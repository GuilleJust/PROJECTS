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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Volver = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SQLServer = new System.Windows.Forms.Button();
            this.MySQL = new System.Windows.Forms.Button();
            this.Adapter = new System.Windows.Forms.Button();
            this.SQLite = new System.Windows.Forms.Button();
            this.NuevoContacto = new System.Windows.Forms.Button();
            this.ActivarConexion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gestorElegido = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 171);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = "";
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(598, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Volver);
            this.tabPage2.Controls.Add(this.Eliminar);
            this.tabPage2.Controls.Add(this.Guardar);
            this.tabPage2.Controls.Add(this.textNombre);
            this.tabPage2.Controls.Add(this.textTelefono);
            this.tabPage2.Controls.Add(this.textApellido);
            this.tabPage2.Controls.Add(this.textID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contacto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(507, 161);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 39);
            this.Volver.TabIndex = 10;
            this.Volver.Text = "Volver al Listado";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(507, 92);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 39);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(507, 33);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 39);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(207, 89);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(145, 23);
            this.textNombre.TabIndex = 7;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(208, 182);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(144, 23);
            this.textTelefono.TabIndex = 6;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(208, 135);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(144, 23);
            this.textApellido.TabIndex = 5;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(208, 48);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(118, 23);
            this.textID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // SQLServer
            // 
            this.SQLServer.Location = new System.Drawing.Point(0, 22);
            this.SQLServer.Name = "SQLServer";
            this.SQLServer.Size = new System.Drawing.Size(75, 47);
            this.SQLServer.TabIndex = 8;
            this.SQLServer.Text = "SQLServer";
            this.SQLServer.UseVisualStyleBackColor = true;
            this.SQLServer.Click += new System.EventHandler(this.SQLServer_Click);
            // 
            // MySQL
            // 
            this.MySQL.Location = new System.Drawing.Point(94, 22);
            this.MySQL.Name = "MySQL";
            this.MySQL.Size = new System.Drawing.Size(75, 47);
            this.MySQL.TabIndex = 9;
            this.MySQL.Text = "MySQL";
            this.MySQL.UseVisualStyleBackColor = true;
            this.MySQL.Click += new System.EventHandler(this.MySQL_Click);
            // 
            // Adapter
            // 
            this.Adapter.Location = new System.Drawing.Point(344, 22);
            this.Adapter.Name = "Adapter";
            this.Adapter.Size = new System.Drawing.Size(75, 47);
            this.Adapter.TabIndex = 10;
            this.Adapter.Text = "ADAPTER";
            this.Adapter.UseVisualStyleBackColor = true;
            this.Adapter.Click += new System.EventHandler(this.Adapter_Click);
            // 
            // SQLite
            // 
            this.SQLite.Location = new System.Drawing.Point(187, 22);
            this.SQLite.Name = "SQLite";
            this.SQLite.Size = new System.Drawing.Size(75, 47);
            this.SQLite.TabIndex = 11;
            this.SQLite.Text = "SQLite";
            this.SQLite.UseVisualStyleBackColor = true;
            this.SQLite.Click += new System.EventHandler(this.SQLite_Click);
            // 
            // NuevoContacto
            // 
            this.NuevoContacto.Location = new System.Drawing.Point(689, 228);
            this.NuevoContacto.Name = "NuevoContacto";
            this.NuevoContacto.Size = new System.Drawing.Size(75, 61);
            this.NuevoContacto.TabIndex = 12;
            this.NuevoContacto.Text = "Nuevo Contacto";
            this.NuevoContacto.UseVisualStyleBackColor = true;
            this.NuevoContacto.Click += new System.EventHandler(this.NuevoContacto_Click);
            // 
            // ActivarConexion
            // 
            this.ActivarConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ActivarConexion.Location = new System.Drawing.Point(614, 32);
            this.ActivarConexion.Name = "ActivarConexion";
            this.ActivarConexion.Size = new System.Drawing.Size(174, 47);
            this.ActivarConexion.TabIndex = 13;
            this.ActivarConexion.Text = "Conectar con otro SGBD";
            this.ActivarConexion.UseVisualStyleBackColor = false;
            this.ActivarConexion.Click += new System.EventHandler(this.ActivarConexion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.SQLite);
            this.groupBox1.Controls.Add(this.MySQL);
            this.groupBox1.Controls.Add(this.SQLServer);
            this.groupBox1.Controls.Add(this.Adapter);
            this.groupBox1.Location = new System.Drawing.Point(22, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 80);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "SGBD:";
            // 
            // gestorElegido
            // 
            this.gestorElegido.AutoSize = true;
            this.gestorElegido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gestorElegido.Location = new System.Drawing.Point(116, 112);
            this.gestorElegido.Name = "gestorElegido";
            this.gestorElegido.Size = new System.Drawing.Size(0, 32);
            this.gestorElegido.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gestorElegido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ActivarConexion);
            this.Controls.Add(this.NuevoContacto);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TextBox textNombre;
        private TextBox textTelefono;
        private TextBox textApellido;
        private TextBox textID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Volver;
        private Button Eliminar;
        private Button Guardar;
        private Button SQLServer;
        private Button MySQL;
        private Button Adapter;
        private Button SQLite;
        private Button NuevoContacto;
        private Button ActivarConexion;
        private GroupBox groupBox1;
        private Label label5;
        private Label gestorElegido;
    }
}