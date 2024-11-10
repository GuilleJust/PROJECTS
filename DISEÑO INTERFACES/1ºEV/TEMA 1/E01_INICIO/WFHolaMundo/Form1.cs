namespace WFHolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsaludo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            txtsaludo.Text = "Hola Mundo!";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}