using AIPrompts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;


namespace AIPrompts.Forms
{
    public partial class ImageMaintMain : Form
    {
        #region Class Variables


        #endregion

        public ImageMaintMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Startup functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageMaintMain_Load(object sender, EventArgs e)
        {
           
        }

        #region Menustrip

        /// <summary>
        /// Close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpFileCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Menustrip: Edit/Prompt/Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditPromptAddPrompt_Click(object sender, EventArgs e)
        {
            string _message = "Add Prompt";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Prompt/Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditPromptEditPrompt_Click(object sender, EventArgs e)
        {
            string _message = "Edit Prompt";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Prompt/Delete   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditPromptDeletePrompt_Click(object sender, EventArgs e)
        {
            string _message = "Delete Prompt";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableCategory_Click(object sender, EventArgs e)
        {
            string _message = "Edit Category";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableStyle_Click(object sender, EventArgs e)
        {
            string _message = "Edit Style";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Mewnustrip: Edit/Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableModel_Click(object sender, EventArgs e)
        {
            string _message = "Edit Model";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Lora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableLora_Click(object sender, EventArgs e)
        {
            string _message = "Edit Lora";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Image Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableImageSettings_Click(object sender, EventArgs e)
        {
            string _message = "Edit Image Settings";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Site
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableSite_Click(object sender, EventArgs e)
        {
            string _message = "Edit Site";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Edit/Site Features
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpEditTableSiteFeatures_Click(object sender, EventArgs e)
        {
            string _message = "Edit Site Features";
            NotWorkingMessage(_message);
        }

        #endregion

        #region Form Controls

        /// <summary>
        /// Button: Add Prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPrompt_Click(object sender, EventArgs e)
        {
            string _message = "Add Prompt";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditPrompt_Click(object sender, EventArgs e)
        {
            string _message = "Edit Prompt";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Delete Prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletePrompt_Click(object sender, EventArgs e)
        {
            string _message = "Delete Prompt";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Button: Edit Category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string _message = "Edit Category";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditStyle_Click(object sender, EventArgs e)
        {
            string _message = "Edit Style";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditModel_Click(object sender, EventArgs e)
        {
            string _message = "Edit Model";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Lora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditLora_Click(object sender, EventArgs e)
        {
            string _message = "Edit Lora";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Image Setting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditImageSetting_Click(object sender, EventArgs e)
        {
            string _message = "Edit Image Setting";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Site
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSite_Click(object sender, EventArgs e)
        {
            string _message = "Edit Site";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Button: Edit Site Feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSiteFeature_Click(object sender, EventArgs e)
        {
            string _message = "Edit Site Feature";
            NotWorkingMessage(_message);
        }

        #endregion

        #region Code Snippits

        /// <summary>
        /// Close the window
        /// </summary>
        public void CloseWindow()
        {
            this.Close();
        }

        /// <summary>
        /// Show message for non working functions
        /// </summary>
        /// <param name="_message"></param>
        public void NotWorkingMessage(string _message)
        {
            MessageBox.Show(_message + " is not currently set up.");
        }

        #endregion

 
    }
}
