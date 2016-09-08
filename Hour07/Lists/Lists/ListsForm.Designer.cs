namespace Lists
{
    partial class ListsForm
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
            this.lstPinkFloydAlbums = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstPinkFloydAlbums
            // 
            this.lstPinkFloydAlbums.FormattingEnabled = true;
            this.lstPinkFloydAlbums.Items.AddRange(new object[] {
            "Atom Heart Mother",
            "Wish You Were Here",
            "Animals",
            "Echoes",
            "Meddle",
            "Dark Side of the Moon"});
            this.lstPinkFloydAlbums.Location = new System.Drawing.Point(64, 32);
            this.lstPinkFloydAlbums.Name = "lstPinkFloydAlbums";
            this.lstPinkFloydAlbums.Size = new System.Drawing.Size(160, 121);
            this.lstPinkFloydAlbums.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(96, 159);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 23);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add an Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(96, 188);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove an Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(96, 217);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(100, 23);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnShowItem
            // 
            this.btnShowItem.Location = new System.Drawing.Point(96, 246);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(100, 23);
            this.btnShowItem.TabIndex = 4;
            this.btnShowItem.Text = "Show Selected";
            this.btnShowItem.UseVisualStyleBackColor = true;
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // cboColors
            // 
            this.cboColors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboColors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboColors.FormattingEnabled = true;
            this.cboColors.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Gold",
            "Green",
            "Red",
            "Yellow"});
            this.cboColors.Location = new System.Drawing.Point(64, 5);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(160, 21);
            this.cboColors.TabIndex = 5;
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.cboColors);
            this.Controls.Add(this.btnShowItem);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstPinkFloydAlbums);
            this.Name = "ListsForm";
            this.Text = "Lists Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPinkFloydAlbums;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnShowItem;
        private System.Windows.Forms.ComboBox cboColors;
    }
}

