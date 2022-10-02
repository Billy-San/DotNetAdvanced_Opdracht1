namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int resultaat1 = 1234 * 54321;
            string s = $"1234 * 54321 = {resultaat1}";
            label1.Text = s;


            int resultaat2 = 22222 * 33333;
            string s2 = $"22222 * 33333 = {resultaat2}";
            label2.Text = s2;


            Boolean resultaat3 = resultaat1 > resultaat2;
            string s3 = $"1234 * 54321 > 22222 * 33333 = {resultaat3}";
            label3.Text = s3;
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}