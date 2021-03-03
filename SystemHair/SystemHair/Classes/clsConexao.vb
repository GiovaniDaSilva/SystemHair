Imports System.Data.SqlClient

Public Class clsConexao


    Dim glfConexao As SqlClient.SqlConnection
    'Dim glfTransaction As SqlTransaction

    'Public Sub BeginTransaction()
    '    glfTransaction = glfConexao.BeginTransaction()
    'End Sub

    'Public Sub Commit()
    '    glfTransaction.Commit()
    'End Sub

    'Public Sub RollBack()
    '    glfTransaction.Rollback()
    'End Sub


    Public Sub Conectar()
        Try
            'usuario SQL
            'glfConexao = New SqlClient.SqlConnection("Data Source = WS800\MSSQL2016DEV; INITIAL CATALOG = SYSTEM_HAIR; USER ID = SYSTEM_HAIR; PASSWORD = SYSTEM_HAIR")

            'Windows Autenticarion
            glfConexao = New SqlClient.SqlConnection("Data Source = GIOVANI-PC\SQLEXPRESS; Database=SYSTEM_HAIR;Integrated Security=SSPI;")

            glfConexao.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            If Not IsNothing(glfConexao) Then
                If glfConexao.State = ConnectionState.Open Then
                    glfConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ExecuteQueryDataSet(ByVal parSQL As String) As DataSet
        Dim locRetorno As New DataSet
        Dim locDataAdapter As New SqlClient.SqlDataAdapter
        Dim locComando As New SqlClient.SqlCommand

        Try
            Me.Conectar()
            locComando = glfConexao.CreateCommand
            locComando.CommandText = parSQL
            locDataAdapter = New SqlClient.SqlDataAdapter(locComando)

            locDataAdapter.Fill(locRetorno)
            Me.Desconectar()
        Catch ex As Exception
            Me.Desconectar()
            Throw ex
        End Try
        Return locRetorno
    End Function

    Public Function Execute(ByVal parSQL As String, Optional ByVal parTransaction As Boolean = False) As Boolean
        Dim locComando As SqlClient.SqlCommand
        Dim locRetorno As Boolean

        Try
            If Not parTransaction Then Me.Conectar()
            locRetorno = False
            locComando = New SqlClient.SqlCommand(parSQL, glfConexao)
            If locComando.ExecuteNonQuery() = 1 Then
                locRetorno = True
            End If
            If Not parTransaction Then Me.Desconectar()
        Catch ex As Exception
            Me.Desconectar()
            Throw ex
        End Try

        Return locRetorno
    End Function


    Public Function ExecuteQueryDataReader(ByVal parSQL As String) As SqlClient.SqlDataReader
        Dim locDataReader As SqlClient.SqlDataReader
        Dim locSQLCommand As SqlClient.SqlCommand

        Try
            locSQLCommand = New SqlCommand(parSQL, glfConexao)
            locDataReader = locSQLCommand.ExecuteReader()
        Catch ex As Exception
            Throw ex
        End Try
        Return locDataReader
    End Function


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    glfBanco.Conectar()
    '    Dim ds As DataSet = glfBanco.ExecuteQuery("Select * from teste")

    '    DataGridView1.DataSource = ds.Tables(0)
    '    glfBanco.Fechar()
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    glfBanco.Conectar()
    '    glfBanco.Execute("Insert into Teste values (10,'Giovani')")
    '    glfBanco.Fechar()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Dim locConsulta As New clsConsulaDefault
    '    locConsulta.ColunaFiltro = "Codigo"
    '    locConsulta.ConsultaF2("Select * from Teste", "Consulta Teste ")
    'End Sub
End Class
