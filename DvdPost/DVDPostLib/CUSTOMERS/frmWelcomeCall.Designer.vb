<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcomeCall
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GridcallMeBrowse = New DevExpress.XtraGrid.GridControl
        Me.GridViewCallMeBrowse = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridcallMeBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCallMeBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridcallMeBrowse
        '
        Me.GridcallMeBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridcallMeBrowse.EmbeddedNavigator.Name = ""
        Me.GridcallMeBrowse.FormsUseDefaultLookAndFeel = False
        Me.GridcallMeBrowse.Location = New System.Drawing.Point(0, 30)
        Me.GridcallMeBrowse.MainView = Me.GridViewCallMeBrowse
        Me.GridcallMeBrowse.Name = "GridcallMeBrowse"
        Me.GridcallMeBrowse.Size = New System.Drawing.Size(1160, 552)
        Me.GridcallMeBrowse.TabIndex = 5
        Me.GridcallMeBrowse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCallMeBrowse})
        '
        'GridViewCallMeBrowse
        '
        Me.GridViewCallMeBrowse.ActiveFilterEnabled = False
        Me.GridViewCallMeBrowse.GridControl = Me.GridcallMeBrowse
        Me.GridViewCallMeBrowse.Name = "GridViewCallMeBrowse"
        '
        'frmWelcomeCall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 582)
        Me.Controls.Add(Me.GridcallMeBrowse)
        Me.Name = "frmWelcomeCall"
        Me.Text = "frmWelcomeCall"
        Me.Controls.SetChildIndex(Me.GridcallMeBrowse, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridcallMeBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCallMeBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridcallMeBrowse As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCallMeBrowse As DevExpress.XtraGrid.Views.Grid.GridView
End Class
