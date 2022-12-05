namespace DylanDeSouzaWk6ExA
{
    partial class Form5
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
            this.btnClick = new System.Windows.Forms.Button();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.lblDogName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(326, 180);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(114, 23);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(340, 137);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(100, 20);
            this.txtDogName.TabIndex = 9;
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.Location = new System.Drawing.Point(239, 144);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(92, 13);
            this.lblDogName.TabIndex = 10;
            this.lblDogName.Text = "Enter a dog breed";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDogName);
            this.Controls.Add(this.txtDogName);
            this.Controls.Add(this.btnClick);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Label lblDogName;
    }
}