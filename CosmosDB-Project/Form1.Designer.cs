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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDevID = new System.Windows.Forms.TextBox();
            this.textBoxDevName = new System.Windows.Forms.TextBox();
            this.textBoxConnectionSRC = new System.Windows.Forms.TextBox();
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.textBoxPrimaryKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDevEmail = new System.Windows.Forms.TextBox();
            this.btn_CreateCosmosClient = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1370, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Details and Cosmos Client Creation";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1470, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox1
            // 
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CreateCosmosClient);
            this.groupBox2.Controls.Add(this.textBoxPrimaryKey);
            this.groupBox2.Controls.Add(this.textBoxURI);
            this.groupBox2.Controls.Add(this.textBoxConnectionSRC);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connection Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Developer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Point URI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Primary Key";
            // 
            // textBoxDevID
            // 
            this.textBoxDevID.Location = new System.Drawing.Point(266, 142);
            this.textBoxDevID.Name = "textBoxDevID";
            this.textBoxDevID.ReadOnly = true;
            this.textBoxDevID.Size = new System.Drawing.Size(378, 35);
            this.textBoxDevID.TabIndex = 6;
            // 
            // textBoxDevName
            // 
            this.textBoxDevName.Location = new System.Drawing.Point(266, 211);
            this.textBoxDevName.Name = "textBoxDevName";
            this.textBoxDevName.ReadOnly = true;
            this.textBoxDevName.Size = new System.Drawing.Size(378, 35);
            this.textBoxDevName.TabIndex = 7;
            // 
            // textBoxConnectionSRC
            // 
            this.textBoxConnectionSRC.Location = new System.Drawing.Point(273, 142);
            this.textBoxConnectionSRC.Name = "textBoxConnectionSRC";
            this.textBoxConnectionSRC.Size = new System.Drawing.Size(362, 35);
            this.textBoxConnectionSRC.TabIndex = 8;
            // 
            // textBoxURI
            // 
            this.textBoxURI.Location = new System.Drawing.Point(273, 210);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.Size = new System.Drawing.Size(362, 35);
            this.textBoxURI.TabIndex = 9;
            // 
            // textBoxPrimaryKey
            // 
            this.textBoxPrimaryKey.Location = new System.Drawing.Point(273, 279);
            this.textBoxPrimaryKey.Name = "textBoxPrimaryKey";
            this.textBoxPrimaryKey.Size = new System.Drawing.Size(362, 35);
            this.textBoxPrimaryKey.TabIndex = 10;
            this.textBoxPrimaryKey.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Developer E-Mail";
            // 
            // textBoxDevEmail
            // 
            this.textBoxDevEmail.Location = new System.Drawing.Point(266, 279);
            this.textBoxDevEmail.Name = "textBoxDevEmail";
            this.textBoxDevEmail.ReadOnly = true;
            this.textBoxDevEmail.Size = new System.Drawing.Size(378, 35);
            this.textBoxDevEmail.TabIndex = 9;
            // 
            // btn_CreateCosmosClient
            // 
            this.btn_CreateCosmosClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateCosmosClient.Location = new System.Drawing.Point(132, 481);
            this.btn_CreateCosmosClient.Name = "btn_CreateCosmosClient";
            this.btn_CreateCosmosClient.Size = new System.Drawing.Size(407, 106);
            this.btn_CreateCosmosClient.TabIndex = 10;
            this.btn_CreateCosmosClient.Text = "Create Cosmos Client";
            this.btn_CreateCosmosClient.UseVisualStyleBackColor = true;
            this.btn_CreateCosmosClient.Click += new System.EventHandler(this.btn_CreateCosmosClient_Click);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxConnectionSRC;
        private System.Windows.Forms.TextBox textBoxDevID;
        private System.Windows.Forms.TextBox textBoxDevName;
        private System.Windows.Forms.TextBox textBoxDevEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CreateCosmosClient;
    }
}

