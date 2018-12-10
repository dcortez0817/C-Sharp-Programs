namespace Part3
{
    partial class PlayerDisplayForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDisplayForm));
            System.Windows.Forms.Label playerIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label battingAverageLabel;
            this.BrowseAll_Button = new System.Windows.Forms.Button();
            this.Query_GroupBox = new System.Windows.Forms.GroupBox();
            this.Find_Button = new System.Windows.Forms.Button();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.baseballDataSet = new Part3.BaseballDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Part3.BaseballDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new Part3.BaseballDataSetTableAdapters.TableAdapterManager();
            this.playersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.playersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playerIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.battingAverageTextBox = new System.Windows.Forms.TextBox();
            playerIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            battingAverageLabel = new System.Windows.Forms.Label();
            this.Query_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).BeginInit();
            this.playersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseAll_Button
            // 
            this.BrowseAll_Button.Location = new System.Drawing.Point(360, 179);
            this.BrowseAll_Button.Name = "BrowseAll_Button";
            this.BrowseAll_Button.Size = new System.Drawing.Size(75, 23);
            this.BrowseAll_Button.TabIndex = 12;
            this.BrowseAll_Button.Text = "Browse All Entries";
            this.BrowseAll_Button.UseVisualStyleBackColor = true;
            this.BrowseAll_Button.Click += new System.EventHandler(this.BrowseAll_Button_Click);
            // 
            // Query_GroupBox
            // 
            this.Query_GroupBox.Controls.Add(this.Find_Button);
            this.Query_GroupBox.Controls.Add(this.LastName_TextBox);
            this.Query_GroupBox.Controls.Add(this.LastName_Label);
            this.Query_GroupBox.Location = new System.Drawing.Point(273, 75);
            this.Query_GroupBox.Name = "Query_GroupBox";
            this.Query_GroupBox.Size = new System.Drawing.Size(256, 84);
            this.Query_GroupBox.TabIndex = 11;
            this.Query_GroupBox.TabStop = false;
            this.Query_GroupBox.Text = "Find Entry By Last Name";
            // 
            // Find_Button
            // 
            this.Find_Button.Location = new System.Drawing.Point(87, 46);
            this.Find_Button.Name = "Find_Button";
            this.Find_Button.Size = new System.Drawing.Size(75, 23);
            this.Find_Button.TabIndex = 2;
            this.Find_Button.Text = "Find";
            this.Find_Button.UseVisualStyleBackColor = true;
            this.Find_Button.Click += new System.EventHandler(this.Find_Button_Click);
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(114, 20);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.LastName_TextBox.TabIndex = 1;
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Location = new System.Drawing.Point(25, 20);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(61, 13);
            this.LastName_Label.TabIndex = 0;
            this.LastName_Label.Text = "Last Name:";
            // 
            // baseballDataSet
            // 
            this.baseballDataSet.DataSetName = "BaseballDataSet";
            this.baseballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.baseballDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Part3.BaseballDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersBindingNavigator
            // 
            this.playersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playersBindingNavigator.BindingSource = this.playersBindingSource;
            this.playersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.playersBindingNavigatorSaveItem});
            this.playersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playersBindingNavigator.Name = "playersBindingNavigator";
            this.playersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playersBindingNavigator.Size = new System.Drawing.Size(608, 25);
            this.playersBindingNavigator.TabIndex = 13;
            this.playersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // playersBindingNavigatorSaveItem
            // 
            this.playersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playersBindingNavigatorSaveItem.Image")));
            this.playersBindingNavigatorSaveItem.Name = "playersBindingNavigatorSaveItem";
            this.playersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.playersBindingNavigatorSaveItem.Text = "Save Data";
            this.playersBindingNavigatorSaveItem.Click += new System.EventHandler(this.playersBindingNavigatorSaveItem_Click_2);
            // 
            // playerIDLabel
            // 
            playerIDLabel.AutoSize = true;
            playerIDLabel.Location = new System.Drawing.Point(66, 67);
            playerIDLabel.Name = "playerIDLabel";
            playerIDLabel.Size = new System.Drawing.Size(53, 13);
            playerIDLabel.TabIndex = 13;
            playerIDLabel.Text = "Player ID:";
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "PlayerID", true));
            this.playerIDTextBox.Location = new System.Drawing.Point(158, 64);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerIDTextBox.TabIndex = 14;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(66, 93);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 90);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(66, 119);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 17;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 116);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // battingAverageLabel
            // 
            battingAverageLabel.AutoSize = true;
            battingAverageLabel.Location = new System.Drawing.Point(66, 145);
            battingAverageLabel.Name = "battingAverageLabel";
            battingAverageLabel.Size = new System.Drawing.Size(86, 13);
            battingAverageLabel.TabIndex = 19;
            battingAverageLabel.Text = "Batting Average:";
            // 
            // battingAverageTextBox
            // 
            this.battingAverageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "BattingAverage", true));
            this.battingAverageTextBox.Location = new System.Drawing.Point(158, 142);
            this.battingAverageTextBox.Name = "battingAverageTextBox";
            this.battingAverageTextBox.Size = new System.Drawing.Size(100, 20);
            this.battingAverageTextBox.TabIndex = 20;
            // 
            // PlayerDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 319);
            this.Controls.Add(playerIDLabel);
            this.Controls.Add(this.playerIDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(battingAverageLabel);
            this.Controls.Add(this.battingAverageTextBox);
            this.Controls.Add(this.playersBindingNavigator);
            this.Controls.Add(this.BrowseAll_Button);
            this.Controls.Add(this.Query_GroupBox);
            this.Name = "PlayerDisplayForm";
            this.Text = "Display Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Query_GroupBox.ResumeLayout(false);
            this.Query_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).EndInit();
            this.playersBindingNavigator.ResumeLayout(false);
            this.playersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BrowseAll_Button;
        private System.Windows.Forms.GroupBox Query_GroupBox;
        private System.Windows.Forms.Button Find_Button;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label LastName_Label;
        private BaseballDataSet baseballDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private BaseballDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private BaseballDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator playersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton playersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox playerIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox battingAverageTextBox;
    }
}

