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

namespace Presentacion
{
    public partial class FormModPedido : Form
    {
        public FormModPedido()
        {
            InitializeComponent();
            DGVPedidos.DataSource = EmpNegocio.ListadoPedidos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido modificado correctamente", "Informacion", MessageBoxButtons.OK);
        }

        private void DGVPedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOrderID.Text = "10250";
            TxtProductID.Text = "49";
            TxtUnitPrice.Text = "14.00";
            TxtQuantity.Text = "3";
            TxtDiscount.Text = "0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este pedido contiene claves ajenas", "Error", MessageBoxButtons.OK);
        }
    }
}
