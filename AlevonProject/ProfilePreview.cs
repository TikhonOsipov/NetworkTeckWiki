using System;
using System.Windows.Forms;

namespace AlevonProject
{
    public partial class ProfilePreview : Form
    {

        public ProfilePreview()
        {
            InitializeComponent();
        }

        private void ProfilePreview_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(100, 100);
            SelectedDocuments mem = SelectedDocuments.getInstance();
            //Load profile and display on the form
            new PdfDocumentReader(mem.selectedProfile, webBrowser1);
        }

        private void openExtendedProfile_Click(object sender, EventArgs e)
        {
            if (Program.extendedProfile == null) Program.extendedProfile = new ExtendedProfilePreview();
            Program.extendedProfile.Show();
            Hide();
        }

        private void backToAnnotation_Click(object sender, EventArgs e)
        {
            backToAnnotationOperations();
            Hide();
        }

        private void ProfilePreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            backToAnnotationOperations();
        }

        private void backToAnnotationOperations()
        {
            if (Program.annotation == null) Program.annotation = new AnnotationPreview();
            Program.annotation.Show();
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
