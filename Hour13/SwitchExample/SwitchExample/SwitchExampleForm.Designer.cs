﻿namespace SwitchExample
{
    partial class SwitchExampleForm
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
            this.cboAnimals = new System.Windows.Forms.ComboBox();
            this.btnShowLegs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboAnimals
            // 
            this.cboAnimals.FormattingEnabled = true;
            this.cboAnimals.Items.AddRange(new object[] {
            "Horse",
            "Dog",
            "Bird",
            "Cat",
            "Snake",
            "Centipede"});
            this.cboAnimals.Location = new System.Drawing.Point(80, 100);
            this.cboAnimals.Name = "cboAnimals";
            this.cboAnimals.Size = new System.Drawing.Size(121, 24);
            this.cboAnimals.TabIndex = 0;
            // 
            // btnShowLegs
            // 
            this.btnShowLegs.Location = new System.Drawing.Point(95, 130);
            this.btnShowLegs.Name = "btnShowLegs";
            this.btnShowLegs.Size = new System.Drawing.Size(90, 23);
            this.btnShowLegs.TabIndex = 1;
            this.btnShowLegs.Text = "Show Legs";
            this.btnShowLegs.UseVisualStyleBackColor = true;
            this.btnShowLegs.Click += new System.EventHandler(this.btnShowLegs_Click);
            // 
            // SwitchExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnShowLegs);
            this.Controls.Add(this.cboAnimals);
            this.Name = "SwitchExampleForm";
            this.Text = "Switch Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimals;
        private System.Windows.Forms.Button btnShowLegs;
    }
}

