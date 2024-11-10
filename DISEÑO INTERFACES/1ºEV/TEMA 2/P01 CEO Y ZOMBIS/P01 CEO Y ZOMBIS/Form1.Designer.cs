namespace P01_CEO_Y_ZOMBIS
{
    partial class imagen
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
            this.bienvenida = new System.Windows.Forms.Button();
            this.Disminuir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bienestar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bienvenida
            // 
            this.bienvenida.Location = new System.Drawing.Point(12, 37);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(103, 109);
            this.bienvenida.TabIndex = 0;
            this.bienvenida.Text = "¡Bienvenid@ nuevo CEO!";
            this.bienvenida.UseVisualStyleBackColor = true;
            this.bienvenida.Click += new System.EventHandler(this.bienvenida_Click);
            // 
            // Disminuir
            // 
            this.Disminuir.Location = new System.Drawing.Point(121, 37);
            this.Disminuir.Name = "Disminuir";
            this.Disminuir.Size = new System.Drawing.Size(102, 109);
            this.Disminuir.TabIndex = 1;
            this.Disminuir.UseVisualStyleBackColor = true;
            this.Disminuir.Click += new System.EventHandler(this.Disminuir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 109);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienestar:";
            // 
            // Bienestar
            // 
            this.Bienestar.AutoSize = true;
            this.Bienestar.Location = new System.Drawing.Point(692, 131);
            this.Bienestar.Name = "Bienestar";
            this.Bienestar.Size = new System.Drawing.Size(0, 15);
            this.Bienestar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(668, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 335);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::P01_CEO_Y_ZOMBIS.Properties.Resources.fondoInversores;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bienestar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Disminuir);
            this.Controls.Add(this.bienvenida);
            this.Name = "imagen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bienvenida;
        private Button Disminuir;
        private Button button3;
        private Label label1;
        private Label Bienestar;
        private PictureBox pictureBox1;
    }
}