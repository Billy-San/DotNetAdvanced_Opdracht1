namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string text = $"Heloow {Environment.UserName}. Het is {DateTime.Now.ToShortTimeString()} Op {DateTime.Now.ToShortDateString()}";
            lb1.Text = text;

        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }
    }
}