using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System;
//using System.Collections.Generic;
using db = AIPrompts.DBInOut;
using AIPrompts.Models;
//using Microsoft.Identity.Client;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
// using System.Security.Cryptography.Pkcs;

namespace AIPrompts.Forms
{
    public partial class AddChat : Form
    {
        #region Class variables
        DBInOut     db                          = new DBInOut();
        SQLAccess   sql                         = new SQLAccess();
        List<ChatCategoryClass> chatCategory    = new List<ChatCategoryClass>();
        List<ChatGPTClass>      chatGPT         = new List<ChatGPTClass>();
        CustMsgBox CustMsgBox                   = new CustMsgBox();
        string title                            = "";  // message, title, icon, button...
        string message                          = "";
        string errMessage                       = "";
        string rank                             = "";
        string temp                             = "";
        string result                           = "";
        int    cmresult                         = 0;

        #endregion

        #region Start Form

        /// <summary>
        /// Form: Initialize form
        /// </summary>
        public AddChat()
        {
            InitializeComponent();
            LoadCategories();
            LoadGPTCombobox();
        }

        /// <summary>
        /// Form startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChat_Load(object sender, EventArgs e)
        {

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
            //string _message = "Chat/Add";
            //NotWorkingMessage(_message);
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
        /// Refresh Dropdowns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefreshDropdowns_Click(object sender, EventArgs e)
        {
            LoadCategories();
            LoadGPTCombobox();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add the prompt to the Database
        /// </summary>
        public void AddPrompt()
        {
            // Variables
            title           = "";
            message         = "";
            string temp     = "";
            result          = "";
            int NSFW        = 0;
            int rank        = 0;
            int category1   = 0;
            int category2   = 0;
            int category3   = 0;
            int gpt         = 0;

            //   Setup Messagebox
            //CustMsgBox = new CustMsgBox();
            
            
            
            title                   = "Add GPT Prompt";
            message                 = "Add GPT Prompt is not currently set up.";
            CustMsgBox.ButtonText1  = "OK";
            CustMsgBox.Icon         = (int)_icon.Error;

            // Do Checks in seperate method
            // Get Category 1
            temp = cboCat1.Text.Trim();
            if (string.IsNullOrEmpty(temp))
            {
                category1 = 1;             // None
            }
            else if (temp == "None")
            {
                category1 = 1;             //  None
            }
            else
            {
                category1 = catGet(1);     //  Get category ID
            }

            // Get Category 2
            temp = cboCat2.Text.Trim();
            if (string.IsNullOrEmpty(temp))
            {
                category2 = 1;             // None
            }
            else if (temp == "None")
            {
                category2 = 1;             //  None
            }
            else
            {
                category2 = catGet(2);     //  Get category ID
            }

            // Get Category 3
            temp = cboCat3.Text.Trim();
            if (string.IsNullOrEmpty(temp))
            {
                category3 = 1;             // None
            }
            else if (temp == "None")
            {
                category3 = 1;             //  None
            }
            else
            {
                category3 = catGet(3);     //  Get category ID
            }

            // Get GPT
            gpt = gptGet();

            //  Check the data
            result = checkInputs();
            if (result == "Error") return;

            //  Get Rank
            temp = txtRank.Text.Trim();
            rank = int.Parse(temp);

            //  Create GPT Class
            ChatGPTPrompt GPTPrompt = new ChatGPTPrompt();

            //  Add to class
            GPTPrompt.PromptTitle   = txtPromptTitle.Text.Trim();
            GPTPrompt.Prompt        = txtPrompt.Text.Trim();
            GPTPrompt.Rank          = rank;
            GPTPrompt.Category1     = category1;
            GPTPrompt.Category2     = category2;
            GPTPrompt.Category3     = category3;
            GPTPrompt.GPTVersion    = gpt;
            GPTPrompt.NSFW          = NSFW;

            //  Add to database
            db.addGPTPrompt(GPTPrompt);
        }

        /// <summary>
        /// Check User Inputs
        /// </summary>
        /// <returns></returns>
        public string checkInputs()
        {
            //  Variables
            string title    = txtPromptTitle.Text.Trim();    // message, title, icon, button...
            string message  = txtPrompt.Text.Trim();
            string rank     = txtRank.Text.Trim();
            string temp     = "";
            string result   = "Good";
            int cmresult    = 0;

            CustMsgBox.Title        = "Add GPT Prompt - Check Inputs";
            CustMsgBox.Message      = "Add GPT Prompt is not currently set up.";
            CustMsgBox.ButtonText1  = "OK";
            CustMsgBox.Icon = (int)_icon.Error;

            //  Check the data
            //      Prompt Title
            if (string.IsNullOrEmpty(title))
            {
                message  = "Prompt Title is missing or is blank. Please fill in this textbox and try again. Thank you.";
                title    = "Add GPT Prompt - Check Inputs (Missing Prompt Title)";
                cmresult = ShowMsgBox(title, message, (int)_icon.Error, "OK");
                //cmresult = CMsgBox(message, title, (int)_icon.Error, "OK","here");

                result = "Error";
                return result;
            }

            //      Prompt
            if (string.IsNullOrEmpty(message))
            {
                message  = "Prompt is missing or is blank. Please fill in this textbox and try again. Thank you.";
                title    = "Add GPT Prompt - Check Inputs (Missing GPT Prompt)";
                cmresult = ShowMsgBox(title, message, (int)_icon.Error, "OK");
               // cmresult = CMsgBox(message, title, (int)_icon.Error, "OK");

                result = "Error";
                return result;
            }

            //      Rank
            if (string.IsNullOrEmpty(rank))
            {
                message  = "Rank is missing or is blank. Please fill in this textbox and try again. Thank you.";
                title    = "Add GPT Prompt - Check Inputs (Missing Rank)";
                cmresult = ShowMsgBox(title, message, (int)_icon.Error, "OK");
                //cmresult = CMsgBox(message, title, (int)_icon.Error, "OK");

                result = "Error";
                return result;
            }

            //      GPT
            temp = cboGPT.Text.Trim();
            if (string.IsNullOrEmpty(temp))
            {
                message     = "GPT is missing or is blank. Please select a GPT and try again. Thank you.";
                title       = "Add GPT Prompt - Check Inputs (Missing GPT)";
                cmresult    = ShowMsgBox(title, message, (int)_icon.Error, "OK");
                //cmresult    = CMsgBox(message, title, (int)_icon.Error, "OK");

                result = "Error";
                return result;
            }

            return result;
        }

        /// <summary>
        /// Get Category ID
        /// </summary>
        /// <param name="_catLevel"></param>
        /// <returns></returns>
        public int catGet(int _catLevel)
        {
            int _result = 0;
            string _category = "";

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
            foreach (var item in chatCategory)
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
            int _result = 0;
            string _gptName = cboGPT.Text.Trim();

            foreach (var item in chatGPT)
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
            chatCategory.Clear();
            chatCategory = db.chatGetAllCategory();
            LoadcatComboboxes(chatCategory);
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
            int     result      = 0;
            string  title       = _message + " Not Working";
            string  message     = _message + " is not currently set up.";
            string  buttonText1 = "OK";
            int     icon        = (int)_icon.Misc;
            cmresult = ShowMsgBox(title, message, icon, buttonText1);
           // result = CMsgBox(message, title, icon, buttonText1 );
            
            //CustMsgBox = new CustMsgBox();
            //CustMsgBox.Title = _message + " Not Working";
            //CustMsgBox.Message = _message + " is not currently set up.";
            //CustMsgBox.ButtonText1 = "OK";
            //CustMsgBox.Icon = (int)_icon.Misc;

            //MsgBoxUser custMsgBox = new MsgBoxUser(CustMsgBox);
            //custMsgBox.ShowDialog();
            //int Result = (int)custMsgBox.ShowDialog();
            //int Result2 = (int)custMsgBox.Result;


        }

        /// <summary>
        /// Load the GPT combobox
        /// </summary>
        public void LoadGPTCombobox()
        {
            chatGPT.Clear();
            chatGPT = db.getChatGPT();

            cboGPT.Items.Clear();
            cboGPT.Items.Add("");

            foreach (var item in chatGPT)
            {
                cboGPT.Items.Add(item.versionName.Trim());
            }
        }

        /// <summary>
        /// Custom Message Box
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="title"></param>
        /// <param name="_icn"></param>
        /// <param name="_buttonText1"></param>
        /// <param name="_buttonText2"></param>
        /// <param name="_buttonText3"></param>
        /// <param name="_buttonText4"></param>
        /// <param name="_buttonText5"></param>
        /// <param name="_buttonText6"></param>
        /// <returns></returns>
        public int CMsgBox(string _message, string title, int _icn, string _buttonText1, string _buttonText2 = "", string _buttonText3 = "", 
            string _buttonText4 = "", string _buttonText5 = "", string _buttonText6 = "")
        {
            CustMsgBox              = new CustMsgBox();
            CustMsgBox.Title        = _message + " Not Working";
            CustMsgBox.Message      = _message + " is not currently set up.";
            CustMsgBox.ButtonText1  = "OK";
            CustMsgBox.Icon         =_icn;

            MsgBoxUser custMsgBox   = new MsgBoxUser(CustMsgBox);
            custMsgBox.ShowDialog();
            int Result              = (int)custMsgBox.ShowDialog();
            int Result2             = (int)custMsgBox.Result;
            return Result2;
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
                Title           = title,
                Message         = message,
                SystemMessage   = systemMessage.Trim(),
                ButtonText1     = buttonText1,
                ButtonText2     = buttonText2,
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
