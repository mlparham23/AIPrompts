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
using System.Collections.Generic;
using db = AIPrompts.DBInOut;
using AIPrompts.Models;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
// using System.Security.Cryptography.Pkcs;

namespace AIPrompts.Forms
{
    public partial class AddChat : Form
    {
        #region Class variables
        DBInOut                  db             = new DBInOut();
        SQLAccess                sql            = new SQLAccess();
        List<ChatCategoryClass> _chatCategory   = new List<ChatCategoryClass>();
        List<ChatGPTClass>      _chatGPT        = new List<ChatGPTClass>();
        CustMsgBox              CustMsgBox      = new CustMsgBox();

        #endregion

        #region Start Form

        /// <summary>
        /// Form: Initialize form
        /// </summary>
        public AddChat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChat_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadGPTCombobox();
        }

        #endregion  // Start Form


        #region Menustrip

        /// <summary>
        /// Menustrip: File/Close Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpFileCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Menustrip: Chat/Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpChatAdd_Click(object sender, EventArgs e)
        {
            string _message = "Chat/Add";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: Chat/Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpChatReset_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        #endregion

        #region Form events

        /// <summary>
        /// Button: File/Add Prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPrompt();
        }

        /// <summary>
        /// Button: File/Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        /// <summary>
        /// Button: Close Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow(); //Close the window
        }

       

        /// <summary>
        /// Combo Box: GPT Index Changed    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _message = "Combobox/GPT";
            NotWorkingMessage(_message);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add the prompt to the Database
        /// </summary>
        public void AddPrompt()
        {
            // Variables
            string  _promptTitle = txtPromptTitle.Text.Trim();
            string  _prompt      = txtPrompt.Text.Trim();
            string  _temp        = "";
            string  _result      = "";
            int     _NSFW        = 0;
            int     _rank        = 0;
            int     _category1   = 0;
            int     _category2   = 0;
            int     _category3   = 0;
            int     _gpt         = 0;

            //   Setup Messagebox
            CustMsgBox              = new CustMsgBox();
            CustMsgBox.Title        = "Add GPT Prompt";
            CustMsgBox.Message      = "Add GPT Prompt is not currently set up.";
            CustMsgBox.ButtonText1  = "OK";
            CustMsgBox.Icon = (int)_icon.Error;

            // Do Checks in seperate method
            // Get Category 1
            _temp = cboCat1.Text.Trim();
            if (string.IsNullOrEmpty(_temp))
            {
                _category1 = 1;             // None
            }
            else if (_temp == "None")
            {
                _category1 = 1;             //  None
            }
            else
            {
                _category1 = catGet(1);     //  Get category ID
            }

            // Get Category 2
            _temp = cboCat2.Text.Trim();
            if (string.IsNullOrEmpty(_temp))
            {
                _category2 = 1;             // None
            }
            else if (_temp == "None")
            {
                _category2 = 1;             //  None
            }
            else
            {
                _category2 = catGet(2);     //  Get category ID
            }

            // Get Category 3
            _temp = cboCat3.Text.Trim();
            if (string.IsNullOrEmpty(_temp))
            {
                _category3 = 1;             // None
            }
            else if (_temp == "None")
            {
                _category3 = 1;             //  None
            }
            else
            {
                _category3 = catGet(3);     //  Get category ID
            }

            // Get GPT
            _gpt = gptGet();

            //  Check the data
            _result = checkInputs();
            if(_result == "Error") return;

            //  Create GPT Class
            ChatGPTPrompt GPTPrompt = new ChatGPTPrompt();

            //  Add to class
            GPTPrompt.PromptTitle   = _promptTitle;
            GPTPrompt.Prompt        = _prompt;
            GPTPrompt.Rank          = _rank;
            GPTPrompt.Category1     = _category1;
            GPTPrompt.Category2     = _category2;
            GPTPrompt.Category3     = _category3;
            GPTPrompt.GPTVersion    = _gpt;
            GPTPrompt.NSFW          = _NSFW;
            
            //  Add to database




        }


        public string checkInputs()
        {
            //  Variables
            string _promptTitle     = txtPromptTitle.Text.Trim();
            string _prompt          = txtPrompt.Text.Trim();
            string _rank            = txtRank.Text.Trim();
            string _temp            = "";
            string _result          = "Good";
            CustMsgBox.Title        = "Add GPT Prompt - Check Inputs";
            CustMsgBox.Message      = "Add GPT Prompt is not currently set up.";
            CustMsgBox.ButtonText1  = "OK";
            CustMsgBox.Icon = (int)_icon.Error;

            //  Check the data
            //      Prompt Title
            if (string.IsNullOrEmpty(_promptTitle))
            {
                CustMsgBox.Message      = "Prompt Title is missing or is blank. Please fill in this textbox and try again. Thank you.";
                CustMsgBox.Title        = "Add GPT Prompt - Check Inputs (Missing Prompt Title)";
                MsgBoxUser custMsgBox   = new MsgBoxUser(CustMsgBox);
                _result                 = "Error";
                return _result;
            }

            //      Prompt
            if (string.IsNullOrEmpty(_prompt))
            {
                CustMsgBox.Message      = "Prompt is missing or is blank. Please fill in this textbox and try again. Thank you.";
                CustMsgBox.Title        = "Add GPT Prompt - Check Inputs (Missing GPT Prompt)";
                MsgBoxUser custMsgBox   = new MsgBoxUser(CustMsgBox);
                _result                 = "Error";
                return _result;
            }

            //      Rank
            if (string.IsNullOrEmpty(_rank))
            {
                CustMsgBox.Message      = "Rank is missing or is blank. Please fill in this textbox and try again. Thank you.";
                CustMsgBox.Title        = "Add GPT Prompt - Check Inputs (Missing Rank)";
                MsgBoxUser custMsgBox   = new MsgBoxUser(CustMsgBox);
                _result                 = "Error";
                return _result;
            }

            //      GPT
            _temp = cboGPT.Text.Trim();
            if (string.IsNullOrEmpty(_temp))
            {
                CustMsgBox.Message      = "GPT is missing or is blank. Please select a GPT and try again. Thank you.";
                CustMsgBox.Title        = "Add GPT Prompt - Check Inputs (Missing GPT)";
                MsgBoxUser custMsgBox   = new MsgBoxUser(CustMsgBox);
                _result                 = "Error";
                return _result;
            }

            return _result;
        }

        /// <summary>
        /// Get Category ID
        /// </summary>
        /// <param name="_catLevel"></param>
        /// <returns></returns>
        public int catGet(int _catLevel)
        {
            int     _result      = 0;
            string  _category    = "";

            switch (_catLevel)
            {
                case 1:
                    _category = cboCat1.Text.Trim();
                    break;
                case 2:
                    _category = cboCat2.Text.Trim();
                    break;
                case 3:
                    _category = cboCat3.Text.Trim();
                    break;
                default:
                    break;
            }

            // Search for category
            foreach (var item in _chatCategory)
            {
                if (_category == item.category)
                {
                    _result = item.categoryID;
                    break;
                }
            }

            return _result;
        
        }

        /// <summary>
        /// Get Gpt ID
        /// </summary>
        /// <returns></returns>
        public int gptGet()
        {
            //  Variables
            int     _result     = 0;
            string  _gptName    = cboGPT.Text.Trim();

            foreach (var item in _chatGPT)
            {
                if (_gptName == item.versionName)
                {
                    _result = item.GPTID;
                    break;
                }
            }

            return _result;
        }

        /// <summary>
        /// Get Categories from SQL
        /// </summary>
        public async void LoadCategories()
        {
            _chatCategory.Clear();
            _chatCategory = db.chatGetAllCategory();
            LoadcatComboboxes(_chatCategory);

        }

        /// <summary>
        /// Initial load of categories
        /// </summary>
        /// <param name="_chatCategory"></param>
        public void LoadcatComboboxes(List<ChatCategoryClass> _chatCategory)
        {
            cboCat1.Items.Clear();
            cboCat2.Items.Clear();
            cboCat3.Items.Clear();

            cboCat1.Items.Add("");
            cboCat2.Items.Add("");
            cboCat3.Items.Add("");

            foreach (var item in _chatCategory)
            {
                cboCat1.Items.Add(item.category.Trim());
                cboCat2.Items.Add(item.category.Trim());
                cboCat3.Items.Add(item.category.Trim());
            }
        }

        /// <summary>
        /// Reset the screen to default settings
        /// </summary>
        public void ResetScreen()
        {
            txtPrompt.Text          = "";
            txtPromptTitle.Text     = "";
            txtRank.Text            = "";
            ckbxNSFW.Checked        = false;
            cboCat1.SelectedIndex   = 0;
            cboCat2.SelectedIndex   = 0;
            cboCat3.SelectedIndex   = 0;
            cboGPT.SelectedIndex    = 0;
        }

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
            CustMsgBox              = new CustMsgBox();
            CustMsgBox.Title        = _message + " Not Working";
            CustMsgBox.Message      = _message + " is not currently set up.";
            CustMsgBox.ButtonText1  = "OK";
            CustMsgBox.Icon = (int)_icon.Misc;

            MsgBoxUser custMsgBox = new MsgBoxUser(CustMsgBox);
            int Result = (int)custMsgBox.ShowDialog();
            int Result2 = (int)custMsgBox.Result; 


        }

        /// <summary>
        /// Load the GPT combobox
        /// </summary>
        public void LoadGPTCombobox()
        { 
            _chatGPT.Clear();
            _chatGPT = db.getChatGPT();

            cboGPT.Items.Clear();
            cboGPT.Items.Add("");

            foreach (var item in _chatGPT)
            { 
                cboGPT.Items.Add(item.versionName.Trim());
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
            Warning     = 2,
            Error       = 3,
            Misc        = 4
        }

        #endregion

        // Sample Messagebox
        //CustMsgBox = new CustMsgBox();
        //CustMsgBox.Title = "";
        //CustMsgBox.Message = "";
        //CustMsgBox.ButtonText1 = "";
        //CustMsgBox.Icon = (int) _icon.Misc;


    }

}
