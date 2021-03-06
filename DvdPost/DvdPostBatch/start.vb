Module start
    Private Function GetKey() As String
        Dim key As String
        key = Configuration.ConfigurationManager.AppSettings("KEY_EXEC")

        Return key
    End Function

    Private Function GetTimeOut() As Integer
        Dim key As Integer
        key = Configuration.ConfigurationManager.AppSettings("KEY_TIMEOUTMIN")
        Return key
    End Function
    Private Sub LaunchMappingFolder()
        Process.Start("connectBizkeys.bat")
    End Sub
    Private Function isvalidArgument(ByVal cmdArgs() As String) As String
        If cmdArgs.Length > 0 AndAlso cmdArgs.Length < 3 Then
            If cmdArgs(0) = GetKey() Then
                If cmdArgs(1) = "prod" Or cmdArgs(1) = "test" Then
                    Return cmdArgs(1)
                Else
                    Return String.Empty
                End If
            Else
                Return String.Empty
            End If
        Else
            Return String.Empty
        End If

    End Function

    Function Main(ByVal cmdArgs() As String) As Integer

        Dim env As String

        env = isvalidArgument(cmdArgs)
        Try
            If env <> String.Empty Then
                DvdPostData.clsSession.isBatch = True
                DvdPostData.clsSession.user_id = 0
                DvdPostData.clsConnection.typeEnv = env
                DvdPostData.clsSession.isEnvTest = env = "test"
                DvdPostData.clsConnection.timeoutMIN = GetTimeOut()

                LaunchMappingFolder()

                Dim clscust As New DVDPostBuziness.ClsCustomers()

                clscust.ReconductionOgone(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ReconductionOgone(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                'clscust.ReconductionOgoneADULTSVOD(DvdPostData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionOgoneADULTSVOD(DvdPostData.ClsCustomersData.Country.NEDERLANDS)
                'clscust.ReconductionOgoneADULTSVOD(DvdPostData.ClsCustomersData.Country.LUXEMBOURG)

                clscust.ChangeCard_customers(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ChangeCard_customers(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                'ogone reject payment for customer who pay after duration limit
                clscust.RejetFileOgone()

                clscust.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.NEDERLANDS)
                clscust.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.LUXEMBOURG)

                'clscust.ReconductionDomiciliationADULTSVOD(DvdPostData.ClsCustomersData.Country.BELGIUM)

                If (Configuration.ConfigurationManager.AppSettings("edd") = "true") Then
                    'clscust.DomiciliationReturnedToRecurent(DvdPostData.ClsCustomersData.Country.BELGIUM)
                    clscust.DomiciliationForceMandateUpdate(DvdPostData.ClsCustomersData.Country.BELGIUM)
                End If

                'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.BELGIQUE)
                'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.PAYSBAS)

                'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.BELGIQUE)
                'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.PAYSBAS)

                clscust.ReconductionVirement(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ReconductionVirement(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                'clscust.ReconductionVirementADULTSVOD(DvdPostData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionVirementADULTSVOD(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                If (Configuration.ConfigurationManager.AppSettings("virmanonemail") = "true") Then
                    DVDPostBuziness.ClsBankTransfer.printAndSendEmail()
                Else
                    DVDPostBuziness.ClsBankTransfer.print()
                End If
                Dim _OffLinePay As New DVDPostBuziness.clsOffLinePayments()
                _OffLinePay.DomiciliationPaymentRecovery_ApplyAllTransitions()
                _OffLinePay.VirmanPaymentRecovery_ApplyAllTransitions()
                _OffLinePay.OgonePaymentRecovery_ApplyAllTransitions()
                _OffLinePay.PayPalPaymentRecovery_ApplyAllTransitions()
                '_OffLinePay.ApplyAllTransitions()

                If (Configuration.ConfigurationManager.AppSettings("eddprepayment") = "true") Then
                    _OffLinePay.SendEDDPrepaymentMail(Configuration.ConfigurationManager.AppSettings("eddprepaymentnotif"))
                End If

                DVDPostBuziness.ClsCredits.UpdateCreditMoreMonth()
                'Dim sql As String
                'Sql = DvdPostData.clsProductDvd.GetStepProductDisabled()
                'DvdPostData.clsConnection.ExecuteNonQuery(sql)

                DVDPostBuziness.clsOffLinePayments.matchingOffline()
                'DVDPostBuziness.ClsBankTransfer.matching()
                clscust.CreateCustomersRotation()
                Dim sql As String
                'call store procedure to calculate average of the duration of keeping dvdat home
                sql = DvdPostData.ClsPurchaseSale.GetInsertCreateRateRotationAbo()
                DvdPostData.clsConnection.ExecuteNonQuery(sql)

                ' Dim cls As New DVDPostBuziness.ClsPurchaseSale
                ' cls.CreatePrevisionAchat()

                'calculate vod statistic
                DVDPostBuziness.ClsVod.InsertStatVod()
                clscust.UpdateDvd_at_Home()
                DVDPostBuziness.ClsVod.UpdateVodCreditsAfterStartPeriod()
                DVDPostBuziness.ClsVod.UpdateSoonVod()
                DVDPostBuziness.ClsproductsDvd.UpdateInCinema(Configuration.ConfigurationManager.AppSettings("notincinemaafterdays"))

                clscust.ReconductionPayPal(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ReconductionPayPal(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                clscust.RetryChangedPayPalPayment(DvdPostData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionPayPalADULTSVOD(DvdPostData.ClsCustomersData.Country.BELGIUM)
                'clscust.ReconductionPayPalADULTSVOD(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                'PPV
                If (Configuration.ConfigurationManager.AppSettings("do_ppv") = "true") Then
                    Dim clsPPV As DVDPostBuziness.clsPPV = New DVDPostBuziness.clsPPV
                    clsPPV.CreatePPVPaymentsManager(DvdPostData.ClsCustomersData.Country.BELGIUM, DateTime.Now.Date.AddDays(-1), DateTime.Now.Date)
                End If

                clscust.SendDVDNOTReturnedMoreThenMonth(5)


            Else
                Console.WriteLine("Error Argument")
            End If

        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Batch, ex)
        End Try

    End Function

End Module
