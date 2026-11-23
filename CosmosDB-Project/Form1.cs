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
        private bool CosmosClientCreation = false;

        private CosmosClient MyCosmosClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDevID.Text = developerID; 
            textBoxDevName.Text = developerFullName;
            textBoxDevEmail.Text = developerEmail;
            btn_CreateCosmosClient.Enabled = false;

        }


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
                CosmosClientCreation = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating Cosmos DB: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btn_CreateDataInCloud_Click(object sender, EventArgs e)
        {
            string dbNameToCreate = textBoxDatabaseNameToCreate.Text;
            string containerNameToCreate = textBoxContainerNameToCreate.Text;
            await createDBandContainerInCloudAsync(dbNameToCreate, containerNameToCreate);
        }

        private async Task createDBandContainerInCloudAsync(string dbNameToCreate, string containerNameToCreate)
        {
            if (CosmosClientCreation == true)
            {
                MessageBox.Show("Creating " + dbNameToCreate + " database and " + containerNameToCreate + " container in the cloud...");
                DatabaseResponse databaseResponse =
                   await MyCosmosClient.CreateDatabaseIfNotExistsAsync(dbNameToCreate);

                System.Net.HttpStatusCode statusCode = databaseResponse.StatusCode;
                if (statusCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Database " + dbNameToCreate + " created successfully in the cloud!");
                }
                else if (statusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Database " + dbNameToCreate + " already exists in the cloud!");
                }

                if (string.IsNullOrEmpty(containerNameToCreate))
                {
                    MessageBox.Show("Container name cannot be empty.");
                    return;
                }

                Database dbObj = databaseResponse.Database;
                ContainerResponse containerResponse =
                    await dbObj.CreateContainerIfNotExistsAsync(containerNameToCreate, "/id");

                statusCode = containerResponse.StatusCode;
                if (statusCode == System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show("Container " + containerNameToCreate + " created successfully in " + dbNameToCreate + "!");
                }
                else if (statusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Container " + containerNameToCreate + " already exists in the cloud!");
                }
            }
            else
            {
                MessageBox.Show("Error!, At first create client connection","Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

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
    }
}
