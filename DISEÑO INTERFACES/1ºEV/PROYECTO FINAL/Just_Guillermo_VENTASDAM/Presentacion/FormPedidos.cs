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

namespace Presentacion
{
    public partial class FormPedidos : Form
    {
        decimal total = 0;
        double IVA;
        double totalConIVA;
        Order? order;
        public FormPedidos()
        {
            InitializeComponent();
            DGVProductos.DataSource = EmpNegocio.ListadoProductos();
            TxtID.Text = "12";
            TxtID.Enabled = false;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            DGVProductos.DataSource = EmpNegocio.ListaFiltradaProductos(TxtBusqueda.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            total += ((decimal)DGVProductos.CurrentRow.Cells["UnitPrice"].Value);
            double totalD = Convert.ToDouble(total);
            IVA = totalD * 0.21;
            totalConIVA = totalD + IVA;

            LblTotalParcial.Text = totalD.ToString() + " €";
            LblIVA.Text = IVA.ToString() + " €";
            LblTotal.Text = totalConIVA.ToString() + " €";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(total > 0)
            {
                total -= ((decimal)DGVProductos.CurrentRow.Cells["UnitPrice"].Value);
                double totalD = Convert.ToDouble(total);
                IVA = totalD * 0.21;
                totalConIVA = totalD + IVA;

                LblTotalParcial.Text = totalD.ToString() + " €";
                LblIVA.Text = IVA.ToString() + " €";
                LblTotal.Text = totalConIVA.ToString() + " €";
            }

            else
            {
                LblTotalParcial.Text = "0 €";
                LblIVA.Text = "0 €";
                LblTotal.Text = "0 €";
            }
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            int shipVia = 0;

            if (ComprobarCampos())
            {
                this.order = new Order
                {
                    CustomerId = TxtCliente.Text,
                    RequiredDate = dateTimePedido.Value,
                    ShippedDate = dateTimeEnvio.Value,
                    ShipName = TxtShipName.Text,
                    ShipAddress = TxtDireccion.Text,
                    ShipCity = TxtPoblacion.Text,
                    ShipRegion = comboBoxProvincia.Text,
                    ShipPostalCode = TxtCP.Text,
                    ShipCountry = TxtPais.Text,
                };

                order.EmployeeID = Convert.ToInt32(TxtID.Text);
                if(comboBoxMetodoEnvio.Text == "Express")
                {
                    shipVia = 1;
                }
                else
                {
                    shipVia = 2;
                }
                order.ShipVia = shipVia;

                EmpNegocio.NuevoPedido(order);
                MessageBox.Show("Pedido insertado correctamente", "Info", MessageBoxButtons.OK);

                TxtCliente.Text = "";
                TxtShipName.Text = "";
                TxtDireccion.Text = "";
                TxtPoblacion.Text = "";
                TxtCP.Text = "";
                TxtPais.Text = "";
                TxtShipName.Text = "";
                comboBoxMetodoEnvio.Text = "";
                comboBoxProvincia.Text = "";
            }

            else
            {
                MessageBox.Show("Debes seleccionar un metodo de envio y una provincia", "Error", MessageBoxButtons.OK);
            }
        }

        public bool ComprobarCampos()
        {
            if(comboBoxMetodoEnvio.Text != "" && comboBoxMetodoEnvio.Text != "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
