using System.Diagnostics;

namespace OrdenacionPersonas
{
    public partial class Form1 : Form
    {
        List<Persona> listaP = new List<Persona>();
        
        public Form1()
        {
            InitializeComponent();

            textBox1.Focus();

            Persona p = new Persona("aaa", "aaa", 20);
            Persona p2 = new Persona("bbbb", "bbbb", 24);
            Debug.WriteLine(p + p2);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            int edad = Convert.ToInt32(textBox3.Text);
            Persona p = new Persona(nombre, apellido, edad);
            listaP.Add(p);

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox1.Focus();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox1.Focus();
        }

        private void OrdNombre_Click(object sender, EventArgs e)
        {
            Refrescar(Persona.CompareType.Nombre);
        }

        private void OrdApellido_Click(object sender, EventArgs e)
        {
            Refrescar(Persona.CompareType.Apellido);
        }

        private void OrdEdad_Click(object sender, EventArgs e)
        {
            Refrescar(Persona.CompareType.Edad);
        }

        private void Refrescar(Persona.CompareType tipo)
        {
            ListaPersonas.Items.Clear();
            listaP.Sort(new Persona.PersonaComparer(tipo));

            foreach(Persona p in listaP)
            {
                ListaPersonas.Items.Add(p);
            }
        }
    }
}