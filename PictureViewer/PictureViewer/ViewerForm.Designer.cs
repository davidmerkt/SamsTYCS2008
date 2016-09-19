namespace PictureViewer
{
    partial class ViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.picShowPicture = new System.Windows.Forms.PictureBox();
            this.mnuPictureContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnEnlarge = new System.Windows.Forms.Button();
            this.btnShrink = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfirmOnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrMainToolbar = new System.Windows.Forms.ToolStrip();
            this.tbbOpenPicture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbDrawBorder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbEnlarge = new System.Windows.Forms.ToolStripButton();
            this.tbbShrink = new System.Windows.Forms.ToolStripButton();
            this.tbbOptions = new System.Windows.Forms.ToolStripButton();
            this.sbrMyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbbGetFileAttributes = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).BeginInit();
            this.mnuPictureContext.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.tbrMainToolbar.SuspendLayout();
            this.sbrMyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picShowPicture
            // 
            this.picShowPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShowPicture.ContextMenuStrip = this.mnuPictureContext;
            this.picShowPicture.Location = new System.Drawing.Point(16, 100);
            this.picShowPicture.Margin = new System.Windows.Forms.Padding(4);
            this.picShowPicture.Name = "picShowPicture";
            this.picShowPicture.Size = new System.Drawing.Size(799, 313);
            this.picShowPicture.TabIndex = 2;
            this.picShowPicture.TabStop = false;
            this.picShowPicture.MouseLeave += new System.EventHandler(this.picShowPicture_MouseLeave);
            this.picShowPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseMove);
            // 
            // mnuPictureContext
            // 
            this.mnuPictureContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPictureContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawBorderToolStripMenuItem});
            this.mnuPictureContext.Name = "mnuPictureContext";
            this.mnuPictureContext.Size = new System.Drawing.Size(163, 28);
            // 
            // drawBorderToolStripMenuItem
            // 
            this.drawBorderToolStripMenuItem.Name = "drawBorderToolStripMenuItem";
            this.drawBorderToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.drawBorderToolStripMenuItem.Text = "Draw Border";
            this.drawBorderToolStripMenuItem.Click += new System.EventHandler(this.mnuDrawBorder_Click);
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.Filter = "Bitmaps|*.BMP|JPEG Images|*.JPG; *.JPEG|GIF Images|*.GIF|PNG Images|*.PNG|TIFF Im" +
    "ages|*.TIF; *.TIFF";
            this.ofdSelectPicture.Title = "Select Picture";
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.Location = new System.Drawing.Point(16, 64);
            this.btnEnlarge.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Size = new System.Drawing.Size(31, 28);
            this.btnEnlarge.TabIndex = 6;
            this.btnEnlarge.Text = "^";
            this.btnEnlarge.UseVisualStyleBackColor = true;
            this.btnEnlarge.Click += new System.EventHandler(this.btnEnlarge_Click);
            // 
            // btnShrink
            // 
            this.btnShrink.Location = new System.Drawing.Point(55, 64);
            this.btnShrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(31, 28);
            this.btnShrink.TabIndex = 7;
            this.btnShrink.Text = "v";
            this.btnShrink.UseVisualStyleBackColor = true;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(120, 70);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(240, 70);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(832, 28);
            this.mnuMainMenu.TabIndex = 8;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenPicture,
            this.mnuConfirmOnExit,
            this.mnuQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpenPicture
            // 
            this.mnuOpenPicture.Name = "mnuOpenPicture";
            this.mnuOpenPicture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenPicture.Size = new System.Drawing.Size(216, 26);
            this.mnuOpenPicture.Text = "&Open Picture";
            this.mnuOpenPicture.Click += new System.EventHandler(this.mnuOpenPicture_Click);
            // 
            // mnuConfirmOnExit
            // 
            this.mnuConfirmOnExit.Checked = true;
            this.mnuConfirmOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuConfirmOnExit.Name = "mnuConfirmOnExit";
            this.mnuConfirmOnExit.Size = new System.Drawing.Size(216, 26);
            this.mnuConfirmOnExit.Text = "Confirm on Exit";
            this.mnuConfirmOnExit.Click += new System.EventHandler(this.mnuConfirmOnExit_Click);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuQuit.Size = new System.Drawing.Size(216, 26);
            this.mnuQuit.Text = "&Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrawBorder,
            this.toolStripSeparator1,
            this.mnuOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // mnuDrawBorder
            // 
            this.mnuDrawBorder.Name = "mnuDrawBorder";
            this.mnuDrawBorder.Size = new System.Drawing.Size(162, 24);
            this.mnuDrawBorder.Text = "&Draw Border";
            this.mnuDrawBorder.Click += new System.EventHandler(this.mnuDrawBorder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(162, 24);
            this.mnuOptions.Text = "&Options";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // tbrMainToolbar
            // 
            this.tbrMainToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbrMainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbOpenPicture,
            this.toolStripSeparator2,
            this.tbbDrawBorder,
            this.toolStripSeparator3,
            this.tbbEnlarge,
            this.tbbShrink,
            this.tbbOptions,
            this.tbbGetFileAttributes});
            this.tbrMainToolbar.Location = new System.Drawing.Point(0, 28);
            this.tbrMainToolbar.Name = "tbrMainToolbar";
            this.tbrMainToolbar.Size = new System.Drawing.Size(832, 27);
            this.tbrMainToolbar.TabIndex = 10;
            this.tbrMainToolbar.Text = "toolStrip1";
            // 
            // tbbOpenPicture
            // 
            this.tbbOpenPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOpenPicture.Image = ((System.Drawing.Image)(resources.GetObject("tbbOpenPicture.Image")));
            this.tbbOpenPicture.ImageTransparentColor = System.Drawing.Color.White;
            this.tbbOpenPicture.Name = "tbbOpenPicture";
            this.tbbOpenPicture.Size = new System.Drawing.Size(24, 24);
            this.tbbOpenPicture.Text = "Open Picture";
            this.tbbOpenPicture.Click += new System.EventHandler(this.tbbOpenPicture_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbbDrawBorder
            // 
            this.tbbDrawBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbDrawBorder.Image = ((System.Drawing.Image)(resources.GetObject("tbbDrawBorder.Image")));
            this.tbbDrawBorder.ImageTransparentColor = System.Drawing.Color.White;
            this.tbbDrawBorder.Name = "tbbDrawBorder";
            this.tbbDrawBorder.Size = new System.Drawing.Size(24, 24);
            this.tbbDrawBorder.Text = "Draw Border";
            this.tbbDrawBorder.Click += new System.EventHandler(this.tbbDrawBorder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tbbEnlarge
            // 
            this.tbbEnlarge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbEnlarge.Image = ((System.Drawing.Image)(resources.GetObject("tbbEnlarge.Image")));
            this.tbbEnlarge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbEnlarge.Name = "tbbEnlarge";
            this.tbbEnlarge.Size = new System.Drawing.Size(24, 24);
            this.tbbEnlarge.Text = "Enlarge Window";
            this.tbbEnlarge.Click += new System.EventHandler(this.tbbEnlarge_Click);
            // 
            // tbbShrink
            // 
            this.tbbShrink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbShrink.Image = ((System.Drawing.Image)(resources.GetObject("tbbShrink.Image")));
            this.tbbShrink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbShrink.Name = "tbbShrink";
            this.tbbShrink.Size = new System.Drawing.Size(24, 24);
            this.tbbShrink.Text = "Shrink Window";
            this.tbbShrink.Click += new System.EventHandler(this.tbbShrink_Click);
            // 
            // tbbOptions
            // 
            this.tbbOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbOptions.Image")));
            this.tbbOptions.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tbbOptions.Name = "tbbOptions";
            this.tbbOptions.Size = new System.Drawing.Size(24, 24);
            this.tbbOptions.Text = "Options";
            this.tbbOptions.Click += new System.EventHandler(this.tbbOptions_Click);
            // 
            // sbrMyStatusStrip
            // 
            this.sbrMyStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sbrMyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.sbrMyStatusStrip.Location = new System.Drawing.Point(0, 419);
            this.sbrMyStatusStrip.Name = "sbrMyStatusStrip";
            this.sbrMyStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sbrMyStatusStrip.Size = new System.Drawing.Size(832, 25);
            this.sbrMyStatusStrip.TabIndex = 11;
            this.sbrMyStatusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 20);
            this.lblStatus.Text = "No image loaded";
            // 
            // tbbGetFileAttributes
            // 
            this.tbbGetFileAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbGetFileAttributes.Image = ((System.Drawing.Image)(resources.GetObject("tbbGetFileAttributes.Image")));
            this.tbbGetFileAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbGetFileAttributes.Name = "tbbGetFileAttributes";
            this.tbbGetFileAttributes.Size = new System.Drawing.Size(24, 24);
            this.tbbGetFileAttributes.Text = "Get File Attributes";
            this.tbbGetFileAttributes.ToolTipText = "Get File Attributes";
            this.tbbGetFileAttributes.Click += new System.EventHandler(this.tbbGetFileAttributes_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(832, 444);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.btnEnlarge);
            this.Controls.Add(this.picShowPicture);
            this.Controls.Add(this.tbrMainToolbar);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.sbrMyStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(594, 161);
            this.Name = "ViewerForm";
            this.Text = "Picture Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.Resize += new System.EventHandler(this.ViewerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).EndInit();
            this.mnuPictureContext.ResumeLayout(false);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.tbrMainToolbar.ResumeLayout(false);
            this.tbrMainToolbar.PerformLayout();
            this.sbrMyStatusStrip.ResumeLayout(false);
            this.sbrMyStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picShowPicture;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
        private System.Windows.Forms.Button btnEnlarge;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuConfirmOnExit;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawBorder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ContextMenuStrip mnuPictureContext;
        private System.Windows.Forms.ToolStripMenuItem drawBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tbrMainToolbar;
        private System.Windows.Forms.ToolStripButton tbbOpenPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbbDrawBorder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbbOptions;
        private System.Windows.Forms.StatusStrip sbrMyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton tbbEnlarge;
        private System.Windows.Forms.ToolStripButton tbbShrink;
        private System.Windows.Forms.ToolStripButton tbbGetFileAttributes;
    }
}

