using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInsertarEmpleado : Form
    {
        Employee? emp;
        int id;
        public FormInsertarEmpleado(Employee emplo)
        {
            InitializeComponent();
            TxtEmployee.Enabled = false;
            id = emplo.EmployeeID;
            CargarEmpleado(emplo);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                this.emp = new Employee
                {

                    Login = TxtLogin.Text,
                    Password = TxtPassword.Text,
                    LastName = TxtLastName.Text,
                    FirstName = TxtFirstName.Text,
                    Title = TxtTitle.Text,
                    TitleOfCourtesy = TxtTitleOfCourtesy.Text,
                    BirthDate = TxtBirthDate.Text,
                    HireDate = TxtHireDate.Text,
                    Address = TxtAddress.Text,
                    City = TxtCity.Text,
                    Region = TxtRegion.Text,
                    PostalCode = TxtPostalCode.Text,
                    Country = TxtCountry.Text,
                    HomePhone = TxtHomePhone.Text,
                    Extension = TxtExtension.Text,
                    Notes = TxtNotes.Text,
                    PhotoPath = TxtPhotoPath.Text
                };

                Int32 reports = 2;
                Int32.TryParse(TxtReportsTo.Text, out reports);
                this.emp.ReportsTo = reports;

                EmpNegocio.InsertarEmp(this.emp);
                MessageBox.Show("Registro insertado correctamente", "Informacion", MessageBoxButtons.OK);

                TxtLogin.Text = "";
                TxtPassword.Text = "";
                TxtLastName.Text = "";
                TxtFirstName.Text = "";
                TxtTitle.Text = "";
                TxtTitleOfCourtesy.Text = "";
                TxtBirthDate.Text = "";
                TxtHireDate.Text = "";
                TxtAddress.Text = "";
                TxtCity.Text = "";
                TxtRegion.Text = "";
                TxtPostalCode.Text = "";
                TxtCountry.Text = "";
                TxtHomePhone.Text = "";
                TxtExtension.Text = "";
                TxtNotes.Text = "";
                TxtReportsTo.Text = "";
                TxtPhotoPath.Text = "";
            }

            else
            {
                MessageBox.Show("Error en uno de los campos", "Error", MessageBoxButtons.OK);
            }
        }

        public void CargarEmpleado(Employee empleado)
        {
            TxtEmployee.Text = id.ToString();
            TxtLogin.Text = empleado.Login;
            TxtPassword.Text = "**********";
            TxtLastName.Text = empleado.LastName;
            TxtFirstName.Text = empleado.FirstName;
            TxtTitle.Text = empleado.Title;
            TxtTitleOfCourtesy.Text = empleado.TitleOfCourtesy;
            TxtBirthDate.Text = empleado.BirthDate;
            TxtHireDate.Text = empleado.HireDate;
            TxtAddress.Text = empleado.Address;
            TxtCity.Text = empleado.City;
            TxtRegion.Text = empleado.Region;
            TxtPostalCode.Text = empleado.PostalCode;
            TxtCountry.Text = empleado.Country;
            TxtHomePhone.Text = empleado.HomePhone;
            TxtExtension.Text = empleado.Extension;
            TxtNotes.Text = empleado.Notes;
            TxtReportsTo.Text = (empleado.ReportsTo).ToString();
            TxtPhotoPath.Text = empleado.PhotoPath;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            if (ComprobarCampos())
            {
                this.emp = new Employee
                {

                    Login = TxtLogin.Text,
                    Password = TxtPassword.Text,
                    LastName = TxtLastName.Text,
                    FirstName = TxtFirstName.Text,
                    Title = TxtTitle.Text,
                    TitleOfCourtesy = TxtTitleOfCourtesy.Text,
                    BirthDate = TxtBirthDate.Text,
                    HireDate = TxtHireDate.Text,
                    Address = TxtAddress.Text,
                    City = TxtCity.Text,
                    Region = TxtRegion.Text,
                    PostalCode = TxtPostalCode.Text,
                    Country = TxtCountry.Text,
                    HomePhone = TxtHomePhone.Text,
                    Extension = TxtExtension.Text,
                    Notes = TxtNotes.Text,
                    PhotoPath = TxtPhotoPath.Text
                };

                Int32 reports = 2;
                Int32.TryParse(TxtReportsTo.Text, out reports);
                this.emp.ReportsTo = reports;

                EmpNegocio.InsertarEmp(this.emp);
                MessageBox.Show("Registro editado correctamente", "Informacion", MessageBoxButtons.OK);

                TxtLogin.Text = "";
                TxtPassword.Text = "";
                TxtLastName.Text = "";
                TxtFirstName.Text = "";
                TxtTitle.Text = "";
                TxtTitleOfCourtesy.Text = "";
                TxtBirthDate.Text = "";
                TxtHireDate.Text = "";
                TxtAddress.Text = "";
                TxtCity.Text = "";
                TxtRegion.Text = "";
                TxtPostalCode.Text = "";
                TxtCountry.Text = "";
                TxtHomePhone.Text = "";
                TxtExtension.Text = "";
                TxtNotes.Text = "";
                TxtReportsTo.Text = "";
                TxtPhotoPath.Text = "";
            }

            else
            {
                MessageBox.Show("Error en uno de los campos", "Error", MessageBoxButtons.OK);
            }
        }
    
        private bool ComprobarCampos()
        {
            bool resultado = false;

            if(TxtLogin.Text != "" && TxtPassword.Text!= "" && TxtReportsTo.Text != "" && 
            (TxtHomePhone.TextLength >= 9 && TxtHomePhone.TextLength <= 12) && (TxtTitleOfCourtesy.Text == "Mr." ||
            TxtTitleOfCourtesy.Text == "Ms" || TxtTitleOfCourtesy.Text == "Dr." || TxtTitleOfCourtesy.Text == "Mrs."))
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
