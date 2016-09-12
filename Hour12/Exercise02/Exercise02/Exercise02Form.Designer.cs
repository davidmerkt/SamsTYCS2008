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
            this.txtBirthdateEntry = new System.Windows.Forms.TextBox();
            this.btnFindBirthDay = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBirthdateEntry
            // 
            this.txtBirthdateEntry.Location = new System.Drawing.Point(12, 29);
            this.txtBirthdateEntry.Name = "txtBirthdateEntry";
            this.txtBirthdateEntry.Size = new System.Drawing.Size(187, 22);
            this.txtBirthdateEntry.TabIndex = 0;
            this.txtBirthdateEntry.Text = "1/1/1990";
            this.txtBirthdateEntry.Click += new System.EventHandler(this.txtBirthdateEntry_Click);
            // 
            // btnFindBirthDay
            // 
            this.btnFindBirthDay.Location = new System.Drawing.Point(12, 57);
            this.btnFindBirthDay.Name = "btnFindBirthDay";
            this.btnFindBirthDay.Size = new System.Drawing.Size(120, 23);
            this.btnFindBirthDay.TabIndex = 1;
            this.btnFindBirthDay.Text = "Find Birth Day…";
            this.btnFindBirthDay.UseVisualStyleBackColor = true;
            this.btnFindBirthDay.Click += new System.EventHandler(this.btnFindBirthDay_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(118, 17);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter a birthdate:";
            // 
            // Exercise02Form
            // 
            this.AcceptButton = this.btnFindBirthDay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnFindBirthDay);
            this.Controls.Add(this.txtBirthdateEntry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercise02Form";
            this.Text = "Hour 12 Exercise 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirthdateEntry;
        private System.Windows.Forms.Button btnFindBirthDay;
        private System.Windows.Forms.Label lblInstructions;
    }
}

