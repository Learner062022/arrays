namespace DylanDeSouzaWk6ExB
{
    partial class Form1
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
            this.btnFindPrice = new System.Windows.Forms.Button();
            this.txtMagazineName = new System.Windows.Forms.TextBox();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindPrice
            // 
            this.btnFindPrice.Location = new System.Drawing.Point(352, 199);
            this.btnFindPrice.Name = "btnFindPrice";
            this.btnFindPrice.Size = new System.Drawing.Size(75, 23);
            this.btnFindPrice.TabIndex = 0;
            this.btnFindPrice.Text = "Find Price";
            this.btnFindPrice.UseVisualStyleBackColor = true;
            this.btnFindPrice.Click += new System.EventHandler(this.btnFindPrice_Click);
            // 
            // txtMagazineName
            // 
            this.txtMagazineName.Location = new System.Drawing.Point(352, 140);
            this.txtMagazineName.Name = "txtMagazineName";
            this.txtMagazineName.Size = new System.Drawing.Size(100, 20);
            this.txtMagazineName.TabIndex = 2;
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Location = new System.Drawing.Point(189, 147);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(157, 13);
            this.lblMagazineName.TabIndex = 3;
            this.lblMagazineName.Text = "Enter the name of the magazine";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(352, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(315, 173);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblMagazineName);
            this.Controls.Add(this.txtMagazineName);
            this.Controls.Add(this.btnFindPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindPrice;
        private System.Windows.Forms.TextBox txtMagazineName;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}

