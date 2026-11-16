using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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
        private string connectionSource = ConfigurationManager.AppSettings["ConnectionSRC"];
        private string cosmosDBURI = ConfigurationManager.AppSettings["URI"];
        private string cosmosDBKey = ConfigurationManager.AppSettings["PrimaryKey"];


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
            textBoxConnectionSRC.Text = connectionSource;
            textBoxPrimaryKey.Text = cosmosDBKey;
            textBoxURI.Text = cosmosDBURI;
        }

        private void btn_CreateCosmosClient_Click(object sender, EventArgs e)
        {
            MyCosmosClient = new CosmosClient(cosmosDBURI, cosmosDBKey);
        }
    }
}
