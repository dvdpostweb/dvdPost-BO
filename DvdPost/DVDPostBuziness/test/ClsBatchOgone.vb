Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Collections.Generic
Imports DvdPostData
Public Class ClsBatchOgone
    Private _lastPaymentofflineRequestid As Integer
    Private Const CODING_CARD As String = "XXX" ' code verifiant si carte est valide
    Private Const MAIL_PAYMENT_INVALID_ID As Integer = 438



    Public Shared Function getLastIdBatchOgone() As Integer
        Dim sql As String
        Dim result As Integer

        sql = DvdPostData.ClsBatchOgone.getIdLastOgoneBatch()
        result = DvdPostData.clsConnection.ExecuteScalar(sql)

        Return result
    End Function

    Public Shared Function getIdBatchOgone() As Integer
        Dim result As Integer

        result = getLastIdBatchOgone()
        result += 1 ' lastID + 1 
        Return result
    End Function
    Private Shared Function GetFooter() As String
        Dim stroutput As String = ""
        stroutput = "OTF" & ";" & ControlChars.CrLf
        Return stroutput
    End Function

    ' utiliser pour gerer la progress bar
    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)


#Region "Create Batch"

    Public Enum TypeBatch
        RECONDUCTION_OGONE
        REJET_OGONE
    End Enum


    Public Shared Function CreatePathFile(ByVal tBatch As TypeBatch, ByVal idcountry As DvdPostData.ClsCustomersData.Country) As String
        Dim nameFile As String
        Dim path_file As String

        path_file = Configuration.ConfigurationManager.AppSettings("Path_BatchOgone")
        nameFile = DVDPostTools.clsEnum.getNameStrEnum(idcountry) & "_" & tBatch.ToString() & "_" & DVDPostTools.ClsDate.formatDate() & ".txt"

        Return path_file & nameFile

    End Function


    Const CURRENCY As String = "EUR"
    Const OPERATION_CODE As String = "SAL"
    Const DESC As String = "dvdpost subscription "

    Private Shared Function GetHeader(ByVal cpt_transaction As Integer, ByVal idBatchOgone As Integer, ByVal idcountry As DvdPostData.ClsCustomersData.Country) As String
        Dim stroutput As String = ""
        Dim pspid As String
        Dim pwd As String

        If idcountry = ClsCustomersData.Country.BELGIQUE Then
            pspid = Configuration.ConfigurationManager.AppSettings("ogone_pspidBE")
            pwd = Configuration.ConfigurationManager.AppSettings("ogone_pwdBE")
        Else
            pspid = Configuration.ConfigurationManager.AppSettings("ogone_pspidNL")
            pwd = Configuration.ConfigurationManager.AppSettings("ogone_pwdNL")
        End If
        stroutput = stroutput & "OHL" & ";" & pspid & ";" & pwd & ";" & ";" & ";" & ControlChars.CrLf
        stroutput = stroutput & "OHF" & ";" & "batchogone" & idBatchOgone & ";" & "ATR" & ";" & ";" & cpt_transaction & ";" & ControlChars.CrLf

        Return stroutput
    End Function

    'Public Shared Function FormatAmount(ByVal amount As String) As String
    '    amount = amount.Replace(".", ",")
    '    'amount = amount.Replace(",", "")

    '    Dim dec As Double
    '    'Dim i As Integer
    '    dec = Double.Parse(amount, System.Globalization.NumberStyles.AllowDecimalPoint)
    '    dec = dec * 100


    '    Return dec.ToString("0")

    'End Function

    'Public Shared Function FormatAmountRecouvrement(ByVal amount As String) As String
    '    ' amount = amount.Replace(",", ".")
    '    ' Return amount

    '    'amount = amount.Replace(".", ",")
    '    'amount = amount.Replace(",", "")

    '    Dim dec As Double
    '    'Dim i As Integer
    '    dec = Double.Parse(amount, System.Globalization.NumberStyles.AllowDecimalPoint)
    '    dec = dec / 100

    '    Return dec.ToString("#0.00")

    'End Function
    Private Shared Function VerifValidCard(ByVal num_card As String) As String
        'If num_card Is Nothing Then
        '    Return False
        'Else
        '    Return Not num_card.Contains(CODING_CARD)
        'End If
        ' the credit card is stock in the site ogone and not more in db dvdpost 
        Return False
    End Function


    Private Shared Sub EncodeNumberCard(ByVal customers_id As String, ByVal num_card As String)
        Dim encod_num As String
        Dim sql As String
        encod_num = num_card.Substring(0, 3) & CODING_CARD & num_card.Substring(num_card.Length - 3, 3)
        sql = ClsCustomersData.GetUpdateEncodeCreditCard(customers_id, encod_num)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub
    Public Shared Function CreateLineOgone(ByVal rCustomers As DataRow, ByVal batch_id As Integer) As String
        Dim customers_id As Integer
        Dim product_model As String
        Dim amount As String
        Dim type_CardCredit As String = String.Empty
        Dim num_card As String = String.Empty
        Dim card_exp_date As String = String.Empty


        Try
            customers_id = rCustomers("customers_id")
            product_model = rCustomers("products_model")
            amount = rCustomers("amount")


            If (Not rCustomers("ogone_card_no") Is DBNull.Value) AndAlso VerifValidCard(rCustomers("ogone_card_no")) Then
                num_card = rCustomers("ogone_card_no")
                If Not rCustomers("ogone_card_type") Is DBNull.Value Then
                    type_CardCredit = rCustomers("ogone_card_type")
                Else
                    num_card = String.Empty
                End If

                If Not rCustomers("ogone_exp_date") Is DBNull.Value Then
                    card_exp_date = rCustomers("ogone_exp_date")
                Else
                    num_card = String.Empty
                End If
            End If

            Return CreateLineOgone(customers_id, _
                                   CURRENCY, _
                                   OPERATION_CODE, _
                                   DESC, _
                                   product_model, _
                                   batch_id, _
                                   amount, _
                                   type_CardCredit, _
                                   num_card, _
                                   card_exp_date)
        Catch ex As Exception
            ' Dim sql As String
            ' sql = ClsCustomersData.GetSuspendedCustomersError(customers_id)
            ' DvdPostData.clsConnection.ExecuteNonQuery(sql)

            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex, customers_id)
            'Throw New Exception(ex.Message & " customers id : " & cls.GetCustomersId(drReconduction))
            Return ""
        End Try

    End Function
    Public Shared Function CreateLineOgone(ByVal customers_id As Integer, _
                                           ByVal currency As String, _
                                           ByVal Operatopn_code As String, _
                                           ByVal desc As String, _
                                           ByVal product_model As String, _
                                           ByVal batch_id As Integer, _
                                           ByVal amount As String, _
                                           ByVal type_cardCredit As String, _
                                           ByVal num_card As String, _
                                            ByVal card_exp_date As String) As String
        Dim line As String = ""

        line = line + DVDPostTools.ClsPrice.castPriceDbToPriceBatch(amount) + ";"    'amount
        line = line + currency & ";" 'currency
        If String.IsNullOrEmpty(num_card) Then
            line = line + ";" 'card type
            line = line + ";" 'card number
            line = line + ";" 'exp date
        Else
            line = line + type_cardCredit & ";" 'card type
            line = line + num_card & ";" 'card number
            line = line + card_exp_date & ";" 'exp date
            ' EncodeNumberCard(customers_id, num_card)
        End If


        line = line + "b" & batch_id & "c" & customers_id & ";" 'ref 
        line = line + desc & product_model & " from " & DateString() & ";" 'desc
        line = line + ";" 'client name
        line = line + ";" 'payment id
        line = line + Operatopn_code & ";" 'operation code
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line + ";" '
        line = line & customers_id & ";" 'clientalias
        line = line + vbLf 'ControlChars.CrLf

        Return line
    End Function
    Public Function CreateBatchFile(ByVal dtCustomers As DataTable, ByVal idcountry As DvdPostData.ClsCustomersData.Country) As String
        Dim stroutput As String = ""
        Dim idBatchOgone As Integer
        idBatchOgone = getIdBatchOgone()
        RaiseEvent initMapping_Event(dtCustomers.Rows.Count)
        stroutput = stroutput + GetHeader(dtCustomers.Rows.Count, idBatchOgone, idcountry)
        Dim cpt As Integer = 0
        For Each dr As DataRow In dtCustomers.Rows
            stroutput = stroutput + CreateLineOgone(dr, idBatchOgone)
            RaiseEvent stepMapping_event(cpt)
            cpt += 1
        Next
        stroutput = stroutput + GetFooter()
        Return stroutput
    End Function
    Public Shared Sub UpdateBatchId(ByVal dtCustomers As DataTable)
        Dim sql As String
        Dim idBatchOgone As Integer
        idBatchOgone = getLastIdBatchOgone()

        For Each dr As DataRow In dtCustomers.Rows
            sql = DvdPostData.ClsBatchOgone.UpdateBatchId(dr("ogone_batch_id"), idBatchOgone, dr("customers_id"))
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
        Next

    End Sub
    'Private Function WriteFile(ByVal path As String, ByVal listResult As String()) As Boolean
    '    Dim fs As New FileStream(path, FileMode.Open, FileAccess.Write)
    '    'declaring a FileStream and open a document file na()med file with 
    '    'access mode of writing
    '    Dim s As New StreamWriter(fs)

    '    s.WriteLine(GetHeader(listResult.))
    '    For Each strline As String In listResult
    '        s.WriteLine(strline)
    '    Next
    '    s.WriteLine(GetFooter())
    '    s.Close()
    '    'closing the file

    'End Function
    'Public Shared Function WriteFile(ByVal path As String, ByVal flux As String) As Boolean
    '    Dim fs As New FileStream(path, FileMode.Create, FileAccess.Write)
    '    Dim listResult As String() = flux.Split(vbLf)
    '    'declaring a FileStream and open a document file na()med file with 
    '    'access mode of writing
    '    Dim s As New StreamWriter(fs)
    '    For Each strline As String In listResult
    '        s.WriteLine(strline)
    '    Next
    '    s.Close()
    '    'closing the file

    'End Function

#End Region

#Region "Matching Ogone File"


    Const POS_CUSTOMERID As Integer = 1
    Const CARACT_SEP_BATCH As String = "b"
    Const POS_REASON As Integer = 4
    Const CARACT_SEP As String = ";"
    Const CARACT_SEP_CUSTOMER As String = "c"

    'Const REASON_OGONE_REJECT As String = "Autorisation refus�e"
    Const REASON_OGONE_OK As String = "Paiement demand�"

    Const NB_LINE_HEADER_FILE As Integer = 1
    Const NB_LINE_HEADER_TYPE As Integer = 5

    'Enum StepPaymentOffline
    '    CREATED = 1
    '    MAIL_TOSEND = 2
    '    MAIL_SENT = 3
    '    LETTER_TOSEND = 4
    '    LETTER_SENT = 5
    '    LETTER2_TOSEND = 22
    '    LETTER2_SENT = 23
    '    CALLED = 6
    '    PROMISE_TO_PAY = 7
    '    LETTER_AVOCAT_TOSEND = 8
    '    LETTER_AVOCAT_SENT = 9
    '    CANCELED = 19
    '    RECEIVED = 20

    'End Enum

    Private Function GetHeader(ByVal listResult As List(Of String)) As String
        Dim stroutput As String = ""
        Dim idBatchOgone As Integer
        idBatchOgone = getIdBatchOgone()
        stroutput = stroutput & "OHL" & CARACT_SEP & Configuration.ConfigurationManager.AppSettings("ogone_pspid") & CARACT_SEP & Configuration.ConfigurationManager.AppSettings("ogone_pwd") & CARACT_SEP & CARACT_SEP & CARACT_SEP & ControlChars.CrLf
        stroutput = stroutput & "OHF" & CARACT_SEP & "batchogone" & idBatchOgone & CARACT_SEP & "ATR" & CARACT_SEP & CARACT_SEP & listResult.Count & CARACT_SEP & ControlChars.CrLf

        Return stroutput
    End Function

    Public Function MappingOgoneFile(ByVal filepath As String) As Boolean
        'Dim filepath As String = ""
        Dim listDataOgone As List(Of String)

        Try
            'filepath = BatchOgone.CreatePathFile(typeB)
            listDataOgone = DVDPostTools.clsFile.LoadFileTxt(filepath)
            RaiseEvent initMapping_Event(listDataOgone.Count)
            Return MappingFile(listDataOgone)
        Catch ex As Exception
            MsgBox(ex.Message & " File Format Incorrect " & filepath)
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Matching, ex)
            Return False
        End Try


    End Function
    Private Function GetHeaderOgone(ByVal listDataOgone As List(Of String)) As String
        If listDataOgone.Count > 1 Then
            ' 2 eme line 
            Return listDataOgone(1)
        Else
            Return ""
        End If

    End Function

    Private Function getValue(ByVal lineDataOgone As String, ByVal pos As Integer) As String

        If lineDataOgone.Length > 0 Then
            Dim lst() As String = lineDataOgone.Split(CARACT_SEP)

            Return lst(pos)

        End If

        Return ""

    End Function
    Private Function getCustomersID(ByVal lineDataOgone As String) As String
        Dim result As String
        Try

            If lineDataOgone.Length > 0 Then
                Dim lst() As String = lineDataOgone.Split(CARACT_SEP)
                If lst.Length > POS_CUSTOMERID Then
                    result = lst(POS_CUSTOMERID)
                    Return result.Split(CARACT_SEP_CUSTOMER)(1)
                Else
                    Return Nothing
                End If
            End If

        Catch ex As Exception
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Matching, ex.Message & " " & ex.StackTrace & " lineData " & lineDataOgone)
            Return Nothing
        End Try
        Return Nothing

    End Function

    Private Function getBatchID(ByVal lineDataOgone As String) As String
        Dim result As String

        If lineDataOgone.Length > 0 Then
            Dim lst() As String = lineDataOgone.Split(CARACT_SEP)

            result = lst(POS_CUSTOMERID)
            result = result.Split(CARACT_SEP_BATCH)(1)
            result = result.Split(CARACT_SEP_CUSTOMER)(0)
            Return result
        End If

        Return ""
    End Function

    Private Function UpdatePaymentStatus(ByVal customers_id As Integer, ByVal reason As String, ByVal batch_id As Integer) As String


        Select Case reason

            Case REASON_OGONE_OK
                UpdatePaymentOgone(customers_id, DvdPostData.ClsBatchOgone.OGONE_PAYMENT_STATUS.SENT, batch_id)
                Return ""
            Case Else
                Return UpdatePaymentOgoneReject(customers_id, DvdPostData.ClsBatchOgone.OGONE_PAYMENT_STATUS.REJECT, batch_id)

        End Select

    End Function

    Private Function MappingFile(ByVal listDataOgone As List(Of String)) As Boolean


        Dim customers_id As String
        Dim reason As String
        'Dim switch_type As Boolean
        Dim batch_id As Integer
        Dim msg As String = ""
        Try

            Dim i As Integer = NB_LINE_HEADER_FILE + NB_LINE_HEADER_TYPE
            DvdPostData.clsConnection.CreateTransaction(False)
            _lastPaymentofflineRequestid = GetLastPaymentOfflineRequest()

            While i < listDataOgone.Count - 1

                customers_id = getCustomersID(listDataOgone(i))

                If Not customers_id Is Nothing Then
                    batch_id = getBatchID(listDataOgone(i))
                    reason = getValue(listDataOgone(i), POS_REASON)
                    If msg.Length > 0 Then
                        msg = msg + vbNewLine
                    End If
                    msg = msg + UpdatePaymentStatus(customers_id, reason, batch_id)
                    i += 1

                Else
                    i += NB_LINE_HEADER_TYPE
                End If
                RaiseEvent stepMapping_event(i)
            End While

            If msg.Length > 0 Then
                MsgBox(msg)
            End If
            DvdPostData.clsConnection.CommitTransaction(True)
            ' time out expected ???
            'Return DvdPostData.clsConnection.ExecuteBulkQuery()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Matching, ex)
            If msg.Length > 0 Then
                MsgBox(msg)
            End If
            DvdPostData.clsConnection.CommitTransaction(False)
            Return False

        End Try

    End Function

    'Private Function openFile(ByVal path As String) As List(Of String)
    '    Dim fs As New FileStream(path, FileMode.Open, FileAccess.Read)
    '    'declaring a FileStream to open the file named file.doc with access mode of reading
    '    Dim ListResult As List(Of String) = New List(Of String)
    '    Dim d As New StreamReader(fs)
    '    'creating a new StreamReader and passing the filestream object fs as argument
    '    d.BaseStream.Seek(0, SeekOrigin.Begin)
    '    'Seek method is used to move the cursor to different positions in a file, in this code, to 
    '    'the beginning
    '    While d.Peek() > -1
    '        'peek method of StreamReader object tells how much more data is left in the file
    '        ListResult.Add(d.ReadLine())
    '        'displaying text from doc file in the RichTextBox
    '    End While
    '    d.Close()

    '    Return ListResult
    'End Function
    Private Function GetConnection() As MySqlConnection
        Dim connectionString As String
        connectionString = Configuration.ConfigurationManager.ConnectionStrings("prod").ConnectionString
        Dim connect As MySqlConnection = New MySqlConnection(connectionString)
        connect.Open()
        Return connect
    End Function
    Private Function GetLastPaymentOfflineRequest() As Integer
        Dim sql As String
        Dim payment_offline_request_id As Integer
        Sql = DvdPostData.PaymentOfflineData.getIdLast()
        payment_offline_request_id = DvdPostData.clsConnection.ExecuteScalar(sql)

        Return payment_offline_request_id
    End Function

    Private Function UpdatePaymentOgoneReject(ByVal customers_id As Integer, ByVal reason As Integer, ByVal batch_id As Integer) As String
        Dim sql As String

        sql = DvdPostData.ClsBatchOgone.GetUpdatePaymentStatus_ogone(customers_id, reason, batch_id)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
       
        sql = DvdPostData.ClsBatchOgone.GetPaymentOgone(customers_id, batch_id)
        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)
            Dim communication_structure As String

            ' verif que cette transaction n'est pas encore en recouvrement 
            ' si c'est le cas on la rajoute 

            sql = DvdPostData.PaymentOfflineData.getPaymentOfflineRequest(customers_id, dr("ogone_payment_id"), ClsCustomersData.Payment_Method.OGONE.ToString())
            If DvdPostData.clsConnection.FillDataSet(sql).Rows.Count = 0 Then
                ' variable member incremente the id because the id must be unique  
                _lastPaymentofflineRequestid = _lastPaymentofflineRequestid + 1

                communication_structure = clsCompta.CreateCommunicationStruct(_lastPaymentofflineRequestid, ClsCustomersData.TypePaymentCommunication.OGONE)
                sql = DvdPostData.PaymentOfflineData.InsertPaymentOfflineRequest(PaymentOfflineData.StepPaymentOffline.CREATED, _
                                                                          DVDPostTools.ClsPrice.FormatPrice(dr("amount").ToString()), _
                                                                          clsCompta.DVDPOST_ACCOUNT_DEXIA, _
                                                                          customers_id, _
                                                                          ClsCustomersData.Payment_Method.OGONE.ToString(), _
                                                                          dr("ogone_payment_id"), _
                                                                          communication_structure)

                DvdPostData.clsConnection.ExecuteNonQuery(sql)
                clsMail.SendMail(customers_id, MAIL_PAYMENT_INVALID_ID)

            End If
            Return ""

        Else

            Return "the payment ogone doesn't exist (customer_id : " & customers_id & " / batch_id : " & batch_id & ")"
        End If




    End Function
    Private Sub UpdatePaymentOgone(ByVal customers_id As Integer, ByVal reason As Integer, ByVal batch_id As Integer)
        Dim sql As String
        sql = DvdPostData.ClsBatchOgone.GetUpdatePaymentStatus_ogone(customers_id, reason, batch_id)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        sql = DvdPostData.PaymentOfflineData.ForcedUpdateStatus(PaymentOfflineData.StepPaymentOffline.CREATED, PaymentOfflineData.StepPaymentOffline.RECEIVED, customers_id)
        ' create history des recouvrement 
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub



    'Private Function WriteFile(ByVal path As String) As Boolean
    '    Dim fs As New FileStream(path, FileMode.Open, FileAccess.Write)
    '    Dim listResult As List(Of String) = New List(Of String)
    '    'declaring a FileStream and open a document file na()med file with 
    '    'access mode of writing
    '    Dim s As New StreamWriter(fs)

    '    s.WriteLine(GetHeader(listResult))
    '    For Each strline As String In listResult
    '        s.WriteLine(strline)
    '    Next
    '    s.WriteLine(GetFooter())
    '    s.Close()
    '    'closing the file

    'End Function
    'Private Function LoadFileTxt(ByVal path As String) As List(Of String)
    '    If File.Exists(path) Then
    '        Return openFile(path)
    '    Else
    '        Return Nothing
    '    End If

    'End Function

#End Region
End Class