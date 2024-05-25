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
    public partial class AIImageNotes : Form
    {
        public AIImageNotes()
        {
            InitializeComponent();
        }

        // Controls
        private void mnustrpFileExit_Click(      object sender, EventArgs e) => CloseWindows();
        private void mnustrpFileClearForm_Click( object sender, EventArgs e) => ResetFields();
        private void pctbxRefreshTitle_Click(    object sender, EventArgs e) => ResetTitle();
        private void pctbxRefreshPrompt_Click(   object sender, EventArgs e) => ResetPrompt();
        private void pctbxNegPrompt_Click(       object sender, EventArgs e) => ResetNegativePrompt();
        private void pctbxNotes_Click(           object sender, EventArgs e) => ResetNotes();
        private void pctbxRefreshMiscNotes_Click(object sender, EventArgs e) => ResetMiscNotes();
        private void picbxExit_Click(            object sender, EventArgs e) => CloseWindows();
        private void picbxRefresh_Click(         object sender, EventArgs e) => ResetFields();

        // Code
        public void ResetFields()
        {
            txtRating.Text          = string.Empty;
            txtNegativePrompt.Text  = string.Empty;
            txtNotes.Text           = string.Empty;
            txtPrompt.Text          = string.Empty;
            txtPromptTitle.Text     = string.Empty;
            txtMiscNote.Text        = string.Empty;
        }

        public void ResetTitle()
        {
            txtRating.Text      = string.Empty;
            txtPromptTitle.Text = string.Empty;
        }


        public void ResetPrompt() 
        {
            txtPrompt.Text = string.Empty;
        }

        public void ResetNegativePrompt() 
        {
            txtNegativePrompt.Text = string.Empty;
        }

        public void ResetNotes() 
        {
            txtNotes.Text = string.Empty;
        }

        public void ResetMiscNotes()
        { 
            txtMiscNote.Text = string.Empty;
        }

        public void CloseWindows()
        {
            this.Close();
        }

        public void NotSetup()
        {
            MessageBox.Show("Not Done", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
