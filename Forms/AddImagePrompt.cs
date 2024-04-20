using AIPrompts.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using db = AIPrompts.DBInOut;

namespace AIPrompts.Forms
{
    public partial class AddImagePrompt : Form
    {
        #region Class Variables
        List<ImageCategory> cat = new List<ImageCategory>();
        List<ImageLora> lora = new List<ImageLora>();
        List<ImageSite> site = new List<ImageSite>();
        List<ImageStyle> style = new List<ImageStyle>();
        List<ImageModel> model = new List<ImageModel>();
        List<ImageAspectRatio> aspectRatios = new List<ImageAspectRatio>();
        List<ImageSampleMethod> sampleMethods = new List<ImageSampleMethod>();
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
            LoadStyles();
            LoadAspectRatio();   // Aspectratio
            //LoadImageMode();
            LoadSampleMethod();

            // Click Once
            cklstbxCategories.CheckOnClick  = true;
            cklstbxLoras.CheckOnClick       = true;
            cklstbxSites.CheckOnClick       = true;
            cklstbxStyles.CheckOnClick      = true;
            cklstbxModels.CheckOnClick      = true;
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
            addPrompt();
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
            LoadStyles();
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
        public void addPrompt()
        {
            // Variables
            List<string>        loras       = new List<string>();
            List<string>        models      = new List<string>();
            List<string>        categories  = new List<string>();
            List<string>        sites       = new List<string>();
            List<string>        st          = new List<string>();
            ImagePrompt         prompt      = new ImagePrompt();
            List<ImageModel>    m           = new List<ImageModel>();
            List<ImageLora>     l           = new List<ImageLora>();
            List<ImageCategory> c           = new List<ImageCategory>();
            List<ImageSite>     s           = new List<ImageSite>();
            List<ImageStyle>    styles      = new List<ImageStyle>();
            ImageSettings       settings    = new ImageSettings();
            int                 PromptID    = 0;
            string              temp        = "";
            string              result      = "";
            int                 result2     = 0;
            CustMsgBox          cmb         = new CustMsgBox();

            //  Collect Data
            //      Prompt
            prompt.prompt           = txtPrompt.Text.Trim();
            prompt.negativePrompt   = txtNegPrompt.Text.Trim();
            prompt.promptTitle      = txtTitle.Text.Trim();  
            prompt.notes            = txtNotes.Text.Trim();
            temp                    = txtRating.Text.Trim();
            if (!string.IsNullOrEmpty(temp)) prompt.rating = Int32.Parse(temp);

            //      Sites
            sites = getSelectedItems(cklstbxSites);

            foreach (var item in sites)
            {
                ImageSite t = new ImageSite();
                t.siteName  = item;
                s.Add(t);
            }

            //      Loras
            loras = getSelectedItems(cklstbxLoras);

            foreach (var item in loras)
            {
                ImageLora t = new ImageLora();
                t.lora = item;
                l.Add(t);
            }

            //      Models
            models = getSelectedItems(cklstbxModels);

            foreach (var item in models)
            {
                ImageModel t = new ImageModel();
                t.modelName = item;
                m.Add(t);
            }

            //      Categories
            categories = getSelectedItems(cklstbxCategories);

            foreach (var item in categories)
            {
                ImageCategory t = new ImageCategory();
                t.category = item;
                c.Add(t);
            }

            //      Styles
            st = getSelectedItems(cklstbxStyles);

            foreach (var item in st)
            {
                ImageStyle t = new ImageStyle();
                t.styleName = item;
                styles.Add(t);
            }

            //  Get IDs for Object Items
            //      Sites
            foreach (var item in s)
            {
                item.siteID = site.Where(x => x.siteName == item.siteName).Select(x => x.siteID).FirstOrDefault();
            }

            //      Loras
            foreach (var item in l)
            {
                item.loraID = lora.Where(x => x.lora == item.lora).Select(x => x.loraID).FirstOrDefault();
            }

            //      Categories
            foreach (var item in c)
            {
                item.catID = cat.Where(x => x.category == item.category).Select(x => x.catID).FirstOrDefault();
            }

            //      Models
            foreach (var item in m)
            {
                item.modelID = model.Where(x => x.modelName == item.modelName).Select(x => x.modelID).FirstOrDefault();
            }

            //      Styles
            foreach (var item in styles)
            {
                item.styleID    = style.Where(x => x.styleName == item.styleName).Select(x => x.styleID).FirstOrDefault();
                item.notes      = prompt.notes;
            }

            //      Settings
            temp = cboAspectRatio.Text.Trim();
            if (!string.IsNullOrEmpty(temp)) settings.imageAspectRatio = temp;
            if (!string.IsNullOrEmpty(txtSeed.Text.Trim())) settings.seed = Int32.Parse(txtSeed.Text.Trim());
            if (!string.IsNullOrEmpty(txtCFGScale.Text.Trim())) settings.CGFScale = Int32.Parse(txtCFGScale.Text.Trim());
            if (!string.IsNullOrEmpty(txtSteps.Text.Trim())) settings.steps = Int32.Parse(txtSteps.Text.Trim());
            if (!string.IsNullOrEmpty(txtScheduler.Text.Trim())) settings.scheduler = Int32.Parse(txtScheduler.Text.Trim());
            temp = cboSampleMethod.Text.Trim();
            if (!string.IsNullOrEmpty(temp)) settings.samplingMethod = temp;
            if (!string.IsNullOrEmpty(txtDpmsolverGuideance.Text.Trim())) settings.DPMSolverGuidanceScale = Int32.Parse(txtDpmsolverGuideance.Text.Trim());
            if (!string.IsNullOrEmpty(txtDpmsolverInterference.Text.Trim())) settings.DPMSolverInterferenceSteps = Int32.Parse(txtDpmsolverInterference.Text.Trim());
            if (!string.IsNullOrEmpty(txtSaSolverGuideance.Text.Trim())) settings.SASolverGuidanceScale = Int32.Parse(txtSaSolverGuideance.Text.Trim());
            if (!string.IsNullOrEmpty(txtSaSolverInterference.Text.Trim())) settings.SASolverInterferenceSteps = Int32.Parse(txtSaSolverInterference.Text.Trim());
            if (!string.IsNullOrEmpty(txtTags.Text.Trim())) settings.tags = txtTags.Text.Trim();

            //  Check Inputs
            result = checkAddInputs(prompt, c, s, settings);
            if (result.Contains("Error")) return;

            // Prompt User if they wish to cntinue
            cmb.Title = "Add Prompt";
            cmb.Message = "Are you sure you want to add this prompt?";
            cmb.ButtonText1 = "Yes";
            cmb.ButtonText2 = "No";
            cmb.ButtonText3 = "";
            cmb.ButtonText4 = "";
            cmb.ButtonText5 = "";
            cmb.ButtonText6 = "";
            cmb.SystemMessage = "";
            cmb.Icon = (int)_icon.Question;
            result2 = ShowMsgBox(cmb);
            if (result2 != 1) return;   // No

            //  Add to database
            //      Checdk for duplicate first
            temp = db.checkAIImagePromptExists(prompt);
            if (temp.Contains("Error"))
            {
                //  Error
                cmb.Title = "Duplicate Prompt";
                cmb.Message = "This prompt already exist in the database. Enter a different prompt and try again. Thank you.\r\n\r\nAborting";
                cmb.ButtonText1 = "Ok";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return;
            }

            //      Prompt
            PromptID = db.AddAIImagePrompt(prompt);

            //  Categorys
            db.addAIImageCategory(PromptID, c);

            //  Loras
            if (l.Count > 0) db.addAIImageLora(PromptID, l);

            //  Models
            if (m.Count > 0) db.addAIImageModel(PromptID, m);

            //  Sites
            if (s.Count > 0) db.addAIImageSite(PromptID, prompt, s);

            //  Styles
            if (styles.Count > 0) db.addAIImageStyle(PromptID, styles);

            //  Settings
            db.AddAISettings(PromptID, settings);

            //  Notify User
            cmb.Title = "Add Prompt";
            cmb.Message = "Prompt has been added to database.\r\n\r\nTitle: " + prompt.promptTitle;
            cmb.ButtonText1 = "Ok";
            cmb.ButtonText2 = "";
            cmb.ButtonText3 = "";
            cmb.ButtonText4 = "";
            cmb.ButtonText5 = "";
            cmb.ButtonText6 = "";
            cmb.SystemMessage = "";
            cmb.Icon = (int)_icon.Information;
            result2 = ShowMsgBox(cmb);

            // Reset form
            clearfields();
            clearCheckListBoxes();

            return;
        }

        /// <summary>
        /// Check Inputs
        /// </summary>
        /// <param name="_prompt"></param>
        /// <param name="_category"></param>
        /// <param name="_site"></param>
        /// <param name="_settings"></param>
        /// <returns></returns>
        public string checkAddInputs(ImagePrompt _prompt, List<ImageCategory> _category, List<ImageSite> _site, ImageSettings _settings)
        {
            //  Variables
            string temp = "";
            int result = 0;
            CustMsgBox cmb = new CustMsgBox();


            //  Check Text Boxes
            //      Rating
            //          Exists
            temp = txtRating.Text.Trim();
            if (string.IsNullOrEmpty(temp))
            {
                cmb.Title = "Missing Rating";
                cmb.Message = "Rating is missing or is blank. Please fill in this textbox and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            //          Check if numeric
            bool isNUmber = int.TryParse(txtRating.Text.Trim(), out result);
            if (!isNUmber)
            {
                cmb.Title = "Rating Is Not Numeric";
                cmb.Message = "Rating is not numeric. Enter a number 0-10 for the rating and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }
            else
            {
                //          Check if in range
                if (result < 0 || result > 10)
                {
                    cmb.Title = "Rating Is Out Of Range";
                    cmb.Message = "Rating is not in the range 0-10. Enter a number 0-10 for the rating and try again. Thank you.";
                    cmb.ButtonText1 = "OK";
                    cmb.ButtonText2 = "";
                    cmb.ButtonText3 = "";
                    cmb.ButtonText4 = "";
                    cmb.ButtonText5 = "";
                    cmb.ButtonText6 = "";
                    cmb.SystemMessage = "";
                    cmb.Icon = (int)_icon.Error;
                    ShowMsgBox(cmb);
                    return "Error";
                }
            }

            //      Check Prompt Title
            if (string.IsNullOrEmpty(_prompt.promptTitle))
            {
                cmb.Title = "Missing Prompt Title";
                cmb.Message = "Prompt Title is missing or is blank. Please fill in this textbox and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            //  Chedck CheckListBoxes
            //      Check Sites
            if (site.Count == 0)
            {
                cmb.Title = "No Sites Selected";
                cmb.Message = "No Sites selected. Please select at least one site and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            //      Check Categories
            if (_category.Count == 0)
            {
                cmb.Title = "No Categories Selected";
                cmb.Message = "No Categories selected. Please select between 1 and 5 categories and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            //if (_category.Count > 5)
            //{
            //    cmb.Title = "Too Many Categories Selected";
            //    cmb.Message = "Too many categories selected. Please select between 1 and 5 categories and try again. Thank you.";
            //    cmb.ButtonText1 = "OK";
            //    cmb.ButtonText2 = "";
            //    cmb.ButtonText3 = "";
            //    cmb.ButtonText4 = "";
            //    cmb.ButtonText5 = "";
            //    cmb.ButtonText6 = "";
            //    cmb.SystemMessage = "";
            //    cmb.Icon = (int)_icon.Error;
            //    ShowMsgBox(cmb);
            //    return "Error";
            //}

            //  Check Settimgs
            //      Check Seed
            if (_settings.seed < -1 || _settings.seed > 2147483647)
            {
                cmb.Title = "Seed Is Out Of Range";
                cmb.Message = "Seed is not in the range 0 - 2,147,483,647. Enter a number 0 - 2,147,483,647 for the Seed and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            //      Check CFG Scale
            if (_settings.CGFScale < 0 || _settings.CGFScale > 20)
            {
                cmb.Title = "CFG Scale Is Out Of Range";
                cmb.Message = "CFG Scale is not in the range 0 - 20. Enter a number 0 - 20 for the CFG Scale and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            //      Check Steps 
            if (_settings.steps < 0 || _settings.steps > 50)
            {
                cmb.Title = "Steps Is Out Of Range";
                cmb.Message = "Steps is not in the range 0 - 50. Enter a number 0 - 50 for the Steps and try again. Thank you.";
                cmb.ButtonText1 = "OK";
                cmb.ButtonText2 = "";
                cmb.ButtonText3 = "";
                cmb.ButtonText4 = "";
                cmb.ButtonText5 = "";
                cmb.ButtonText6 = "";
                cmb.SystemMessage = "";
                cmb.Icon = (int)_icon.Error;
                ShowMsgBox(cmb);
                return "Error";
            }

            return "Good";
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <param name="clb"></param>
        /// <returns></returns>
        public List<string> getSelectedItems(CheckedListBox clb)
        {
            //  Variables
            string temp = "";
            List<string> items = new List<string>();

            foreach (var item in clb.CheckedItems)
            {
                temp = item.ToString().Trim();
                if (!string.IsNullOrEmpty(temp)) items.Add(temp); ;
            }
            return items;
        }

        /// <summary>
        /// Clear CheckListBox
        /// </summary>
        public void clearCheckListBoxes()
        {
            for (int i = 0; i < cklstbxLoras.Items.Count; i++)
            {
                cklstbxLoras.SetItemChecked(i, false);
            }

            for (int i = 0; i < cklstbxCategories.Items.Count; i++)
            {
                cklstbxCategories.SetItemChecked(i, false);
            }

            for (int i = 0; i < cklstbxSites.Items.Count; i++)
            {
                cklstbxSites.SetItemChecked(i, false);
            }

            for (int i = 0; i < cklstbxStyles.Items.Count; i++)
            {
                cklstbxStyles.SetItemChecked(i, false);
            }

            for (int i = 0; i < cklstbxModels.Items.Count; i++)
            {
                cklstbxModels.SetItemChecked(i, false);
            }
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

        public void LoadStyles()
        {
            //  Load Styles 
            style.Clear();
            style = db.getAllStyles();
            LoadStyles(style);
        }

        /// <summary>
        /// Load Aspect Ratio
        /// </summary>
        public void LoadAspectRatio()
        {
            //  Load Aspect Ratio
            aspectRatios.Clear();
            aspectRatios = db.getAllAspectRatios();
            LoadAspectRatios(aspectRatios);
        }

        /// <summary>
        /// Load Sample Method
        /// </summary>
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
        /// Build out Styles Check List Box
        /// </summary>
        /// <param name="_style"></param>
        public void LoadStyles(List<ImageStyle> _style)
        {
            cklstbxStyles.Items.Clear();
            foreach (var item in _style)
            {
                if (string.IsNullOrEmpty(item.styleName.Trim())) continue;
                cklstbxStyles.Items.Add(item.styleName.Trim());
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
            cboAspectRatio.Items.Add("");
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
            cklstbxStyles.ClearSelected();
            cklstbxLoras.ClearSelected();
            cklstbxModels.ClearSelected();  
            cklstbxSites.ClearSelected();
            txtNegPrompt.Text               = "";
            txtTitle.Text                   = "";
            txtPrompt.Text                  = "";
            txtNotes.Text                   = "";
            txtRating.Text                  = "";
            txtSeed.Text                    = "";
            txtSteps.Text                   = "";
            txtScheduler.Text               = "";
            txtDpmsolverGuideance.Text      = "";
            txtDpmsolverInterference.Text   = "";
            cboAspectRatio.SelectedIndex    = 0;
            cboSampleMethod.SelectedIndex   = 0;
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
            Question = 2,
            Warning = 3,
            Error = 4,
            Misc = 5
        }

        #endregion



    }
}
