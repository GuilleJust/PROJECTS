using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Estadisticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT ShipCity, COUNT(OrderId) [Total]";
            query += " FROM Orders WHERE ShipCountry = 'Brazil'";
            query += " GROUP BY ShipCity";
            DataTable dt = GetData(query);


            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("ShipCity") ascending
                          select p.Field<string>("ShipCity")).ToArray();


            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("ShipCity") ascending
            select p.Field<int>("Total")).ToArray();

            Chart1.Series[0].LegendText = "Brazil Order Statistics";
            Chart1.Series[0].ChartType = SeriesChartType.Bar;
            Chart1.Series[0].IsValueShownAsLabel = true;
            Chart1.Series[0].Points.DataBindXY(x, y);
        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source=DESKTOP-EP3DO45;Initial Catalog=northwind;User ID=sa;Password=1234";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
