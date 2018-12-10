namespace CaterinasPizza
{
    partial class Caterinas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caterinas));
            this.Menu = new System.Windows.Forms.GroupBox();
            this.Veggies = new System.Windows.Forms.GroupBox();
            this.Jalapenos = new System.Windows.Forms.CheckBox();
            this.Tomatoes = new System.Windows.Forms.CheckBox();
            this.Onions = new System.Windows.Forms.CheckBox();
            this.MushRooms = new System.Windows.Forms.CheckBox();
            this.Meat = new System.Windows.Forms.GroupBox();
            this.Ham = new System.Windows.Forms.CheckBox();
            this.Bacon = new System.Windows.Forms.CheckBox();
            this.Sausage = new System.Windows.Forms.CheckBox();
            this.Pep = new System.Windows.Forms.CheckBox();
            this.CheeseType = new System.Windows.Forms.GroupBox();
            this.Cheddar = new System.Windows.Forms.RadioButton();
            this.Right = new System.Windows.Forms.PictureBox();
            this.Feta = new System.Windows.Forms.RadioButton();
            this.Left = new System.Windows.Forms.PictureBox();
            this.Whole = new System.Windows.Forms.PictureBox();
            this.Sauce = new System.Windows.Forms.GroupBox();
            this.Alfredo = new System.Windows.Forms.RadioButton();
            this.Tomato = new System.Windows.Forms.RadioButton();
            this.Size = new System.Windows.Forms.GroupBox();
            this.Personal = new System.Windows.Forms.RadioButton();
            this.Small = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Large = new System.Windows.Forms.RadioButton();
            this.Order = new System.Windows.Forms.Button();
            this.Build = new System.Windows.Forms.Panel();
            this.BuildLabel = new System.Windows.Forms.Label();
            this.Barbecue = new System.Windows.Forms.Panel();
            this.BarbecueLabel = new System.Windows.Forms.Label();
            this.Italiano = new System.Windows.Forms.Panel();
            this.ItalianoLabel = new System.Windows.Forms.Label();
            this.VeggieLovers = new System.Windows.Forms.Panel();
            this.VeggieLabel = new System.Windows.Forms.Label();
            this.MeatLovers = new System.Windows.Forms.Panel();
            this.MeatLabel = new System.Windows.Forms.Label();
            this.cheese = new System.Windows.Forms.Panel();
            this.cheeseLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Redo = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.Veggies.SuspendLayout();
            this.Meat.SuspendLayout();
            this.CheeseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whole)).BeginInit();
            this.Sauce.SuspendLayout();
            this.Size.SuspendLayout();
            this.Build.SuspendLayout();
            this.Barbecue.SuspendLayout();
            this.Italiano.SuspendLayout();
            this.VeggieLovers.SuspendLayout();
            this.MeatLovers.SuspendLayout();
            this.cheese.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Menu.Controls.Add(this.Veggies);
            this.Menu.Controls.Add(this.Meat);
            this.Menu.Controls.Add(this.CheeseType);
            this.Menu.Controls.Add(this.Sauce);
            this.Menu.Controls.Add(this.Size);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(0, 84);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(531, 802);
            this.Menu.TabIndex = 2;
            this.Menu.TabStop = false;
            this.Menu.Text = "Pizza Options";
            // 
            // Veggies
            // 
            this.Veggies.Controls.Add(this.Jalapenos);
            this.Veggies.Controls.Add(this.Tomatoes);
            this.Veggies.Controls.Add(this.Onions);
            this.Veggies.Controls.Add(this.MushRooms);
            this.Veggies.Enabled = false;
            this.Veggies.ForeColor = System.Drawing.Color.OrangeRed;
            this.Veggies.Location = new System.Drawing.Point(12, 543);
            this.Veggies.Name = "Veggies";
            this.Veggies.Size = new System.Drawing.Size(461, 153);
            this.Veggies.TabIndex = 20;
            this.Veggies.TabStop = false;
            this.Veggies.Text = "Select Veggies";
            // 
            // Jalapenos
            // 
            this.Jalapenos.ForeColor = System.Drawing.Color.White;
            this.Jalapenos.Location = new System.Drawing.Point(18, 101);
            this.Jalapenos.Name = "Jalapenos";
            this.Jalapenos.Size = new System.Drawing.Size(215, 36);
            this.Jalapenos.TabIndex = 18;
            this.Jalapenos.Text = "Jalapenos";
            this.Jalapenos.UseVisualStyleBackColor = true;
            this.Jalapenos.CheckedChanged += new System.EventHandler(this.Jalapenos_CheckedChanged);
            // 
            // Tomatoes
            // 
            this.Tomatoes.ForeColor = System.Drawing.Color.White;
            this.Tomatoes.Location = new System.Drawing.Point(18, 78);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(215, 36);
            this.Tomatoes.TabIndex = 18;
            this.Tomatoes.Text = "Tomatoes";
            this.Tomatoes.UseVisualStyleBackColor = true;
            this.Tomatoes.CheckedChanged += new System.EventHandler(this.Tomatoes_CheckedChanged);
            // 
            // Onions
            // 
            this.Onions.ForeColor = System.Drawing.Color.White;
            this.Onions.Location = new System.Drawing.Point(18, 50);
            this.Onions.Name = "Onions";
            this.Onions.Size = new System.Drawing.Size(215, 36);
            this.Onions.TabIndex = 17;
            this.Onions.Text = "Onions";
            this.Onions.UseVisualStyleBackColor = true;
            this.Onions.CheckedChanged += new System.EventHandler(this.Onions_CheckedChanged);
            // 
            // MushRooms
            // 
            this.MushRooms.ForeColor = System.Drawing.Color.White;
            this.MushRooms.Location = new System.Drawing.Point(18, 28);
            this.MushRooms.Name = "MushRooms";
            this.MushRooms.Size = new System.Drawing.Size(215, 36);
            this.MushRooms.TabIndex = 0;
            this.MushRooms.Text = "Mushrooms";
            this.MushRooms.UseVisualStyleBackColor = true;
            this.MushRooms.CheckedChanged += new System.EventHandler(this.MushRooms_CheckedChanged);
            // 
            // Meat
            // 
            this.Meat.Controls.Add(this.Ham);
            this.Meat.Controls.Add(this.Bacon);
            this.Meat.Controls.Add(this.Sausage);
            this.Meat.Controls.Add(this.Pep);
            this.Meat.Enabled = false;
            this.Meat.ForeColor = System.Drawing.Color.OrangeRed;
            this.Meat.Location = new System.Drawing.Point(12, 385);
            this.Meat.Name = "Meat";
            this.Meat.Size = new System.Drawing.Size(461, 152);
            this.Meat.TabIndex = 16;
            this.Meat.TabStop = false;
            this.Meat.Text = "Select Meat";
            // 
            // Ham
            // 
            this.Ham.ForeColor = System.Drawing.Color.White;
            this.Ham.Location = new System.Drawing.Point(18, 103);
            this.Ham.Name = "Ham";
            this.Ham.Size = new System.Drawing.Size(215, 36);
            this.Ham.TabIndex = 18;
            this.Ham.Text = "Ham";
            this.Ham.UseVisualStyleBackColor = true;
            this.Ham.CheckedChanged += new System.EventHandler(this.Ham_CheckedChanged);
            // 
            // Bacon
            // 
            this.Bacon.ForeColor = System.Drawing.Color.White;
            this.Bacon.Location = new System.Drawing.Point(18, 72);
            this.Bacon.Name = "Bacon";
            this.Bacon.Size = new System.Drawing.Size(215, 37);
            this.Bacon.TabIndex = 18;
            this.Bacon.Text = "Bacon";
            this.Bacon.UseVisualStyleBackColor = true;
            this.Bacon.CheckedChanged += new System.EventHandler(this.Bacon_CheckedChanged);
            // 
            // Sausage
            // 
            this.Sausage.ForeColor = System.Drawing.Color.White;
            this.Sausage.Location = new System.Drawing.Point(18, 48);
            this.Sausage.Name = "Sausage";
            this.Sausage.Size = new System.Drawing.Size(215, 36);
            this.Sausage.TabIndex = 17;
            this.Sausage.Text = "Sausage";
            this.Sausage.UseVisualStyleBackColor = true;
            this.Sausage.CheckedChanged += new System.EventHandler(this.Sausage_CheckedChanged);
            // 
            // Pep
            // 
            this.Pep.ForeColor = System.Drawing.Color.White;
            this.Pep.Location = new System.Drawing.Point(18, 19);
            this.Pep.Name = "Pep";
            this.Pep.Size = new System.Drawing.Size(215, 36);
            this.Pep.TabIndex = 0;
            this.Pep.Text = "Pepperoni";
            this.Pep.UseVisualStyleBackColor = true;
            this.Pep.CheckedChanged += new System.EventHandler(this.Pep_CheckedChanged);
            // 
            // CheeseType
            // 
            this.CheeseType.Controls.Add(this.Cheddar);
            this.CheeseType.Controls.Add(this.Right);
            this.CheeseType.Controls.Add(this.Feta);
            this.CheeseType.Controls.Add(this.Left);
            this.CheeseType.Controls.Add(this.Whole);
            this.CheeseType.Enabled = false;
            this.CheeseType.ForeColor = System.Drawing.Color.OrangeRed;
            this.CheeseType.Location = new System.Drawing.Point(12, 280);
            this.CheeseType.Name = "CheeseType";
            this.CheeseType.Size = new System.Drawing.Size(461, 99);
            this.CheeseType.TabIndex = 17;
            this.CheeseType.TabStop = false;
            this.CheeseType.Text = "Select Cheese";
            // 
            // Cheddar
            // 
            this.Cheddar.ForeColor = System.Drawing.Color.White;
            this.Cheddar.Location = new System.Drawing.Point(18, 24);
            this.Cheddar.Name = "Cheddar";
            this.Cheddar.Size = new System.Drawing.Size(215, 36);
            this.Cheddar.TabIndex = 4;
            this.Cheddar.TabStop = true;
            this.Cheddar.Text = "Cheddar Cheese";
            this.Cheddar.UseVisualStyleBackColor = true;
            this.Cheddar.CheckedChanged += new System.EventHandler(this.Cheddar_CheckedChanged);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.White;
            this.Right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Right.Image = global::CaterinasPizza.Properties.Resources.openRight;
            this.Right.Location = new System.Drawing.Point(388, 24);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(55, 55);
            this.Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Right.TabIndex = 13;
            this.Right.TabStop = false;
            this.Right.Visible = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            this.Right.MouseLeave += new System.EventHandler(this.Right_Leave);
            this.Right.MouseHover += new System.EventHandler(this.Right_Hover);
            // 
            // Feta
            // 
            this.Feta.ForeColor = System.Drawing.Color.White;
            this.Feta.Location = new System.Drawing.Point(18, 57);
            this.Feta.Name = "Feta";
            this.Feta.Size = new System.Drawing.Size(215, 36);
            this.Feta.TabIndex = 4;
            this.Feta.TabStop = true;
            this.Feta.Text = "Feta Cheese";
            this.Feta.UseVisualStyleBackColor = true;
            this.Feta.CheckedChanged += new System.EventHandler(this.Feta_CheckedChanged);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Left.Image = global::CaterinasPizza.Properties.Resources.openLeft;
            this.Left.Location = new System.Drawing.Point(239, 24);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(55, 55);
            this.Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Left.TabIndex = 12;
            this.Left.TabStop = false;
            this.Left.Visible = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            this.Left.MouseLeave += new System.EventHandler(this.Left_Leave);
            this.Left.MouseHover += new System.EventHandler(this.Left_Hover);
            // 
            // Whole
            // 
            this.Whole.BackColor = System.Drawing.Color.White;
            this.Whole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Whole.Image = global::CaterinasPizza.Properties.Resources.openCirc;
            this.Whole.Location = new System.Drawing.Point(313, 24);
            this.Whole.Name = "Whole";
            this.Whole.Size = new System.Drawing.Size(55, 55);
            this.Whole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Whole.TabIndex = 9;
            this.Whole.TabStop = false;
            this.Whole.Visible = false;
            this.Whole.Click += new System.EventHandler(this.Whole_Click);
            this.Whole.MouseLeave += new System.EventHandler(this.Whole_Leave);
            this.Whole.MouseHover += new System.EventHandler(this.Whole_Hover);
            // 
            // Sauce
            // 
            this.Sauce.Controls.Add(this.Alfredo);
            this.Sauce.Controls.Add(this.Tomato);
            this.Sauce.Enabled = false;
            this.Sauce.ForeColor = System.Drawing.Color.OrangeRed;
            this.Sauce.Location = new System.Drawing.Point(12, 183);
            this.Sauce.Name = "Sauce";
            this.Sauce.Size = new System.Drawing.Size(461, 91);
            this.Sauce.TabIndex = 16;
            this.Sauce.TabStop = false;
            this.Sauce.Text = "Select Sauce";
            // 
            // Alfredo
            // 
            this.Alfredo.ForeColor = System.Drawing.Color.White;
            this.Alfredo.Location = new System.Drawing.Point(18, 25);
            this.Alfredo.Name = "Alfredo";
            this.Alfredo.Size = new System.Drawing.Size(215, 36);
            this.Alfredo.TabIndex = 4;
            this.Alfredo.TabStop = true;
            this.Alfredo.Text = "Alfredo Sauce";
            this.Alfredo.UseVisualStyleBackColor = true;
            this.Alfredo.CheckedChanged += new System.EventHandler(this.Alfredo_CheckedChanged);
            // 
            // Tomato
            // 
            this.Tomato.ForeColor = System.Drawing.Color.White;
            this.Tomato.Location = new System.Drawing.Point(18, 51);
            this.Tomato.Name = "Tomato";
            this.Tomato.Size = new System.Drawing.Size(215, 36);
            this.Tomato.TabIndex = 4;
            this.Tomato.TabStop = true;
            this.Tomato.Text = "Tomato Sauce";
            this.Tomato.UseVisualStyleBackColor = true;
            this.Tomato.CheckedChanged += new System.EventHandler(this.Tomato_CheckedChanged);
            // 
            // Size
            // 
            this.Size.Controls.Add(this.Personal);
            this.Size.Controls.Add(this.Small);
            this.Size.Controls.Add(this.Medium);
            this.Size.Controls.Add(this.Large);
            this.Size.Enabled = false;
            this.Size.ForeColor = System.Drawing.Color.OrangeRed;
            this.Size.Location = new System.Drawing.Point(12, 26);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(461, 151);
            this.Size.TabIndex = 15;
            this.Size.TabStop = false;
            this.Size.Text = "Select size of pizza";
            // 
            // Personal
            // 
            this.Personal.ForeColor = System.Drawing.Color.White;
            this.Personal.Location = new System.Drawing.Point(18, 18);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(215, 36);
            this.Personal.TabIndex = 4;
            this.Personal.TabStop = true;
            this.Personal.Text = "Personal (4 slices)";
            this.Personal.UseVisualStyleBackColor = true;
            this.Personal.CheckedChanged += new System.EventHandler(this.Personal_CheckedChanged);
            // 
            // Small
            // 
            this.Small.ForeColor = System.Drawing.Color.White;
            this.Small.Location = new System.Drawing.Point(18, 44);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(215, 36);
            this.Small.TabIndex = 4;
            this.Small.TabStop = true;
            this.Small.Text = "Sm. (6 slices)";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.CheckedChanged += new System.EventHandler(this.Small_CheckedChanged);
            // 
            // Medium
            // 
            this.Medium.ForeColor = System.Drawing.Color.White;
            this.Medium.Location = new System.Drawing.Point(18, 75);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(215, 36);
            this.Medium.TabIndex = 5;
            this.Medium.TabStop = true;
            this.Medium.Text = "Md. (8 slices)";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // Large
            // 
            this.Large.ForeColor = System.Drawing.Color.White;
            this.Large.Location = new System.Drawing.Point(18, 105);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(215, 36);
            this.Large.TabIndex = 3;
            this.Large.TabStop = true;
            this.Large.Text = "Lg. (8 slices)";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.CheckedChanged += new System.EventHandler(this.Large_CheckedChanged);
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.White;
            this.Order.Enabled = false;
            this.Order.ForeColor = System.Drawing.Color.OrangeRed;
            this.Order.Location = new System.Drawing.Point(1310, 33);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(212, 32);
            this.Order.TabIndex = 14;
            this.Order.Text = "Checkout";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Build
            // 
            this.Build.BackColor = System.Drawing.Color.White;
            this.Build.BackgroundImage = global::CaterinasPizza.Properties.Resources.Pepperoni;
            this.Build.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Build.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Build.Controls.Add(this.BuildLabel);
            this.Build.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Build.Location = new System.Drawing.Point(943, 571);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(311, 193);
            this.Build.TabIndex = 8;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // BuildLabel
            // 
            this.BuildLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.BuildLabel.Location = new System.Drawing.Point(0, 0);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(307, 32);
            this.BuildLabel.TabIndex = 0;
            this.BuildLabel.Text = "Build Your Own";
            this.BuildLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Barbecue
            // 
            this.Barbecue.BackColor = System.Drawing.Color.White;
            this.Barbecue.BackgroundImage = global::CaterinasPizza.Properties.Resources.Barbecue;
            this.Barbecue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Barbecue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Barbecue.Controls.Add(this.BarbecueLabel);
            this.Barbecue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Barbecue.Location = new System.Drawing.Point(943, 342);
            this.Barbecue.Name = "Barbecue";
            this.Barbecue.Size = new System.Drawing.Size(311, 193);
            this.Barbecue.TabIndex = 7;
            this.Barbecue.Click += new System.EventHandler(this.Barbecue_Click);
            // 
            // BarbecueLabel
            // 
            this.BarbecueLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarbecueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarbecueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarbecueLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.BarbecueLabel.Location = new System.Drawing.Point(0, 0);
            this.BarbecueLabel.Name = "BarbecueLabel";
            this.BarbecueLabel.Size = new System.Drawing.Size(307, 32);
            this.BarbecueLabel.TabIndex = 0;
            this.BarbecueLabel.Text = "Barbecue Chicken";
            this.BarbecueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Italiano
            // 
            this.Italiano.BackColor = System.Drawing.Color.White;
            this.Italiano.BackgroundImage = global::CaterinasPizza.Properties.Resources.Iltaliano;
            this.Italiano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Italiano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Italiano.Controls.Add(this.ItalianoLabel);
            this.Italiano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Italiano.Location = new System.Drawing.Point(580, 342);
            this.Italiano.Name = "Italiano";
            this.Italiano.Size = new System.Drawing.Size(311, 193);
            this.Italiano.TabIndex = 6;
            this.Italiano.Click += new System.EventHandler(this.Italiano_Click);
            // 
            // ItalianoLabel
            // 
            this.ItalianoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItalianoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalianoLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ItalianoLabel.Location = new System.Drawing.Point(0, 0);
            this.ItalianoLabel.Name = "ItalianoLabel";
            this.ItalianoLabel.Size = new System.Drawing.Size(307, 32);
            this.ItalianoLabel.TabIndex = 0;
            this.ItalianoLabel.Text = "Caterina\'s Italiano";
            this.ItalianoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VeggieLovers
            // 
            this.VeggieLovers.BackgroundImage = global::CaterinasPizza.Properties.Resources.Veggie;
            this.VeggieLovers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VeggieLovers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VeggieLovers.Controls.Add(this.VeggieLabel);
            this.VeggieLovers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VeggieLovers.Location = new System.Drawing.Point(580, 571);
            this.VeggieLovers.Name = "VeggieLovers";
            this.VeggieLovers.Size = new System.Drawing.Size(311, 193);
            this.VeggieLovers.TabIndex = 5;
            this.VeggieLovers.Click += new System.EventHandler(this.VeggieLovers_Click);
            // 
            // VeggieLabel
            // 
            this.VeggieLabel.BackColor = System.Drawing.Color.White;
            this.VeggieLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VeggieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeggieLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.VeggieLabel.Location = new System.Drawing.Point(0, 0);
            this.VeggieLabel.Name = "VeggieLabel";
            this.VeggieLabel.Size = new System.Drawing.Size(307, 32);
            this.VeggieLabel.TabIndex = 0;
            this.VeggieLabel.Text = "Veggie Lovers";
            this.VeggieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeatLovers
            // 
            this.MeatLovers.BackgroundImage = global::CaterinasPizza.Properties.Resources.MeatLovers;
            this.MeatLovers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MeatLovers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MeatLovers.Controls.Add(this.MeatLabel);
            this.MeatLovers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MeatLovers.Location = new System.Drawing.Point(943, 110);
            this.MeatLovers.Name = "MeatLovers";
            this.MeatLovers.Size = new System.Drawing.Size(311, 193);
            this.MeatLovers.TabIndex = 4;
            this.MeatLovers.Click += new System.EventHandler(this.MeatLovers_Click);
            // 
            // MeatLabel
            // 
            this.MeatLabel.BackColor = System.Drawing.Color.White;
            this.MeatLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeatLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.MeatLabel.Location = new System.Drawing.Point(0, 0);
            this.MeatLabel.Name = "MeatLabel";
            this.MeatLabel.Size = new System.Drawing.Size(307, 32);
            this.MeatLabel.TabIndex = 0;
            this.MeatLabel.Text = "Meat Lovers";
            this.MeatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cheese
            // 
            this.cheese.BackColor = System.Drawing.Color.White;
            this.cheese.BackgroundImage = global::CaterinasPizza.Properties.Resources.Cheese;
            this.cheese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cheese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cheese.Controls.Add(this.cheeseLabel);
            this.cheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheese.Location = new System.Drawing.Point(580, 110);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(311, 193);
            this.cheese.TabIndex = 3;
            this.cheese.Click += new System.EventHandler(this.Cheese_click);
            // 
            // cheeseLabel
            // 
            this.cheeseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cheeseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheeseLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.cheeseLabel.Location = new System.Drawing.Point(0, 0);
            this.cheeseLabel.Name = "cheeseLabel";
            this.cheeseLabel.Size = new System.Drawing.Size(307, 32);
            this.cheeseLabel.TabIndex = 0;
            this.cheeseLabel.Text = "Cheese Lovers";
            this.cheeseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logo.Image = global::CaterinasPizza.Properties.Resources.pizza;
            this.logo.Location = new System.Drawing.Point(431, 33);
            this.logo.Margin = new System.Windows.Forms.Padding(5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(66, 41);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1645, 84);
            this.Title.TabIndex = 0;
            this.Title.Text = "Caterinas\' Pizza";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Redo
            // 
            this.Redo.BackColor = System.Drawing.Color.White;
            this.Redo.Enabled = false;
            this.Redo.ForeColor = System.Drawing.Color.OrangeRed;
            this.Redo.Location = new System.Drawing.Point(1321, 110);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(212, 32);
            this.Redo.TabIndex = 15;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = false;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Caterinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1645, 886);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Barbecue);
            this.Controls.Add(this.Italiano);
            this.Controls.Add(this.VeggieLovers);
            this.Controls.Add(this.MeatLovers);
            this.Controls.Add(this.cheese);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Caterinas";
            this.Text = "Caterinas\' Pizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Veggies.ResumeLayout(false);
            this.Meat.ResumeLayout(false);
            this.CheeseType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whole)).EndInit();
            this.Sauce.ResumeLayout(false);
            this.Size.ResumeLayout(false);
            this.Build.ResumeLayout(false);
            this.Barbecue.ResumeLayout(false);
            this.Italiano.ResumeLayout(false);
            this.VeggieLovers.ResumeLayout(false);
            this.MeatLovers.ResumeLayout(false);
            this.cheese.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Personal;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.Panel cheese;
        private System.Windows.Forms.Label cheeseLabel;
        private System.Windows.Forms.Panel MeatLovers;
        private System.Windows.Forms.Panel VeggieLovers;
        private System.Windows.Forms.Label MeatLabel;
        private System.Windows.Forms.Label VeggieLabel;
        private System.Windows.Forms.Panel Italiano;
        private System.Windows.Forms.Label ItalianoLabel;
        private System.Windows.Forms.Panel Barbecue;
        private System.Windows.Forms.Label BarbecueLabel;
        private System.Windows.Forms.Panel Build;
        private System.Windows.Forms.Label BuildLabel;
        private System.Windows.Forms.PictureBox Whole;
        private System.Windows.Forms.PictureBox Left;
        private System.Windows.Forms.PictureBox Right;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.GroupBox Sauce;
        private System.Windows.Forms.RadioButton Alfredo;
        private System.Windows.Forms.RadioButton Tomato;
        private System.Windows.Forms.GroupBox CheeseType;
        private System.Windows.Forms.RadioButton Cheddar;
        private System.Windows.Forms.RadioButton Feta;
        private System.Windows.Forms.GroupBox Veggies;
        private System.Windows.Forms.CheckBox Jalapenos;
        private System.Windows.Forms.CheckBox Tomatoes;
        private System.Windows.Forms.CheckBox Onions;
        private System.Windows.Forms.CheckBox MushRooms;
        private System.Windows.Forms.GroupBox Meat;
        private System.Windows.Forms.CheckBox Ham;
        private System.Windows.Forms.CheckBox Bacon;
        private System.Windows.Forms.CheckBox Sausage;
        private System.Windows.Forms.CheckBox Pep;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Redo;
    }
}

