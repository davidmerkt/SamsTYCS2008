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
            this.btnPerformDivision = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPerformDivision
            // 
            this.btnPerformDivision.Location = new System.Drawing.Point(79, 139);
            this.btnPerformDivision.Name = "btnPerformDivision";
            this.btnPerformDivision.Size = new System.Drawing.Size(120, 23);
            this.btnPerformDivision.TabIndex = 0;
            this.btnPerformDivision.Text = "Perform Division";
            this.btnPerformDivision.UseVisualStyleBackColor = true;
            this.btnPerformDivision.Click += new System.EventHandler(this.btnPerformDivision_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(79, 113);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 22);
            this.txtInput.TabIndex = 1;
            // 
            // Exercise01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnPerformDivision);
            this.Name = "Exercise01Form";
            this.Text = "Hour 15 Exercise 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerformDivision;
        private System.Windows.Forms.TextBox txtInput;
    }
}

