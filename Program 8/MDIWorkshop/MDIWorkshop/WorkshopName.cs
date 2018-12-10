/***************************************************************************************
 * Darien Cortez
 * Program 8 - MDI workshop
 * This program utilizes multiple document interfaces to display different workshops
 * and its items, item prices, and item quantity. A serializable file (record)
 * is used to allow the user to read in and out data to be stored in files.
 ****************************************************************************************/
using System;
using System.Linq;
using System.Windows.Forms;

namespace MDIWorkshop
{
    public partial class WorkshopName : Form
    {
        public string WsName; //name of the file that stores everything

        public WorkshopName()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            //checks if the workshop could be a valid file name
            if (WorkshopEntry.Text == "" || HasSpecialChars(WorkshopEntry.Text))
                MessageBox.Show("The workshop name cannot be empty or contain special characters.", 
                    "Invalid Workshop Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                WsName = WorkshopEntry.Text;//holds the name of the workshop
                Close();
            }
        }
        //closes the form if the user decides not to enter a workshop name 
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //determines if the file contains special characters
        private bool HasSpecialChars(string text)
        {
            return text.Any(ch => !Char.IsLetterOrDigit(ch));
        }
    }
}
