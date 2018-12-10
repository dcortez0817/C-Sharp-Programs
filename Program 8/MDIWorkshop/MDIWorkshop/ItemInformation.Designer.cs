namespace MDIWorkshop
{
    partial class ItemInformation
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
            this.ItemDetails = new System.Windows.Forms.GroupBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Item = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.ItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemDetails
            // 
            this.ItemDetails.Controls.Add(this.Quantity);
            this.ItemDetails.Controls.Add(this.Price);
            this.ItemDetails.Controls.Add(this.Item);
            this.ItemDetails.Controls.Add(this.QuantityLabel);
            this.ItemDetails.Controls.Add(this.PriceLabel);
            this.ItemDetails.Controls.Add(this.ItemLabel);
            this.ItemDetails.Location = new System.Drawing.Point(114, 66);
            this.ItemDetails.Margin = new System.Windows.Forms.Padding(4);
            this.ItemDetails.Name = "ItemDetails";
            this.ItemDetails.Padding = new System.Windows.Forms.Padding(4);
            this.ItemDetails.Size = new System.Drawing.Size(1195, 437);
            this.ItemDetails.TabIndex = 0;
            this.ItemDetails.TabStop = false;
            this.ItemDetails.Text = "Item Details";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(371, 310);
            this.Quantity.Multiline = true;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(581, 63);
            this.Quantity.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(371, 203);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(581, 62);
            this.Price.TabIndex = 4;
            // 
            // Item
            // 
            this.Item.Location = new System.Drawing.Point(371, 108);
            this.Item.Multiline = true;
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(581, 63);
            this.Item.TabIndex = 3;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Location = new System.Drawing.Point(62, 310);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(278, 63);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(62, 203);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(278, 62);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemLabel
            // 
            this.ItemLabel.Location = new System.Drawing.Point(62, 108);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(278, 63);
            this.ItemLabel.TabIndex = 0;
            this.ItemLabel.Text = "Item Name";
            this.ItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(821, 598);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(345, 84);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(272, 598);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(345, 84);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ItemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 751);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ItemDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemInformation";
            this.Text = "Input Item Information";
            this.ItemDetails.ResumeLayout(false);
            this.ItemDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemDetails;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Item;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}