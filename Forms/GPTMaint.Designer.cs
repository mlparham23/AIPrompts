namespace AIPrompts.Forms
{
    partial class GPTMaint
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
            mnustrpFileExit = new ToolStripMenuItem();
            mnustrpCategories = new ToolStripMenuItem();
            mnustrpCategoriesAdd = new ToolStripMenuItem();
            mnustrpCategoriesRename = new ToolStripMenuItem();
            mnustrpCategoriesDelete = new ToolStripMenuItem();
            mnustrpCategoriesRefresh = new ToolStripMenuItem();
            mnustrpGpts = new ToolStripMenuItem();
            mnustrpGptsAdd = new ToolStripMenuItem();
            mnustrpGptsRename = new ToolStripMenuItem();
            mnustrpGptsDelete = new ToolStripMenuItem();
            mnustrpGptsRefresh = new ToolStripMenuItem();
            lstbxCategories = new ListBox();
            lstbxGpts = new ListBox();
            grpbxCategories = new GroupBox();
            btnCategoriesRefresh = new Button();
            btnCategoriesAdd = new Button();
            btnCategoriesDelete = new Button();
            btnCategoriesRename = new Button();
            txtCategories = new TextBox();
            grpbxGpts = new GroupBox();
            btnGptsRefresh = new Button();
            txtGpts = new TextBox();
            btnGptsAdd = new Button();
            btnGptsDelete = new Button();
            btnGptsRename = new Button();
            btnExit = new Button();
            lblCatSource = new Label();
            lblCatDestination = new Label();
            txtCatDest = new TextBox();
            lblGPTDestination = new Label();
            lblGPTSource = new Label();
            txtGPTDest = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            mnustrp.SuspendLayout();
            grpbxCategories.SuspendLayout();
            grpbxGpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // mnustrp
            // 
            mnustrp.Items.AddRange(new ToolStripItem[] { mnustrpFile, mnustrpCategories, mnustrpGpts });
            mnustrp.Location = new Point(0, 0);
            mnustrp.Name = "mnustrp";
            mnustrp.Size = new Size(967, 24);
            mnustrp.TabIndex = 0;
            mnustrp.Text = "menuStrip1";
            // 
            // mnustrpFile
            // 
            mnustrpFile.DropDownItems.AddRange(new ToolStripItem[] { mnustrpFileExit });
            mnustrpFile.Name = "mnustrpFile";
            mnustrpFile.Size = new Size(37, 20);
            mnustrpFile.Text = "File";
            // 
            // mnustrpFileExit
            // 
            mnustrpFileExit.Name = "mnustrpFileExit";
            mnustrpFileExit.Size = new Size(93, 22);
            mnustrpFileExit.Text = "Exit";
            mnustrpFileExit.Click += mnustrpFileExit_Click;
            // 
            // mnustrpCategories
            // 
            mnustrpCategories.DropDownItems.AddRange(new ToolStripItem[] { mnustrpCategoriesAdd, mnustrpCategoriesRename, mnustrpCategoriesDelete, mnustrpCategoriesRefresh });
            mnustrpCategories.Name = "mnustrpCategories";
            mnustrpCategories.Size = new Size(75, 20);
            mnustrpCategories.Text = "Categories";
            // 
            // mnustrpCategoriesAdd
            // 
            mnustrpCategoriesAdd.Name = "mnustrpCategoriesAdd";
            mnustrpCategoriesAdd.Size = new Size(117, 22);
            mnustrpCategoriesAdd.Text = "Add";
            mnustrpCategoriesAdd.Click += mnustrpCategoriesAdd_Click;
            // 
            // mnustrpCategoriesRename
            // 
            mnustrpCategoriesRename.Name = "mnustrpCategoriesRename";
            mnustrpCategoriesRename.Size = new Size(117, 22);
            mnustrpCategoriesRename.Text = "Rename";
            mnustrpCategoriesRename.Click += mnustrpCategoriesRename_Click;
            // 
            // mnustrpCategoriesDelete
            // 
            mnustrpCategoriesDelete.Name = "mnustrpCategoriesDelete";
            mnustrpCategoriesDelete.Size = new Size(117, 22);
            mnustrpCategoriesDelete.Text = "Delete";
            mnustrpCategoriesDelete.Click += mnustrpCategoriesDelete_Click;
            // 
            // mnustrpCategoriesRefresh
            // 
            mnustrpCategoriesRefresh.Name = "mnustrpCategoriesRefresh";
            mnustrpCategoriesRefresh.Size = new Size(117, 22);
            mnustrpCategoriesRefresh.Text = "Refresh";
            mnustrpCategoriesRefresh.Click += mnustrpCategoriesRefresh_Click;
            // 
            // mnustrpGpts
            // 
            mnustrpGpts.DropDownItems.AddRange(new ToolStripItem[] { mnustrpGptsAdd, mnustrpGptsRename, mnustrpGptsDelete, mnustrpGptsRefresh });
            mnustrpGpts.Name = "mnustrpGpts";
            mnustrpGpts.Size = new Size(44, 20);
            mnustrpGpts.Text = "GPTs";
            // 
            // mnustrpGptsAdd
            // 
            mnustrpGptsAdd.Name = "mnustrpGptsAdd";
            mnustrpGptsAdd.Size = new Size(117, 22);
            mnustrpGptsAdd.Text = "Add";
            mnustrpGptsAdd.Click += mnustrpGptsAdd_Click;
            // 
            // mnustrpGptsRename
            // 
            mnustrpGptsRename.Name = "mnustrpGptsRename";
            mnustrpGptsRename.Size = new Size(117, 22);
            mnustrpGptsRename.Text = "Rename";
            mnustrpGptsRename.Click += mnustrpGptsRename_Click;
            // 
            // mnustrpGptsDelete
            // 
            mnustrpGptsDelete.Name = "mnustrpGptsDelete";
            mnustrpGptsDelete.Size = new Size(117, 22);
            mnustrpGptsDelete.Text = "Delete";
            mnustrpGptsDelete.Click += mnustrpGptsDelete_Click;
            // 
            // mnustrpGptsRefresh
            // 
            mnustrpGptsRefresh.Name = "mnustrpGptsRefresh";
            mnustrpGptsRefresh.Size = new Size(117, 22);
            mnustrpGptsRefresh.Text = "Refresh";
            mnustrpGptsRefresh.Click += mnustrpGptsRefresh_Click;
            // 
            // lstbxCategories
            // 
            lstbxCategories.Font = new Font("Segoe UI", 12F);
            lstbxCategories.FormattingEnabled = true;
            lstbxCategories.ItemHeight = 21;
            lstbxCategories.Location = new Point(6, 32);
            lstbxCategories.Name = "lstbxCategories";
            lstbxCategories.Size = new Size(241, 655);
            lstbxCategories.TabIndex = 1;
            lstbxCategories.SelectedIndexChanged += lstbxCategories_SelectedIndexChanged;
            // 
            // lstbxGpts
            // 
            lstbxGpts.Font = new Font("Segoe UI", 12F);
            lstbxGpts.FormattingEnabled = true;
            lstbxGpts.ItemHeight = 21;
            lstbxGpts.Location = new Point(182, 32);
            lstbxGpts.Name = "lstbxGpts";
            lstbxGpts.Size = new Size(170, 655);
            lstbxGpts.TabIndex = 2;
            lstbxGpts.SelectedIndexChanged += lstbxGpts_SelectedIndexChanged;
            // 
            // grpbxCategories
            // 
            grpbxCategories.Controls.Add(txtCatDest);
            grpbxCategories.Controls.Add(lblCatDestination);
            grpbxCategories.Controls.Add(lblCatSource);
            grpbxCategories.Controls.Add(btnCategoriesRefresh);
            grpbxCategories.Controls.Add(btnCategoriesAdd);
            grpbxCategories.Controls.Add(btnCategoriesDelete);
            grpbxCategories.Controls.Add(btnCategoriesRename);
            grpbxCategories.Controls.Add(txtCategories);
            grpbxCategories.Controls.Add(lstbxCategories);
            grpbxCategories.Location = new Point(12, 37);
            grpbxCategories.Name = "grpbxCategories";
            grpbxCategories.Size = new Size(476, 696);
            grpbxCategories.TabIndex = 4;
            grpbxCategories.TabStop = false;
            grpbxCategories.Text = "Categories";
            // 
            // btnCategoriesRefresh
            // 
            btnCategoriesRefresh.BackColor = Color.SkyBlue;
            btnCategoriesRefresh.Font = new Font("Segoe UI", 12F);
            btnCategoriesRefresh.Location = new Point(311, 326);
            btnCategoriesRefresh.Name = "btnCategoriesRefresh";
            btnCategoriesRefresh.Size = new Size(100, 37);
            btnCategoriesRefresh.TabIndex = 6;
            btnCategoriesRefresh.Text = "Refresh";
            btnCategoriesRefresh.UseVisualStyleBackColor = false;
            btnCategoriesRefresh.Click += btnCategoriesRefresh_Click;
            // 
            // btnCategoriesAdd
            // 
            btnCategoriesAdd.BackColor = Color.SkyBlue;
            btnCategoriesAdd.Font = new Font("Segoe UI", 12F);
            btnCategoriesAdd.Location = new Point(311, 197);
            btnCategoriesAdd.Name = "btnCategoriesAdd";
            btnCategoriesAdd.Size = new Size(100, 37);
            btnCategoriesAdd.TabIndex = 5;
            btnCategoriesAdd.Text = "Add";
            btnCategoriesAdd.UseVisualStyleBackColor = false;
            btnCategoriesAdd.Click += btnCategoriesAdd_Click;
            // 
            // btnCategoriesDelete
            // 
            btnCategoriesDelete.BackColor = Color.SkyBlue;
            btnCategoriesDelete.Font = new Font("Segoe UI", 12F);
            btnCategoriesDelete.Location = new Point(311, 283);
            btnCategoriesDelete.Name = "btnCategoriesDelete";
            btnCategoriesDelete.Size = new Size(100, 37);
            btnCategoriesDelete.TabIndex = 4;
            btnCategoriesDelete.Text = "Delete";
            btnCategoriesDelete.UseVisualStyleBackColor = false;
            btnCategoriesDelete.Click += btnCategoriesDelete_Click;
            // 
            // btnCategoriesRename
            // 
            btnCategoriesRename.BackColor = Color.SkyBlue;
            btnCategoriesRename.Font = new Font("Segoe UI", 12F);
            btnCategoriesRename.Location = new Point(311, 240);
            btnCategoriesRename.Name = "btnCategoriesRename";
            btnCategoriesRename.Size = new Size(100, 37);
            btnCategoriesRename.TabIndex = 3;
            btnCategoriesRename.Text = "Rename";
            btnCategoriesRename.UseVisualStyleBackColor = false;
            btnCategoriesRename.Click += btnCategoriesRename_Click;
            // 
            // txtCategories
            // 
            txtCategories.Font = new Font("Segoe UI", 12F);
            txtCategories.Location = new Point(253, 50);
            txtCategories.Multiline = true;
            txtCategories.Name = "txtCategories";
            txtCategories.Size = new Size(217, 60);
            txtCategories.TabIndex = 2;
            // 
            // grpbxGpts
            // 
            grpbxGpts.Controls.Add(txtGPTDest);
            grpbxGpts.Controls.Add(lblGPTDestination);
            grpbxGpts.Controls.Add(btnGptsRefresh);
            grpbxGpts.Controls.Add(lblGPTSource);
            grpbxGpts.Controls.Add(txtGpts);
            grpbxGpts.Controls.Add(btnGptsAdd);
            grpbxGpts.Controls.Add(btnGptsDelete);
            grpbxGpts.Controls.Add(lstbxGpts);
            grpbxGpts.Controls.Add(btnGptsRename);
            grpbxGpts.Location = new Point(600, 37);
            grpbxGpts.Name = "grpbxGpts";
            grpbxGpts.Size = new Size(361, 696);
            grpbxGpts.TabIndex = 5;
            grpbxGpts.TabStop = false;
            grpbxGpts.Text = "GPTs";
            // 
            // btnGptsRefresh
            // 
            btnGptsRefresh.BackColor = Color.SkyBlue;
            btnGptsRefresh.Font = new Font("Segoe UI", 12F);
            btnGptsRefresh.Location = new Point(41, 326);
            btnGptsRefresh.Name = "btnGptsRefresh";
            btnGptsRefresh.Size = new Size(100, 37);
            btnGptsRefresh.TabIndex = 9;
            btnGptsRefresh.Text = "Refresh";
            btnGptsRefresh.UseVisualStyleBackColor = false;
            btnGptsRefresh.Click += btnGptsRefresh_Click;
            // 
            // txtGpts
            // 
            txtGpts.Font = new Font("Segoe UI", 12F);
            txtGpts.Location = new Point(6, 50);
            txtGpts.Multiline = true;
            txtGpts.Name = "txtGpts";
            txtGpts.Size = new Size(170, 60);
            txtGpts.TabIndex = 6;
            // 
            // btnGptsAdd
            // 
            btnGptsAdd.BackColor = Color.SkyBlue;
            btnGptsAdd.Font = new Font("Segoe UI", 12F);
            btnGptsAdd.Location = new Point(41, 197);
            btnGptsAdd.Name = "btnGptsAdd";
            btnGptsAdd.Size = new Size(100, 37);
            btnGptsAdd.TabIndex = 8;
            btnGptsAdd.Text = "Add";
            btnGptsAdd.UseVisualStyleBackColor = false;
            btnGptsAdd.Click += btnGptsAdd_Click;
            // 
            // btnGptsDelete
            // 
            btnGptsDelete.BackColor = Color.SkyBlue;
            btnGptsDelete.Font = new Font("Segoe UI", 12F);
            btnGptsDelete.Location = new Point(41, 283);
            btnGptsDelete.Name = "btnGptsDelete";
            btnGptsDelete.Size = new Size(100, 37);
            btnGptsDelete.TabIndex = 7;
            btnGptsDelete.Text = "Delete";
            btnGptsDelete.UseVisualStyleBackColor = false;
            btnGptsDelete.Click += btnGptsDelete_Click;
            // 
            // btnGptsRename
            // 
            btnGptsRename.BackColor = Color.SkyBlue;
            btnGptsRename.Font = new Font("Segoe UI", 12F);
            btnGptsRename.Location = new Point(41, 240);
            btnGptsRename.Name = "btnGptsRename";
            btnGptsRename.Size = new Size(100, 37);
            btnGptsRename.TabIndex = 6;
            btnGptsRename.Text = "Rename";
            btnGptsRename.UseVisualStyleBackColor = false;
            btnGptsRename.Click += btnGptsRename_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SkyBlue;
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(494, 147);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 37);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblCatSource
            // 
            lblCatSource.AutoSize = true;
            lblCatSource.Location = new Point(340, 32);
            lblCatSource.Name = "lblCatSource";
            lblCatSource.Size = new Size(43, 15);
            lblCatSource.TabIndex = 7;
            lblCatSource.Text = "Source";
            // 
            // lblCatDestination
            // 
            lblCatDestination.AutoSize = true;
            lblCatDestination.Location = new Point(328, 113);
            lblCatDestination.Name = "lblCatDestination";
            lblCatDestination.Size = new Size(67, 15);
            lblCatDestination.TabIndex = 8;
            lblCatDestination.Text = "Destination";
            // 
            // txtCatDest
            // 
            txtCatDest.Font = new Font("Segoe UI", 12F);
            txtCatDest.Location = new Point(253, 131);
            txtCatDest.Multiline = true;
            txtCatDest.Name = "txtCatDest";
            txtCatDest.Size = new Size(217, 60);
            txtCatDest.TabIndex = 9;
            // 
            // lblGPTDestination
            // 
            lblGPTDestination.AutoSize = true;
            lblGPTDestination.Location = new Point(58, 113);
            lblGPTDestination.Name = "lblGPTDestination";
            lblGPTDestination.Size = new Size(67, 15);
            lblGPTDestination.TabIndex = 11;
            lblGPTDestination.Text = "Destination";
            // 
            // lblGPTSource
            // 
            lblGPTSource.AutoSize = true;
            lblGPTSource.Location = new Point(70, 32);
            lblGPTSource.Name = "lblGPTSource";
            lblGPTSource.Size = new Size(43, 15);
            lblGPTSource.TabIndex = 10;
            lblGPTSource.Text = "Source";
            // 
            // txtGPTDest
            // 
            txtGPTDest.Font = new Font("Segoe UI", 12F);
            txtGPTDest.Location = new Point(6, 131);
            txtGPTDest.Multiline = true;
            txtGPTDest.Name = "txtGPTDest";
            txtGPTDest.Size = new Size(170, 60);
            txtGPTDest.TabIndex = 12;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GPTMaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 745);
            Controls.Add(btnExit);
            Controls.Add(grpbxGpts);
            Controls.Add(grpbxCategories);
            Controls.Add(mnustrp);
            MainMenuStrip = mnustrp;
            Name = "GPTMaint";
            Text = "GPTMaint";
            mnustrp.ResumeLayout(false);
            mnustrp.PerformLayout();
            grpbxCategories.ResumeLayout(false);
            grpbxCategories.PerformLayout();
            grpbxGpts.ResumeLayout(false);
            grpbxGpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnustrp;
        private ToolStripMenuItem mnustrpFile;
        private ListBox lstbxCategories;
        private ListBox lstbxGpts;
        private GroupBox grpbxCategories;
        private Button btnCategoriesAdd;
        private Button btnCategoriesDelete;
        private Button btnCategoriesRename;
        private TextBox txtCategories;
        private GroupBox grpbxGpts;
        private Button btnGptsAdd;
        private Button btnGptsDelete;
        private Button btnGptsRename;
        private ToolStripMenuItem mnustrpFileExit;
        private ToolStripMenuItem mnustrpCategories;
        private ToolStripMenuItem mnustrpCategoriesAdd;
        private ToolStripMenuItem mnustrpCategoriesRename;
        private ToolStripMenuItem mnustrpCategoriesDelete;
        private ToolStripMenuItem mnustrpGpts;
        private ToolStripMenuItem mnustrpGptsAdd;
        private ToolStripMenuItem mnustrpGptsRename;
        private ToolStripMenuItem mnustrpGptsDelete;
        private TextBox txtGpts;
        private Button btnExit;
        private Button btnCategoriesRefresh;
        private Button btnGptsRefresh;
        private ToolStripMenuItem mnustrpCategoriesRefresh;
        private ToolStripMenuItem mnustrpGptsRefresh;
        private Label lblCatSource;
        private TextBox txtCatDest;
        private Label lblCatDestination;
        private TextBox txtGPTDest;
        private Label lblGPTDestination;
        private Label lblGPTSource;
        private FileSystemWatcher fileSystemWatcher1;
    }
}