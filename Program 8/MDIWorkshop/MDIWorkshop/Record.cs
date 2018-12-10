/***************************************************************************************
 * Darien Cortez
 * Program 8 - MDI workshop
 * This program utilizes multiple document interfaces to display different workshops
 * and its items, item prices, and item quantity. A serializable file (record)
 * is used to allow the user to read in and out data to be stored in files.
 ****************************************************************************************/
using System;

namespace MDIWorkshop
{
    [Serializable]
    public class Record
    {
        public Record() : this(0, 0.0, "") { }
        
        public Record(int quantity, double price, string item)
        {
            Quantity = quantity;
            Price = price;
            Item = item;
        }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Item { get; set; }

        override public string ToString()
        {
            return Quantity + "\t\t" + Item + "\t\t\t$" + Price;
        }
    }
}
