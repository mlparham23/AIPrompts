using AIPrompts.Models;
using System;
using System.Windows.Forms;

namespace AIPrompts.Forms
{
    public partial class MsgBoxSystem : Form
    {
        #region Startup

        public int Result { get; set; }
        private readonly CustMsgBox _custMsgBox;

        public MsgBoxSystem(CustMsgBox custMsgBox)
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
            txtSystem.Text  = _custMsgBox.SystemMessage.Trim();

            SetButtonVisibilityAndText(Button1, _custMsgBox.ButtonText1);
            SetButtonVisibilityAndText(Button2, _custMsgBox.ButtonText2);
            SetButtonVisibilityAndText(Button3, _custMsgBox.ButtonText3);
            SetButtonVisibilityAndText(Button4, _custMsgBox.ButtonText4);
            SetButtonVisibilityAndText(Button5, _custMsgBox.ButtonText5);
            SetButtonVisibilityAndText(Button6, _custMsgBox.ButtonText6);

            SetIcon();
            Button1.Focus();



            //if (!string.IsNullOrEmpty(_custMsgBox.ButtonText1)) { Button1.Visible = true; Button1.Text = cmb.ButtonText1.Trim(); } else { Button1.Visible = false; }
            //if (!string.IsNullOrEmpty(_custMsgBox.ButtonText2)) { Button2.Visible = true; Button2.Text = cmb.ButtonText2.Trim(); } else { Button2.Visible = false; }
            //if (!string.IsNullOrEmpty(cmb.ButtonText3)) { Button3.Visible = true; Button3.Text = cmb.ButtonText3.Trim(); } else { Button3.Visible = false; }
            //if (!string.IsNullOrEmpty(cmb.ButtonText4)) { Button4.Visible = true; Button4.Text = cmb.ButtonText4.Trim(); } else { Button4.Visible = false; }
            //if (!string.IsNullOrEmpty(cmb.ButtonText5)) { Button5.Visible = true; Button5.Text = cmb.ButtonText5.Trim(); } else { Button5.Visible = false; }
            //if (!string.IsNullOrEmpty(cmb.ButtonText6)) { Button6.Visible = true; Button6.Text = cmb.ButtonText6.Trim(); } else { Button6.Visible = false; }


            //if (cmb.Icon == 1) { picbxIcon.Image = Properties.Resources.info; }
            //if (cmb.Icon == 2) { picbxIcon.Image = Properties.Resources.Warning; }
            //if (cmb.Icon == 3) { picbxIcon.Image = Properties.Resources.Error; }
            //if (cmb.Icon == 4) { picbxIcon.Image = Properties.Resources.Misc; }
        }

        private void SetButtonVisibilityAndText(Button button, string buttonText)
        {
            button.Visible  = !string.IsNullOrEmpty(buttonText);
            button.Text     = buttonText?.Trim() ?? string.Empty;
        }

        /// <summary>
        /// Set the icon to display
        /// </summary>
        private void SetIcon()
        {
            switch (_custMsgBox.Icon)
            {
                case (int)MessageBoxIcon.Information:
                    picbxIcon.Image = Properties.Resources.info;
                    break;
                case (int)MessageBoxIcon.Warning:
                    picbxIcon.Image = Properties.Resources.Warning;
                    break;
                case (int)MessageBoxIcon.Error:
                    picbxIcon.Image = Properties.Resources.Error;
                    break;
                case (int)MessageBoxIcon.Question:
                    picbxIcon.Image = Properties.Resources.Misc;
                    break;
            }
        }


        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Result = 1;
        //    this.Close();
        //}

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    Result = 2;
        //    this.Close();
        //}

        //private void Button3_Click(object sender, EventArgs e)
        //{
        //    Result = 3;
        //    this.Close();
        //}

        //private void Button4_Click(object sender, EventArgs e)
        //{
        //    Result = 4;
        //    this.Close();
        //}

        //private void Button5_Click(object sender, EventArgs e)
        //{
        //    Result = 5;
        //    this.Close();
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    Result = 6;
        //    this.Close();
        //}

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Result = 1;
            this.Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Result = 2;
            this.Close();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Result = 3;
            this.Close();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Result = 4;
            this.Close();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Result = 5;
            this.Close();
        }

        private void Button6_Click_1(object sender, EventArgs e)
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
            Warning = 2,
            Error = 3,
            Misc = 4
        }

        #endregion

    }
}
