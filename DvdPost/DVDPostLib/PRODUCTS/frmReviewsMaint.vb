Imports System.Windows.Forms.Application
Public Class frmReviewsMaint
    Inherits BizzLib.frmBKForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DsProducts1 As DVDPostLib.dsProducts
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReviewID As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAcceptAndSave As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtCustomerID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductTitle As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnDeleteReview As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtReviewRating As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Public WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtLast_modified As DevExpress.XtraEditors.DateEdit
    Public WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReviews_Read As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReview_Check As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReview_Corrected As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCust_Best_Rating As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCust_Bad_Rating As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtLanguage_id As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReview_Text As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnSaveOnly As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtReviewID = New DevExpress.XtraEditors.TextEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnAcceptAndSave = New DevExpress.XtraEditors.SimpleButton
        Me.txtCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.btnDeleteReview = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveOnly = New DevExpress.XtraEditors.SimpleButton
        Me.DsProducts1 = New DVDPostLib.dsProducts
        Me.txtReviewRating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAdded = New DevExpress.XtraEditors.DateEdit
        Me.txtLast_modified = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtReviews_Read = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtReview_Check = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtReview_Corrected = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtCust_Best_Rating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtCust_Bad_Rating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtLanguage_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtReview_Text = New DevExpress.XtraEditors.MemoEdit
        Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReviewID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReviewRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLast_modified.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLast_modified.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReviews_Read.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReview_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReview_Corrected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCust_Best_Rating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCust_Bad_Rating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLanguage_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReview_Text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(38, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Review ID"
        '
        'txtReviewID
        '
        Me.txtReviewID.Location = New System.Drawing.Point(173, 65)
        Me.txtReviewID.Name = "txtReviewID"
        Me.txtReviewID.Size = New System.Drawing.Size(120, 22)
        Me.txtReviewID.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(298, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 26)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTip = "Rechercher les info de cette commande"
        '
        'btnAcceptAndSave
        '
        Me.btnAcceptAndSave.Location = New System.Drawing.Point(535, 65)
        Me.btnAcceptAndSave.Name = "btnAcceptAndSave"
        Me.btnAcceptAndSave.Size = New System.Drawing.Size(125, 26)
        Me.btnAcceptAndSave.TabIndex = 7
        Me.btnAcceptAndSave.Text = "Save and Accept"
        Me.btnAcceptAndSave.ToolTip = "Supprimer cette commande"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(173, 106)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(120, 22)
        Me.txtCustomerID.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(38, 106)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Customer ID"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(173, 164)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(120, 22)
        Me.txtProductID.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(38, 167)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Product ID"
        '
        'txtProductTitle
        '
        Me.txtProductTitle.Enabled = False
        Me.txtProductTitle.Location = New System.Drawing.Point(173, 194)
        Me.txtProductTitle.Name = "txtProductTitle"
        Me.txtProductTitle.Size = New System.Drawing.Size(355, 22)
        Me.txtProductTitle.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(38, 197)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(25, 16)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Title"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(173, 134)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(355, 22)
        Me.txtCustomerName.TabIndex = 17
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(38, 134)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Customer Name"
        '
        'btnDeleteReview
        '
        Me.btnDeleteReview.Location = New System.Drawing.Point(403, 65)
        Me.btnDeleteReview.Name = "btnDeleteReview"
        Me.btnDeleteReview.Size = New System.Drawing.Size(125, 26)
        Me.btnDeleteReview.TabIndex = 28
        Me.btnDeleteReview.Text = "Delete Review"
        Me.btnDeleteReview.ToolTip = "Definir ce DVD comme Bizzarement Perdu"
        '
        'btnSaveOnly
        '
        Me.btnSaveOnly.Location = New System.Drawing.Point(667, 65)
        Me.btnSaveOnly.Name = "btnSaveOnly"
        Me.btnSaveOnly.Size = New System.Drawing.Size(125, 26)
        Me.btnSaveOnly.TabIndex = 29
        Me.btnSaveOnly.Text = "Save Only"
        Me.btnSaveOnly.ToolTip = "Supprimer cette commande"
        '
        'DsProducts1
        '
        Me.DsProducts1.DataSetName = "dsProducts"
        Me.DsProducts1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtReviewRating
        '
        Me.txtReviewRating.Enabled = False
        Me.txtReviewRating.Location = New System.Drawing.Point(672, 134)
        Me.txtReviewRating.Name = "txtReviewRating"
        Me.txtReviewRating.Size = New System.Drawing.Size(120, 22)
        Me.txtReviewRating.TabIndex = 31
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(565, 137)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 16)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Review Rating"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(565, 107)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Date Added"
        '
        'txtDateAdded
        '
        Me.txtDateAdded.EditValue = Nothing
        Me.txtDateAdded.Enabled = False
        Me.txtDateAdded.Location = New System.Drawing.Point(672, 104)
        Me.txtDateAdded.Name = "txtDateAdded"
        Me.txtDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAdded.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDateAdded.Size = New System.Drawing.Size(120, 22)
        Me.txtDateAdded.TabIndex = 33
        '
        'txtLast_modified
        '
        Me.txtLast_modified.EditValue = Nothing
        Me.txtLast_modified.Enabled = False
        Me.txtLast_modified.Location = New System.Drawing.Point(925, 103)
        Me.txtLast_modified.Name = "txtLast_modified"
        Me.txtLast_modified.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLast_modified.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtLast_modified.Size = New System.Drawing.Size(120, 22)
        Me.txtLast_modified.TabIndex = 35
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(805, 106)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Last Modified"
        '
        'txtReviews_Read
        '
        Me.txtReviews_Read.Enabled = False
        Me.txtReviews_Read.Location = New System.Drawing.Point(925, 134)
        Me.txtReviews_Read.Name = "txtReviews_Read"
        Me.txtReviews_Read.Size = New System.Drawing.Size(120, 22)
        Me.txtReviews_Read.TabIndex = 37
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(805, 137)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl9.TabIndex = 36
        Me.LabelControl9.Text = "Review Read"
        '
        'txtReview_Check
        '
        Me.txtReview_Check.Enabled = False
        Me.txtReview_Check.Location = New System.Drawing.Point(925, 164)
        Me.txtReview_Check.Name = "txtReview_Check"
        Me.txtReview_Check.Size = New System.Drawing.Size(120, 22)
        Me.txtReview_Check.TabIndex = 39
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(805, 167)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl10.TabIndex = 38
        Me.LabelControl10.Text = "Review Check"
        '
        'txtReview_Corrected
        '
        Me.txtReview_Corrected.Enabled = False
        Me.txtReview_Corrected.Location = New System.Drawing.Point(925, 194)
        Me.txtReview_Corrected.Name = "txtReview_Corrected"
        Me.txtReview_Corrected.Size = New System.Drawing.Size(120, 22)
        Me.txtReview_Corrected.TabIndex = 41
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(805, 197)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "Review Corrected"
        '
        'txtCust_Best_Rating
        '
        Me.txtCust_Best_Rating.Enabled = False
        Me.txtCust_Best_Rating.Location = New System.Drawing.Point(672, 164)
        Me.txtCust_Best_Rating.Name = "txtCust_Best_Rating"
        Me.txtCust_Best_Rating.Size = New System.Drawing.Size(120, 22)
        Me.txtCust_Best_Rating.TabIndex = 43
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(565, 167)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl12.TabIndex = 42
        Me.LabelControl12.Text = "Cust Best Rating"
        '
        'txtCust_Bad_Rating
        '
        Me.txtCust_Bad_Rating.Enabled = False
        Me.txtCust_Bad_Rating.Location = New System.Drawing.Point(672, 194)
        Me.txtCust_Bad_Rating.Name = "txtCust_Bad_Rating"
        Me.txtCust_Bad_Rating.Size = New System.Drawing.Size(120, 22)
        Me.txtCust_Bad_Rating.TabIndex = 45
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(565, 197)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl13.TabIndex = 44
        Me.LabelControl13.Text = "Cust Best Rating"
        '
        'txtLanguage_id
        '
        Me.txtLanguage_id.Enabled = False
        Me.txtLanguage_id.Location = New System.Drawing.Point(408, 103)
        Me.txtLanguage_id.Name = "txtLanguage_id"
        Me.txtLanguage_id.Size = New System.Drawing.Size(120, 22)
        Me.txtLanguage_id.TabIndex = 47
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(301, 106)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl14.TabIndex = 46
        Me.LabelControl14.Text = "Language ID"
        '
        'txtReview_Text
        '
        Me.txtReview_Text.Location = New System.Drawing.Point(173, 250)
        Me.txtReview_Text.Name = "txtReview_Text"
        Me.txtReview_Text.Size = New System.Drawing.Size(872, 158)
        Me.txtReview_Text.TabIndex = 48
        '
        'cmbRating
        '
        Me.cmbRating.Location = New System.Drawing.Point(173, 222)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRating.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("rating_desc", "rating_desc", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbRating.Properties.DisplayMember = "rating_desc"
        Me.cmbRating.Properties.NullText = ""
        Me.cmbRating.Properties.ValueMember = "rating_id"
        Me.cmbRating.Size = New System.Drawing.Size(124, 22)
        Me.cmbRating.TabIndex = 49
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(38, 222)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl15.TabIndex = 50
        Me.LabelControl15.Text = "Rating"
        '
        'frmReviewsMaint
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1056, 421)
        Me.Controls.Add(Me.cmbRating)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txtReview_Text)
        Me.Controls.Add(Me.txtLanguage_id)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtCust_Bad_Rating)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtCust_Best_Rating)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtReview_Corrected)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtReview_Check)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtReviews_Read)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtLast_modified)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtDateAdded)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtReviewRating)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btnSaveOnly)
        Me.Controls.Add(Me.btnDeleteReview)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtProductTitle)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAcceptAndSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtReviewID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmReviewsMaint"
        Me.Text = "frmReviewsMaint"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtReviewID, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnAcceptAndSave, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtProductID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.txtProductTitle, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerName, 0)
        Me.Controls.SetChildIndex(Me.btnDeleteReview, 0)
        Me.Controls.SetChildIndex(Me.btnSaveOnly, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.txtReviewRating, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.txtDateAdded, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.txtLast_modified, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.txtReviews_Read, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.txtReview_Check, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.txtReview_Corrected, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.txtCust_Best_Rating, 0)
        Me.Controls.SetChildIndex(Me.LabelControl13, 0)
        Me.Controls.SetChildIndex(Me.txtCust_Bad_Rating, 0)
        Me.Controls.SetChildIndex(Me.LabelControl14, 0)
        Me.Controls.SetChildIndex(Me.txtLanguage_id, 0)
        Me.Controls.SetChildIndex(Me.txtReview_Text, 0)
        Me.Controls.SetChildIndex(Me.LabelControl15, 0)
        Me.Controls.SetChildIndex(Me.cmbRating, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReviewID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReviewRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLast_modified.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLast_modified.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReviews_Read.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReview_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReview_Corrected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCust_Best_Rating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCust_Bad_Rating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLanguage_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReview_Text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim ReviewsTable As New DataTable("Reviews")
    Dim CustomerTable As New DataTable("customers")
    Dim ReviewRow As DataRow
    Dim objProductsDVD As clsProduct_DVD
    Public Need_A_Reload As Boolean = False

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchReviewInfo()
    End Sub
    Public Sub SearchReviewInfo()
        If txtReviewID.EditValue & "" = "" Then Exit Sub
        If Not IsNumeric(txtReviewID.EditValue) Then Exit Sub
        Dim _SQLTxt As String
        _SQLTxt = "SELECT * FROM reviews " & _
                  " WHERE reviews_id = " & txtReviewID.EditValue
        ReviewsTable.Clear()
        DvdPostData.clsConnection.FillDataSet(ReviewsTable, _SQLTxt)

        Dim dt As DataTable

        dt = DVDPostBuziness.clsReviews.getValueReview()

        cmbRating.Properties.DataSource = dt
        If ReviewsTable.Rows.Count = 1 Then
            ReviewRow = ReviewsTable.Rows(0)
        Else
            ReviewRow = Nothing
        End If
        If Not IsNothing(ReviewRow) Then
            CustomerTable.Clear()
            DvdPostData.clsConnection.FillDataSet(CustomerTable, "SELECT * From customers where customers_id = " & ReviewRow("customers_id"))
            objProductsDVD = New clsProduct_DVD(SessionInfo, DsProducts1, ReviewRow("products_id"), 0)
            txtCustomerID.EditValue = ReviewRow("customers_id")
            txtCustomerName.EditValue = CustomerTable.Rows(0)("customers_lastname") & " " & CustomerTable.Rows(0)("customers_firstname")
            txtProductID.EditValue = ReviewRow("products_id")
            txtProductTitle.EditValue = objProductsDVD.Product_row("products_title")
            txtLanguage_id.EditValue = ReviewRow("customers_id")
            txtDateAdded.EditValue = ReviewRow("date_added")
            txtReviewRating.EditValue = ReviewRow("reviews_rating")
            txtCust_Best_Rating.EditValue = ReviewRow("customers_best_rating")
            txtCust_Bad_Rating.EditValue = ReviewRow("customers_bad_rating")
            txtLast_modified.EditValue = ReviewRow("last_modified")
            txtReviews_Read.EditValue = ReviewRow("reviews_read")
            txtReview_Check.EditValue = ReviewRow("reviews_check")
            txtReview_Corrected.EditValue = ReviewRow("reviews_corrected")
            txtReview_Text.Text = ReviewRow("reviews_text")
            If ReviewRow("dvdpost_rating") Is DBNull.Value Then
                cmbRating.Text = ""
            Else
                cmbRating.EditValue = ReviewRow("dvdpost_rating")
            End If

        Else
            txtCustomerID.EditValue = ""
            txtCustomerName.EditValue = "REVIEW NON TROUVEE"
            txtProductID.EditValue = ""
            txtProductTitle.EditValue = "REVIEW NON TROUVEE"
            txtLanguage_id.EditValue = ""
            txtDateAdded.EditValue = ""
            txtReviewRating.EditValue = ""
            txtCust_Best_Rating.EditValue = ""
            txtCust_Bad_Rating.EditValue = ""
            txtLast_modified.EditValue = ""
            txtReviews_Read.EditValue = ""
            txtReview_Check.EditValue = ""
            txtReview_Corrected.EditValue = ""
            txtReview_Text.Text = ""
            cmbRating.Text = ""
        End If
    End Sub

    Private Sub btnDeleteReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteReview.Click
        Dim _answ As MsgBoxResult = MsgBox("Do you really want to delete this review?", MsgBoxStyle.YesNo)
        If _answ = MsgBoxResult.No Then Exit Sub
        Dim _SQLTXt As String = "DELETE FROM reviews where reviews_id = " & txtReviewID.EditValue
        Dim _del As Int32 = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTXt)
        If _del <> 1 Then
            MsgBox("Cannot delete this review.", MsgBoxStyle.Critical)
        Else
            Need_A_Reload = True
            Me.Hide()
        End If

    End Sub
    Private Sub btnSaveOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOnly.Click
        If String.Equals(ReviewRow("reviews_text"), txtReview_Text.Text, StringComparison.InvariantCultureIgnoreCase) = False Then
            ReviewRow("reviews_corrected") = 1
        End If
        ReviewRow("reviews_text") = txtReview_Text.Text
        ReviewRow("last_modified") = Now.ToString("yyyy-MM-dd HH:mm:ss")
        If cmbRating.Text <> "" Then
            ReviewRow("dvdpost_rating") = cmbRating.Text
            DvdPostData.clsConnection.UpdateDataTableInDB(ReviewsTable, "SELECT * FROM reviews")
            SearchReviewInfo()
        Else
            MsgBox("Veuillez Coter cette critique !!")
        End If
    End Sub

    Private Sub btnAcceptAndSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptAndSave.Click
        ReviewRow("reviews_check") = 1
        If String.Equals(ReviewRow("reviews_text"), txtReview_Text.Text, StringComparison.InvariantCultureIgnoreCase) = False Then
            ReviewRow("reviews_corrected") = 1
        End If
        ReviewRow("reviews_text") = txtReview_Text.Text
        ReviewRow("last_modified") = Now.ToString("yyyy-MM-dd HH:mm:ss")
        ReviewRow("dvdpost_rating") = cmbRating.Text
        DvdPostData.clsConnection.UpdateDataTableInDB(ReviewsTable, "SELECT * FROM reviews")
        Need_A_Reload = True
        Me.Hide()
    End Sub
End Class

