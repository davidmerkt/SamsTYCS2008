﻿namespace PictureViewer
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstPinkFloydAlbums = new System.Windows.Forms.ListBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.chkPromptOnExit = new System.Windows.Forms.CheckBox();
            this.grpDefaultBackcolor = new System.Windows.Forms.GroupBox();
            this.optBackgroundWhite = new System.Windows.Forms.RadioButton();
            this.optBackgroundDefault = new System.Windows.Forms.RadioButton();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.pgeGeneral = new System.Windows.Forms.TabPage();
            this.pgeAppearance = new System.Windows.Forms.TabPage();
            this.grpDefaultBackcolor.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.pgeGeneral.SuspendLayout();
            this.pgeAppearance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(396, 15);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(128, 50);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.MaxLength = 0;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(396, 50);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstPinkFloydAlbums
            // 
            this.lstPinkFloydAlbums.FormattingEnabled = true;
            this.lstPinkFloydAlbums.ItemHeight = 16;
            this.lstPinkFloydAlbums.Location = new System.Drawing.Point(192, 222);
            this.lstPinkFloydAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPinkFloydAlbums.Name = "lstPinkFloydAlbums";
            this.lstPinkFloydAlbums.Size = new System.Drawing.Size(303, 84);
            this.lstPinkFloydAlbums.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(36, 54);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 17);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            // 
            // chkPromptOnExit
            // 
            this.chkPromptOnExit.AutoSize = true;
            this.chkPromptOnExit.Location = new System.Drawing.Point(128, 82);
            this.chkPromptOnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPromptOnExit.Name = "chkPromptOnExit";
            this.chkPromptOnExit.Size = new System.Drawing.Size(186, 21);
            this.chkPromptOnExit.TabIndex = 2;
            this.chkPromptOnExit.Text = "Prompt to confirm on exit";
            this.chkPromptOnExit.UseVisualStyleBackColor = true;
            // 
            // grpDefaultBackcolor
            // 
            this.grpDefaultBackcolor.Controls.Add(this.optBackgroundWhite);
            this.grpDefaultBackcolor.Controls.Add(this.optBackgroundDefault);
            this.grpDefaultBackcolor.Location = new System.Drawing.Point(49, 33);
            this.grpDefaultBackcolor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDefaultBackcolor.Name = "grpDefaultBackcolor";
            this.grpDefaultBackcolor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDefaultBackcolor.Size = new System.Drawing.Size(267, 89);
            this.grpDefaultBackcolor.TabIndex = 1;
            this.grpDefaultBackcolor.TabStop = false;
            this.grpDefaultBackcolor.Text = "Default Picture Background Color";
            // 
            // optBackgroundWhite
            // 
            this.optBackgroundWhite.AutoSize = true;
            this.optBackgroundWhite.Location = new System.Drawing.Point(19, 52);
            this.optBackgroundWhite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optBackgroundWhite.Name = "optBackgroundWhite";
            this.optBackgroundWhite.Size = new System.Drawing.Size(65, 21);
            this.optBackgroundWhite.TabIndex = 1;
            this.optBackgroundWhite.Text = "White";
            this.optBackgroundWhite.UseVisualStyleBackColor = true;
            // 
            // optBackgroundDefault
            // 
            this.optBackgroundDefault.AutoSize = true;
            this.optBackgroundDefault.Checked = true;
            this.optBackgroundDefault.Location = new System.Drawing.Point(19, 23);
            this.optBackgroundDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optBackgroundDefault.Name = "optBackgroundDefault";
            this.optBackgroundDefault.Size = new System.Drawing.Size(109, 21);
            this.optBackgroundDefault.TabIndex = 0;
            this.optBackgroundDefault.TabStop = true;
            this.optBackgroundDefault.Text = "Default Grey";
            this.optBackgroundDefault.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.pgeGeneral);
            this.tabOptions.Controls.Add(this.pgeAppearance);
            this.tabOptions.Location = new System.Drawing.Point(16, 15);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(373, 178);
            this.tabOptions.TabIndex = 7;
            // 
            // pgeGeneral
            // 
            this.pgeGeneral.Controls.Add(this.lblUserName);
            this.pgeGeneral.Controls.Add(this.chkPromptOnExit);
            this.pgeGeneral.Controls.Add(this.txtUserName);
            this.pgeGeneral.Location = new System.Drawing.Point(4, 25);
            this.pgeGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgeGeneral.Name = "pgeGeneral";
            this.pgeGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgeGeneral.Size = new System.Drawing.Size(365, 149);
            this.pgeGeneral.TabIndex = 0;
            this.pgeGeneral.Text = "General";
            this.pgeGeneral.UseVisualStyleBackColor = true;
            // 
            // pgeAppearance
            // 
            this.pgeAppearance.Controls.Add(this.grpDefaultBackcolor);
            this.pgeAppearance.Location = new System.Drawing.Point(4, 25);
            this.pgeAppearance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgeAppearance.Name = "pgeAppearance";
            this.pgeAppearance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgeAppearance.Size = new System.Drawing.Size(365, 149);
            this.pgeAppearance.TabIndex = 1;
            this.pgeAppearance.Text = "Appearance";
            this.pgeAppearance.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.lstPinkFloydAlbums);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 358);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Picture Viewer Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.grpDefaultBackcolor.ResumeLayout(false);
            this.grpDefaultBackcolor.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.pgeGeneral.ResumeLayout(false);
            this.pgeGeneral.PerformLayout();
            this.pgeAppearance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstPinkFloydAlbums;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox chkPromptOnExit;
        private System.Windows.Forms.GroupBox grpDefaultBackcolor;
        private System.Windows.Forms.RadioButton optBackgroundWhite;
        private System.Windows.Forms.RadioButton optBackgroundDefault;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage pgeGeneral;
        private System.Windows.Forms.TabPage pgeAppearance;
    }
}