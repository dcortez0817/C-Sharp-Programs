/******************************************************************
 * Darien Cortez
 * Program 6 - Caterinas Pizza
 * 11/7/2018
 * This program acts as an online site to allow users to order
 * pizza online and print out the total cost of the pizza.
*******************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaterinasPizza
{
    public partial class Caterinas : Form
    {
        public string list = "";//array of the different orders
        public double cost;
        double pcost, scost, mcost, lcost;//variables for prices
        
        bool Wclicked = false;//determines if whole circle was clicked
        bool Lclicked = false;//determines if left half circle was clicked
        bool Rclicked = false;//determines if right half circle was clicked
        bool byo = false; //determines if build your own option was clicked

        public Caterinas()
        {
            InitializeComponent();
            cost = 0.0;//initializes the price to $0

            logo.Parent = Title;
            logo.BackColor = Color.Transparent;
        }
        
        //***************************************************************
        //adds the price for each pizza size to its corresponding text
        //****************************************************************
        private void PrintPizzaCost()
        {
            Personal.Text = "Personal (4 slices) $" + pcost;
            Small.Text = "Sm. (6 slices) $" + scost;
            Medium.Text = "Md. (8 slices) $" + mcost;
            Large.Text = "Lg. (8 slices) $" + lcost;
        }

        //***************************************************************
        //sets prices for speciality pizzas and enables the groupbox
        //that determines the size of the pizza
        //***************************************************************
        private void SpecialtyPizza()
        {
            //sets specialty pizza costs based on pizza size
            pcost = 9.99;
            scost = 11.99;
            mcost = 14.99;
            lcost = 17.99;

            //enables pizza size groupbox and disables ever other groubox
            Size.Enabled = true;
            Sauce.Enabled = false;
            CheeseType.Enabled = false;
            Meat.Enabled = false;
            Veggies.Enabled = false;
            PrintPizzaCost();
        }

        //disables all pizza choices
        private void DisablePizzas()
        {
            cheese.Enabled = false;
            MeatLovers.Enabled = false;
            Italiano.Enabled = false;
            Barbecue.Enabled = false;
            VeggieLovers.Enabled = false;
            Build.Enabled = false;
        }

         //******************************************************************
        //changes options for the size of the specialty pizzas
        //*******************************************************************
        private void Cheese_click(object sender, EventArgs e)
        {
            SpecialtyPizza();
            DisablePizzas();
        }

        private void MeatLovers_Click(object sender, EventArgs e)
        {
            SpecialtyPizza();
            DisablePizzas();
        }

        private void Italiano_Click(object sender, EventArgs e)
        {
            SpecialtyPizza();
            DisablePizzas();
        }

        private void Barbecue_Click(object sender, EventArgs e)
        {
            SpecialtyPizza();
            DisablePizzas();
        }

        private void VeggieLovers_Click(object sender, EventArgs e)
        {
            SpecialtyPizza();
            DisablePizzas();
        }

        //function for the build your own pizzas option
        private void Build_Click(object sender, EventArgs e)
        {
            pcost = 5.99;
            scost = 7.99;
            mcost = 9.99;
            lcost = 11.99;
            
            //enables the groupbox for the size of the pizza
            Size.Enabled = true;
            PrintPizzaCost();//updates text based on pizza prices
            DisablePizzas();
            byo = true;//build your own was selected
        }

        //******************************************************************************
        //this function determines which boxes are selected by the time you proceed to
        //checkout. If the box was checked the list string is updated with the content
        //that was in its text and displays the string on another form
        //*******************************************************************************
        private void Order_Click(object sender, EventArgs e)
        {
            if (Personal.Checked)
                list += Personal.Text + System.Environment.NewLine;

            if (Small.Checked)
                list += Small.Text + System.Environment.NewLine;

            if (Medium.Checked)
                list += Medium.Text + System.Environment.NewLine;

            if (Large.Checked)
                list += Large.Text + System.Environment.NewLine;

            if (Alfredo.Checked)
                list += Alfredo.Text + System.Environment.NewLine;

            if (Tomato.Checked)
                list += Tomato.Text + System.Environment.NewLine;

            if (Cheddar.Checked)
                list += Cheddar.Text + System.Environment.NewLine;

            if (Feta.Checked)
                list += Feta.Text + System.Environment.NewLine;

            if (Pep.Checked)
                list += Pep.Text + System.Environment.NewLine;

            if (Sausage.Checked)
                list += Sausage.Text + System.Environment.NewLine;

            if (Bacon.Checked)
                list += Bacon.Text + System.Environment.NewLine;

            if (Ham.Checked)
                list += Ham.Text + System.Environment.NewLine;

            if (MushRooms.Checked)
                list += MushRooms.Text + System.Environment.NewLine;

            if (Onions.Checked)
                list += Onions.Text + System.Environment.NewLine;

            if (Tomatoes.Checked)
                list += Tomatoes.Text + System.Environment.NewLine;

            if (Jalapenos.Checked)
                list += Jalapenos.Text + System.Environment.NewLine;

            //disables all the groupboxes
            Sauce.Enabled = false;
            CheeseType.Enabled = false;
            Meat.Enabled = false;
            Veggies.Enabled = false;

            Cart ct = new Cart(cost, list);//passes cost and list to another form
            ct.Show();
        }

        //prints the circle and half circles to the screen
        private void DisplayHalves()
        {
            Whole.Visible = true;
            Left.Visible = true;
            Right.Visible = true;
        }

        //**************************************************************************
        //function to determine basic options when Size groupbox is chosen
        //called on by every radiobutton in size groupbox
        //**************************************************************************
        private void pizzaSizeCheck()
        {
            if (byo)//the build your own box was chosen do the following
            {
                //makes the user choose a different option and disables the size of the pizza groupbox
                Sauce.Enabled = true;
                CheeseType.Enabled = true;
                Meat.Enabled = true;
                Veggies.Enabled = true;
                Size.Enabled = false;
            }
            else
                //tells the user to proceed to the checkout, doesn't allow extra toppings
                MessageBox.Show("Click the button in the upper right hand corner to proceed to checkout.");

            Order.Text = "Checkout $" + cost;//updates the string with the current cost
            Order.Enabled = true;//enables the my order button when a pizza size is chosen
            Redo.Enabled = true;//lets the user restart
            Size.Enabled = false;//disables the size groupbox
        }

        private void Personal_CheckedChanged(object sender, EventArgs e)
        {
            cost += pcost;//updates cost with personal pizza cost
            pizzaSizeCheck();
        }

        private void Small_CheckedChanged(object sender, EventArgs e)
        {
            cost += scost;//updates cost with small pizza cost
            pizzaSizeCheck();
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            cost += mcost;//updates cost with medium pizza cost
            pizzaSizeCheck();
        }

        private void Large_CheckedChanged(object sender, EventArgs e)
        {
            cost += lcost;//updates cost with large pizza cost
            pizzaSizeCheck();
        }
        
        //****************************************************************************
        //the function below deals with anything relsating to the sauce groupbox
        //****************************************************************************
        
        //sets the sauce group box as the parent of the circles and half circles
        private void sauceOption()
        {
            Left.Parent = Sauce;
            Right.Parent = Sauce;
            Whole.Parent = Sauce;
            DisplayHalves();//displays circles to the screen
        }

        private void Alfredo_CheckedChanged(object sender, EventArgs e)
        {
            sauceOption();
        }

        private void Tomato_CheckedChanged(object sender, EventArgs e)
        {
            sauceOption();
        }

        //****************************************************************************
        //deals with cheese
        //****************************************************************************

        //sets the cheese group box as the parent of the circles and half circles
        private void cheeseOption()
        {
            Left.Parent = CheeseType;
            Right.Parent = CheeseType;
            Whole.Parent = CheeseType;
            DisplayHalves();//displays circles to the screen
        }
        
        private void Feta_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the feta cheese option was selected or not
            cheeseOption();
            if (Feta.Checked)
                cost += 0.39;
            else
                cost -= 0.39;

            Order.Text = "Checkout $" + cost;
        }

        private void Cheddar_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the cheddar cheese option was selected or not
            cheeseOption();
            if (Cheddar.Checked)
                cost += 0.39;
            else
                cost -= 0.39;

            Order.Text = "Checkout $" + cost;
        }

        //*****************************************************************************
        //deals with meat
        //*****************************************************************************

        //sets the meat group box as the parent of the circles and half circles
        private void meatOption()
        {
            Left.Parent = Meat;
            Right.Parent = Meat;
            Whole.Parent = Meat;
            DisplayHalves();//displays circles to the screen
        }

        private void Pep_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the pepperoni option was selected or not
            meatOption();
            if (Pep.Checked)
                cost += 1.19;
            else
                cost -= 1.19;

            Order.Text = "Checkout $" + cost;
        }

        private void Sausage_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the sausage option was selected or not
            meatOption();
            if (Sausage.Checked)
                cost += 1.19;
            else
                cost -= 1.19;

            Order.Text = "Checkout $" + cost;
        }

        private void Bacon_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the bacon option was selected or not
            meatOption();
            if (Bacon.Checked)
                cost += 1.19;
            else
                cost -= 1.19;

            Order.Text = "Checkout $" + cost;
        }

        private void Ham_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the ham option was selected or not
            meatOption();
            if (Ham.Checked)
                cost += 1.19;
            else
                cost -= 1.19;

            Order.Text = "Checkout $" + cost;
        }

        //*****************************************************************************
        //deals with veggies
        //*****************************************************************************

        ////sets the veggie group box as the parent of the circles and half circles
        private void veggieOption()
        {
            Left.Parent = Veggies;
            Right.Parent = Veggies;
            Whole.Parent = Veggies;
            DisplayHalves();//displays circles to the screen
        }

        private void MushRooms_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the mushroom option was selected or not
            veggieOption();
            if (MushRooms.Checked)
                cost += 0.69;
            else
                cost -= 0.69;

            Order.Text = "Checkout $" + cost;
        }

        private void Onions_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the onion option was selected or not
            veggieOption();
            if (Onions.Checked)
                cost += 0.69;
            else
                cost -= 0.69;

            Order.Text = "Checkout $" + cost;
        }
        private void Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the tomatoes option was selected or not
            veggieOption();
            if (Tomatoes.Checked && cost != 0)
                cost += 0.69;
            else
                cost -= 0.69;

            Order.Text = "Checkout $" + cost;
        }

        private void Jalapenos_CheckedChanged(object sender, EventArgs e)
        {
            //updates cost based on whether the jalapeno option was selected or not
            veggieOption();
            if (Jalapenos.Checked)
                cost += 0.69;
            else
                cost -= 0.69;

            Order.Text = "Checkout $" + cost;
        }

        //****************************************************************************
        //event handlers for the circle and the half circles
        //****************************************************************************
        private void Whole_Hover(object sender, EventArgs e)
        {
            //changes to a full shaded circle image when you hover over the full circle
            Whole.Image = Properties.Resources.fillCirc;
        }

        //if the full circle wasn't selected, change back to full unshaded circle after hovering
        private void Whole_Leave(object sender, EventArgs e)
        {
            if (!Wclicked)
                Whole.Image = Properties.Resources.openCirc;
        }

        //changes to shaded full circle when clicked and non shaded left and right half circles
        private void Whole_Click(object sender, EventArgs e)
        {
            Wclicked = true;
            Whole.Image = Properties.Resources.fillCirc;
            Left.Image = Properties.Resources.openLeft;
            Right.Image = Properties.Resources.openRight; 
        }

        //changes to shaded right circle when clicked and non shaded left half circle and full circle
        private void Right_Click(object sender, EventArgs e)
        {
            Rclicked = true;
            Right.Image = Properties.Resources.fillRight;
            Left.Image = Properties.Resources.openLeft;
            Whole.Image = Properties.Resources.openCirc;
        }

        private void Right_Hover(object sender, EventArgs e)
        {
            //changes to a shaded half right circle image when you hover over the half right circle
            Right.Image = Properties.Resources.fillRight;
        }

        //if the right half circle wasn't selected, change back to half right unshaded circle after hovering
        private void Right_Leave(object sender, EventArgs e)
        {
            if (!Rclicked)
                Right.Image = Properties.Resources.openRight;
        }

        //allows the user to reselect options
        private void Redo_Click(object sender, EventArgs e)
        {
            cost = 0.00;
            list = "";
            Order.Text = "Checkout $" + cost;

            cheese.Enabled = true;
            MeatLovers.Enabled = true;
            Italiano.Enabled = true;
            Barbecue.Enabled = true;
            VeggieLovers.Enabled = true;
            Build.Enabled = true;
        }

        //changes to shaded left circle when clicked and non shaded right half circle and full circle
        private void Left_Click(object sender, EventArgs e)
        {
            Lclicked = true;
            Left.Image = Properties.Resources.fillLeft;
            Right.Image = Properties.Resources.openRight;
            Whole.Image = Properties.Resources.openCirc;
        }

        private void Left_Hover(object sender, EventArgs e)
        {
            //changes to a shaded half left circle image when you hover over the half left circle
            Left.Image = Properties.Resources.fillLeft;
        }

        //if the left half circle wasn't selected, change back to half left unshaded circle after hovering
        private void Left_Leave(object sender, EventArgs e)
        {
            if (!Lclicked)
                Left.Image = Properties.Resources.openLeft;
        }
    }
}
