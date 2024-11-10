namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MySQL = new System.Windows.Forms.Button();
            this.MySQLServer = new System.Windows.Forms.Button();
            this.MySQLLite = new System.Windows.Forms.Button();
            this.Adapter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(485, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // MySQL
            // 
            this.MySQL.Location = new System.Drawing.Point(644, 67);
            this.MySQL.Name = "MySQL";
            this.MySQL.Size = new System.Drawing.Size(90, 43);
            this.MySQL.TabIndex = 1;
            this.MySQL.Text = "MySQL";
            this.MySQL.UseVisualStyleBackColor = true;
            this.MySQL.Click += new System.EventHandler(this.MySQL_Click);
            // 
            // MySQLServer
            // 
            this.MySQLServer.Location = new System.Drawing.Point(644, 132);
            this.MySQLServer.Name = "MySQLServer";
            this.MySQLServer.Size = new System.Drawing.Size(90, 52);
            this.MySQLServer.TabIndex = 2;
            this.MySQLServer.Text = "MySQLServer";
            this.MySQLServer.UseVisualStyleBackColor = true;
            this.MySQLServer.Click += new System.EventHandler(this.MySQLServer_Click);
            // 
            // MySQLLite
            // 
            this.MySQLLite.Location = new System.Drawing.Point(644, 206);
            this.MySQLLite.Name = "MySQLLite";
            this.MySQLLite.Size = new System.Drawing.Size(90, 48);
            this.MySQLLite.TabIndex = 3;
            this.MySQLLite.Text = "MySQLLite";
            this.MySQLLite.UseVisualStyleBackColor = true;
            this.MySQLLite.Click += new System.EventHandler(this.MySQLLite_Click);
            // 
            // Adapter
            // 
            this.Adapter.Location = new System.Drawing.Point(644, 276);
            this.Adapter.Name = "Adapter";
            this.Adapter.Size = new System.Drawing.Size(90, 49);
            this.Adapter.TabIndex = 4;
            this.Adapter.Text = "ADAPTER";
            this.Adapter.UseVisualStyleBackColor = true;
            this.Adapter.Click += new System.EventHandler(this.Adapter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adapter);
            this.Controls.Add(this.MySQLLite);
            this.Controls.Add(this.MySQLServer);
            this.Controls.Add(this.MySQL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button MySQL;
        private Button MySQLServer;
        private Button MySQLLite;
        private Button Adapter;
    }
}