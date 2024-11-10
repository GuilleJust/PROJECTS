using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public Employee Employee { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            TxtContrasenya_Required.UseSystemPasswordChar = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (Control componente in PanelLogin.Controls)
            {
                if (componente is TextBox)
                {
                    int find = componente.Name.ToString().IndexOf("_Required");
                    if (find > 0 && String.IsNullOrEmpty(componente.Text))
                    {
                        componente.BackColor = Color.RosyBrown;
                        LblError.Text = "Los campos son obligatorios";
                        LblError.ForeColor = Color.Red;
                        LblError.Visible = true;
                    }
                }
            }

            this.Employee = new Employee
            {
                Login = TxtUsuario_Required.Text,
                Password = TxtContrasenya_Required.Text,
            };

            if (EmpNegocio.ComprobarLogin(this.Employee))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}