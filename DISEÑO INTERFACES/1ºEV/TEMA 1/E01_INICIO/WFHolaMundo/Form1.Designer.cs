namespace WFHolaMundo
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
            this.txtsaludo = new System.Windows.Forms.Label();
            this.btnsaludo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsaludo
            // 
            this.txtsaludo.AutoSize = true;
            this.txtsaludo.Location = new System.Drawing.Point(180, 39);
            this.txtsaludo.Name = "txtsaludo";
            this.txtsaludo.Size = new System.Drawing.Size(0, 15);
            this.txtsaludo.TabIndex = 0;
            this.txtsaludo.Click += new System.EventHandler(this.txtsaludo_Click);
            // 
            // btnsaludo
            // 
            this.btnsaludo.Location = new System.Drawing.Point(189, 190);
            this.btnsaludo.Name = "btnsaludo";
            this.btnsaludo.Size = new System.Drawing.Size(75, 23);
            this.btnsaludo.TabIndex = 1;
            this.btnsaludo.Text = "Saludar";
            this.btnsaludo.UseVisualStyleBackColor = true;
            this.btnsaludo.Click += new System.EventHandler(this.btnsaludo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(189, 231);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 307);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnsaludo);
            this.Controls.Add(this.txtsaludo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtsaludo;
        private Button btnsaludo;
        private Button btnsalir;
    }
}