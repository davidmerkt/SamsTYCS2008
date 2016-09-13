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
            this.txtShape = new System.Windows.Forms.TextBox();
            this.btnShowMessagebox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShape
            // 
            this.txtShape.Location = new System.Drawing.Point(12, 12);
            this.txtShape.Name = "txtShape";
            this.txtShape.Size = new System.Drawing.Size(125, 22);
            this.txtShape.TabIndex = 0;
            // 
            // btnShowMessagebox
            // 
            this.btnShowMessagebox.Location = new System.Drawing.Point(12, 40);
            this.btnShowMessagebox.Name = "btnShowMessagebox";
            this.btnShowMessagebox.Size = new System.Drawing.Size(125, 23);
            this.btnShowMessagebox.TabIndex = 1;
            this.btnShowMessagebox.Text = "Show # of sides…";
            this.btnShowMessagebox.UseVisualStyleBackColor = true;
            this.btnShowMessagebox.Click += new System.EventHandler(this.btnShowMessagebox_Click);
            // 
            // Exercise01Form
            // 
            this.AcceptButton = this.btnShowMessagebox;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnShowMessagebox);
            this.Controls.Add(this.txtShape);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercise01Form";
            this.Text = "Hour 13 Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShape;
        private System.Windows.Forms.Button btnShowMessagebox;
    }
}

