using AIPrompts.Forms;
using db = AIPrompts.SQLAccess;
using System;
using AIPrompts.Models;

namespace AIPrompts
{
    public partial class Main : Form
    {
        #region Class variables
        CustMsgBox  CustMsgBox  = new CustMsgBox();
        string      title       = "";  // message, title, icon, button...
        string      message     = "";
        string      errMessage  = "";
        string      rank        = "";
        string      temp        = "";
        string      result      = "";
        int         cmresult    = 0;

        #endregion

        #region Form Startup
        /// <summary>
        /// Initialize the form
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setup the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        #endregion  // Form Startup


        #region Menu Strip Items

        /// <summary>
        /// Menustrip: File/Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpFileExit_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }

        /// <summary>
        /// Menustrip: AI Image/Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpAIImageAdd_Click(object sender, EventArgs e)
        {
            string _message = "AI Image/Add";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: AI Image/Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpAIImageSearch_Click(object sender, EventArgs e)
        {
            string _message = "AI Image/Search";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: AI Image/Maintenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpAIImageMaintenance_Click(object sender, EventArgs e)
        {
            string _message = "AI Image/Maintenance";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: AI Chat/Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpAIChatAdd_Click(object sender, EventArgs e)
        {
            string _message = "AI Chat/Add";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: AI Chat/Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpAIChatSearch_Click(object sender, EventArgs e)
        {
            string _message = "AI Chat/Search";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Menustrip: AI Chat/Maintenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnustrpAIChatMaintenance_Click(object sender, EventArgs e)
        {
            string _message = "AI Image/Maintenance";
            NotWorkingMessage(_message);
        }
        #endregion

        #region Form Items

        /// <summary>
        /// Form: Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }

        /// <summary>
        /// Form: AI Image/Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAIImagesAdd_Click(object sender, EventArgs e)
        {
            AddImagePrompt _imagePrompt = new AddImagePrompt(); // Create new form for image maintenance
            _imagePrompt.Show();
        }

        /// <summary>
        /// Form: AI Image/Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAIImagesSearch_Click(object sender, EventArgs e)
        {
            string _message = "AI Image/Search";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Form: AI Image/Maintenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAIImagesMaintenance_Click(object sender, EventArgs e)
        {
            ImageMaintMain _imageMaint = new ImageMaintMain(); // Create new form for image maintenance
            _imageMaint.Show();
        }

        /// <summary>
        /// Form: AI Chat/Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAIChatAdd_Click(object sender, EventArgs e)
        {
            AddChat _addChat = new AddChat(); // Create new form for Add Chat
            _addChat.Show();
        }

        /// <summary>
        /// Form: AI Chat/Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAIChatSearch_Click(object sender, EventArgs e)
        {
            //  Variables
            title = "Testing The User Box";    // message, title, icon, button...
            message = "Jack and jill were Users";
            errMessage = "System Error";
            //string rank = txtRank.Text.Trim();
            //string temp = "";
            //string result = "Good";
            int cmresult = 0;

            cmresult = ShowMsgBox(title, message, (int)_icon.Error, "OK","Not OK","Alfred","","","",errMessage);
            message = cmresult.ToString();



            string _message = "AI Chat/Search";
            NotWorkingMessage(_message);
        }

        /// <summary>
        /// Form: AI Chat/Maintenance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAIChatMaintenance_Click(object sender, EventArgs e)
        {
            GPTMaint _maintGPT = new GPTMaint(); // Create new form for Add Chat
            _maintGPT.Show();
        }

        #endregion

        #region Main Code



        /// <summary>
        /// Close Program
        /// </summary>
        public void CloseProgram()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Show message for non working functions
        /// </summary>
        /// <param name="_message"></param>
        public void NotWorkingMessage(string _message)
        {
            MessageBox.Show(_message + " is not currently set up.");
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
                string buttonText3 = "", string buttonText4 = "", string buttonText5 = "", string buttonText6 = "",
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
                ButtonText3 = buttonText3,
                ButtonText4 = buttonText4,
                ButtonText5 = buttonText5,
                ButtonText6 = buttonText6,


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
            Question    = 2,
            Warning     = 3,
            Error       = 4,
            Misc        = 5
        }

        #endregion



    }
}
