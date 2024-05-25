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
    public partial class AddImagePrompt : Form, IDisposable
    {
        #region Class Variables

        List<ImageCategory> cat = new List<ImageCategory>();
        List<ImageLora> lora = new List<ImageLora>();
        List<ImageSite> site = new List<ImageSite>();
        List<ImageStyle> style = new List<ImageStyle>();
        List<ImageArtist> artist = new List<ImageArtist>();
        List<ImageModel> model = new List<ImageModel>();
        List<ImageAspectRatio> aspectRatios = new List<ImageAspectRatio>();
        List<ImageSampleMethod> sampleMethods = new List<ImageSampleMethod>();
        CustMsgBox cmb = new CustMsgBox();
        DBInOut db = new DBInOut();

        #endregion

        #region Startup

        /// <summary>
        /// Initialize everything during startup
        /// </summary>
        public AddImagePrompt()
        {
            InitializeComponent();
            InitializeLists();
            SetupCheckOnClick();
        }

        private void InitializeLists()
        {
            LoadLoras();
            LoadModels();
            LoadCategories();
            LoadSites();
            LoadStyles();
            LoadArtist();
            LoadAspectRatio();
            LoadSampleMethod();
        }

        private void SetupCheckOnClick()
        {
            cklstbxCategories.CheckOnClick = true;
            cklstbxLoras.CheckOnClick = true;
            cklstbxSites.CheckOnClick = true;
            cklstbxStyles.CheckOnClick = true;
            cklstbxArtist.CheckOnClick = true;
            cklstbxModels.CheckOnClick = true;
        }

        #endregion

        #region Form
        #region Menu Strip

        private void mnustrpFileExit_Click(object sender, EventArgs e) => Close();
        private void mnustrpFunctionAddPrompt_Click(object sender, EventArgs e) => addPrompt();
        private void mnustrpFunctionClearScreen_Click(object sender, EventArgs e) => ClearFields();
        private void mnustrpFunctionRefreshScreen_Click(object sender, EventArgs e) => RefreshLists();

        #endregion
        #region Form Controls

        private void btnAdd_Click(object sender, EventArgs e) => addPrompt();
        private void btnClear_Click(object sender, EventArgs e) => ClearFields();
        private void btnRefresh_Click(object sender, EventArgs e) => RefreshLists();
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void picbxRefreshSites_Click(object sender, EventArgs e) => LoadSites();
        private void picbxRefreshLoras_Click(object sender, EventArgs e) => LoadLoras();
        private void picbxRefreshModels_Click(object sender, EventArgs e) => LoadModels();
        private void picbxRefreshCategories_Click(object sender, EventArgs e) => LoadCategories();
        private void picbxRefreshStyles_Click(object sender, EventArgs e) => LoadStyles();
        //private void picbxRefreshArtist_Click(object sender, EventArgs e) => LoadArtist();
        private void picbxNotes_Click(object sender, EventArgs e) => Loadnotes();

        private void picbxRefreshArtist_Click_1(object sender, EventArgs e) => LoadArtist();
        

        #endregion
        #endregion

        #region Methods
        #region Code

        private void addPrompt()
        {
            try
            {
                var prompt = GetPromptFromForm();
                var settings = GetSettingsFromForm();
                List<int> categories = GetIDsFromForm(cklstbxCategories, cat, c => c.category, c => c.catID);
                List<int> sites = GetIDsFromForm(cklstbxSites, site, s => s.siteName, s => s.siteID);
                List<int> loras = GetIDsFromForm(cklstbxLoras, lora, l => l.lora, l => l.loraID);
                List<int> models = GetIDsFromForm(cklstbxModels, model, m => m.modelName, m => m.modelID);
                List<int> styles = GetIDsFromForm(cklstbxStyles, style, s => s.styleName, s => s.styleID);
                List<int> artists = GetIDsFromForm(cklstbxArtist, artist, a => a.artistName, a => a.artistID);
                prompt = CleanPrompt(prompt);
                DisplayEditedPrompt(prompt);

                var validationResult = ValidateInputs(prompt, categories, sites, settings);
                if (!string.IsNullOrEmpty(validationResult))
                {
                    ShowErrorMessage(validationResult);
                    return;
                }

                if (!ConfirmAddPrompt()) return;

                var duplicateCheck = db.checkAIImagePromptExists(prompt);
                if (duplicateCheck.Contains("Error"))
                {
                    ShowErrorMessage("Prompt already exist.");
                    return;
                }

                var promptId = db.AddAIImagePrompt(prompt);
                db.addAIImageCategory(promptId, categories);
                db.addAIImageLora(promptId, loras);
                db.addAIImageModel(promptId, models);
                db.addAIImageSite(promptId, prompt, sites);
                db.addAIImageStyle(promptId, styles);
                db.addAIImageArtist(promptId, artists);
                db.AddAISettings(promptId, settings);

                ShowSuccessMessage($"Prompt has been added to database.{Environment.NewLine}{Environment.NewLine}Title: {prompt.promptTitle}");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred while adding the prompt:{Environment.NewLine}{ex.Message}");
            }
        }

        private ImagePrompt CleanPrompt(ImagePrompt prompt)
        {
            //  Fix
            prompt.prompt = CleanStringForDatabase(prompt.prompt, 1000).Trim();
            prompt.negativePrompt = CleanStringForDatabase(prompt.negativePrompt, 1000).Trim();
            prompt.promptTitle = CleanStringForDatabase(prompt.promptTitle, 50).Trim();
            if (!string.IsNullOrEmpty(prompt.notes)) prompt.notes = CleanStringForDatabase(prompt.notes, 1000).Trim();

            return prompt;
        }

        private void DisplayEditedPrompt(ImagePrompt prompt)
        {
            txtPrompt.Text = prompt.prompt.Trim();
            txtNegPrompt.Text = prompt.negativePrompt.Trim();
            txtNotes.Text = prompt.notes.Trim();
            txtTitle.Text = prompt.promptTitle.Trim();
        }

        private ImagePrompt GetPromptFromForm()
        {
            return new ImagePrompt
            {
                prompt = txtPrompt.Text.Trim(),
                negativePrompt = txtNegPrompt.Text.Trim(),
                promptTitle = txtTitle.Text.Trim(),
                notes = txtNotes.Text.Trim(),
                rating = int.TryParse(txtRating.Text.Trim(), out var rating) ? rating : 0
            };
        }

        private ImageSettings GetSettingsFromForm()
        {
            return new ImageSettings
            {
                imageAspectRatio = cboAspectRatio.Text.Trim(),
                seed = int.TryParse(txtSeed.Text.Trim(), out var seed) ? seed : 0,
                CGFScale = int.TryParse(txtCFGScale.Text.Trim(), out var cgfScale) ? cgfScale : 0,
                steps = int.TryParse(txtSteps.Text.Trim(), out var steps) ? steps : 0,
                scheduler = int.TryParse(txtScheduler.Text.Trim(), out var scheduler) ? scheduler : 0,
                samplingMethod = cboSampleMethod.Text.Trim(),
                DPMSolverGuidanceScale = int.TryParse(txtDpmsolverGuideance.Text.Trim(), out var dpmSolverGuidance) ? dpmSolverGuidance : 0,
                DPMSolverInterferenceSteps = int.TryParse(txtDpmsolverInterference.Text.Trim(), out var dpmSolverInterference) ? dpmSolverInterference : 0,
                SASolverGuidanceScale = int.TryParse(txtSaSolverGuideance.Text.Trim(), out var saSolverGuidance) ? saSolverGuidance : 0,
                SASolverInterferenceSteps = int.TryParse(txtSaSolverInterference.Text.Trim(), out var saSolverInterference) ? saSolverInterference : 0,
                tags = txtTags.Text.Trim()
            };
        }

        private string CleanStringForDatabase(string input, int maxLength = 0)
        {
            string cleanedString = input;

            try
            {
                // Check if the input is null or empty
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentException("Input string is null or empty.");
                }

                // Check if the input exceeds the maximum length of the varchar field
                // Change this value to match your varchar field's maximum length
                if (maxLength > 0)
                {
                    if (cleanedString.Length > maxLength)
                    {
                        throw new ArgumentException("Input string exceeds the maximum length allowed for the database field.");
                        cleanedString = cleanedString.Substring(0, Math.Min(cleanedString.Length, maxLength));
                    }
                }

                // Replace single quotes with two single quotes to escape them
                cleanedString = cleanedString.Replace("'", "''");

                return cleanedString;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the cleaning process
                Console.WriteLine("Error cleaning string: " + ex.Message);
                return null; // Or throw an exception, depending on your application's requirements
            }
        }

        private List<int> GetCategoriesFromForm(CheckedListBox checkedListBox, List<ImageCategory> categories)
        {
            // Get the selected category names from the CheckedListBox
            List<string> selectedNames = checkedListBox.CheckedItems.Cast<string>().ToList();

            // Use LINQ to get the category IDs for the selected names
            List<int> selectedIDs = categories
                .Where(c => selectedNames.Contains(c.category))
                .Select(c => c.catID)
                .ToList();

            return selectedIDs;
        }


        private List<int> GetIDsFromForm<T>(CheckedListBox checkedListBox, List<T> items, Func<T, string> getName, Func<T, int> getID)
        {
            // Get the selected item names from the CheckedListBox
            List<string> selectedNames = checkedListBox.CheckedItems.Cast<string>().ToList();

            // Use LINQ to get the IDs for the selected names
            List<int> selectedIDs = items
                .Where(item => selectedNames.Contains(getName(item)))
                .Select(item => getID(item))
                .ToList();

            return selectedIDs;
        }

        private void Loadnotes()
        {
            AIImageNotes notes = new AIImageNotes();
            notes.Show();
        }

        private string ValidateInputs(ImagePrompt prompt, List<int> categories, List<int> sites, ImageSettings settings)
        {
            if (string.IsNullOrEmpty(prompt.promptTitle))
                return "Prompt Title is missing or blank.";

            if (prompt.rating < 0 || prompt.rating > 10)
                return "Rating must be between 0 and 10.";

            if (sites.Count == 0)
                return "No Sites selected. Please select at least one site.";

            if (categories.Count == 0)
                return "No Categories selected. Please select between 1 and 5 categories.";

            if (settings.seed < -1 || settings.seed > 2147483647)
                return "Seed must be between 0 and 2,147,483,647.";

            if (settings.CGFScale < 0 || settings.CGFScale > 20)
                return "CFG Scale must be between 0 and 20.";

            if (settings.steps < 0 || settings.steps > 50)
                return "Steps must be between 0 and 50.";

            return string.Empty;
        }

        private bool ConfirmAddPrompt()
        {
            cmb.ResetToDefault();
            cmb.Title = "Add Prompt";
            cmb.Message = "Are you sure you want to add this prompt?";
            cmb.ButtonText1 = "Yes";
            cmb.ButtonText2 = "No";
            cmb.Icon = (int)MessageBoxIcon.Question;
            return ShowMessageBox(cmb) == 1;
        }

        private void ShowSuccessMessage(string message)
        {
            cmb.ResetToDefault();
            cmb.Title = "Add Prompt";
            cmb.Message = message;
            cmb.ButtonText1 = "OK";
            cmb.Icon = (int)MessageBoxIcon.Information;
            ShowMessageBox(cmb);
        }

        private void ShowErrorMessage(string message)
        {
            cmb.ResetToDefault();
            cmb.Title = "Error";
            cmb.Message = message;
            cmb.ButtonText1 = "OK";
            cmb.Icon = (int)MessageBoxIcon.Error;
            ShowMessageBox(cmb);
        }

        private int ShowMessageBox(CustMsgBox cmb)
        {
            if (string.IsNullOrEmpty(cmb.SystemMessage))
            {
                MsgBoxUser cMsgBox = new MsgBoxUser(cmb);
                cMsgBox.ShowDialog();
                cMsgBox.Dispose();
                return (int)cMsgBox.Result;
            }
            else
            {
                MsgBoxSystem cMsgBox = new MsgBoxSystem(cmb);
                cMsgBox.ShowDialog();
                cMsgBox.Dispose();
                return (int)cMsgBox.Result;
            }
        }

        private void RefreshLists()
        {
            LoadLoras();
            LoadModels();
            LoadCategories();
            LoadSites();
            LoadStyles();
            LoadArtist();
        }

        private void LoadLoras()
        {
            lora.Clear();
            lora.AddRange(db.getAllLoras());
            LoadListBox(cklstbxLoras, lora.Select(l => l.lora));
        }

        private void LoadModels()
        {
            model.Clear();
            model.AddRange(db.getAllModels());
            LoadListBox(cklstbxModels, model.Select(m => m.modelName));
        }

        private void LoadCategories()
        {
            cat.Clear();
            cat.AddRange(db.getAllCategories());
            LoadListBox(cklstbxCategories, cat.Select(c => c.category));
        }

        private void LoadSites()
        {
            site.Clear();
            site.AddRange(db.getAllSites());
            LoadListBox(cklstbxSites, site.Select(s => s.siteName));
        }

        private void LoadStyles()
        {
            style.Clear();
            style.AddRange(db.getAllStyles());
            LoadListBox(cklstbxStyles, style.Select(s => s.styleName));
        }

        private void LoadArtist()
        {
            artist.Clear();
            artist.AddRange(db.getAllArtist());
            LoadListBox(cklstbxArtist, artist.Select(s => s.artistName));
        }

        private void LoadAspectRatio()
        {
            aspectRatios.Clear();
            aspectRatios.AddRange(db.getAllAspectRatios());
            LoadComboBox(cboAspectRatio, aspectRatios.Select(ar => ar.AspectRatio), addEmptyItem: true);
        }

        private void LoadSampleMethod()
        {
            sampleMethods.Clear();
            sampleMethods.AddRange(db.getAllSampleMethods());
            LoadComboBox(cboSampleMethod, sampleMethods.Select(sm => sm.SampleMethod));
        }

        private void LoadListBox(ListBox listBox, IEnumerable<string> items)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(items.Where(i => !string.IsNullOrEmpty(i)).ToArray());
        }

        private void LoadComboBox(ComboBox comboBox, IEnumerable<string> items, bool addEmptyItem = false)
        {
            comboBox.Items.Clear();
            if (addEmptyItem) comboBox.Items.Add(string.Empty);
            comboBox.Items.AddRange(items.Where(i => !string.IsNullOrEmpty(i)).ToArray());
        }

        private void ClearFields()
        {
            cklstbxStyles.ClearSelected();
            cklstbxArtist.ClearSelected();
            cklstbxLoras.ClearSelected();
            cklstbxModels.ClearSelected();
            cklstbxSites.ClearSelected();
            txtNegPrompt.Clear();
            txtTitle.Clear();
            txtPrompt.Clear();
            txtNotes.Clear();
            txtRating.Clear();
            txtSeed.Clear();
            txtSteps.Clear();
            txtScheduler.Clear();
            txtDpmsolverGuideance.Clear();
            txtDpmsolverInterference.Clear();
            cboAspectRatio.SelectedIndex = 0;
            cboSampleMethod.SelectedIndex = 0;
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
