/***************************************************************************************
 * Darien Cortez
 * Program 8 - MDI workshop
 * This program utilizes multiple document interfaces to display different workshops
 * and its items, item prices, and item quantity. A serializable file (record)
 * is used to allow the user to read in and out data to be stored in files.
 ****************************************************************************************/
using System;
using System.IO;
using System.Windows.Forms;

namespace MDIWorkshop
{
    public partial class Conference : Form
    {
        public string fileName;//name of the file based on the workshop
        public Conference()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();//closes the program
        }

        private void NewWorkshop_Click(object sender, EventArgs e)
        {
            WorkshopName name = new WorkshopName();//creates object of the workshopName form
            name.ShowDialog();//use showDialog because name is not a child of this Mdi

            if(fileName != "")
            {
                fileName += ".sup";//makes the file a .sup file

                WorkshopForm workshop = new WorkshopForm(fileName, name.WsName);//creates object of the workshopForm
                workshop.MdiParent = this;//makes this form the parent form of the display workshop form
                workshop.Text = name.WsName;
                workshop.Show();
            }
        }

        //opens an existing file when this button is clicked
        private void OpenWorkshop_Click(object sender, EventArgs e)
        {
            // create and show dialog box that enables user to open file
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            WorkshopName name = new WorkshopName();

            // exits the open event handler if user clicks Cancel
            if (result != DialogResult.Cancel)
            {
                try
                {
                    fileName = fileChooser.FileName;// get name of file from user
                    
                    if (fileName.Contains(".sup") == false)// show error if the selected file is not a .sup file
                        MessageBox.Show("The file must be a .sup file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                    {
                        WorkshopForm workshop = new WorkshopForm(fileName, name.WsName);//creates object of the workshopForm
                        workshop.MdiParent = this;//makes this form the parent form of the display workshop form
                        workshop.Show();
                    }
                }
                //exception when a file doesn't exist
                catch (FileNotFoundException)
                {
                    //tells the user if file does not exist
                    MessageBox.Show("This File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        //saves everything for the workshop file
        private void SaveWorkshop_Click(object sender, EventArgs e)
        {
            WorkshopForm active = ((WorkshopForm)ActiveMdiChild);

            //determines if an existing file is being saved
            if (active != null)
                active.SaveWkShop();

            else
                MessageBox.Show("You must open a new or existing file before saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InsertItem_Click(object sender, EventArgs e)
        {
            WorkshopForm active = ((WorkshopForm)ActiveMdiChild);
            active.AddItem();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            WorkshopForm active = ((WorkshopForm)ActiveMdiChild);
            active.OmitItem();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            WorkshopForm active = ((WorkshopForm)ActiveMdiChild);
            active.UpdateItem();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program utilizes multiple document interfaces to display \n\ndifferent workshops" +
                "and its items, item prices, and item \n\nquantity.A serializable file(record)" +
                "is used to allow the user to \n\nread in and out data to be stored in files.", "About this program",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
