namespace Oefening6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double btw = 0.07;
            double shipping_kost = 0;


            double price1 = Convert.ToDouble(P_each1.Text);
            double price2 = Convert.ToDouble(P_each2.Text);
            double price3 = Convert.ToDouble(P_each3.Text);
            double price4 = Convert.ToDouble(P_each4.Text);


            double Quantity1 = Convert.ToDouble(Qty1.Text);
            double Quantity2 = Convert.ToDouble(Qty2.Text);
            double Quantity3 = Convert.ToDouble(Qty3.Text);
            double Quantity4 = Convert.ToDouble(Qty4.Text);

            double result1 = price1 * Quantity1;
            double result2 = price2 * Quantity2;
            double result3 = price3 * Quantity3;
            double result4 = price4 * Quantity4;

            Ex_price1.Text = "€" + result1;
            Ex_price2.Text = "€" + result2;
            Ex_price3.Text = "€" + result3;
            Ex_price4.Text = "€" + result4;

            double subtot = result1 + result2 + result3 + result4;
            Sub_Box.Text = "€" + subtot.ToString();

            double s_tax = btw * subtot;
            SalesTaxe.Text = s_tax.ToString();
            
            if(subtot < 20)
            {
                shipping_kost = 5;
            }
            else if(subtot < 50)
            {
                shipping_kost = 7.5;
            }
            else if (subtot < 75)
            {
                shipping_kost = 10;
            }
            else
            {
                shipping_kost = 0;
            }

            Shipping.Text = shipping_kost.ToString();

            double G_tot = s_tax + subtot + shipping_kost;
            GrandTotal.Text = G_tot.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}