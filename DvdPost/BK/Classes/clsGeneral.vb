Public Class clsData_Holding
    Inherits BizzLib.clsOneTableData

    'GitIgnore

    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
        MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "HoldingID", "SELECT * FROM generalholding ", WhereClause, OrderByTxt)
    End Sub
    Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(SessionInfo)
    End Sub

    Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check if Entity Exist
        If Row1("HoldingID") & "" <> "" Then
            Dim _DataEntity As New BizzLib.clsData_Entity(SessionInfo)
            If _DataEntity.Exists("HoldingID", Row1("HoldingID")) Then
                'Cannot Delete - Entities as Attached to this Holding
                _MsgID = 12
            End If
        End If
        Return _MsgID
    End Function
    Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
        Dim _MsgID As Integer = -1
        'Check ID
        If Row1(IDField) & "" = "" Then
            Row1(IDField) = BKGlobal.GetNextID(IDField)
        End If
        'Check Name
        If Row1("Name") & "" = "" Then
            'Name Cannot Be Blank
            _MsgID = 5
        End If
        Return _MsgID
    End Function

    Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
        Return BKGlobal.ExecuteExists("Select Count(*) FROM generalholding WHERE " & IDFieldName & " = " & ID)
    End Function
    Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
        Return BKGlobal.ExecuteDelete("DELETE generalholding WHERE AddrID = " & ID)
    End Function
End Class

Public Class clsCurrency
    Public Class clsData_Currency
        Inherits BizzLib.clsOneTableData
        Dim mvarExRateData As New clsData_CurrencyExRate(SessionInfo)
        Dim mvarExRateTableName As String = "systemcurrencyexrate"


        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "CurrCode", "SELECT * FROM systemcurrency ", WhereClause, OrderByTxt)
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, ByVal CurrCode As String, ByVal WhereClause As String, ByVal OrderByTxt As String)
            MyBase.New(SessionInfo)
            If WhereClause = "" Then
                MyBase.Initialize(DataSet1, DataSetType, TableName, "CurrCode", "SELECT * FROM systemcurrency ", " WHERE CurrCode = " & CurrCode, OrderByTxt)
            Else
                MyBase.Initialize(DataSet1, DataSetType, TableName, "CurrCode", "SELECT * FROM systemcurrency ", WhereClause & " AND CurrCode = " & CurrCode, OrderByTxt)
            End If
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
            MyBase.New(SessionInfo)
        End Sub

        ReadOnly Property ExRateTableName() As String
            Get
                ExRateTableName = mvarExRateTableName
            End Get
        End Property

        'ReadOnly Property ExRateObject() As clsData_CurrencyExRate
        '    Get
        '        ExRateObject = mvarExRateData
        '    End Get
        'End Property
        Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
            Dim _MsgID As Integer = -1
            'Check if Transactions Exist
            If Row1("CurrCode") & "" <> "" Then
                Dim _Data As New clsData_CurrencyExRate(SessionInfo)
                If _Data.Exists("CurrCode", Row1("CurrCode")) Then
                    'TUTU TUTU Cannot Delete - Transactions exists
                    _MsgID = 21
                End If
            End If
            Return _MsgID
        End Function
        Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
            Dim _MsgID As Integer = -1
            'Check CurrCode
            If Row1("CurrCode") & "" = "" Then
                'TUTU TUTU Name Cannot Be Blank
                _MsgID = 5
            End If
            Return _MsgID
        End Function
        Public Overloads Sub Save()
            Dim _MsgID As Integer = -1
            'Add Any Saving Before
            Try
                _MsgID = ValidateDataSetBeforeSave()
                If _MsgID <= 0 Then
                    'Save Associated ExRate
                    mvarExRateData.Save()
                    'Save Changes
                    SaveDataSet()
                Else
                    Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Overloads Sub SaveOnlyCurrency()
            Dim _MsgID As Integer = -1
            'Add Any Saving Before
            Try
                _MsgID = ValidateDataSetBeforeSave()
                If _MsgID <= 0 Then
                    'Save Changes
                    SaveDataSet()
                Else
                    Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Overloads Sub SaveOnlyExRate()
            Dim _MsgID As Integer = -1
            'Add Any Saving Before
            Try
                _MsgID = ValidateDataSetBeforeSave()
                If _MsgID <= 0 Then
                    'Save Associated ExRates
                    mvarExRateData.Save()
                Else
                    Throw New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Overloads Sub Delete(ByVal CurrCode As String)
            Dim _View1 As DataView
            Dim _MsgID As Integer = -1

            _View1 = New DataView(DataSet1.Tables(TableName), MyBase.IDField & " = " & CurrCode, _
                 MyBase.IDField, DataViewRowState.CurrentRows)
            If _View1.Count = 0 Then
                Exit Sub
            End If
            _MsgID = ValidateRecordBeforeDelete(_View1(0))
            If _MsgID <= 0 Then
                'Delete associated Tables : exRates
                mvarExRateData.DeleteByCurrCode(CurrCode)
                'Delete the Record
                _View1(0).Delete()
                Save()
            Else
                Dim _ex As New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                _ex.Source = "##"
                Throw _ex
            End If
        End Sub

        Public Overloads Overrides Function Exists(ByVal IDFieldName As String, ByVal CurrCode As Integer) As Boolean
            Return False
        End Function
        Public Overloads Function Exists(ByVal IDFieldName As String, ByVal CurrCode As String) As Boolean
            Return BKGlobal.ExecuteExists("Select Count(*) FROM systemcurrency WHERE CurrCode = " & CurrCode)
        End Function
        Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
            Return 0
        End Function
        Public Overloads Function DeleteByCurrCode(ByVal CurrCode As String) As Integer
            Return BKGlobal.ExecuteDelete("DELETE systemcurrency WHERE CurrCode = '" & CurrCode & "'")
        End Function

        Public Function GetFirstExRateDate(ByVal ExChangeType As String) As Date
            Dim _ExRate As clsData_CurrencyExRate
            Dim _DS As New DataSet
            Dim _TableName As String = "systemcurrencyexrate"

            '_ExRate = New clsData_CurrencyExRate(_DS, DataSetType, _TableName, CurrCode, 1, " ORDER BY FromDate ASC ")
            _ExRate = New clsData_CurrencyExRate(SessionInfo, _DS, DataSetType, _TableName, "", " ORDER BY FromDate ASC ", 1, ExChangeType)
            If _DS.Tables(_TableName).Rows.Count > 0 Then
                Return _DS.Tables(_TableName).Rows(0)("FromDate")
            Else
                Return Today
            End If
        End Function
        Public Function GetLastExRateDate(ByVal ExChangeType As String) As Date
            Dim _ExRate As clsData_CurrencyExRate
            Dim _DS As New DataSet
            Dim _TableName As String = "systemcurrencyexrate"

            _ExRate = New clsData_CurrencyExRate(SessionInfo, _DS, DataSetType, _TableName, "", " ORDER BY FromDate DESC ", 1, ExChangeType)
            If _DS.Tables(_TableName).Rows.Count > 0 Then
                Return _DS.Tables(_TableName).Rows(0)("FromDate")
            Else
                Return Today
            End If
        End Function
        Public Function GetPreviousExRateDate(ByVal AsOfDate As Date, ByVal ExChangeType As String) As Date
            Dim _ExRate As clsData_CurrencyExRate
            Dim _DS As New DataSet
            Dim _TableName As String = "systemcurrencyexrate"
            Dim _Where As String

            _Where = " WHERE FromDate < '" & AsOfDate.ToString("d", New System.Globalization.CultureInfo(SessionInfo.DataBaseCultureInfo)) & "' "
            _ExRate = New clsData_CurrencyExRate(SessionInfo, _DS, DataSetType, _TableName, _Where, " ORDER BY FromDate DESC ", 1, ExChangeType)
            If _DS.Tables(_TableName).Rows.Count > 0 Then
                Return _DS.Tables(_TableName).Rows(0)("FromDate")
            Else
                Return GetFirstExRateDate(ExChangeType)
            End If
        End Function
        Public Function GetNextExRateDate(ByVal AsOfDate As Date, ByVal ExChangeType As String) As Date
            Dim _ExRate As clsData_CurrencyExRate
            Dim _DS As New DataSet
            Dim _TableName As String = "systemcurrencyexrate"
            Dim _Where As String

            _Where = " WHERE FromDate > '" & AsOfDate.ToString("d", New System.Globalization.CultureInfo(SessionInfo.DataBaseCultureInfo)) & "' "
            _ExRate = New clsData_CurrencyExRate(SessionInfo, _DS, DataSetType, _TableName, _Where, " ORDER BY FromDate ASC ", 1, ExChangeType)
            If _DS.Tables(_TableName).Rows.Count > 0 Then
                Return _DS.Tables(_TableName).Rows(0)("FromDate")
            Else
                Return GetLastExRateDate(ExChangeType)
            End If
        End Function
        Public Sub LoadExRates(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal CurrCode As String)
            mvarExRateData = New clsData_CurrencyExRate(SessionInfo, DataSet1, DataSetType, mvarExRateTableName, CurrCode, " ORDER BY FromDate ")
            DataSet1.Tables(mvarExRateTableName).Columns("CurrCode").DefaultValue = CurrCode
        End Sub
        Public Sub LoadExrates(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal CurrCode As String, ByVal AtDate As Date, ByVal ExChangeType As String)
            mvarExRateData = New clsData_CurrencyExRate(SessionInfo, DataSet1, DataSetType, mvarExRateTableName, CurrCode, AtDate, " ORDER BY CurrCode ", ExChangeType)
            DataSet1.Tables(mvarExRateTableName).Columns("CurrCode").DefaultValue = CurrCode
        End Sub
        Public Sub LoadExrates(ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal AtDate As Date, ByVal ExChangeType As String)
            mvarExRateData = New clsData_CurrencyExRate(SessionInfo, DataSet1, DataSetType, mvarExRateTableName, AtDate, " ORDER BY CurrCode ", ExChangeType)
            DataSet1.Tables(mvarExRateTableName).Columns("FromDate").DefaultValue = AtDate
        End Sub

    End Class
    Protected Friend Class clsData_CurrencyExRate
        Inherits BizzLib.clsOneTableData
        Dim mvarExChangeType As String = "0" 'Default Type

        Property ExChangeType() As String
            Get
                ExChangeType = mvarExChangeType
            End Get
            Set(ByVal Value As String)
                mvarExChangeType = Value
            End Set
        End Property
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                       ByVal WhereClause As String, ByVal OrderByTxt As String)
            MyBase.New(SessionInfo)
            'If WhereClause = "" Then
            '    WhereClause = " WHERE Forecast = 0"
            'Else
            '    WhereClause += " AND Forecast = 0 "
            'End If
            Initialize(DataSet1, DataSetType, TableName, "", "SELECT * FROM systemcurrencyexrate ", WhereClause, OrderByTxt)
            'DataSet1.Tables(TableName).Columns("Forecast").DefaultValue = 0
            mvarExChangeType = ExChangeType
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                       ByVal CurrCode As String, ByVal WhereClause As String, ByVal OrderByTxt As String, ByVal ExChangeType As String)
            MyBase.New(SessionInfo)
            mvarExChangeType = ExChangeType
            If WhereClause = "" Then
                WhereClause = " WHERE CurrCode = '" & CurrCode & "' AND ExChangeType = '" & mvarExChangeType & "'"
            Else
                WhereClause += " AND CurrCode = '" & CurrCode & "' AND ExChangeType = '" & mvarExChangeType & "'"
            End If
            Initialize(DataSet1, DataSetType, TableName, "", "SELECT * FROM systemcurrencyexrate ", _
                       WhereClause, OrderByTxt)
            'DataSet1.Tables(TableName).Columns("Forecast").DefaultValue = 0

        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                       ByVal CurrCode As String, ByVal AsOfDate As Date, ByVal OrderByTxt As String, ByVal ExChangeType As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "", "SELECT TOP 1 * FROM systemcurrencyexrate ", _
                     " WHERE CurrCode = '" & CurrCode & "' AND ExChangeType = '" & ExChangeType & "' " & _
                     " AND FromDate = '" & AsOfDate.ToString("d", New System.Globalization.CultureInfo(SessionInfo.DataBaseCultureInfo)) & "' " & _
                     " ", OrderByTxt)
            mvarExChangeType = ExChangeType
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                       ByVal AsOfDate As Date, ByVal OrderByTxt As String, ByVal ExChangeType As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "", "SELECT * FROM systemcurrencyexrate ", _
                     " WHERE ExChangeType = '" & ExChangeType & "' " & _
                     " AND FromDate = '" & AsOfDate.ToString("d", New System.Globalization.CultureInfo(SessionInfo.DataBaseCultureInfo)) & "' " & _
                     " ", OrderByTxt)
            mvarExChangeType = ExChangeType
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                       ByVal CurrCode As String, ByVal TopRows As Integer, ByVal OrderByTxt As String, ByVal ExChangeType As String)
            MyBase.New(SessionInfo, DataSet1, DataSetType, TableName, "", _
                    "SELECT Top " & TopRows & " * FROM systemcurrencyexrate ", _
                    " WHERE CurrCode = '" & CurrCode & _
                    "' AND ExChangeType = '" & ExChangeType & "' ", OrderByTxt)
            mvarExChangeType = ExChangeType
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo, ByVal DataSet1 As DataSet, ByVal DataSetType As String, ByVal TableName As String, _
                       ByVal WhereClause As String, ByVal OrderByTxt As String, ByVal TopRows As Integer, ByVal ExChangeType As String)
            MyBase.New(SessionInfo)
            mvarExChangeType = ExChangeType
            If WhereClause = "" Then
                WhereClause = " WHERE ExChangeType = '" & mvarExChangeType & "'"
            Else
                WhereClause += " AND ExChangeType = '" & mvarExChangeType & "'"
            End If
            Initialize(DataSet1, DataSetType, TableName, "", _
                    "SELECT Top " & TopRows & " * FROM systemcurrencyexrate ", _
                    WhereClause, OrderByTxt)
        End Sub
        Public Sub New(ByVal SessionInfo As BizzLib.clsSessionInfo)
            MyBase.New(SessionInfo)
        End Sub

        Public Overrides Function ValidateRecordBeforeDelete(ByVal Row1 As System.Data.DataRowView) As Integer
            Dim _MsgID As Integer = -1
            Return _MsgID
        End Function
        Public Overrides Function ValidateRecordFields(ByRef Row1 As System.Data.DataRowView) As Integer
            Dim _MsgID As Integer = -1
            ''Check ID
            'If Row1(IDField) & "" = "" Then
            '    Row1(IDField) = BKGlobal.GetNextID(IDField)
            'End If
            'Check BankID
            'Check BankAccountID

            Return _MsgID
        End Function

        Public Overrides Function Exists(ByVal IDFieldName As String, ByVal ID As Integer) As Boolean
            'Return BKGlobal.ExecuteExists("Select Count(*) FROM CashBankCreditLine WHERE " & IDFieldName & " = " & ID)
            Return False
        End Function

        Public Overloads Overrides Function DeleteByID(ByVal ID As Integer) As Integer
            Return BKGlobal.ExecuteDelete("DELETE systemcurrencyexrate WHERE ExChangeID = " & ID)
        End Function

        Public Overloads Sub DeleteByCurrCode(ByVal CurrCode As String)
            Dim _View1 As DataView
            Dim _MsgID As Integer = -1
            Dim _Row1 As DataRowView
            _View1 = New DataView(DataSet1.Tables(TableName), "CurrCode = " & CurrCode, MyBase.IDField, DataViewRowState.CurrentRows)
            If _View1.Count = 0 Then
                Exit Sub
            End If
            If _View1.Count > 0 Then
                For Each _Row1 In _View1
                    _MsgID = ValidateRecordBeforeDelete(_Row1)
                    If _MsgID <= 0 Then
                        'Delete the Record
                        _Row1.Delete()
                    Else
                        Dim _ex As New Exception(BKGlobal.GetMsg(_MsgID, SessionInfo.UserLang))
                        _ex.Source = "##"
                        Throw _ex
                    End If
                Next
                Save()
            End If
        End Sub
    End Class
End Class