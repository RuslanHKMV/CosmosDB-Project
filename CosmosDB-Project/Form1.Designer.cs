namespace CosmosDB_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxConnectionSRC = new System.Windows.Forms.ComboBox();
            this.btn_CreateCosmosClient = new System.Windows.Forms.Button();
            this.textBoxPrimaryKey = new System.Windows.Forms.TextBox();
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDevEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDevName = new System.Windows.Forms.TextBox();
            this.textBoxDevID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_TablesNamesFromCloud = new System.Windows.Forms.ComboBox();
            this.comboBox_DBsNamesFromCloud = new System.Windows.Forms.ComboBox();
            this.btn_GetTablesNamesFromCloud = new System.Windows.Forms.Button();
            this.btn_GetDBsNamesFromCloud = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CreateDataInCloud = new System.Windows.Forms.Button();
            this.textBoxContainerNameToCreate = new System.Windows.Forms.TextBox();
            this.textBoxDatabaseNameToCreate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_CountDBsInCloud = new System.Windows.Forms.Button();
            this.btn_CountTablesInCloud = new System.Windows.Forms.Button();
            this.textBox_DBsCount = new System.Windows.Forms.TextBox();
            this.textBox_TablesCount = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1378, 744);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1370, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Details and Cosmos Client Creation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxConnectionSRC);
            this.groupBox2.Controls.Add(this.btn_CreateCosmosClient);
            this.groupBox2.Controls.Add(this.textBoxPrimaryKey);
            this.groupBox2.Controls.Add(this.textBoxURI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(703, 3);
            this.groupBox2.MaximumSize = new System.Drawing.Size(700, 700);
            this.groupBox2.MinimumSize = new System.Drawing.Size(700, 700);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 700);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Azure Connection Details";
            // 
            // comboBoxConnectionSRC
            // 
            this.comboBoxConnectionSRC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionSRC.FormattingEnabled = true;
            this.comboBoxConnectionSRC.Items.AddRange(new object[] {
            "Emulator",
            "Azure Portal"});
            this.comboBoxConnectionSRC.Location = new System.Drawing.Point(271, 87);
            this.comboBoxConnectionSRC.Name = "comboBoxConnectionSRC";
            this.comboBoxConnectionSRC.Size = new System.Drawing.Size(362, 37);
            this.comboBoxConnectionSRC.TabIndex = 11;
            this.comboBoxConnectionSRC.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnectionSRC_SelectedIndexChanged);
            // 
            // btn_CreateCosmosClient
            // 
            this.btn_CreateCosmosClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateCosmosClient.Location = new System.Drawing.Point(130, 426);
            this.btn_CreateCosmosClient.Name = "btn_CreateCosmosClient";
            this.btn_CreateCosmosClient.Size = new System.Drawing.Size(407, 106);
            this.btn_CreateCosmosClient.TabIndex = 10;
            this.btn_CreateCosmosClient.Text = "Create Cosmos Client";
            this.btn_CreateCosmosClient.UseVisualStyleBackColor = true;
            this.btn_CreateCosmosClient.Click += new System.EventHandler(this.btn_CreateCosmosClient_Click);
            // 
            // textBoxPrimaryKey
            // 
            this.textBoxPrimaryKey.Location = new System.Drawing.Point(271, 224);
            this.textBoxPrimaryKey.Name = "textBoxPrimaryKey";
            this.textBoxPrimaryKey.ReadOnly = true;
            this.textBoxPrimaryKey.Size = new System.Drawing.Size(362, 35);
            this.textBoxPrimaryKey.TabIndex = 10;
            this.textBoxPrimaryKey.WordWrap = false;
            // 
            // textBoxURI
            // 
            this.textBoxURI.Location = new System.Drawing.Point(271, 155);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.ReadOnly = true;
            this.textBoxURI.Size = new System.Drawing.Size(362, 35);
            this.textBoxURI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primary Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Point URI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connection Source";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxDevEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDevName);
            this.groupBox1.Controls.Add(this.textBoxDevID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(700, 700);
            this.groupBox1.MinimumSize = new System.Drawing.Size(700, 700);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 700);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User\'s Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDevEmail
            // 
            this.textBoxDevEmail.Location = new System.Drawing.Point(290, 224);
            this.textBoxDevEmail.Name = "textBoxDevEmail";
            this.textBoxDevEmail.ReadOnly = true;
            this.textBoxDevEmail.Size = new System.Drawing.Size(378, 35);
            this.textBoxDevEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Developer E-Mail";
            // 
            // textBoxDevName
            // 
            this.textBoxDevName.Location = new System.Drawing.Point(290, 156);
            this.textBoxDevName.Name = "textBoxDevName";
            this.textBoxDevName.ReadOnly = true;
            this.textBoxDevName.Size = new System.Drawing.Size(378, 35);
            this.textBoxDevName.TabIndex = 7;
            // 
            // textBoxDevID
            // 
            this.textBoxDevID.Location = new System.Drawing.Point(290, 87);
            this.textBoxDevID.Name = "textBoxDevID";
            this.textBoxDevID.ReadOnly = true;
            this.textBoxDevID.Size = new System.Drawing.Size(378, 35);
            this.textBoxDevID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Developer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developer ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1370, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dabases and Containers";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_TablesCount);
            this.groupBox4.Controls.Add(this.textBox_DBsCount);
            this.groupBox4.Controls.Add(this.btn_CountTablesInCloud);
            this.groupBox4.Controls.Add(this.btn_CountDBsInCloud);
            this.groupBox4.Controls.Add(this.comboBox_TablesNamesFromCloud);
            this.groupBox4.Controls.Add(this.comboBox_DBsNamesFromCloud);
            this.groupBox4.Controls.Add(this.btn_GetTablesNamesFromCloud);
            this.groupBox4.Controls.Add(this.btn_GetDBsNamesFromCloud);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(21, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1330, 398);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Databases and Tables in Cloud";
            // 
            // comboBox_TablesNamesFromCloud
            // 
            this.comboBox_TablesNamesFromCloud.FormattingEnabled = true;
            this.comboBox_TablesNamesFromCloud.Location = new System.Drawing.Point(529, 254);
            this.comboBox_TablesNamesFromCloud.Name = "comboBox_TablesNamesFromCloud";
            this.comboBox_TablesNamesFromCloud.Size = new System.Drawing.Size(325, 37);
            this.comboBox_TablesNamesFromCloud.TabIndex = 13;
            // 
            // comboBox_DBsNamesFromCloud
            // 
            this.comboBox_DBsNamesFromCloud.FormattingEnabled = true;
            this.comboBox_DBsNamesFromCloud.Location = new System.Drawing.Point(431, 110);
            this.comboBox_DBsNamesFromCloud.Name = "comboBox_DBsNamesFromCloud";
            this.comboBox_DBsNamesFromCloud.Size = new System.Drawing.Size(423, 37);
            this.comboBox_DBsNamesFromCloud.TabIndex = 12;
            // 
            // btn_GetTablesNamesFromCloud
            // 
            this.btn_GetTablesNamesFromCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GetTablesNamesFromCloud.Location = new System.Drawing.Point(16, 247);
            this.btn_GetTablesNamesFromCloud.Name = "btn_GetTablesNamesFromCloud";
            this.btn_GetTablesNamesFromCloud.Size = new System.Drawing.Size(471, 53);
            this.btn_GetTablesNamesFromCloud.TabIndex = 11;
            this.btn_GetTablesNamesFromCloud.Text = "Count Tables In Every DB from Cloud";
            this.btn_GetTablesNamesFromCloud.UseVisualStyleBackColor = true;
            this.btn_GetTablesNamesFromCloud.Click += new System.EventHandler(this.btn_GetTablesNamesFromCloud_Click);
            // 
            // btn_GetDBsNamesFromCloud
            // 
            this.btn_GetDBsNamesFromCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GetDBsNamesFromCloud.Location = new System.Drawing.Point(16, 101);
            this.btn_GetDBsNamesFromCloud.Name = "btn_GetDBsNamesFromCloud";
            this.btn_GetDBsNamesFromCloud.Size = new System.Drawing.Size(389, 57);
            this.btn_GetDBsNamesFromCloud.TabIndex = 10;
            this.btn_GetDBsNamesFromCloud.Text = "Get DBs Names from Cloud";
            this.btn_GetDBsNamesFromCloud.UseVisualStyleBackColor = true;
            this.btn_GetDBsNamesFromCloud.Click += new System.EventHandler(this.btn_GetDBsNamesFromCloud_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CreateDataInCloud);
            this.groupBox3.Controls.Add(this.textBoxContainerNameToCreate);
            this.groupBox3.Controls.Add(this.textBoxDatabaseNameToCreate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(21, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1330, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Entities in Cloud";
            // 
            // btn_CreateDataInCloud
            // 
            this.btn_CreateDataInCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateDataInCloud.Location = new System.Drawing.Point(490, 175);
            this.btn_CreateDataInCloud.Name = "btn_CreateDataInCloud";
            this.btn_CreateDataInCloud.Size = new System.Drawing.Size(346, 62);
            this.btn_CreateDataInCloud.TabIndex = 10;
            this.btn_CreateDataInCloud.Text = "Create Data in Cloud";
            this.btn_CreateDataInCloud.UseVisualStyleBackColor = true;
            this.btn_CreateDataInCloud.Click += new System.EventHandler(this.btn_CreateDataInCloud_Click);
            // 
            // textBoxContainerNameToCreate
            // 
            this.textBoxContainerNameToCreate.Location = new System.Drawing.Point(835, 84);
            this.textBoxContainerNameToCreate.Name = "textBoxContainerNameToCreate";
            this.textBoxContainerNameToCreate.Size = new System.Drawing.Size(362, 35);
            this.textBoxContainerNameToCreate.TabIndex = 9;
            // 
            // textBoxDatabaseNameToCreate
            // 
            this.textBoxDatabaseNameToCreate.Location = new System.Drawing.Point(271, 87);
            this.textBoxDatabaseNameToCreate.Name = "textBoxDatabaseNameToCreate";
            this.textBoxDatabaseNameToCreate.Size = new System.Drawing.Size(362, 35);
            this.textBoxDatabaseNameToCreate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(669, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Container";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Database";
            // 
            // btn_CountDBsInCloud
            // 
            this.btn_CountDBsInCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CountDBsInCloud.Location = new System.Drawing.Point(891, 106);
            this.btn_CountDBsInCloud.Name = "btn_CountDBsInCloud";
            this.btn_CountDBsInCloud.Size = new System.Drawing.Size(271, 46);
            this.btn_CountDBsInCloud.TabIndex = 14;
            this.btn_CountDBsInCloud.Text = "Count DBs In Cloud";
            this.btn_CountDBsInCloud.UseVisualStyleBackColor = true;
            this.btn_CountDBsInCloud.Click += new System.EventHandler(this.btn_CountDBsInCloud_Click);
            // 
            // btn_CountTablesInCloud
            // 
            this.btn_CountTablesInCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CountTablesInCloud.Location = new System.Drawing.Point(891, 243);
            this.btn_CountTablesInCloud.Name = "btn_CountTablesInCloud";
            this.btn_CountTablesInCloud.Size = new System.Drawing.Size(271, 57);
            this.btn_CountTablesInCloud.TabIndex = 15;
            this.btn_CountTablesInCloud.Text = "Count Tables In Cloud";
            this.btn_CountTablesInCloud.UseVisualStyleBackColor = true;
            this.btn_CountTablesInCloud.Click += new System.EventHandler(this.btn_CountTablesInCloud_Click);
            // 
            // textBox_DBsCount
            // 
            this.textBox_DBsCount.Location = new System.Drawing.Point(1181, 112);
            this.textBox_DBsCount.Name = "textBox_DBsCount";
            this.textBox_DBsCount.Size = new System.Drawing.Size(126, 35);
            this.textBox_DBsCount.TabIndex = 11;
            // 
            // textBox_TablesCount
            // 
            this.textBox_TablesCount.Location = new System.Drawing.Point(1181, 254);
            this.textBox_TablesCount.Name = "textBox_TablesCount";
            this.textBox_TablesCount.Size = new System.Drawing.Size(126, 35);
            this.textBox_TablesCount.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "Form1";
            this.Text = "CosmosDB Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrimaryKey;
        private System.Windows.Forms.TextBox textBoxURI;
        private System.Windows.Forms.TextBox textBoxDevID;
        private System.Windows.Forms.TextBox textBoxDevName;
        private System.Windows.Forms.TextBox textBoxDevEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CreateCosmosClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_CreateDataInCloud;
        private System.Windows.Forms.TextBox textBoxContainerNameToCreate;
        private System.Windows.Forms.TextBox textBoxDatabaseNameToCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxConnectionSRC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_GetTablesNamesFromCloud;
        private System.Windows.Forms.Button btn_GetDBsNamesFromCloud;
        private System.Windows.Forms.ComboBox comboBox_TablesNamesFromCloud;
        private System.Windows.Forms.ComboBox comboBox_DBsNamesFromCloud;
        private System.Windows.Forms.TextBox textBox_TablesCount;
        private System.Windows.Forms.TextBox textBox_DBsCount;
        private System.Windows.Forms.Button btn_CountTablesInCloud;
        private System.Windows.Forms.Button btn_CountDBsInCloud;
    }
}

