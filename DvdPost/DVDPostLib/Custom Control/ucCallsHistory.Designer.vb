<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCallsHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlCallQuestionnaire = New DevExpress.XtraEditors.PanelControl
        Me.btnFinish = New DevExpress.XtraEditors.SimpleButton
        Me.btnSuivant = New DevExpress.XtraEditors.SimpleButton
        Me.btnPrec = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.rgCallDetail = New DevExpress.XtraEditors.RadioGroup
        Me.pnlCallData = New DevExpress.XtraEditors.PanelControl
        Me.memCallComment = New DevExpress.XtraEditors.MemoEdit
        Me.lblCallComment = New DevExpress.XtraEditors.LabelControl
        Me.lblcallContact = New DevExpress.XtraEditors.LabelControl
        Me.rgContact = New DevExpress.XtraEditors.RadioGroup
        Me.txtCallEndDate = New DevExpress.XtraEditors.TextEdit
        Me.lblCallEndDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCallStartDate = New DevExpress.XtraEditors.TextEdit
        Me.lblCallStartDate = New DevExpress.XtraEditors.LabelControl
        Me.txtCallReconduction = New DevExpress.XtraEditors.TextEdit
        Me.lblCallReconduction = New DevExpress.XtraEditors.LabelControl
        Me.lblCallFt = New DevExpress.XtraEditors.LabelControl
        Me.chkCallFt = New DevExpress.XtraEditors.CheckEdit
        Me.txtCallCustomers_id = New DevExpress.XtraEditors.TextEdit
        Me.lblCallCustomers_id = New DevExpress.XtraEditors.LabelControl
        Me.btnCallNew = New DevExpress.XtraEditors.SimpleButton
        Me.pnlCallHistory = New System.Windows.Forms.Panel
        Me.GridCallHistory = New DevExpress.XtraGrid.GridControl
        Me.GridViewCallHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDateStart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndStart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblCallValues = New DevExpress.XtraEditors.LabelControl
        CType(Me.pnlCallQuestionnaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCallQuestionnaire.SuspendLayout()
        CType(Me.rgCallDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCallData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCallData.SuspendLayout()
        CType(Me.memCallComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallReconduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCallFt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCallCustomers_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCallHistory.SuspendLayout()
        CType(Me.GridCallHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCallHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCallQuestionnaire
        '
        Me.pnlCallQuestionnaire.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCallQuestionnaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pnlCallQuestionnaire.Controls.Add(Me.btnFinish)
        Me.pnlCallQuestionnaire.Controls.Add(Me.btnSuivant)
        Me.pnlCallQuestionnaire.Controls.Add(Me.btnPrec)
        Me.pnlCallQuestionnaire.Controls.Add(Me.lblTitle)
        Me.pnlCallQuestionnaire.Controls.Add(Me.rgCallDetail)
        Me.pnlCallQuestionnaire.Location = New System.Drawing.Point(267, 35)
        Me.pnlCallQuestionnaire.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCallQuestionnaire.Name = "pnlCallQuestionnaire"
        Me.pnlCallQuestionnaire.Size = New System.Drawing.Size(824, 399)
        Me.pnlCallQuestionnaire.TabIndex = 3
        Me.pnlCallQuestionnaire.Visible = False
        '
        'btnFinish
        '
        Me.btnFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinish.Location = New System.Drawing.Point(134, 314)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(552, 30)
        Me.btnFinish.TabIndex = 40
        Me.btnFinish.Text = "FIN"
        '
        'btnSuivant
        '
        Me.btnSuivant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSuivant.Location = New System.Drawing.Point(758, 314)
        Me.btnSuivant.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(56, 30)
        Me.btnSuivant.TabIndex = 39
        Me.btnSuivant.Text = "suivant"
        '
        'btnPrec
        '
        Me.btnPrec.Location = New System.Drawing.Point(8, 314)
        Me.btnPrec.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrec.Name = "btnPrec"
        Me.btnPrec.Size = New System.Drawing.Size(63, 30)
        Me.btnPrec.TabIndex = 38
        Me.btnPrec.Text = "prec"
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(28, 19)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(18, 13)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "title"
        '
        'rgCallDetail
        '
        Me.rgCallDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgCallDetail.AutoSizeInLayoutControl = True
        Me.rgCallDetail.Location = New System.Drawing.Point(8, 43)
        Me.rgCallDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.rgCallDetail.Name = "rgCallDetail"
        Me.rgCallDetail.Size = New System.Drawing.Size(806, 266)
        Me.rgCallDetail.TabIndex = 36
        '
        'pnlCallData
        '
        Me.pnlCallData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pnlCallData.Controls.Add(Me.memCallComment)
        Me.pnlCallData.Controls.Add(Me.lblCallComment)
        Me.pnlCallData.Controls.Add(Me.lblcallContact)
        Me.pnlCallData.Controls.Add(Me.rgContact)
        Me.pnlCallData.Controls.Add(Me.txtCallEndDate)
        Me.pnlCallData.Controls.Add(Me.lblCallEndDate)
        Me.pnlCallData.Controls.Add(Me.txtCallStartDate)
        Me.pnlCallData.Controls.Add(Me.lblCallStartDate)
        Me.pnlCallData.Controls.Add(Me.txtCallReconduction)
        Me.pnlCallData.Controls.Add(Me.lblCallReconduction)
        Me.pnlCallData.Controls.Add(Me.lblCallFt)
        Me.pnlCallData.Controls.Add(Me.chkCallFt)
        Me.pnlCallData.Controls.Add(Me.txtCallCustomers_id)
        Me.pnlCallData.Controls.Add(Me.lblCallCustomers_id)
        Me.pnlCallData.Location = New System.Drawing.Point(2, 33)
        Me.pnlCallData.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCallData.Name = "pnlCallData"
        Me.pnlCallData.Size = New System.Drawing.Size(256, 403)
        Me.pnlCallData.TabIndex = 2
        Me.pnlCallData.Visible = False
        '
        'memCallComment
        '
        Me.memCallComment.Location = New System.Drawing.Point(5, 238)
        Me.memCallComment.Margin = New System.Windows.Forms.Padding(2)
        Me.memCallComment.Name = "memCallComment"
        Me.memCallComment.Size = New System.Drawing.Size(247, 161)
        Me.memCallComment.TabIndex = 38
        '
        'lblCallComment
        '
        Me.lblCallComment.Location = New System.Drawing.Point(8, 220)
        Me.lblCallComment.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallComment.Name = "lblCallComment"
        Me.lblCallComment.Size = New System.Drawing.Size(43, 13)
        Me.lblCallComment.TabIndex = 37
        Me.lblCallComment.Text = "comment"
        '
        'lblcallContact
        '
        Me.lblcallContact.Location = New System.Drawing.Point(5, 149)
        Me.lblcallContact.Margin = New System.Windows.Forms.Padding(2)
        Me.lblcallContact.Name = "lblcallContact"
        Me.lblcallContact.Size = New System.Drawing.Size(36, 13)
        Me.lblcallContact.TabIndex = 36
        Me.lblcallContact.Text = "contact"
        '
        'rgContact
        '
        Me.rgContact.Location = New System.Drawing.Point(82, 149)
        Me.rgContact.Margin = New System.Windows.Forms.Padding(2)
        Me.rgContact.Name = "rgContact"
        Me.rgContact.Size = New System.Drawing.Size(109, 78)
        Me.rgContact.TabIndex = 35
        '
        'txtCallEndDate
        '
        Me.txtCallEndDate.Enabled = False
        Me.txtCallEndDate.Location = New System.Drawing.Point(82, 119)
        Me.txtCallEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCallEndDate.Name = "txtCallEndDate"
        Me.txtCallEndDate.Properties.ReadOnly = True
        Me.txtCallEndDate.Size = New System.Drawing.Size(109, 20)
        Me.txtCallEndDate.TabIndex = 34
        '
        'lblCallEndDate
        '
        Me.lblCallEndDate.Location = New System.Drawing.Point(4, 121)
        Me.lblCallEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallEndDate.Name = "lblCallEndDate"
        Me.lblCallEndDate.Size = New System.Drawing.Size(46, 13)
        Me.lblCallEndDate.TabIndex = 33
        Me.lblCallEndDate.Text = "end_date"
        '
        'txtCallStartDate
        '
        Me.txtCallStartDate.Enabled = False
        Me.txtCallStartDate.Location = New System.Drawing.Point(82, 89)
        Me.txtCallStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCallStartDate.Name = "txtCallStartDate"
        Me.txtCallStartDate.Properties.ReadOnly = True
        Me.txtCallStartDate.Size = New System.Drawing.Size(109, 20)
        Me.txtCallStartDate.TabIndex = 32
        '
        'lblCallStartDate
        '
        Me.lblCallStartDate.Location = New System.Drawing.Point(4, 91)
        Me.lblCallStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallStartDate.Name = "lblCallStartDate"
        Me.lblCallStartDate.Size = New System.Drawing.Size(51, 13)
        Me.lblCallStartDate.TabIndex = 31
        Me.lblCallStartDate.Text = "start_date"
        '
        'txtCallReconduction
        '
        Me.txtCallReconduction.Enabled = False
        Me.txtCallReconduction.Location = New System.Drawing.Point(82, 61)
        Me.txtCallReconduction.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCallReconduction.Name = "txtCallReconduction"
        Me.txtCallReconduction.Properties.ReadOnly = True
        Me.txtCallReconduction.Size = New System.Drawing.Size(109, 20)
        Me.txtCallReconduction.TabIndex = 30
        '
        'lblCallReconduction
        '
        Me.lblCallReconduction.Location = New System.Drawing.Point(4, 63)
        Me.lblCallReconduction.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallReconduction.Name = "lblCallReconduction"
        Me.lblCallReconduction.Size = New System.Drawing.Size(81, 13)
        Me.lblCallReconduction.TabIndex = 29
        Me.lblCallReconduction.Text = "Nb reconduction "
        '
        'lblCallFt
        '
        Me.lblCallFt.Location = New System.Drawing.Point(5, 43)
        Me.lblCallFt.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallFt.Name = "lblCallFt"
        Me.lblCallFt.Size = New System.Drawing.Size(12, 13)
        Me.lblCallFt.TabIndex = 9
        Me.lblCallFt.Text = "FT"
        '
        'chkCallFt
        '
        Me.chkCallFt.Location = New System.Drawing.Point(81, 41)
        Me.chkCallFt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCallFt.Name = "chkCallFt"
        Me.chkCallFt.Properties.Caption = ""
        Me.chkCallFt.Size = New System.Drawing.Size(110, 19)
        Me.chkCallFt.TabIndex = 8
        '
        'txtCallCustomers_id
        '
        Me.txtCallCustomers_id.Enabled = False
        Me.txtCallCustomers_id.Location = New System.Drawing.Point(82, 14)
        Me.txtCallCustomers_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCallCustomers_id.Name = "txtCallCustomers_id"
        Me.txtCallCustomers_id.Properties.ReadOnly = True
        Me.txtCallCustomers_id.Size = New System.Drawing.Size(109, 20)
        Me.txtCallCustomers_id.TabIndex = 7
        '
        'lblCallCustomers_id
        '
        Me.lblCallCustomers_id.Location = New System.Drawing.Point(5, 16)
        Me.lblCallCustomers_id.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallCustomers_id.Name = "lblCallCustomers_id"
        Me.lblCallCustomers_id.Size = New System.Drawing.Size(60, 13)
        Me.lblCallCustomers_id.TabIndex = 6
        Me.lblCallCustomers_id.Text = "Customer ID"
        '
        'btnCallNew
        '
        Me.btnCallNew.Location = New System.Drawing.Point(335, 2)
        Me.btnCallNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCallNew.Name = "btnCallNew"
        Me.btnCallNew.Size = New System.Drawing.Size(98, 30)
        Me.btnCallNew.TabIndex = 41
        Me.btnCallNew.Text = "Appel"
        '
        'pnlCallHistory
        '
        Me.pnlCallHistory.Controls.Add(Me.pnlCallData)
        Me.pnlCallHistory.Location = New System.Drawing.Point(2, 2)
        Me.pnlCallHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCallHistory.Name = "pnlCallHistory"
        Me.pnlCallHistory.Size = New System.Drawing.Size(261, 432)
        Me.pnlCallHistory.TabIndex = 42
        '
        'GridCallHistory
        '
        Me.GridCallHistory.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridCallHistory.EmbeddedNavigator.Name = ""
        Me.GridCallHistory.FormsUseDefaultLookAndFeel = False
        Me.GridCallHistory.Location = New System.Drawing.Point(0, 438)
        Me.GridCallHistory.MainView = Me.GridViewCallHistory
        Me.GridCallHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.GridCallHistory.Name = "GridCallHistory"
        Me.GridCallHistory.Size = New System.Drawing.Size(837, 148)
        Me.GridCallHistory.TabIndex = 0
        Me.GridCallHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCallHistory, Me.GridView2})
        '
        'GridViewCallHistory
        '
        Me.GridViewCallHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDateStart, Me.colEndStart, Me.colUserName, Me.colComment})
        Me.GridViewCallHistory.GridControl = Me.GridCallHistory
        Me.GridViewCallHistory.Name = "GridViewCallHistory"
        Me.GridViewCallHistory.OptionsBehavior.Editable = False
        Me.GridViewCallHistory.OptionsView.ColumnAutoWidth = False
        '
        'colDateStart
        '
        Me.colDateStart.Caption = "start"
        Me.colDateStart.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateStart.FieldName = "start_date"
        Me.colDateStart.Name = "colDateStart"
        Me.colDateStart.OptionsColumn.AllowEdit = False
        Me.colDateStart.OptionsColumn.ReadOnly = True
        Me.colDateStart.Visible = True
        Me.colDateStart.VisibleIndex = 0
        Me.colDateStart.Width = 105
        '
        'colEndStart
        '
        Me.colEndStart.Caption = "End"
        Me.colEndStart.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.colEndStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndStart.FieldName = "end_date"
        Me.colEndStart.Name = "colEndStart"
        Me.colEndStart.OptionsColumn.AllowEdit = False
        Me.colEndStart.OptionsColumn.ReadOnly = True
        Me.colEndStart.Visible = True
        Me.colEndStart.VisibleIndex = 3
        Me.colEndStart.Width = 104
        '
        'colUserName
        '
        Me.colUserName.Caption = "user"
        Me.colUserName.FieldName = "FullName"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.OptionsColumn.AllowEdit = False
        Me.colUserName.OptionsColumn.ReadOnly = True
        Me.colUserName.Visible = True
        Me.colUserName.VisibleIndex = 2
        Me.colUserName.Width = 100
        '
        'colComment
        '
        Me.colComment.Caption = "comment"
        Me.colComment.FieldName = "comment"
        Me.colComment.Name = "colComment"
        Me.colComment.OptionsColumn.AllowEdit = False
        Me.colComment.OptionsColumn.ReadOnly = True
        Me.colComment.ToolTip = "comment"
        Me.colComment.Visible = True
        Me.colComment.VisibleIndex = 1
        Me.colComment.Width = 145
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridCallHistory
        Me.GridView2.Name = "GridView2"
        '
        'lblCallValues
        '
        Me.lblCallValues.Location = New System.Drawing.Point(506, 11)
        Me.lblCallValues.Margin = New System.Windows.Forms.Padding(2)
        Me.lblCallValues.Name = "lblCallValues"
        Me.lblCallValues.Size = New System.Drawing.Size(58, 13)
        Me.lblCallValues.TabIndex = 41
        Me.lblCallValues.Text = "lblCallValues"
        '
        'ucCallsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.GridCallHistory)
        Me.Controls.Add(Me.pnlCallQuestionnaire)
        Me.Controls.Add(Me.lblCallValues)
        Me.Controls.Add(Me.pnlCallHistory)
        Me.Controls.Add(Me.btnCallNew)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(956, 470)
        Me.Name = "ucCallsHistory"
        Me.Size = New System.Drawing.Size(1100, 588)
        CType(Me.pnlCallQuestionnaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCallQuestionnaire.ResumeLayout(False)
        Me.pnlCallQuestionnaire.PerformLayout()
        CType(Me.rgCallDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlCallData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCallData.ResumeLayout(False)
        Me.pnlCallData.PerformLayout()
        CType(Me.memCallComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallReconduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCallFt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCallCustomers_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCallHistory.ResumeLayout(False)
        CType(Me.GridCallHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCallHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCallQuestionnaire As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFinish As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSuivant As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgCallDetail As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents pnlCallData As DevExpress.XtraEditors.PanelControl
    Friend WithEvents memCallComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblCallComment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblcallContact As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgContact As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCallEndDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCallStartDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCallReconduction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallReconduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCallFt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCallFt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCallCustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCallCustomers_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCallNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlCallHistory As System.Windows.Forms.Panel
    Friend WithEvents GridCallHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCallHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCallValues As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colDateStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComment As DevExpress.XtraGrid.Columns.GridColumn

End Class
