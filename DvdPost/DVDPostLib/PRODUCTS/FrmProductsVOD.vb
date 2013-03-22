Imports System.Collections.Generic
Public Class FrmProductsVOD
    Inherits BizzLib.frmBKForm
    Private _dtLanguage As DataTable
    Dim _dtLanguageSound As DataTable
    Dim _dtLanguageSubtitle As DataTable
    Dim _dtSupport As DataTable
    'Igor


    Const KEYWEBSITE As String = "WEBSITEVOD"

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
        CHOOSEVOD
    End Enum

    Enum typeSearch
        DETAIL
        ALL
    End Enum
    Private _typesearch As typeSearch
    Private Sub initForm()
        Dim blank As String = String.Empty

        txtId.EditValue = Nothing
        TxtFilename.EditValue = blank
        txtImdbView.EditValue = blank

        cmbDateExpired.EditValue = blank
        cmbDateStart.EditValue = blank
        cmbDateLaterStart.EditValue = blank
        cmbDateLaterExpired.EditValue = blank
        cmbLanguageSound.EditValue = 0
        cmbLanguageSubtitle.EditValue = 0
        cmbStudioEdit.EditValue = blank
        cmbStatus.EditValue = blank
        chkAvailable.Checked = False
        chkIsPPV.Checked = False
        txtPPVPrice.EditValue = blank
        chkIsPPVLU.Checked = False
        txtPPVPriceLU.EditValue = blank
        chkIsPPVNL.Checked = False
        txtPPVPriceNL.EditValue = blank

    End Sub
    Private Sub loadData(ByVal row As DataRow)

        txtId.EditValue = row("id")
        If row("filename") Is DBNull.Value Then
            TxtFilename.EditValue = ""
        Else
            TxtFilename.EditValue = row("filename")
        End If

        txtImdbView.EditValue = row("imdb_id")

        If row("expire_at") Is DBNull.Value Then
            cmbDateExpired.EditValue = DateTime.MinValue
        Else
            cmbDateExpired.EditValue = row("expire_at")
        End If

        If row("available_from") Is DBNull.Value Then
            cmbDateStart.EditValue = DateTime.MinValue
        Else
            cmbDateStart.EditValue = row("available_from")
        End If

        If row("available_backcatalogue_from") Is DBNull.Value Then
            cmbDateLaterStart.EditValue = DateTime.MinValue
        Else
            cmbDateLaterStart.EditValue = row("available_backcatalogue_from")
        End If

        If row("expire_backcatalogue_at") Is DBNull.Value Then
            cmbDateLaterExpired.EditValue = DateTime.MinValue
        Else
            cmbDateLaterExpired.EditValue = row("expire_backcatalogue_at")
        End If

        If (row("language_id") Is DBNull.Value) Then
            cmbLanguageSound.EditValue = 0
        Else
            cmbLanguageSound.EditValue = row("language_id")
        End If

        If row("subtitle_id") Is DBNull.Value Then
            cmbLanguageSubtitle.EditValue = 0
        Else

            cmbLanguageSubtitle.EditValue = row("subtitle_id")
        End If
        If row("studio_id") Is DBNull.Value Then
            cmbStudioEdit.EditValue = 0
        Else
            cmbStudioEdit.EditValue = CInt(row("studio_id"))
        End If

        chkAvailable.Checked = row("available")

        cmbStatus.EditValue = row("status")
        If row("quality") Is DBNull.Value Then
            cmbQuality.EditValue = ""
        Else
            cmbQuality.EditValue = row("quality")
        End If

        cmbSource.EditValue = row("source")
        cmbSupportVod.EditValue = row("vod_support_id")

        spedCredit.EditValue = row("credits")

        If row("is_ppv") Is DBNull.Value Then
            chkIsPPV.Checked = False
        Else
            chkIsPPV.Checked = row("is_ppv")
        End If

        If row("ppv_price") Is DBNull.Value Then
            txtPPVPrice.Text = String.Empty
        Else
            txtPPVPrice.Text = row("ppv_price")
        End If

    End Sub

    Private Sub ClearLUData()
        chkLU.Checked = False
        txtIdLU.EditValue = Nothing
        cmbDateExpiredLU.EditValue = DateTime.MinValue
        cmbDateStartLU.EditValue = DateTime.MinValue
        cmbDateLaterStartLU.EditValue = DateTime.MinValue
        cmbDateLaterExpiredLU.EditValue = DateTime.MinValue
        chkAvailableLU.Checked = False
        'cmbStatusLU.Text = String.Empty
        spedCreditLU.EditValue = String.Empty
        chkIsPPVLU.Checked = False
        txtPPVPriceLU.Text = String.Empty

    End Sub
    Private Sub loadDataLU(ByVal row As DataRow)

        chkLU.Checked = True
        txtIdLU.EditValue = row("id")

        If row("expire_at") Is DBNull.Value Then
            cmbDateExpiredLU.EditValue = DateTime.MinValue
        Else
            cmbDateExpiredLU.EditValue = row("expire_at")
        End If

        If row("available_from") Is DBNull.Value Then
            cmbDateStartLU.EditValue = DateTime.MinValue
        Else
            cmbDateStartLU.EditValue = row("available_from")
        End If

        If row("available_backcatalogue_from") Is DBNull.Value Then
            cmbDateLaterStartLU.EditValue = DateTime.MinValue
        Else
            cmbDateLaterStartLU.EditValue = row("available_backcatalogue_from")
        End If

        If row("expire_backcatalogue_at") Is DBNull.Value Then
            cmbDateLaterExpiredLU.EditValue = DateTime.MinValue
        Else
            cmbDateLaterExpiredLU.EditValue = row("expire_backcatalogue_at")
        End If

        chkAvailableLU.Checked = row("available")

        'cmbStatusLU.EditValue = row("status")

        spedCreditLU.EditValue = row("credits")

        If row("is_ppv") Is DBNull.Value Then
            chkIsPPVLU.Checked = False
        Else
            chkIsPPVLU.Checked = row("is_ppv")
        End If

        If row("ppv_price") Is DBNull.Value Then
            txtPPVPriceLU.Text = String.Empty
        Else
            txtPPVPriceLU.Text = row("ppv_price")
        End If

    End Sub

    Private Sub ClearNLData()
        chkNL.Checked = False
        txtIdNL.EditValue = Nothing
        cmbDateExpiredNL.EditValue = DateTime.MinValue
        cmbDateStartNL.EditValue = DateTime.MinValue
        cmbDateLaterStartNL.EditValue = DateTime.MinValue
        cmbDateLaterExpiredNL.EditValue = DateTime.MinValue
        chkAvailableNL.Checked = False
        'cmbStatusNL.Text = String.Empty
        spedCreditNL.EditValue = String.Empty
        chkIsPPVNL.Checked = False
        txtPPVPriceNL.Text = String.Empty

    End Sub

    Private Sub loadDataNL(ByVal row As DataRow)

        chkNL.Checked = True
        txtIdNL.EditValue = row("id")

        If row("expire_at") Is DBNull.Value Then
            cmbDateExpiredNL.EditValue = DateTime.MinValue
        Else
            cmbDateExpiredNL.EditValue = row("expire_at")
        End If

        If row("available_from") Is DBNull.Value Then
            cmbDateStartNL.EditValue = DateTime.MinValue
        Else
            cmbDateStartNL.EditValue = row("available_from")
        End If

        If row("available_backcatalogue_from") Is DBNull.Value Then
            cmbDateLaterStartNL.EditValue = DateTime.MinValue
        Else
            cmbDateLaterStartNL.EditValue = row("available_backcatalogue_from")
        End If

        If row("expire_backcatalogue_at") Is DBNull.Value Then
            cmbDateLaterExpiredNL.EditValue = DateTime.MinValue
        Else
            cmbDateLaterExpiredNL.EditValue = row("expire_backcatalogue_at")
        End If

        chkAvailableNL.Checked = row("available")

        'cmbStatusNL.EditValue = row("status")

        spedCreditNL.EditValue = row("credits")

        If row("is_ppv") Is DBNull.Value Then
            chkIsPPVNL.Checked = False
        Else
            chkIsPPVNL.Checked = row("is_ppv")
        End If

        If row("ppv_price") Is DBNull.Value Then
            txtPPVPriceNL.Text = String.Empty
        Else
            txtPPVPriceNL.Text = row("ppv_price")
        End If

    End Sub



    Private Sub EnableField(ByVal enable As Boolean)

        TxtFilename.Enabled = enable
        txtImdbView.Enabled = enable
        cmbDateExpired.Enabled = enable
        cmbDateStart.Enabled = enable
        cmbDateLaterStart.Enabled = enable
        cmbDateLaterExpired.Enabled = enable
        cmbLanguageSound.Enabled = enable
        cmbLanguageSubtitle.Enabled = enable
        cmbStatus.Enabled = enable
        chkAvailable.Enabled = enable
        cmbStudioEdit.Enabled = enable
        cmbQuality.Enabled = enable
        cmbSource.Enabled = enable
        cmbSupportVod.Enabled = enable
        spedCredit.Enabled = enable
        chkIsPPV.Enabled = enable
        txtPPVPrice.Enabled = enable And chkIsPPV.Checked

        LuxEnable(enable)
        NLEnable(enable)

    End Sub
    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditVod.Enabled = True
                btnSaveVod.Enabled = False
                btnCancelVod.Enabled = False
                btnDeleteVOD.Enabled = True

                EnableField(False)

                XTabSearch.PageVisible = True
                XTabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditVod.Enabled = False
                btnSaveVod.Enabled = True
                btnCancelVod.Enabled = True
                btnDeleteVOD.Enabled = True

                EnableField(True)
                XTabView.PageVisible = True
                XTabResult.PageVisible = False

            Case StepForm.INIT
                btnEditVod.Enabled = False
                btnSaveVod.Enabled = False
                btnCancelVod.Enabled = False
                btnDeleteVOD.Enabled = False

                EnableField(False)

                XTabResult.PageVisible = False
                XTabSearch.PageVisible = True
                XTabView.PageVisible = False
                XTabControlVod.SelectedTabPage = XTabSearch


            Case StepForm.[NEW]
                btnEditVod.Enabled = False
                btnSaveVod.Enabled = True
                btnCancelVod.Enabled = True
                btnDeleteVOD.Enabled = False

                EnableField(True)
                XTabResult.PageVisible = False
                XTabView.PageVisible = True
                XTabControlVod.SelectedTabPage = XTabView

            Case StepForm.SAVE
                btnEditVod.Enabled = True
                btnSaveVod.Enabled = False
                btnCancelVod.Enabled = False
                btnDeleteVOD.Enabled = True

                EnableField(False)
                XTabView.PageVisible = True
                XTabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditVod.Enabled = True
                btnSaveVod.Enabled = False
                btnCancelVod.Enabled = False

                EnableField(False)
                XTabResult.PageVisible = True
                XTabView.PageVisible = False
                XTabControlVod.SelectedTabPage = XTabResult

            Case StepForm.CHOOSEVOD
                btnEditVod.Enabled = True
                btnSaveVod.Enabled = False
                btnCancelVod.Enabled = False

                EnableField(False)
                XTabView.PageVisible = True
                XTabControlVod.SelectedTabPage = XTabView

        End Select
    End Sub

    Private Sub loadSupportVod()
        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "code"
        sql = DvdPostData.ClsVod.GetSupportVod()
        _dtSupport = DvdPostData.clsConnection.FillDataSet(sql)


        cmbSupportVod.Properties.ValueMember = key
        cmbSupportVod.Properties.DisplayMember = value
        cmbSupportVod.Properties.DataSource = _dtSupport

        RepositorycmbSupportVod.ValueMember = key
        RepositorycmbSupportVod.DisplayMember = value
        RepositorycmbSupportVod.DataSource = _dtSupport

    End Sub
    Private Sub loadStudio()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsVod.GetStudio()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        cmbStudio.ValueMember = "studio_id"
        cmbStudio.DisplayMember = "studio_name"
        cmbStudio.DataSource = dt

        RepositoryCmbStudio.ValueMember = "studio_id"
        RepositoryCmbStudio.DisplayMember = "studio_name"
        RepositoryCmbStudio.DataSource = dt

        cmbStudioEdit.Properties.ValueMember = "studio_id"
        cmbStudioEdit.Properties.DisplayMember = "studio_name"
        cmbStudioEdit.Properties.DataSource = dt

    End Sub
    Private Sub loadSource()
        Dim sql As String

        Dim lstSource As List(Of DVDPostBuziness.clsKeyComboEnum)
        sql = DvdPostData.ClsVod.GetEnumMysqlSource()
        lstSource = DVDPostBuziness.ClsCombo.GetListEnum(sql)

        cmbSource.Properties.ValueMember = "Value"
        cmbSource.Properties.DisplayMember = "DisplayMember"
        cmbSource.Properties.DataSource = lstSource
    End Sub
    Private Sub loadquality()
        Dim lstquality As List(Of DVDPostBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = DvdPostData.ClsVod.GetEnumMysqlQuality()
        lstquality = DVDPostBuziness.ClsCombo.GetListEnum(sql)
        lstquality.Add(New DVDPostBuziness.clsKeyComboEnum("", ""))
        cmbQuality.Properties.ValueMember = "Value"
        cmbQuality.Properties.DisplayMember = "DisplayMember"
        cmbQuality.Properties.DataSource = lstquality

    End Sub
    Private Sub loadStatus()
        Dim lststatus As List(Of DVDPostBuziness.clsKeyComboEnum)
        Dim sql As String

        Sql = DvdPostData.ClsVod.GetEnumMysqlStatus()
        lststatus = DVDPostBuziness.ClsCombo.GetListEnum(sql)

        cmbStatus.Properties.ValueMember = "Value"
        cmbStatus.Properties.DisplayMember = "DisplayMember"
        cmbStatus.Properties.DataSource = lststatus

        'cmbStatusLU.Properties.ValueMember = "Value"
        'cmbStatusLU.Properties.DisplayMember = "DisplayMember"
        'cmbStatusLU.Properties.DataSource = lststatus

        'cmbStatusNL.Properties.ValueMember = "Value"
        'cmbStatusNL.Properties.DisplayMember = "DisplayMember"
        'cmbStatusNL.Properties.DataSource = lststatus

    End Sub
    Private Function SplitFileName(ByVal full_filename As String) As String()
        Dim lst_elt() As String
        lst_elt = full_filename.Split(".")
        lst_elt = lst_elt(0).Split("_")
        Return lst_elt

    End Function



    Private Function SearchLangID(ByVal language_code As String, ByVal filename As String) As Integer

        If language_code.ToUpper() = "NIL" Then
            Return -1
        End If

        Dim lst_dr() As DataRow
        If _dtLanguage.Rows.Count > 0 Then
            lst_dr = _dtLanguage.Select("code = '" & language_code.ToUpper() & "'")
            If lst_dr.Length = 1 Then
                Return lst_dr(0)("languages_id")
            Else
                Throw New Exception("The code language " & language_code & " is not valid " & filename)
            End If

        End If

    End Function
    Private Sub LoadLanguageProcess()
        Dim sql As String

        sql = DvdPostData.ClsVod.GetAllLanguage()
        _dtLanguage = DvdPostData.clsConnection.FillDataSet(sql)

    End Sub

    Private Sub loadLanguage()
        Dim sql As String
        Dim key As String = "id"
        Dim keySubtitle As String = "subtitle_id"
        Dim value As String = "code"
        Dim lngdsc As String = "lngdsc"

        sql = DvdPostData.ClsVod.GetAllLanguage()
        _dtLanguageSound = DvdPostData.clsConnection.FillDataSet(sql)
        sql = DvdPostData.ClsVod.GetAllSubtitle()
        _dtLanguageSubtitle = DvdPostData.clsConnection.FillDataSet(sql)

        RepositorycmbLanguage.ValueMember = key
        RepositorycmbLanguage.DisplayMember = value
        RepositorycmbLanguage.DataSource = _dtLanguageSound

        repLanguageTrailers.ValueMember = key
        repLanguageTrailers.DisplayMember = value
        repLanguageTrailers.DataSource = _dtLanguageSound

        cmbLanguages.ValueMember = key
        cmbLanguages.DisplayMember = value
        cmbLanguages.DataSource = _dtLanguageSound


        cmbLanguageSound.Properties.ValueMember = key
        cmbLanguageSound.Properties.DisplayMember = lngdsc
        cmbLanguageSound.Properties.DataSource = _dtLanguageSound

        _dtLanguageSubtitle = DVDPostBuziness.ClsCombo.addRowEmpty(_dtLanguageSubtitle)
        cmbLanguageSubtitle.Properties.ValueMember = keySubtitle
        cmbLanguageSubtitle.Properties.DisplayMember = lngdsc
        cmbLanguageSubtitle.Properties.DataSource = _dtLanguageSubtitle

        cmbLanguagesSubtitleEdit.ValueMember = keySubtitle
        cmbLanguagesSubtitleEdit.DisplayMember = value
        cmbLanguagesSubtitleEdit.DataSource = _dtLanguageSubtitle

        RepositoryLanguageSubtitleGrid.ValueMember = keySubtitle
        RepositoryLanguageSubtitleGrid.DisplayMember = value
        RepositoryLanguageSubtitleGrid.DataSource = _dtLanguageSubtitle

        repSubtitleTrailers.ValueMember = keySubtitle
        repSubtitleTrailers.DisplayMember = value
        repSubtitleTrailers.DataSource = _dtLanguageSubtitle




    End Sub

    'Private Sub loadInfoVod(ByVal streaming_products_id As Integer)
    '    Dim sql As String
    '    Dim dt As DataTable

    '    sql = DvdPostData.ClsVod.SearchViewVodId(streaming_products_id)
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    If dt.Rows.Count > 0 Then
    '        loadData(dt.Rows(0))
    '    End If

    'End Sub
    Private Sub loadInfoVod()

        Dim row As DataRow
        If GridViewSearch.RowCount > 0 Then
            row = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle())
            loadData(row)
            Dim drLU As DataRow() = CType(GridVod.DataSource, DataTable).Select("imdb_id = " & row("imdb_id") & " " & IIf(IsDBNull(row("language_id")), " and language_id is null ", " and language_id = " & row("language_id")) & " and id <> " & row("id") & IIf(IsDBNull(row("subtitle_id")), " and subtitle_id is null ", " and subtitle_id = " & row("subtitle_id")) & " and source = 'alphanetworks' and status <> 'deleted' and country = 'LU' ")
            If drLU.Length > 0 Then
                loadDataLU(drLU(0))
            Else
                ClearLUData()
            End If
            Dim drNL As DataRow() = CType(GridVod.DataSource, DataTable).Select("imdb_id = " & row("imdb_id") & " " & IIf(IsDBNull(row("language_id")), " and language_id is null ", " and language_id = " & row("language_id")) & " " & IIf(IsDBNull(row("subtitle_id")), " and subtitle_id is null ", " and subtitle_id = " & row("subtitle_id")) & " and id <> " & row("id") & " and source = 'alphanetworks' and status <> 'deleted' and country = 'NL' ")
            If drNL.Length > 0 Then
                loadDataNL(drNL(0))
            Else
                ClearNLData()
            End If

        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim sql As String
        Dim dt As DataTable = Nothing
        Dim dtBE As DataTable = Nothing

        If txtTitleSearch.EditValue <> String.Empty Then
            sql = DvdPostData.ClsVod.SearchViewVodpartTitle(txtTitleSearch.EditValue)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
        ElseIf TxtProducts_id.EditValue <> String.Empty Then
            sql = DvdPostData.ClsVod.SearchViewVodProduct(TxtProducts_id.EditValue)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
        ElseIf txtImdb.EditValue <> String.Empty Then
            sql = DvdPostData.ClsVod.SearchViewVodImdb(txtImdb.EditValue)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
        End If
        If Not dt Is Nothing Then
            GridVod.DataSource = dt

            GridViewSearch.ActiveFilterString = "country = 'BE'"

            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.DETAIL
        End If


    End Sub
    Private Function Save() As Boolean
        Dim sql As String
        Try

            If txtId.EditValue Is Nothing Then
                sql = DvdPostData.ClsVod.GetInsertVod(txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStart.EditValue, cmbDateExpired.EditValue, chkAvailable.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCredit.EditValue, cmbDateLaterStart.EditValue, cmbDateLaterExpired.EditValue, chkIsPPV.EditValue, txtPPVPrice.EditValue, "BE")
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
                If chkLU.Checked Then
                    sql = DvdPostData.ClsVod.GetInsertVod(txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStart.EditValue, cmbDateExpired.EditValue, chkAvailable.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCredit.EditValue, cmbDateLaterStart.EditValue, cmbDateLaterExpired.EditValue, chkIsPPV.EditValue, txtPPVPrice.EditValue, "LU")
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)
                End If
                If chkNL.Checked Then
                    sql = DvdPostData.ClsVod.GetInsertVod(txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStart.EditValue, cmbDateExpired.EditValue, chkAvailable.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCredit.EditValue, cmbDateLaterStart.EditValue, cmbDateLaterExpired.EditValue, chkIsPPV.EditValue, txtPPVPrice.EditValue, "NL")
                    DvdPostData.clsConnection.ExecuteNonQuery(sql)
                End If
            Else
                sql = DvdPostData.ClsVod.GetUpdateVod(txtId.EditValue, txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStart.EditValue, cmbDateExpired.EditValue, chkAvailable.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCredit.EditValue, cmbDateLaterStart.EditValue, cmbDateLaterExpired.EditValue, chkIsPPV.EditValue, txtPPVPrice.EditValue, "BE")
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
                If chkLU.Checked Then
                    If txtIdLU.EditValue Is Nothing Then
                        sql = DvdPostData.ClsVod.GetInsertVod(txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStartLU.EditValue, cmbDateExpiredLU.EditValue, chkAvailableLU.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCreditLU.EditValue, cmbDateLaterStartLU.EditValue, cmbDateLaterExpiredLU.EditValue, chkIsPPVLU.EditValue, txtPPVPriceLU.EditValue, "LU")
                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                    Else
                        sql = DvdPostData.ClsVod.GetUpdateVod(txtIdLU.EditValue, txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStartLU.EditValue, cmbDateExpiredLU.EditValue, chkAvailableLU.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCreditLU.EditValue, cmbDateLaterStartLU.EditValue, cmbDateLaterExpiredLU.EditValue, chkIsPPVLU.EditValue, txtPPVPriceLU.EditValue, "LU")
                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                    End If
                End If
                If chkNL.Checked Then
                    If txtIdNL.EditValue Is Nothing Then
                        sql = DvdPostData.ClsVod.GetInsertVod(txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStartNL.EditValue, cmbDateExpiredNL.EditValue, chkAvailableNL.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCreditNL.EditValue, cmbDateLaterStartNL.EditValue, cmbDateLaterExpiredNL.EditValue, chkIsPPVNL.EditValue, txtPPVPriceNL.EditValue, "NL")
                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                    Else
                        sql = DvdPostData.ClsVod.GetUpdateVod(txtIdNL.EditValue, txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStartNL.EditValue, cmbDateExpiredNL.EditValue, chkAvailableNL.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCreditNL.EditValue, cmbDateLaterStartNL.EditValue, cmbDateLaterExpiredNL.EditValue, chkIsPPVNL.EditValue, txtPPVPriceNL.EditValue, "NL")
                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                    End If
                End If

            End If
            Return True
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Vod, ex)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Vod, sql)
            Return False
        End Try
    End Function

    Private Sub BtnNewVodProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVodProduct.Click
        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnSaveVod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveVod.Click
        If Save() Then
            ChangeStep(StepForm.SAVE)
            If _typesearch = typeSearch.DETAIL Then
                btnSearch_Click(Nothing, Nothing)
            Else
                BtnViewAll_Click(Nothing, Nothing)
            End If
        Else
            MsgBox("Error Save Vod (voir log)", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnEditVod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditVod.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub GridVod_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVod.DoubleClick
        loadInfoVod()
        ChangeStep(StepForm.CHOOSEVOD)
    End Sub

    Private Sub btnCancelVod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelVod.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridVod.ContextMenuStrip = menuStrip
        loadLanguage()
        loadStudio()
        loadStatus()
        loadquality()
        loadSource()

        loadSupportVod()
        txtSourcePath.EditValue = FolderChoose.SelectedPath
        LoadLanguageProcess()
        ' Add any initialization after the InitializeComponent() call.
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsVod.GetEnumMysqlStatus()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Dim statuses As String = dt.Rows()(0)(1)
        statuses = statuses.Replace("'", "")
        statuses = statuses.Replace("enum(", "")
        statuses = statuses.Replace(")", "")
        Dim arrst As String() = statuses.Split(",")
        cmbgridStatus.Items.AddRange(arrst)
        cmbgridStatusTrailer.Items.AddRange(arrst)
        'studio




    End Sub
    Private Sub loadDatatUploaded()
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.SearchViewVodProductUploaded()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        GridVodWatch.DataSource = dt
    End Sub

    Private Sub laodUploadedTrailers()
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.SearchViewTrailersUploaded()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        grdTrailers.DataSource = dt
    End Sub

    Private Sub BtnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAll.Click
        Dim sql As String
        Dim dt As DataTable = Nothing

        sql = DvdPostData.ClsVod.SearchAllViewVod()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If Not dt Is Nothing Then
            GridVod.DataSource = dt
            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.ALL
        End If
    End Sub

    Private Sub btnDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestination.Click
        If txtDestinationPath.EditValue <> "" Then FolderChoose.SelectedPath = txtDestinationPath.EditValue
        If FolderChoose.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDestinationPath.EditValue = FolderChoose.SelectedPath
        End If
    End Sub

    Private Sub btnSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSource.Click
        If txtSourcePath.EditValue <> "" Then FolderChoose.SelectedPath = txtSourcePath.EditValue
        If FolderChoose.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSourcePath.EditValue = FolderChoose.SelectedPath
        End If
    End Sub

    Private Sub btnGenerateRipping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRipping.Click
        ' format fichier = (studio_id,imdb_id,Language_audio_id,language_subtitle_id,quality) 
        Dim files() As String
        Dim elts() As String
        Dim sql As String
        Dim fileZilla As DVDPostBuziness.clsFileZilla = Nothing
        Dim language_audio_id As Integer
        Dim language_subtitle_id As Integer
        Dim filename As String
        Dim strQuality As String
        Dim extension As String = "mp4:"
        Try
            files = System.IO.Directory.GetFiles(txtSourcePath.EditValue, "*.mp4", IO.SearchOption.AllDirectories)

            ProgressBarRipping.Properties.Step = 1
            ProgressBarRipping.Properties.PercentView = True

            ProgressBarRipping.Properties.Maximum = files.Length
            ProgressBarRipping.Properties.Minimum = 0
            Dim fileInfo As System.IO.FileInfo

            If files.Length = 0 Then Return
            fileZilla = New DVDPostBuziness.clsFileZilla(txtDestinationPath.EditValue)
            DvdPostData.clsConnection.CreateTransaction(False)


            For Each file As String In files

                fileInfo = New System.IO.FileInfo(file)
                elts = SplitFileName(fileInfo.Name)

                If elts.Length <> 5 Then Throw New Exception("Fomat File Not Valid " & file)
                'If elts(DVDPostBuziness.clsFileZilla.FormatFile.QUALITY) = "HIGH" Then
                '    Throw New Exception("HIGH QUALITY Not imported (You want delete the file with HIGH and reprocess folder) ")
                'End If
                strQuality = elts(DVDPostBuziness.clsFileZilla.FormatFile.QUALITY)
                'filename = fileInfo.Name.Replace("_" + elts(DVDPostBuziness.clsFileZilla.FormatFile.QUALITY), "")
                filename = fileInfo.Name
                language_audio_id = SearchLangID(elts(DVDPostBuziness.clsFileZilla.FormatFile.LANGUAGE_AUDIO_ID), filename)
                language_subtitle_id = SearchLangID(elts(DVDPostBuziness.clsFileZilla.FormatFile.LANGUAGE_SUBTITLE_ID), filename)
                sql = DvdPostData.ClsVod.GetInsertVod(elts(DVDPostBuziness.clsFileZilla.FormatFile.IMDB_ID), extension + filename, Date.MinValue, Date.MinValue, True, language_audio_id, language_subtitle_id, elts(DVDPostBuziness.clsFileZilla.FormatFile.STUDIO_ID), "uploaded", strQuality, "SOFTLAYER", 1, 1, Date.MinValue, Date.MinValue, "false", "", "BE")
                DvdPostData.clsConnection.ExecuteNonQuery(sql)

                fileZilla.InsertNodeQueue(file, fileInfo.Name, fileInfo.Length)
                ProgressBarRipping.PerformStep()
                ProgressBarRipping.Refresh()
            Next
            Threading.Thread.Sleep(1000)
            fileZilla.save()
            DvdPostData.clsConnection.CommitTransaction(True)
            MsgBox("finish")


        Catch ex As Exception
            If Not fileZilla Is Nothing Then
                fileZilla.DeleteFile()
            End If
            DvdPostData.clsConnection.CommitTransaction(False)
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            ProgressBarRipping.Position = 0
            ProgressBarRipping.Refresh()
            ProgressBarRipping.Reset()
        End Try

    End Sub


    Private Sub XTabControlVod_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTabControlVod.SelectedPageChanged
        If XTabControlVod.SelectedTabPage Is XTabViewVod Then
            loadDatatUploaded()
        ElseIf XTabControlVod.SelectedTabPage Is xTabTrailers Then
            laodUploadedTrailers()
        End If
    End Sub

    Private Sub GridVodWatch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVodWatch.DoubleClick
        Dim row As DataRow
        If gridViewVodWatch.RowCount > 0 Then
            row = gridViewVodWatch.GetDataRow(gridViewVodWatch.FocusedRowHandle())
            loadData(row)
            Dim drLU As DataRow() = CType(GridVodWatch.DataSource, DataTable).Select("imdb_id = " & row("imdb_id") & " " & IIf(IsDBNull(row("language_id")), " and language_id is null ", " and language_id = " & row("language_id")) & " and id <> " & row("id") & IIf(IsDBNull(row("subtitle_id")), " and subtitle_id is null ", " and subtitle_id = " & row("subtitle_id")) & " and source = 'alphanetworks' and status <> 'deleted' and country = 'LU' ")
            If drLU.Length > 0 Then
                loadDataLU(drLU(0))
            Else
                ClearLUData()
            End If
            Dim drNL As DataRow() = CType(GridVodWatch.DataSource, DataTable).Select("imdb_id = " & row("imdb_id") & " " & IIf(IsDBNull(row("language_id")), " and language_id is null ", " and language_id = " & row("language_id")) & " " & IIf(IsDBNull(row("subtitle_id")), " and subtitle_id is null ", " and subtitle_id = " & row("subtitle_id")) & " and id <> " & row("id") & " and source = 'alphanetworks' and status <> 'deleted' and country = 'NL' ")
            If drNL.Length > 0 Then
                loadDataNL(drNL(0))
            Else
                ClearNLData()
            End If
        End If
        ChangeStep(StepForm.CHOOSEVOD)
    End Sub
    Private Sub loadInfoVodWatch()

        Dim row As DataRow
        If gridViewVodWatch.RowCount > 0 Then
            row = gridViewVodWatch.GetDataRow(gridViewVodWatch.FocusedRowHandle())
            loadData(row)
            Dim drLU As DataRow() = CType(GridVodWatch.DataSource, DataTable).Select("imdb_id = " & row("imdb_id") & " " & IIf(IsDBNull(row("language_id")), " and language_id is null ", " and language_id = " & row("language_id")) & " and id <> " & row("id") & IIf(IsDBNull(row("subtitle_id")), " and subtitle_id is null ", " and subtitle_id = " & row("subtitle_id")) & " and source = 'alphanetworks' and status <> 'deleted' and country = 'LU' ")
            If drLU.Length > 0 Then
                loadDataLU(drLU(0))
            Else
                ClearLUData()
            End If
            Dim drNL As DataRow() = CType(GridVodWatch.DataSource, DataTable).Select("imdb_id = " & row("imdb_id") & " " & IIf(IsDBNull(row("language_id")), " and language_id is null ", " and language_id = " & row("language_id")) & " " & IIf(IsDBNull(row("subtitle_id")), " and subtitle_id is null ", " and subtitle_id = " & row("subtitle_id")) & " and id <> " & row("id") & " and source = 'alphanetworks' and status <> 'deleted' and country = 'NL' ")
            If drNL.Length > 0 Then
                loadDataNL(drNL(0))
            Else
                ClearNLData()
            End If
        End If
    End Sub


    Private Sub btnRipped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRipped.Click
        Dim sql As String
        Dim dt As DataTable = Nothing

        sql = DvdPostData.ClsVod.SearchViewVodProductRipped()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridVod.DataSource = dt
        ChangeStep(StepForm.LOAD)

    End Sub
    Private Function CompareDifferent(ByVal dt As DataTable, ByVal col As String, ByVal NameList1 As String, _
                                      ByVal lst2 As List(Of String), ByVal NameList2 As String) As List(Of String)

        Dim filename As String = ""
        Dim lst As String()
        Dim lstResult As New List(Of String)
        Dim index As Integer = dt.Rows.Count - 1
        While index > 0
            lst = dt.Rows(index)(col).ToString().Split(":")
            If lst.Length = 2 Then
                filename = lst(1)
                'filename = filename.Substring(0, filename.Length - 4) + + filename.Substring(filename.Length - 4, 4)
            Else
                filename = lst(0)
            End If
            If lst2.Contains(filename) Then
                lst2.Remove(filename)
                dt.Rows.RemoveAt(index)
            Else
                lstResult.Add(filename + " -> " + NameList1 + " status : " & dt.Rows(index)("status") & " available : " & dt.Rows(index)("available"))
            End If
            index -= 1
        End While


        For Each Item As String In lst2

            lstResult.Add(Item + " <- " & NameList2)
        Next

        Return lstResult

    End Function


    Private Function CompareDifferent(ByVal lst1 As List(Of String), ByVal NameList1 As String, _
                                 ByVal lst2 As List(Of String), ByVal NameList2 As String) As List(Of String)

        Dim lstResult As New List(Of String)
        Dim index As Integer = lst2.Count - 1
        While index > 0

            If lst1.Contains(lst2(index)) Then
                lst1.Remove(lst2(index))
                lst2.RemoveAt(index)
            Else
                lstResult.Add(lst2(index) + " -> " + NameList2)
            End If
            index -= 1
        End While


        For Each Item As String In lst1

            lstResult.Add(Item + " <- " & NameList1)
        Next

        Return lstResult

    End Function
    Private Sub BtnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompare.Click
        Dim lstFilesServerFtp As List(Of String) = Nothing
        Dim tmp As New List(Of String)
        Dim lstFilesServerLocal As List(Of String) = Nothing
        Dim lstFilesResult As List(Of String) = Nothing
        Dim dt As DataTable
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Dim clsFiles As New DVDPostBuziness.clsFiles()
        Dim clsFtp As New DVDPostBuziness.clsFTP()

        lstFilesServerLocal = clsFiles.GetListFilesTree(TxtSourceLocal.EditValue)
        lstFilesServerFtp = clsFtp.GetListFilesTree(txtSourceFtp.EditValue)
        dt = DvdPostData.clsConnection.FillDataSet(DvdPostData.ClsVod.SearchAllViewVod())
        tmp.AddRange(lstFilesServerFtp.ToArray())
        lstFilesResult = CompareDifferent(tmp, "FTP", lstFilesServerLocal, "Local")
        GridFtpLocal.DataSource = lstFilesResult

        lstFilesResult = CompareDifferent(dt, "filename", "DB", lstFilesServerFtp, "FTP")
        GridDBFtp.DataSource = lstFilesResult
        Me.Cursor = Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub btnFolderLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolderLocal.Click
        If TxtSourceLocal.EditValue <> "" Then FolderChoose.SelectedPath = TxtSourceLocal.EditValue
        If FolderChoose.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TxtSourceLocal.EditValue = FolderChoose.SelectedPath
        End If
    End Sub

    Private Sub btnChooseFileTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFileTxt.Click
        If txtPathOfFile.EditValue <> "" Then OpenFile.FileName = txtPathOfFile.EditValue
        OpenFile.FileName = ""
        If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPathOfFile.EditValue = OpenFile.FileName
        End If
    End Sub
    Private Function ExistAlreadyMovie(ByVal result() As String) As Boolean
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.getSelectVod(result(DvdPostData.ClsVod.ListField.IMDB_ID), result(DvdPostData.ClsVod.ListField.LANGUAGE), result(DvdPostData.ClsVod.ListField.SUBTITLE), result(DvdPostData.ClsVod.ListField.SOURCE), result(DvdPostData.ClsVod.ListField.VOD_SUPPORT))
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt.Rows.Count > 0
    End Function


    Private Function ExistAlreadyTrailer(ByVal result() As String) As Boolean
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.getSelectTrailer(result(DvdPostData.ClsVod.TrailerListField.IMDB_ID), result(DvdPostData.ClsVod.TrailerListField.LANGUAGE), result(DvdPostData.ClsVod.TrailerListField.SUBTITLE))
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt.Rows.Count > 0
    End Function

    Private Function ExistMovieData(ByVal imdb_id As Long) As Boolean
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.getSelectMovieData(imdb_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows.Count > 0

    End Function

    Private Function GetInfoVod(ByVal result() As String) As DataRow

        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.getSelectVod(result(DvdPostData.ClsVod.ListField.IMDB_ID), result(DvdPostData.ClsVod.ListField.LANGUAGE), result(DvdPostData.ClsVod.ListField.SUBTITLE))
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If

    End Function

    Private Function TrailerGetInfoVod(ByVal result() As String) As DataRow

        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.getSelectTrailer(result(DvdPostData.ClsVod.TrailerListField.IMDB_ID), result(DvdPostData.ClsVod.TrailerListField.LANGUAGE), result(DvdPostData.ClsVod.TrailerListField.SUBTITLE))
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If

    End Function

    Private Function CheckEltFileName(ByVal elt As String, ByVal key As String) As String

        If elt(0) <> key Then
            Return Nothing
        Else
            Return elt.Substring(1)
        End If

    End Function
    Private Function GetId(ByVal key As String, ByVal dt As DataTable) As Object

        If key = "non" Then Return 0
        Dim dr() As DataRow = dt.Select("code ='" & key & "'")

        If dr.Length <> 1 Then
            Return Nothing
        Else
            Return dr(0)("id")
        End If

    End Function


    Private Function SubtitleGetId(ByVal key As String, ByVal dt As DataTable) As Object

        If key = "non" Then Return 0
        Dim dr() As DataRow = dt.Select("code ='" & key & "'")

        If dr.Length <> 1 Then
            Return Nothing
        Else
            Return dr(0)("subtitle_id")
        End If

    End Function

    Private Sub CheckParseFileName(ByVal name As String, ByRef result() As String)
        ' rules path NameFile@Imdbid_DTypeOfVod_ALanguage_SSubtitle_BitRate.Extension   FATAL@1473357_Dpc_Afre_Snon_3000k.f4v

        Dim elt() As String
        Dim tmp() As String
        Dim valueElt As String
        elt = name.Split("@")

        If elt.Length <> 2 Then
            result = Nothing
            Return
        Else
            tmp = elt(1).Split("_")
            If tmp.Length <> 5 Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.ListField.FILENAME) = elt(0)
                result(DvdPostData.ClsVod.ListField.IMDB_ID) = tmp(0)
            End If

            valueElt = CheckEltFileName(tmp(1), "D")
            If valueElt Is Nothing Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.ListField.VOD_SUPPORT) = valueElt
            End If

            valueElt = CheckEltFileName(tmp(2), "A")
            If valueElt Is Nothing Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.ListField.LANGUAGE) = valueElt
            End If

            valueElt = CheckEltFileName(tmp(3), "S")
            If valueElt Is Nothing Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.ListField.SUBTITLE) = valueElt
            End If

            'Dim fi As System.IO.FileInfo = New System.IO.FileInfo(name)
            'result(DvdPostData.ClsVod.ListField.LANGUAGE) = fi.Extension
        End If

    End Sub

    Private Sub TrailerCheckParseFileName(ByVal name As String, ByRef result() As String)
        ' rules path NameFile@Imdbid_DTypeOfVod_ALanguage_SSubtitle_BitRate.Extension   FATAL@1473357_Dpc_Afre_Snon_3000k.f4v

        Dim elt() As String
        Dim tmp() As String
        Dim valueElt As String
        elt = name.Split("@")

        If elt.Length <> 2 Then
            result = Nothing
            Return
        Else
            tmp = elt(1).Split("_")
            If tmp.Length <> 5 Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.TrailerListField.FILENAME) = elt(0)
                result(DvdPostData.ClsVod.TrailerListField.IMDB_ID) = tmp(0)
            End If

            valueElt = CheckEltFileName(tmp(1), "D")
            If valueElt Is Nothing Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.TrailerListField.VOD_SUPPORT) = valueElt
            End If

            valueElt = CheckEltFileName(tmp(2), "A")
            If valueElt Is Nothing Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.TrailerListField.LANGUAGE) = valueElt
            End If

            valueElt = CheckEltFileName(tmp(3), "S")
            If valueElt Is Nothing Then
                result = Nothing
                Return
            Else
                result(DvdPostData.ClsVod.TrailerListField.SUBTITLE) = valueElt
            End If

        End If

    End Sub

    Private Sub FillEmptyValue(ByRef result() As String)

        result = [Enum].GetNames(GetType(DvdPostData.ClsVod.ListField))
    End Sub
    Private Sub TrailerFillEmptyValue(ByRef result() As String)

        result = [Enum].GetNames(GetType(DvdPostData.ClsVod.TrailerListField))
    End Sub
    Private Sub btnGenerateVod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateVod.Click
        ' parse file path 
        Dim struct As List(Of String)
        LstResult.Items.Clear()
        lstError.Items.Clear()
        If txtPathOfFile.EditValue = String.Empty Then
            Return
        End If
        struct = DVDPostTools.clsFile.openFile(txtPathOfFile.EditValue)
        Dim result() As String = Nothing
        Dim dr As DataRow
        Dim sql As String


        For Each name As String In struct

            If name.StartsWith("trailer_") Then
                TrailerFillEmptyValue(result)
                TrailerCheckParseFileName(name, result)

                If result IsNot Nothing Then

                    result(DvdPostData.ClsVod.TrailerListField.LANGUAGE) = GetId(result(DvdPostData.ClsVod.TrailerListField.LANGUAGE), _dtLanguageSound)
                    result(DvdPostData.ClsVod.TrailerListField.SUBTITLE) = SubtitleGetId(result(DvdPostData.ClsVod.TrailerListField.SUBTITLE), _dtLanguageSubtitle)
                    result(DvdPostData.ClsVod.TrailerListField.VOD_SUPPORT) = GetId(result(DvdPostData.ClsVod.TrailerListField.VOD_SUPPORT), _dtSupport)

                    If result(DvdPostData.ClsVod.TrailerListField.LANGUAGE) Is Nothing _
                       Or result(DvdPostData.ClsVod.TrailerListField.SUBTITLE) Is Nothing Then
                        Continue For
                    End If


                    dr = TrailerGetInfoVod(result)

                    If dr Is Nothing Then
                        result(DvdPostData.ClsVod.TrailerListField.EXPIRE_AT) = Date.MinValue
                    Else

                        If dr("expire_at") IsNot DBNull.Value Then
                            result(DvdPostData.ClsVod.TrailerListField.EXPIRE_AT) = dr("expire_at")
                        Else
                            result(DvdPostData.ClsVod.TrailerListField.EXPIRE_AT) = DateTime.MinValue
                        End If
                    End If

                    result(DvdPostData.ClsVod.TrailerListField.AVAILABLE_FROM) = DateTime.MinValue
                    result(DvdPostData.ClsVod.TrailerListField.STATUS) = "uploaded"
                    result(DvdPostData.ClsVod.TrailerListField.AVAILABLE) = "true"

                    If Not ExistAlreadyTrailer(result) Then
                        sql = DvdPostData.ClsVod.GetInsertTrailer( _
                                result(DvdPostData.ClsVod.TrailerListField.IMDB_ID), _
                                result(DvdPostData.ClsVod.TrailerListField.FILENAME), _
                                result(DvdPostData.ClsVod.TrailerListField.AVAILABLE_FROM), _
                                result(DvdPostData.ClsVod.TrailerListField.EXPIRE_AT), _
                                result(DvdPostData.ClsVod.TrailerListField.AVAILABLE), _
                                result(DvdPostData.ClsVod.TrailerListField.LANGUAGE), _
                                result(DvdPostData.ClsVod.TrailerListField.SUBTITLE), _
                                result(DvdPostData.ClsVod.TrailerListField.STATUS))

                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                        LstResult.Items.Add(name)
                    End If

                Else
                    lstError.Items.Add(name)
                End If
            Else

                FillEmptyValue(result)
                CheckParseFileName(name, result)

                If result IsNot Nothing Then

                    result(DvdPostData.ClsVod.ListField.LANGUAGE) = GetId(result(DvdPostData.ClsVod.ListField.LANGUAGE), _dtLanguageSound)
                    result(DvdPostData.ClsVod.ListField.SUBTITLE) = SubtitleGetId(result(DvdPostData.ClsVod.ListField.SUBTITLE), _dtLanguageSubtitle)
                    result(DvdPostData.ClsVod.ListField.VOD_SUPPORT) = GetId(result(DvdPostData.ClsVod.ListField.VOD_SUPPORT), _dtSupport)

                    If result(DvdPostData.ClsVod.ListField.LANGUAGE) Is Nothing _
                       Or result(DvdPostData.ClsVod.ListField.SUBTITLE) Is Nothing _
                       Or result(DvdPostData.ClsVod.ListField.VOD_SUPPORT) Is Nothing Then
                        Continue For
                    End If


                    dr = GetInfoVod(result)

                    If dr Is Nothing Then
                        result(DvdPostData.ClsVod.ListField.EXPIRE_AT) = Date.MinValue
                        result(DvdPostData.ClsVod.ListField.STUDIO) = ""
                    Else

                        If dr("expire_at") IsNot DBNull.Value Then
                            result(DvdPostData.ClsVod.ListField.EXPIRE_AT) = dr("expire_at")
                        Else
                            result(DvdPostData.ClsVod.ListField.EXPIRE_AT) = DateTime.MinValue
                        End If

                        result(DvdPostData.ClsVod.ListField.STUDIO) = dr("studio_id").ToString()

                        result(DvdPostData.ClsVod.ListField.IS_PPV) = dr("is_ppv").ToString()
                        result(DvdPostData.ClsVod.ListField.PPV_PRICE) = dr("ppv_price").ToString()

                    End If

                    result(DvdPostData.ClsVod.ListField.AVAILABLE_FROM) = DateTime.MinValue
                    result(DvdPostData.ClsVod.ListField.STATUS) = "uploaded"
                    result(DvdPostData.ClsVod.ListField.AVAILABLE) = "true"
                    result(DvdPostData.ClsVod.ListField.SOURCE) = "ALPHANETWORKS"
                    result(DvdPostData.ClsVod.ListField.CREDIT) = 1
                    result(DvdPostData.ClsVod.ListField.AVAILABLE_BACKCATALOGUE_FROM) = Date.MinValue
                    result(DvdPostData.ClsVod.ListField.EXPIRE_BACKKATALOGUE_AT) = Date.MinValue

                    If Not ExistAlreadyMovie(result) Then
                        sql = DvdPostData.ClsVod.GetInsertVod( _
                                result(DvdPostData.ClsVod.ListField.IMDB_ID), _
                                result(DvdPostData.ClsVod.ListField.FILENAME), _
                                result(DvdPostData.ClsVod.ListField.AVAILABLE_FROM), _
                                result(DvdPostData.ClsVod.ListField.EXPIRE_AT), _
                                result(DvdPostData.ClsVod.ListField.AVAILABLE), _
                                result(DvdPostData.ClsVod.ListField.LANGUAGE), _
                                result(DvdPostData.ClsVod.ListField.SUBTITLE), _
                                result(DvdPostData.ClsVod.ListField.STUDIO), _
                                result(DvdPostData.ClsVod.ListField.STATUS), _
                                String.Empty, _
                                result(DvdPostData.ClsVod.ListField.SOURCE), _
                                result(DvdPostData.ClsVod.ListField.VOD_SUPPORT), _
                                Integer.Parse(result(DvdPostData.ClsVod.ListField.CREDIT)), _
                                result(DvdPostData.ClsVod.ListField.AVAILABLE_BACKCATALOGUE_FROM), _
                                result(DvdPostData.ClsVod.ListField.EXPIRE_BACKKATALOGUE_AT), _
                                "false", "", "BE")

                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                        LstResult.Items.Add(name)
                    End If

                Else
                    lstError.Items.Add(name)
                End If
            End If
        Next

    End Sub

    Private Sub RepositoryBtnWatchMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryBtnWatchMovie.Click
        Dim imdb_id As Integer

        If gridViewVodWatch.FocusedRowHandle > -1 Then
            imdb_id = gridViewVodWatch.GetDataRow(gridViewVodWatch.FocusedRowHandle)("imdb_id")
            Dim url As String = Configuration.ConfigurationManager.AppSettings(KEYWEBSITE)

            WebSiteDvdPost.Url = New Uri(url & imdb_id)
            loadInfoVodWatch()
        Else
            MsgBox("after watch movie select product please !", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnAllNoMovieInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllNoMovieInfo.Click
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.getSelectVodNoMovieInfo()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        grdOnlyVODMovie.DataSource = dt
    End Sub

    Private Sub btnDeleteVOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteVOD.Click
        Dim sql As String

        sql = DvdPostData.ClsVod.GetDeleteVod(txtId.Text)


        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        If _typesearch = typeSearch.DETAIL Then
            btnSearch_Click(Nothing, Nothing)
        Else
            BtnViewAll_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnSaveAllChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAllChanges.Click
        Dim dt As DataTable
        dt = GridVod.DataSource.GetChanges()


        If dt Is Nothing Then
            Return
        ElseIf MsgBoxResult.Cancel = MsgBox(dt.Rows.Count & " movies are updated and will be saved, please confim ! ", MsgBoxStyle.OkCancel) Then
            Return
        End If
        For Each dr As DataRow In dt.Rows
            Dim sql As String
            sql = DvdPostData.ClsVod.GetUpdateVod(dr("id"), _
                                        IIf(dr("imdb_id") Is System.DBNull.Value, 0, dr("imdb_id")), _
                                        IIf(dr("filename") Is System.DBNull.Value, "", dr("filename")), _
                                        IIf(dr("available_from") Is System.DBNull.Value, DateTime.MinValue, dr("available_from")), _
                                        IIf(dr("expire_at") Is System.DBNull.Value, DateTime.MinValue, dr("expire_at")), _
                                        dr("available"), _
                                        IIf(dr("language_id") Is System.DBNull.Value, 0, dr("language_id")), _
                                        IIf(dr("subtitle_id") Is System.DBNull.Value, 0, dr("subtitle_id")), _
                                        IIf(dr("studio_id") Is System.DBNull.Value, 0, dr("studio_id")), _
                                        IIf(dr("status") Is System.DBNull.Value, "", dr("status")), _
                                        IIf(dr("quality") Is System.DBNull.Value, "", dr("quality")), _
                                        dr("source"), _
                                        IIf(dr("vod_support_id") Is System.DBNull.Value, 0, dr("vod_support_id")), _
                                        IIf(dr("credits") Is System.DBNull.Value, 0, dr("credits")), _
                                        IIf(dr("available_backcatalogue_from") Is System.DBNull.Value, DateTime.MinValue, dr("available_backcatalogue_from")), _
                                        IIf(dr("expire_backcatalogue_at") Is System.DBNull.Value, DateTime.MinValue, dr("expire_backcatalogue_at")), _
                                        IIf(dr("is_ppv") Is System.DBNull.Value, "false", dr("is_ppv")), _
                                        IIf(dr("ppv_price") Is System.DBNull.Value, "", dr("ppv_price")), _
                                        dr("country"), True)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

        Next
        GridVod.DataSource.AcceptChanges()

    End Sub

    Private Sub XTabControlVod_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTabControlVod.Resize
        Dim center As Integer = GridVodWatch.Width + (XTabControlVod.Width - GridVodWatch.Width) / 2
        'WebSiteDvdPost.Left = GridVodWatch.Left + GridVodWatch.Width - 203
        'WebSiteDvdPost.Width = (XTabControlVod.Width - GridVodWatch.Width) + 203
    End Sub

    Private Sub chkIsPPV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsPPV.CheckedChanged
        txtPPVPrice.Enabled = chkIsPPV.Checked

    End Sub

    Private Sub chkLux_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLU.CheckedChanged
        LuxEnable(True)
    End Sub

    Private Sub LuxEnable(ByVal enable As Boolean)
        chkLU.Enabled = enable
        cmbDateStartLU.Enabled = chkLU.Checked And enable
        cmbDateExpiredLU.Enabled = chkLU.Checked And enable
        cmbDateLaterStartLU.Enabled = chkLU.Checked And enable
        cmbDateLaterExpiredLU.Enabled = chkLU.Checked And enable
        chkAvailableLU.Enabled = chkLU.Checked And enable
        'cmbStatusLU.Enabled = chkLU.Checked And enable
        spedCreditLU.Enabled = chkLU.Checked And enable
        chkIsPPVLU.Enabled = chkLU.Checked And enable
        txtPPVPriceLU.Enabled = chkLU.Checked And enable And chkIsPPVLU.Checked

    End Sub

    Private Sub chkNL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNL.CheckedChanged
        NLEnable(True)
    End Sub

    Private Sub NLEnable(ByVal enable As Boolean)
        chkNL.Enabled = enable
        cmbDateStartNL.Enabled = chkNL.Checked And enable
        cmbDateExpiredNL.Enabled = chkNL.Checked And enable
        cmbDateLaterStartNL.Enabled = chkNL.Checked And enable
        cmbDateLaterExpiredNL.Enabled = chkNL.Checked And enable
        chkAvailableNL.Enabled = chkNL.Checked And enable
        'cmbStatusNL.Enabled = chkNL.Checked And enable
        spedCreditNL.Enabled = chkNL.Checked And enable
        chkIsPPVNL.Enabled = chkNL.Checked And enable
        txtPPVPriceNL.Enabled = chkNL.Checked And enable And chkIsPPVNL.Checked
    End Sub

    Private Sub chkIsPPVLU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsPPVLU.CheckedChanged
        txtPPVPriceLU.Enabled = chkLU.Checked And chkIsPPVLU.Checked
    End Sub

    Private Sub chkIsPPVNL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsPPVNL.CheckedChanged
        txtPPVPriceNL.Enabled = chkLU.Checked And chkIsPPVNL.Checked
    End Sub

    Private Sub btnSaveTrailers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTrailers.Click
        Dim dt As DataTable
        dt = grdTrailers.DataSource.GetChanges()


        If dt Is Nothing Then
            Return
        ElseIf MsgBoxResult.Cancel = MsgBox(dt.Rows.Count & " trailers; status are updated and will be saved, please confim ! ", MsgBoxStyle.OkCancel) Then
            Return
        End If
        For Each dr As DataRow In dt.Rows
            Dim sql As String
            sql = DvdPostData.ClsVod.GetUpdateTrailer(dr("id"), _
                                        IIf(dr("imdb_id") Is System.DBNull.Value, 0, dr("imdb_id")), _
                                        IIf(dr("filename") Is System.DBNull.Value, "", dr("filename")), _
                                        IIf(dr("available_from") Is System.DBNull.Value, DateTime.MinValue, dr("available_from")), _
                                        IIf(dr("expire_at") Is System.DBNull.Value, DateTime.MinValue, dr("expire_at")), _
                                        dr("available"), _
                                        IIf(dr("language_id") Is System.DBNull.Value, 0, dr("language_id")), _
                                        IIf(dr("subtitle_id") Is System.DBNull.Value, 0, dr("subtitle_id")), _
                                        IIf(dr("status") Is System.DBNull.Value, 0, dr("status")))
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

        Next
        grdTrailers.DataSource.AcceptChanges()

    End Sub
End Class