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
    public partial class FormBorrarEmpleado : Form
    {
        public FormBorrarEmpleado()
        {
            InitializeComponent();
            DGVEmpleados.DataSource = EmpNegocio.ListadoGenerico();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Esta seguro que desea eliminar este empleado de la base de datos?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (opcion == DialogResult.OK)
            {
                if(Convert.ToInt32(DGVEmpleados.Rows[e.RowIndex].Cells[0].Value) > 12)
                {
                    EmpNegocio.BorrarEmp(Convert.ToInt32(DGVEmpleados.Rows[e.RowIndex].Cells[0].Value));
                    MessageBox.Show("Registro eliminado correctamente", "Info", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Este registro esta asociado a otras tablas y no se puede eliminar", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DGVEmpleados.DataSource = EmpNegocio.ListaFiltrada(TxtBuscar.Text);
        }
    }
}
