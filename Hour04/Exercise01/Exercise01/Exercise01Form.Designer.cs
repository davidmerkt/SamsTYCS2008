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
            this.lblDescriptiveText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescriptiveText
            // 
            this.lblDescriptiveText.AutoSize = true;
            this.lblDescriptiveText.Location = new System.Drawing.Point(34, 98);
            this.lblDescriptiveText.Name = "lblDescriptiveText";
            this.lblDescriptiveText.Size = new System.Drawing.Size(211, 52);
            this.lblDescriptiveText.TabIndex = 0;
            this.lblDescriptiveText.Text = "Use the knowledge you’ve gained so far \r\nto create a new project with a form that" +
    " \r\nis gray at design time but that appears blue \r\nwhen the form displays";
            // 
            // Exercise01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDescriptiveText);
            this.Name = "Exercise01Form";
            this.Text = "Hour 4 Exercise 1";
            this.Load += new System.EventHandler(this.Exercise01Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescriptiveText;
    }
}

