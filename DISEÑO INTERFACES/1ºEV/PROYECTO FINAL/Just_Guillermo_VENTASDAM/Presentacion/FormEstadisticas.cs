using Microsoft.Data.SqlClient;
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
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            //POR LO QUE HE ESTADO MIRANDO NO EXISTE EL ELEMTNO "CHART" EN EL .NET 6.0
            //HE CREADO OTRO PORYECTO CON EL .NET 4.8 Y LO HE HECHO AHI, TE LO ADJUNTO TAMBIEN
        }
    }
}
