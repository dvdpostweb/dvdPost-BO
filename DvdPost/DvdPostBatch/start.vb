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

                clscust.ChangeCard_customers(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ChangeCard_customers(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                clscust.RejetFileOgone()

                clscust.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.BELGIUM)

                'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.BELGIQUE)
                'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.PAYSBAS)

                'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.BELGIQUE)
                'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.PAYSBAS)

                clscust.ReconductionVirement(DvdPostData.ClsCustomersData.Country.BELGIUM)
                clscust.ReconductionVirement(DvdPostData.ClsCustomersData.Country.NEDERLANDS)

                DVDPostBuziness.ClsBankTransfer.print()

                Dim _OffLinePay As New DVDPostBuziness.clsOffLinePayments()
                _OffLinePay.ApplyAllTransitions()

                DVDPostBuziness.ClsCredits.UpdateCreditMoreMonth()
                'Dim sql As String
                'Sql = DvdPostData.clsProductDvd.GetStepProductDisabled()
                'DvdPostData.clsConnection.ExecuteNonQuery(sql)

                DVDPostBuziness.clsOffLinePayments.matchingOffline()
                'DVDPostBuziness.ClsBankTransfer.matching()
                clscust.CreateCustomersRotation()
                Dim sql As String
                Sql = DvdPostData.ClsPurchaseSale.GetInsertCreateRateRotationAbo()
                DvdPostData.clsConnection.ExecuteNonQuery(Sql)

                ' Dim cls As New DVDPostBuziness.ClsPurchaseSale
                ' cls.CreatePrevisionAchat()

                DVDPostBuziness.ClsVod.InsertStatVod()
                clscust.UpdateDvd_at_Home()

            Else
                Console.WriteLine("Error Argument")
            End If

        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Batch, ex)
        End Try

    End Function

End Module
