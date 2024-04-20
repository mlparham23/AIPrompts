using AIPrompts.Models;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPrompts.Forms
{
    public partial class GPTMaint : Form
    {
        #region Class Variables
        List<ChatCategoryClass> chatCategory    = new List<ChatCategoryClass>();
        List<ChatGPTClass>      chatGPT         = new List<ChatGPTClass>();
        DBInOut                 db              = new DBInOut();
        int                     btnResult       = 0;

        #endregion

        #region Startup

        public GPTMaint()
        {
            InitializeComponent();
            LoadCategories();
            LoadGPTs();
        }

        #endregion

        #region Form Controls
        #region Menu Strip

        private void mnustrpFileExit_Click(object sender, EventArgs e)
        {

        }

        #region -Categories

        /// <summary>
        /// Add Categories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpCategoriesAdd_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        /// <summary>
        /// Rename Categories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpCategoriesRename_Click(object sender, EventArgs e)
        {
            renameCategory();
        }

        /// <summary>
        /// Delete Categories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpCategoriesDelete_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }

        /// <summary>
        /// Refresh Categories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpCategoriesRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        #endregion
        #region -GPT

        private void mnustrpGptsAdd_Click(object sender, EventArgs e)
        {

        }

        private void mnustrpGptsRename_Click(object sender, EventArgs e)
        {

        }

        private void mnustrpGptsDelete_Click(object sender, EventArgs e)
        {

        }

        private void mnustrpGptsRefresh_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
        #region Form

        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        #region -Categories

        /// <summary>
        /// Item selection from listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the Categories ListBox
            string selectedCategory = lstbxCategories.SelectedItem?.ToString();

            // Set the text of the txtCat TextBox to the selected category
            txtCategories.Text = selectedCategory;
        }

        /// <summary>
        /// Add a new category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoriesAdd_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        /// <summary>
        /// Rename a category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoriesRename_Click(object sender, EventArgs e)
        {
            renameCategory();
        }

        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoriesDelete_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }

        /// <summary>
        /// Refresh category list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategoriesRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        #endregion
        #region -GPT

        private void lstbxGpts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the Categories ListBox
            string selectedGPT = lstbxGpts.SelectedItem?.ToString();

            // Set the text of the txtCat TextBox to the selected category
            txtGpts.Text = selectedGPT;
        }

        private void btnGptsAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnGptsRename_Click(object sender, EventArgs e)
        {

        }

        private void btnGptsDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnGptsRefresh_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #endregion
        #endregion

        #region Methods
        #region Categories

        /// <summary>
        /// Rename a category
        /// </summary>
        public void renameCategory()
        { 
            // Variables
            string  oldCat = txtCategories.Text.Trim();
            string  newCat = txtCatDest.Text.Trim();
            bool    result = false;

            //  Check data
            result = renCatCheck(oldCat, newCat);
            if (result == false) return;

            //  Prompt user if they wish to continue
            btnResult = ShowMsgBox("Continue with Renaming Category","Are you sure you want to rename this category?\r\n\r\nFrom: " + oldCat + "\r\n" +
                                    "To: " + newCat + "\r\n\r\nNOTE - Renaming a category will rename all related chat prompts.", 
                                    (int)_icon.Misc, "Yes", "No", "", "", "", "","");
            if (btnResult == 1) return;

            //  Find ID and create class
            ChatCategoryClass cat = new ChatCategoryClass();
            cat = findCatID(oldCat);

            //  Rename category
            db.renGPTPrompt(cat, newCat);
            if (result == false) return;

            //  Refresh Category list   
            LoadCategories();
            txtCategories.Text = "";
            txtCatDest.Text = "";
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        public void deleteCategory()
        { 
            //  Variables
            string  delCat = txtCategories.Text.Trim();
            bool    result = false;

            //  Check data
            result = delCatCheck(delCat);
            if (result == false) return;

            //  Prompt user if they wish to continue
            btnResult = ShowMsgBox("Continue with Category Deletion", "Are you sure you want to delete this category?\r\n\r\nCategory: " + delCat, (int)_icon.Misc, "Yes", "No", "", "", "", "");
            if (btnResult == 1) return;

            //  Find ID and create class
            ChatCategoryClass cat = new ChatCategoryClass();
            cat = findCatID(delCat);
                
                
            //  Delete category 
            db.delGPTCategory(cat);
            if (result == false) return;

            //  Refresh Category list
            LoadCategories();
            txtCategories.Text  = "";
            txtCatDest.Text     = "";
        }

        /// <summary>
        /// Add New Category
        /// </summary>
        public void addCategory()
        {
            //  Variables
            string  addCat = txtCategories.Text.Trim();
            bool    result = false;

            //  Check data
            result = addCatCheck(addCat);
            if (result == false) return;

            //  Prompt user if they wish to continue
            btnResult = ShowMsgBox("Continue with Add Category", "Are you sure you want to add this category?\r\n\r\nCategory: " + addCat, (int)_icon.Misc, "Yes", "No","","","","");
            if (btnResult == 1) return;

            //  Add category
            db.addGPTCategory(addCat);
            if (result == false) return;

            //  Refresh Category list
            LoadCategories();
            txtCategories.Text  = "";
            txtCatDest.Text     = "";   
        }

        /// <summary>
        /// Rename Category Data Input Check
        /// </summary>
        /// <param name="oldCat"></param>
        /// <param name="newCat"></param>
        /// <returns></returns>
        public bool renCatCheck(string oldCat, string newCat)
        {
            string  title           = "";
            string  message         = "";
            string  buttonText1     = "";
            string  buttonText2     = "";
            string  buttonText3     = "";
            string  buttonText4     = "";
            string  buttonText5     = "";
            string  buttonText6     = "";
            string  systemMessage   = "";
            bool    found           = false;

            // Check if old cat is selected
            if (string.IsNullOrEmpty(oldCat))
            {
                title           = "Missing Source Category Name (Rename Category)";
                message         = "Source Category name is missing or is blank. Please fill in this textbox and try again. Thank you.";
                buttonText1     = "OK";
                systemMessage   = "";
                ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                return false;
            }

            // Check if new cat is entered
            if (string.IsNullOrEmpty(newCat))
            {
                title           = "Missing Destination Category Name (Rename Category)";
                message         = "Destination Category name is missing or is blank. Please fill in this textbox and try again. Thank you.";
                buttonText1     = "OK";
                systemMessage   = "";
                ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                return false;
            }

            //  Check if category exist
            foreach (var item in chatCategory)
            {
                if (string.IsNullOrEmpty(item.category.Trim())) continue;
                if (item.category.ToUpper() == oldCat.ToUpper())
                {
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                title           = "Category Name Does Not Exist (Rename Category)";
                message         = "Category name does not exist. Please choose an existing category and try again. Thank you.";
                buttonText1     = "OK";
                systemMessage   = "";
                ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check data inputs for Category deletion
        /// </summary>
        /// <param name="delCat"></param>
        /// <returns></returns>
        public bool delCatCheck(string delCat)
        {
            string  title           = "";
            string  message         = "";
            string  buttonText1     = "";
            string  buttonText2     = "";
            string  buttonText3     = "";
            string  buttonText4     = "";
            string  buttonText5     = "";
            string  buttonText6     = "";
            string  systemMessage   = "";
            bool    found           = false;

            //  Check if empty or null
            if (string.IsNullOrEmpty(delCat))
            {
                title           = "Missing Category Name (Delete Category)";
                message         = "Category name is missing or is blank. Please fill in this textbox and try again. Thank you.";
                buttonText1     = "OK";
                systemMessage   = "";
                ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                return false;
            }

            //  Check if category exist
            foreach (var item in chatCategory)
            {
                if (string.IsNullOrEmpty(item.category.Trim())) continue;
                if (item.category.ToUpper() == delCat.ToUpper())
                {
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                title           = "Category Name Does Not Exist (Delete Category)";
                message         = "Category name does not exist. Please choose an existing category and try again. Thank you.";
                buttonText1     = "OK";
                systemMessage   = "";
                ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check inputs for adding a new catgory
        /// </summary>
        /// <returns></returns>
        public bool addCatCheck(string addCat)
        {
            string title = "";
            string message = "";
            string buttonText1 = "";
            string buttonText2 = "";
            string buttonText3 = "";
            string buttonText4 = "";
            string buttonText5 = "";
            string buttonText6 = "";
            string systemMessage = "";

            //  Check if empty or null
            if(string.IsNullOrEmpty(addCat)) 
            {
                title           = "Missing Category Name";
                message         = "Category name is missing or is blank. Please fill in this textbox and try again. Thank you.";
                buttonText1     = "OK";
                systemMessage   = "";
                ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                return false;
            }

            //  Check if already exist
            foreach (var item in chatCategory)
            {
                if (string.IsNullOrEmpty(item.category.Trim())) continue;
                if (item.category.ToUpper() == addCat.ToUpper())
                { 
                    title           = "Category Already Exists";
                    message         = "Category already exists. Please choose a different name. Thank you.";
                    buttonText1     = "OK";
                    systemMessage   = "";
                    ShowMsgBox(title, message, (int)_icon.Error, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, systemMessage);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// find the category ID that goes with the category name
        /// </summary>
        /// <param name="delCat"></param>
        /// <returns></returns>
        public ChatCategoryClass findCatID(string delCat)
        {
            ChatCategoryClass newCat = new ChatCategoryClass();

            foreach (var item in chatCategory)
            { 
                if (string.IsNullOrEmpty(item.category.Trim())) continue;
                if (delCat != item.category) continue;
                
                newCat.category = item.category;
                newCat.categoryID = item.categoryID;
                break;
            }
            return newCat;
        }

        /// <summary>
        /// Get Categories from SQL
        /// </summary>
        public async void LoadCategories()
        {
            chatCategory.Clear();
            chatCategory = db.chatGetAllCategory();
            LoadCatListboxes(chatCategory);
        }

        /// <summary>
        /// Initial load of categories
        /// </summary>
        /// <param name="_chatCategory"></param>
        public void LoadCatListboxes(List<ChatCategoryClass> _chatCategory)
        {
            lstbxCategories.Items.Clear();

            foreach (var item in _chatCategory)
            {
                if(string.IsNullOrEmpty(item.category.Trim())) continue;
                lstbxCategories.Items.Add(item.category.Trim());
            }
        }

        /// <summary>
        /// Load the GPT combobox
        /// </summary>
        public void LoadGPTs()
        {
            chatGPT.Clear();
            chatGPT = db.getChatGPT();

            lstbxGpts.Items.Clear();
            lstbxGpts.Items.Add("");

            foreach (var item in chatGPT)
            {
                if (string.IsNullOrEmpty(item.versionName.Trim())) continue;
                lstbxGpts.Items.Add(item.versionName.Trim());
            }
        }
        #endregion
        
        #region GPTs

        #endregion

        #region Common Code

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









        #endregion

        #region eNums

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
