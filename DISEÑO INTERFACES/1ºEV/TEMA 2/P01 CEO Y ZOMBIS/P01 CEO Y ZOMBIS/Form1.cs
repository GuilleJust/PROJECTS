namespace P01_CEO_Y_ZOMBIS
{
    public partial class imagen : Form
    {
        CEO ceo = new CEO("Pablo", 27);
        Zombie z = null;

        public imagen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Disminuir.Text = "Si, si que es interesante... NO TE DOY NI UN EURO!! ";
            button3.Text = "WOW, Proyectazo TOMA MI PASTA!";
            button3.Hide();
            Disminuir.Hide();
            label1.Hide();
        }

        private void bienvenida_Click(object sender, EventArgs e)
        {
            button3.Show();
            Disminuir.Show();
            label1.Show();
            Bienestar.Text = Convert.ToString(ceo.Bienestar);
            pictureBox1.Image = Properties.Resources.ceo;
            bienvenida.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ceo.AddBienestar();
            Bienestar.Text = Convert.ToString(ceo.Bienestar);

            if(button3.Text == "¡Demosle algo de dienro o nos matara a todos!")
            {
                pictureBox1.Image = Properties.Resources.ceo;
                Disminuir.Text = "Si, si que es interesante... NO TE DOY NI UN EURO!! ";
                button3.Text = "WOW, Proyectazo TOMA MI PASTA!";
            }
        }

        private void Disminuir_Click(object sender, EventArgs e)
        {
            ceo.AddMalestar();
            Bienestar.Text = Convert.ToString(ceo.Bienestar);

            if(ceo.Bienestar == 0)
            {
                //He intentado acceder de todas las formas posibles al Zombie pero si no lo hago asi no puedo acceder a el.
                z = new Zombie(ceo);
                pictureBox1.Image = Properties.Resources.zombie2;
                Disminuir.Text = "WOW Que ha pasado ¿Quien era ese Zombie";
                button3.Text = "¡Demosle algo de dienro o nos matara a todos!";
                Bienestar.Text = z.ToString();
                label1.Hide();
                z = null;
            }

            if (ceo.Bienestar <= -5)
            {
                Bienestar.Text = "Yo antes era " + ceo.Nombre;
                ceo.AddBienestar();
            }
        }
    }
}