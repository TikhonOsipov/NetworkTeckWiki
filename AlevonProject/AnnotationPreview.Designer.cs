namespace AlevonProject
{
    partial class AnnotationPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openProfile = new System.Windows.Forms.Button();
            this.backToMain = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // openProfile
            // 
            this.openProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openProfile.Location = new System.Drawing.Point(663, 477);
            this.openProfile.Name = "openProfile";
            this.openProfile.Size = new System.Drawing.Size(139, 23);
            this.openProfile.TabIndex = 2;
            this.openProfile.Text = "Профиль";
            this.openProfile.UseVisualStyleBackColor = true;
            this.openProfile.Click += new System.EventHandler(this.openProfile_Click);
            // 
            // backToMain
            // 
            this.backToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backToMain.Location = new System.Drawing.Point(12, 477);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(75, 23);
            this.backToMain.TabIndex = 3;
            this.backToMain.Text = "На главную";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(790, 459);
            this.webBrowser1.TabIndex = 4;
            // 
            // AnnotationPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 512);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.backToMain);
            this.Controls.Add(this.openProfile);
            this.Name = "AnnotationPreview";
            this.Text = "Аннотация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnnotationPreview_FormClosing);
            this.Load += new System.EventHandler(this.AnnotationPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openProfile;
        private System.Windows.Forms.Button backToMain;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}