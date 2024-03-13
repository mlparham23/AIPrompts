namespace AIPrompts.Forms
{
    partial class AddChat
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
            mnustrp = new MenuStrip();
            mnustrpFile = new ToolStripMenuItem();
            mnustrpFileCloseWindow = new ToolStripMenuItem();
            mnustrpChat = new ToolStripMenuItem();
            mnustrpChatAdd = new ToolStripMenuItem();
            mnustrpChatReset = new ToolStripMenuItem();
            txtPromptTitle = new TextBox();
            lblPromptTitle = new Label();
            lblPrompt = new Label();
            txtPrompt = new TextBox();
            lblRank = new Label();
            txtRank = new TextBox();
            lblCategory1 = new Label();
            lblCategory3 = new Label();
            lblGPT = new Label();
            btnCloseWindow = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            cboGPT = new ComboBox();
            lblCategory2 = new Label();
            ckbxNSFW = new CheckBox();
            cboCat1 = new ComboBox();
            cboCat2 = new ComboBox();
            cboCat3 = new ComboBox();
            mnustrp.SuspendLayout();
            SuspendLayout();
            // 
            // mnustrp
            // 
            mnustrp.Items.AddRange(new ToolStripItem[] { mnustrpFile, mnustrpChat });
            mnustrp.Location = new Point(0, 0);
            mnustrp.Name = "mnustrp";
            mnustrp.Size = new Size(1035, 24);
            mnustrp.TabIndex = 0;
            mnustrp.Text = "menuStrip1";
            // 
            // mnustrpFile
            // 
            mnustrpFile.DropDownItems.AddRange(new ToolStripItem[] { mnustrpFileCloseWindow });
            mnustrpFile.Name = "mnustrpFile";
            mnustrpFile.Size = new Size(37, 20);
            mnustrpFile.Text = "File";
            // 
            // mnustrpFileCloseWindow
            // 
            mnustrpFileCloseWindow.Name = "mnustrpFileCloseWindow";
            mnustrpFileCloseWindow.Size = new Size(150, 22);
            mnustrpFileCloseWindow.Text = "Close Window";
            mnustrpFileCloseWindow.Click += mnustrpFileCloseWindow_Click;
            // 
            // mnustrpChat
            // 
            mnustrpChat.DropDownItems.AddRange(new ToolStripItem[] { mnustrpChatAdd, mnustrpChatReset });
            mnustrpChat.Name = "mnustrpChat";
            mnustrpChat.Size = new Size(44, 20);
            mnustrpChat.Text = "Chat";
            // 
            // mnustrpChatAdd
            // 
            mnustrpChatAdd.Name = "mnustrpChatAdd";
            mnustrpChatAdd.Size = new Size(102, 22);
            mnustrpChatAdd.Text = "Add";
            mnustrpChatAdd.Click += mnustrpChatAdd_Click;
            // 
            // mnustrpChatReset
            // 
            mnustrpChatReset.Name = "mnustrpChatReset";
            mnustrpChatReset.Size = new Size(102, 22);
            mnustrpChatReset.Text = "Reset";
            mnustrpChatReset.Click += mnustrpChatReset_Click;
            // 
            // txtPromptTitle
            // 
            txtPromptTitle.Location = new Point(90, 24);
            txtPromptTitle.Name = "txtPromptTitle";
            txtPromptTitle.Size = new Size(332, 23);
            txtPromptTitle.TabIndex = 1;
            // 
            // lblPromptTitle
            // 
            lblPromptTitle.AutoSize = true;
            lblPromptTitle.Location = new Point(12, 27);
            lblPromptTitle.Name = "lblPromptTitle";
            lblPromptTitle.Size = new Size(72, 15);
            lblPromptTitle.TabIndex = 2;
            lblPromptTitle.Text = "Prompt Title";
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(407, 59);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(47, 15);
            lblPrompt.TabIndex = 3;
            lblPrompt.Text = "Prompt";
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(12, 77);
            txtPrompt.Multiline = true;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.ScrollBars = ScrollBars.Vertical;
            txtPrompt.Size = new Size(836, 634);
            txtPrompt.TabIndex = 4;
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Location = new Point(450, 27);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(36, 15);
            lblRank.TabIndex = 5;
            lblRank.Text = "Rank:";
            // 
            // txtRank
            // 
            txtRank.Location = new Point(492, 24);
            txtRank.MaxLength = 2;
            txtRank.Name = "txtRank";
            txtRank.Size = new Size(55, 23);
            txtRank.TabIndex = 6;
            txtRank.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCategory1
            // 
            lblCategory1.AutoSize = true;
            lblCategory1.Location = new Point(904, 59);
            lblCategory1.Name = "lblCategory1";
            lblCategory1.Size = new Size(64, 15);
            lblCategory1.TabIndex = 7;
            lblCategory1.Text = "Category 1";
            // 
            // lblCategory3
            // 
            lblCategory3.AutoSize = true;
            lblCategory3.Location = new Point(904, 168);
            lblCategory3.Name = "lblCategory3";
            lblCategory3.Size = new Size(64, 15);
            lblCategory3.TabIndex = 9;
            lblCategory3.Text = "Category 3";
            // 
            // lblGPT
            // 
            lblGPT.AutoSize = true;
            lblGPT.Location = new Point(922, 223);
            lblGPT.Name = "lblGPT";
            lblGPT.Size = new Size(28, 15);
            lblGPT.TabIndex = 11;
            lblGPT.Text = "GPT";
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.BackColor = Color.FromArgb(192, 255, 255);
            btnCloseWindow.Location = new Point(887, 339);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(99, 23);
            btnCloseWindow.TabIndex = 13;
            btnCloseWindow.Text = "Close Window";
            btnCloseWindow.UseVisualStyleBackColor = false;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 255, 255);
            btnReset.Location = new Point(887, 310);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 23);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.Location = new Point(887, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboGPT
            // 
            cboGPT.FormattingEnabled = true;
            cboGPT.Location = new Point(854, 241);
            cboGPT.Name = "cboGPT";
            cboGPT.Size = new Size(165, 23);
            cboGPT.TabIndex = 16;
            cboGPT.SelectedIndexChanged += cboGPT_SelectedIndexChanged;
            // 
            // lblCategory2
            // 
            lblCategory2.AutoSize = true;
            lblCategory2.Location = new Point(904, 114);
            lblCategory2.Name = "lblCategory2";
            lblCategory2.Size = new Size(64, 15);
            lblCategory2.TabIndex = 17;
            lblCategory2.Text = "Category 2";
            // 
            // ckbxNSFW
            // 
            ckbxNSFW.AutoSize = true;
            ckbxNSFW.Location = new Point(568, 27);
            ckbxNSFW.Name = "ckbxNSFW";
            ckbxNSFW.Size = new Size(61, 19);
            ckbxNSFW.TabIndex = 20;
            ckbxNSFW.Text = "NSFW:";
            ckbxNSFW.UseVisualStyleBackColor = true;
            // 
            // cboCat1
            // 
            cboCat1.FormattingEnabled = true;
            cboCat1.Location = new Point(854, 77);
            cboCat1.Name = "cboCat1";
            cboCat1.Size = new Size(165, 23);
            cboCat1.TabIndex = 21;
            // 
            // cboCat2
            // 
            cboCat2.FormattingEnabled = true;
            cboCat2.Location = new Point(854, 132);
            cboCat2.Name = "cboCat2";
            cboCat2.Size = new Size(165, 23);
            cboCat2.TabIndex = 22;
            // 
            // cboCat3
            // 
            cboCat3.FormattingEnabled = true;
            cboCat3.Location = new Point(854, 186);
            cboCat3.Name = "cboCat3";
            cboCat3.Size = new Size(165, 23);
            cboCat3.TabIndex = 23;
            // 
            // AddChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 717);
            Controls.Add(cboCat3);
            Controls.Add(cboCat2);
            Controls.Add(cboCat1);
            Controls.Add(ckbxNSFW);
            Controls.Add(lblCategory2);
            Controls.Add(cboGPT);
            Controls.Add(btnAdd);
            Controls.Add(btnReset);
            Controls.Add(btnCloseWindow);
            Controls.Add(lblGPT);
            Controls.Add(lblCategory3);
            Controls.Add(lblCategory1);
            Controls.Add(txtRank);
            Controls.Add(lblRank);
            Controls.Add(txtPrompt);
            Controls.Add(lblPrompt);
            Controls.Add(lblPromptTitle);
            Controls.Add(txtPromptTitle);
            Controls.Add(mnustrp);
            MainMenuStrip = mnustrp;
            Name = "AddChat";
            Text = "AddChat";
            Load += AddChat_Load;
            mnustrp.ResumeLayout(false);
            mnustrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnustrp;
        private ToolStripMenuItem mnustrpFile;
        private TextBox txtPromptTitle;
        private Label lblPromptTitle;
        private Label lblPrompt;
        private TextBox txtPrompt;
        private Label lblRank;
        private TextBox txtRank;
        private Label lblCategory1;
        private Label lblCategory3;
        private Label lblGPT;
        private Button btnCloseWindow;
        private Button btnReset;
        private Button btnAdd;
        private ToolStripMenuItem mnustrpFileCloseWindow;
        private ToolStripMenuItem mnustrpChat;
        private ToolStripMenuItem mnustrpChatAdd;
        private ToolStripMenuItem mnustrpChatReset;
        private ComboBox cboGPT;
        private Label lblCategory2;
        private CheckBox ckbxNSFW;
        private ComboBox cboCat1;
        private ComboBox cboCat2;
        private ComboBox cboCat3;
    }
}