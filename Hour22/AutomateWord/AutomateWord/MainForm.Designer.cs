namespace AutomateWord
{
    partial class MainForm
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
            this.btnAutomateWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutomateWord
            // 
            this.btnAutomateWord.Location = new System.Drawing.Point(75, 128);
            this.btnAutomateWord.Name = "btnAutomateWord";
            this.btnAutomateWord.Size = new System.Drawing.Size(120, 23);
            this.btnAutomateWord.TabIndex = 0;
            this.btnAutomateWord.Text = "Automate Word";
            this.btnAutomateWord.UseVisualStyleBackColor = true;
            this.btnAutomateWord.Click += new System.EventHandler(this.btnAutomateWord_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAutomateWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnAutomateWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Automate Word";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutomateWord;
    }
}

