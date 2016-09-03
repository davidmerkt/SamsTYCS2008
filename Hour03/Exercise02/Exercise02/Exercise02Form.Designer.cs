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
            this.btnShowNames = new System.Windows.Forms.Button();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.btnTwo = new System.Windows.Forms.Button();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.btnThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowNames
            // 
            this.btnShowNames.Location = new System.Drawing.Point(83, 112);
            this.btnShowNames.Name = "btnShowNames";
            this.btnShowNames.Size = new System.Drawing.Size(120, 23);
            this.btnShowNames.TabIndex = 0;
            this.btnShowNames.Text = "Show Control Names";
            this.btnShowNames.UseVisualStyleBackColor = true;
            this.btnShowNames.Click += new System.EventHandler(this.btnShowNames_Click);
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(12, 12);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 1;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(118, 10);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "button1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(12, 41);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 3;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(118, 39);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "button2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(12, 70);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 20);
            this.txtThree.TabIndex = 5;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(118, 68);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 23);
            this.btnThree.TabIndex = 6;
            this.btnThree.Text = "button3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // Exercise02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnShowNames);
            this.Name = "Exercise02Form";
            this.Text = "Hour 3 Exercise 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowNames;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.Button btnThree;
    }
}

