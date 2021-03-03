Public Class clsCliente
    Private _ID As Integer
    Private _Codigo As Integer
    Private _Nome As String
    Private _DataNasc As String
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

    Public Property DataNasc As String
        Get
            Return _DataNasc
        End Get
        Set(value As String)
            _DataNasc = value
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

    Public Property Nome As String
        Get
            Return _Nome
        End Get
        Set(value As String)
            _Nome = value
        End Set
    End Property

    Public Function Grava() As Boolean

        Dim locConexao As New clsConexao
        Dim locSQL As String
        Dim locCodigo As Long

        Dim locData As String

        Try



            locCodigo = 0
            Grava = True
            locSQL = vbNullString


            If Me.DataNasc = clsRotinas.DATA_ZERO Then
                locData = vbNullString
            Else
                locData = CDate(Me.DataNasc).ToString("dd/MM/yyyy")
            End If

            If ID = 0 Then
                locSQL = locSQL & vbCr & " INSERT INTO CLIENTE (CODIGO,"
                locSQL = locSQL & vbCr & "                      NOME,"
                locSQL = locSQL & vbCr & "                      DATA_NASC,"
                locSQL = locSQL & vbCr & "                      FONE_RES,"
                locSQL = locSQL & vbCr & "                      FONE_CEL,"
                locSQL = locSQL & vbCr & "                      EMAIL,"
                locSQL = locSQL & vbCr & "                      ENDERECO,"
                locSQL = locSQL & vbCr & "                      BAIRRO,"
                locSQL = locSQL & vbCr & "                      CIDADE,"
                locSQL = locSQL & vbCr & "                      OBSERVACAO)"
                locSQL = locSQL & vbCr & "  VALUES("

                locCodigo = funRetornaProximoCodigo("CLIENTE", "CODIGO")

                locSQL = locSQL & vbCr & locCodigo
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Nome, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", '" & locData & "'"
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.FoneRes, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.FoneCel, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Email, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Endereco, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Bairro, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Cidade, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me.Observacao, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "     )"
            Else
                locSQL = locSQL & vbCr & "UPDATE CLIENTE SET"
                locSQL = locSQL & vbCr & "   NOME = " & funAjustaCampoSQL(Me.Nome, enumTipoDados.TP_STRING)

                locSQL = locSQL & vbCr & "  ,DATA_NASC = '" & locData & "'"


                locSQL = locSQL & vbCr & "  ,FONE_RES = " & funAjustaCampoSQL(Me.FoneRes, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,FONE_CEL = " & funAjustaCampoSQL(Me.FoneCel, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,EMAIL = " & funAjustaCampoSQL(Me.Email, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,ENDERECO = " & funAjustaCampoSQL(Me.Endereco, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,BAIRRO = " & funAjustaCampoSQL(Me.Bairro, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,CIDADE = " & funAjustaCampoSQL(Me.Cidade, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  ,OBSERVACAO = " & funAjustaCampoSQL(Me.Observacao, enumTipoDados.TP_STRING)
                locSQL = locSQL & vbCr & "  WHERE ID = " & ID
            End If

            If Not locConexao.Execute(locSQL) Then
                MsgBox("Falha na gravação do cliente.", vbExclamation)
            Else
                If Me.ID = 0 Then
                    MsgBox("Cliente gravado com sucesso. Código: " & locCodigo, vbInformation)
                Else
                    MsgBox("Cliente gravado com sucesso.", vbInformation)
                End If
            End If



        Catch ex As Exception
            MsgBox("Falha na gravação do cliente." & vbNewLine & ex.Message, vbExclamation)
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
            MsgBox("Nenhum cliente selecionado.", vbExclamation)
            Exit Function
        End If


        locSQL = "DELETE FROM CLIENTE WHERE ID = " & ID

        If Not locConexao.Execute(locSQL) Then
            MsgBox("Falha na exclusão do cliente.", vbExclamation)
        Else
            MsgBox("Cliente excluído com sucesso.", vbInformation)
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
            locID = clsRotinas.funRetornaID("CLIENTE", "CODIGO", CStr(parCodigo))
        ElseIf parID > 0 Then
            locID = parID
        End If

        Try
            locConexao.Conectar()

            locSQL = "SELECT ID, CODIGO,NOME,DATA_NASC , FONE_RES , FONE_CEL, EMAIL , ENDERECO , BAIRRO, "
            locSQL = locSQL & vbCr & "CIDADE, OBSERVACAO FROM CLIENTE WHERE ID = " & locID

            locSQLReader = locConexao.ExecuteQueryDataReader(locSQL)
            If locSQLReader.HasRows() Then
                While locSQLReader.Read()
                    Me.ID = locSQLReader.GetInt32(0)
                    Me.Codigo = locSQLReader.GetInt32(1)
                    Me.Nome = locSQLReader.GetString(2)
                    Me.DataNasc = locSQLReader.GetDateTime(3).ToString()

                    If clsRotinas.funEhDataZero(Me.DataNasc) Then
                        Me.DataNasc = ""
                    End If

                    Me.FoneRes = locSQLReader.GetString(4)
                    Me.FoneCel = locSQLReader.GetString(5)
                    Me.Email = locSQLReader.GetString(6)
                    Me.Endereco = locSQLReader.GetString(7)
                    Me.Bairro = locSQLReader.GetString(8)
                    Me.Cidade = locSQLReader.GetString(9)
                    Me.Observacao = locSQLReader.GetString(10)
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

        Dim locConsulta As New clsConsulaDefault
        Dim locRetorno As clsRetornoConsultaDefault

        Try
            locRetorno = locConsulta.ConsultaF2("Select Codigo, Nome, Fone_Res, Fone_cel from Cliente", "Consulta Cliente")
        Catch ex As Exception
            Throw ex
        End Try

        Return locRetorno
    End Function

End Class
