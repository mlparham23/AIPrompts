namespace AIPrompts
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnustrp = new MenuStrip();
            mnustrpFile = new ToolStripMenuItem();
            mnustrpFileExit = new ToolStripMenuItem();
            mnustrpAIImage = new ToolStripMenuItem();
            mnustrpAIImageAdd = new ToolStripMenuItem();
            mnustrpAIImageSearch = new ToolStripMenuItem();
            mnustrpAIImageMaintenance = new ToolStripMenuItem();
            mnustrpAIChat = new ToolStripMenuItem();
            mnustrpAIChatAdd = new ToolStripMenuItem();
            mnustrpAIChatSearch = new ToolStripMenuItem();
            mnustrpAIChatMaintenance = new ToolStripMenuItem();
            grpbxAIImages = new GroupBox();
            btnAIImagesAdd = new Button();
            btnAIImagesMaintenance = new Button();
            btnAIImagesSearch = new Button();
            grpbxAIChat = new GroupBox();
            btnAIChatAdd = new Button();
            btnAIChatMaintenance = new Button();
            btnAIChatSearch = new Button();
            btnExit = new Button();
            mnustrp.SuspendLayout();
            grpbxAIImages.SuspendLayout();
            grpbxAIChat.SuspendLayout();
            SuspendLayout();
            // 
            // mnustrp
            // 
            mnustrp.Items.AddRange(new ToolStripItem[] { mnustrpFile, mnustrpAIImage, mnustrpAIChat });
            mnustrp.Location = new Point(0, 0);
            mnustrp.Name = "mnustrp";
            mnustrp.Padding = new Padding(7, 3, 0, 3);
            mnustrp.Size = new Size(487, 25);
            mnustrp.TabIndex = 0;
            mnustrp.Text = "menuStrip1";
            // 
            // mnustrpFile
            // 
            mnustrpFile.DropDownItems.AddRange(new ToolStripItem[] { mnustrpFileExit });
            mnustrpFile.Name = "mnustrpFile";
            mnustrpFile.Size = new Size(37, 19);
            mnustrpFile.Text = "File";
            // 
            // mnustrpFileExit
            // 
            mnustrpFileExit.Name = "mnustrpFileExit";
            mnustrpFileExit.Size = new Size(93, 22);
            mnustrpFileExit.Text = "Exit";
            mnustrpFileExit.Click += mnustrpFileExit_Click;
            // 
            // mnustrpAIImage
            // 
            mnustrpAIImage.DropDownItems.AddRange(new ToolStripItem[] { mnustrpAIImageAdd, mnustrpAIImageSearch, mnustrpAIImageMaintenance });
            mnustrpAIImage.Name = "mnustrpAIImage";
            mnustrpAIImage.Size = new Size(74, 19);
            mnustrpAIImage.Text = "AI Iimages";
            // 
            // mnustrpAIImageAdd
            // 
            mnustrpAIImageAdd.Name = "mnustrpAIImageAdd";
            mnustrpAIImageAdd.Size = new Size(143, 22);
            mnustrpAIImageAdd.Text = "Add";
            mnustrpAIImageAdd.Click += mnustrpAIImageAdd_Click;
            // 
            // mnustrpAIImageSearch
            // 
            mnustrpAIImageSearch.Name = "mnustrpAIImageSearch";
            mnustrpAIImageSearch.Size = new Size(143, 22);
            mnustrpAIImageSearch.Text = "Search";
            mnustrpAIImageSearch.Click += mnustrpAIImageSearch_Click;
            // 
            // mnustrpAIImageMaintenance
            // 
            mnustrpAIImageMaintenance.Name = "mnustrpAIImageMaintenance";
            mnustrpAIImageMaintenance.Size = new Size(143, 22);
            mnustrpAIImageMaintenance.Text = "Maintenance";
            mnustrpAIImageMaintenance.Click += mnustrpAIImageMaintenance_Click;
            // 
            // mnustrpAIChat
            // 
            mnustrpAIChat.DropDownItems.AddRange(new ToolStripItem[] { mnustrpAIChatAdd, mnustrpAIChatSearch, mnustrpAIChatMaintenance });
            mnustrpAIChat.Name = "mnustrpAIChat";
            mnustrpAIChat.Size = new Size(58, 19);
            mnustrpAIChat.Text = "AI Chat";
            // 
            // mnustrpAIChatAdd
            // 
            mnustrpAIChatAdd.Name = "mnustrpAIChatAdd";
            mnustrpAIChatAdd.Size = new Size(143, 22);
            mnustrpAIChatAdd.Text = "Add";
            mnustrpAIChatAdd.Click += mnustrpAIChatAdd_Click;
            // 
            // mnustrpAIChatSearch
            // 
            mnustrpAIChatSearch.Name = "mnustrpAIChatSearch";
            mnustrpAIChatSearch.Size = new Size(143, 22);
            mnustrpAIChatSearch.Text = "Search";
            mnustrpAIChatSearch.Click += mnustrpAIChatSearch_Click;
            // 
            // mnustrpAIChatMaintenance
            // 
            mnustrpAIChatMaintenance.Name = "mnustrpAIChatMaintenance";
            mnustrpAIChatMaintenance.Size = new Size(143, 22);
            mnustrpAIChatMaintenance.Text = "Maintenance";
            mnustrpAIChatMaintenance.Click += mnustrpAIChatMaintenance_Click;
            // 
            // grpbxAIImages
            // 
            grpbxAIImages.Controls.Add(btnAIImagesAdd);
            grpbxAIImages.Controls.Add(btnAIImagesMaintenance);
            grpbxAIImages.Controls.Add(btnAIImagesSearch);
            grpbxAIImages.Location = new Point(12, 43);
            grpbxAIImages.Margin = new Padding(3, 4, 3, 4);
            grpbxAIImages.Name = "grpbxAIImages";
            grpbxAIImages.Padding = new Padding(3, 4, 3, 4);
            grpbxAIImages.Size = new Size(229, 191);
            grpbxAIImages.TabIndex = 1;
            grpbxAIImages.TabStop = false;
            grpbxAIImages.Text = "AI Images";
            // 
            // btnAIImagesAdd
            // 
            btnAIImagesAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAIImagesAdd.Location = new Point(24, 28);
            btnAIImagesAdd.Margin = new Padding(3, 4, 3, 4);
            btnAIImagesAdd.Name = "btnAIImagesAdd";
            btnAIImagesAdd.Size = new Size(183, 44);
            btnAIImagesAdd.TabIndex = 7;
            btnAIImagesAdd.Text = "Add";
            btnAIImagesAdd.UseVisualStyleBackColor = false;
            btnAIImagesAdd.Click += btnAIImagesAdd_Click;
            // 
            // btnAIImagesMaintenance
            // 
            btnAIImagesMaintenance.BackColor = Color.FromArgb(192, 255, 255);
            btnAIImagesMaintenance.Font = new Font("Segoe UI", 11F);
            btnAIImagesMaintenance.Location = new Point(24, 132);
            btnAIImagesMaintenance.Margin = new Padding(3, 4, 3, 4);
            btnAIImagesMaintenance.Name = "btnAIImagesMaintenance";
            btnAIImagesMaintenance.Size = new Size(183, 44);
            btnAIImagesMaintenance.TabIndex = 4;
            btnAIImagesMaintenance.Text = "Maintenance";
            btnAIImagesMaintenance.UseVisualStyleBackColor = false;
            btnAIImagesMaintenance.Click += btnAIImagesMaintenance_Click;
            // 
            // btnAIImagesSearch
            // 
            btnAIImagesSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnAIImagesSearch.Font = new Font("Segoe UI", 11F);
            btnAIImagesSearch.Location = new Point(24, 80);
            btnAIImagesSearch.Margin = new Padding(3, 4, 3, 4);
            btnAIImagesSearch.Name = "btnAIImagesSearch";
            btnAIImagesSearch.Size = new Size(183, 44);
            btnAIImagesSearch.TabIndex = 3;
            btnAIImagesSearch.Text = "Search";
            btnAIImagesSearch.UseVisualStyleBackColor = false;
            btnAIImagesSearch.Click += btnAIImagesSearch_Click;
            // 
            // grpbxAIChat
            // 
            grpbxAIChat.Controls.Add(btnAIChatAdd);
            grpbxAIChat.Controls.Add(btnAIChatMaintenance);
            grpbxAIChat.Controls.Add(btnAIChatSearch);
            grpbxAIChat.Location = new Point(247, 43);
            grpbxAIChat.Margin = new Padding(3, 4, 3, 4);
            grpbxAIChat.Name = "grpbxAIChat";
            grpbxAIChat.Padding = new Padding(3, 4, 3, 4);
            grpbxAIChat.Size = new Size(229, 191);
            grpbxAIChat.TabIndex = 2;
            grpbxAIChat.TabStop = false;
            grpbxAIChat.Text = "AI Chat";
            // 
            // btnAIChatAdd
            // 
            btnAIChatAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAIChatAdd.Location = new Point(19, 28);
            btnAIChatAdd.Margin = new Padding(3, 4, 3, 4);
            btnAIChatAdd.Name = "btnAIChatAdd";
            btnAIChatAdd.Size = new Size(183, 44);
            btnAIChatAdd.TabIndex = 6;
            btnAIChatAdd.Text = "Add";
            btnAIChatAdd.UseVisualStyleBackColor = false;
            btnAIChatAdd.Click += btnAIChatAdd_Click;
            // 
            // btnAIChatMaintenance
            // 
            btnAIChatMaintenance.BackColor = Color.FromArgb(192, 255, 255);
            btnAIChatMaintenance.Font = new Font("Segoe UI", 11F);
            btnAIChatMaintenance.Location = new Point(19, 132);
            btnAIChatMaintenance.Margin = new Padding(3, 4, 3, 4);
            btnAIChatMaintenance.Name = "btnAIChatMaintenance";
            btnAIChatMaintenance.Size = new Size(183, 44);
            btnAIChatMaintenance.TabIndex = 5;
            btnAIChatMaintenance.Text = "Maintenance";
            btnAIChatMaintenance.UseVisualStyleBackColor = false;
            btnAIChatMaintenance.Click += btnAIChatMaintenance_Click;
            // 
            // btnAIChatSearch
            // 
            btnAIChatSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnAIChatSearch.Location = new Point(19, 80);
            btnAIChatSearch.Margin = new Padding(3, 4, 3, 4);
            btnAIChatSearch.Name = "btnAIChatSearch";
            btnAIChatSearch.Size = new Size(183, 44);
            btnAIChatSearch.TabIndex = 4;
            btnAIChatSearch.Text = "Search";
            btnAIChatSearch.UseVisualStyleBackColor = false;
            btnAIChatSearch.Click += btnAIChatSearch_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 255, 255);
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.Location = new Point(149, 242);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 44);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 297);
            Controls.Add(btnExit);
            Controls.Add(grpbxAIChat);
            Controls.Add(grpbxAIImages);
            Controls.Add(mnustrp);
            Font = new Font("Segoe UI", 11F);
            MainMenuStrip = mnustrp;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI Prompts (Main)";
            Load += Main_Load;
            mnustrp.ResumeLayout(false);
            mnustrp.PerformLayout();
            grpbxAIImages.ResumeLayout(false);
            grpbxAIChat.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnustrp;
        private ToolStripMenuItem mnustrpFile;
        private GroupBox grpbxAIImages;
        private GroupBox grpbxAIChat;
        private Button btnAIImagesSearch;
        private Button btnAIImagesMaintenance;
        private ToolStripMenuItem mnustrpFileExit;
        private ToolStripMenuItem mnustrpAIImage;
        private ToolStripMenuItem mnustrpAIImageSearch;
        private ToolStripMenuItem mnustrpAIImageMaintenance;
        private ToolStripMenuItem mnustrpAIChat;
        private ToolStripMenuItem mnustrpAIChatSearch;
        private ToolStripMenuItem mnustrpAIChatMaintenance;
        private Button btnAIChatMaintenance;
        private Button btnAIChatSearch;
        private Button btnExit;
        private Button btnAIImagesAdd;
        private Button btnAIChatAdd;
        private ToolStripMenuItem mnustrpAIImageAdd;
        private ToolStripMenuItem mnustrpAIChatAdd;
    }
}
