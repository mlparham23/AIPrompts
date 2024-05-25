namespace AIPrompts.Forms
{
    partial class ImageMaintMain
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
            mnustrpEditPrompt = new ToolStripMenuItem();
            mnustrpEditPromptAddPrompt = new ToolStripMenuItem();
            mnustrpEditPromptEditPrompt = new ToolStripMenuItem();
            mnustrpEditPromptDeletePrompt = new ToolStripMenuItem();
            mnustrpEditTable = new ToolStripMenuItem();
            mnustrpEditTableCategory = new ToolStripMenuItem();
            mnustrpEditTableStyle = new ToolStripMenuItem();
            mnustrpEditTableModel = new ToolStripMenuItem();
            mnustrpEditTableLora = new ToolStripMenuItem();
            mnustrpEditTableImageSettings = new ToolStripMenuItem();
            mnustrpEditTableSite = new ToolStripMenuItem();
            mnustrpEditTableSiteFeatures = new ToolStripMenuItem();
            btnAddPrompt = new Button();
            btnDeletePrompt = new Button();
            btnEditPrompt = new Button();
            grpbxEditTable = new GroupBox();
            btnEditCategory = new Button();
            btnEditSiteFeature = new Button();
            btnEditSite = new Button();
            btnEditStyle = new Button();
            btnEditImageSetting = new Button();
            btnEditModel = new Button();
            btnEditLora = new Button();
            grpbxEditPrompt = new GroupBox();
            btnCloseWindow = new Button();
            btnImageNotes = new Button();
            mnustrp.SuspendLayout();
            grpbxEditTable.SuspendLayout();
            grpbxEditPrompt.SuspendLayout();
            SuspendLayout();
            // 
            // mnustrp
            // 
            mnustrp.Items.AddRange(new ToolStripItem[] { mnustrpFile, mnustrpEditPrompt, mnustrpEditTable });
            mnustrp.Location = new Point(0, 0);
            mnustrp.Name = "mnustrp";
            mnustrp.Padding = new Padding(7, 3, 0, 3);
            mnustrp.Size = new Size(404, 25);
            mnustrp.TabIndex = 0;
            mnustrp.Text = "menuStrip1";
            // 
            // mnustrpFile
            // 
            mnustrpFile.DropDownItems.AddRange(new ToolStripItem[] { mnustrpFileCloseWindow });
            mnustrpFile.Name = "mnustrpFile";
            mnustrpFile.Size = new Size(37, 19);
            mnustrpFile.Text = "File";
            // 
            // mnustrpFileCloseWindow
            // 
            mnustrpFileCloseWindow.Name = "mnustrpFileCloseWindow";
            mnustrpFileCloseWindow.Size = new Size(150, 22);
            mnustrpFileCloseWindow.Text = "Close Window";
            mnustrpFileCloseWindow.Click += mnustrpFileCloseWindow_Click;
            // 
            // mnustrpEditPrompt
            // 
            mnustrpEditPrompt.DropDownItems.AddRange(new ToolStripItem[] { mnustrpEditPromptAddPrompt, mnustrpEditPromptEditPrompt, mnustrpEditPromptDeletePrompt });
            mnustrpEditPrompt.Name = "mnustrpEditPrompt";
            mnustrpEditPrompt.Size = new Size(82, 19);
            mnustrpEditPrompt.Text = "Edit Prompt";
            // 
            // mnustrpEditPromptAddPrompt
            // 
            mnustrpEditPromptAddPrompt.Name = "mnustrpEditPromptAddPrompt";
            mnustrpEditPromptAddPrompt.Size = new Size(150, 22);
            mnustrpEditPromptAddPrompt.Text = "Add Prompt";
            mnustrpEditPromptAddPrompt.Click += mnustrpEditPromptAddPrompt_Click;
            // 
            // mnustrpEditPromptEditPrompt
            // 
            mnustrpEditPromptEditPrompt.Name = "mnustrpEditPromptEditPrompt";
            mnustrpEditPromptEditPrompt.Size = new Size(150, 22);
            mnustrpEditPromptEditPrompt.Text = "Edit Prompt";
            mnustrpEditPromptEditPrompt.Click += mnustrpEditPromptEditPrompt_Click;
            // 
            // mnustrpEditPromptDeletePrompt
            // 
            mnustrpEditPromptDeletePrompt.Name = "mnustrpEditPromptDeletePrompt";
            mnustrpEditPromptDeletePrompt.Size = new Size(150, 22);
            mnustrpEditPromptDeletePrompt.Text = "Delete Prompt";
            mnustrpEditPromptDeletePrompt.Click += mnustrpEditPromptDeletePrompt_Click;
            // 
            // mnustrpEditTable
            // 
            mnustrpEditTable.DropDownItems.AddRange(new ToolStripItem[] { mnustrpEditTableCategory, mnustrpEditTableStyle, mnustrpEditTableModel, mnustrpEditTableLora, mnustrpEditTableImageSettings, mnustrpEditTableSite, mnustrpEditTableSiteFeatures });
            mnustrpEditTable.Name = "mnustrpEditTable";
            mnustrpEditTable.Size = new Size(69, 19);
            mnustrpEditTable.Text = "Edit Table";
            // 
            // mnustrpEditTableCategory
            // 
            mnustrpEditTableCategory.Name = "mnustrpEditTableCategory";
            mnustrpEditTableCategory.Size = new Size(152, 22);
            mnustrpEditTableCategory.Text = "Category";
            mnustrpEditTableCategory.Click += mnustrpEditTableCategory_Click;
            // 
            // mnustrpEditTableStyle
            // 
            mnustrpEditTableStyle.Name = "mnustrpEditTableStyle";
            mnustrpEditTableStyle.Size = new Size(152, 22);
            mnustrpEditTableStyle.Text = "Style";
            mnustrpEditTableStyle.Click += mnustrpEditTableStyle_Click;
            // 
            // mnustrpEditTableModel
            // 
            mnustrpEditTableModel.Name = "mnustrpEditTableModel";
            mnustrpEditTableModel.Size = new Size(152, 22);
            mnustrpEditTableModel.Text = "Model";
            mnustrpEditTableModel.Click += mnustrpEditTableModel_Click;
            // 
            // mnustrpEditTableLora
            // 
            mnustrpEditTableLora.Name = "mnustrpEditTableLora";
            mnustrpEditTableLora.Size = new Size(152, 22);
            mnustrpEditTableLora.Text = "Lora";
            mnustrpEditTableLora.Click += mnustrpEditTableLora_Click;
            // 
            // mnustrpEditTableImageSettings
            // 
            mnustrpEditTableImageSettings.Name = "mnustrpEditTableImageSettings";
            mnustrpEditTableImageSettings.Size = new Size(152, 22);
            mnustrpEditTableImageSettings.Text = "Image Settings";
            mnustrpEditTableImageSettings.Click += mnustrpEditTableImageSettings_Click;
            // 
            // mnustrpEditTableSite
            // 
            mnustrpEditTableSite.Name = "mnustrpEditTableSite";
            mnustrpEditTableSite.Size = new Size(152, 22);
            mnustrpEditTableSite.Text = "Site";
            mnustrpEditTableSite.Click += mnustrpEditTableSite_Click;
            // 
            // mnustrpEditTableSiteFeatures
            // 
            mnustrpEditTableSiteFeatures.Name = "mnustrpEditTableSiteFeatures";
            mnustrpEditTableSiteFeatures.Size = new Size(152, 22);
            mnustrpEditTableSiteFeatures.Text = "Site Features";
            mnustrpEditTableSiteFeatures.Click += mnustrpEditTableSiteFeatures_Click;
            // 
            // btnAddPrompt
            // 
            btnAddPrompt.BackColor = Color.FromArgb(192, 255, 255);
            btnAddPrompt.Location = new Point(19, 27);
            btnAddPrompt.Margin = new Padding(3, 4, 3, 4);
            btnAddPrompt.Name = "btnAddPrompt";
            btnAddPrompt.Size = new Size(138, 31);
            btnAddPrompt.TabIndex = 1;
            btnAddPrompt.Text = "Add Prompt";
            btnAddPrompt.UseVisualStyleBackColor = false;
            btnAddPrompt.Click += btnAddPrompt_Click;
            // 
            // btnDeletePrompt
            // 
            btnDeletePrompt.BackColor = Color.FromArgb(192, 255, 255);
            btnDeletePrompt.Location = new Point(19, 105);
            btnDeletePrompt.Margin = new Padding(3, 4, 3, 4);
            btnDeletePrompt.Name = "btnDeletePrompt";
            btnDeletePrompt.Size = new Size(138, 31);
            btnDeletePrompt.TabIndex = 2;
            btnDeletePrompt.Text = "Delete Prompt";
            btnDeletePrompt.UseVisualStyleBackColor = false;
            btnDeletePrompt.Click += btnDeletePrompt_Click;
            // 
            // btnEditPrompt
            // 
            btnEditPrompt.BackColor = Color.FromArgb(192, 255, 255);
            btnEditPrompt.Location = new Point(19, 66);
            btnEditPrompt.Margin = new Padding(3, 4, 3, 4);
            btnEditPrompt.Name = "btnEditPrompt";
            btnEditPrompt.Size = new Size(138, 31);
            btnEditPrompt.TabIndex = 3;
            btnEditPrompt.Text = "Edit Prompt";
            btnEditPrompt.UseVisualStyleBackColor = false;
            btnEditPrompt.Click += btnEditPrompt_Click;
            // 
            // grpbxEditTable
            // 
            grpbxEditTable.Controls.Add(btnEditCategory);
            grpbxEditTable.Controls.Add(btnEditSiteFeature);
            grpbxEditTable.Controls.Add(btnEditSite);
            grpbxEditTable.Controls.Add(btnEditStyle);
            grpbxEditTable.Controls.Add(btnEditImageSetting);
            grpbxEditTable.Controls.Add(btnEditModel);
            grpbxEditTable.Controls.Add(btnEditLora);
            grpbxEditTable.Location = new Point(200, 37);
            grpbxEditTable.Name = "grpbxEditTable";
            grpbxEditTable.Size = new Size(182, 312);
            grpbxEditTable.TabIndex = 4;
            grpbxEditTable.TabStop = false;
            grpbxEditTable.Text = "Edit Table";
            // 
            // btnEditCategory
            // 
            btnEditCategory.BackColor = Color.FromArgb(192, 255, 255);
            btnEditCategory.Location = new Point(21, 27);
            btnEditCategory.Margin = new Padding(3, 4, 3, 4);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(138, 31);
            btnEditCategory.TabIndex = 5;
            btnEditCategory.Text = "Category";
            btnEditCategory.UseVisualStyleBackColor = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnEditSiteFeature
            // 
            btnEditSiteFeature.BackColor = Color.FromArgb(192, 255, 255);
            btnEditSiteFeature.Location = new Point(21, 261);
            btnEditSiteFeature.Margin = new Padding(3, 4, 3, 4);
            btnEditSiteFeature.Name = "btnEditSiteFeature";
            btnEditSiteFeature.Size = new Size(138, 31);
            btnEditSiteFeature.TabIndex = 6;
            btnEditSiteFeature.Text = "Site Feature";
            btnEditSiteFeature.UseVisualStyleBackColor = false;
            btnEditSiteFeature.Click += btnEditSiteFeature_Click;
            // 
            // btnEditSite
            // 
            btnEditSite.BackColor = Color.FromArgb(192, 255, 255);
            btnEditSite.Location = new Point(21, 222);
            btnEditSite.Margin = new Padding(3, 4, 3, 4);
            btnEditSite.Name = "btnEditSite";
            btnEditSite.Size = new Size(138, 31);
            btnEditSite.TabIndex = 10;
            btnEditSite.Text = "Site";
            btnEditSite.UseVisualStyleBackColor = false;
            btnEditSite.Click += btnEditSite_Click;
            // 
            // btnEditStyle
            // 
            btnEditStyle.BackColor = Color.FromArgb(192, 255, 255);
            btnEditStyle.Location = new Point(21, 66);
            btnEditStyle.Margin = new Padding(3, 4, 3, 4);
            btnEditStyle.Name = "btnEditStyle";
            btnEditStyle.Size = new Size(138, 31);
            btnEditStyle.TabIndex = 11;
            btnEditStyle.Text = "Style";
            btnEditStyle.UseVisualStyleBackColor = false;
            btnEditStyle.Click += btnEditStyle_Click;
            // 
            // btnEditImageSetting
            // 
            btnEditImageSetting.BackColor = Color.FromArgb(192, 255, 255);
            btnEditImageSetting.Location = new Point(21, 183);
            btnEditImageSetting.Margin = new Padding(3, 4, 3, 4);
            btnEditImageSetting.Name = "btnEditImageSetting";
            btnEditImageSetting.Size = new Size(138, 31);
            btnEditImageSetting.TabIndex = 9;
            btnEditImageSetting.Text = "Image Settings";
            btnEditImageSetting.UseVisualStyleBackColor = false;
            btnEditImageSetting.Click += btnEditImageSetting_Click;
            // 
            // btnEditModel
            // 
            btnEditModel.BackColor = Color.FromArgb(192, 255, 255);
            btnEditModel.Location = new Point(21, 105);
            btnEditModel.Margin = new Padding(3, 4, 3, 4);
            btnEditModel.Name = "btnEditModel";
            btnEditModel.Size = new Size(138, 31);
            btnEditModel.TabIndex = 8;
            btnEditModel.Text = "Model";
            btnEditModel.UseVisualStyleBackColor = false;
            btnEditModel.Click += btnEditModel_Click;
            // 
            // btnEditLora
            // 
            btnEditLora.BackColor = Color.FromArgb(192, 255, 255);
            btnEditLora.Location = new Point(21, 144);
            btnEditLora.Margin = new Padding(3, 4, 3, 4);
            btnEditLora.Name = "btnEditLora";
            btnEditLora.Size = new Size(138, 31);
            btnEditLora.TabIndex = 7;
            btnEditLora.Text = "Lora";
            btnEditLora.UseVisualStyleBackColor = false;
            btnEditLora.Click += btnEditLora_Click;
            // 
            // grpbxEditPrompt
            // 
            grpbxEditPrompt.Controls.Add(btnAddPrompt);
            grpbxEditPrompt.Controls.Add(btnDeletePrompt);
            grpbxEditPrompt.Controls.Add(btnEditPrompt);
            grpbxEditPrompt.Location = new Point(12, 37);
            grpbxEditPrompt.Name = "grpbxEditPrompt";
            grpbxEditPrompt.Size = new Size(182, 153);
            grpbxEditPrompt.TabIndex = 5;
            grpbxEditPrompt.TabStop = false;
            grpbxEditPrompt.Text = "Edit Prompt";
            // 
            // btnCloseWindow
            // 
            btnCloseWindow.BackColor = Color.FromArgb(192, 255, 255);
            btnCloseWindow.Location = new Point(31, 220);
            btnCloseWindow.Margin = new Padding(3, 4, 3, 4);
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.Size = new Size(138, 31);
            btnCloseWindow.TabIndex = 4;
            btnCloseWindow.Text = "Close Window";
            btnCloseWindow.UseVisualStyleBackColor = false;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // btnImageNotes
            // 
            btnImageNotes.BackColor = Color.FromArgb(192, 255, 255);
            btnImageNotes.Location = new Point(31, 259);
            btnImageNotes.Margin = new Padding(3, 4, 3, 4);
            btnImageNotes.Name = "btnImageNotes";
            btnImageNotes.Size = new Size(138, 31);
            btnImageNotes.TabIndex = 4;
            btnImageNotes.Text = "Notes";
            btnImageNotes.UseVisualStyleBackColor = false;
            btnImageNotes.Click += btnImageNotes_Click;
            // 
            // ImageMaintMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 363);
            Controls.Add(btnImageNotes);
            Controls.Add(btnCloseWindow);
            Controls.Add(grpbxEditPrompt);
            Controls.Add(grpbxEditTable);
            Controls.Add(mnustrp);
            Font = new Font("Segoe UI", 11F);
            MainMenuStrip = mnustrp;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImageMaintMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI Image Maintenance (Main)";
            Load += ImageMaintMain_Load;
            mnustrp.ResumeLayout(false);
            mnustrp.PerformLayout();
            grpbxEditTable.ResumeLayout(false);
            grpbxEditPrompt.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnustrp;
        private ToolStripMenuItem mnustrpFile;
        private ToolStripMenuItem mnustrpFileCloseWindow;
        private Button btnAddPrompt;
        private Button btnDeletePrompt;
        private Button btnEditPrompt;
        private GroupBox grpbxEditTable;
        private Button btnEditCategory;
        private Button btnEditSiteFeature;
        private Button btnEditLora;
        private Button btnEditModel;
        private Button btnEditImageSetting;
        private Button btnEditSite;
        private Button btnEditStyle;
        private ToolStripMenuItem mnustrpEditPrompt;
        private ToolStripMenuItem mnustrpEditPromptAddPrompt;
        private ToolStripMenuItem mnustrpEditPromptEditPrompt;
        private ToolStripMenuItem mnustrpEditPromptDeletePrompt;
        private ToolStripMenuItem mnustrpEditTable;
        private ToolStripMenuItem mnustrpEditTableCategory;
        private ToolStripMenuItem mnustrpEditTableStyle;
        private GroupBox grpbxEditPrompt;
        private Button btnCloseWindow;
        private ToolStripMenuItem mnustrpEditTableModel;
        private ToolStripMenuItem mnustrpEditTableLora;
        private ToolStripMenuItem mnustrpEditTableImageSettings;
        private ToolStripMenuItem mnustrpEditTableSite;
        private ToolStripMenuItem mnustrpEditTableSiteFeatures;
        private Button btnImageNotes;
    }
}