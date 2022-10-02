namespace Oefening7
{
    public partial class Form1 : Form
    {
        int som;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hoeveelheid = Convert.ToInt32(box1.Text);

            for (int i = 0; i <= hoeveelheid; i++)
            {
                som += i;
            }
            Result.Text = som.ToString();
            som = 0;
        }
    }
}