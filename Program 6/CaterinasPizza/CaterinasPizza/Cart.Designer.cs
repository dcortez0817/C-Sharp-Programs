namespace CaterinasPizza
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.MyCart = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.Totals = new System.Windows.Forms.Panel();
            this.Tot = new System.Windows.Forms.Label();
            this.Tx = new System.Windows.Forms.Label();
            this.SubT = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.PizzaList = new System.Windows.Forms.Label();
            this.AddMore = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.Totals.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyCart
            // 
            this.MyCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MyCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MyCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCart.ForeColor = System.Drawing.Color.White;
            this.MyCart.Location = new System.Drawing.Point(0, 0);
            this.MyCart.Name = "MyCart";
            this.MyCart.Size = new System.Drawing.Size(1191, 95);
            this.MyCart.TabIndex = 0;
            this.MyCart.Text = "My Cart";
            this.MyCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubTotal
            // 
            this.SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTotal.BackColor = System.Drawing.Color.Transparent;
            this.SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubTotal.Location = new System.Drawing.Point(548, 37);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(249, 56);
            this.SubTotal.TabIndex = 1;
            this.SubTotal.Text = "Subtotal:";
            this.SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Totals
            // 
            this.Totals.AutoSize = true;
            this.Totals.BackColor = System.Drawing.Color.White;
            this.Totals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Totals.Controls.Add(this.Checkout);
            this.Totals.Controls.Add(this.AddMore);
            this.Totals.Controls.Add(this.Tot);
            this.Totals.Controls.Add(this.Tx);
            this.Totals.Controls.Add(this.SubT);
            this.Totals.Controls.Add(this.Total);
            this.Totals.Controls.Add(this.Tax);
            this.Totals.Controls.Add(this.SubTotal);
            this.Totals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Totals.Location = new System.Drawing.Point(0, 854);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(1191, 214);
            this.Totals.TabIndex = 2;
            // 
            // Tot
            // 
            this.Tot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tot.BackColor = System.Drawing.Color.Transparent;
            this.Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tot.Location = new System.Drawing.Point(900, 154);
            this.Tot.Name = "Tot";
            this.Tot.Size = new System.Drawing.Size(216, 56);
            this.Tot.TabIndex = 6;
            this.Tot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tx
            // 
            this.Tx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tx.BackColor = System.Drawing.Color.Transparent;
            this.Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tx.Location = new System.Drawing.Point(900, 93);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(216, 56);
            this.Tx.TabIndex = 5;
            this.Tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubT
            // 
            this.SubT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubT.BackColor = System.Drawing.Color.Transparent;
            this.SubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubT.Location = new System.Drawing.Point(900, 37);
            this.SubT.Name = "SubT";
            this.SubT.Size = new System.Drawing.Size(216, 56);
            this.SubT.TabIndex = 4;
            this.SubT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Total.Location = new System.Drawing.Point(548, 154);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(249, 56);
            this.Total.TabIndex = 3;
            this.Total.Text = "Total:";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tax
            // 
            this.Tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tax.BackColor = System.Drawing.Color.Transparent;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tax.Location = new System.Drawing.Point(548, 93);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(249, 56);
            this.Tax.TabIndex = 2;
            this.Tax.Text = "+Tax:";
            this.Tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PizzaList
            // 
            this.PizzaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PizzaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaList.Location = new System.Drawing.Point(0, 95);
            this.PizzaList.Name = "PizzaList";
            this.PizzaList.Size = new System.Drawing.Size(1191, 759);
            this.PizzaList.TabIndex = 3;
            this.PizzaList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddMore
            // 
            this.AddMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMore.ForeColor = System.Drawing.Color.White;
            this.AddMore.Location = new System.Drawing.Point(10, 23);
            this.AddMore.Name = "AddMore";
            this.AddMore.Size = new System.Drawing.Size(258, 55);
            this.AddMore.TabIndex = 7;
            this.AddMore.Text = "Add More";
            this.AddMore.UseVisualStyleBackColor = false;
            this.AddMore.Click += new System.EventHandler(this.AddMore_Click);
            // 
            // Checkout
            // 
            this.Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout.ForeColor = System.Drawing.Color.White;
            this.Checkout.Location = new System.Drawing.Point(284, 23);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(258, 55);
            this.Checkout.TabIndex = 8;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = false;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1191, 1068);
            this.Controls.Add(this.PizzaList);
            this.Controls.Add(this.Totals);
            this.Controls.Add(this.MyCart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cart";
            this.Text = "Cart";
            this.Totals.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyCart;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Panel Totals;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Tx;
        private System.Windows.Forms.Label SubT;
        private System.Windows.Forms.Label Tot;
        private System.Windows.Forms.Label PizzaList;
        private System.Windows.Forms.Button AddMore;
        private System.Windows.Forms.Button Checkout;
    }
}