namespace AlevonProject
{
    partial class ProfilePreview
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openExtendedProfile = new System.Windows.Forms.Button();
            this.backToAnnotation = new System.Windows.Forms.Button();
            this.goToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(814, 471);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openExtendedProfile
            // 
            this.openExtendedProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openExtendedProfile.Location = new System.Drawing.Point(653, 477);
            this.openExtendedProfile.Name = "openExtendedProfile";
            this.openExtendedProfile.Size = new System.Drawing.Size(149, 23);
            this.openExtendedProfile.TabIndex = 1;
            this.openExtendedProfile.Text = "Расширенный профиль";
            this.openExtendedProfile.UseVisualStyleBackColor = true;
            this.openExtendedProfile.Click += new System.EventHandler(this.openExtendedProfile_Click);
            // 
            // backToAnnotation
            // 
            this.backToAnnotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backToAnnotation.Location = new System.Drawing.Point(12, 477);
            this.backToAnnotation.Name = "backToAnnotation";
            this.backToAnnotation.Size = new System.Drawing.Size(75, 23);
            this.backToAnnotation.TabIndex = 2;
            this.backToAnnotation.Text = "Аннотация";
            this.backToAnnotation.UseVisualStyleBackColor = true;
            this.backToAnnotation.Click += new System.EventHandler(this.backToAnnotation_Click);
            // 
            // goToMain
            // 
            this.goToMain.Location = new System.Drawing.Point(93, 477);
            this.goToMain.Name = "goToMain";
            this.goToMain.Size = new System.Drawing.Size(123, 23);
            this.goToMain.TabIndex = 3;
            this.goToMain.Text = "На главную";
            this.goToMain.UseVisualStyleBackColor = true;
            this.goToMain.Click += new System.EventHandler(this.goToMain_Click);
            // 
            // ProfilePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 512);
            this.Controls.Add(this.goToMain);
            this.Controls.Add(this.backToAnnotation);
            this.Controls.Add(this.openExtendedProfile);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ProfilePreview";
            this.Text = "Профиль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfilePreview_FormClosing);
            this.Load += new System.EventHandler(this.ProfilePreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button openExtendedProfile;
        private System.Windows.Forms.Button backToAnnotation;
        private System.Windows.Forms.Button goToMain;
    }
}