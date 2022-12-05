namespace DylanDeSouzaWk6ExA
{
    partial class Form4
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
            this.lstDogNamesNumbers = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDogNamesNumbers
            // 
            this.lstDogNamesNumbers.FormattingEnabled = true;
            this.lstDogNamesNumbers.Location = new System.Drawing.Point(340, 149);
            this.lstDogNamesNumbers.Name = "lstDogNamesNumbers";
            this.lstDogNamesNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstDogNamesNumbers.TabIndex = 6;
            this.lstDogNamesNumbers.Visible = false;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(346, 250);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(114, 23);
            this.btnClick.TabIndex = 5;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDogNamesNumbers);
            this.Controls.Add(this.btnClick);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstDogNamesNumbers;
        private System.Windows.Forms.Button btnClick;
    }
}