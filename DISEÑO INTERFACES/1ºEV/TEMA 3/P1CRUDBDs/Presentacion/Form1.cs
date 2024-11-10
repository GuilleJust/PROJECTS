using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            textID.Enabled = false;
        }

        private void SQLServer_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = Negocio.Negocio.ListadoContactosSQLServer();
            groupBox1.Enabled = false;
            gestorElegido.Text = "SQL SERVER";
            gestorElegido.ForeColor = Color.Blue;
        }

        private void MySQL_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.Negocio.ListadoContactosMySQL();
            groupBox1.Enabled = false;
            gestorElegido.Text = "MYSQL";
            gestorElegido.ForeColor = Color.Purple;
        }

        private void SQLite_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.Negocio.ListadoContactosSQLite();
            groupBox1.Enabled = false;
            gestorElegido.Text = "SQLITE";
            gestorElegido.ForeColor = Color.Green;
        }

        private void Adapter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.Negocio.ListadoContactosAdapter();
            groupBox1.Enabled = false;
            gestorElegido.Text = "ADAPTER";
            gestorElegido.ForeColor = Color.Yellow;
        }

        //HECHO CON MYSQL
        private void Guardar_Click(object sender, EventArgs e)
        {
            ContactoEntidad contacto =  new ContactoEntidad();
            int resultado = 0;

            contacto.Nombre = textNombre.Text;
            contacto.Apellidos = textApellido.Text;
            contacto.Telefono = textTelefono.Text;

            try
            {
                resultado = Negocio.Negocio.CompararContactoMySQL(contacto);
                if (resultado > 0)
                {
                    Negocio.Negocio.EditarContactoMySQL(contacto);
                    MessageBox.Show("Regitro editado correctamente.", "Información", MessageBoxButtons.OK);
                }

                else if(resultado == 0)
                {
                    Negocio.Negocio.GuardarContactoMySQL(contacto);
                    MessageBox.Show("Regitro insertado correctamente.", "Información", MessageBoxButtons.OK);
                }

                else
                    MessageBox.Show("El resgitro no se ha insertado correctamente:" + resultado + " filas.", "Información", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido:" + ex.Message, "Error", MessageBoxButtons.OK);
            }

            finally
            {
                textID.Text = "";
                textNombre.Text = "";
                textApellido.Text = "";
                textTelefono.Text = "";
            }

            tabControl1.SelectedIndex = 1;
            dataGridView1.DataSource = Negocio.Negocio.ListadoContactosMySQL();
        }

        //HECHO CON MYSQL
        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Estas seguro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Negocio.Negocio.BorrarContactoMySQL(textID.Text);

                dataGridView1.DataSource = Negocio.Negocio.ListadoContactosMySQL();
                textID.Text = "";
                textNombre.Text = "";
                textApellido.Text = "";
                textTelefono.Text = "";
                tabControl1.SelectedIndex = 1;
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void NuevoContacto_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ActivarConexion_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = ((Int32)dataGridView1.CurrentRow.Cells["Id"].Value).ToString();
            textNombre.Text = (string)dataGridView1.CurrentRow.Cells["Nombre"].Value;
            textApellido.Text = (string)dataGridView1.CurrentRow.Cells["Apellidos"].Value;
            textTelefono.Text = (string)dataGridView1.CurrentRow.Cells["Telefono"].Value;
            tabControl1.SelectedIndex = 1;
        }
    }
}