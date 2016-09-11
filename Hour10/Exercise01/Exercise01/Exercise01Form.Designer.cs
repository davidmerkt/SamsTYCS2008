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
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.lblUppercase = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextBox.Location = new System.Drawing.Point(12, 25);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(260, 20);
            this.txtTextBox.TabIndex = 0;
            this.txtTextBox.TextChanged += new System.EventHandler(this.txtTextBox_TextChanged);
            // 
            // lblUppercase
            // 
            this.lblUppercase.AutoSize = true;
            this.lblUppercase.Location = new System.Drawing.Point(12, 66);
            this.lblUppercase.Name = "lblUppercase";
            this.lblUppercase.Size = new System.Drawing.Size(35, 13);
            this.lblUppercase.TabIndex = 1;
            this.lblUppercase.Text = "label1";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(59, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter Text:";
            // 
            // Exercise01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblUppercase);
            this.Controls.Add(this.txtTextBox);
            this.Name = "Exercise01Form";
            this.Text = "Hour 10 Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Label lblUppercase;
        private System.Windows.Forms.Label lblInstructions;
    }
}

