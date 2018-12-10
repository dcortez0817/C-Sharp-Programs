/***************************************************************************************
 * Darien Cortez
 * Program 8 - MDI workshop
 * This program utilizes multiple document interfaces to display different workshops
 * and its items, item prices, and item quantity. A serializable file (record)
 * is used to allow the user to read in and out data to be stored in files.
 ****************************************************************************************/
using System;
using System.Windows.Forms;

namespace MDIWorkshop
{
    public partial class ItemInformation : Form
    {
        private int quant;//quantity
        private double prc;//price
        private string it;//item

        public ItemInformation()
        {
            InitializeComponent();
        }

        //parameterized constructor updated records
        public ItemInformation(Record record)
        {
            InitializeComponent();
            Rec = record;
            Item.Text = record.Item;
            Price.Text = record.Price.ToString();
            Quantity.Text = record.Quantity.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //converts the quantity.text to quant and returns bool succeed value  
            bool isInt = int.TryParse(Quantity.Text, out quant);
            //converts the price.text to pric and returns bool succeed value 
            bool isdouble = double.TryParse(Price.Text, out prc);
            
            if (!isInt)//checks if quanity was an int
                MessageBox.Show("The quantity value must be an integer value", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!isdouble)//checks if price was a double
                MessageBox.Show("Price must be a double value", "Invalid Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Item.Text == "")
                MessageBox.Show("Please enter an item name", "Invalid Item Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                it = Item.Text;
                Rec = new Record(quant, prc, it);
                Hide();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //returns Rec
        public Record Rec { get; private set; }
    }
}
