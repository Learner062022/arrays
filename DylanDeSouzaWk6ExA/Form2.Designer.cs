namespace DylanDeSouzaWk6ExA
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
            this.btnArrayMemberOrder = new System.Windows.Forms.Button();
            this.lstAustralianStates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnArrayMemberOrder
            // 
            this.btnArrayMemberOrder.Location = new System.Drawing.Point(356, 231);
            this.btnArrayMemberOrder.Name = "btnArrayMemberOrder";
            this.btnArrayMemberOrder.Size = new System.Drawing.Size(114, 23);
            this.btnArrayMemberOrder.TabIndex = 0;
            this.btnArrayMemberOrder.Text = "Array Member Order";
            this.btnArrayMemberOrder.UseVisualStyleBackColor = true;
            this.btnArrayMemberOrder.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lstAustralianStates
            // 
            this.lstAustralianStates.FormattingEnabled = true;
            this.lstAustralianStates.Location = new System.Drawing.Point(350, 130);
            this.lstAustralianStates.Name = "lstAustralianStates";
            this.lstAustralianStates.Size = new System.Drawing.Size(120, 95);
            this.lstAustralianStates.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAustralianStates);
            this.Controls.Add(this.btnArrayMemberOrder);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayMemberOrder;
        private System.Windows.Forms.ListBox lstAustralianStates;
    }
}