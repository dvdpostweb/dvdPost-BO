Imports System.Net.Mail
Imports System.Collections.Generic
Public Class clsProduct_VODSerie
    Inherits BizzLib.clsOneTableData
    Private _productsId As Integer = -1
    Private _serieProductsId As List(Of Integer) = New List(Of Integer)
    Private _dvdId As Integer
    Private _productsType As String
    Private _ObjBarCode As clsProduct_BarCode
    Private _INOUT As DvdPostData.clsProductDvd.INOUT
    Private _product_dvd_status As DvdPostData.clsProductDvd.DVDStatus

    Private _box_id As Integer
    Private _posBox_id As Integer

    Public alert_cre_date As DateTime = Nothing
    Public alert_comment As String = ""
    Public OrdersDataTable As DataTable = Nothing
    Public Products_dvd_row As DataRow
    Public Product_row As DataRow


    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo, ByVal vDataset1 As dsProducts)
        MyBase.New(vSessionInfo)
        initObject(vDataset1)

    End Sub


    'Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo, ByVal vDataset1 As dsProducts)
    '    MyBase.New(vSessionInfo)

    '    _ObjBarCode = New clsProduct_BarCode(vBarCodeWithCheckDigit)
    '    initObject(vDataset1)

    'End Sub
    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo, ByVal vDataset1 As dsProducts, ByVal productsId As Integer)
        MyBase.New(vSessionInfo)
        _productsId = productsId
        '_ObjBarCode = New clsProduct_BarCode(productsId, dvdId)
        initObject(vDataset1)

    End Sub
    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As DataRowView) As Integer
        Return -1
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check ID
        If Row1("products_id") & "" = "" Then
        End If
        Return _MsgID
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer

    End Function
    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM products_dvd WHERE " & IDFieldName & " = " & ID)
    End Function

    Public Property products_dvd_status() As DvdPostData.clsProductDvd.DVDStatus
        Get
            Return _product_dvd_status
        End Get
        Set(ByVal value As DvdPostData.clsProductDvd.DVDStatus)
            _product_dvd_status = value
        End Set
    End Property

    Public ReadOnly Property INOUT() As DvdPostData.clsProductDvd.INOUT
        Get
            Return _INOUT
        End Get
    End Property

    Public ReadOnly Property isAdult() As Boolean
        Get
            If _productsType = "DVD_ADULT" Then
                Return True
            ElseIf _productsType = "DVD_NORM" Then
                Return False
            Else
                Return False
            End If
        End Get
    End Property
    Public ReadOnly Property productsType() As String
        Get
            Return _productsType
        End Get
    End Property
    Public Property ProductsID() As Integer
        Get
            Return _productsId
        End Get
        Set(ByVal value As Integer)
            _productsId = value
        End Set
    End Property

    Public Property SerieProductsID() As List(Of Integer)
        Get
            Return _serieProductsId
        End Get
        Set(ByVal value As List(Of Integer))
            _serieProductsId = value
        End Set
    End Property

    Private ReadOnly Property SerieProductsInList() As String
        Get
            Dim stringOUT As String = String.Empty

            For index As Integer = 0 To _serieProductsId.Count - 1
                If index = _serieProductsId.Count - 1 Then
                    stringOUT = stringOUT & _serieProductsId(index)
                Else
                    stringOUT = stringOUT & _serieProductsId(index) & ","
                End If
            Next
            Return stringOUT
        End Get

    End Property

    Public ReadOnly Property PosBoxID() As Integer
        Get
            Return _posBox_id
        End Get
    End Property
    Public ReadOnly Property BoxID() As Integer
        Get
            Return _box_id
        End Get
    End Property
    Public ReadOnly Property DvdId() As Integer
        Get
            Return _dvdId
        End Get
    End Property
    Public ReadOnly Property BarCode() As clsProduct_BarCode
        Get
            Return _ObjBarCode
        End Get
    End Property
    Public Sub initObject(ByVal vDataSet1 As DataSet)

        'If _ObjBarCode.IsBarCodeValid Then
        '    _productsId = _ObjBarCode.ProductID  'CInt(Mid(_ObjBarCode.BarcodeWithCheckDigit, 4, 6))
        '    _dvdId = _ObjBarCode.DVDID  'CInt(Mid(_BarcodeWithCheckDigit, 10, 3))
        'If _productsId <> -1 Then
        Dim dsTmp As DVDPostLib.dsProducts = New DVDPostLib.dsProducts()
        If _productsId <> -1 Then
            MyBase.Initialize(dsTmp, "", "products", "products_id", "SELECT * FROM products where products_id = " & _productsId, "", "")
            If dsTmp.Tables("products").Rows.Count > 0 Then
                'vDataSet1.Tables("products").Rows.Add(dsTmp.Tables("products").Rows(0))
                Dim _row_to As DataRow = vDataSet1.Tables("products").NewRow()
                _row_to.ItemArray = dsTmp.Tables("products").Rows(0).ItemArray
                vDataSet1.Tables("products").Rows.Add(_row_to)
            End If
        Else
            MyBase.Initialize(vDataSet1, "", "products", "products_id", "SELECT * FROM products where products_id = " & _productsId, "", "")
        End If


        DataSet1 = vDataSet1
        If MyBase.TableOfData.Rows.Count = 1 Then
            Product_row = MyBase.TableOfData.Rows(0)
            _productsType = MyBase.TableOfData.Rows(0)("products_type")
            '    'If _dvdId <> -1 Then
            '    '    Load_One_Products_DVD_Info()
            '    'End If
        Else
            _productsId = -1
            _dvdId = -1
            _productsType = ""
        End If

        'Else
        '_productsId = -1
        '_dvdId = -1
        '_productsType = ""
        'End If
    End Sub

    Public Sub initObject(ByVal vDataSet1 As DataSet, ByVal productsID As Integer)

        'If _ObjBarCode.IsBarCodeValid Then
        '    _productsId = _ObjBarCode.ProductID  'CInt(Mid(_ObjBarCode.BarcodeWithCheckDigit, 4, 6))
        '    _dvdId = _ObjBarCode.DVDID  'CInt(Mid(_BarcodeWithCheckDigit, 10, 3))
        'If _productsId <> -1 Then
        If Not _serieProductsId.Contains(productsID) Then Return
        Dim dsTmp As DVDPostLib.dsProducts = New DVDPostLib.dsProducts()
        If _productsId <> -1 Then
            MyBase.Initialize(dsTmp, "", "products", "products_id", "SELECT * FROM products where products_id = " & productsID, "", "")
            If dsTmp.Tables("products").Rows.Count > 0 Then
                'vDataSet1.Tables("products").Rows.Add(dsTmp.Tables("products").Rows(0))
                Dim _row_to As DataRow = vDataSet1.Tables("products").NewRow()
                _row_to.ItemArray = dsTmp.Tables("products").Rows(0).ItemArray
                vDataSet1.Tables("products").Rows.Add(_row_to)
            End If
        Else
            MyBase.Initialize(vDataSet1, "", "products", "products_id", "SELECT * FROM products where products_id = " & productsID, "", "")
        End If


        DataSet1 = vDataSet1
        If MyBase.TableOfData.Rows.Count > 1 Then
            Product_row = MyBase.TableOfData.Rows(0)
            _productsType = MyBase.TableOfData.Rows(0)("products_type")
            '    'If _dvdId <> -1 Then
            '    '    Load_One_Products_DVD_Info()
            '    'End If
        Else
            _productsId = -1
            _dvdId = -1
            _productsType = ""
        End If

        'Else
        '_productsId = -1
        '_dvdId = -1
        '_productsType = ""
        'End If
    End Sub

    Public Function GetPosBox(Optional ByVal posbox_id As Integer = 0, Optional ByVal change_status As DvdPostData.clsProductDvd.DVDStatus = -1) As Integer

        Dim new_status As DvdPostData.clsProductDvd.DVDStatus
        new_status = GetNewStatus(change_status)

        Select Case new_status
            Case DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU, _
                DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL, _
                DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN, _
                DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED, _
                DvdPostData.clsProductDvd.DVDStatus.DVD_SOLD, _
                DvdPostData.clsProductDvd.DVDStatus.PREP_FOR_SOLD, _
                DvdPostData.clsProductDvd.DVDStatus.INVENTAIRE, _
                DvdPostData.clsProductDvd.DVDStatus.VOD
                Return 1
            Case Else
                If posbox_id = 0 Then
                    Return PosBoxID
                Else
                    Return posbox_id
                End If

        End Select

    End Function
    Private Function GetNewStatus(ByVal change_status As DvdPostData.clsProductDvd.DVDStatus) As DvdPostData.clsProductDvd.DVDStatus

        If change_status = -1 Then
            Return products_dvd_status
        Else
            Return change_status
        End If


    End Function
    'Public Function GetBox(Optional ByVal box_id As Integer = 0, Optional ByVal change_status As DvdPostData.clsProductDvd.DVDStatus = -1) As Integer
    '    Dim new_status As DvdPostData.clsProductDvd.DVDStatus

    '    new_status = GetNewStatus(change_status)
    '    Select Case new_status
    '        Case DvdPostData.clsProductDvd.DVDStatus.BIZARREMENT_PERDU
    '            Return DvdPostData.clsProductDvd.BOXTYPE.BIZARREMENT_PERDU

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BADLABEL
    '            Return DvdPostData.clsProductDvd.BOXTYPE.BADLABEL

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_BROKEN, _
    '            DvdPostData.clsProductDvd.DVDStatus.IRREPARABLE
    '            Return DvdPostData.clsProductDvd.BOXTYPE.BROKEN

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_DAMAGED, _
    '             DvdPostData.clsProductDvd.DVDStatus.ENTRETIEN
    '            Return DvdPostData.clsProductDvd.BOXTYPE.DAMAGED

    '        Case DvdPostData.clsProductDvd.DVDStatus.DVD_SOLD
    '            Return DvdPostData.clsProductDvd.BOXTYPE.SOLD

    '        Case DvdPostData.clsProductDvd.DVDStatus.PREP_FOR_SOLD
    '            Return DvdPostData.clsProductDvd.BOXTYPE.PREPFORSOLD

    '        Case DvdPostData.clsProductDvd.DVDStatus.INVENTAIRE
    '            Return DvdPostData.clsProductDvd.BOXTYPE.INVENTAIRE

    '        Case DvdPostData.clsProductDvd.DVDStatus.VOD
    '            Return DvdPostData.clsProductDvd.BOXTYPE.VOD

    '        Case DvdPostData.clsProductDvd.DVDStatus.CUSTOMERS_SERVICE
    '            Return DvdPostData.clsProductDvd.BOXTYPE.CUSTSERV

    '        Case DvdPostData.clsProductDvd.DVDStatus.NON_LOCATIF
    '            Return DvdPostData.clsProductDvd.BOXTYPE.NOLOCATIVE

    '        Case Else
    '            If box_id = 0 Then
    '                Return BoxID
    '            Else
    '                Return box_id
    '            End If

    '    End Select

    'End Function
    Public Sub SaveAll()
        Me.Save()
        SaveActors()
        SaveLanguages()
        SaveUndertitles()
        SaveSoundtracks()
        SaveCategories()
        SaveThemes()
        SaveTrailers()
        SaveDescriptionFR()
        SaveDescriptionNL()
        SaveDescriptionEN()
    End Sub
    Public Sub SaveAll(ByVal imdb_id As Integer)
        Me.Save()
        SaveActors()
        SaveLanguages()
        SaveUndertitles()
        SaveSoundtracks()
        SaveCategories(imdb_id)
        SaveThemes(imdb_id)
        SaveTrailers()
        SaveDescriptionFR()
        SaveDescriptionNL()
        SaveDescriptionEN()
    End Sub
    Public Sub LoadProductsDetail()
        DataSet1.Tables("products").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products"), "select * from products where products_id in ( " & SerieProductsInList & " ) ")
        DataSet1.Tables("products").Columns("products_id").DefaultValue = ProductsID

    End Sub
    Public Sub LoadVod()
        DataSet1.Tables("streaming_products").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("streaming_products"), "select group_concat(distinct pl.short_alpha) audio, group_concat(distinct pu.short_alpha) subtitle" & _
        " from products p join streaming_products sp on p.imdb_id = sp.imdb_id " & _
        " left join products_languages pl on sp.language_id = pl.languages_id and pl.languagenav_id = 1 " & _
        " left join products_undertitles pu on sp.subtitle_id = pu.undertitles_id and pu.language_id = 1 " & _
        " where p.products_id = " & ProductsID)
        'DataSet1.Tables("streaming_products").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub LoadActors()
        DataSet1.Tables("products_to_actors").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_actors"), "select * from products_to_actors where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_actors"), "select * from products_to_actors where products_id = " & ProductsID)
        DataSet1.Tables("products_to_actors").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveActors()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_actors").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_actors"), "select * from products_to_actors ")
        If refresh Then
            LoadActors()
        End If
    End Sub

    Public Sub LoadLanguages()
        DataSet1.Tables("products_to_languages").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_languages"), "select * from products_to_languages where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_languages"), "select * from products_to_languages where products_id = " & ProductsID)
        DataSet1.Tables("products_to_languages").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveLanguages()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_languages").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_languages"), "select * from products_to_languages ")
        If refresh Then
            LoadLanguages()
        End If
    End Sub

    Public Sub LoadUndertitles()
        DataSet1.Tables("products_to_undertitles").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_undertitles"), "select * from products_to_undertitles where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_undertitles"), "select * from products_to_undertitles where products_id = " & ProductsID)
        DataSet1.Tables("products_to_undertitles").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveUndertitles()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_undertitles").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_undertitles"), "select * from products_to_undertitles ")
        If refresh Then
            LoadUndertitles()
        End If
    End Sub

    Public Sub LoadSoundtracks()
        DataSet1.Tables("products_to_soundtracks").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_soundtracks"), "select * from products_to_soundtracks where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_soundtracks"), "select * from products_to_soundtracks where products_id = " & ProductsID)
        DataSet1.Tables("products_to_soundtracks").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveSoundtracks()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_soundtracks").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_soundtracks"), "select * from products_to_soundtracks ")
        If refresh Then
            LoadSoundtracks()
        End If
    End Sub

    Public Sub LoadTrailers()
        DataSet1.Tables("products_trailers").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_trailers"), "select * from products_trailers where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_trailers"), "select * from products_trailers where products_id  = " & ProductsID)
        DataSet1.Tables("products_trailers").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub LoadStreamingTrailers()
        DataSet1.Tables("streaming_trailers").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("streaming_trailers"), "select sp.id, sp.filename, pl.short_alpha audio, pu.short_alpha subtitle, sp.status" & _
        " from products p join streaming_trailers sp on p.imdb_id = sp.imdb_id " & _
        " left join products_languages pl on sp.language_id = pl.languages_id and pl.languagenav_id = 1 " & _
        " left join products_undertitles pu on sp.subtitle_id = pu.undertitles_id and pu.language_id = 1 " & _
        " where p.products_id in ( " & SerieProductsInList & " ) ")
    End Sub
    Public Sub SaveTrailers()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_trailers").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_trailers"), "select trailers_id, products_id, trailer, language_id, broadcast from products_trailers ")
        If refresh Then
            LoadTrailers()
        End If

    End Sub

    Public Sub LoadCategories()
        DataSet1.Tables("products_to_categories").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_categories"), "select * from products_to_categories where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_categories"), "select * from products_to_categories where products_id  = " & ProductsID)
        DataSet1.Tables("products_to_categories").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveCategories()
        '  dvdpostdata.clsconnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select * from products_to_categories ")
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_categories").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select products_id, categories_id from products_to_categories where products_id in ( " & SerieProductsInList & " ) ")
        'DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select products_id, categories_id from products_to_categories where products_id  = " & ProductsID)
        If refresh Then
            LoadCategories()
        End If
    End Sub

    Public Sub SaveCategories(ByVal imdb_id As Integer)
        '  dvdpostdata.clsconnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select * from products_to_categories ")
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_categories").GetChanges() Is Nothing Then
            refresh = True
        End If


        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_categories"), "select products_id, categories_id from products_to_categories where products_id = " & ProductsID)
        DvdPostData.clsConnection.ExecuteNonQuery("delete from products_to_categories where products_id <> " & ProductsID & " and products_id in (select products_id from products where imdb_id = " & imdb_id & ")")
        DvdPostData.clsConnection.ExecuteNonQuery("insert into products_to_categories select p.products_id, c.categories_id, sysdate() from (Select categories_id from products_to_categories where products_id = " & ProductsID & ") c," & _
                                                    "( select products_id from products where imdb_id = " & imdb_id & " and products_id <> " & ProductsID & " ) p ")

        If refresh Then
            LoadCategories()
        End If
    End Sub

    Public Sub LoadThemes()
        DataSet1.Tables("products_to_themes").Clear()
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id  = " & ProductsID)
        DataSet1.Tables("products_to_themes").Columns("products_id").DefaultValue = ProductsID
    End Sub
    Public Sub SaveThemes()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_themes").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id in ( " & SerieProductsInList & " ) ")
        If refresh Then
            LoadThemes()
        End If
    End Sub

    Public Sub SaveThemes(ByVal imdb_id As Integer)
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_to_themes").GetChanges() Is Nothing Then
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_to_themes"), "select * from products_to_themes where products_id in ( " & SerieProductsInList & " ) ")
        DvdPostData.clsConnection.ExecuteNonQuery("delete from products_to_themes where products_id <> " & ProductsID & " and products_id in (select products_id from products where imdb_id = " & imdb_id & ")")
        DvdPostData.clsConnection.ExecuteNonQuery("insert into products_to_themes select p.products_id, c.themes_id, sysdate() from (Select themes_id from products_to_themes where products_id in ( " & SerieProductsInList & " ) ) c," & _
                                                    "( select products_id from products where imdb_id = " & imdb_id & " and products_id <> " & ProductsID & " ) p ")
        If refresh Then
            LoadThemes()
        End If
    End Sub

    Public Sub LoadDescriptionFR()
        DataSet1.Tables("products_description_fr").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_fr"), "select * from products_description where language_id = 1 and products_id in( " & SerieProductsInList & " ) ")
        DataSet1.Tables("products_description_fr").Columns("products_id").DefaultValue = ProductsID
        DataSet1.Tables("products_description_fr").Columns("language_id").DefaultValue = 1
        If DataSet1.Tables("products_description_fr").Rows.Count < 1 Then
            DvdPostData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 1)")
            DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_fr"), "select * from products_description where language_id = 1 and products_id in ( " & SerieProductsInList & " ) ")
        End If
    End Sub
    Public Sub SaveDescriptionFR()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_description_fr").GetChanges() Is Nothing Then
            For i As Integer = 0 To DataSet1.Tables("products_description_fr").Rows.Count - 1
                DataSet1.Tables("products_description_fr").Rows(i)("products_description") = Replace(DataSet1.Tables("products_description_fr").Rows(i)("products_description").ToString(), "’", "'")
            Next
            refresh = True

        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_description_fr"), "select * from products_description ")
        If refresh Then
            LoadDescriptionFR()
        End If
    End Sub

    Public Sub LoadDescriptionNL()
        DataSet1.Tables("products_description_nl").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_nl"), "select * from products_description where language_id = 2 and products_id in ( " & SerieProductsInList & " ) ")
        DataSet1.Tables("products_description_nl").Columns("products_id").DefaultValue = ProductsID
        DataSet1.Tables("products_description_nl").Columns("language_id").DefaultValue = 2
        If DataSet1.Tables("products_description_nl").Rows.Count < 1 Then
            DvdPostData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 2)")
            DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_nl"), "select * from products_description where language_id = 2 and products_id in ( " & SerieProductsInList & " ) ")
        End If

    End Sub
    Public Sub SaveDescriptionNL()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_description_nl").GetChanges() Is Nothing Then
            For i As Integer = 0 To DataSet1.Tables("products_description_nl").Rows.Count - 1
                DataSet1.Tables("products_description_nl").Rows(i)("products_description") = Replace(DataSet1.Tables("products_description_nl").Rows(i)("products_description").ToString(), "’", "'")
            Next
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_description_nl"), "select * from products_description ")
        If refresh Then
            LoadDescriptionNL()
        End If
    End Sub

    Public Sub LoadDescriptionEN()
        DataSet1.Tables("products_description_en").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_en"), "select * from products_description where language_id = 3 and products_id in ( " & SerieProductsInList & " ) ")
        'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_en"), "select * from products_description where language_id = 3 and products_id  = " & ProductsID)
        DataSet1.Tables("products_description_en").Columns("products_id").DefaultValue = ProductsID
        DataSet1.Tables("products_description_en").Columns("language_id").DefaultValue = 3
        If DataSet1.Tables("products_description_en").Rows.Count < 1 Then
            DvdPostData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 3)")
            DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_en"), "select * from products_description where language_id = 3 and products_id in ( " & SerieProductsInList & " ) ")
            'DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_description_en"), "select * from products_description where language_id = 3 and products_id  = " & ProductsID)
        End If
    End Sub
    Public Sub SaveDescriptionEN()
        Dim refresh As Boolean = False
        If Not DataSet1.Tables("products_description_en").GetChanges() Is Nothing Then
            For i As Integer = 0 To DataSet1.Tables("products_description_en").Rows.Count - 1
                DataSet1.Tables("products_description_en").Rows(i)("products_description") = Replace(DataSet1.Tables("products_description_en").Rows(i)("products_description").ToString(), "’", "'")
            Next
            refresh = True
        End If
        DvdPostData.clsConnection.UpdateDataTableInDB(DataSet1.Tables("products_description_en"), "select * from products_description ")
        If refresh Then
            LoadDescriptionEN()
        End If
    End Sub
    'Public Function AddNewDVD(ByVal vNbrOfDVDToAdd As Integer) As Integer
    '    Dim intmaxproducts_dvdid As Integer = 0
    '    Dim _SQLTxt As String
    '    _SQLTxt = "SELECT if(max(products_dvdid)  is null, 0, max(products_dvdid))  as cnt FROM products_dvd where products_id = '" & ProductsID & "' "
    '    intmaxproducts_dvdid = BKGlobal.ExecuteFindFieldValueINT("cnt", _SQLTxt)

    '    _SQLTxt = "update products set products_dvd_quantity = products_dvd_quantity + '" & vNbrOfDVDToAdd & _
    '              "' , products_availability = 1 where products_id = '" & ProductsID & "'  "
    '    DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
    '    Dim i As Integer
    '    For i = (intmaxproducts_dvdid + 1) To (vNbrOfDVDToAdd + intmaxproducts_dvdid)
    '        _SQLTxt = "insert into products_dvd (products_id , products_dvdid ,`inout`,  products_dvd_status, last_admindate, dvd_buy_date, box_id)values( '" & _
    '                ProductsID & "' , '" & i & "' , 1 , " & DvdPostData.clsProductDvd.DVDStatus.PURCHASE & " , now(), now(), " & DvdPostData.clsProductDvd.BOXTYPE.PURCHASE & " ) "
    '        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)

    '        ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.PURCHASE, "add new dvd", DvdPostData.ClsProducts_dvd_state.state.PURCHASE, DvdPostData.clsProductDvd.INOUT.IN)

    '    Next
    '    Return i
    'End Function
    Public Function AddNewProduct(ByVal season_id As Integer, ByVal episode_id As Integer, ByVal serie_id As Integer) As Integer 'Return the new Product_id
        Dim _row As DataRow = TableOfData.NewRow
        Dim _Date As String
        _Date = DVDPostTools.ClsDate.formatDateDB(Date.Now)
        _row("products_id") = 0
        _row("products_type") = "DVD_NORM"
        _row("products_media") = "DVD"
        _row("products_status") = -1
        _row("products_availability") = 0
        _row("products_date_added") = _Date
        _row("products_last_modified") = _Date
        _row("products_quantity") = 0
        _row("imdb_id") = 0
        _row("products_price") = 0
        _row("products_title") = ""
        _row("products_tax_class_id") = 0
        _row("products_ordered") = 0
        _row("products_public") = 1 'tout public
        _row("products_picture_format") = 4 ' 16/9 compatible 4/3
        _row("products_countries_id") = 223
        _row("products_barcode") = 0
        _row("products_dvd_quantity") = 0
        _row("products_regional_code") = 2
        _row("products_language_fr") = 0
        _row("products_undertitle_nl") = 0
        _row("in_the_bags") = 0
        _row("in_the_bags_next") = 0
        _row("in_cinema_now") = 0
        _row("products_dvdpostchoice") = 0
        _row("products_french") = 0
        _row("products_next") = 0
        _row("products_tiscali_hp_fr") = 0
        _row("products_tiscali_hp_nl") = 0
        _row("products_series_id") = 0
        _row("products_series_number") = 0
        _row("products_series_aboprocess_id") = 0
        _row("products_series_aboprocess_number") = 0
        _row("feesharing") = 0
        _row("feesharing_end") = DBNull.Value
        _row("feesharing_upfront_fee") = 0
        _row("feesharing_upfront_fee_recoverable") = 0
        _row("feesharing_turn_price") = 0
        _row("feesharing_turn_price_after3month") = 0
        _row("feesharing_upfront_fee") = 0
        _row("feesharing_buy_option_price") = 0
        _row("feesharing_expected_nbr_turns") = 0
        _row("products_desire") = 0
        _row("products_desire_weighted") = 0
        _row("quantity_to_sale") = 0
        _row("products_sale_price") = 0
        _row("products_sale_date") = DBNull.Value
        '_row("distributors_id") = 0
        _row("quantity_new_to_sale") = 0
        _row("products_new_sale_price") = 0
        _row("only_for_sale") = 0
        _row("products_other_language") = 0
        _row("products_product_type") = "Movie"
        _row("criteo_status") = 0
        _row("serie_id") = serie_id
        _row("season_id") = season_id
        _row("episode_id") = episode_id
        TableOfData.Rows.Add(_row)
        SaveAll()
        'Retreiving the ID just Created
        _productsId = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products where products_date_added = '" & _Date & "' ORDER by products_id desc limit 1 ")
        _serieProductsId.Add(_productsId)
        'DvdPostData.clsConnection.ExecuteNonQuery("insert into products_to_soundtracks  (products_id, products_soundtracks_id) values (" & _productsId & ", 4)") 'Default SoundTracks = Dolby Digital
        DvdPostData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 1)")
        DvdPostData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 2)")
        DvdPostData.clsConnection.ExecuteNonQuery("insert into products_description (products_id, language_id) values (" & _productsId & ", 3)")
        Product_row = _row
        _dvdId = -1
        _productsType = "DVD_NORM"
        Return _productsId
    End Function
    Public Function IsInCategory(ByVal vProducts_ID As Integer, ByVal vCategories_ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("select count(*) cnt from products_to_categories where products_id = " & vProducts_ID & " AND categories_id = " & vCategories_ID)
    End Function
    Public Function IsInTheme(ByVal vProducts_ID As Integer, ByVal vTheme_ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("select count(*) cnt from products_to_themes where products_id = " & vProducts_ID & " AND themes_id = " & vTheme_ID)
    End Function
    Public Function CopyProduct(ByVal season_id As Integer, ByVal episode_id As Integer, ByVal serie_id As Integer) As Integer
        'Return the New Product_ID Created
        If ProductsID = -1 Then Exit Function
        Dim _row_from As DataRow
        Dim _row_to As DataRow
        Dim _Date As String = Year(Now) & "-" & Month(Now) & "-" & Day(Now) & " " & Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        Dim _DSFrom As New DataSet
        Dim _DSTo As New DataSet
        _DSFrom.Tables.Add("products")
        Dim _newID As Integer
        DvdPostData.clsConnection.FillDataSet(_DSFrom.Tables("products"), "SELECT * FROM products WHERE products_id = " & ProductsID)
        _DSTo.Tables.Add(_DSFrom.Tables("products").Clone)
        If _DSFrom.Tables("products").Rows.Count = 1 Then
            _row_from = _DSFrom.Tables("products").Rows(0)
            _row_to = _DSTo.Tables("products").NewRow
            _row_to.ItemArray = _row_from.ItemArray
            _row_to("products_id") = 0
            _row_to("products_status") = -1
            _row_to("products_quantity") = 0
            _row_to("products_dvd_quantity") = 0
            _row_to("products_availability") = -1
            _row_to("products_date_added") = _Date
            _row_to("products_last_modified") = _Date
            _row_to("products_sale_date") = DBNull.Value
            _row_to("products_sale_price") = 0
            _row_to("quantity_to_sale") = 0
            _row_to("products_new_sale_price") = 0
            _row_to("quantity_new_to_sale") = 0
            _row_to("only_for_sale") = 0
            _row_to("feesharing") = 0
            _row_to("feesharing_end") = DBNull.Value
            _row_to("feesharing_upfront_fee") = 0
            _row_to("feesharing_upfront_fee_recoverable") = 0
            _row_to("feesharing_turn_price") = 0
            _row_to("feesharing_turn_price_after3month") = 0
            _row_to("feesharing_upfront_fee") = 0
            _row_to("feesharing_buy_option_price") = 0
            _row_to("feesharing_expected_nbr_turns") = 0
            _row_to("serie_id") = serie_id
            _row_to("season_id") = season_id
            _row_to("episode_id") = episode_id
            _DSTo.Tables("products").Rows.Add(_row_to)
            DvdPostData.clsConnection.UpdateDataTableInDB(_DSTo.Tables("products"), "SELECT * FROM products")
            'Retreiving the ID just Created
            _newID = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products where products_date_added = '" & _Date & "' ORDER by products_id desc limit 1 ")
            If _newID <> -1 Then
                'Creates Actors , Language, Undertiltes, SoundTracks, Trailers, Categories, Themes, DescFR, DescNL, DescEN
                CopyInfo("products_to_actors", _newID)
                CopyInfo("products_to_languages", _newID)
                CopyInfo("products_to_undertitles", _newID)
                CopyInfo("products_to_soundtracks", _newID)
                CopyInfo("products_trailers", _newID, "trailers_id")
                CopyInfo("products_to_categories", _newID)
                CopyInfo("products_to_themes", _newID)
                CopyInfo("products_description", _newID) 'ALL Languages in one SHot
            End If
            _serieProductsId.Add(_newID)
            Return _newID

        Else
            MsgBox("Impossible de copier cette fiche DVD", MsgBoxStyle.Exclamation)
            Return -1
        End If

    End Function
    Private Sub CopyInfo(ByVal vTableName As String, ByVal vToProductID As Integer, Optional ByVal IDFieldToNull As String = "")
        If ProductsID = -1 Then Exit Sub
        Dim _DSFrom As New DataSet
        Dim _DSTo As New DataSet
        Dim _row_from As DataRow
        Dim _row_to As DataRow
        _DSFrom.Tables.Add(vTableName)
        DvdPostData.clsConnection.FillDataSet(_DSFrom.Tables(vTableName), "SELECT * FROM " & vTableName & " WHERE products_id = " & ProductsID)
        _DSTo.Tables.Add(_DSFrom.Tables(vTableName).Clone)
        For Each _row_from In _DSFrom.Tables(vTableName).Rows
            _row_to = _DSTo.Tables(vTableName).NewRow
            _row_to.ItemArray = _row_from.ItemArray
            _row_to("products_id") = vToProductID
            If IDFieldToNull & "" <> "" Then
                _row_to(IDFieldToNull) = DBNull.Value
            End If
            _DSTo.Tables(vTableName).Rows.Add(_row_to)
        Next
        DvdPostData.clsConnection.UpdateDataTableInDB(_DSTo.Tables(vTableName), "SELECT * FROM " & vTableName)
    End Sub
    Public Sub Load_One_Products_DVD_Info()
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable")
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), "SELECT * FROM products_dvd where products_id = " & ProductsID & _
                   " AND products_dvdid = " & DvdId)
        If _DS.Tables("TmpTable").Rows.Count = 1 Then
            Products_dvd_row = _DS.Tables("TmpTable").Rows(0)
            _INOUT = Products_dvd_row("inout")
            _product_dvd_status = Products_dvd_row("products_dvd_status")
            _box_id = Products_dvd_row("box_id")
            _posBox_id = Products_dvd_row("pibox_id")
        Else
            Products_dvd_row = Nothing
        End If
    End Sub
    Public Sub Load_All_Products_DVD_Info()
        DataSet1.Tables("products_dvd").Clear()
        DvdPostData.clsConnection.FillDataSet(DataSet1.Tables("products_dvd"), "SELECT * FROM products_dvd where products_id = " & ProductsID)
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
'Public Class clsDVDPostMisc
'    Public mvarSessionInfo As BizzLib.clsSessionInfo
'    Public BKGlobal As BizzLib.clsGlobal
'    Public BKFilter As BizzLib.clsFilter
'    Public BKBrowseView As BizzLib.clsBrowseView
'    Public BKDefaultSet As BizzLib.clsDefaultSet
'    Public BKReport As BizzLib.clsReport
'    Public BKCombo As BizzLib.clsCombo
'    Public Property SessionInfo() As BizzLib.clsSessionInfo
'        Get
'            SessionInfo = mvarSessionInfo
'        End Get
'        Set(ByVal Value As BizzLib.clsSessionInfo)
'            mvarSessionInfo = Value
'        End Set
'    End Property
'    Public Sub SetBKOjects(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
'        mvarSessionInfo = CurrentSessionInfo
'        BKGlobal = New BizzLib.clsGlobal(SessionInfo)
'        BKFilter = New BizzLib.clsFilter(SessionInfo)
'        BKBrowseView = New BizzLib.clsBrowseView(SessionInfo)
'        BKDefaultSet = New BizzLib.clsDefaultSet(SessionInfo)
'        BKReport = New BizzLib.clsReport(SessionInfo)
'        BKCombo = New BizzLib.clsCombo(SessionInfo)
'    End Sub
'    Public Sub New(ByVal vSessionInfo As BizzLib.clsSessionInfo)
'        SetBKOjects(vSessionInfo)
'    End Sub

'End Class