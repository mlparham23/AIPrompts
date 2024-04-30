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

namespace AIPrompts.Forms
{
    public partial class SearchImagePrompt : Form
    {
        #region Class Variables

        List<ImageCategory> cat = new List<ImageCategory>();
        List<ImageLora> lora = new List<ImageLora>();
        List<ImageSite> site = new List<ImageSite>();
        List<ImageStyle> style = new List<ImageStyle>();
        List<ImageModel> model = new List<ImageModel>();
        List<ImageAspectRatio> aspectRatios = new List<ImageAspectRatio>();
        List<ImageSampleMethod> sampleMethods = new List<ImageSampleMethod>();
        CustMsgBox cmb = new CustMsgBox();
        DBInOut db = new DBInOut();

        #endregion

        #region Startup

        /// <summary>
        /// Initialize upon Startup
        /// </summary>
        public SearchImagePrompt()
        {
            InitializeComponent();
            LoadCategories();
            LoadStyles();
            LoadSites();
            LoadLoras();
            LoadModels();

            // Click Once
            cklstbxCategory.CheckOnClick = true;
            cklstbxLora.CheckOnClick = true;
            cklstbxSite.CheckOnClick = true;
            cklstbxLora.CheckOnClick = true;
            cklstbxStyle.CheckOnClick = true;
            cklstbxModel.CheckOnClick = true;
        }

        #endregion

        #region Controls
        #region Form

        /// <summary>
        /// Reset All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxAllReset_Click(object sender, EventArgs e)
        {
            categoryReset();
            LoraReset();
            SiteReset();
            StyleReset();
            ModelReset();
        }

        /// <summary>
        /// Refresh All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxAllRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
            LoadStyles();
            LoadSites();
            LoadLoras();
            LoadModels();
        }

        /// <summary>
        /// Search by Title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxTitleSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Search by Prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxPromptSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Category Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxCategoryReset_Click(object sender, EventArgs e)
        {
            categoryReset();
        }

        /// <summary>
        /// Category Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxCategorySearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Category Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxCategoryRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        /// <summary>
        /// Style Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxStyleReset_Click(object sender, EventArgs e)
        {
            StyleReset();
        }

        /// <summary>
        /// Style Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxStyleSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Style Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxStyleRefresh_Click(object sender, EventArgs e)
        {
            LoadStyles();
        }

        /// <summary>
        /// Site Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxSiteReset_Click(object sender, EventArgs e)
        {
            SiteReset();
        }

        /// <summary>
        /// Site Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxSiteSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Site Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxSiteRefresh_Click(object sender, EventArgs e)
        {
            LoadSites();
        }

        /// <summary>
        /// Model Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxModelReset_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Model Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxModelSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Model Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxModelRefresh_Click(object sender, EventArgs e)
        {
            LoadModels();
        }

        /// <summary>
        /// Lora Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxLoraReset_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lora Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxLoraSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lora Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxLoraRefresh_Click(object sender, EventArgs e)
        {
            LoadLoras();
        }

        /// <summary>
        /// Close Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbxAllClose_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        #endregion
        #region Menu Strip

        /// <summary>
        /// Close Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpFileCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }


        #endregion
        #endregion

        #region Code

        /// <summary>
        /// Load categories
        /// </summary>
        public void LoadCategories()
        {
            //  Load Categories
            cat.Clear();
            cat = db.getAllCategories();
            LoadCategories(cat);
        }

        /// <summary>
        /// Build out Categories Check List Box
        /// </summary>
        /// <param name="_cat"></param>
        public void LoadCategories(List<ImageCategory> _cat)
        {
            cklstbxCategory.Items.Clear();
            foreach (var item in _cat)
            {
                if (string.IsNullOrEmpty(item.category.Trim())) continue;
                cklstbxCategory.Items.Add(item.category.Trim());
            }
        }

        /// <summary>
        /// Load Styles
        /// </summary>
        public void LoadStyles()
        {
            //  Load Styles 
            style.Clear();
            style = db.getAllStyles();
            LoadStyles(style);
        }

        /// <summary>
        /// Build out Styles Check List Box
        /// </summary>
        /// <param name="_style"></param>
        public void LoadStyles(List<ImageStyle> _style)
        {

            cklstbxStyle.Items.Clear();
            foreach (var item in _style)
            {
                if (string.IsNullOrEmpty(item.styleName.Trim())) continue;
                cklstbxStyle.Items.Add(item.styleName.Trim());
            }
        }

        /// <summary>
        /// Load sites
        /// </summary>
        public void LoadSites()
        {
            //  Load Sites
            site.Clear();
            site = db.getAllSites();
            LoadSites(site);
        }

        /// <summary>
        /// Build out Sites Check List Box
        /// </summary>
        /// <param name="_Site"></param>
        public void LoadSites(List<ImageSite> _site)
        {

            cklstbxSite.Items.Clear();
            foreach (var item in _site)
            {
                if (string.IsNullOrEmpty(item.siteName.Trim())) continue;
                cklstbxSite.Items.Add(item.siteName.Trim());
            }
        }

        /// <summary>
        /// Load Loras
        /// </summary>
        public void LoadLoras()
        {
            //  Load Loras
            lora.Clear();
            lora = db.getAllLoras();
            LoadLoras(lora);
        }

        /// <summary>
        /// Build out Lora Check List Box
        /// </summary>
        /// <param name="_lora"></param>
        public void LoadLoras(List<ImageLora> _lora)
        {
            cklstbxLora.Items.Clear();
            foreach (var item in _lora)
            {
                if (string.IsNullOrEmpty(item.lora.Trim())) continue;
                cklstbxLora.Items.Add(item.lora.Trim());
            }
        }

        /// <summary>
        /// Load Models
        /// </summary>
        public void LoadModels()
        {
            //  Load Models
            model.Clear();
            model = db.getAllModels();
            LoadModels(model);
        }

        /// <summary>
        /// Build out Model Check List Box
        /// </summary>
        /// <param name="_Model"></param>
        public void LoadModels(List<ImageModel> _model)
        {
            cklstbxModel.Items.Clear();
            foreach (var item in _model)
            {
                if (string.IsNullOrEmpty(item.modelName.Trim())) continue;
                cklstbxModel.Items.Add(item.modelName.Trim());
            }
        }

        /// <summary>
        /// Close window
        /// </summary>
        public void CloseWindow()
        {
            this.Close();
        }

        /// <summary>
        /// Reset category List Box
        /// </summary>
        public void categoryReset()
        {
            UncheckAllItems(cklstbxCategory);
        }

        /// <summary>
        /// Reset Style list Box
        /// </summary>
        public void StyleReset()
        {
            UncheckAllItems(cklstbxStyle);
        }

        /// <summary>
        /// Reset Site List Box
        /// </summary>
        public void SiteReset()
        {
            UncheckAllItems(cklstbxSite);
        }

        /// <summary>
        /// Reset Model List Box
        /// </summary>
        public void ModelReset()
        {
            UncheckAllItems(cklstbxModel);
        }

        /// <summary>
        /// Reset Lora List Box
        /// </summary>
        public void LoraReset()
        {
            UncheckAllItems(cklstbxLora);
        }


        #endregion

        #region Common Code





        /// <summary>
        /// Unchedck items in selected Check List Box
        /// </summary>
        /// <param name="checkListBox"></param>
        public void UncheckAllItems(CheckedListBox checkListBox)
        {
            for (int i = 0; i < checkListBox.Items.Count; i++)
            {
                checkListBox.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// Display Custom Message Box
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="icon"></param>
        /// <param name="buttonText1"></param>
        /// <param name="buttonText2"></param>
        /// <param name="systemMessage"></param>
        private int ShowMsgBox(CustMsgBox cmb)
        {
            int result = 0;

            CustMsgBox custMsgBox = new CustMsgBox
            {
                Title = cmb.Title.Trim(),
                Message = cmb.Message.Trim(),
                SystemMessage = cmb.SystemMessage.Trim(),
                ButtonText1 = cmb.ButtonText1,
                ButtonText2 = cmb.ButtonText2,
                ButtonText3 = cmb.ButtonText3,
                ButtonText4 = cmb.ButtonText4,
                ButtonText5 = cmb.ButtonText5,
                ButtonText6 = cmb.ButtonText6,
                Icon = (int)cmb.Icon
            };

            if (string.IsNullOrEmpty(custMsgBox.SystemMessage))
            {
                // Standard Message Box
                MsgBoxUser cMsgBox = new MsgBoxUser(custMsgBox);
                cMsgBox.ShowDialog();
                result = (int)cMsgBox.Result;
                return result;
            }
            else
            {
                //  System Error Message Box
                MsgBoxSystem cMsgBox = new MsgBoxSystem(custMsgBox);
                cMsgBox.ShowDialog();
                result = (int)cMsgBox.Result;
                return result;
            }
        }
















        #endregion

        #region enums

        /// <summary>
        /// Enum: Icon  Custom Messagebox Icons
        /// </summary>
        public enum _icon
        {
            Information = 1,
            Question = 2,
            Warning = 3,
            Error = 4,
            Misc = 5
        }

        #endregion
    }
}
