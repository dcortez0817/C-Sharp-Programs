/******************************************************************
 * Darien Cortez
 * Program 6 - Caterinas Pizza
 * 11/7/2018
 * This form prints out the options of the users choice and the
 * total cost of everything.
*******************************************************************/
using System;
using System.Windows.Forms;

namespace CaterinasPizza
{
    public partial class Cart : Form
    {
        public Cart(double c, string l)
        {
            InitializeComponent();

            double tax = c * 0.08;//calculate tax
            double total = c + tax;//calculate the total price

            PizzaList.Text += l;//print list of options

            //updates the total price and tax
            SubT.Text = "$" + Math.Round(c,2).ToString();
            Tx.Text = "$" + Math.Round(tax,2).ToString();
            Tot.Text = "$" + Math.Round(total,2).ToString();
        }


        private void Checkout_Click(object sender, EventArgs e)
        {
            //simulates the user checking out
            MessageBox.Show("You order the pizza and have the time of your life. The end.");
        }

        private void AddMore_Click(object sender, EventArgs e)
        {
            //this just closes the cart form because everything else is done on the other form
            this.Close();
        }
    }
}
