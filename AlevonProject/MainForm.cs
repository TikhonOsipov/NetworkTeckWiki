using System;
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
            Location = new System.Drawing.Point(100, 100);
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

        private void lte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(5);
        }

        private void lteAdvanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(6);
        }

        private void glonass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(7);
        }

        private void nsn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showAnnotation(8);
        }
    }
}
