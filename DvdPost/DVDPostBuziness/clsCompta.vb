Public Class clsCompta
    'Inherits BizzLib.clsBKGenericClass

    'Public Const DVDPOST_BANK_ACCOUNT_ING_1 As String = "310168751895"
    Public Const DVDPOST_BANK_ACCOUNT_ING As String = "310191369467"
    Public Const DVDPOST_ACCOUNT_DEXIA As String = "068241688661"
    Public Const KEY_ESKERLOADER As String = "Path_EskerLoader"
    Public Const SEND_EMAIL_AND_LETTER As String = "SendEmailAndLetter"

    'Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
    '    'Add any initialization after the InitializeComponent() call
    '    SetBKOjects(CurrentSessionInfo)
    'End Sub
    Public Shared Function getMOD97OnTwoChars(ByRef value As Long) As String
        Dim num As Integer = CInt((value Mod &H61))
        If (num = 0) Then
            num = &H61
        End If
        Return num.ToString().PadLeft(2, "0"c)
    End Function

    Public Shared Function CreateCommunicationStruct(ByVal id As Integer, ByVal typePaymentCommunication As Integer) As String
        Dim s As String = id.ToString.PadLeft(9, "0"c)
        s = (typePaymentCommunication & s)
        Dim num As Long = Long.Parse(s)
        Return (s & getMOD97OnTwoChars((num)))
    End Function


    Public Class clsPayment
        ' Inherits BizzLib.clsBKGenericClass
        'Public PaymentType As PaymentTypeList
        Private sql As String
        Public REASON_PK_NAME As String = ""


        'Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo) ', ByVal vPaymentType As PaymentTypeList)
        '    SetBKOjects(CurrentSessionInfo)


        'End Sub

    End Class


    Friend Sub ForcedUpdateStepStatus(ByVal old_status As DvdPostData.PaymentOfflineData.StepPayment, ByVal new_status As DvdPostData.PaymentOfflineData.StepPayment, ByVal payment_offline_request_id As Integer)
        DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.ForcedUpdateStatus(payment_offline_request_id, new_status, old_status))
    End Sub

    Friend Sub ForcedUpdateAllCustomerStepStatus(ByVal old_status As Integer, ByVal new_status As Integer)
        DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.ForcedUpdateAllCustomerStatus(old_status, new_status))
    End Sub

    Friend Sub designReport()

        Dim report As New DevExpress.XtraReports.UI.XtraReport
        Dim ex As New DevExpress.XtraReports.UserDesigner.XRDesignFormEx
        ' Dim path As String = rowReport("ReportPath")

        'report.LoadLayout(path & "\\" & rowReport("Name") & ".repx")
        ' report.DataSource = dvCust.ToTable()
        ex.OpenReport(report)
        'ex.FileName = path
        ex.Show()
        'report.ShowDesigner()

    End Sub


    Friend Sub designReport(ByVal dvCust As DataView, ByVal rowReport As DataRow)

        Dim report As New DevExpress.XtraReports.UI.XtraReport

        Dim path As String = rowReport("ReportPath")
        Dim reportName As String = rowReport("name")
        Dim pathEsker As String
        Dim strdateFormat As String
        Dim saveFileDialog As Windows.Forms.SaveFileDialog
        report.LoadLayout(path & "\\" & rowReport("Name") & ".repx")
        report.DataSource = dvCust.ToTable()
        ' report.Name = "_" & Convert.ToString(Format(Date.Now, "yyyyMMdd")) & "_" & reportName
        'ex.OpenReport(report)
        'ex.FileName = path
        'ex.Show()
        'report.ShowDesigner()

        Dim pdfOptions As DevExpress.XtraPrinting.PdfExportOptions = report.ExportOptions.Pdf
        pdfOptions.Compressed = True
        pdfOptions.NeverEmbeddedFonts = "Microsoft Sans Serif"
        strdateFormat = Convert.ToString(Format(Date.Now, "yyyyMMdd"))
        report.Name = reportName & "_" & strdateFormat


        Try
            'report.ShowDesigner()
            'report.ShowPreview()

            'report.ExportToPdf("C:\Documents and Settings\gauthier\Bureau\" & Convert.ToString(Format(Date.Now, "yyyyMMdd")) & "_" & reportName & ".pdf")
            Dim filename As String = strdateFormat & "_" & reportName

            If DvdPostData.clsSession.isBatch Then
                pathEsker = System.Configuration.ConfigurationManager.AppSettings(KEY_ESKERLOADER)
                If System.IO.Directory.Exists(pathEsker) Then
                    report.ExportToPdf(pathEsker & filename & ".pdf")
                Else
                    clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Report, "ERROR path EskerLoader")
                End If
            Else
                saveFileDialog = New Windows.Forms.SaveFileDialog()
                saveFileDialog.Filter = "pdf (*.pdf)|*.pdf "
                saveFileDialog.FileName = filename
                If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    report.ExportToPdf(saveFileDialog.FileName)
                End If
            End If

            DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.getInsertLetter_ToPost(dvCust.Item(0).Row.Item("customers_id"), dvCust.Item(0).Row.Item("id"), filename & ".pdf"))

        Catch e As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Report, e)
            clsMsgError.MsgBox(e.Message)
        End Try
    End Sub

    Friend Sub designReportAndSendEmail(ByVal dtOneCust As DataView, ByVal rowReport As DataRow)

        Dim report As New DevExpress.XtraReports.UI.XtraReport

        Dim path As String = rowReport("ReportPath")
        Dim reportName As String = rowReport("name")
        Dim pathEsker As String
        Dim strdateFormat As String
        Dim saveFileDialog As Windows.Forms.SaveFileDialog
        report.LoadLayout(path & "\\" & rowReport("Name") & ".repx")
        report.DataSource = dtOneCust.ToTable()
        ' report.Name = "_" & Convert.ToString(Format(Date.Now, "yyyyMMdd")) & "_" & reportName
        'ex.OpenReport(report)
        'ex.FileName = path
        'ex.Show()
        'report.ShowDesigner()

        Dim pdfOptions As DevExpress.XtraPrinting.PdfExportOptions = report.ExportOptions.Pdf
        pdfOptions.Compressed = True
        pdfOptions.NeverEmbeddedFonts = "Microsoft Sans Serif"
        strdateFormat = Convert.ToString(Format(Date.Now, "yyyyMMdd"))
        report.Name = reportName & "_" & strdateFormat & "_" & dtOneCust.ToTable().Rows(0)("customers_id")

        Try
            'report.ShowDesigner()
            'report.ShowPreview()

            'report.ExportToPdf("C:\Documents and Settings\gauthier\Bureau\" & Convert.ToString(Format(Date.Now, "yyyyMMdd")) & "_" & reportName & ".pdf")
            Dim filename As String = strdateFormat & "_" & reportName & "_" & dtOneCust.ToTable().Rows(0)("customers_id")

            If DvdPostData.clsSession.isBatch Then
                pathEsker = System.Configuration.ConfigurationManager.AppSettings(SEND_EMAIL_AND_LETTER)
                If System.IO.Directory.Exists(pathEsker) Then
                    report.ExportToPdf(pathEsker & filename & ".pdf")

                Else
                    clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Report, "ERROR path SEND_EMAIL_AND_LETTER")
                End If
                Dim ok As Boolean
                'For Each rCustomer As DataRow In dtCustomers.Rows

                ok = clsMail.SendMailWithAttachement(dtOneCust.ToTable().Rows(0), pathEsker & filename & ".pdf", DVDPostBuziness.clsMail.Mail.MAIL_VIRMAN)
                If Not ok Then
                    clsMsgError.MsgBox("mail to customers_id " & dtOneCust.ToTable().Rows(0)("customers_id") & " not sent ")
                End If
                'Return
                'ForcedUpdateStepStatus(stepCurrent, rCustomer("id"))

                'Next
                clsMsgError.MsgBox("sending mails for mail_id finished: OK = " & ok.ToString())
            Else
                saveFileDialog = New Windows.Forms.SaveFileDialog()
                saveFileDialog.Filter = "pdf (*.pdf)|*.pdf "
                saveFileDialog.FileName = filename
                If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    report.ExportToPdf(saveFileDialog.FileName)
                End If
            End If

        Catch e As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Report, e)
            clsMsgError.MsgBox(e.Message)
        End Try
    End Sub

    Public Sub sendLetter(ByVal dtCustomers As DataTable, ByVal report_id As Integer, Optional ByVal suspended As Boolean = False)
        Dim dvCust As DataView
        Dim dtReport As New DataTable

        dtReport = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetReport(report_id))
        If dtReport.Rows.Count > 0 Then

            For lang As Integer = 1 To 3
                dvCust = New DataView(dtCustomers, "customers_language = " & lang, "customers_id ", DataViewRowState.CurrentRows)
                If dvCust.Count > 0 Then
                    designReport(dvCust, dtReport.Rows(lang - 1))

                    If suspended Then

                        For Each drv As DataRowView In dvCust
                            If suspended Then
                                DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsCustomersData.GetUpdateSuspendedCustomers(drv("customers_id")))
                            End If
                        Next
                    End If
                End If
            Next
        End If



    End Sub

    Public Sub sendLetterAndEmail(ByVal dtCustomers As DataTable, ByVal report_id As Integer, Optional ByVal suspended As Boolean = False)
        Dim dtReport As New DataTable

        dtReport = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetReport(report_id))
        If dtReport.Rows.Count > 0 Then
            For Each drv As DataRow In dtCustomers.Rows
                Dim dt As DataTable = New DataTable()
                For lang As Integer = 1 To 3
                    Dim dvCust As DataView = New DataView(dtCustomers, "customers_language = " & lang & " and customers_id = " & drv("customers_id"), "customers_id ", DataViewRowState.CurrentRows)
                    If dvCust.Count > 0 Then
                        designReportAndSendEmail(dvCust, dtReport.Rows(lang - 1))
                        If suspended Then
                            For Each drvOne As DataRowView In dvCust
                                If suspended Then
                                    DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsCustomersData.GetUpdateSuspendedCustomers(drvOne("customers_id")))
                                End If
                            Next
                        End If
                    End If
                Next
            Next
        End If

    End Sub

    Friend Sub ToChangeStatus(ByVal new_status As Integer, ByVal GridView1 As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal stopAbo As Boolean = False)

        If GridView1 Is Nothing Or GridView1.SelectedRowsCount = 0 Then
            Return
        End If
        Dim row As System.Data.DataRow
        Dim IntRows() As Integer = GridView1.GetSelectedRows()
        'If IntRows.Length = 0 Then
        '    clsMsgError.MsgBox("Select a Row first", MsgBoxStyle.Critical)
        'End If
        For Each index As Integer In IntRows
            row = GridView1.GetDataRow(index)
            ForcedUpdateStepStatus(row("payment_status"), new_status, row("id"))
            If stopAbo And row("customers_abo") = 1 Then
                Dim cls As New ClsCustomers()
                cls.AboStopRecovery(row)
            End If
            clsMsgError.MsgBox("change status " & row("customers_id"))
            row.Delete()
        Next


    End Sub

    Friend Sub UpdateStepStatus(ByVal old_status As Integer, ByVal new_status As Integer, ByVal delay As Integer, Optional ByVal isClosed As Boolean = False, Optional ByVal account_movements_id As String = Nothing)
        If old_status = 0 Then Exit Sub

        DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.SaveHistory(old_status, new_status))
        DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.PaymentOfflineData.UpdateStatus(old_status, new_status, delay, isClosed, account_movements_id))

    End Sub

   

   
   
    'Public Class clsOffLineFlow
    '    Inherits BizzLib.clsBKGenericClass
    '    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
    '        'Add any initialization after the InitializeComponent() call
    '        SetBKOjects(CurrentSessionInfo)
    '    End Sub

    'End Class
End Class
