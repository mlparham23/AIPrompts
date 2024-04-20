namespace AIPrompts.Forms
{
    partial class MsgBoxUser
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
            txtTitle = new TextBox();
            Button1 = new Button();
            Button2 = new Button();
            Button3 = new Button();
            Button4 = new Button();
            Button5 = new Button();
            txtMessage = new RichTextBox();
            Button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)picbxIcon).BeginInit();
            SuspendLayout();
            // 
            // picbxIcon
            // 
            picbxIcon.Image = Properties.Resources.Warning_512;
            picbxIcon.Location = new Point(12, 12);
            picbxIcon.Name = "picbxIcon";
            picbxIcon.Size = new Size(127, 117);
            picbxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxIcon.TabIndex = 0;
            picbxIcon.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Control;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 14F);
            txtTitle.Location = new Point(159, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(629, 25);
            txtTitle.TabIndex = 1;
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // Button1
            // 
            Button1.BackColor = Color.LightBlue;
            Button1.Font = new Font("Segoe UI", 12F);
            Button1.Location = new Point(159, 43);
            Button1.Name = "Button1";
            Button1.Size = new Size(201, 34);
            Button1.TabIndex = 2;
            Button1.Text = "CANCEL";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.BackColor = Color.LightBlue;
            Button2.Font = new Font("Segoe UI", 12F);
            Button2.Location = new Point(375, 43);
            Button2.Name = "Button2";
            Button2.Size = new Size(201, 34);
            Button2.TabIndex = 3;
            Button2.Text = "CANCEL";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button2_Click;
            // 
            // Button3
            // 
            Button3.BackColor = Color.LightBlue;
            Button3.Font = new Font("Segoe UI", 12F);
            Button3.Location = new Point(587, 43);
            Button3.Name = "Button3";
            Button3.Size = new Size(201, 34);
            Button3.TabIndex = 4;
            Button3.Text = "CANCEL";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += Button3_Click;
            // 
            // Button4
            // 
            Button4.BackColor = Color.LightBlue;
            Button4.Font = new Font("Segoe UI", 12F);
            Button4.Location = new Point(159, 83);
            Button4.Name = "Button4";
            Button4.Size = new Size(201, 34);
            Button4.TabIndex = 5;
            Button4.Text = "CANCEL";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.BackColor = Color.LightBlue;
            Button5.Font = new Font("Segoe UI", 12F);
            Button5.Location = new Point(375, 83);
            Button5.Name = "Button5";
            Button5.Size = new Size(201, 34);
            Button5.TabIndex = 6;
            Button5.Text = "CANCEL";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += Button5_Click;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = SystemColors.MenuBar;
            txtMessage.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMessage.Location = new Point(12, 135);
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(776, 303);
            txtMessage.TabIndex = 7;
            txtMessage.Text = "";
            // 
            // Button6
            // 
            Button6.BackColor = Color.LightBlue;
            Button6.Font = new Font("Segoe UI", 12F);
            Button6.Location = new Point(582, 83);
            Button6.Name = "Button6";
            Button6.Size = new Size(201, 34);
            Button6.TabIndex = 8;
            Button6.Text = "CANCEL";
            Button6.UseVisualStyleBackColor = false;
            Button6.Click += Button6_Click;
            // 
            // MsgBoxUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button6);
            Controls.Add(txtMessage);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(txtTitle);
            Controls.Add(picbxIcon);
            Name = "MsgBoxUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MsgBoxUser";
            Load += MsgBoxUser_Load;
            ((System.ComponentModel.ISupportInitialize)picbxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbxIcon;
        private TextBox txtTitle;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private RichTextBox txtMessage;
        private Button Button6;
    }
}