using AIPrompts.Forms;
using db = AIPrompts.SQLAccess;
using System;
using AIPrompts.Models;

namespace AIPrompts
{
    public partial class Main : Form
    {
        #region Class variables


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


        #endregion





    }
}
