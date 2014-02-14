<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport3
    Inherits DVDPostLib.XtraReport2

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
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'XtraReport3
        '
        Me.ExportOptions.Csv.EncodingType = DevExpress.XtraPrinting.EncodingType.[Unicode]
        Me.ExportOptions.Pdf.NeverEmbeddedFonts = "Microsoft Sans Serif"
        Me.ExportOptions.Text.EncodingType = DevExpress.XtraPrinting.EncodingType.UTF32
        Me.Version = "8.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
