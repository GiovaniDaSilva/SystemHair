Public Class clsConsulaDefault
    Private _glfSQL As String
    Private _titulo As String

    Private _dataSet As DataSet



    Public Property SQL As String
        Get
            Return _glfSQL
        End Get
        Set(parValor As String)
            _glfSQL = parValor
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(parValor As String)
            _titulo = parValor
        End Set

    End Property


    Public Property DataSet As DataSet
        Get
            Return _dataSet
        End Get
        Set(parValor As DataSet)
            _dataSet = parValor
        End Set

    End Property

    Public Function ConsultaF2(Optional ByVal parSQL As String = "", Optional ByVal parTitulo As String = "") As clsRetornoConsultaDefault
        Dim locFrmConsulta As frmConsultaDefault
        Dim locConexao As clsConexao
        Dim locDataSet As New DataSet
        Dim locRetorno As clsRetornoConsultaDefault

        Try
            If parTitulo = "" Then parTitulo = Titulo : Else Titulo = parTitulo
            If parSQL = "" Then parSQL = SQL : Else SQL = parSQL

            locConexao = New clsConexao()
            locFrmConsulta = New frmConsultaDefault()
            Me.DataSet = locConexao.ExecuteQueryDataSet(Me.SQL)
            locFrmConsulta.DataSet = Me.DataSet
            locFrmConsulta.Titulo = parTitulo
            locFrmConsulta.SQL = Me.SQL
            locRetorno = locFrmConsulta.funShowDialog()
        Catch ex As Exception
            Throw ex
        End Try

        Return locRetorno
    End Function

End Class
