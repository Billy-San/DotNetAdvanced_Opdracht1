namespace Oefening4
{
    public partial class SalesTaxCalculator : Form
    {
        public SalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalesTaxCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            Subtotaal.Text = "€" + subtot.ToString();

            double txR = Convert.ToDouble(TaxRate.Text);
            double salTax = subtot * txR;

            SalesTax.Text = "€" + salTax.ToString();

            double ship = Convert.ToDouble(Shipping.Text);
            double grTot = subtot + salTax + ship;

            GrandTotal.Text = "€" + grTot.ToString();

        }

        private void GrandTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}