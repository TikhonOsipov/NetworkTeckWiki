using System;
using System.Windows.Forms;

namespace AlevonProject
{
    public partial class ExtendedProfilePreview : Form
    { 
        public ExtendedProfilePreview()
        {
            InitializeComponent();
        }

        private void ExtendedProfilePreview_Load(object sender, EventArgs e)
        {
            SelectedDocuments mem = SelectedDocuments.getInstance();
            //Load extended profile and display on the form
            new WordDocumentReader(mem.selectedExtendedProfile, richTextBox1);
        }

        //back to profile
        private void button1_Click_1(object sender, EventArgs e)
        {
            backToProfileOperations();
            Hide();
        }

        private void ExtendedProfilePreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            backToProfileOperations();
        }

        private void backToProfileOperations()
        {
            if (Program.profile == null) Program.profile = new ProfilePreview();
            Program.profile.Show();
        }
    }
}
