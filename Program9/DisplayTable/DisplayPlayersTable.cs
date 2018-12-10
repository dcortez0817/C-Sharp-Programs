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
using System.Data.Entity.Validation;

namespace DisplayTable
{
    public partial class DisplayPlayersTable : Form
    {
        private BaseballExample.BaseballEntities dbcontext = new BaseballExample.BaseballEntities();
        public DisplayPlayersTable()
        {
            InitializeComponent();
        }

        private void DisplayPlayersTable_Load(object sender, EventArgs e)
        {
            dbcontext.Players.OrderBy(Player => Player.PlayerID).Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Validate();
            playerBindingSource.EndEdit();
            try
            {
                dbcontext.SaveChanges();

            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("First Name and Last Name must contain values",
                    "EntityValidationException");
            }
        }

        private void Query_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).Text) {
                case "Get All Players":
                    playerBindingSource.DataSource = dbcontext.Players.Local.ToBindingList();
                    break;
                case "Get Players With Batting Average At or Above 0.300":

                    playerBindingSource.DataSource = dbcontext.Players.Local.Where(player => player.BattingAverage >= 0.300m);

                    break;
                case "Get All Players With A Last Name of Hernandez":
                    playerBindingSource.DataSource = dbcontext.Players.Local.Where(player => player.LastName.Contains("Hernandez"));
                    break;

            }

        }
    }
}
