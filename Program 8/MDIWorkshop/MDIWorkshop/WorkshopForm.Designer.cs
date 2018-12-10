namespace MDIWorkshop
{
    partial class WorkshopForm
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
            this.WorkshopList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // WorkshopList
            // 
            this.WorkshopList.DisplayMember = "(none)";
            this.WorkshopList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkshopList.FormattingEnabled = true;
            this.WorkshopList.ItemHeight = 46;
            this.WorkshopList.Items.AddRange(new object[] {
            "Item Name\\t\\tPrice\\t\\t\\tQuantity"});
            this.WorkshopList.Location = new System.Drawing.Point(0, 0);
            this.WorkshopList.Name = "WorkshopList";
            this.WorkshopList.Size = new System.Drawing.Size(1527, 751);
            this.WorkshopList.TabIndex = 0;
            // 
            // WorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 751);
            this.Controls.Add(this.WorkshopList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkshopForm";
            this.Text = "Workshop";
            this.Load += new System.EventHandler(this.WorkshopForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox WorkshopList;
    }
}