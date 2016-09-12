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
            this.txtTextToString = new System.Windows.Forms.TextBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblStringToLabel = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextToString
            // 
            this.txtTextToString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToString.Location = new System.Drawing.Point(12, 25);
            this.txtTextToString.Name = "txtTextToString";
            this.txtTextToString.Size = new System.Drawing.Size(260, 20);
            this.txtTextToString.TabIndex = 0;
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(12, 51);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblStringToLabel
            // 
            this.lblStringToLabel.AutoSize = true;
            this.lblStringToLabel.Location = new System.Drawing.Point(12, 77);
            this.lblStringToLabel.Name = "lblStringToLabel";
            this.lblStringToLabel.Size = new System.Drawing.Size(35, 13);
            this.lblStringToLabel.TabIndex = 2;
            this.lblStringToLabel.Text = "label1";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(12, 9);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(59, 13);
            this.lblDirections.TabIndex = 3;
            this.lblDirections.Text = "Enter Text:";
            // 
            // Exercise01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblStringToLabel);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.txtTextToString);
            this.Name = "Exercise01Form";
            this.Text = "Hour 11 Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextToString;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblStringToLabel;
        private System.Windows.Forms.Label lblDirections;
    }
}

