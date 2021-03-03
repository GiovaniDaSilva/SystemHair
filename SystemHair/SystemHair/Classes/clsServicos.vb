Public Class clsServicos
    Private _ID As Integer
    Private _Codigo As Integer
    Private _Nome As String
    Private _Valor As String
    Private _Descricao As String

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Codigo As Integer
        Get
            Return _Codigo
        End Get
        Set(value As Integer)
            _Codigo = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _Nome
        End Get
        Set(value As String)
            _Nome = value
        End Set
    End Property

    Public Property Valor As String
        Get
            Return _Valor
        End Get
        Set(value As String)
            _Valor = value
        End Set
    End Property

    Public Property Descricao As String
        Get
            Return _Descricao
        End Get
        Set(value As String)
            _Descricao = value
        End Set
    End Property


    Public Function Grava() As Boolean

        Dim locConexao As New clsConexao
        Dim locSQL As String
        Dim locCodigo As Long


        Try
            locCodigo = 0
            Grava = True
            locSQL = vbNullString

            If ID = 0 Then

                locSQL = locSQL & vbCr & "INSERT INTO SERVICOS( CODIGO, NOME, VALOR, DESCRICAO)  VALUES("
                locCodigo = funRetornaProximoCodigo("SERVICOS", "CODIGO")

                locSQL = locSQL & vbCr & locCodigo
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Nome, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Valor, enumTipoDados.TP_DOUBLE)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Descricao, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ")"
            Else
                locSQL = locSQL & vbCr & "UPDATE SERVICOS SET"
                locSQL = locSQL & vbCr & "   NOME = " & funAjustaCampoSQL(Me.Nome, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,VALOR = " & funAjustaCampoSQL(Me.Valor, enumTipoDados.TP_DOUBLE)
                locSQL = locSQL & vbCr & "  ,DESCRICAO = " & funAjustaCampoSQL(Me.Descricao, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  WHERE ID = " & ID
            End If

            If Not locConexao.Execute(locSQL) Then
                MsgBox("Falha na gravação do Serviço.", vbExclamation)
            Else
                If Me.ID = 0 Then
                    MsgBox("Serviço gravado com sucesso. Código: " & locCodigo, vbInformation)
                Else
                    MsgBox("Serviço gravado com sucesso.", vbInformation)
                End If
            End If

        Catch ex As Exception
            MsgBox("Falha na gravação do Serviço." & vbNewLine & ex.Message, vbExclamation)
        End Try

    End Function

    Private Function funRetornaProximoCodigo(v1 As String, v2 As String) As Long
        Return clsRotinas.funRetornaProximoCodigo(v1, v2)
    End Function


    Public Function Exclui() As Boolean
        Dim locSQL As String
        Dim locConexao As New clsConexao

        Exclui = True
        If ID = 0 Then
            MsgBox("Nenhum serviço selecionado.", vbExclamation)
            Exit Function
        End If


        locSQL = "DELETE FROM SERVICOS WHERE ID = " & ID

        If Not locConexao.Execute(locSQL) Then
            MsgBox("Falha na exclusão do Serviço.", vbExclamation)
        Else
            MsgBox("Serviço excluído com sucesso.", vbInformation)
            Me.ID = 0
        End If
    End Function

    Public Function Inicializa(Optional ByVal parCodigo As Long = 0, Optional ByVal parID As Long = 0) As Boolean
        Dim locID As Long
        Dim locConexao As New clsConexao
        Dim locSQLReader As SqlClient.SqlDataReader
        Dim locSQL As String
        Dim locRetorno As Boolean

        locRetorno = True
        If parID = 0 And parCodigo > 0 Then
            locID = clsRotinas.funRetornaID("SERVICOS", "CODIGO", CStr(parCodigo))
        ElseIf parID > 0 Then
            locID = parID
        End If

        Try
            locConexao.Conectar()

            locSQL = "SELECT ID, CODIGO, NOME, VALOR, DESCRICAO FROM SERVICOS WHERE ID = " & locID
            locSQLReader = locConexao.ExecuteQueryDataReader(locSQL)
            If locSQLReader.HasRows() Then
                While locSQLReader.Read()
                    Me.ID = locSQLReader.GetInt32(0)
                    Me.Codigo = locSQLReader.GetInt32(1)
                    Me.Nome = locSQLReader.GetString(2)
                    Me.Valor = locSQLReader.GetDouble(3)
                    If Me.Valor = 0 Then Me.Valor = ""
                    Me.Descricao = locSQLReader.GetString(4)
                End While
            Else
                locRetorno = False
            End If

            locConexao.Desconectar()

            Return locRetorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ConsultaF2() As clsRetornoConsultaDefault
        Dim locRetorno As clsRetornoConsultaDefault
        Dim locConsulta As New clsConsulaDefault

        Try

            locRetorno = locConsulta.ConsultaF2("SELECT CODIGO, NOME, VALOR, CAST(DESCRICAO as VARCHAR(50)) as DESCRICAO FROM SERVICOS", "Consulta Serviços")
        Catch ex As Exception
            Throw ex
        End Try

        Return locRetorno
    End Function


End Class
