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
            this.btnExercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercise
            // 
            this.btnExercise.Location = new System.Drawing.Point(13, 13);
            this.btnExercise.Name = "btnExercise";
            this.btnExercise.Size = new System.Drawing.Size(150, 23);
            this.btnExercise.TabIndex = 0;
            this.btnExercise.Text = "Learn New Things";
            this.btnExercise.UseVisualStyleBackColor = true;
            this.btnExercise.Click += new System.EventHandler(this.btnExercise_Click);
            // 
            // Exercise02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExercise);
            this.Name = "Exercise02Form";
            this.Text = "Hour 11 Exercise 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercise;
    }
}

