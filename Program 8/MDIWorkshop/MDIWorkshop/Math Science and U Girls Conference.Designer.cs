namespace MDIWorkshop
{
    partial class Conference
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWorkshop = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWorkshop = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveWorkshop = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitWorkshop = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1527, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWorkshop,
            this.OpenWorkshop,
            this.SaveWorkshop,
            this.ExitWorkshop});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(75, 48);
            this.File.Text = "File";
            // 
            // NewWorkshop
            // 
            this.NewWorkshop.Name = "NewWorkshop";
            this.NewWorkshop.Size = new System.Drawing.Size(206, 46);
            this.NewWorkshop.Text = "New";
            this.NewWorkshop.Click += new System.EventHandler(this.NewWorkshop_Click);
            // 
            // OpenWorkshop
            // 
            this.OpenWorkshop.Name = "OpenWorkshop";
            this.OpenWorkshop.Size = new System.Drawing.Size(206, 46);
            this.OpenWorkshop.Text = "Open";
            this.OpenWorkshop.Click += new System.EventHandler(this.OpenWorkshop_Click);
            // 
            // SaveWorkshop
            // 
            this.SaveWorkshop.Name = "SaveWorkshop";
            this.SaveWorkshop.Size = new System.Drawing.Size(206, 46);
            this.SaveWorkshop.Text = "Save";
            this.SaveWorkshop.Click += new System.EventHandler(this.SaveWorkshop_Click);
            // 
            // ExitWorkshop
            // 
            this.ExitWorkshop.Name = "ExitWorkshop";
            this.ExitWorkshop.ShortcutKeyDisplayString = "";
            this.ExitWorkshop.Size = new System.Drawing.Size(206, 46);
            this.ExitWorkshop.Text = "Exit";
            this.ExitWorkshop.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertItem,
            this.DeleteItem,
            this.Update});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(80, 48);
            this.Edit.Text = "Edit";
            // 
            // InsertItem
            // 
            this.InsertItem.Name = "InsertItem";
            this.InsertItem.Size = new System.Drawing.Size(396, 46);
            this.InsertItem.Text = "Insert";
            this.InsertItem.Click += new System.EventHandler(this.InsertItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(396, 46);
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // Update
            // 
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(396, 46);
            this.Update.Text = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(112, 48);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Conference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 747);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Conference";
            this.Text = "Math, Science & U Girls Conference";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem NewWorkshop;
        private System.Windows.Forms.ToolStripMenuItem OpenWorkshop;
        private System.Windows.Forms.ToolStripMenuItem SaveWorkshop;
        private System.Windows.Forms.ToolStripMenuItem ExitWorkshop;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem InsertItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem Update;
        private System.Windows.Forms.ToolStripMenuItem About;
    }
}

