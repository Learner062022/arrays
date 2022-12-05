namespace DylanDeSouzaWk6ExA
{
    partial class Form3
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
            this.lstAustralianStates = new System.Windows.Forms.ListBox();
            this.btnArrayMemberOrder = new System.Windows.Forms.Button();
            this.btnReverseOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAustralianStates
            // 
            this.lstAustralianStates.FormattingEnabled = true;
            this.lstAustralianStates.Location = new System.Drawing.Point(340, 163);
            this.lstAustralianStates.Name = "lstAustralianStates";
            this.lstAustralianStates.Size = new System.Drawing.Size(120, 95);
            this.lstAustralianStates.TabIndex = 3;
            this.lstAustralianStates.SelectedIndexChanged += new System.EventHandler(this.lstAustralianStates_SelectedIndexChanged);
            // 
            // btnArrayMemberOrder
            // 
            this.btnArrayMemberOrder.Location = new System.Drawing.Point(346, 264);
            this.btnArrayMemberOrder.Name = "btnArrayMemberOrder";
            this.btnArrayMemberOrder.Size = new System.Drawing.Size(114, 23);
            this.btnArrayMemberOrder.TabIndex = 2;
            this.btnArrayMemberOrder.Text = "Array Member Order";
            this.btnArrayMemberOrder.UseVisualStyleBackColor = true;
            this.btnArrayMemberOrder.Click += new System.EventHandler(this.btnArrayMemberOrder_Click);
            // 
            // btnReverseOrder
            // 
            this.btnReverseOrder.Location = new System.Drawing.Point(346, 293);
            this.btnReverseOrder.Name = "btnReverseOrder";
            this.btnReverseOrder.Size = new System.Drawing.Size(103, 23);
            this.btnReverseOrder.TabIndex = 4;
            this.btnReverseOrder.Text = "Reverse Order";
            this.btnReverseOrder.UseVisualStyleBackColor = true;
            this.btnReverseOrder.Click += new System.EventHandler(this.btnReverseOrder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReverseOrder);
            this.Controls.Add(this.lstAustralianStates);
            this.Controls.Add(this.btnArrayMemberOrder);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAustralianStates;
        private System.Windows.Forms.Button btnArrayMemberOrder;
        private System.Windows.Forms.Button btnReverseOrder;
    }
}