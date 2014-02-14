Public Class clsMandate

    Public Sub SendLetter(ByVal dtCustomers As DataTable, ByVal report_id As Integer, ByVal path As String)
        Dim dvCust As DataView
        Dim dtReport As New DataTable

        dtReport = DvdPostData.clsConnection.FillDataSet(DvdPostData.PaymentOfflineData.GetReport(report_id))
        If dtReport.Rows.Count > 0 Then

            For lang As Integer = 1 To 3
                dvCust = New DataView(dtCustomers, "customers_language = " & lang, "customers_id ", DataViewRowState.CurrentRows)
                If dvCust.Count > 0 Then
                    designReport(dvCust, dtReport.Rows(lang - 1), path)
                End If
            Next
        End If
    End Sub
    Friend Sub designReport(ByVal dvCust As DataView, ByVal rowReport As DataRow, ByVal savePath As String)

        Dim report As New DevExpress.XtraReports.UI.XtraReport

        Dim path As String = rowReport("ReportPath")
        Dim reportName As String = rowReport("name")
        Dim pathEsker As String
        Dim strdateFormat As String
        Dim saveFileDialog As Windows.Forms.SaveFileDialog
        report.LoadLayout(path & "\" & rowReport("Name") & ".repx")
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
                If savePath.Equals(String.Empty) Then
                    pathEsker = System.Configuration.ConfigurationManager.AppSettings(clsCompta.KEY_ESKERLOADER)
                Else
                    pathEsker = savePath
                End If
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

        Catch e As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Report, e)
            clsMsgError.MsgBox(e.Message)
        End Try

    End Sub

End Class
