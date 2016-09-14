namespace Exercise01
{
    partial class Exercise01Form
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnFindNumbers = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(82, 11);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnFindNumbers
            // 
            this.btnFindNumbers.Location = new System.Drawing.Point(82, 39);
            this.btnFindNumbers.Name = "btnFindNumbers";
            this.btnFindNumbers.Size = new System.Drawing.Size(120, 23);
            this.btnFindNumbers.TabIndex = 1;
            this.btnFindNumbers.Text = "Find Numbers";
            this.btnFindNumbers.UseVisualStyleBackColor = true;
            this.btnFindNumbers.Click += new System.EventHandler(this.btnFindNumbers_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(82, 68);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(120, 148);
            this.lstResults.TabIndex = 2;
            // 
            // Exercise01Form
            // 
            this.AcceptButton = this.btnFindNumbers;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnFindNumbers);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercise01Form";
            this.Text = "Hour 14 Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnFindNumbers;
        private System.Windows.Forms.ListBox lstResults;
    }
}

