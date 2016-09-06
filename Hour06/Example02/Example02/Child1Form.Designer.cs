namespace Example02
{
    partial class Child1Form
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
            this.btnShowChild2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowChild2
            // 
            this.btnShowChild2.Location = new System.Drawing.Point(105, 100);
            this.btnShowChild2.Name = "btnShowChild2";
            this.btnShowChild2.Size = new System.Drawing.Size(85, 23);
            this.btnShowChild2.TabIndex = 0;
            this.btnShowChild2.Text = "Show Child 2";
            this.btnShowChild2.UseVisualStyleBackColor = true;
            this.btnShowChild2.Click += new System.EventHandler(this.btnShowChild2_Click);
            // 
            // Child1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowChild2);
            this.Name = "Child1Form";
            this.Text = "Child 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowChild2;
    }
}