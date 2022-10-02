namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fahrenheit_Click(object sender, EventArgs e)
        {

        }

        private void CelsiusBtn_Click(object sender, EventArgs e)
        {
            double convertisseur = Convert.ToDouble(CelsiusBox.Text) * 9/5 + 32;
            FahrenheitBox.Text = convertisseur.ToString();

        }

        private void FahrenheitBtn_Click(object sender, EventArgs e)
        {
            double convertisseur2 = (Convert.ToDouble(FahrenheitBox.Text) - 32) * 5/9;
            CelsiusBox.Text = convertisseur2.ToString();
        }
    }
}