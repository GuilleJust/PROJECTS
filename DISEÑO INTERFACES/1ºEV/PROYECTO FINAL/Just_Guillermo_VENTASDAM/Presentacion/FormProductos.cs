using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion
{
    public partial class FormProductos : Form
    {
        
        public FormProductos()
        {
            InitializeComponent();
            DGVProductos.DataSource = EmpNegocio.ListadoProductos();
            TxtID.Enabled = false;
            TxtNombre.Enabled = false;
            TxtProveedor.Enabled = false;
            TxtPrecioUnidad.Enabled = false;
            btnCambiarPrecio.Enabled = false;
            comboBoxCategorias.ValueMember = "CategoryID";
            comboBoxCategorias.DisplayMember = "CategoryName";
        }

        private void DGVProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = ((Int32)DGVProductos.CurrentRow.Cells["ProductId"].Value).ToString();
            TxtNombre.Text = (string)DGVProductos.CurrentRow.Cells["ProductName"].Value;
            TxtProveedor.Text = ((Int32)DGVProductos.CurrentRow.Cells["SupplierID"].Value).ToString();
            TxtPrecioUnidad.Text = ((decimal)DGVProductos.CurrentRow.Cells["UnitPrice"].Value).ToString();

            TxtPrecioUnidad.Enabled = true;
            btnCambiarPrecio.Enabled = true;
        }

        private void btnCambiarPrecio_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.ProductID = (Int32)DGVProductos.CurrentRow.Cells["ProductId"].Value;
            decimal value;
            decimal.TryParse(TxtPrecioUnidad.Text, out value);
            prod.UnitPrice = value;
            EmpNegocio.EditarProducto(prod);
            MessageBox.Show("Precio editado correctamente", "Confirmacion", MessageBoxButtons.OK);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DGVProductos.DataSource = EmpNegocio.ListaFiltradaProductos(TxtBuscar.Text);
        }
    }
}
