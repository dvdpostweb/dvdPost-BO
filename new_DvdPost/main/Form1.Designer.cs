namespace main
{
    partial class Form1
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
            this.gridProductFiches = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductFiche = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtabCtrlNewDvdPost = new DevExpress.XtraTab.XtraTabControl();
            this.xtabPageMovies = new DevExpress.XtraTab.XtraTabPage();
            this.xtabPageProducts = new DevExpress.XtraTab.XtraTabPage();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtabPageDisk = new DevExpress.XtraTab.XtraTabPage();
            this.gridDVD = new DevExpress.XtraGrid.GridControl();
            this.gridViewDVD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtabPageInfo = new DevExpress.XtraTab.XtraTabPage();
            this.gbVod = new System.Windows.Forms.GroupBox();
            this.gbBlueray = new System.Windows.Forms.GroupBox();
            this.gbDvd = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.imgCover = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductFiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabCtrlNewDvdPost)).BeginInit();
            this.xtabCtrlNewDvdPost.SuspendLayout();
            this.xtabPageMovies.SuspendLayout();
            this.xtabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            this.xtabPageDisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVD)).BeginInit();
            this.xtabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductFiches
            // 
            this.gridProductFiches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductFiches.EmbeddedNavigator.Name = "";
            this.gridProductFiches.FormsUseDefaultLookAndFeel = false;
            this.gridProductFiches.Location = new System.Drawing.Point(0, 0);
            this.gridProductFiches.MainView = this.gridViewProductFiche;
            this.gridProductFiches.Name = "gridProductFiches";
            this.gridProductFiches.Size = new System.Drawing.Size(1021, 802);
            this.gridProductFiches.TabIndex = 0;
            this.gridProductFiches.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductFiche});
            // 
            // gridViewProductFiche
            // 
            this.gridViewProductFiche.GridControl = this.gridProductFiches;
            this.gridViewProductFiche.Name = "gridViewProductFiche";
            this.gridViewProductFiche.OptionsBehavior.Editable = false;
            this.gridViewProductFiche.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductFiche.OptionsView.ShowFooter = true;
            this.gridViewProductFiche.DoubleClick += new System.EventHandler(this.gridViewProductFiche_DoubleClick);
            // 
            // xtabCtrlNewDvdPost
            // 
            this.xtabCtrlNewDvdPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtabCtrlNewDvdPost.Location = new System.Drawing.Point(0, 0);
            this.xtabCtrlNewDvdPost.Name = "xtabCtrlNewDvdPost";
            this.xtabCtrlNewDvdPost.SelectedTabPage = this.xtabPageMovies;
            this.xtabCtrlNewDvdPost.Size = new System.Drawing.Size(1030, 836);
            this.xtabCtrlNewDvdPost.TabIndex = 1;
            this.xtabCtrlNewDvdPost.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabPageMovies,
            this.xtabPageProducts,
            this.xtabPageDisk,
            this.xtabPageInfo});
            // 
            // xtabPageMovies
            // 
            this.xtabPageMovies.Controls.Add(this.gridProductFiches);
            this.xtabPageMovies.Name = "xtabPageMovies";
            this.xtabPageMovies.Size = new System.Drawing.Size(1021, 802);
            this.xtabPageMovies.Text = "movies";
            // 
            // xtabPageProducts
            // 
            this.xtabPageProducts.Controls.Add(this.gridProduct);
            this.xtabPageProducts.Name = "xtabPageProducts";
            this.xtabPageProducts.Size = new System.Drawing.Size(1021, 802);
            this.xtabPageProducts.Text = "Products";
            // 
            // gridProduct
            // 
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.EmbeddedNavigator.Name = "";
            this.gridProduct.FormsUseDefaultLookAndFeel = false;
            this.gridProduct.Location = new System.Drawing.Point(0, 0);
            this.gridProduct.MainView = this.gridViewProduct;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(1021, 802);
            this.gridProduct.TabIndex = 1;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduct});
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.GridControl = this.gridProduct;
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.OptionsBehavior.Editable = false;
            this.gridViewProduct.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProduct.OptionsView.ShowFooter = true;
            this.gridViewProduct.DoubleClick += new System.EventHandler(this.gridViewProduct_DoubleClick);
            // 
            // xtabPageDisk
            // 
            this.xtabPageDisk.Controls.Add(this.gridDVD);
            this.xtabPageDisk.Name = "xtabPageDisk";
            this.xtabPageDisk.Size = new System.Drawing.Size(1021, 802);
            this.xtabPageDisk.Text = "Disk";
            // 
            // gridDVD
            // 
            this.gridDVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDVD.EmbeddedNavigator.Name = "";
            this.gridDVD.FormsUseDefaultLookAndFeel = false;
            this.gridDVD.Location = new System.Drawing.Point(0, 0);
            this.gridDVD.MainView = this.gridViewDVD;
            this.gridDVD.Name = "gridDVD";
            this.gridDVD.Size = new System.Drawing.Size(1021, 802);
            this.gridDVD.TabIndex = 1;
            this.gridDVD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDVD});
            // 
            // gridViewDVD
            // 
            this.gridViewDVD.GridControl = this.gridDVD;
            this.gridViewDVD.Name = "gridViewDVD";
            this.gridViewDVD.OptionsBehavior.Editable = false;
            this.gridViewDVD.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDVD.OptionsView.ShowFooter = true;
            // 
            // xtabPageInfo
            // 
            this.xtabPageInfo.Controls.Add(this.gbVod);
            this.xtabPageInfo.Controls.Add(this.gbBlueray);
            this.xtabPageInfo.Controls.Add(this.gbDvd);
            this.xtabPageInfo.Controls.Add(this.cmbLanguage);
            this.xtabPageInfo.Controls.Add(this.txtDescription);
            this.xtabPageInfo.Controls.Add(this.imgCover);
            this.xtabPageInfo.Controls.Add(this.lblTitle);
            this.xtabPageInfo.Name = "xtabPageInfo";
            this.xtabPageInfo.Size = new System.Drawing.Size(1021, 802);
            this.xtabPageInfo.Text = "Info";
            // 
            // gbVod
            // 
            this.gbVod.Location = new System.Drawing.Point(11, 615);
            this.gbVod.Name = "gbVod";
            this.gbVod.Size = new System.Drawing.Size(1010, 171);
            this.gbVod.TabIndex = 6;
            this.gbVod.TabStop = false;
            this.gbVod.Text = "Vod";
            // 
            // gbBlueray
            // 
            this.gbBlueray.Location = new System.Drawing.Point(11, 438);
            this.gbBlueray.Name = "gbBlueray";
            this.gbBlueray.Size = new System.Drawing.Size(1010, 171);
            this.gbBlueray.TabIndex = 5;
            this.gbBlueray.TabStop = false;
            this.gbBlueray.Text = "Blueray";
            // 
            // gbDvd
            // 
            this.gbDvd.Location = new System.Drawing.Point(10, 261);
            this.gbDvd.Name = "gbDvd";
            this.gbDvd.Size = new System.Drawing.Size(1010, 171);
            this.gbDvd.TabIndex = 4;
            this.gbDvd.TabStop = false;
            this.gbDvd.Text = "DVD";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(621, 92);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 24);
            this.cmbLanguage.TabIndex = 3;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(293, 92);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(263, 136);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // imgCover
            // 
            this.imgCover.Location = new System.Drawing.Point(78, 92);
            this.imgCover.Name = "imgCover";
            this.imgCover.Size = new System.Drawing.Size(182, 136);
            this.imgCover.TabIndex = 1;
            this.imgCover.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(305, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 836);
            this.Controls.Add(this.xtabCtrlNewDvdPost);
            this.Name = "Form1";
            this.Text = "demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductFiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabCtrlNewDvdPost)).EndInit();
            this.xtabCtrlNewDvdPost.ResumeLayout(false);
            this.xtabPageMovies.ResumeLayout(false);
            this.xtabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            this.xtabPageDisk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVD)).EndInit();
            this.xtabPageInfo.ResumeLayout(false);
            this.xtabPageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProductFiches;
        private DevExpress.XtraTab.XtraTabControl xtabCtrlNewDvdPost;
        private DevExpress.XtraTab.XtraTabPage xtabPageMovies;
        private DevExpress.XtraTab.XtraTabPage xtabPageProducts;
        private DevExpress.XtraTab.XtraTabPage xtabPageDisk;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.GridControl gridDVD;
        DevExpress.XtraGrid.Views.Grid.GridView gridViewProductFiche;
        DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        DevExpress.XtraGrid.Views.Grid.GridView gridViewDVD;
        private DevExpress.XtraTab.XtraTabPage xtabPageInfo;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.PictureBox imgCover;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbDvd;
        private System.Windows.Forms.GroupBox gbVod;
        private System.Windows.Forms.GroupBox gbBlueray;
    }
}

