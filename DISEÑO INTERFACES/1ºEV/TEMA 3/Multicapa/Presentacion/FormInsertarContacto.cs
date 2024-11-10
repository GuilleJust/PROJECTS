using System;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FormInsertarContacto : Form
    {
        // atributo que meneja la agenda de contactos.
        private Agenda agenda;
        public FormInsertarContacto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agenda = new Agenda();
            DGListado.DataSource = agenda.Listado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                agenda.InsertarAgenda(textBox1.Text, textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Inserción realizada correctamente");
                DGListado.DataSource = agenda.Listar2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
