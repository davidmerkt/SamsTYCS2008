namespace Exercise
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
            this.btnAutomate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutomate
            // 
            this.btnAutomate.Location = new System.Drawing.Point(90, 128);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(104, 23);
            this.btnAutomate.TabIndex = 0;
            this.btnAutomate.Text = "Automate It‼";
            this.btnAutomate.UseVisualStyleBackColor = true;
            this.btnAutomate.Click += new System.EventHandler(this.btnAutomate_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAutomate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnAutomate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hour 22 Excel Exercises";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutomate;
    }
}

