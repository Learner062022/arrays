namespace DylanDeSouzaWk6ExB
{
    partial class Form2
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
            this.lstNamePrice = new System.Windows.Forms.ListBox();
            this.lblEnterAnAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.txtMagazineName = new System.Windows.Forms.TextBox();
            this.btnPriceUnder = new System.Windows.Forms.Button();
            this.btnFindPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNamePrice
            // 
            this.lstNamePrice.FormattingEnabled = true;
            this.lstNamePrice.Location = new System.Drawing.Point(422, 254);
            this.lstNamePrice.Name = "lstNamePrice";
            this.lstNamePrice.Size = new System.Drawing.Size(289, 95);
            this.lstNamePrice.TabIndex = 17;
            // 
            // lblEnterAnAmount
            // 
            this.lblEnterAnAmount.AutoSize = true;
            this.lblEnterAnAmount.Location = new System.Drawing.Point(331, 196);
            this.lblEnterAnAmount.Name = "lblEnterAnAmount";
            this.lblEnterAnAmount.Size = new System.Drawing.Size(85, 13);
            this.lblEnterAnAmount.TabIndex = 16;
            this.lblEnterAnAmount.Text = "Enter an amount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(385, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(422, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(422, 189);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 13;
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Location = new System.Drawing.Point(259, 108);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(157, 13);
            this.lblMagazineName.TabIndex = 12;
            this.lblMagazineName.Text = "Enter the name of the magazine";
            // 
            // txtMagazineName
            // 
            this.txtMagazineName.Location = new System.Drawing.Point(422, 101);
            this.txtMagazineName.Name = "txtMagazineName";
            this.txtMagazineName.Size = new System.Drawing.Size(100, 20);
            this.txtMagazineName.TabIndex = 11;
            // 
            // btnPriceUnder
            // 
            this.btnPriceUnder.Location = new System.Drawing.Point(422, 215);
            this.btnPriceUnder.Name = "btnPriceUnder";
            this.btnPriceUnder.Size = new System.Drawing.Size(75, 23);
            this.btnPriceUnder.TabIndex = 10;
            this.btnPriceUnder.Text = "Price Under";
            this.btnPriceUnder.UseVisualStyleBackColor = true;
            this.btnPriceUnder.Click += new System.EventHandler(this.btnPriceUnder_Click);
            // 
            // btnFindPrice
            // 
            this.btnFindPrice.Location = new System.Drawing.Point(422, 160);
            this.btnFindPrice.Name = "btnFindPrice";
            this.btnFindPrice.Size = new System.Drawing.Size(75, 23);
            this.btnFindPrice.TabIndex = 9;
            this.btnFindPrice.Text = "Find Price";
            this.btnFindPrice.UseVisualStyleBackColor = true;
            this.btnFindPrice.Click += new System.EventHandler(this.btnFindPrice_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNamePrice);
            this.Controls.Add(this.lblEnterAnAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMagazineName);
            this.Controls.Add(this.txtMagazineName);
            this.Controls.Add(this.btnPriceUnder);
            this.Controls.Add(this.btnFindPrice);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNamePrice;
        private System.Windows.Forms.Label lblEnterAnAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.TextBox txtMagazineName;
        private System.Windows.Forms.Button btnPriceUnder;
        private System.Windows.Forms.Button btnFindPrice;
    }
}