Public Class ClsBatchDomiciliation
    Const DOMINEXIST As String = "MOTIF : DOM. INEXISTANTE"
    Const DOMINSOLVENT As String = "MOTIF : NON PRECISE"
    Const DOMCOMPTESOLDE As String = "MOTIF : COMPTE SOLDE"
    Const NB_DAYSOFWAITING As Integer = 15
    Const RECONDUCT As String = "   RECONDUCT" ' identifier les snapshot dom

    Public Enum TypeBatch
        RECONDUCTION_DOM80
        ACTIVATION_DOM70
        REJET_OGONE
    End Enum

    Public Enum EDD_MANDATE_STATUS
        WAITING_SIGNED_DOCUMENT = 1
        SIGNED_DOCUMENT_RECEIVED = 2
        FIRST = 3
        RECURRENT = 4
        stop_initated = 5
        stop_sent_in_bank = 6
        sttoped = 7
    End Enum

    Public Shared Function GetListUnpaid() As String
        Dim str As String

        str = DVDPostTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.WAITING_PAYMENT) + "," + _
              DVDPostTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.PAYBACK) + "," + _
              DVDPostTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.RECOVERY_DOM_ERROR) + "," + _
              DVDPostTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.RECOVERY_INSOLVENT) + "," + _
              DVDPostTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.REJECTINSOLVENT) + "," + _
              DVDPostTools.clsEnum.getValueStrEnum(PaymentOfflineData.StepPayment.REJECTDOMERROR)

        Return str

    End Function


    Private Shared Function GetReferenceDom(Optional ByVal stralias As String = "") As String
        If stralias <> "" Then
            stralias = stralias + "."
        End If

        Return " right(" & stralias & "clientreference,13) "
    End Function

    Public Shared Function getCommunicationDomiciliation(Optional ByVal stralias As String = "") As String
        Dim sql As String
        Dim aliassql As String

        If stralias = "" Then
            aliassql = ""
        Else
            aliassql = stralias & "."
        End If
        'left(substring(bam.communication,length(bam.communication) - 13),12)
        ' get the communication number 
        sql = " left(substring(" & aliassql & "communication,length(" & aliassql & "communication) - 13),12)"
        Return sql
    End Function

    Public Shared Function getInsertPaymentOfflineRequest() As String
        Dim sql As String

        sql = " update payment " & _
                " set payment_status = " & PaymentOfflineData.StepPayment.CREATE_RECOVERY & _
                " ,last_modified = now() " & _
                ", user_modified = " & clsSession.user_id & _
                " where payment_status in (" & PaymentOfflineData.StepPayment.REJECTDOMERROR & "," & PaymentOfflineData.StepPayment.REJECTINSOLVENT & ")" & _
                " and date(last_modified) = date(now())"

        Return sql
    End Function

    'Public Shared Function getChangeStatusUnpaidDomInexist() As String
    '    Dim sql As String

    '    sql = "update payment set payment_status = " & PaymentOfflineData.StepPayment.RECOVERY_DOM_ERROR & _
    '        " ,last_modified = now() " & _
    '    " where payment_status = " & PaymentOfflineData.StepPayment.REJECTDOMERROR

    '    Return sql
    'End Function
    Public Shared Function getChangeStatuspaidAfterLongTime() As String
        Dim sql As String

        sql = "update payment p set p.last_status_id = p.payment_status , p.payment_status = " & PaymentOfflineData.StepPayment.PAID & _
            " , p.last_modified = now() ,p.date_closed = now() " & _
        " where p.payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION & " and p.payment_status = " & PaymentOfflineData.StepPayment.WAITING_PAYMENT & _
        " and date_add(p.date_added,interval " & NB_DAYSOFWAITING & " DAY) <= date(now())"

        Return sql
    End Function

    'Public Shared Function getChangeStatusUnpaidInsolvent() As String
    '    Dim sql As String

    '    sql = "update payment p set p.payment_status = " & PaymentOfflineData.StepPayment.RECOVERY_INSOLVENT & _
    '        " ,p.last_modified = now() " & _
    '    " where p.payment_status = " & PaymentOfflineData.StepPayment.REJECTINSOLVENT

    '    Return sql
    'End Function
    Public Shared Function getFlagReconduct() As String
        Dim sql As String
        sql = " update bank_account_movements bam " & _
              " set bam.ismatching = " & ClsMatching.matching_type.NOPAYMENT & ",debit = 1 " & _
              " where bam.date_coda_created = date(now()) and StructuredComm12 = '" & RECONDUCT & "'"
        Return sql
    End Function
    Public Shared Function getFlagPaidDom() As String
        Dim sql As String

        sql = " update payment p set p.last_status_id = p.payment_status, p.payment_status = " & PaymentOfflineData.StepPayment.PAID & ",p.last_modified = now() " & _
              " , p.date_closed = now() " & _
              " where p.payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION & _
              " and not p.payment_status in (" & PaymentOfflineData.StepPayment.REJECTDOMERROR & "," & PaymentOfflineData.StepPayment.REJECTINSOLVENT & ")" & _
              " and p.date_added in (select dom_date from (select distinct p2.date_added dom_date" & _
              "                      from  payment p2 " & _
              "                      where date(p2.last_modified) = date(now()) " & _
              "                      and p2.payment_status in (" & PaymentOfflineData.StepPayment.REJECTDOMERROR & "," & PaymentOfflineData.StepPayment.REJECTINSOLVENT & ")) tmp )"

        Return sql
    End Function

    Public Shared Function getEDDFlagPaidDom() As String
        Dim sql As String

        sql = " update payment p set p.last_status_id = p.payment_status, p.payment_status = " & PaymentOfflineData.StepPayment.PAID & ",p.last_modified = now() " & _
              " , p.date_closed = now() " & _
              " where p.payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION & _
              " and not p.payment_status = " & PaymentOfflineData.StepPayment.DOM_PROBLEM & _
              " and p.date_added in (select dom_date from (select distinct p2.date_added dom_date" & _
              "                      from  payment p2 " & _
              "                      where date(p2.last_modified) = date(now()) " & _
              "                      and p2.payment_status = " & PaymentOfflineData.StepPayment.DOM_PROBLEM & ") tmp )"

        Return sql
    End Function

    Public Shared Function getFlagUnpaidDomInexist() As String
        Dim sql As String

        sql = "update bank_account_movements bam" & _
                " join payment p on replace(entiredata,'-','') like concat('%',p.domiciliation_number,'%')" & _
                " and entiredata like concat('%',p.communication,'%')" & _
                " set bam.ismatching = " & ClsMatching.matching_type.DOMICILIATION & ", p.payment_status = " & PaymentOfflineData.StepPayment.REJECTDOMERROR & ",p.last_modified = now(), p.user_modified = " & clsSession.user_id & _
                " where bam.entiredata like '%" & DOMINEXIST & "%' and date_coda_created = date(now()) and p.communication <> 0 " & _
                " and p.date_added >= date_add(now(),interval -1 month) and p.payment_status in (" & PaymentOfflineData.StepPayment.WAITING_PAYMENT & "," & PaymentOfflineData.StepPayment.PAID & ")"

        Return sql
    End Function

    Public Shared Function getFlagUnpaidInsolvent() As String
        Dim sql As String

        sql = "update bank_account_movements bam" & _
                " join payment p on replace(entiredata,'-','') like concat('%',p.domiciliation_number,'%')" & _
                " and entiredata like concat('%',p.communication,'%')" & _
                " set  bam.ismatching = " & ClsMatching.matching_type.DOMICILIATION & ",p.payment_status = " & PaymentOfflineData.StepPayment.REJECTINSOLVENT & ",p.last_modified = now(), p.user_modified = " & clsSession.user_id & _
                " where entiredata like '%" & DOMINSOLVENT & "%'  and date_coda_created = date(now()) and p.communication <> 0 " & _
                " and p.date_added >= date_add(now(),interval -1 month) and p.payment_status in (" & PaymentOfflineData.StepPayment.WAITING_PAYMENT & "," & PaymentOfflineData.StepPayment.PAID & ")"
        Return sql
    End Function

    Public Shared Function getFlagUnpaidCompteSolde() As String
        Dim sql As String

        sql = "update bank_account_movements bam" & _
                " join payment p on replace(entiredata,'-','') like concat('%',p.domiciliation_number,'%')" & _
                " and entiredata like concat('%',p.communication,'%')" & _
                " set  bam.ismatching = " & ClsMatching.matching_type.DOMICILIATION & ",p.payment_status = " & PaymentOfflineData.StepPayment.REJECTDOMERROR & ",p.last_modified = now(), p.user_modified = " & clsSession.user_id & _
                " where entiredata like '%" & DOMCOMPTESOLDE & "%'  and date_coda_created = date(now()) and p.communication <> 0 " & _
                " and p.date_added >= date_add(now(),interval -1 month) and p.payment_status = " & PaymentOfflineData.StepPayment.WAITING_PAYMENT
        Return sql
    End Function

    Public Shared Function getMatchingDomiciliation(ByVal lststatus_paid As String) As String
        Dim sql As String

        sql = "select * from payment p"
        sql = sql + " join bank_account_movements bam on p.domiciliation_number = bam.communication2"
        sql = sql + " where p.amount = bam.amount and bam.ismatching = " & ClsMatching.matching_type.NOMATCHED & " and date(date_coda_created) = date(now()) "
        sql = sql + " and ((p.communication = bam.structuredcomm12) or " & getCommunicationDomiciliation("bam") & "= cast(p.communication as unsigned))"
        sql = sql + " and not p.payment_status in (" & lststatus_paid & ") and p.account_movements_id is null "
        Return sql

    End Function

    'Public Shared Function getUpdateStatusDomiciliation(ByVal dom_id As Integer, ByVal status As PaymentOfflineData.StepPayment) As String
    '    Dim sql As String

    '    sql = "update payment p set p.payment_status = " & status & ",p.last_modified = now()  where p.id = " & dom_id
    '    Return sql
    'End Function


    Public Shared Function CreatedomiciliationPayment(ByVal id_payment As Integer, ByVal abo_id As Integer, _
                                                        ByVal customers_id As Integer, _
                                                        ByVal price As String, _
                                                        ByVal domiciliation_number As String, _
                                                        ByVal communication As String) As String
        Dim sql As String
        sql = ClsPayment.CreatePayment(id_payment, abo_id, ClsCustomersData.Payment_Method.DOMICILIATION, customers_id, price, domiciliation_number, communication)
        Return sql
    End Function

    Public Shared Function CreateEddPayment(ByVal customers_id As Integer, ByVal msg_id As Integer, ByVal pmt_inf_id As Integer, _
                                                        ByVal pmt_instr_id As Integer, _
                                                        ByVal end_to_end_id As String, _
                                                        ByVal InstdAmt As String, _
                                                        ByVal cre_dt_tm As String, _
                                                        ByVal sequence_type As String, _
                                                        ByVal reqd_colltn_dt As String, _
                                                        ByVal edd_payment_status As Integer, _
                                                        ByVal iban As String, ByVal parent_id As Integer) As String
        Dim sql As String
        Dim strParent_id As String
        If parent_id = 0 Then
            strParent_id = "null"
        Else
            strParent_id = parent_id
        End If
        sql = String.Format("insert into payment_edd(customers_id, msg_id, pmt_inf_id, pmt_instr_id, end_to_end_id, InstdAmt, cre_dt_tm, sequence_type, reqd_colltn_dt, edd_payment_status, iban, system_created_at, parent_id) " & _
                " values({0}, {1}, {2}, {3},'{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}', now(), {11})", customers_id, msg_id, pmt_inf_id, pmt_instr_id, end_to_end_id, DVDPostTools.ClsPrice.FormatPrice(InstdAmt), cre_dt_tm, sequence_type, reqd_colltn_dt, edd_payment_status, iban, strParent_id)

        Return sql
    End Function

    Public Shared Function UpdateEDDPayment() As String
        Dim sql As String
        sql = "UPDATE payment_edd p join bank_account_movements b on b.entiredata = p.pmt_instr_id and b.ClientReference = p.end_to_end_id " & _
              "   SET p.type_r_transaction = b.type_r_transaction, p.paid_or_refund_reason = b.paid_refund_reason, p.reason = b.reason " & _
              " WHERE b.date_coda_created = date(now()) "

        Return sql
    End Function

    Public Shared Function EDDPaymentToDomProblem() As String
        Dim sql As String
        sql = "UPDATE bank_account_movements b join payment p on b.structuredComm12 = p.communication " & _
              "  JOIN payment_edd pe on p.id = pe.pmt_instr_id " & _
              "  JOIN ( select pmt_instr_id, max(id) id from payment_edd group by pmt_instr_id) pe1 on pe.id = pe1.id " & _
              "   SET pe.type_r_transaction = b.type_r_transaction, pe.paid_or_refund_reason = b.paid_refund_reason, pe.reason = b.reason, " & _
              "        p.last_status_id = p.payment_status, p.payment_status = " & PaymentOfflineData.StepPayment.DOM_PROBLEM & ", p.last_modified = now(), b.customers_id = p.customers_id,  " & _
              "       b.ismatching = " & ClsMatching.matching_type.DOMICILIATION & " , p.account_movements_id = b.account_movements_id " & _
              " WHERE b.date_coda_created = date(now()) and p.payment_status in (" & PaymentOfflineData.StepPayment.WAITING_PAYMENT & "," & PaymentOfflineData.StepPayment.PAID & ")" & _
              "   AND (b.paid_refund_reason <> " & PaymentOfflineData.Paid_Refund_Reason.PAID & " or b.type_r_transaction <> " & PaymentOfflineData.Type_R_Transaction.PAID & _
              " ) and b.communication_type = 127 and b.paid_refund_reason is not null and b.type_r_transaction is not null "

        Return sql
    End Function

    Public Shared Function EDDPaymentToPaid() As String
        Dim sql As String
        sql = "UPDATE bank_account_movements b join payment p on b.structuredComm12 = p.communication " & _
              "  JOIN payment_edd pe on p.id = pe.pmt_instr_id " & _
              "  JOIN ( select pmt_instr_id, max(id) id from payment_edd group by pmt_instr_id) pe1 on pe.id = pe1.id " & _
              "   SET pe.type_r_transaction = b.type_r_transaction, pe.paid_or_refund_reason = b.paid_refund_reason, pe.reason = b.reason, " & _
              "       p.payment_status = " & PaymentOfflineData.StepPayment.PAID & ", p.last_modified = now(), b.customers_id = p.customers_id" & _
              "       b.ismatching = " & ClsMatching.matching_type.DOMICILIATION & _
              " WHERE b.date_coda_created = date(now()) and p.payment_status = " & PaymentOfflineData.StepPayment.WAITING_PAYMENT & _
              "   AND b.paid_refund_reason = " & PaymentOfflineData.Paid_Refund_Reason.PAID & " AND b.type_r_transaction = " & PaymentOfflineData.Type_R_Transaction.PAID

        Return sql
    End Function

    Public Shared Function UpdateCustomersEDDMandateFrstToRecurrent() As String
        Dim sql As String
        sql = " update customers_edd ce join customers c on ce.customers_id = c.customers_id "
        sql = sql & " join payment p on c.customers_id = p.customers_id "
        sql = sql & " SET ce.edd_mandate_status = " & EDD_MANDATE_STATUS.RECURRENT & " , ce.last_update = now() "
        sql = sql & " WHERE customers_abo = 1 "
        sql = sql & " AND ce.edd_mandate_status = " & EDD_MANDATE_STATUS.FIRST
        sql = sql & " AND c.customers_abo_payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION
        sql = sql & " AND p.payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION
        sql = sql & " AND p.payment_status = " & PaymentOfflineData.StepPayment.PAID
        sql = sql & " AND date(p.last_modified) = date(now())"
        Return sql
    End Function

    Public Shared Function UpdateCustomersEDDMandateFrstToRecurrentR_RETURN() As String
        Dim Sql As String

        Sql = " update bank_account_movements bam join customers_edd ce on bam.customers_id = ce.customers_id "
        Sql = Sql & " join customers c on ce.customers_id = c.customers_id "
        Sql = Sql & " join payment p on c.customers_id = p.customers_id "
        Sql = Sql & " SET ce.edd_mandate_status = " & EDD_MANDATE_STATUS.RECURRENT & " , ce.last_update = now() "
        Sql = Sql & " WHERE customers_abo = 1 "
        Sql = Sql & " AND ce.edd_mandate_status = " & EDD_MANDATE_STATUS.FIRST
        Sql = Sql & " AND c.customers_abo_payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION
        Sql = Sql & " AND p.payment_method = " & ClsCustomersData.Payment_Method.DOMICILIATION
        Sql = Sql & " AND p.payment_status = " & PaymentOfflineData.StepPayment.DOM_PROBLEM & " AND bam.type_r_transaction is not null AND bam.type_r_transaction = " & PaymentOfflineData.Type_R_Transaction.R_RETURN
        Sql = Sql & " AND date(p.last_modified) = date(now()) AND bam.date_coda_created = date(now())"
        Return Sql
    End Function

    Public Shared Function SelectEDDPaymentReturnedToRecurrent() As String
        Dim sql As String
        sql = "SELECT * payment_edd p where type_r_transaction = " & PaymentOfflineData.Type_R_Transaction.R_RETURN & " and sequence_type = 'FRST' "

        Return sql
    End Function

    Public Shared Function PrintActivation(ByVal typePayment As Integer, _
                                           ByVal country_id As Integer, _
                                           ByVal domiciliation_status_SendLetter As Integer, _
                                           ByVal StepRegistration As Integer) As String
        Dim sql As String
        sql = "select   concat(entry_firstname,' ',entry_lastname) delivery_name, "
        sql = sql & " entry_street_address delivery_street_address,"
        sql = sql & " entry_city delivery_city,"
        sql = sql & " entry_postcode delivery_postcode,"
        sql = sql & " l.code lang_name,l.languages_id,c.customers_id, "
        sql = sql & " now() date_added "
        sql = sql & " from customers c  "
        sql = sql & " join address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id "
        sql = sql & " join languages l on l.languages_id = c.customers_language "
        sql = sql & " WHERE customers_abo = 0 "
        sql = sql & " AND domiciliation_status = " & domiciliation_status_SendLetter
        sql = sql & " AND customers_registration_step in (" & StepRegistration & ")"
        sql = sql & " AND customers_abo_payment_method = " & typePayment
        sql = sql & " AND EntityID = " & country_id

        Return sql
    End Function

    Public Shared Function UpdateActivation(ByVal typePayment As Integer, _
                                           ByVal country_id As Integer, _
                                           ByVal domiciliation_status_SendLetter As Integer, _
                                           ByVal StepRegistrationCreate As Integer, _
                                           ByVal domiciliation_status_Sent As Integer _
                                          ) As String
        Dim sql As String
        sql = " update customers set domiciliation_status = " & domiciliation_status_Sent
        sql = sql & " WHERE customers_abo = 0 "
        sql = sql & " AND domiciliation_status = " & domiciliation_status_SendLetter
        sql = sql & " AND customers_registration_step = " & StepRegistrationCreate
        sql = sql & " AND customers_abo_payment_method = " & typePayment
        sql = sql & " AND EntityID = " & country_id
        Return sql
    End Function
    Public Shared Function IsexistCoda(ByVal name_coda As String) As String
        Dim sql As String

        sql = "select count(1) from bank_account_movements  where coda_filename = '" & name_coda & "'"
        Return sql
    End Function
    Public Shared Function UpdateActivation(ByVal customers_id As Integer, _
                                          ByVal typePayment As Integer, _
                                          ByVal country_id As Integer, _
                                          ByVal StepRegistrationCreate As Integer, _
                                          ByVal domiciliation_status_RetrieveLetter As Integer, _
                                          ByVal StepRegistrationDomiciliation As Integer _
                                         ) As String
        Dim sql As String
        sql = " update customers set domiciliation_status = " & domiciliation_status_RetrieveLetter
        sql = sql & ", customers_registration_step = " & StepRegistrationDomiciliation
        sql = sql & " WHERE customers_abo = 0 "
        sql = sql & " AND customers_registration_step = " & StepRegistrationCreate
        sql = sql & " AND customers_abo_payment_method = " & typePayment
        sql = sql & " AND EntityID = " & country_id
        sql = sql & " AND customers_id = " & customers_id
        Return sql
    End Function

    Public Shared Function GetBankAccountMovementAmount(ByVal name_coda As String) As String
        Dim sql As String

        sql = "update bank_account_movements set last_modified = now(), amount = amount / 1000 where coda_filename = '" & name_coda & "'"
        Return sql
    End Function

    Public Shared Function GetBankAccountMovementWithCommunicationStructure(ByVal name_coda As String) As String
        Dim sql As String

        sql = "select account_movements_id, concat(concat(communication, if(ISNULL(communication2),'',communication2)), if(isnull(communication3),'',communication3)) as communication from bank_account_movements where coda_filename = '" & name_coda & "' and communicationtypeid = 1 "
        Return sql
    End Function
End Class
