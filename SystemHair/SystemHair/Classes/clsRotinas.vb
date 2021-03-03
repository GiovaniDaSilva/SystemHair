

Imports System.Data.SqlClient

Public Class clsRotinas

    Public Const DATA_ZERO = "  /  /"
    Public Const VALOR_MAXIMO = 9999999999999

    Public Const TAMANHO_NOME = 100
    Public Const TAMANHO_FONE = 25

    Public Shared Function funCampoObrigatorio(ByVal parCampo As TextBox) As Boolean
        funCampoObrigatorio = True
        If Trim(parCampo.Text) = vbNullString Then
            MsgBox("Campo Obrigatório", vbExclamation)
            funCampoObrigatorio = False
        End If
    End Function


    Public Shared Function funRetornaProximoCodigo(ByVal parTabela As String, ByVal parCampo As String) As Long

        Dim locConexao As New clsConexao
        Dim locSQLReader As SqlClient.SqlDataReader
        Dim locSQL As String
        Dim locCodigo As Long

        locConexao.Conectar()
        locSQL = "Select Coalesce(Max(" & parCampo & "),0) as codigo from " & parTabela

        locSQLReader = locConexao.ExecuteQueryDataReader(locSQL)

        If locSQLReader.Read() Then
            locCodigo = locSQLReader.GetInt32(0) + 1
        End If
        locConexao.Desconectar()
        Return locCodigo

    End Function

    Public Shared Function funRetornaID(ByVal parTabela As String, ByVal parCampo As String, parValor As String) As Long

        Dim locConexao As New clsConexao
        Dim locSQLReader As SqlClient.SqlDataReader
        Dim locSQL As String
        Dim locCodigo As Long

        locConexao.Conectar()

        locSQL = "SELECT ID FROM " & parTabela & " WHERE " & parCampo & " = '" & parValor & "'"

        locSQLReader = locConexao.ExecuteQueryDataReader(locSQL)

        If locSQLReader.Read() Then
            locCodigo = locSQLReader.GetInt32(0)
        Else
            locCodigo = 0
        End If

        locConexao.Desconectar()

        Return locCodigo

    End Function

    Public Shared Function funEhDataZero(ParData As String) As Boolean
        If Format("dd/mm/yyyy", ParData) = "01/01/1900 00:00:00" Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Shared Sub TextBoxMoeda(ByRef txt As TextBox)

        Dim n As String = String.Empty

        Dim v As Double = 0

        Try

            n = txt.Text.Replace(",", "").Replace(".", "")

            If n.Equals("") Then n = "000"

            n = n.PadLeft(3, "0")

            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)

            v = Convert.ToDouble(n) / 100

            txt.Text = String.Format("{0:N2}", v)

            txt.SelectionStart = txt.Text.Length

        Catch ex As Exception

            MessageBox.Show(ex.Message, "TextBoxMoeda")

        End Try

    End Sub


    Public Shared Function funRetornaColuna(ByVal parTabela As String, ByVal parCampo As String, parValor As String, ByVal parCampoRetorno As String) As Object

        Dim locConexao As New clsConexao
        Dim locSQLReader As SqlClient.SqlDataReader
        Dim locSQL As String
        Dim locRetorno As Object

        locConexao.Conectar()

        locSQL = "SELECT " & parCampoRetorno & " FROM " & parTabela & " WHERE " & parCampo & " = '" & parValor & "'"

        locSQLReader = locConexao.ExecuteQueryDataReader(locSQL)

        If locSQLReader.Read() Then
            locRetorno = locSQLReader.GetValue(0)
        Else
            locRetorno = Nothing
        End If

        locConexao.Desconectar()

        Return locRetorno


    End Function

    Public Shared Function funValidaData(ByVal parData As String) As Boolean
        Dim locRetorno As Boolean

        locRetorno = True
        Try
            If Date.Compare(Format("dd/mm/yyyy", parData), CDate("01/01/1900")) < 0 Then
                locRetorno = False
                MsgBox("Data inválida.", vbExclamation)
            End If

        Catch ex As Exception
            locRetorno = False
            MsgBox("Data inválida.", vbExclamation)
        End Try

        Return locRetorno
    End Function

    Public Shared Function funValidaValor(ByVal parValor As String) As Boolean
        Dim locRetorno As Boolean

        locRetorno = True
        Try
            If CDbl(parValor) >= VALOR_MAXIMO Then
                MsgBox("Valor informado ultrapassa o valor máximo permitido.", vbExclamation)
                locRetorno = False
            End If

        Catch ex As Exception
            locRetorno = False
            MsgBox("Valor inválido.", vbExclamation)
        End Try

        Return locRetorno
    End Function


    Public Shared Function funSomenteCaracterNumerico(ByVal sender As Object, ByVal e As KeyPressEventArgs, Optional ByVal parEhValor As Boolean = False) As Boolean

        If Not parEhValor Then
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
                Return False
            End If
        Else
            If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = ",") Then
                Return False
            End If
        End If
        Return True
    End Function

    Public Shared Function funValidaTamanho(ByVal parCampo As String, ByVal parTamanho As Long) As Boolean
        If parCampo.Length >= parTamanho Then
            MsgBox("O Campo ultrapassa a quantidade de caracteres permitido. (" & parTamanho & ")", vbExclamation)
            Return False
        End If
        Return True
    End Function
End Class

