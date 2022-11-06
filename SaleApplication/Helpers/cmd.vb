Imports System.Data.OleDb
Public Class cmd
    Shared cn As OleDbConnection = Nothing
    Shared cmd As OleDbCommand = Nothing
    Shared da As OleDbDataAdapter = Nothing
    Public Shared tran As OleDbTransaction = Nothing
    Shared lastCmd As String = ""
    Public Shared ConnectionString As String = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=|DataDirectory|\PMMS.accdb;" 'Jet OLEDB:Database Password=chun@b05061990"
    Public Shared Parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

    Public Shared Function generateCommand(ByVal sql As String, ByVal ParamArray args As Object()) As OleDbCommand
        For i As Integer = 0 To args.Length - 1
            sql = sql.Replace("{" & i & "}", "@P" & i)
            Parameters("@P" & i) = args(i)
        Next

        cmd = New OleDbCommand(sql)
        cmd.Connection = connection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        If Not (tran Is Nothing) Then
            cmd.Transaction = tran
        End If

        For Each p In Parameters
            If TypeOf p.Value Is DateTime Then
                cmd.Parameters.Add(p.Key, OleDbType.Date).Value = p.Value
            ElseIf TypeOf p.Value Is Long OrElse TypeOf p.Value Is Integer Then
                cmd.Parameters.Add(p.Key, OleDbType.SmallInt).Value = p.Value
            ElseIf TypeOf p.Value Is Double OrElse TypeOf p.Value Is Decimal OrElse TypeOf p.Value Is Single Then
                cmd.Parameters.Add(p.Key, OleDbType.Decimal).Value = p.Value
            ElseIf TypeOf p.Value Is Boolean Then
                cmd.Parameters.Add(p.Key, OleDbType.Boolean).Value = p.Value
            ElseIf p.Value Is Nothing OrElse p.Value Is DBNull.Value Then
                cmd.CommandText = cmd.CommandText.Replace(p.Key, "null")
            ElseIf TypeOf p.Value Is Byte() Then
                cmd.Parameters.Add(p.Key, OleDbType.LongVarBinary).Value = p.Value
            Else
                cmd.Parameters.Add(p.Key, OleDbType.VarWChar).Value = p.Value
            End If
        Next

        lastCmd = cmd.CommandText

        Parameters.Clear()

        Return cmd
    End Function

    Public Shared Function connection() As OleDbConnection
        Try
            If cn Is Nothing Then
                cn = New OleDbConnection(ConnectionString)
            End If
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Return cn
        Catch generatedExceptionName As OleDbException
            cn = New OleDbConnection(ConnectionString)
            cn.Open()
            Return cn
        End Try
    End Function


    Public Shared Function ExecuteScalar(ByVal sql As String, ByVal ParamArray values As Object()) As Object
        Return generateCommand(sql, values).ExecuteScalar()
    End Function

    Public Shared Function ExecuteNonQuery(ByVal sql As String, ByVal ParamArray values As Object()) As Integer
        generateCommand(sql, values).ExecuteNonQuery()
    End Function

    Public Shared Function ExecuteDataTable(ByVal sql As String, ByVal ParamArray values As Object()) As DataTable
        If da Is Nothing Then
            da = New OleDbDataAdapter()
        End If
        da.SelectCommand = generateCommand(sql, values)
        Dim dt As New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function ExecuteDataReader(ByVal sql As String, ByVal ParamArray values As Object()) As IDataReader
        Return generateCommand(sql, values).ExecuteReader()
    End Function

    Public Shared Function ExecuteDataSet(ByVal sql As String, ByVal ParamArray values As Object()) As DataSet
        If da Is Nothing Then
            da = New OleDbDataAdapter()
        End If
        da.SelectCommand = generateCommand(sql, values)
        Dim ds As New DataSet()
        da.Fill(ds)
        Return ds
    End Function

    Public Shared Sub Begin()
        If tran Is Nothing Then
            tran = connection().BeginTransaction()
            If cmd Is Nothing Then
                cmd = connection().CreateCommand()
            End If
            cmd.Transaction = tran
        End If
    End Sub
    Public Shared Sub Commit()
        tran.Commit()
        tran = Nothing
    End Sub
    Public Shared Sub Rollback()
        tran.Rollback()
        tran = Nothing
    End Sub
    Public Shared ReadOnly Property Trans() As OleDbTransaction
        Get
            Return tran
        End Get
    End Property
End Class
