namespace AIPrompts.Forms
{
    partial class MsgBoxSystem
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
            picbxIcon = new PictureBox();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            txtTitle = new TextBox();
            Button6 = new Button();
            Button5 = new Button();
            Button4 = new Button();
            txtMessage = new RichTextBox();
            lblUser = new Label();
            txtSystem = new TextBox();
            lblSystem = new Label();
            ((System.ComponentModel.ISupportInitialize)picbxIcon).BeginInit();
            SuspendLayout();
            // 
            // picbxIcon
            // 
            picbxIcon.Image = Properties.Resources.Misc;
            picbxIcon.Location = new Point(12, 12);
            picbxIcon.Name = "picbxIcon";
            picbxIcon.Size = new Size(127, 117);
            picbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxIcon.TabIndex = 1;
            picbxIcon.TabStop = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.LightBlue;
            Button3.Font = new Font("Segoe UI", 12F);
            Button3.Location = new Point(573, 43);
            Button3.Name = "Button3";
            Button3.Size = new Size(201, 34);
            Button3.TabIndex = 8;
            Button3.Text = "CANCEL";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += Button3_Click_1;
            // 
            // Button2
            // 
            Button2.BackColor = Color.LightBlue;
            Button2.Font = new Font("Segoe UI", 12F);
            Button2.Location = new Point(361, 43);
            Button2.Name = "Button2";
            Button2.Size = new Size(201, 34);
            Button2.TabIndex = 7;
            Button2.Text = "CANCEL";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button2_Click_1;
            // 
            // Button1
            // 
            Button1.BackColor = Color.LightBlue;
            Button1.Font = new Font("Segoe UI", 12F);
            Button1.Location = new Point(145, 43);
            Button1.Name = "Button1";
            Button1.Size = new Size(201, 34);
            Button1.TabIndex = 6;
            Button1.Text = "CANCEL";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click_1;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Control;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 14F);
            txtTitle.Location = new Point(145, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(629, 25);
            txtTitle.TabIndex = 5;
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // Button6
            // 
            Button6.BackColor = Color.LightBlue;
            Button6.Font = new Font("Segoe UI", 12F);
            Button6.Location = new Point(568, 95);
            Button6.Name = "Button6";
            Button6.Size = new Size(201, 34);
            Button6.TabIndex = 11;
            Button6.Text = "CANCEL";
            Button6.UseVisualStyleBackColor = false;
            Button6.Click += Button6_Click_1;
            // 
            // Button5
            // 
            Button5.BackColor = Color.LightBlue;
            Button5.Font = new Font("Segoe UI", 12F);
            Button5.Location = new Point(361, 95);
            Button5.Name = "Button5";
            Button5.Size = new Size(201, 34);
            Button5.TabIndex = 10;
            Button5.Text = "CANCEL";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += Button5_Click_1;
            // 
            // Button4
            // 
            Button4.BackColor = Color.LightBlue;
            Button4.Font = new Font("Segoe UI", 12F);
            Button4.Location = new Point(145, 95);
            Button4.Name = "Button4";
            Button4.Size = new Size(201, 34);
            Button4.TabIndex = 9;
            Button4.Text = "CANCEL";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += Button4_Click_1;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = SystemColors.MenuBar;
            txtMessage.Font = new Font("Courier New", 12F);
            txtMessage.Location = new Point(12, 157);
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(776, 128);
            txtMessage.TabIndex = 12;
            txtMessage.Text = "";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUser.Location = new Point(358, 137);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(84, 15);
            lblUser.TabIndex = 13;
            lblUser.Text = "User Message";
            // 
            // txtSystem
            // 
            txtSystem.BackColor = SystemColors.MenuBar;
            txtSystem.Location = new Point(12, 314);
            txtSystem.Multiline = true;
            txtSystem.Name = "txtSystem";
            txtSystem.ReadOnly = true;
            txtSystem.ScrollBars = ScrollBars.Vertical;
            txtSystem.Size = new Size(776, 172);
            txtSystem.TabIndex = 14;
            // 
            // lblSystem
            // 
            lblSystem.AutoSize = true;
            lblSystem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSystem.Location = new Point(331, 296);
            lblSystem.Name = "lblSystem";
            lblSystem.Size = new Size(138, 15);
            lblSystem.TabIndex = 15;
            lblSystem.Text = "System / Error Message";
            // 
            // MsgBoxSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(lblSystem);
            Controls.Add(txtSystem);
            Controls.Add(lblUser);
            Controls.Add(txtMessage);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(txtTitle);
            Controls.Add(picbxIcon);
            Name = "MsgBoxSystem";
            Text = "MsgBoxSystem";
            ((System.ComponentModel.ISupportInitialize)picbxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbxIcon;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private TextBox txtTitle;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private RichTextBox txtMessage;
        private Label lblUser;
        private TextBox txtSystem;
        private Label lblSystem;
    }
}