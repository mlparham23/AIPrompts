namespace AIPrompts.Forms
{
    partial class AddImagePrompt
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
            addPromptToolStripMenuItem = new ToolStripMenuItem();
            mnustrpFunction = new ToolStripMenuItem();
            mnustrpFunctionAddPrompt = new ToolStripMenuItem();
            mnustrpFunctionClearScreen = new ToolStripMenuItem();
            mnustrpFunctionRefreshScreen = new ToolStripMenuItem();
            grpbxPrompt = new GroupBox();
            txtTitle = new TextBox();
            lblTitle = new Label();
            label25 = new Label();
            txtNotes = new TextBox();
            txtNegPrompt = new TextBox();
            txtPrompt = new TextBox();
            txtRating = new TextBox();
            lblRating = new Label();
            lblNotes = new Label();
            lblNegPrompt = new Label();
            lblPrompt = new Label();
            grpbxSites = new GroupBox();
            cklstbxSites = new CheckedListBox();
            cklstbxLoras = new CheckedListBox();
            grpbxLoras = new GroupBox();
            cklstbxModels = new CheckedListBox();
            grpbxModels = new GroupBox();
            cklstbxStyles = new CheckedListBox();
            grpbxStyles = new GroupBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            btnExit = new Button();
            grpbxSettings = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            txtCFGScale = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtSaSolverInterference = new TextBox();
            txtSaSolverGuideance = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtDpmsolverInterference = new TextBox();
            txtDpmsolverGuideance = new TextBox();
            label7 = new Label();
            txtTags = new TextBox();
            label6 = new Label();
            cboSampleMethod = new ComboBox();
            label5 = new Label();
            txtScheduler = new TextBox();
            label4 = new Label();
            txtSteps = new TextBox();
            label2 = new Label();
            txtSeed = new TextBox();
            label1 = new Label();
            cboAspectRatio = new ComboBox();
            cklstbxCategories = new CheckedListBox();
            grpbxCategories = new GroupBox();
            mnustrp.SuspendLayout();
            grpbxPrompt.SuspendLayout();
            grpbxSites.SuspendLayout();
            grpbxLoras.SuspendLayout();
            grpbxModels.SuspendLayout();
            grpbxStyles.SuspendLayout();
            grpbxSettings.SuspendLayout();
            grpbxCategories.SuspendLayout();
            SuspendLayout();
            // 
            // mnustrp
            // 
            mnustrp.Items.AddRange(new ToolStripItem[] { mnustrpFile, addPromptToolStripMenuItem, mnustrpFunction });
            mnustrp.Location = new Point(0, 0);
            mnustrp.Name = "mnustrp";
            mnustrp.Size = new Size(1637, 24);
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
            // addPromptToolStripMenuItem
            // 
            addPromptToolStripMenuItem.Name = "addPromptToolStripMenuItem";
            addPromptToolStripMenuItem.Size = new Size(12, 20);
            // 
            // mnustrpFunction
            // 
            mnustrpFunction.DropDownItems.AddRange(new ToolStripItem[] { mnustrpFunctionAddPrompt, mnustrpFunctionClearScreen, mnustrpFunctionRefreshScreen });
            mnustrpFunction.Name = "mnustrpFunction";
            mnustrpFunction.Size = new Size(71, 20);
            mnustrpFunction.Text = "Functions";
            // 
            // mnustrpFunctionAddPrompt
            // 
            mnustrpFunctionAddPrompt.Name = "mnustrpFunctionAddPrompt";
            mnustrpFunctionAddPrompt.Size = new Size(151, 22);
            mnustrpFunctionAddPrompt.Text = "Add Prompt";
            // 
            // mnustrpFunctionClearScreen
            // 
            mnustrpFunctionClearScreen.Name = "mnustrpFunctionClearScreen";
            mnustrpFunctionClearScreen.Size = new Size(151, 22);
            mnustrpFunctionClearScreen.Text = "Clear Screen";
            mnustrpFunctionClearScreen.Click += mnustrpFunctionClearScreen_Click;
            // 
            // mnustrpFunctionRefreshScreen
            // 
            mnustrpFunctionRefreshScreen.Name = "mnustrpFunctionRefreshScreen";
            mnustrpFunctionRefreshScreen.Size = new Size(151, 22);
            mnustrpFunctionRefreshScreen.Text = "Refresh Screen";
            mnustrpFunctionRefreshScreen.Click += mnustrpFunctionRefreshScreen_Click;
            // 
            // grpbxPrompt
            // 
            grpbxPrompt.Controls.Add(txtTitle);
            grpbxPrompt.Controls.Add(lblTitle);
            grpbxPrompt.Controls.Add(label25);
            grpbxPrompt.Controls.Add(txtNotes);
            grpbxPrompt.Controls.Add(txtNegPrompt);
            grpbxPrompt.Controls.Add(txtPrompt);
            grpbxPrompt.Controls.Add(txtRating);
            grpbxPrompt.Controls.Add(lblRating);
            grpbxPrompt.Controls.Add(lblNotes);
            grpbxPrompt.Controls.Add(lblNegPrompt);
            grpbxPrompt.Controls.Add(lblPrompt);
            grpbxPrompt.Location = new Point(12, 27);
            grpbxPrompt.Name = "grpbxPrompt";
            grpbxPrompt.Size = new Size(463, 539);
            grpbxPrompt.TabIndex = 1;
            grpbxPrompt.TabStop = false;
            grpbxPrompt.Text = "Prompt";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(166, 16);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.ScrollBars = ScrollBars.Vertical;
            txtTitle.Size = new Size(283, 23);
            txtTitle.TabIndex = 45;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(131, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 44;
            lblTitle.Text = "Title";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(4, 19);
            label25.Name = "label25";
            label25.Size = new Size(36, 15);
            label25.TabIndex = 43;
            label25.Text = "0 - 10";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(84, 376);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(373, 154);
            txtNotes.TabIndex = 7;
            // 
            // txtNegPrompt
            // 
            txtNegPrompt.Location = new Point(84, 210);
            txtNegPrompt.Multiline = true;
            txtNegPrompt.Name = "txtNegPrompt";
            txtNegPrompt.ScrollBars = ScrollBars.Vertical;
            txtNegPrompt.Size = new Size(373, 154);
            txtNegPrompt.TabIndex = 6;
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(82, 45);
            txtPrompt.Multiline = true;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.ScrollBars = ScrollBars.Vertical;
            txtPrompt.Size = new Size(373, 154);
            txtPrompt.TabIndex = 5;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(84, 16);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(45, 23);
            txtRating.TabIndex = 4;
            txtRating.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(37, 19);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(41, 15);
            lblRating.TabIndex = 3;
            lblRating.Text = "Rating";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(40, 379);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notes";
            // 
            // lblNegPrompt
            // 
            lblNegPrompt.AutoSize = true;
            lblNegPrompt.Location = new Point(6, 213);
            lblNegPrompt.Name = "lblNegPrompt";
            lblNegPrompt.Size = new Size(72, 15);
            lblNegPrompt.TabIndex = 1;
            lblNegPrompt.Text = "Neg Prompt";
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(31, 48);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(47, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Prompt";
            // 
            // grpbxSites
            // 
            grpbxSites.Controls.Add(cklstbxSites);
            grpbxSites.Location = new Point(481, 27);
            grpbxSites.Name = "grpbxSites";
            grpbxSites.Size = new Size(225, 539);
            grpbxSites.TabIndex = 2;
            grpbxSites.TabStop = false;
            grpbxSites.Text = "Sites Used";
            // 
            // cklstbxSites
            // 
            cklstbxSites.FormattingEnabled = true;
            cklstbxSites.Location = new Point(6, 22);
            cklstbxSites.Name = "cklstbxSites";
            cklstbxSites.Size = new Size(213, 508);
            cklstbxSites.TabIndex = 0;
            // 
            // cklstbxLoras
            // 
            cklstbxLoras.FormattingEnabled = true;
            cklstbxLoras.Location = new Point(6, 22);
            cklstbxLoras.Name = "cklstbxLoras";
            cklstbxLoras.Size = new Size(213, 508);
            cklstbxLoras.TabIndex = 0;
            // 
            // grpbxLoras
            // 
            grpbxLoras.Controls.Add(cklstbxLoras);
            grpbxLoras.Location = new Point(712, 27);
            grpbxLoras.Name = "grpbxLoras";
            grpbxLoras.Size = new Size(225, 539);
            grpbxLoras.TabIndex = 3;
            grpbxLoras.TabStop = false;
            grpbxLoras.Text = "Loras Used";
            // 
            // cklstbxModels
            // 
            cklstbxModels.FormattingEnabled = true;
            cklstbxModels.Location = new Point(6, 22);
            cklstbxModels.Name = "cklstbxModels";
            cklstbxModels.Size = new Size(213, 508);
            cklstbxModels.TabIndex = 0;
            // 
            // grpbxModels
            // 
            grpbxModels.Controls.Add(cklstbxModels);
            grpbxModels.Location = new Point(943, 27);
            grpbxModels.Name = "grpbxModels";
            grpbxModels.Size = new Size(225, 539);
            grpbxModels.TabIndex = 4;
            grpbxModels.TabStop = false;
            grpbxModels.Text = "Models Used";
            // 
            // cklstbxStyles
            // 
            cklstbxStyles.FormattingEnabled = true;
            cklstbxStyles.Location = new Point(6, 22);
            cklstbxStyles.Name = "cklstbxStyles";
            cklstbxStyles.Size = new Size(213, 508);
            cklstbxStyles.TabIndex = 0;
            // 
            // grpbxStyles
            // 
            grpbxStyles.Controls.Add(cklstbxStyles);
            grpbxStyles.Location = new Point(1405, 27);
            grpbxStyles.Name = "grpbxStyles";
            grpbxStyles.Size = new Size(225, 539);
            grpbxStyles.TabIndex = 5;
            grpbxStyles.TabStop = false;
            grpbxStyles.Text = "Styles";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SkyBlue;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(94, 572);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 32);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SkyBlue;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(219, 572);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 32);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SkyBlue;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(344, 572);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 32);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SkyBlue;
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(469, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 32);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // grpbxSettings
            // 
            grpbxSettings.Controls.Add(label24);
            grpbxSettings.Controls.Add(label23);
            grpbxSettings.Controls.Add(label22);
            grpbxSettings.Controls.Add(label21);
            grpbxSettings.Controls.Add(label20);
            grpbxSettings.Controls.Add(label19);
            grpbxSettings.Controls.Add(label18);
            grpbxSettings.Controls.Add(label17);
            grpbxSettings.Controls.Add(txtCFGScale);
            grpbxSettings.Controls.Add(label16);
            grpbxSettings.Controls.Add(label15);
            grpbxSettings.Controls.Add(label14);
            grpbxSettings.Controls.Add(label11);
            grpbxSettings.Controls.Add(label12);
            grpbxSettings.Controls.Add(label13);
            grpbxSettings.Controls.Add(txtSaSolverInterference);
            grpbxSettings.Controls.Add(txtSaSolverGuideance);
            grpbxSettings.Controls.Add(label10);
            grpbxSettings.Controls.Add(label9);
            grpbxSettings.Controls.Add(label8);
            grpbxSettings.Controls.Add(txtDpmsolverInterference);
            grpbxSettings.Controls.Add(txtDpmsolverGuideance);
            grpbxSettings.Controls.Add(label7);
            grpbxSettings.Controls.Add(txtTags);
            grpbxSettings.Controls.Add(label6);
            grpbxSettings.Controls.Add(cboSampleMethod);
            grpbxSettings.Controls.Add(label5);
            grpbxSettings.Controls.Add(txtScheduler);
            grpbxSettings.Controls.Add(label4);
            grpbxSettings.Controls.Add(txtSteps);
            grpbxSettings.Controls.Add(label2);
            grpbxSettings.Controls.Add(txtSeed);
            grpbxSettings.Controls.Add(label1);
            grpbxSettings.Controls.Add(cboAspectRatio);
            grpbxSettings.Location = new Point(12, 610);
            grpbxSettings.Name = "grpbxSettings";
            grpbxSettings.Size = new Size(1387, 143);
            grpbxSettings.TabIndex = 10;
            grpbxSettings.TabStop = false;
            grpbxSettings.Text = "Settings";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(803, 100);
            label24.Name = "label24";
            label24.Size = new Size(27, 15);
            label24.TabIndex = 42;
            label24.Text = "Dec";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(631, 100);
            label23.Name = "label23";
            label23.Size = new Size(27, 15);
            label23.TabIndex = 41;
            label23.Text = "Dec";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(884, 85);
            label22.Name = "label22";
            label22.Size = new Size(36, 15);
            label22.TabIndex = 40;
            label22.Text = "1 - 40";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(712, 85);
            label21.Name = "label21";
            label21.Size = new Size(36, 15);
            label21.TabIndex = 39;
            label21.Text = "1 - 40";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(123, 100);
            label20.Name = "label20";
            label20.Size = new Size(76, 15);
            label20.TabIndex = 38;
            label20.Text = "2,147,483,647";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(151, 85);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 37;
            label19.Text = "0 -";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(798, 85);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 36;
            label18.Text = "1 - 12";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(626, 85);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 35;
            label17.Text = "1 - 12";
            // 
            // txtCFGScale
            // 
            txtCFGScale.Location = new Point(207, 59);
            txtCFGScale.Name = "txtCFGScale";
            txtCFGScale.Size = new Size(80, 23);
            txtCFGScale.TabIndex = 34;
            txtCFGScale.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(229, 85);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 33;
            label16.Text = "1 - 20";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(218, 41);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 32;
            label15.Text = "CFG Scale";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(315, 85);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 30;
            label14.Text = "1 - 50";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(867, 41);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 29;
            label11.Text = "Interference";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(827, 26);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 28;
            label12.Text = "SASolver";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(785, 41);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 27;
            label13.Text = "Guideance";
            // 
            // txtSaSolverInterference
            // 
            txtSaSolverInterference.Location = new Point(862, 59);
            txtSaSolverInterference.Name = "txtSaSolverInterference";
            txtSaSolverInterference.Size = new Size(80, 23);
            txtSaSolverInterference.TabIndex = 26;
            txtSaSolverInterference.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSaSolverGuideance
            // 
            txtSaSolverGuideance.Location = new Point(776, 59);
            txtSaSolverGuideance.Name = "txtSaSolverGuideance";
            txtSaSolverGuideance.Size = new Size(80, 23);
            txtSaSolverGuideance.TabIndex = 25;
            txtSaSolverGuideance.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(695, 41);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 24;
            label10.Text = "Interference";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(652, 26);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 23;
            label9.Text = "DPMSolver";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(613, 41);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 22;
            label8.Text = "Guideance";
            // 
            // txtDpmsolverInterference
            // 
            txtDpmsolverInterference.Location = new Point(690, 59);
            txtDpmsolverInterference.Name = "txtDpmsolverInterference";
            txtDpmsolverInterference.Size = new Size(80, 23);
            txtDpmsolverInterference.TabIndex = 21;
            txtDpmsolverInterference.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDpmsolverGuideance
            // 
            txtDpmsolverGuideance.Location = new Point(604, 59);
            txtDpmsolverGuideance.Name = "txtDpmsolverGuideance";
            txtDpmsolverGuideance.Size = new Size(80, 23);
            txtDpmsolverGuideance.TabIndex = 20;
            txtDpmsolverGuideance.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1030, 41);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 19;
            label7.Text = "Tags";
            // 
            // txtTags
            // 
            txtTags.Location = new Point(948, 59);
            txtTags.Multiline = true;
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(195, 73);
            txtTags.TabIndex = 18;
            txtTags.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 41);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 17;
            label6.Text = "Sampling Method";
            // 
            // cboSampleMethod
            // 
            cboSampleMethod.FormattingEnabled = true;
            cboSampleMethod.Location = new Point(465, 59);
            cboSampleMethod.Name = "cboSampleMethod";
            cboSampleMethod.Size = new Size(133, 23);
            cboSampleMethod.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 41);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 15;
            label5.Text = "Scheduler";
            // 
            // txtScheduler
            // 
            txtScheduler.Location = new Point(379, 59);
            txtScheduler.Name = "txtScheduler";
            txtScheduler.Size = new Size(80, 23);
            txtScheduler.TabIndex = 14;
            txtScheduler.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 41);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 13;
            label4.Text = "Steps";
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(293, 59);
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(80, 23);
            txtSteps.TabIndex = 12;
            txtSteps.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 41);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 9;
            label2.Text = "Seed";
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(121, 59);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(80, 23);
            txtSeed.TabIndex = 8;
            txtSeed.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Aspect Ratio";
            // 
            // cboAspectRatio
            // 
            cboAspectRatio.FormattingEnabled = true;
            cboAspectRatio.Location = new Point(6, 59);
            cboAspectRatio.Name = "cboAspectRatio";
            cboAspectRatio.Size = new Size(109, 23);
            cboAspectRatio.TabIndex = 0;
            // 
            // cklstbxCategories
            // 
            cklstbxCategories.FormattingEnabled = true;
            cklstbxCategories.Location = new Point(6, 22);
            cklstbxCategories.Name = "cklstbxCategories";
            cklstbxCategories.Size = new Size(213, 508);
            cklstbxCategories.TabIndex = 0;
            // 
            // grpbxCategories
            // 
            grpbxCategories.Controls.Add(cklstbxCategories);
            grpbxCategories.Location = new Point(1174, 27);
            grpbxCategories.Name = "grpbxCategories";
            grpbxCategories.Size = new Size(225, 539);
            grpbxCategories.TabIndex = 6;
            grpbxCategories.TabStop = false;
            grpbxCategories.Text = "Categories";
            // 
            // AddImagePrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 758);
            Controls.Add(grpbxCategories);
            Controls.Add(grpbxStyles);
            Controls.Add(grpbxSettings);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(grpbxModels);
            Controls.Add(grpbxLoras);
            Controls.Add(grpbxSites);
            Controls.Add(grpbxPrompt);
            Controls.Add(mnustrp);
            MainMenuStrip = mnustrp;
            Name = "AddImagePrompt";
            Text = "AddImagePrompt";
            mnustrp.ResumeLayout(false);
            mnustrp.PerformLayout();
            grpbxPrompt.ResumeLayout(false);
            grpbxPrompt.PerformLayout();
            grpbxSites.ResumeLayout(false);
            grpbxLoras.ResumeLayout(false);
            grpbxModels.ResumeLayout(false);
            grpbxStyles.ResumeLayout(false);
            grpbxSettings.ResumeLayout(false);
            grpbxSettings.PerformLayout();
            grpbxCategories.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnustrp;
        private GroupBox grpbxPrompt;
        private Label lblNotes;
        private Label lblNegPrompt;
        private Label lblPrompt;
        private TextBox txtNotes;
        private TextBox txtNegPrompt;
        private TextBox txtPrompt;
        private TextBox txtRating;
        private Label lblRating;
        private GroupBox grpbxSites;
        private CheckedListBox cklstbxSites;
        private CheckedListBox cklstbxLoras;
        private GroupBox grpbxLoras;
        private CheckedListBox cklstbxModels;
        private GroupBox grpbxModels;
        private CheckedListBox cklstbxStyles;
        private GroupBox grpbxStyles;
        private Button btnAdd;
        private Button btnClear;
        private Button btnRefresh;
        private ToolStripMenuItem mnustrpFile;
        private ToolStripMenuItem mnustrpFileExit;
        private ToolStripMenuItem addPromptToolStripMenuItem;
        private Button btnExit;
        private ToolStripMenuItem mnustrpFunction;
        private ToolStripMenuItem mnustrpFunctionAddPrompt;
        private ToolStripMenuItem mnustrpFunctionClearScreen;
        private ToolStripMenuItem mnustrpFunctionRefreshScreen;
        private GroupBox grpbxSettings;
        private Label label2;
        private TextBox txtSeed;
        private Label label1;
        private ComboBox cboAspectRatio;
        private Label label7;
        private TextBox txtTags;
        private Label label6;
        private ComboBox cboSampleMethod;
        private Label label5;
        private TextBox txtScheduler;
        private Label label4;
        private TextBox txtSteps;
        private Label label8;
        private TextBox txtDpmsolverInterference;
        private TextBox txtDpmsolverGuideance;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSaSolverInterference;
        private TextBox txtSaSolverGuideance;
        private Label label10;
        private Label label9;
        private Label label15;
        private Label label14;
        private TextBox txtCFGScale;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label20;
        private Label label19;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label25;
        private CheckedListBox cklstbxCategories;
        private GroupBox grpbxCategories;
        private TextBox txtTitle;
        private Label lblTitle;
    }
}