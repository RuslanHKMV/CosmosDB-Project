using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Cosmos;

namespace CosmosDB_Project
{
    public partial class Form1 : Form
    {
        
        //get the developer ID and full name from the app.config file
        private string developerID = ConfigurationManager.AppSettings["DeveloperID"];
        private string developerFullName = ConfigurationManager.AppSettings["DeveloperFullName"];
        private string developerEmail = ConfigurationManager.AppSettings["DeveloperEmail"];
        //get the Cosmos DB connection data from the app.config file
        private string connectionSourceE = ConfigurationManager.AppSettings["ConnectionSRCE"];
        private string cosmosDBURIE = ConfigurationManager.AppSettings["URIE"];
        private string cosmosDBKeyE = ConfigurationManager.AppSettings["PrimaryKeyE"];

        private string connectionSourceP = ConfigurationManager.AppSettings["ConnectionSRCP"];
        private string cosmosDBURIP = ConfigurationManager.AppSettings["URIP"];
        private string cosmosDBKeyP = ConfigurationManager.AppSettings["PrimaryKeyP"];

        private string DB_URI;
        private string DB_Key;
        

        private CosmosClient MyCosmosClient;
        public Form1()
        {
            InitializeComponent();
        }
        //Event handler for the Form1 load event
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDevID.Text = developerID; 
            textBoxDevName.Text = developerFullName;
            textBoxDevEmail.Text = developerEmail;
            btn_CreateCosmosClient.Enabled = false;

        }

        //Event handler for the btn_CreateCosmosClient button click event
        private async void btn_CreateCosmosClient_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxConnectionSRC.SelectedItem?.ToString() == "Emulator")
                {
                    CosmosClientOptions options = new CosmosClientOptions
                    {
                        ConnectionMode = ConnectionMode.Gateway,
                        LimitToEndpoint = true
                    };

                    MyCosmosClient = new CosmosClient(cosmosDBURIE, cosmosDBKeyE, options);
                }
                else if (comboBoxConnectionSRC.SelectedItem?.ToString() == "Azure Portal")
                {
                  
                }

                

                MessageBox.Show("Cosmos Client and database created successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btn_CreateCosmosClient.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating Cosmos DB: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //Event handler for the btn_CreateDataInCloud button click event
        private async void btn_CreateDataInCloud_Click(object sender, EventArgs e)
        {
            if (MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string dbNameToCreate = textBoxDatabaseNameToCreate.Text;
            string containerNameToCreate = textBoxContainerNameToCreate.Text;
            if (string.IsNullOrEmpty(dbNameToCreate))
            {
                MessageBox.Show("Database name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(containerNameToCreate))
            {
                MessageBox.Show("Container name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await createDBandContainerInCloudAsync(dbNameToCreate, containerNameToCreate);
        }
        //create a database and a container in the cloud account.
        private async Task createDBandContainerInCloudAsync(string dbNameToCreate, string containerNameToCreate)
        {
            //MessageBox.Show("Creating " + dbNameToCreate + " database and " + containerNameToCreate + " container in the cloud...");
            DatabaseResponse databaseResponse =
               await MyCosmosClient.CreateDatabaseIfNotExistsAsync(dbNameToCreate);

            System.Net.HttpStatusCode statusCode = databaseResponse.StatusCode;
            if (statusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Database " + dbNameToCreate + " created successfully in the cloud!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (statusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Database " + dbNameToCreate + " already exists in the cloud!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Database dbObj = databaseResponse.Database;
            ContainerResponse containerResponse =
                await dbObj.CreateContainerIfNotExistsAsync(containerNameToCreate, "/id");

            statusCode = containerResponse.StatusCode;
            if (statusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Container " + containerNameToCreate + " created successfully in " + dbNameToCreate + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (statusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Container " + containerNameToCreate + " already exists in " + dbNameToCreate + "!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Event handler for the comboBoxConnectionSRC selection change event
        private void comboBoxConnectionSRC_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            btn_CreateCosmosClient.Enabled = false;
            if (comboBoxConnectionSRC.SelectedItem?.ToString() == "Emulator")
            {   
                DB_URI= ConfigurationManager.AppSettings["URIE"];
                DB_Key= ConfigurationManager.AppSettings["PrimaryKeyE"];
                textBoxURI.Text = DB_URI;
                textBoxPrimaryKey.Text = DB_Key;
            }
            else if (comboBoxConnectionSRC.SelectedItem?.ToString() == "Azure Portal")
            {
                DB_URI = ConfigurationManager.AppSettings["URIP"];
                DB_Key = ConfigurationManager.AppSettings["PrimaryKeyP"];
                textBoxURI.Text = DB_URI;
                textBoxPrimaryKey.Text = DB_Key;
            }
            btn_CreateCosmosClient.Enabled = true;
        }

        //get the names of the databases in the cloud account.
        private async void btn_GetDBsNamesFromCloud_Click(object sender, EventArgs e)
        {
            if (MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboBox_DBsNamesFromCloud.DataSource = await getDBsNamesFromCloudAccountAsync();
        }
        private async Task<List<string>> getDBsNamesFromCloudAccountAsync()
        {
            List <string> dbNamesList = new List<string>();
            FeedIterator<DatabaseProperties> dbIterator =
                MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            { 
                     foreach (DatabaseProperties dbProp in await dbIterator.ReadNextAsync())
                     {
                         dbNamesList.Add(dbProp.Id);
                     }
            }
            return dbNamesList;
        }

        //get the number of databases in the cloud account.
        private async void btn_CountDBsInCloud_Click(object sender, EventArgs e)
        {
            if (MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numberOfDBs = await CountDBsInCloudAccountAsync();
            textBox_DBsCount.Text = numberOfDBs.ToString();
        }
        private async Task<int> CountDBsInCloudAccountAsync()
        {
            int dbCount = 0;
            FeedIterator<DatabaseProperties> dbIterator =
               MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties dbProp in await dbIterator.ReadNextAsync())
                    dbCount++;
            }
            return dbCount;
        }

        //get the number of the tables in the specified database.
        //With the format: DatabaseName.TableName.
        private async void btn_GetTablesNamesFromCloud_Click(object sender, EventArgs e)
        {
            if (MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboBox_TablesNamesFromCloud.DataSource = await getTablesNamesFromCloudAccountAsync();
        }
        private async Task<List<string>> getTablesNamesFromCloudAccountAsync()
        {
            List<string> dbNames = new List<string>();
            FeedIterator<DatabaseProperties> dbIterator =
                MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties dbProp in await dbIterator.ReadNextAsync())
                {
                    Database databaseRefObj = MyCosmosClient.GetDatabase(dbProp.Id);
                    FeedIterator<ContainerProperties> tablesIterator =
                        databaseRefObj.GetContainerQueryIterator<ContainerProperties>();
                    int tableCount = 0;
                    while (tablesIterator.HasMoreResults)
                    {
                        foreach (ContainerProperties tableProp in await tablesIterator.ReadNextAsync())
                        {
                            tableCount++;
                        }
                    }
                    dbNames.Add($"{dbProp.Id} = {tableCount} Tables");
                }
            }
            return dbNames;
        }


        //get the number of tables in the cloud account.
        private async void btn_CountTablesInCloud_Click(object sender, EventArgs e)
        {
            if (MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numberOfTables = await CountTablesInCloudAccountAsync();
            textBox_TablesCount.Text = numberOfTables.ToString();
        }
        private async Task<int> CountTablesInCloudAccountAsync()
        {
            int tableCount = 0;
            FeedIterator<DatabaseProperties> dbIterator =
                MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties dbProp in await dbIterator.ReadNextAsync())
                {
                    Database databaseRefObj = MyCosmosClient.GetDatabase(dbProp.Id);
                    FeedIterator<ContainerProperties> tablesIterator =
                        databaseRefObj.GetContainerQueryIterator<ContainerProperties>();
                    while (tablesIterator.HasMoreResults)
                    {
                        foreach (ContainerProperties tableProp in await tablesIterator.ReadNextAsync())
                        {
                            tableCount++;
                        }
                    }
                }
            }
            return tableCount;
        }

        //Event handler for the btn_getDBsT9 button click event
        private async void btn_getDBsT9_Click(object sender, EventArgs e)
        {
            
            comboBox_ResultT9.DataSource = null;
            //Read the info from screen.
            string userPrefix = textBox_PrefixStrT9.Text;
            if (userPrefix.Length == 0)
            {
                MessageBox.Show("Please enter a prefix string to search for databases.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboBox_ResultT9.DataSource = await getDBsNamesWithPrefixT7Async(userPrefix);
            if (comboBox_ResultT9.Items.Count == 0)
            {
                MessageBox.Show("No databases found with the specified prefix.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<List<string>> getDBsNamesWithPrefixT7Async(string userPrefix)
        {
            List<string> dbNamesList = new List<string>();
            FeedIterator<DatabaseProperties> dbIterator =
                MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties dbProp in await dbIterator.ReadNextAsync())
                {
                    if(dbProp.Id.StartsWith(userPrefix))
                    {
                        dbNamesList.Add(dbProp.Id);
                    }
                }
            }
            return dbNamesList;
        }
        //Event handler for the btn_CheckIfExist button click event
        private void btn_CheckIfExist_Click(object sender, EventArgs e)
        {
            string userInput = textBox_IDInput.Text;
            if(string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a database name to check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MyCosmosClient != null)
            {
                CheckDatabaseExistenceAsync(userInput);
            }
            else
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckDatabaseExistenceAsync(string userInput)
        {
            FeedIterator<DatabaseProperties> dbIterator =
                MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties dbProp in  dbIterator.ReadNextAsync().Result)
                {
                    if (dbProp.Id.CompareTo(userInput) == 0)
                    {
                        MessageBox.Show("Database exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            MessageBox.Show("Database does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Event handler for the btn_GetDBsWithTable button click event
        private async void btn_GetDBsWithTable_Click(object sender, EventArgs e)
        {
            if(MyCosmosClient == null)
            {
                MessageBox.Show("Cosmos Client is not created. Please create the client first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userInputTableName = textBox_FindDBWithTableInput.Text;
            comboBox_GetDBsWithTable.DataSource = await getDBsWithTableAsync(userInputTableName);
        }

        private async Task<List<string >> getDBsWithTableAsync(string userInputTableName)
        {
            List<string> dbNames = new List<string>();
            FeedIterator<DatabaseProperties> dbIterator =
                MyCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties dbProp in await dbIterator.ReadNextAsync())
                {
                    Database databaseRefObj = MyCosmosClient.GetDatabase(dbProp.Id);
                    FeedIterator<ContainerProperties> tablesIterator =
                        databaseRefObj.GetContainerQueryIterator<ContainerProperties>();
                    while (tablesIterator.HasMoreResults)
                    {
                        foreach (ContainerProperties tableProp in await tablesIterator.ReadNextAsync())
                        {
                            if(tableProp.Id.CompareTo(userInputTableName) == 0)
                            {
                                dbNames.Add(dbProp.Id);
                            }
                        }
                    }
                    
                }
            }
            if (dbNames.Count == 0)
            {
                dbNames.Add("No databases found with the specified table.");
            }
            return dbNames;
        }
    }

}