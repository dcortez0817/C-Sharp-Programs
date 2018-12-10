/*Darien Cortez
 * 9/12/2018
 * This app allows the user to input one number consisting of five digits and
 * separates each digit by three spaces. The form utilizes the mod (%) and
 * division (/) expressions to single out each individual digit. Text boxes 
 * are used to input, output data and a button is used to output the number
 * into the second textbox from the first textbox. If-Else statements allow the
 * form to display 5 digit numbers or below and print an error message for numbers
 * greater than 5 digits.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_DCortez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

         private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, n1, n2, n3, n4, n5;

            num = Int32.Parse(textBox1.Text);

            //calculations
            n1 = num / 10000 % 10;
            n2 = num / 1000 % 10;
            n3 = num / 100 % 10;
            n4 = num / 10 % 10;
            n5 = num % 10;

            if (num < 100000) // 5 digit number or less
            {
                if (num < 100000 && num > 10000)
                    textBox2.Text = n1 + "   " + n2 + "   " + n3 + "   " + n4 + "   " + n5; //5 digit number
                if (num < 10000 && num > 1000)
                    textBox2.Text = n2 + "   " + n3 + "   " + n4 + "   " + n5; //4 digit number
                if (num < 1000 && num > 100)
                    textBox2.Text = n3 + "   " + n4 + "   " + n5; //3 digit number
                if (num < 100 && num > 10)
                    textBox2.Text = n4 + "   " + n5; //2 digit number
                if (num < 10 && num > 1)
                    textBox2.Text = "" + n5; //1 digit number
            }
            else
                textBox2.Text = "Error. Too many digits. Please enter a 5 digit number or below."; //more than five digits
        }
    }
}
