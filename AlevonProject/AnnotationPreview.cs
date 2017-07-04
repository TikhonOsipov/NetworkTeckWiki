using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlevonProject
{
    public partial class AnnotationPreview : Form
    {
        public AnnotationPreview()
        {
            InitializeComponent();
        }

        private void AnnotationPreview_Load(object sender, EventArgs e)
        {
            SelectedDocuments mem = SelectedDocuments.getInstance();
            //Load annotation and display on the form
            new WordDocumentReader(mem.selectedAnnotation, richTextBox1);
        }

        private void openProfile_Click(object sender, EventArgs e)
        {
            if (Program.profile == null) Program.profile = new ProfilePreview();
            Program.profile.Show();
            Hide();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            backToMainOperations();
            Hide();
        }

        private void AnnotationPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            backToMainOperations();
        }

        private void backToMainOperations()
        {
            if (Program.main == null) Program.main = new MainForm();
            Program.annotation = null;
            Program.profile = null;
            Program.extendedProfile = null;
            Program.main.Show();
        }
    }
}
