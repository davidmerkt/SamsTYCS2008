namespace ClassProgrammingExample
{
    partial class ClassExampleForm
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
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.btnExercise02 = new System.Windows.Forms.Button();
            this.btnExercise01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(90, 120);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(110, 23);
            this.btnCreateObject.TabIndex = 0;
            this.btnCreateObject.Text = "Create Object";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // btnExercise02
            // 
            this.btnExercise02.Location = new System.Drawing.Point(90, 178);
            this.btnExercise02.Name = "btnExercise02";
            this.btnExercise02.Size = new System.Drawing.Size(110, 23);
            this.btnExercise02.TabIndex = 1;
            this.btnExercise02.Text = "Exercise 2";
            this.btnExercise02.UseVisualStyleBackColor = true;
            this.btnExercise02.Click += new System.EventHandler(this.btnExercise02_Click);
            // 
            // btnExercise01
            // 
            this.btnExercise01.Location = new System.Drawing.Point(90, 149);
            this.btnExercise01.Name = "btnExercise01";
            this.btnExercise01.Size = new System.Drawing.Size(110, 23);
            this.btnExercise01.TabIndex = 2;
            this.btnExercise01.Text = "Exercise 1";
            this.btnExercise01.UseVisualStyleBackColor = true;
            this.btnExercise01.Click += new System.EventHandler(this.btnExercise01_Click);
            // 
            // ClassExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnExercise01);
            this.Controls.Add(this.btnExercise02);
            this.Controls.Add(this.btnCreateObject);
            this.Name = "ClassExampleForm";
            this.Text = "Class Programming Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.Button btnExercise02;
        private System.Windows.Forms.Button btnExercise01;
    }
}

