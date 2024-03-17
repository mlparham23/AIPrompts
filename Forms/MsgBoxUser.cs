using AIPrompts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPrompts.Forms
{
    public partial class MsgBoxUser : Form
    {
        #region Startup

        public int Result { get; set; }
        CustMsgBox cmb = new CustMsgBox();

        public MsgBoxUser(CustMsgBox custMsgBox)
        {
            InitializeComponent();
            cmb = custMsgBox;
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
            Populate();
        }

        #endregion

        #region Code

        /// <summary>
        /// Populate the form
        /// </summary>
        private void Populate()
        {
            txtTitle.Text = cmb.Title.Trim();
            txtMessage.Text = cmb.Message.Trim();
            if (!string.IsNullOrEmpty(cmb.ButtonText1)) { Button1.Visible = true; Button1.Text = cmb.ButtonText1.Trim(); } else { Button1.Visible = false; }
            if (!string.IsNullOrEmpty(cmb.ButtonText2)) { Button2.Visible = true; Button2.Text = cmb.ButtonText2.Trim(); } else { Button2.Visible = false; }
            if (!string.IsNullOrEmpty(cmb.ButtonText3)) { Button3.Visible = true; Button3.Text = cmb.ButtonText3.Trim(); } else { Button3.Visible = false; }
            if (!string.IsNullOrEmpty(cmb.ButtonText4)) { Button4.Visible = true; Button4.Text = cmb.ButtonText4.Trim(); } else { Button4.Visible = false; }
            if (!string.IsNullOrEmpty(cmb.ButtonText5)) { Button5.Visible = true; Button5.Text = cmb.ButtonText5.Trim(); } else { Button5.Visible = false; }
            if (!string.IsNullOrEmpty(cmb.ButtonText6)) { Button6.Visible = true; Button6.Text = cmb.ButtonText6.Trim(); } else { Button6.Visible = false; }


            if (cmb.Icon == 1) { picbxIcon.Image = Properties.Resources.info; }
            if (cmb.Icon == 2) { picbxIcon.Image = Properties.Resources.Warning; }
            if (cmb.Icon == 3) { picbxIcon.Image = Properties.Resources.Error; }
            if (cmb.Icon == 4) { picbxIcon.Image = Properties.Resources.Misc; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Result =  1;
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

        private void button6_Click(object sender, EventArgs e)
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
