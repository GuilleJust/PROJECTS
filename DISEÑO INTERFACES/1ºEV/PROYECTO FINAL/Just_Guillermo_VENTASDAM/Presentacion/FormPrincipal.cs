using Entidades;
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
    public partial class FormPrincipal : Form
    {
        private int childFormNumber = 0;
        public Employee? Employee;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void insertarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertarEmpleado formInsertarEmpleado = new FormInsertarEmpleado(Employee);
            formInsertarEmpleado.MdiParent = this;
            formInsertarEmpleado.WindowState = FormWindowState.Maximized;
            formInsertarEmpleado.Show();
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.MdiParent = this;
            formPedidos.WindowState = FormWindowState.Maximized;
            formPedidos.Show();
        }

        private void imprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInforme formInforme = new FormInforme();
            formInforme.MdiParent = this;
            formInforme.WindowState = FormWindowState.Maximized;
            formInforme.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarEmp formModificarEmp = new FormModificarEmp();
            formModificarEmp.MdiParent = this;
            formModificarEmp.WindowState = FormWindowState.Maximized;
            formModificarEmp.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorrarEmpleado formBorrarEmpleado = new FormBorrarEmpleado();
            formBorrarEmpleado.MdiParent = this;
            formBorrarEmpleado.WindowState = FormWindowState.Maximized;
            formBorrarEmpleado.Show();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsertarEmpleado formInsertarEmpleado = new FormInsertarEmpleado(Employee);
            formInsertarEmpleado.MdiParent = this;
            formInsertarEmpleado.WindowState = FormWindowState.Maximized;
            formInsertarEmpleado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Estas seguro?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.WindowState = FormWindowState.Maximized;
            formProductos.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.MdiParent = this;
            formPedidos.WindowState = FormWindowState.Maximized;
            formPedidos.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModPedido formModPedido = new FormModPedido();
            formModPedido.MdiParent = this;
            formModPedido.WindowState = FormWindowState.Maximized;
            formModPedido.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModPedido formModPedido = new FormModPedido();
            formModPedido.MdiParent = this;
            formModPedido.WindowState = FormWindowState.Maximized;
            formModPedido.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercaDe = new FormAcercaDe();
            formAcercaDe.MdiParent = this;
            formAcercaDe.WindowState = FormWindowState.Maximized;
            formAcercaDe.Show();
        }

        private void totalDePedidosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new FormEstadisticas();
            formEstadisticas.MdiParent = this;
            formEstadisticas.WindowState = FormWindowState.Maximized;
            formEstadisticas.Show();
        }

        private void productosPorCatgoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new FormEstadisticas();
            formEstadisticas.MdiParent = this;
            formEstadisticas.WindowState = FormWindowState.Maximized;
            formEstadisticas.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInforme formInforme = new FormInforme();
            formInforme.MdiParent = this;
            formInforme.WindowState = FormWindowState.Maximized;
            formInforme.Show();
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
