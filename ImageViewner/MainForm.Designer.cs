namespace ImageViewner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageDisplayer = new System.Windows.Forms.PictureBox();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.zoomLess = new System.Windows.Forms.Button();
            this.zoomMore = new System.Windows.Forms.Button();
            this.openMultipleImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.openMultipleImagesToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // imageDisplayer
            // 
            this.imageDisplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageDisplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDisplayer.Image = global::ImageViewner.Properties.Resources.placeholder;
            this.imageDisplayer.Location = new System.Drawing.Point(0, 24);
            this.imageDisplayer.Name = "imageDisplayer";
            this.imageDisplayer.Size = new System.Drawing.Size(484, 337);
            this.imageDisplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageDisplayer.TabIndex = 1;
            this.imageDisplayer.TabStop = false;
            this.imageDisplayer.DoubleClick += new System.EventHandler(this.imageDisplayer_DoubleClick);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightButton.BackColor = System.Drawing.Color.Transparent;
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightButton.Image = global::ImageViewner.Properties.Resources.right;
            this.rightButton.Location = new System.Drawing.Point(396, 155);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(76, 76);
            this.rightButton.TabIndex = 2;
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Visible = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftButton.BackColor = System.Drawing.Color.Transparent;
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftButton.Image = global::ImageViewner.Properties.Resources.left;
            this.leftButton.Location = new System.Drawing.Point(12, 155);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(76, 76);
            this.leftButton.TabIndex = 3;
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Visible = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // zoomLess
            // 
            this.zoomLess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomLess.BackColor = System.Drawing.Color.Transparent;
            this.zoomLess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zoomLess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoomLess.Image = global::ImageViewner.Properties.Resources.zoomLess;
            this.zoomLess.Location = new System.Drawing.Point(303, 273);
            this.zoomLess.Name = "zoomLess";
            this.zoomLess.Size = new System.Drawing.Size(76, 76);
            this.zoomLess.TabIndex = 4;
            this.zoomLess.UseVisualStyleBackColor = false;
            this.zoomLess.Visible = false;
            this.zoomLess.Click += new System.EventHandler(this.zoomLess_Click);
            // 
            // zoomMore
            // 
            this.zoomMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomMore.BackColor = System.Drawing.Color.Transparent;
            this.zoomMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zoomMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoomMore.Image = global::ImageViewner.Properties.Resources.zoomMore;
            this.zoomMore.Location = new System.Drawing.Point(385, 273);
            this.zoomMore.Name = "zoomMore";
            this.zoomMore.Size = new System.Drawing.Size(76, 76);
            this.zoomMore.TabIndex = 5;
            this.zoomMore.UseVisualStyleBackColor = false;
            this.zoomMore.Visible = false;
            this.zoomMore.Click += new System.EventHandler(this.zoomMore_Click);
            // 
            // openMultipleImagesToolStripMenuItem
            // 
            this.openMultipleImagesToolStripMenuItem.Name = "openMultipleImagesToolStripMenuItem";
            this.openMultipleImagesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openMultipleImagesToolStripMenuItem.Text = "Open Multiple Images";
            this.openMultipleImagesToolStripMenuItem.Click += new System.EventHandler(this.openMultipleImagesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.zoomMore);
            this.Controls.Add(this.zoomLess);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.imageDisplayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.PictureBox imageDisplayer;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button zoomLess;
        private System.Windows.Forms.Button zoomMore;
        private System.Windows.Forms.ToolStripMenuItem openMultipleImagesToolStripMenuItem;
    }
}

