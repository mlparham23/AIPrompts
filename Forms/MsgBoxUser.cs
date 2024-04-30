using AIPrompts.Models;
using System;
using System.Windows.Forms;

namespace AIPrompts.Forms
{
    public partial class MsgBoxUser : Form, IDisposable
    {
        #region Startup

        public int Result { get; set; }
        private readonly CustMsgBox _custMsgBox;        // = new CustMsgBox();

        public MsgBoxUser(CustMsgBox custMsgBox)
        {
            InitializeComponent();
            _custMsgBox = custMsgBox;
        }

        #endregion

        #region Form

        /// <summary>
        /// Populate the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MsgBoxUser_Load(object sender, EventArgs e)
        {
            PopulateForm();
        }

        #endregion

        #region Code

        /// <summary>
        /// Populate the form
        /// </summary>
        private void PopulateForm()
        {
            txtTitle.Text   = _custMsgBox.Title.Trim();
            txtMessage.Text = _custMsgBox.Message.Trim();

            SetButtonVisibilityAndText(Button1, _custMsgBox.ButtonText1);
            SetButtonVisibilityAndText(Button2, _custMsgBox.ButtonText2);
            SetButtonVisibilityAndText(Button3, _custMsgBox.ButtonText3);
            SetButtonVisibilityAndText(Button4, _custMsgBox.ButtonText4);
            SetButtonVisibilityAndText(Button5, _custMsgBox.ButtonText5);
            SetButtonVisibilityAndText(Button6, _custMsgBox.ButtonText6);

            SetIcon();
            Button1.Focus();
        }

        private void SetButtonVisibilityAndText(Button button, string buttonText)
        {
            button.Visible = !string.IsNullOrEmpty(buttonText);
            button.Text = buttonText?.Trim() ?? string.Empty;
        }

        /// <summary>
        /// Set the icon to display
        /// </summary>
        private void SetIcon()
        {
            int icon = _custMsgBox.Icon;

            switch (icon)
            {
                case 1:
                    picbxIcon.Image = Properties.Resources.Information_512;
                    break;
                case 2:
                    picbxIcon.Image = Properties.Resources.Question_512;
                    break;
                case 3:
                    picbxIcon.Image = Properties.Resources.Warning_512;
                    break;
                case 4:
                    picbxIcon.Image = Properties.Resources.Error_512;
                    break;
                default:
                    picbxIcon.Image = Properties.Resources.Misc_512;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Result = 1;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Result = 2;
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Result = 3;
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Result = 4;
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Result = 5;
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Result = 6;
            this.Close();
        }

        #endregion

        #region enums

        /// <summary>
        /// Enum: Icon  Custom Messagebox Icons
        /// </summary>
        public enum _icon
        {
            Information = 1,
            Question    = 2,
            Warning     = 3,
            Error       = 4,
            Misc        = 5
        }

        #endregion
    }
}
