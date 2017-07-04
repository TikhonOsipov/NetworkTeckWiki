namespace AlevonProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMimo = new System.Windows.Forms.LinkLabel();
            this.m2m = new System.Windows.Forms.LinkLabel();
            this.qc = new System.Windows.Forms.LinkLabel();
            this.usn = new System.Windows.Forms.LinkLabel();
            this.rfid = new System.Windows.Forms.LinkLabel();
            this.lte = new System.Windows.Forms.LinkLabel();
            this.lteAdvanced = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMimo
            // 
            this.buttonMimo.AutoSize = true;
            this.buttonMimo.BackColor = System.Drawing.Color.Transparent;
            this.buttonMimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMimo.Location = new System.Drawing.Point(120, 129);
            this.buttonMimo.Name = "buttonMimo";
            this.buttonMimo.Size = new System.Drawing.Size(61, 24);
            this.buttonMimo.TabIndex = 1;
            this.buttonMimo.TabStop = true;
            this.buttonMimo.Text = "MIMO";
            this.buttonMimo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buttonMimo_LinkClicked);
            // 
            // m2m
            // 
            this.m2m.AutoSize = true;
            this.m2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m2m.Location = new System.Drawing.Point(96, 281);
            this.m2m.Name = "m2m";
            this.m2m.Size = new System.Drawing.Size(52, 24);
            this.m2m.TabIndex = 2;
            this.m2m.TabStop = true;
            this.m2m.Text = "M2M";
            this.m2m.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m2m_LinkClicked);
            // 
            // qc
            // 
            this.qc.AutoSize = true;
            this.qc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qc.Location = new System.Drawing.Point(317, 167);
            this.qc.Name = "qc";
            this.qc.Size = new System.Drawing.Size(38, 24);
            this.qc.TabIndex = 3;
            this.qc.TabStop = true;
            this.qc.Text = "QC";
            this.qc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.qc_LinkClicked);
            // 
            // usn
            // 
            this.usn.AutoSize = true;
            this.usn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usn.Location = new System.Drawing.Point(442, 365);
            this.usn.Name = "usn";
            this.usn.Size = new System.Drawing.Size(49, 24);
            this.usn.TabIndex = 4;
            this.usn.TabStop = true;
            this.usn.Text = "USN";
            this.usn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usn_LinkClicked);
            // 
            // rfid
            // 
            this.rfid.AutoSize = true;
            this.rfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rfid.Location = new System.Drawing.Point(566, 156);
            this.rfid.Name = "rfid";
            this.rfid.Size = new System.Drawing.Size(52, 24);
            this.rfid.TabIndex = 5;
            this.rfid.TabStop = true;
            this.rfid.Text = "RFID";
            this.rfid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rfid_LinkClicked);
            // 
            // lte
            // 
            this.lte.AutoSize = true;
            this.lte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lte.Location = new System.Drawing.Point(638, 414);
            this.lte.Name = "lte";
            this.lte.Size = new System.Drawing.Size(45, 24);
            this.lte.TabIndex = 6;
            this.lte.TabStop = true;
            this.lte.Text = "LTE";
            this.lte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lte_LinkClicked);
            // 
            // lteAdvanced
            // 
            this.lteAdvanced.AutoSize = true;
            this.lteAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lteAdvanced.Location = new System.Drawing.Point(778, 291);
            this.lteAdvanced.Name = "lteAdvanced";
            this.lteAdvanced.Size = new System.Drawing.Size(136, 24);
            this.lteAdvanced.TabIndex = 7;
            this.lteAdvanced.TabStop = true;
            this.lteAdvanced.Text = "LTE Advanced";
            this.lteAdvanced.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lteAdvanced_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 537);
            this.Controls.Add(this.lteAdvanced);
            this.Controls.Add(this.lte);
            this.Controls.Add(this.rfid);
            this.Controls.Add(this.usn);
            this.Controls.Add(this.qc);
            this.Controls.Add(this.m2m);
            this.Controls.Add(this.buttonMimo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Navigator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel buttonMimo;
        private System.Windows.Forms.LinkLabel m2m;
        private System.Windows.Forms.LinkLabel qc;
        private System.Windows.Forms.LinkLabel usn;
        private System.Windows.Forms.LinkLabel rfid;
        private System.Windows.Forms.LinkLabel lte;
        private System.Windows.Forms.LinkLabel lteAdvanced;
    }
}

