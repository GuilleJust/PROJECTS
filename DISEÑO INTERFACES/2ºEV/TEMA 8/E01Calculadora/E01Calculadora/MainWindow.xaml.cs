//Guillermo Just 2 DAM B
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E01Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n1 = 0;
        int n2 = 0;
        string operacion = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(operacion == "")
            {
                n1 = (n1 * 10) + 1;
                txtResultado.Text = n2.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 1;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 2;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 2;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 3;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 3;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 4;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 4;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 5;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 5;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 6;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 6;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 7;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 7;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 8;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 8;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 9;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 9;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 * 10) + 0;
                txtResultado.Text = n1.ToString();
            }

            else
            {
                n2 = (n2 * 10) + 0;
                txtResultado.Text = n1.ToString() + operacion + n2.ToString();
            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    txtResultado.Text = (n1 + n2).ToString();
                    break;
                case "-":
                    txtResultado.Text = (n1 - n2).ToString();
                    break;
                case "*":
                    txtResultado.Text = (n1 * n2).ToString();
                    break;
                case "/":
                    txtResultado.Text = (n1 / n2).ToString();
                    break;
            }

            n1 = 0;
            n2 = 0;
            operacion = "";
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            operacion = "/";
            txtResultado.Text = n1 + "/";
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "+";
            txtResultado.Text = n1 + "+";
        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            txtResultado.Text = n1 + "-";
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "*";
            txtResultado.Text = n1 + "*";
        }

        private void btnPositivoNegativo_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = (-1 * int.Parse(txtResultado.Text)).ToString();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = 0;
            }
            else
            {
                n2 = 0;
            }
            txtResultado.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            n1 = 0;
            n2 = 0;
            operacion = "";
            txtResultado.Text = "0";

        }

        private void btnRetroceder_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                n1 = (n1 / 10);
                txtResultado.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 / 10);
                txtResultado.Text = n2.ToString();
            }
        }
    }
}
