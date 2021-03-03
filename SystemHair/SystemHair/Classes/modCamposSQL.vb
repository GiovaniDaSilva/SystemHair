Module modCamposSQL
    Public Enum enumTipoDados
        TP_STRING = 1
        TP_DOUBLE = 2
    End Enum


    Private Function funRemoveAspas(ByVal parValor As String) As String
        Return parValor.Replace("'", "")
    End Function


    Private Function funAJustaString(ByVal parValor As String) As String
        Dim locRetorno

        locRetorno = parValor
        locRetorno = funRemoveAspas(locRetorno)


        locRetorno = "'" + locRetorno + "'"
        Return locRetorno
    End Function

    Private Function funAJustaDouble(ByVal parvalor As Object) As String
        Dim locRetorno As String
        locRetorno = parvalor.ToString().Replace(".", "")
        locRetorno = locRetorno.ToString().Replace(",", ".")
        If locRetorno = vbNullString Then locRetorno = "0"
        Return locRetorno
    End Function

    Public Function funAjustaCampoSQL(ByVal parValor As Object, ByVal parTipo As enumTipoDados) As Object
        Dim locRetorno As Object

        Select Case parTipo
            Case enumTipoDados.TP_STRING
                locRetorno = funAJustaString(parValor)
            Case enumTipoDados.TP_DOUBLE
                locRetorno = funAJustaDouble(parValor)
            Case Else
                locRetorno = 0
        End Select

        Return locRetorno
    End Function

End Module
