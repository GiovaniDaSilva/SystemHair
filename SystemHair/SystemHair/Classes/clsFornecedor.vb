Public Class clsFornecedor
    Private _ID As Integer
    Private _Codigo As Integer
    Private _Nome As String
    Private _FoneRes As String
    Private _FoneCel As String
    Private _Email As String
    Private _Endereco As String
    Private _Bairro As String
    Private _Cidade As String
    Private _Observacao As String



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
    Public Property FoneRes As String
        Get
            Return _FoneRes
        End Get
        Set(value As String)
            _FoneRes = value
        End Set
    End Property

    Public Property FoneCel As String
        Get
            Return _FoneCel
        End Get
        Set(value As String)
            _FoneCel = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Endereco As String
        Get
            Return _Endereco
        End Get
        Set(value As String)
            _Endereco = value
        End Set
    End Property

    Public Property Bairro As String
        Get
            Return _Bairro
        End Get
        Set(value As String)
            _Bairro = value
        End Set
    End Property

    Public Property Cidade As String
        Get
            Return _Cidade
        End Get
        Set(value As String)
            _Cidade = value
        End Set
    End Property

    Public Property Observacao As String
        Get
            Return _Observacao
        End Get
        Set(value As String)
            _Observacao = value
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
                locSQL = locSQL & vbCr & " INSERT INTO FORNECEDOR (CODIGO,"
                locSQL = locSQL & vbCr & "                      NOME,"
                locSQL = locSQL & vbCr & "                      FONE_COM,"
                locSQL = locSQL & vbCr & "                      FONE_CEL,"
                locSQL = locSQL & vbCr & "                      EMAIL,"
                locSQL = locSQL & vbCr & "                      ENDERECO,"
                locSQL = locSQL & vbCr & "                      BAIRRO,"
                locSQL = locSQL & vbCr & "                      CIDADE,"
                locSQL = locSQL & vbCr & "                      OBSERVACAO)"
                locSQL = locSQL & vbCr & "  VALUES("

                locCodigo = funRetornaProximoCodigo("FORNECEDOR", "CODIGO")

                locSQL = locSQL & vbCr & locCodigo
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Nome, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.FoneRes, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.FoneCel, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Email, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Endereco, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Bairro, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Cidade, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Observacao, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "     )"
            Else
                locSQL = locSQL & vbCr & "UPDATE FORNECEDOR SET"
                locSQL = locSQL & vbCr & "   NOME = " & funAjustaCampoSQL(Me.Nome, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,FONE_COM = " & funAjustaCampoSQL(Me.FoneRes, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,FONE_CEL = " & funAjustaCampoSQL(Me.FoneCel, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,EMAIL = " & funAjustaCampoSQL(Me.Email, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,ENDERECO = " & funAjustaCampoSQL(Me.Endereco, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,BAIRRO = " & funAjustaCampoSQL(Me.Bairro, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,CIDADE = " & funAjustaCampoSQL(Me.Cidade, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,OBSERVACAO = " & funAjustaCampoSQL(Me.Observacao, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  WHERE ID = " & ID
            End If

            If Not locConexao.Execute(locSQL) Then
                MsgBox("Falha na gravação do Fornecedor.", vbExclamation)
            Else
                If Me.ID = 0 Then
                    MsgBox("Fornecedor gravado com sucesso. Código: " & locCodigo, vbInformation)
                    Me.ID = clsRotinas.funRetornaColuna("FORNECEDOR", "CODIGO", locCodigo, "ID")
                Else
                    MsgBox("Fornecedor gravado com sucesso.", vbInformation)
                End If
            End If


        Catch ex As Exception
            MsgBox("Falha na gravação do Fornecedor." & vbNewLine & ex.Message, vbExclamation)
        End Try

    End Function

    Private Function funRetornaProximoCodigo(v1 As String, v2 As String) As Long
        Return clsRotinas.funRetornaProximoCodigo(v1, v2)
    End Function



    Public Function Exclui() As Boolean
        Dim locSQL As String
        Dim locConexao As New clsConexao
        Dim locProdutoFornecedor As New clsProdutoFornecedor

        Exclui = True
        If ID = 0 Then Exit Function

        locProdutoFornecedor.FK_Fornecedor = Me.ID
        locProdutoFornecedor.ExcluiFornecedor()

        locSQL = "DELETE FROM FORNECEDOR WHERE ID = " & ID

        If Not locConexao.Execute(locSQL) Then
            MsgBox("Falha na exclusão do Fornecedor.", vbExclamation)
        Else
            MsgBox("Fornecedor excluído com sucesso.", vbInformation)
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
            locID = clsRotinas.funRetornaID("FORNECEDOR", "CODIGO", CStr(parCodigo))
        ElseIf parID > 0 Then
            locID = parID
        End If

        Try
            locConexao.Conectar()

            locSQL = "SELECT ID, CODIGO,NOME , FONE_COM , FONE_CEL, EMAIL , ENDERECO , BAIRRO, "
            locSQL = locSQL & vbCr & "CIDADE, OBSERVACAO FROM FORNECEDOR WHERE ID = " & locID

            locSQLReader = locConexao.ExecuteQueryDataReader(locSQL)
            If locSQLReader.HasRows() Then
                While locSQLReader.Read()
                    Me.ID = locSQLReader.GetInt32(0)
                    Me.Codigo = locSQLReader.GetInt32(1)
                    Me.Nome = locSQLReader.GetString(2)
                    Me.FoneRes = locSQLReader.GetString(3)
                    Me.FoneCel = locSQLReader.GetString(4)
                    Me.Email = locSQLReader.GetString(5)
                    Me.Endereco = locSQLReader.GetString(6)
                    Me.Bairro = locSQLReader.GetString(7)
                    Me.Cidade = locSQLReader.GetString(8)
                    Me.Observacao = locSQLReader.GetString(9)
                End While
            Else
                locRetorno = False
            End If

            locConexao.Desconectar()

            Return locRetorno
        Catch ex As Exception
            locConexao.Desconectar()
            Throw ex
        End Try
    End Function


    Public Function ConsultaF2() As clsRetornoConsultaDefault
        Dim locRetorno As clsRetornoConsultaDefault
        Dim locConsulta As New clsConsulaDefault

        Try
            locRetorno = locConsulta.ConsultaF2("Select CODIGO, NOME, FONE_COM, FONE_CEL from FORNECEDOR", "Consulta Fornecedor")
        Catch ex As Exception
            Throw ex
        End Try

        Return locRetorno
    End Function
End Class
