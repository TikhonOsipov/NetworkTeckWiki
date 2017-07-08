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
            Location = new System.Drawing.Point(100, 100);
            SelectedDocuments mem = SelectedDocuments.getInstance();
            //Load extended profile and display on the form
            new PdfDocumentReader(mem.selectedExtendedProfile, webBrowser1);
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

        private void goToMain_Click(object sender, EventArgs e)
        {
            if (Program.main == null) Program.main = new MainForm();
            Program.annotation = null;
            Program.profile = null;
            Program.extendedProfile = null;
            Program.main.Show();
            Hide();
        }
    }
}
