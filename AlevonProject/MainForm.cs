using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlevonProject
{
    public partial class MainForm : Form
    {
        private SelectedDocuments sd;
        private AnnotationPreview annotation = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.main = this;
            sd = SelectedDocuments.getInstance();
        }

        private void showAnnotation(int annotationIndex)
        {
            Program.annotation = new AnnotationPreview();
            sd.setArticleIndex(annotationIndex);
            Program.annotation.Show();
            Hide();
        }

        private void buttonMimo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(0);
        }

        private void m2m_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(1);
        }

        private void qc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(2);
        }

        private void usn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(3);
        }

        private void rfid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(4);
        }
    }
}
