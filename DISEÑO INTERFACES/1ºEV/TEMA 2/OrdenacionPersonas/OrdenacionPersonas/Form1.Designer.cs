namespace OrdenacionPersonas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.OrdNombre = new System.Windows.Forms.Button();
            this.OrdApellido = new System.Windows.Forms.Button();
            this.OrdEdad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaPersonas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Location = new System.Drawing.Point(45, 227);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(99, 41);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(42, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 289);
            this.panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 23);
            this.textBox1.TabIndex = 6;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Red;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Location = new System.Drawing.Point(172, 227);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(98, 41);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // OrdNombre
            // 
            this.OrdNombre.BackColor = System.Drawing.Color.Cyan;
            this.OrdNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdNombre.Location = new System.Drawing.Point(475, 369);
            this.OrdNombre.Name = "OrdNombre";
            this.OrdNombre.Size = new System.Drawing.Size(75, 31);
            this.OrdNombre.TabIndex = 6;
            this.OrdNombre.Text = "Nombre";
            this.OrdNombre.UseVisualStyleBackColor = false;
            this.OrdNombre.Click += new System.EventHandler(this.OrdNombre_Click);
            // 
            // OrdApellido
            // 
            this.OrdApellido.BackColor = System.Drawing.Color.Cyan;
            this.OrdApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdApellido.Location = new System.Drawing.Point(566, 369);
            this.OrdApellido.Name = "OrdApellido";
            this.OrdApellido.Size = new System.Drawing.Size(75, 31);
            this.OrdApellido.TabIndex = 7;
            this.OrdApellido.Text = "Apellido";
            this.OrdApellido.UseVisualStyleBackColor = false;
            this.OrdApellido.Click += new System.EventHandler(this.OrdApellido_Click);
            // 
            // OrdEdad
            // 
            this.OrdEdad.BackColor = System.Drawing.Color.Cyan;
            this.OrdEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdEdad.Location = new System.Drawing.Point(659, 369);
            this.OrdEdad.Name = "OrdEdad";
            this.OrdEdad.Size = new System.Drawing.Size(75, 31);
            this.OrdEdad.TabIndex = 8;
            this.OrdEdad.Text = "Edad";
            this.OrdEdad.UseVisualStyleBackColor = false;
            this.OrdEdad.Click += new System.EventHandler(this.OrdEdad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ordena lista por:";
            // 
            // ListaPersonas
            // 
            this.ListaPersonas.FormattingEnabled = true;
            this.ListaPersonas.ItemHeight = 15;
            this.ListaPersonas.Location = new System.Drawing.Point(475, 53);
            this.ListaPersonas.Name = "ListaPersonas";
            this.ListaPersonas.Size = new System.Drawing.Size(259, 274);
            this.ListaPersonas.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaPersonas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrdEdad);
            this.Controls.Add(this.OrdApellido);
            this.Controls.Add(this.OrdNombre);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Guardar;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Cancelar;
        private Button OrdNombre;
        private Button OrdApellido;
        private Button OrdEdad;
        private Label label5;
        private ListBox ListaPersonas;
    }
}