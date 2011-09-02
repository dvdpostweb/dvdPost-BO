<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMessagesTicket
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
        Me.GCHeaderMessage = New DevExpress.XtraEditors.GroupControl
        Me.lblSubject = New DevExpress.XtraEditors.LabelControl
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit
        Me.chksendMail = New DevExpress.XtraEditors.CheckEdit
        Me.lblUser = New DevExpress.XtraEditors.LabelControl
        Me.lblDate = New DevExpress.XtraEditors.LabelControl
        Me.chkRead = New DevExpress.XtraEditors.CheckEdit
        CType(Me.GCHeaderMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCHeaderMessage.SuspendLayout()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chksendMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRead.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCHeaderMessage
        '
        Me.GCHeaderMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCHeaderMessage.Controls.Add(Me.chkRead)
        Me.GCHeaderMessage.Controls.Add(Me.lblSubject)
        Me.GCHeaderMessage.Controls.Add(Me.txtSubject)
        Me.GCHeaderMessage.Controls.Add(Me.chksendMail)
        Me.GCHeaderMessage.Controls.Add(Me.lblUser)
        Me.GCHeaderMessage.Controls.Add(Me.lblDate)
        Me.GCHeaderMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.GCHeaderMessage.Location = New System.Drawing.Point(0, 0)
        Me.GCHeaderMessage.Name = "GCHeaderMessage"
        Me.GCHeaderMessage.Size = New System.Drawing.Size(904, 79)
        Me.GCHeaderMessage.TabIndex = 20
        Me.GCHeaderMessage.Text = "Message"
        '
        'lblSubject
        '
        Me.lblSubject.Location = New System.Drawing.Point(651, 28)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(28, 16)
        Me.lblSubject.TabIndex = 5
        Me.lblSubject.Text = "sujet"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(685, 25)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(214, 22)
        Me.txtSubject.TabIndex = 4
        '
        'chksendMail
        '
        Me.chksendMail.Location = New System.Drawing.Point(800, 51)
        Me.chksendMail.Name = "chksendMail"
        Me.chksendMail.Properties.Caption = "send mail"
        Me.chksendMail.Size = New System.Drawing.Size(104, 21)
        Me.chksendMail.TabIndex = 3
        '
        'lblUser
        '
        Me.lblUser.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Appearance.Options.UseFont = True
        Me.lblUser.Location = New System.Drawing.Point(573, 50)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(59, 22)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User_id"
        '
        'lblDate
        '
        Me.lblDate.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Appearance.Options.UseFont = True
        Me.lblDate.Location = New System.Drawing.Point(62, 50)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 22)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "date"
        '
        'chkRead
        '
        Me.chkRead.Location = New System.Drawing.Point(16, 26)
        Me.chkRead.Name = "chkRead"
        Me.chkRead.Properties.Caption = "read"
        Me.chkRead.Size = New System.Drawing.Size(67, 21)
        Me.chkRead.TabIndex = 6
        '
        'ucMessagesTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.GCHeaderMessage)
        Me.Name = "ucMessagesTicket"
        Me.Size = New System.Drawing.Size(904, 79)
        CType(Me.GCHeaderMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCHeaderMessage.ResumeLayout(False)
        Me.GCHeaderMessage.PerformLayout()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chksendMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRead.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MessageTicketHtml As System.Windows.Forms.WebBrowser
    Friend WithEvents GCHeaderMessage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NewMessageTicketHtml As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chksendMail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblSubject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkRead As DevExpress.XtraEditors.CheckEdit

End Class
