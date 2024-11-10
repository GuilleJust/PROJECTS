namespace Presentacion
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.btnCambiarPrecio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(478, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categorias:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(90, 54);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(297, 23);
            this.TxtBuscar.TabIndex = 3;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Items.AddRange(new object[] {
            "Beverages",
            "Condiments",
            "Confections",
            "Dairy Products",
            "Grains/Cereals",
            "Meat/Poultry",
            "Produce",
            "Seafood"});
            this.comboBoxCategorias.Location = new System.Drawing.Point(571, 56);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(188, 23);
            this.comboBoxCategorias.TabIndex = 4;
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToOrderColumns = true;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(25, 85);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.RowTemplate.Height = 25;
            this.DGVProductos.Size = new System.Drawing.Size(743, 238);
            this.DGVProductos.TabIndex = 5;
            this.DGVProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellContentDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(322, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio Unidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Proveedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(116, 341);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(123, 23);
            this.TxtID.TabIndex = 10;
            // 
            // TxtPrecioUnidad
            // 
            this.TxtPrecioUnidad.Location = new System.Drawing.Point(438, 343);
            this.TxtPrecioUnidad.Name = "TxtPrecioUnidad";
            this.TxtPrecioUnidad.Size = new System.Drawing.Size(123, 23);
            this.TxtPrecioUnidad.TabIndex = 11;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(116, 422);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(123, 23);
            this.TxtProveedor.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(116, 381);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(123, 23);
            this.TxtNombre.TabIndex = 13;
            // 
            // btnCambiarPrecio
            // 
            this.btnCambiarPrecio.Location = new System.Drawing.Point(393, 400);
            this.btnCambiarPrecio.Name = "btnCambiarPrecio";
            this.btnCambiarPrecio.Size = new System.Drawing.Size(99, 38);
            this.btnCambiarPrecio.TabIndex = 14;
            this.btnCambiarPrecio.Text = "Cambiar Precio";
            this.btnCambiarPrecio.UseVisualStyleBackColor = true;
            this.btnCambiarPrecio.Click += new System.EventHandler(this.btnCambiarPrecio_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCambiarPrecio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.TxtPrecioUnidad);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtBuscar;
        private ComboBox comboBoxCategorias;
        private DataGridView DGVProductos;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtID;
        private TextBox TxtPrecioUnidad;
        private TextBox TxtProveedor;
        private TextBox TxtNombre;
        private Button btnCambiarPrecio;
    }
}