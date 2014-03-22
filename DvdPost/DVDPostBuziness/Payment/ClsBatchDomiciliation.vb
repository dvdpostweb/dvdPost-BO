Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Collections.Generic

Public Class ClsBatchDomiciliation


    ' utiliser pour gerer la progress bar
    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)
    Public Event init_event()


    Public Shared Function GetMatchingDomiciliation() As DataTable
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsBatchDomiciliation.getMatchingDomiciliation(DvdPostData.PaymentOfflineData.GetListPaid)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function
    Public Shared Function InsertEddPayment(ByVal customers_id As Integer, ByVal msg_id As Integer, ByVal pmt_inf_id As Integer, _
                                                        ByVal pmt_instr_id As Integer, _
                                                        ByVal end_to_end_id As String, _
                                                        ByVal InstdAmt As Decimal, _
                                                        ByVal cre_dt_tm As String, _
                                                        ByVal sequence_type As String, _
                                                        ByVal reqd_colltn_dt As String, _
                                                        ByVal edd_payment_status As Integer, _
                                                        ByVal iban As String, ByVal parent_id As Integer)
        Dim sql As String
        Try
            sql = DvdPostData.ClsBatchDomiciliation.CreateEddPayment(customers_id, msg_id, pmt_inf_id, pmt_instr_id, end_to_end_id, InstdAmt, cre_dt_tm, sequence_type, reqd_colltn_dt, edd_payment_status, iban, parent_id)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
        End Try
    End Function

    Public Shared Function InsertDomiciliationPayment(ByVal drReconduction As DataRow, ByVal strcommunication As String, ByVal id_payment As Integer) As Boolean
        Dim abo_id As Integer
        Dim customers_id As Integer
        Dim price As String
        Dim strDomNumber As String
        Dim sql As String


        Try
            Dim clsCust As ClsCustomers = New ClsCustomers()

            abo_id = clsCust.GetCustomersLastAbo(drReconduction)
            customers_id = clsCust.GetCustomersId(drReconduction)

            sql = DvdPostData.ClsCustomersData.GetLastAboid(customers_id)
            abo_id = DvdPostData.clsConnection.ExecuteScalar(sql)

            price = clsCust.GetCustomersAmount(drReconduction)
            price = DVDPostTools.ClsPrice.FormatPrice(price)
            If price = "0" Then Return True
            strDomNumber = clsCust.getCustomersDomiciliationNumber(drReconduction)

            sql = DvdPostData.ClsBatchDomiciliation.CreatedomiciliationPayment(id_payment, abo_id, customers_id, price, strDomNumber, strcommunication)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'sql = DvdPostData.PaymentOfflineData.InsertPaymentOfflineRequest(DvdPostData.PaymentOfflineData.StepPayment.CREATE_RECOVERY, _
            '                                                               price, _
            '                                                               clsCompta.DVDPOST_ACCOUNT_DEXIA, _
            '                                                               customers_id, _
            '                                                               DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION.ToString(), _
            '                                                               String.Empty, _
            '                                                               strcommunication)
            'DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'sql = DvdPostData.ClsBatchDomiciliation.getUpdateReasonPkValue(customers_id, price)
            'DvdPostData.clsConnection.ExecuteNonQuery(sql)

            Return True
        Catch ex As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex)
        End Try

    End Function

    Public Function CreateEDDXMLBatchFile(ByVal dtCustomers As DataTable) As String
        Dim edd As String = ""
        Dim clsedd As clsEDD = New clsEDD()

        'edd = clsedd.CreateEDDXMLFileManager(dtCustomers)
        Return edd
    End Function

    Public Function CreateBatchFile(ByVal dtCustomers As DataTable) As String
        Dim flux_80 As String
        Dim clsdom As ClsDom80_128 = New ClsDom80_128()

        flux_80 = clsdom.GenerateFile(dtCustomers)
        Return flux_80
    End Function

    Public Function CreatePathFile(ByVal tBatch As String, ByVal country As String) As String
        Return ClsDom80_128.CreatePathFile(tBatch, country)
    End Function

    Public Function CreatePathFileADULTSVOD(ByVal tBatch As String, ByVal country As String) As String
        Return ClsDom80_128.CreatePathFileADULTSVOD(tBatch, country)
    End Function

    Private Sub InitProgressBar(ByVal cpt As Integer)

        RaiseEvent initMapping_Event(cpt)
    End Sub
    Private Sub StepProgressBar(ByVal index As Integer)
        RaiseEvent stepMapping_event(index)
    End Sub

    Private Sub init()
        RaiseEvent init_event()
    End Sub

    Public Function ImportCoda(ByVal pathfile As String) As Boolean
        Dim clsImportCoda As clsCoda2 = New clsCoda2()
        Return clsImportCoda.AnalyseFile(pathfile)

    End Function
End Class
