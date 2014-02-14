<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
        Me.countryname = New DevExpress.XtraReports.UI.XRLabel
        Me.postCodeAndCity = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.postCodeAndCityResult = New DevExpress.XtraReports.UI.XRLabel
        Me.nameResult = New DevExpress.XtraReports.UI.XRLabel
        Me.name = New DevExpress.XtraReports.UI.XRLabel
        Me.addressCustomersResult = New DevExpress.XtraReports.UI.XRLabel
        Me.addressCustomers = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.xrRichText2 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrTextModel1 = New DevExpress.XtraReports.UI.XRRichText
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.dataTable1 = New System.Data.DataTable
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTextModel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'countryname
        '
        Me.countryname.Dpi = 254.0!
        Me.countryname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.countryname.Location = New System.Drawing.Point(783, 600)
        Me.countryname.Name = "countryname"
        Me.countryname.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.countryname.Scripts.OnBeforePrint = resources.GetString("countryname.Scripts.OnBeforePrint")
        Me.countryname.Size = New System.Drawing.Size(870, 42)
        Me.countryname.StylePriority.UseFont = False
        Me.countryname.StylePriority.UseTextAlignment = False
        Me.countryname.Text = "$$$country_name$$$"
        Me.countryname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'postCodeAndCity
        '
        Me.postCodeAndCity.Dpi = 254.0!
        Me.postCodeAndCity.Location = New System.Drawing.Point(1230, 558)
        Me.postCodeAndCity.Name = "postCodeAndCity"
        Me.postCodeAndCity.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.postCodeAndCity.Size = New System.Drawing.Size(423, 42)
        Me.postCodeAndCity.StylePriority.UseTextAlignment = False
        Me.postCodeAndCity.Text = "$$$postCodeAndCity$$$"
        Me.postCodeAndCity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.postCodeAndCity.Visible = False
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.Dpi = 254.0!
        Me.XrPictureBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrPictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.Size = New System.Drawing.Size(2000, 741)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox3, Me.xrPictureBox1, Me.countryname, Me.postCodeAndCityResult, Me.nameResult, Me.postCodeAndCity, Me.name, Me.addressCustomersResult, Me.addressCustomers})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("payment_offline_request_id", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 746
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Dpi = 254.0!
        Me.xrPictureBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.xrPictureBox1.ImageUrl = "Z:\Bizkeys\Reports\logo_dvdpost_BE_CMJN.jpg"
        Me.xrPictureBox1.Location = New System.Drawing.Point(177, 82)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.Size = New System.Drawing.Size(564, 222)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'postCodeAndCityResult
        '
        Me.postCodeAndCityResult.Dpi = 254.0!
        Me.postCodeAndCityResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.postCodeAndCityResult.Location = New System.Drawing.Point(1077, 558)
        Me.postCodeAndCityResult.Name = "postCodeAndCityResult"
        Me.postCodeAndCityResult.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.postCodeAndCityResult.Scripts.OnBeforePrint = resources.GetString("postCodeAndCityResult.Scripts.OnBeforePrint")
        Me.postCodeAndCityResult.Size = New System.Drawing.Size(577, 42)
        Me.postCodeAndCityResult.StylePriority.UseFont = False
        Me.postCodeAndCityResult.StylePriority.UseTextAlignment = False
        Me.postCodeAndCityResult.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'nameResult
        '
        Me.nameResult.Dpi = 254.0!
        Me.nameResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.nameResult.Location = New System.Drawing.Point(783, 468)
        Me.nameResult.Name = "nameResult"
        Me.nameResult.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.nameResult.Scripts.OnBeforePrint = resources.GetString("nameResult.Scripts.OnBeforePrint")
        Me.nameResult.Size = New System.Drawing.Size(873, 42)
        Me.nameResult.StylePriority.UseFont = False
        Me.nameResult.StylePriority.UseTextAlignment = False
        Me.nameResult.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'name
        '
        Me.name.Dpi = 254.0!
        Me.name.Location = New System.Drawing.Point(1169, 468)
        Me.name.Multiline = True
        Me.name.Name = "name"
        Me.name.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.name.Size = New System.Drawing.Size(487, 42)
        Me.name.StylePriority.UseTextAlignment = False
        Me.name.Text = "$$$name$$$"
        Me.name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.name.Visible = False
        '
        'addressCustomersResult
        '
        Me.addressCustomersResult.Dpi = 254.0!
        Me.addressCustomersResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.addressCustomersResult.Location = New System.Drawing.Point(783, 516)
        Me.addressCustomersResult.Name = "addressCustomersResult"
        Me.addressCustomersResult.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.addressCustomersResult.Scripts.OnBeforePrint = resources.GetString("addressCustomersResult.Scripts.OnBeforePrint")
        Me.addressCustomersResult.Size = New System.Drawing.Size(870, 42)
        Me.addressCustomersResult.StylePriority.UseFont = False
        Me.addressCustomersResult.StylePriority.UseTextAlignment = False
        Me.addressCustomersResult.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'addressCustomers
        '
        Me.addressCustomers.Dpi = 254.0!
        Me.addressCustomers.Location = New System.Drawing.Point(783, 516)
        Me.addressCustomers.Name = "addressCustomers"
        Me.addressCustomers.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.addressCustomers.Size = New System.Drawing.Size(868, 42)
        Me.addressCustomers.StylePriority.UseTextAlignment = False
        Me.addressCustomers.Text = "$$$addressCustomers$$$"
        Me.addressCustomers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.addressCustomers.Visible = False
        '
        'xrLabel3
        '
        Me.xrLabel3.Dpi = 254.0!
        Me.xrLabel3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.xrLabel3.Location = New System.Drawing.Point(42, 0)
        Me.xrLabel3.Multiline = True
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrLabel3.Size = New System.Drawing.Size(1910, 254)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UsePadding = False
        Me.xrLabel3.Text = "Please, do not hesitate to contact us if you have any questions." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kind regards," & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DVDPost " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'xrRichText2
        '
        Me.xrRichText2.Dpi = 254.0!
        Me.xrRichText2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.xrRichText2.Location = New System.Drawing.Point(42, 1037)
        Me.xrRichText2.Name = "xrRichText2"
        Me.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString")
        Me.xrRichText2.Size = New System.Drawing.Size(1926, 85)
        Me.xrRichText2.StylePriority.UseFont = False
        Me.xrRichText2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrTextModel1
        '
        Me.xrTextModel1.BackColor = System.Drawing.Color.Transparent
        Me.xrTextModel1.CanGrow = False
        Me.xrTextModel1.Dpi = 254.0!
        Me.xrTextModel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.xrTextModel1.ForeColor = System.Drawing.Color.Black
        Me.xrTextModel1.Location = New System.Drawing.Point(42, 3)
        Me.xrTextModel1.Name = "xrTextModel1"
        Me.xrTextModel1.SerializableRtfString = resources.GetString("xrTextModel1.SerializableRtfString")
        Me.xrTextModel1.Size = New System.Drawing.Size(1905, 971)
        Me.xrTextModel1.StylePriority.UseFont = False
        Me.xrTextModel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.BackColor = System.Drawing.Color.Transparent
        Me.xrPageInfo1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrPageInfo1.BorderWidth = 1
        Me.xrPageInfo1.Dpi = 254.0!
        Me.xrPageInfo1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.xrPageInfo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xrPageInfo1.Format = "{0:dd/MM/yyyy}"
        Me.xrPageInfo1.Location = New System.Drawing.Point(1400, 71)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.Size = New System.Drawing.Size(254, 42)
        Me.xrPageInfo1.StylePriority.UseFont = False
        Me.xrPageInfo1.StylePriority.UsePadding = False
        Me.xrPageInfo1.StylePriority.UseTextAlignment = False
        Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrTextModel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Detail.Height = 1016
        Me.Detail.Name = "Detail"
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.StylePriority.UseFont = False
        '
        'dataTable1
        '
        Me.dataTable1.CaseSensitive = False
        Me.dataTable1.Locale = New System.Globalization.CultureInfo("fr-BE")
        Me.dataTable1.Namespace = ""
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataSource = Me.dataTable1
        Me.Dpi = 254.0!
        Me.ExportOptions.Csv.EncodingType = DevExpress.XtraPrinting.EncodingType.[Unicode]
        Me.ExportOptions.Text.EncodingType = DevExpress.XtraPrinting.EncodingType.UTF32
        Me.Margins = New System.Drawing.Printing.Margins(99, 0, 0, 0)
        Me.PageHeight = 2969
        Me.PageWidth = 2101
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "8.1"
        CType(Me.xrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTextModel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents countryname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents postCodeAndCity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents postCodeAndCityResult As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nameResult As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents name As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents addressCustomersResult As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents addressCustomers As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents xrTextModel1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents dataTable1 As System.Data.DataTable
End Class
