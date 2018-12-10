/***************************************************************************************
 * Darien Cortez
 * Program 8 - MDI workshop
 * This program utilizes multiple document interfaces to display different workshops
 * and its items, item prices, and item quantity. A serializable file (record)
 * is used to allow the user to read in and out data to be stored in files. The program
 * won't let me add a heading.
 ****************************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MDIWorkshop
{
    public partial class WorkshopForm : Form
    {
        FileStream fstream;//allows user to read and write from file
        BinaryFormatter reader;
        private List<Record> records;//stores records in a generic list
        private string FileName;
        private string WName;
        Conference stuff = new Conference();

        public WorkshopForm(string file, string name)
        {
            InitializeComponent();

            FileName = file;
            WName = name;
            reader = new BinaryFormatter();//deserializes Record in binary format
            records = new List<Record>();

            //heading
            WorkshopList.Items.Add("Item Name\t\tPrice\t\t\tQuantity");
        }

        private void WorkshopForm_Load(object sender, EventArgs e)
        {
            //set workshop name as form text
            Text = WName;
            DisplayWorkshop();
        }

        public void DisplayWorkshop()
        {
            WorkshopList.Items.Clear();
            fstream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                while (true)
                {
                    // deserializes record and adds its items to the list
                    Record record = (Record)reader.Deserialize(fstream);
                    WorkshopList.Items.Add(record);
                    records.Add(record);
                }
            }
            //close stream when an error occurs in serialization
            catch (SerializationException)
            {
                fstream.Close();
            }

        }

        public void AddItem()
        {
            //gets the record from the itemInformation form
            ItemInformation information = new ItemInformation();
            information.ShowDialog();
            Record rec = information.Rec;
            
            if (rec != null)
            {
                // add the record to the list
                WorkshopList.Items.Add(rec);
                records.Add(rec);
            }
        }

        public void SaveWkShop()
        {
            //truncate allows user to open existing file that will then be saved
            fstream = new FileStream(FileName, FileMode.Truncate, FileAccess.Write);

            for (int i = 0; i < records.Count; i++)
            {
                reader.Serialize(fstream, records[i]);// serializes the records into a file
            }
            MessageBox.Show("The file was saved succesfully", "Good News", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fstream.Close();
        }

        //method to delete an item
        public void OmitItem()
        {
            //if an item was selected
            if (WorkshopList.SelectedIndex > 0)
            {
                // subtract one because generic list index starts at 1
                records.RemoveAt(WorkshopList.SelectedIndex - 1);
                WorkshopList.Items.RemoveAt(WorkshopList.SelectedIndex);

                MessageBox.Show("The item was deleted successfully", "Item deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //method to update an item
        public void UpdateItem()
        {
            //if an item was selected
            if (WorkshopList.SelectedIndex > 0)
            {
                // get item that was updated
                ItemInformation form = new ItemInformation(records[WorkshopList.SelectedIndex - 1]);
                form.ShowDialog();
                Record record = form.Rec;

                // update item in the list and record
                WorkshopList.Items[WorkshopList.SelectedIndex] = record;
                records[WorkshopList.SelectedIndex - 1] = record;
            }
        }
    }
}
