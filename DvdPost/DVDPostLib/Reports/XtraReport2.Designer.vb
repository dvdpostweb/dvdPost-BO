<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport2
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport2))
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrTextModel1 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrRichText2 = New DevExpress.XtraReports.UI.XRRichText
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.name = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.countryname = New DevExpress.XtraReports.UI.XRLabel
        Me.postCodeAndCity = New DevExpress.XtraReports.UI.XRLabel
        Me.nameResult = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.dataTable1 = New System.Data.DataTable
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.postCodeAndCityResult = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.addressCustomersResult = New DevExpress.XtraReports.UI.XRLabel
        Me.addressCustomers = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        CType(Me.xrTextModel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'xrPageInfo1
        '
        resources.ApplyResources(Me.xrPageInfo1, "xrPageInfo1")
        Me.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrPageInfo1.BorderWidth = 1
        Me.xrPageInfo1.Dpi = 254.0!
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.StylePriority.UseFont = False
        Me.xrPageInfo1.StylePriority.UsePadding = False
        Me.xrPageInfo1.StylePriority.UseTextAlignment = False
        Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrTextModel1
        '
        resources.ApplyResources(Me.xrTextModel1, "xrTextModel1")
        Me.xrTextModel1.CanGrow = False
        Me.xrTextModel1.Dpi = 254.0!
        Me.xrTextModel1.Name = "xrTextModel1"
        Me.xrTextModel1.SerializableRtfString = resources.GetString("xrTextModel1.SerializableRtfString")
        Me.xrTextModel1.StylePriority.UseFont = False
        Me.xrTextModel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrRichText2
        '
        Me.xrRichText2.Dpi = 254.0!
        resources.ApplyResources(Me.xrRichText2, "xrRichText2")
        Me.xrRichText2.Name = "xrRichText2"
        Me.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString")
        Me.xrRichText2.StylePriority.UseFont = False
        Me.xrRichText2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrTextModel1})
        Me.Detail.Dpi = 254.0!
        resources.ApplyResources(Me.Detail, "Detail")
        Me.Detail.Height = 1004
        Me.Detail.Name = "Detail"
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.StylePriority.UseFont = False
        '
        'name
        '
        Me.name.Dpi = 254.0!
        resources.ApplyResources(Me.name, "name")
        Me.name.Multiline = True
        Me.name.Name = "name"
        Me.name.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.name.StylePriority.UseTextAlignment = False
        Me.name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.name.Visible = False
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrRichText2})
        Me.GroupFooter1.Dpi = 254.0!
        Me.GroupFooter1.Height = 1186
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupFooter1.RepeatEveryPage = True
        '
        'countryname
        '
        Me.countryname.Dpi = 254.0!
        resources.ApplyResources(Me.countryname, "countryname")
        Me.countryname.Name = "countryname"
        Me.countryname.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.countryname.Scripts.OnBeforePrint = resources.GetString("countryname.Scripts.OnBeforePrint")
        Me.countryname.StylePriority.UseFont = False
        Me.countryname.StylePriority.UseTextAlignment = False
        Me.countryname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'postCodeAndCity
        '
        Me.postCodeAndCity.Dpi = 254.0!
        resources.ApplyResources(Me.postCodeAndCity, "postCodeAndCity")
        Me.postCodeAndCity.Name = "postCodeAndCity"
        Me.postCodeAndCity.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.postCodeAndCity.StylePriority.UseTextAlignment = False
        Me.postCodeAndCity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.postCodeAndCity.Visible = False
        '
        'nameResult
        '
        Me.nameResult.Dpi = 254.0!
        resources.ApplyResources(Me.nameResult, "nameResult")
        Me.nameResult.Name = "nameResult"
        Me.nameResult.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.nameResult.Scripts.OnBeforePrint = resources.GetString("nameResult.Scripts.OnBeforePrint")
        Me.nameResult.StylePriority.UseFont = False
        Me.nameResult.StylePriority.UseTextAlignment = False
        Me.nameResult.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrLabel3
        '
        Me.xrLabel3.Dpi = 254.0!
        resources.ApplyResources(Me.xrLabel3, "xrLabel3")
        Me.xrLabel3.Multiline = True
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UsePadding = False
        '
        'dataTable1
        '
        Me.dataTable1.CaseSensitive = False
        Me.dataTable1.Locale = New System.Globalization.CultureInfo("fr-BE")
        Me.dataTable1.Namespace = ""
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Dpi = 254.0!
        resources.ApplyResources(Me.xrPictureBox1, "xrPictureBox1")
        Me.xrPictureBox1.ImageUrl = "Z:\Bizkeys\Reports\logo_dvdpost_BE_CMJN.jpg"
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'postCodeAndCityResult
        '
        Me.postCodeAndCityResult.Dpi = 254.0!
        resources.ApplyResources(Me.postCodeAndCityResult, "postCodeAndCityResult")
        Me.postCodeAndCityResult.Name = "postCodeAndCityResult"
        Me.postCodeAndCityResult.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.postCodeAndCityResult.Scripts.OnBeforePrint = resources.GetString("postCodeAndCityResult.Scripts.OnBeforePrint")
        Me.postCodeAndCityResult.StylePriority.UseFont = False
        Me.postCodeAndCityResult.StylePriority.UseTextAlignment = False
        Me.postCodeAndCityResult.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.Dpi = 254.0!
        resources.ApplyResources(Me.XrPictureBox3, "XrPictureBox3")
        Me.XrPictureBox3.ImageUrl = "C:\Users\Igor\Desktop\header1.png"
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'addressCustomersResult
        '
        Me.addressCustomersResult.Dpi = 254.0!
        resources.ApplyResources(Me.addressCustomersResult, "addressCustomersResult")
        Me.addressCustomersResult.Name = "addressCustomersResult"
        Me.addressCustomersResult.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.addressCustomersResult.Scripts.OnBeforePrint = resources.GetString("addressCustomersResult.Scripts.OnBeforePrint")
        Me.addressCustomersResult.StylePriority.UseFont = False
        Me.addressCustomersResult.StylePriority.UseTextAlignment = False
        Me.addressCustomersResult.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'addressCustomers
        '
        Me.addressCustomers.Dpi = 254.0!
        resources.ApplyResources(Me.addressCustomers, "addressCustomers")
        Me.addressCustomers.Name = "addressCustomers"
        Me.addressCustomers.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.addressCustomers.StylePriority.UseTextAlignment = False
        Me.addressCustomers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.addressCustomers.Visible = False
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.countryname, Me.xrPictureBox1, Me.postCodeAndCityResult, Me.nameResult, Me.postCodeAndCity, Me.name, Me.addressCustomersResult, Me.addressCustomers, Me.XrPictureBox3})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("payment_offline_request_id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 751
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XtraReport2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataSource = Me.dataTable1
        Me.Dpi = 254.0!
        Me.ExportOptions.Csv.EncodingType = CType(resources.GetObject("XtraReport2.ExportOptions.Csv.EncodingType"), DevExpress.XtraPrinting.EncodingType)
        Me.ExportOptions.Html.CharacterSet = resources.GetString("XtraReport2.ExportOptions.Html.CharacterSet")
        Me.ExportOptions.Html.Title = resources.GetString("XtraReport2.ExportOptions.Html.Title")
        Me.ExportOptions.Mht.CharacterSet = resources.GetString("XtraReport2.ExportOptions.Mht.CharacterSet")
        Me.ExportOptions.Mht.Title = resources.GetString("XtraReport2.ExportOptions.Mht.Title")
        Me.ExportOptions.Pdf.DocumentOptions.Application = resources.GetString("XtraReport2.ExportOptions.Pdf.DocumentOptions.Application")
        Me.ExportOptions.Pdf.DocumentOptions.Author = resources.GetString("XtraReport2.ExportOptions.Pdf.DocumentOptions.Author")
        Me.ExportOptions.Pdf.DocumentOptions.Keywords = resources.GetString("XtraReport2.ExportOptions.Pdf.DocumentOptions.Keywords")
        Me.ExportOptions.Pdf.DocumentOptions.Subject = resources.GetString("XtraReport2.ExportOptions.Pdf.DocumentOptions.Subject")
        Me.ExportOptions.Pdf.DocumentOptions.Title = resources.GetString("XtraReport2.ExportOptions.Pdf.DocumentOptions.Title")
        Me.ExportOptions.Pdf.NeverEmbeddedFonts = "Microsoft Sans Serif"
        Me.ExportOptions.Text.EncodingType = CType(resources.GetObject("XtraReport2.ExportOptions.Text.EncodingType"), DevExpress.XtraPrinting.EncodingType)
        Me.ExportOptions.Xls.SheetName = resources.GetString("XtraReport2.ExportOptions.Xls.SheetName")
        Me.Margins = New System.Drawing.Printing.Margins(99, 0, 0, 0)
        Me.PageHeight = 2969
        Me.PageWidth = 2101
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "8.1"
        CType(Me.xrTextModel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xrTextModel1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents xrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents name As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents countryname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents postCodeAndCity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nameResult As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dataTable1 As System.Data.DataTable
    Friend WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents postCodeAndCityResult As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents addressCustomersResult As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents addressCustomers As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
End Class
