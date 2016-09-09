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
            this.lstItemsList = new System.Windows.Forms.ListView();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.txtItemsToAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstItemsList
            // 
            this.lstItemsList.Location = new System.Drawing.Point(12, 12);
            this.lstItemsList.Name = "lstItemsList";
            this.lstItemsList.Size = new System.Drawing.Size(260, 211);
            this.lstItemsList.TabIndex = 0;
            this.lstItemsList.UseCompatibleStateImageBehavior = false;
            this.lstItemsList.View = System.Windows.Forms.View.List;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(197, 227);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(75, 23);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // txtItemsToAdd
            // 
            this.txtItemsToAdd.Location = new System.Drawing.Point(12, 229);
            this.txtItemsToAdd.Name = "txtItemsToAdd";
            this.txtItemsToAdd.Size = new System.Drawing.Size(179, 20);
            this.txtItemsToAdd.TabIndex = 2;
            // 
            // Exercise02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtItemsToAdd);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.lstItemsList);
            this.Name = "Exercise02Form";
            this.Text = "Hour 8 Exercise 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstItemsList;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.TextBox txtItemsToAdd;
    }
}

