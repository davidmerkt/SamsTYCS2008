namespace Exercise02
{
    partial class Exercise02Form
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
            this.btnResize = new System.Windows.Forms.Button();
            this.lblLabelToResize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(12, 12);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 1;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lblLabelToResize
            // 
            this.lblLabelToResize.BackColor = System.Drawing.Color.Red;
            this.lblLabelToResize.Location = new System.Drawing.Point(13, 42);
            this.lblLabelToResize.Name = "lblLabelToResize";
            this.lblLabelToResize.Size = new System.Drawing.Size(111, 17);
            this.lblLabelToResize.TabIndex = 2;
            this.lblLabelToResize.Text = "Label To Resize";
            // 
            // Exercise02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblLabelToResize);
            this.Controls.Add(this.btnResize);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercise02Form";
            this.Text = "Hour 14 Exercise 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label lblLabelToResize;

    }
}

