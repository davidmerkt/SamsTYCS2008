namespace DecisionsExample
{
    partial class DecisionsForm
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
            this.btnIsLessThanHundred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(44, 44);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnIsLessThanHundred
            // 
            this.btnIsLessThanHundred.Location = new System.Drawing.Point(150, 44);
            this.btnIsLessThanHundred.Name = "btnIsLessThanHundred";
            this.btnIsLessThanHundred.Size = new System.Drawing.Size(100, 23);
            this.btnIsLessThanHundred.TabIndex = 1;
            this.btnIsLessThanHundred.Text = "Is text < 100?";
            this.btnIsLessThanHundred.UseVisualStyleBackColor = true;
            this.btnIsLessThanHundred.Click += new System.EventHandler(this.btnIsLessThanHundred_Click);
            // 
            // DecisionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnIsLessThanHundred);
            this.Controls.Add(this.txtInput);
            this.Name = "DecisionsForm";
            this.Text = "Decisions Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnIsLessThanHundred;
    }
}

