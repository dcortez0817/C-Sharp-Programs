using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BaseballExample;
namespace Part3
{
    public partial class PlayerDisplayForm : Form
    {
        private BaseballExample.BaseballEntities dbcontext = new BaseballExample.BaseballEntities();
        public PlayerDisplayForm()
        {
            InitializeComponent();
        //    Quary("Fill");
        }

        public void Quary(string q)
        {
            switch (q)
            {
                case "Fill":
                    playersBindingSource.DataSource = dbcontext.Players.Local.ToBindingList();
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);
            
        }
        

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);

        }

        private void BrowseAll_Button_Click(object sender, EventArgs e)
        {
            playersTableAdapter.Fill(baseballDataSet.Players);
            LastName_TextBox.Text = "";
        }

        private void Find_Button_Click(object sender, EventArgs e)
        {
            playersTableAdapter.FillByLastName(this.baseballDataSet.Players, LastName_TextBox.Text);

        }

        private void playersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);

        }

        private void playersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);

        }
    }
}
