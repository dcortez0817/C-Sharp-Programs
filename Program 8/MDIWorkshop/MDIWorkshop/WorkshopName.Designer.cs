namespace MDIWorkshop
{
    partial class WorkshopName
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
            this.label1 = new System.Windows.Forms.Label();
            this.WorkshopEntry = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.notepad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(222, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1110, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the name of the workshop. Then click OK.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WorkshopEntry
            // 
            this.WorkshopEntry.Location = new System.Drawing.Point(230, 481);
            this.WorkshopEntry.Name = "WorkshopEntry";
            this.WorkshopEntry.Size = new System.Drawing.Size(1102, 53);
            this.WorkshopEntry.TabIndex = 2;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(452, 572);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(297, 80);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(791, 572);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(297, 80);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // notepad
            // 
            this.notepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notepad.Image = global::MDIWorkshop.Properties.Resources.notepad;
            this.notepad.Location = new System.Drawing.Point(605, 90);
            this.notepad.Margin = new System.Windows.Forms.Padding(4);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(359, 289);
            this.notepad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notepad.TabIndex = 0;
            this.notepad.TabStop = false;
            // 
            // WorkshopName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 751);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.WorkshopEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notepad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkshopName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Workshop Name";
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox notepad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WorkshopEntry;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}