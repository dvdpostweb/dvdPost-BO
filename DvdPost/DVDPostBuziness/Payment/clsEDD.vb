Public Class clsEDD

    Private _amountTot As Decimal
    Private _domIdTot As Long



    Const FORMATDATE As String = "ddMMyy"
    Const FORMATDATETIME As String = "yyMMddHHmm"
    Const BLANK As String = " "
    Const KEYFILE As String = "Path_EDD"


    ' utiliser pour gerer la progress bar
    Public Event initMapping_Event(ByVal cpt As Integer)
    Public Event stepMapping_event(ByVal index As Integer)
    Public Event ReInitProgressbar_event()
    Const CREDITOR_NAME As String = "HOME ENTERTAINMENT SERVICES"

    Public Shared Function CreatePathFile(ByVal country As String, ByVal fileOrder As Integer, ByVal eddAction As EddXml.SequenceType1Code) As String
        Dim nameFile As String
        Dim path_file As String

        path_file = Configuration.ConfigurationManager.AppSettings(KEYFILE)
        nameFile = country & "_" & DVDPostTools.ClsDate.formatDate() & "_" & fileOrder & "_" & eddAction.ToString() & "PAIN008.xml"

        Return path_file & nameFile

    End Function

    Public Shared Function CreatePathFileADULTSVOD(ByVal tBatch As String, ByVal country As String, ByVal fileOrder As Integer, ByVal eddAction As EddXml.SequenceType1Code) As String
        Dim nameFile As String
        Dim path_file As String

        path_file = Configuration.ConfigurationManager.AppSettings(KEYFILE)
        nameFile = "ADULTSVOD_" & country & "_" & tBatch.ToString() & "_" & DVDPostTools.ClsDate.formatDate() & "_" & fileOrder & "_" & eddAction.ToString() & "PAIN008.xml"

        Return path_file & nameFile

    End Function

    Public Function GetDateTimeFormat(ByVal dt As DateTime) As String
        Return dt.ToString(FORMATDATETIME)
    End Function
    Public Shared Function GetDateFormat(ByVal dt As DateTime) As String
        Return dt.ToString(FORMATDATE)
    End Function

    Private Function FormatStringPad(ByVal o As Object, ByVal cpt_char As Integer) As String
        Dim str As String = o.ToString()
        Return str.PadLeft(cpt_char, "0"c)

    End Function


    Public Function GenerateEDDFile(ByVal dtReconduction As DataTable, ByVal fileOrder As Integer) As String
        'Dim path As String
        Dim totalDomId As Integer = 0
        Dim numberOfRefund As Integer = 0
        Dim totalRefundAmount As Decimal = 0
        Dim totalFundId As Integer = 0

        Dim cpt As Integer = 0
        Dim sql As String
        Dim sqlMsgId As String
        Dim sqlPmtInfId As String
        Dim lastDomId As Integer
        Dim msgId As Integer
        Dim pmtInfId As Integer
        Dim sumAmount As Decimal
        Dim messDT As String = String.Empty
        Dim strEddManager As String = String.Empty
        Dim eddManager As EddXml.EDDManager
        Dim clsCustomers As ClsCustomers = New ClsCustomers()
        Dim strEddSequenceTypeStatus As String = String.Empty

        RaiseEvent initMapping_Event(dtReconduction.Rows.Count)
        '
        Dim items As Array
        items = System.Enum.GetValues(GetType(EddXml.EDDMANDATESTATUS))
        For Each item As EddXml.EDDMANDATESTATUS In items
            Dim eddAction As EddXml.SequenceType1Code
            Select Case item
                Case EddXml.EDDMANDATESTATUS.MANADATESIGNED_WAITINGONBANKINITIATION
                    sumAmount = 0
                    eddAction = EddXml.SequenceType1Code.FRST
                    strEddSequenceTypeStatus = "( edd_mandate_status in ( 2, 3) ) or ( bic_changed = 1 and edd_mandate_status = 4 )"
                Case EddXml.EDDMANDATESTATUS.SENTTOBANKFORINITIATION
                    Continue For
                Case EddXml.EDDMANDATESTATUS.INITIATEDATBANK
                    eddAction = EddXml.SequenceType1Code.RCUR
                    sumAmount = 0
                    strEddSequenceTypeStatus = " edd_mandate_status in (4) and bic_changed = 0 "
                Case EddXml.EDDMANDATESTATUS.STOPPED
                    sumAmount = 0
                    eddAction = EddXml.SequenceType1Code.FNAL
                    strEddSequenceTypeStatus = " edd_mandate_status in ( 5, 6)  and bic_changed = 0 "
            End Select

            If dtReconduction.Select(strEddSequenceTypeStatus).Length > 0 Then
                eddManager = New EddXml.EDDManager()
                '
                sqlMsgId = DvdPostData.ClsPayment.getLastEddMsgId()
                msgId = DvdPostData.clsConnection.ExecuteScalar(sqlMsgId)
                msgId += 1
                '
                sqlPmtInfId = DvdPostData.ClsPayment.getLastEddPmtInfId()
                pmtInfId = DvdPostData.clsConnection.ExecuteScalar(sqlPmtInfId)
                pmtInfId += 1
                '
                For Each row As DataRow In dtReconduction.Select(strEddSequenceTypeStatus)
                    sumAmount += Decimal.Parse(row("amount").ToString().Replace(".", ","))
                Next

                messDT = eddManager.Header(dtReconduction.Select(strEddSequenceTypeStatus).Length, msgId, sumAmount.ToString())

                GenearatePmtInf(clsCustomers, eddManager, dtReconduction, item, eddAction, strEddSequenceTypeStatus, pmtInfId, cpt, msgId, messDT)
                'If dtReconduction.Select("edd_mandate_status in " & strEddMandateStatuses).Length = 0 Then
                '    pmtInfId += 1
                'End If

                '
                eddManager.finalizeXMLDoc()
                eddManager.SerializeObject(CreatePathFile(DvdPostData.ClsCustomersData.Country.BELGIUM.ToString(), fileOrder, eddAction))

                Dim strEddManagerTmp = eddManager.SerializeObjectToString()
                strEddManager += strEddManagerTmp
                sql = DvdPostData.ClsPayment.getCreateEddPmtInf(msgId, pmtInfId, strEddManagerTmp.Replace("'", "''"), messDT)
                lastDomId = DvdPostData.clsConnection.ExecuteScalar(sql)
            End If
        Next

        Return strEddManager

    End Function

    Public Sub New()
        _amountTot = 0
        _domIdTot = 0
    End Sub

    Private Sub GenearatePmtInf(ByRef clsCustomers As ClsCustomers, ByRef eddManager As EddXml.EDDManager, ByVal dtReconduction As DataTable, ByVal eddMandateStatus As EddXml.EDDMANDATESTATUS, _
                    ByVal eddAction As EddXml.SequenceType1Code, ByVal strEddSequenceTypeStatus As String, ByVal pmtInfId As Integer, ByRef cpt As Integer, ByVal msgId As Integer, ByVal messDT As String)

        Dim Sql As String
        Dim lastDomId As Integer
        Dim sumAmount As Decimal
        Dim strcommunication As String
        Dim sqlEddMandateStatus As String
        Dim signatureDom80MigrationDate As Date = Date.MinValue
        Dim requestCollectionDate As DateTime


        If dtReconduction.Select(strEddSequenceTypeStatus).Length = 0 Then
            Return
        End If

        If EddXml.SequenceType1Code.FRST = eddAction Then
            requestCollectionDate = DateTime.Now.AddDays(6)
        Else
            requestCollectionDate = DateTime.Now.AddDays(3)
        End If

        Sql = DvdPostData.ClsPayment.getIdLastPayment()
        lastDomId = DvdPostData.clsConnection.ExecuteScalar(Sql)

        For Each row As DataRow In dtReconduction.Select(strEddSequenceTypeStatus)
            sumAmount += Decimal.Parse(row("amount").Replace(".", ","))
        Next

        eddManager.paymentInfoCreditor(pmtInfId, dtReconduction.Select(strEddSequenceTypeStatus).Length, sumAmount.ToString(), eddAction)
        For Each dr As DataRow In dtReconduction.Select(strEddSequenceTypeStatus)
            Dim debtorChanged As DataTable = New DataTable()
            Dim ibanChanged As Boolean = False
            Dim eddMandateIdChanged As Boolean = False
            Dim bicChanged As Boolean = False
            Dim oldiban As String = String.Empty
            Dim oldeddMandateId As String = String.Empty
            Dim oldbic As String = String.Empty

            cpt = cpt + 1
            'strcommunication = clsCompta.CreateCommunicationStruct(lastDomId + cpt, DvdPostData.ClsCustomersData.TypePaymentCommunication.DOMICILIATION)
            'If ClsBatchDomiciliation.InsertDomiciliationPayment(dr, strcommunication, lastDomId + cpt) Then

            Sql = DvdPostData.ClsCustomersData.getSelectCustomersEDDChangesWithOldValues(clsCustomers.GetCustomersId(dr))
            DvdPostData.clsConnection.FillDataSet(debtorChanged, Sql)
            oldeddMandateId = clsCustomers.getCustomersDomiciliationNumber(dr)
            If debtorChanged.Rows.Count > 0 Then
                ibanChanged = debtorChanged.Rows(0)("iban")
                oldiban = debtorChanged.Rows(0)("oldiban")

                eddMandateIdChanged = debtorChanged.Rows(0)("edd_mandate_id")
                oldeddMandateId = debtorChanged.Rows(0)("oldedd_mandate_id")

                bicChanged = debtorChanged.Rows(0)("bic")
                oldbic = debtorChanged.Rows(0)("oldbic")
            End If

            ' Checks if parent row in payment_edd table exists. This is in case "returned to recurrent"
            Dim parent_id As Integer = 0
            Dim pmt_instr_id As String = String.Empty
            Dim end_to_end_id As String = String.Empty

            If dr.Table.Columns.Contains("parent_id") Then
                parent_id = dr("parent_id")
                pmt_instr_id = dr("pmt_instr_id")
                end_to_end_id = dr("end_to_end_id")
            Else
                strcommunication = clsCompta.CreateCommunicationStruct(lastDomId + cpt, DvdPostData.ClsCustomersData.TypePaymentCommunication.DOMICILIATION)
                pmt_instr_id = lastDomId + cpt
                end_to_end_id = strcommunication
                If Not ClsBatchDomiciliation.InsertDomiciliationPayment(dr, strcommunication, pmt_instr_id) Then
                    cpt -= 1
                End If
            End If
            ClsBatchDomiciliation.InsertEddPayment(clsCustomers.GetCustomersId(dr), msgId, pmtInfId, pmt_instr_id, end_to_end_id, dr("amount"), messDT, eddAction.ToString(), DVDPostTools.ClsDate.formatDateTimeDB(requestCollectionDate), -1, clsCustomers.GetCustomersIBAN(dr), parent_id)
            '"BE65ZZZ0478510502"

            eddManager.CreatePayment(dr, dr("amount"), end_to_end_id, pmt_instr_id, clsCustomers.GetEddManadateId(dr), oldeddMandateId, "00478510502", _
                                        clsCustomers.GetCustomersName(dr), clsCustomers.GetCustomersIBAN(dr), clsCustomers.GetCustomersAgentBIC(dr), clsCustomers.GetCustomersStreetAddress(dr), _
                                        clsCustomers.GetCustomersPostCodeAndCity(dr), eddAction, clsCustomers.GetCustomersDateofSignature(dr), clsCustomers.IsDom80Migraiton(dr), _
                                        ibanChanged, oldiban, eddMandateIdChanged, oldeddMandateId, bicChanged, oldbic)
            If clsCustomers.GetEddMandateStatus(dr).Equals(EddXml.EDDMANDATESTATUS.MANADATESIGNED_WAITINGONBANKINITIATION Or bicChanged) Then
                If clsCustomers.IsDom80Migraiton(dr) Then
                    signatureDom80MigrationDate = DateTime.Now.AddDays(6)
                End If

                sqlEddMandateStatus = DvdPostData.ClsCustomersData.GetUpdateEddMandateStatus(clsCustomers.GetCustomersId(dr), _
                                        EddXml.EDDMANDATESTATUS.SENTTOBANKFORINITIATION, signatureDom80MigrationDate)
                DvdPostData.clsConnection.ExecuteScalar(sqlEddMandateStatus)

                RaiseEvent stepMapping_event(cpt)
            End If



        Next
    End Sub

End Class


