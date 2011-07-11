Imports MySql.Data.MySqlClient

Public Class clsConnection

    Private Const _TIMEOUT As Integer = 120 * 60
    Private Shared ITimeout As Integer = 0
    Private Const SEPARATOR As String = ";*;"
    Private Shared _connectWrite As MySqlConnection
    Private Shared _connectRead As MySqlConnection
    Private Shared _transact As MySqlTransaction
    Private Shared _typeEnv As String
    Private Shared _dataAdapter As MySqlDataAdapter
    Private Shared _isBulkQuery As Boolean ' only before commitransation you execute the bulkquery
    Private Shared _BulkQuery As String  ' all query
    Private Shared _connectionString As String

    Public Enum typeAccessDb
        WRITE
        READ
    End Enum

    Public Shared ReadOnly Property ConnectionString() As String
        Get
            Return _connectionString
        End Get
    End Property

    Public Shared ReadOnly Property bulkQuery() As String
        Get
            Return _BulkQuery & _isBulkQuery.ToString()
        End Get
    End Property
    Public Shared Property timeoutMIN() As Integer
        Get
            Return ITimeout
        End Get
        Set(ByVal value As Integer)
            ITimeout = value * 60
        End Set
    End Property


    Public Shared Property typeEnv() As String
        Get
            Return _typeEnv
        End Get
        Set(ByVal value As String)
            If Not _connectWrite Is Nothing AndAlso _connectWrite.State = ConnectionState.Open Then
                _connectWrite.Close()
            End If
            _typeEnv = value

        End Set
    End Property
    Public Shared Property ConnectType(ByVal access As typeAccessDb) As MySqlConnection

        Get
            Dim connect As MySql.Data.MySqlClient.MySqlConnection
            connect = GetConnect(access)

            If connect Is Nothing OrElse connect.State = ConnectionState.Closed OrElse Not connect.Ping() Then
                access = NewConnection(access)
            End If
            Return GetConnect(access)
        End Get
        Set(ByVal value As MySqlConnection)
            Dim connect As MySql.Data.MySqlClient.MySqlConnection
            connect = GetConnect(access)
            connect = value
            SetConnect(access, connect)
        End Set
    End Property

    Private Shared Sub SetConnect(ByVal access As typeAccessDb, ByVal ConnectType As MySqlConnection)
        If access = typeAccessDb.WRITE Then
            _connectWrite = ConnectType
        Else
            _connectRead = ConnectType
        End If
    End Sub

    Private Shared Function GetConnect(ByVal access As typeAccessDb) As MySqlConnection
        If access = typeAccessDb.WRITE Then
            Return _connectWrite
        Else
            Return _connectRead
        End If
    End Function

    Public Shared Sub CreateTransaction(ByVal isBulkQuery As Boolean)
        If _connectWrite IsNot Nothing Then
            _connectWrite.Close()
            ConnectType(typeAccessDb.WRITE) = Nothing
        End If
        NewConnection(typeAccessDb.WRITE)
        If _transact IsNot Nothing Then
            Dim sql As String
            sql = clsMsgError.InsertLogMsg(clsMsgError.processType.Batch, " error create transaction but exist an other transaction not finished !!")
            DvdPostData.clsConnection.ExecuteNonQuery(sql, True)
            Return
        End If


        _isBulkQuery = isBulkQuery
        If Not isBulkQuery Then
            _transact = _connectWrite.BeginTransaction()

        Else
            If _BulkQuery IsNot Nothing AndAlso _BulkQuery IsNot String.Empty Then
                Dim cpt_result As Integer
                ExecuteBulkQuery(clsMsgError.processType.Email, cpt_result)
            End If
            _BulkQuery = String.Empty

        End If


    End Sub

    Private Shared Function CutQuery(ByVal sqlScript As String) As List(Of String)

        Dim lstTmp As String()
        Dim sqlTmp As String
        Dim result As List(Of String) = New List(Of String)
        lstTmp = sqlScript.Split(New String() {SEPARATOR}, StringSplitOptions.RemoveEmptyEntries)

        sqlTmp = ""
        ' couper toutes les 20 lignes 
        For i As Integer = 0 To lstTmp.Length - 1

            If (i + 1) Mod 20 = 0 Then
                result.Add(sqlTmp)
                sqlTmp = lstTmp(i) & ";"
            Else
                sqlTmp += lstTmp(i) & ";"
            End If
        Next
        result.Add(sqlTmp)
        Return result
    End Function
    Public Shared Function CancelBulkQuery() As Boolean
        _isBulkQuery = False
        _BulkQuery = ""
    End Function
    Public Shared Function ExecuteBulkQuery(ByVal typeProcess As DvdPostData.clsMsgError.processType, ByRef cpt_result As Integer) As Boolean

        If _transact IsNot Nothing Then
            CommitTransaction(True)
        End If
        _transact = Nothing

        CreateTransaction(False)
        Try
            cpt_result = 0
            Dim result As List(Of String)
            If (_BulkQuery IsNot Nothing AndAlso _BulkQuery IsNot String.Empty) Then

                result = CutQuery(_BulkQuery)

                For Each sql As String In result
                    cpt_result += ExecuteNonQuery(sql)
                Next

            End If
            CancelBulkQuery()
            CommitTransaction(True)
            Return True

        Catch ex As Exception
            CommitTransaction(False)
            If Not clsSession.isBatch Then MsgBox(ex.Message)

            Dim sql As String
            sql = clsMsgError.InsertLogMsg(typeProcess, ex.Message & " " & ex.StackTrace)
            DvdPostData.clsConnection.ExecuteNonQuery(sql, True)
            CancelBulkQuery()
            Return False
        End Try

    End Function
    Public Shared Sub CommitTransaction(ByVal ok As Boolean)
        If _transact Is Nothing Then Return
        If ok Then
            _transact.Commit()
        Else
            _transact.Rollback()
        End If
        _transact = Nothing


        Dim sql As String
        '  sql = clsMsgError.InsertLogMsg(clsMsgError.processType.Batch, "Commit Transaction " & ok)
        '  DvdPostData.clsConnection.ExecuteNonQuery(sql, True)
        '_transact.Dispose()
    End Sub
    Public Shared Function GetConnectionString(ByVal typeenv As String, ByVal access As typeAccessDb) As String
        Return typeenv & "-" & DVDPostTools.clsEnum.getNameStrEnum(access)

    End Function

    Private Shared Function NewConnection(ByVal access As typeAccessDb) As typeAccessDb

        Dim connect As MySql.Data.MySqlClient.MySqlConnection
        Dim key As String

        key = GetConnectionString(typeEnv, access)
        _connectionString = Configuration.ConfigurationManager.ConnectionStrings(key).ConnectionString
        connect = GetConnect(access)
        connect = New MySqlConnection(_connectionString)
        SetConnect(access, connect)
        _transact = Nothing
        Try
            connect.Open()
            Return access
        Catch
            If access = typeAccessDb.READ Then
                NewConnection(typeAccessDb.WRITE)
                Return typeAccessDb.WRITE
            End If
        End Try

    End Function

    Private Shared Function CreateCommand(ByVal sql As String, ByVal access As typeAccessDb) As MySqlCommand
        Dim mycommand As MySqlCommand
        Dim connect As MySql.Data.MySqlClient.MySqlConnection
        If Not _transact Is Nothing Then
            access = typeAccessDb.WRITE
        End If
        connect = GetConnect(access)

        If _transact Is Nothing Then
            mycommand = New MySqlCommand(sql, ConnectType(access))
        Else
            mycommand = New MySqlCommand(sql, ConnectType(access), _transact)
        End If
        If timeoutMIN = 0 Then
            mycommand.CommandTimeout = _TIMEOUT
        Else
            mycommand.CommandTimeout = timeoutMIN
        End If
        Return mycommand

    End Function
    Public Shared Function ExecuteNonQuery(ByVal sql As String, Optional ByVal forced As Boolean = False) As Integer
        Dim mycommand As MySqlCommand


        If _isBulkQuery And Not forced Then
            _BulkQuery = _BulkQuery + sql + SEPARATOR
            ' simuler que l'update a bien eu lieu 
            Return 1
        Else

            mycommand = CreateCommand(sql, typeAccessDb.WRITE)
            Return mycommand.ExecuteNonQuery()
        End If


    End Function

    Public Shared Function ExecuteScalar(ByVal sql As String, Optional ByVal access As typeAccessDb = typeAccessDb.WRITE) As Object
        Dim mycommand As MySqlCommand
        mycommand = CreateCommand(sql, access)
        Return mycommand.ExecuteScalar()

    End Function
    Private Shared Sub Init(ByVal sql As String, ByVal access As typeAccessDb)

        If Not (ConnectType(access).State = ConnectionState.Open AndAlso _dataAdapter IsNot Nothing) Then
            _dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, ConnectType(access))
        End If
    End Sub
    Public Shared Sub FillDataSet(ByRef dt As DataTable, ByVal sql As String, Optional ByVal access As typeAccessDb = typeAccessDb.WRITE)

        If Not GetConnect(access) Is Nothing And _transact Is Nothing Then
            GetConnect(access).Close()
        End If

        Init(sql, access)
        _dataAdapter.SelectCommand = CreateCommand(sql, access)
        _dataAdapter.Fill(dt)
        _dataAdapter.Dispose()

    End Sub

    Public Shared Function FillDataSet(ByVal sql As String, Optional ByVal access As typeAccessDb = typeAccessDb.WRITE) As DataTable
        Dim dt As DataTable = New DataTable
        Init(sql, access)
        _dataAdapter.SelectCommand = CreateCommand(sql, access)
        _dataAdapter.Fill(dt)

        Return dt

    End Function
    Public Shared Function SaveData(ByVal dt As DataTable)
        Dim cpt As Integer
        cpt = _dataAdapter.Update(dt)
        Return cpt > 0
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        If Not _connectRead Is Nothing Then
           
            _connectRead.Close()
            _connectRead.Dispose()

        End If

        If Not _connectWrite Is Nothing Then
            If Not _transact Is Nothing Then
                _transact.Commit()
            End If

            _connectWrite.Close()
            _connectWrite.Dispose()

        End If
    End Sub

    Public Shared Sub UpdateDataTableInDB(ByVal dt As DataTable, ByVal sql As String)

        If dt.GetChanges() Is Nothing Then Return
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, _connectWrite)
        Dim builder As New MySqlCommandBuilder(da)
        da.Update(dt)
    End Sub

    'Public Shared Sub UpdateDataTableInDB(ByVal ds As DataSet, ByVal sql As String)

    '    If ds.GetChanges() Is Nothing Then Return
    '    Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, _connectWrite)
    '    Dim builder As New MySqlCommandBuilder(da)
    '    da.Update(ds)
    'End Sub
End Class