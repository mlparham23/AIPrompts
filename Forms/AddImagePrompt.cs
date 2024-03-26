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
using db = AIPrompts.DBInOut;

namespace AIPrompts.Forms
{
    public partial class AddImagePrompt : Form
    {
        #region Class Variables
        List<ImageCategory> cat    = new List<ImageCategory>();
        List<ImageLora>     lora   = new List<ImageLora>();
        List<ImageSite>     site   = new List<ImageSite>();
        List<ImageModel>    model  = new List<ImageModel>();
        List<ImageAspectRatio> aspectRatios = new List<ImageAspectRatio>();
        List<ImageSampleMethod>     sampleMethods = new List<ImageSampleMethod>();
        //List<ImageSampleMethod> sampleMethod = new List<ImageSampleMethod>();

        DBInOut db = new DBInOut();
        #endregion

        #region Startup

        public AddImagePrompt()
        {
            InitializeComponent();
            loadLoras();
            LoadModels();
            LoadCategories();
            LoadSites();
            LoadAspectRatio();   // Aspectratio
            //LoadImageMode();
            LoadSampleMethod();
        }



        private void AddImagePrompt_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Form
        #region Menu Strip

        /// <summary>
        /// Menustrip: File/Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnustrpFunctionAddPrompt_Click(object sender, EventArgs e)
        {

        }

        private void mnustrpFunctionClearScreen_Click(object sender, EventArgs e)
        {

        }

        private void mnustrpFunctionRefreshScreen_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region Form Controls

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // addPrompt();
        }

        /// <summary>
        /// Clear/Reset Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        /// <summary>
        /// Refresh the checklist boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadLoras();
            LoadModels();
            LoadCategories();
            LoadSites();

        }

        /// <summary>
        /// Button: File/Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #endregion

        #region Methods
        #region Code

        /// <summary>
        /// Add prompt
        /// </summary>
        public void addprompt()
        {
            // Variables
            List<string> loras      = new List<string>();
            List<string> models     = new List<string>();
            List<string> categories = new List<string>();
            List<string> sites      = new List<string>();
            string       prompt     = txtPrompt.Text.Trim();
            string       negPrompt  = txtNegPrompt.Text.Trim();
            string       notes      = txtNotes.Text.Trim();
            int          rating     = int.Parse(txtRating.Text.Trim());

            //  Collect Data


            //  Check Inputs


            // Prompt User if they wish to cntinue


            //  Add to database


            //  Refresh List


            // Reset form

        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <param name="clb"></param>
        /// <returns></returns>
        public List<string> getSelectedItems(CheckedListBox clb)
        {
            //  Variables
            List<string> items = new List<string>();
            foreach (var item in clb.CheckedItems)
            {
                items.Add(item.ToString());
            }
            return items;
        }

        /// <summary>
        /// Load Loras
        /// </summary>
        public void loadLoras()
        {
            //  Load Loras
            lora.Clear();
            lora = db.getAllLoras();
            LoadLoras(lora);
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
        /// Load sites
        /// </summary>
        public void LoadSites()
        {
            //  Load Sites
            site.Clear();
            site = db.getAllSites();
            LoadSites(site);
        }

        public void LoadAspectRatio()
        { 
            //  Load Aspect Ratio
            aspectRatios.Clear();
            aspectRatios = db.getAllAspectRatios();
            LoadAspectRatios(aspectRatios);
        
        }

        public void LoadSampleMethod()
        {
            //  Load Sample Method
            sampleMethods.Clear();
            sampleMethods = db.getAllSampleMethods();
            LoadSampleMethods(sampleMethods);
        }

        /// <summary>
        /// Build out Sites Check List Box
        /// </summary>
        /// <param name="_Site"></param>
        public void LoadSites(List<ImageSite> _site)
        {
            cklstbxSites.Items.Clear();
            foreach (var item in _site)
            {
                if (string.IsNullOrEmpty(item.siteName.Trim())) continue;
                cklstbxSites.Items.Add(item.siteName.Trim());
            }
        }

        /// <summary>
        /// Build out Categories Check List Box
        /// </summary>
        /// <param name="_cat"></param>
        public void LoadCategories(List<ImageCategory> _cat)
        {
            cklstbxCategories.Items.Clear();
            foreach (var item in _cat)
            {
                if (string.IsNullOrEmpty(item.category.Trim())) continue;
                cklstbxCategories.Items.Add(item.category.Trim());
            }
        }

        /// <summary>
        /// Build out Model Check List Box
        /// </summary>
        /// <param name="_Model"></param>
        public void LoadModels(List<ImageModel> _model)
        {
            cklstbxModels.Items.Clear();
            foreach (var item in _model)
            {
                if (string.IsNullOrEmpty(item.modelName.Trim())) continue;
                cklstbxModels.Items.Add(item.modelName.Trim());
            }
        }

        /// <summary>
        /// Build out Lora Check List Box
        /// </summary>
        /// <param name="_lora"></param>
        public void LoadLoras(List<ImageLora> _lora)
        {
            cklstbxLoras.Items.Clear();
            foreach (var item in _lora)
            {
                if (string.IsNullOrEmpty(item.lora.Trim())) continue;
                cklstbxLoras.Items.Add(item.lora.Trim());
            }
        }

        /// <summary>
        /// Build out Aspect Ratio ComboBox
        /// </summary>
        /// <param name="_ar"></param>
        public void LoadAspectRatios(List<ImageAspectRatio> _ar)
        {
            cboAspectRatio.Items.Clear();
            foreach (var item in _ar)
            {
                if (string.IsNullOrEmpty(item.AspectRatio.Trim())) continue;
                cboAspectRatio.Items.Add(item.AspectRatio.Trim());
            }
        }

        /// <summary>
        /// Build out Sample Method Ratio ComboBox
        /// </summary>
        /// <param name="_ar"></param>
        public void LoadSampleMethods(List<ImageSampleMethod> _sm)
        {
            cboSampleMethod.Items.Clear();
            foreach (var item in _sm)
            {
                if (string.IsNullOrEmpty(item.SampleMethod.Trim())) continue;
                cboSampleMethod.Items.Add(item.SampleMethod.Trim());
            }
        }

        /// <summary>
        /// Clear/Reset form
        /// </summary>
        public void clearfields()
        {
            cklstbxCategories.ClearSelected();
            cklstbxLoras.ClearSelected();
            cklstbxModels.ClearSelected();
            cklstbxSites.ClearSelected();
            txtNegPrompt.Text               = "";
            txtPrompt.Text                  = "";
            txtNotes.Text                   = "";
            txtRating.Text                  = "";
            txtSeed.Text                    = "";
            txtSteps.Text                   = "";
            txtScheduler.Text               = "";
            txtDpmsolverGuideance.Text      = "";
            txtDpmsolverInterference.Text   = "";
            cboAspectRatio.SelectedIndex = 0;
            cboSampleMethod.SelectedIndex = 0;
        

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
        private int ShowMsgBox(string title, string message, int icon, string buttonText1, string buttonText2 = "",
                string buttontonText3 = "", string buttonText4 = "", string buttonText5 = "", string buttonText6 = "",
                string systemMessage = "")
        {
            int result = 0;

            CustMsgBox custMsgBox = new CustMsgBox
            {
                Title = title,
                Message = message,
                SystemMessage = systemMessage.Trim(),
                ButtonText1 = buttonText1,
                ButtonText2 = buttonText2,
                Icon = (int)icon
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

        #region Common Code


        #endregion
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
