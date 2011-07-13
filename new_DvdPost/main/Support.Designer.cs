namespace main
{
    partial class Support
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLangue = new DevExpress.XtraEditors.LabelControl();
            this.lblSupportValue = new DevExpress.XtraEditors.LabelControl();
            this.lblStudio = new DevExpress.XtraEditors.LabelControl();
            this.lblStudioValue = new DevExpress.XtraEditors.LabelControl();
            this.lblDvd = new DevExpress.XtraEditors.LabelControl();
            this.lblNbDvd = new DevExpress.XtraEditors.LabelControl();
            this.lblDateStart = new DevExpress.XtraEditors.LabelControl();
            this.lblDateEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblDateStartValue = new DevExpress.XtraEditors.LabelControl();
            this.ctrlLanguageSubtitle = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLangue
            // 
            this.lblLangue.Location = new System.Drawing.Point(376, 17);
            this.lblLangue.Name = "lblLangue";
            this.lblLangue.Size = new System.Drawing.Size(104, 16);
            this.lblLangue.TabIndex = 1;
            this.lblLangue.Text = "langue - sous titre";
            // 
            // lblSupportValue
            // 
            this.lblSupportValue.Location = new System.Drawing.Point(58, 53);
            this.lblSupportValue.Name = "lblSupportValue";
            this.lblSupportValue.Size = new System.Drawing.Size(20, 16);
            this.lblSupportValue.TabIndex = 5;
            this.lblSupportValue.Text = "dvd";
            this.lblSupportValue.Visible = false;
            // 
            // lblStudio
            // 
            this.lblStudio.Location = new System.Drawing.Point(140, 17);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(34, 16);
            this.lblStudio.TabIndex = 6;
            this.lblStudio.Text = "studio";
            // 
            // lblStudioValue
            // 
            this.lblStudioValue.Location = new System.Drawing.Point(140, 53);
            this.lblStudioValue.Name = "lblStudioValue";
            this.lblStudioValue.Size = new System.Drawing.Size(39, 16);
            this.lblStudioValue.TabIndex = 7;
            this.lblStudioValue.Text = "cineart";
            // 
            // lblDvd
            // 
            this.lblDvd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvd.Appearance.Options.UseFont = true;
            this.lblDvd.Location = new System.Drawing.Point(48, 75);
            this.lblDvd.Name = "lblDvd";
            this.lblDvd.Size = new System.Drawing.Size(41, 21);
            this.lblDvd.TabIndex = 8;
            this.lblDvd.Text = "#Dvd";
            // 
            // lblNbDvd
            // 
            this.lblNbDvd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbDvd.Appearance.Options.UseFont = true;
            this.lblNbDvd.Location = new System.Drawing.Point(61, 106);
            this.lblNbDvd.Name = "lblNbDvd";
            this.lblNbDvd.Size = new System.Drawing.Size(9, 21);
            this.lblNbDvd.TabIndex = 9;
            this.lblNbDvd.Text = "0";
            // 
            // lblDateStart
            // 
            this.lblDateStart.Location = new System.Drawing.Point(118, 111);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(79, 16);
            this.lblDateStart.TabIndex = 10;
            this.lblDateStart.Text = "date de début";
            this.lblDateStart.Visible = false;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Location = new System.Drawing.Point(220, 111);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(61, 16);
            this.lblDateEnd.TabIndex = 11;
            this.lblDateEnd.Text = "date de fin";
            this.lblDateEnd.Visible = false;
            // 
            // lblDateStartValue
            // 
            this.lblDateStartValue.Location = new System.Drawing.Point(140, 142);
            this.lblDateStartValue.Name = "lblDateStartValue";
            this.lblDateStartValue.Size = new System.Drawing.Size(0, 16);
            this.lblDateStartValue.TabIndex = 12;
            // 
            // ctrlLanguageSubtitle
            // 
            this.ctrlLanguageSubtitle.FormattingEnabled = true;
            this.ctrlLanguageSubtitle.ItemHeight = 16;
            this.ctrlLanguageSubtitle.Location = new System.Drawing.Point(365, 37);
            this.ctrlLanguageSubtitle.Name = "ctrlLanguageSubtitle";
            this.ctrlLanguageSubtitle.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ctrlLanguageSubtitle.Size = new System.Drawing.Size(285, 132);
            this.ctrlLanguageSubtitle.TabIndex = 15;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLanguageSubtitle);
            this.Controls.Add(this.lblDateStartValue);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.lblNbDvd);
            this.Controls.Add(this.lblDvd);
            this.Controls.Add(this.lblStudioValue);
            this.Controls.Add(this.lblStudio);
            this.Controls.Add(this.lblSupportValue);
            this.Controls.Add(this.lblLangue);
            this.Name = "Support";
            this.Size = new System.Drawing.Size(705, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblLangue;
        private DevExpress.XtraEditors.LabelControl lblSupportValue;
        private DevExpress.XtraEditors.LabelControl lblStudio;
        private DevExpress.XtraEditors.LabelControl lblStudioValue;
        private DevExpress.XtraEditors.LabelControl lblDvd;
        private DevExpress.XtraEditors.LabelControl lblNbDvd;
        private DevExpress.XtraEditors.LabelControl lblDateStart;
        private DevExpress.XtraEditors.LabelControl lblDateEnd;
        private DevExpress.XtraEditors.LabelControl lblDateStartValue;
        private System.Windows.Forms.ListBox ctrlLanguageSubtitle;
          
    }
}
