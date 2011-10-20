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
        cmbLanguageSound.EditValue = 0
        cmbLanguageSubtitle.EditValue = 0
        cmbStudioEdit.EditValue = blank
        cmbStatus.EditValue = blank
        chkAvailable.Checked = False


    End Sub
    Private Sub loadData(ByVal row As DataRow)

        txtId.EditValue = row("id")
        TxtFilename.EditValue = row("filename")
        txtImdbView.EditValue = row("imdb_id")

        cmbDateExpired.EditValue = row("expire_at")
        cmbDateStart.EditValue = row("available_from")
        cmbLanguageSound.EditValue = row("language_id")
        If row("subtitle_id") Is DBNull.Value Then
            cmbLanguageSubtitle.EditValue = 0
        Else

            cmbLanguageSubtitle.EditValue = row("subtitle_id")
        End If

        chkAvailable.Checked = row("available")
        cmbStudioEdit.EditValue = CInt(row("studio_id"))
        cmbStatus.EditValue = row("status")
        If row("quality") Is DBNull.Value Then
            cmbQuality.EditValue = ""
        Else
            cmbQuality.EditValue = row("quality")
        End If

        cmbSource.EditValue = row("source")
        cmbSupportVod.EditValue = row("vod_support_id")

        spedCredit.EditValue = row("credits")

    End Sub

    Private Sub EnableField(ByVal enable As Boolean)

        TxtFilename.Enabled = enable
        txtImdbView.Enabled = enable
        cmbDateExpired.Enabled = enable
        cmbDateStart.Enabled = enable
        cmbLanguageSound.Enabled = enable
        cmbLanguageSubtitle.Enabled = enable
        cmbStatus.Enabled = enable
        chkAvailable.Enabled = enable
        cmbStudioEdit.Enabled = enable
        cmbQuality.Enabled = enable
        cmbSource.Enabled = enable
        cmbSupportVod.Enabled = enable
        spedCredit.Enabled = enable

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
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim sql As String
        Dim dt As DataTable = Nothing
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
            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.DETAIL
        End If


    End Sub
    Private Function Save() As Boolean
        Dim sql As String
        Try


            If txtId.EditValue Is Nothing Then
                sql = DvdPostData.ClsVod.GetInsertVod(txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStart.EditValue, cmbDateExpired.EditValue, chkAvailable.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCredit.EditValue)
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
            Else
                sql = DvdPostData.ClsVod.GetUpdateVod(txtId.EditValue, txtImdbView.EditValue, TxtFilename.EditValue, cmbDateStart.EditValue, cmbDateExpired.EditValue, chkAvailable.Checked, cmbLanguageSound.EditValue, cmbLanguageSubtitle.EditValue, cmbStudioEdit.EditValue, cmbStatus.EditValue, cmbQuality.EditValue, cmbSource.EditValue, cmbSupportVod.EditValue, spedCredit.EditValue)
                DvdPostData.clsConnection.ExecuteNonQuery(sql)

            End If
            Return True
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Vod, ex)
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
        'studio




    End Sub
    Private Sub loadDatatUploaded()
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsVod.SearchViewVodProductUploaded()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        GridVodWatch.DataSource = dt
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
                sql = DvdPostData.ClsVod.GetInsertVod(elts(DVDPostBuziness.clsFileZilla.FormatFile.IMDB_ID), extension + filename, Date.MinValue, Date.MinValue, True, language_audio_id, language_subtitle_id, elts(DVDPostBuziness.clsFileZilla.FormatFile.STUDIO_ID), "uploaded", strQuality, "SOFTLAYER", 1, 1)
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
        End If
    End Sub

    Private Sub GridVodWatch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVodWatch.DoubleClick
        Dim row As DataRow
        If gridViewVodWatch.RowCount > 0 Then
            row = gridViewVodWatch.GetDataRow(gridViewVodWatch.FocusedRowHandle())
            loadData(row)
        End If
        ChangeStep(StepForm.CHOOSEVOD)
    End Sub
    Private Sub loadInfoVodWatch()

        Dim row As DataRow
        If gridViewVodWatch.RowCount > 0 Then
            row = gridViewVodWatch.GetDataRow(gridViewVodWatch.FocusedRowHandle())
            loadData(row)
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
    Private Sub FillEmptyValue(ByRef result() As String)

        result = [Enum].GetNames(GetType(DvdPostData.ClsVod.ListField))
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
            FillEmptyValue(result)
            CheckParseFileName(name, result)
            If result IsNot Nothing Then


                result(DvdPostData.ClsVod.ListField.LANGUAGE) = GetId(result(DvdPostData.ClsVod.ListField.LANGUAGE), _dtLanguageSound)
                result(DvdPostData.ClsVod.ListField.SUBTITLE) = GetId(result(DvdPostData.ClsVod.ListField.SUBTITLE), _dtLanguageSubtitle)
                result(DvdPostData.ClsVod.ListField.VOD_SUPPORT) = GetId(result(DvdPostData.ClsVod.ListField.VOD_SUPPORT), _dtSupport)

                If result(DvdPostData.ClsVod.ListField.LANGUAGE) Is Nothing _
                   Or result(DvdPostData.ClsVod.ListField.SUBTITLE) Is Nothing _
                   Or result(DvdPostData.ClsVod.ListField.VOD_SUPPORT) Is Nothing Then
                    lstError.Items.Add(name)
                    Continue For

                End If

                dr = GetInfoVod(result)

                If dr Is Nothing Then
                    result(DvdPostData.ClsVod.ListField.EXPIRE_AT) = Date.MinValue
                    result(DvdPostData.ClsVod.ListField.STUDIO) = "null"
                Else
                    result(DvdPostData.ClsVod.ListField.EXPIRE_AT) = dr("expire_at")
                    result(DvdPostData.ClsVod.ListField.STUDIO) = dr("studio_id")
                End If

                result(DvdPostData.ClsVod.ListField.AVAILABLE_FROM) = Now()
                result(DvdPostData.ClsVod.ListField.STATUS) = "uploaded"
                result(DvdPostData.ClsVod.ListField.AVAILABLE) = "true"
                result(DvdPostData.ClsVod.ListField.SOURCE) = "ALPHANETWORKS"
                result(DvdPostData.ClsVod.ListField.CREDIT) = 1


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
                            Nothing, _
                            result(DvdPostData.ClsVod.ListField.SOURCE), _
                            result(DvdPostData.ClsVod.ListField.VOD_SUPPORT), _
                            Integer.Parse(result(DvdPostData.ClsVod.ListField.CREDIT)))

                    DvdPostData.clsConnection.ExecuteNonQuery(sql)
                    LstResult.Items.Add(name)

                End If

            Else
                lstError.Items.Add(name)
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
                                        dr("imdb_id"), _
                                        dr("filename"), _
                                        dr("available_from"), _
                                        dr("expire_at"), _
                                        dr("available"), _
                                        dr("language_id"), _
                                        IIf(dr("subtitle_id") Is System.DBNull.Value, 0, dr("subtitle_id")), _
                                        dr("studio_id"), _
                                        IIf(dr("status") Is System.DBNull.Value, "", dr("status")), _
                                        IIf(dr("quality") Is System.DBNull.Value, "", dr("quality")), _
                                        dr("source"), _
                                        dr("vod_support_id"), _
                                        dr("credits"))
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

        Next
        GridVod.DataSource.AcceptChanges()

    End Sub
End Class