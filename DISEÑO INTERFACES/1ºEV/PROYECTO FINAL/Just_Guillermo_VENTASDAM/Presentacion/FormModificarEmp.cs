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
    public partial class FormModificarEmp : Form
    {
        Employee? emp;
        public FormModificarEmp()
        {
            InitializeComponent();
            DGVEmpleados.DataSource = EmpNegocio.ListadoGenerico();
        }

        private void DGVEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.emp = new Employee
            {
                EmployeeID = (Int32)DGVEmpleados.CurrentRow.Cells["EmployeeID"].Value,
                Login = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Login"].Value),
                Password = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Password"].Value),
                LastName = Convert.ToString(DGVEmpleados.CurrentRow.Cells["LastName"].Value),
                FirstName = Convert.ToString(DGVEmpleados.CurrentRow.Cells["FirstName"].Value),
                Title = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Title"].Value),
                TitleOfCourtesy = Convert.ToString(DGVEmpleados.CurrentRow.Cells["TitleOfCourtesy"].Value),
                BirthDate = Convert.ToString(DGVEmpleados.CurrentRow.Cells["BirthDate"].Value),
                HireDate = Convert.ToString(DGVEmpleados.CurrentRow.Cells["HireDate"].Value),
                Address = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Address"].Value),
                City = Convert.ToString(DGVEmpleados.CurrentRow.Cells["City"].Value),
                Region = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Region"].Value),
                PostalCode = Convert.ToString(DGVEmpleados.CurrentRow.Cells["PostalCode"].Value),
                Country = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Country"].Value),
                HomePhone = Convert.ToString(DGVEmpleados.CurrentRow.Cells["HomePhone"].Value),
                Extension = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Extension"].Value),
                Notes = Convert.ToString(DGVEmpleados.CurrentRow.Cells["Notes"].Value),
                ReportsTo = (Int32)DGVEmpleados.CurrentRow.Cells["ReportsTo"].Value,
                PhotoPath = Convert.ToString(DGVEmpleados.CurrentRow.Cells["PhotoPath"].Value)
            };

            FormInsertarEmpleado formInsertarEmpleado = new FormInsertarEmpleado(emp);
            formInsertarEmpleado.ShowDialog();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            DGVEmpleados.DataSource = EmpNegocio.ListaFiltrada(TxtBusqueda.Text);
        }
    }
}
