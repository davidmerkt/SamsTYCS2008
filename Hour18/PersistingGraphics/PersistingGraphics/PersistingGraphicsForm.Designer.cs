namespace PersistingGraphics
{
    partial class PersistingGraphicsForm
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
            this.btnDrawText = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDrawText
            // 
            this.btnDrawText.Location = new System.Drawing.Point(162, 182);
            this.btnDrawText.Name = "btnDrawText";
            this.btnDrawText.Size = new System.Drawing.Size(75, 23);
            this.btnDrawText.TabIndex = 0;
            this.btnDrawText.Text = "Draw Text";
            this.btnDrawText.UseVisualStyleBackColor = true;
            this.btnDrawText.Click += new System.EventHandler(this.btnDrawText_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(56, 184);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // PersistingGraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDrawText);
            this.Name = "PersistingGraphicsForm";
            this.Text = "Persisting Graphics Example";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersistingGraphicsForm_FormClosed);
            this.Load += new System.EventHandler(this.PersistingGraphicsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PersistingGraphicsForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawText;
        private System.Windows.Forms.TextBox txtInput;
    }
}

