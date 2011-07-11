Imports MySql.Data.MySqlClient


Namespace BizzLibNew

    Public Class ClsDataSet

        'Private _mysqlole As MySqlDataAdapter
        'Private _MySqlOleCmd As MySqlCommand
        'Private _MySqlOleRD As MySqlDataReader
        'Private _oleCmd As OleDbCommand
        'Private _oledb As OleDbDataAdapter
        'Private _oledbRD As OleDbDataReader
        'Private _SQLCmd As SqlCommand
        Private _sqlole As MySql.Data.MySqlClient.MySqlDataAdapter
        Private _SQLOleRD As MySql.Data.MySqlClient.MySqlDataReader
        Private SessionInfo As BizzLibNew.clsSessionInfo

        Public Sub New(ByVal CurrSessionInfo As BizzLibNew.clsSessionInfo)
            Me.SessionInfo = CurrSessionInfo
        End Sub

        Public Sub FillDataSet(ByVal dataTable1 As DataTable, ByVal SQLTxt As String)

            If (Me.SessionInfo.MySqlDbConn.State <> ConnectionState.Open) Then
                Me.SessionInfo.MySqlDbConn.Open()
            End If
            Me._sqlole = New MySql.Data.MySqlClient.MySqlDataAdapter(SQLTxt, Me.SessionInfo.MySqlDbConn)
            Me._sqlole.Fill(dataTable1)

        End Sub

        Public Function ExecuteNonQuery(ByVal SQLtxt As String, Optional ByVal vBoolCopyToClipBoard As Boolean = True) As Integer
            Dim num As Integer
            If (Me.SessionInfo.DBName = "") Then
                moGeneral.OleDBConnInitialize(Me.SessionInfo)
            End If

            If (Me.SessionInfo.DBConnType = "MySQL") Then
                Dim command3 As New MySqlCommand(SQLtxt, Me.SessionInfo.MySqlDbConn)
                If ((Me.SessionInfo.MySqlDbConn.State = ConnectionState.Closed) Or (Me.SessionInfo.MySqlDbConn.State = ConnectionState.Broken)) Then
                    Me.SessionInfo.MySqlDbConn.Open()
                End If
                Try
                    num = command3.ExecuteNonQuery
                Catch exception1 As Exception
                    'ProjectData.SetProjectError(exception1)
                    'Dim exception As Exception = exception1
                    'Interaction.InputBox(exception.Message, "SQL String causing the error", SQLtxt, -1, -1)
                    'ProjectData.ClearProjectError()
                End Try
            End If
            Return num
        End Function


    End Class
End Namespace
