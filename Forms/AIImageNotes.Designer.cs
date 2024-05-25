namespace AIPrompts.Forms
{
    partial class AIImageNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIImageNotes));
            mnustrp = new MenuStrip();
            mnustrpFile = new ToolStripMenuItem();
            mnustrpFileClearForm = new ToolStripMenuItem();
            mnustrpFileExit = new ToolStripMenuItem();
            mnustrpAbout = new ToolStripMenuItem();
            lblRating = new Label();
            txtRating = new TextBox();
            lblPromptTitle = new Label();
            txtPromptTitle = new TextBox();
            lblPrompt = new Label();
            lblNegativePrompt = new Label();
            lblNotes = new Label();
            label6 = new Label();
            txtPrompt = new TextBox();
            txtNegativePrompt = new TextBox();
            txtNotes = new TextBox();
            picbxExit = new PictureBox();
            picbxRefresh = new PictureBox();
            pctbxRefreshPrompt = new PictureBox();
            pctbxNegPrompt = new PictureBox();
            pctbxNotes = new PictureBox();
            pctbxRefreshTitle = new PictureBox();
            txtMiscNote = new TextBox();
            lblMiscNotes = new Label();
            pctbxRefreshMiscNotes = new PictureBox();
            mnustrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbxRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxRefreshPrompt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxNegPrompt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxRefreshTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxRefreshMiscNotes).BeginInit();
            SuspendLayout();
            // 
            // mnustrp
            // 
            mnustrp.Items.AddRange(new ToolStripItem[] { mnustrpFile, mnustrpAbout });
            mnustrp.Location = new Point(0, 0);
            mnustrp.Name = "mnustrp";
            mnustrp.Size = new Size(1058, 24);
            mnustrp.TabIndex = 0;
            mnustrp.Text = "menuStrip1";
            // 
            // mnustrpFile
            // 
            mnustrpFile.DropDownItems.AddRange(new ToolStripItem[] { mnustrpFileClearForm, mnustrpFileExit });
            mnustrpFile.Name = "mnustrpFile";
            mnustrpFile.Size = new Size(37, 20);
            mnustrpFile.Text = "File";
            // 
            // mnustrpFileClearForm
            // 
            mnustrpFileClearForm.Name = "mnustrpFileClearForm";
            mnustrpFileClearForm.Size = new Size(132, 22);
            mnustrpFileClearForm.Text = "Clear Form";
            mnustrpFileClearForm.Click += mnustrpFileClearForm_Click;
            // 
            // mnustrpFileExit
            // 
            mnustrpFileExit.Name = "mnustrpFileExit";
            mnustrpFileExit.Size = new Size(132, 22);
            mnustrpFileExit.Text = "Exit";
            mnustrpFileExit.Click += mnustrpFileExit_Click;
            // 
            // mnustrpAbout
            // 
            mnustrpAbout.Name = "mnustrpAbout";
            mnustrpAbout.Size = new Size(52, 20);
            mnustrpAbout.Text = "About";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 11F);
            lblRating.Location = new Point(41, 55);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(52, 20);
            lblRating.TabIndex = 1;
            lblRating.Text = "Rating";
            // 
            // txtRating
            // 
            txtRating.Font = new Font("Segoe UI", 11F);
            txtRating.Location = new Point(99, 52);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(68, 27);
            txtRating.TabIndex = 2;
            txtRating.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPromptTitle
            // 
            lblPromptTitle.AutoSize = true;
            lblPromptTitle.Font = new Font("Segoe UI", 11F);
            lblPromptTitle.Location = new Point(182, 55);
            lblPromptTitle.Name = "lblPromptTitle";
            lblPromptTitle.Size = new Size(38, 20);
            lblPromptTitle.TabIndex = 3;
            lblPromptTitle.Text = "Title";
            // 
            // txtPromptTitle
            // 
            txtPromptTitle.Location = new Point(226, 56);
            txtPromptTitle.MaxLength = 50;
            txtPromptTitle.Name = "txtPromptTitle";
            txtPromptTitle.Size = new Size(323, 23);
            txtPromptTitle.TabIndex = 4;
            txtPromptTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 11F);
            lblPrompt.Location = new Point(181, 94);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(58, 20);
            lblPrompt.TabIndex = 5;
            lblPrompt.Text = "Prompt";
            // 
            // lblNegativePrompt
            // 
            lblNegativePrompt.AutoSize = true;
            lblNegativePrompt.Font = new Font("Segoe UI", 11F);
            lblNegativePrompt.Location = new Point(153, 292);
            lblNegativePrompt.Name = "lblNegativePrompt";
            lblNegativePrompt.Size = new Size(122, 20);
            lblNegativePrompt.TabIndex = 6;
            lblNegativePrompt.Text = "Negative Prompt";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 11F);
            lblNotes.Location = new Point(186, 493);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(48, 20);
            lblNotes.TabIndex = 7;
            lblNotes.Text = "Notes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(358, 33);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 8;
            label6.Text = "..";
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(12, 117);
            txtPrompt.Multiline = true;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.ScrollBars = ScrollBars.Vertical;
            txtPrompt.Size = new Size(396, 172);
            txtPrompt.TabIndex = 9;
            // 
            // txtNegativePrompt
            // 
            txtNegativePrompt.Location = new Point(12, 315);
            txtNegativePrompt.Multiline = true;
            txtNegativePrompt.Name = "txtNegativePrompt";
            txtNegativePrompt.ScrollBars = ScrollBars.Vertical;
            txtNegativePrompt.Size = new Size(396, 172);
            txtNegativePrompt.TabIndex = 10;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(12, 516);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(396, 172);
            txtNotes.TabIndex = 11;
            // 
            // picbxExit
            // 
            picbxExit.Image = (Image)resources.GetObject("picbxExit.Image");
            picbxExit.Location = new Point(978, 212);
            picbxExit.Name = "picbxExit";
            picbxExit.Size = new Size(72, 72);
            picbxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxExit.TabIndex = 14;
            picbxExit.TabStop = false;
            picbxExit.Click += picbxExit_Click;
            // 
            // picbxRefresh
            // 
            picbxRefresh.Image = (Image)resources.GetObject("picbxRefresh.Image");
            picbxRefresh.Location = new Point(978, 134);
            picbxRefresh.Name = "picbxRefresh";
            picbxRefresh.Size = new Size(72, 72);
            picbxRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxRefresh.TabIndex = 15;
            picbxRefresh.TabStop = false;
            picbxRefresh.Click += picbxRefresh_Click;
            // 
            // pctbxRefreshPrompt
            // 
            pctbxRefreshPrompt.Image = (Image)resources.GetObject("pctbxRefreshPrompt.Image");
            pctbxRefreshPrompt.Location = new Point(414, 134);
            pctbxRefreshPrompt.Name = "pctbxRefreshPrompt";
            pctbxRefreshPrompt.Size = new Size(50, 55);
            pctbxRefreshPrompt.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxRefreshPrompt.TabIndex = 16;
            pctbxRefreshPrompt.TabStop = false;
            pctbxRefreshPrompt.Click += pctbxRefreshPrompt_Click;
            // 
            // pctbxNegPrompt
            // 
            pctbxNegPrompt.Image = (Image)resources.GetObject("pctbxNegPrompt.Image");
            pctbxNegPrompt.Location = new Point(414, 315);
            pctbxNegPrompt.Name = "pctbxNegPrompt";
            pctbxNegPrompt.Size = new Size(50, 55);
            pctbxNegPrompt.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxNegPrompt.TabIndex = 17;
            pctbxNegPrompt.TabStop = false;
            pctbxNegPrompt.Click += pctbxNegPrompt_Click;
            // 
            // pctbxNotes
            // 
            pctbxNotes.Image = (Image)resources.GetObject("pctbxNotes.Image");
            pctbxNotes.Location = new Point(414, 516);
            pctbxNotes.Name = "pctbxNotes";
            pctbxNotes.Size = new Size(50, 55);
            pctbxNotes.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxNotes.TabIndex = 18;
            pctbxNotes.TabStop = false;
            pctbxNotes.Click += pctbxNotes_Click;
            // 
            // pctbxRefreshTitle
            // 
            pctbxRefreshTitle.Image = (Image)resources.GetObject("pctbxRefreshTitle.Image");
            pctbxRefreshTitle.Location = new Point(555, 52);
            pctbxRefreshTitle.Name = "pctbxRefreshTitle";
            pctbxRefreshTitle.Size = new Size(50, 55);
            pctbxRefreshTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxRefreshTitle.TabIndex = 19;
            pctbxRefreshTitle.TabStop = false;
            pctbxRefreshTitle.Click += pctbxRefreshTitle_Click;
            // 
            // txtMiscNote
            // 
            txtMiscNote.Location = new Point(485, 117);
            txtMiscNote.Multiline = true;
            txtMiscNote.Name = "txtMiscNote";
            txtMiscNote.ScrollBars = ScrollBars.Vertical;
            txtMiscNote.Size = new Size(396, 571);
            txtMiscNote.TabIndex = 21;
            // 
            // lblMiscNotes
            // 
            lblMiscNotes.AutoSize = true;
            lblMiscNotes.Font = new Font("Segoe UI", 11F);
            lblMiscNotes.Location = new Point(654, 94);
            lblMiscNotes.Name = "lblMiscNotes";
            lblMiscNotes.Size = new Size(82, 20);
            lblMiscNotes.TabIndex = 20;
            lblMiscNotes.Text = "Misc Notes";
            // 
            // pctbxRefreshMiscNotes
            // 
            pctbxRefreshMiscNotes.Image = (Image)resources.GetObject("pctbxRefreshMiscNotes.Image");
            pctbxRefreshMiscNotes.Location = new Point(887, 134);
            pctbxRefreshMiscNotes.Name = "pctbxRefreshMiscNotes";
            pctbxRefreshMiscNotes.Size = new Size(50, 55);
            pctbxRefreshMiscNotes.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxRefreshMiscNotes.TabIndex = 22;
            pctbxRefreshMiscNotes.TabStop = false;
            pctbxRefreshMiscNotes.Click += pctbxRefreshMiscNotes_Click;
            // 
            // AIImageNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 707);
            Controls.Add(pctbxRefreshMiscNotes);
            Controls.Add(txtMiscNote);
            Controls.Add(lblMiscNotes);
            Controls.Add(pctbxRefreshTitle);
            Controls.Add(pctbxNotes);
            Controls.Add(pctbxNegPrompt);
            Controls.Add(pctbxRefreshPrompt);
            Controls.Add(picbxRefresh);
            Controls.Add(picbxExit);
            Controls.Add(txtNotes);
            Controls.Add(txtNegativePrompt);
            Controls.Add(txtPrompt);
            Controls.Add(label6);
            Controls.Add(lblNotes);
            Controls.Add(lblNegativePrompt);
            Controls.Add(lblPrompt);
            Controls.Add(txtPromptTitle);
            Controls.Add(lblPromptTitle);
            Controls.Add(txtRating);
            Controls.Add(lblRating);
            Controls.Add(mnustrp);
            MainMenuStrip = mnustrp;
            Name = "AIImageNotes";
            Text = "AIImageNotes";
            mnustrp.ResumeLayout(false);
            mnustrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbxRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxRefreshPrompt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxNegPrompt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxRefreshTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxRefreshMiscNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnustrp;
        private ToolStripMenuItem mnustrpFile;
        private ToolStripMenuItem mnustrpFileClearForm;
        private ToolStripMenuItem mnustrpFileExit;
        private ToolStripMenuItem mnustrpAbout;
        private Label lblRating;
        private TextBox txtRating;
        private Label lblPromptTitle;
        private TextBox txtPromptTitle;
        private Label lblPrompt;
        private Label lblNegativePrompt;
        private Label lblNotes;
        private Label label6;
        private TextBox txtPrompt;
        private TextBox txtNegativePrompt;
        private TextBox txtNotes;
        private PictureBox picbxExit;
        private PictureBox picbxRefresh;
        private PictureBox pctbxRefreshPrompt;
        private PictureBox pctbxNegPrompt;
        private PictureBox pctbxNotes;
        private PictureBox pctbxRefreshTitle;
        private TextBox txtMiscNote;
        private Label lblMiscNotes;
        private PictureBox pctbxRefreshMiscNotes;
    }
}