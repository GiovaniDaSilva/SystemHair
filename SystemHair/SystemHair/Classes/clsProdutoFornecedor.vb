Public Class clsProdutoFornecedor
    Private _ID As Integer
    Private _FK_Produto As Integer
    Private _FK_Fornecedor As Integer
    Private _dataSet As DataSet


    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property



    Public Property FK_Fornecedor As Integer
        Get
            Return _FK_Fornecedor
        End Get
        Set(value As Integer)
            _FK_Fornecedor = value
        End Set
    End Property



    Public Property FK_Produto As Integer
        Get
            Return _FK_Produto
        End Get
        Set(value As Integer)
            _FK_Produto = value
        End Set
    End Property


    Public Property DataSet As DataSet
        Get
            Return _dataSet
        End Get
        Set(value As DataSet)
            _dataSet = value
        End Set
    End Property

    Public Function Grava() As Boolean

        Dim locConexao As New clsConexao
        Dim locSQL As String

        Try
            Grava = True
            locSQL = vbNullString


            For i As Integer = 0 To DataSet.Tables(0).Rows.Count - 1
                Me.FK_Fornecedor = DataSet.Tables(0).Rows(i)("FK_Fornecedor")
                Me.FK_Produto = DataSet.Tables(0).Rows(i)("FK_Produto")

                locSQL = vbNullString
                locSQL = locSQL & vbCr & " INSERT INTO PRODUTO_FORNECEDOR (FK_PRODUTO,"
                locSQL = locSQL & vbCr & "                      FK_FORNECEDOR)"
                locSQL = locSQL & vbCr & "  VALUES("
                locSQL = locSQL & vbCr & "  " & funAjustaCampoSQL(Me.FK_Produto, enumTipoDados.TP_DOUBLE)
                locSQL = locSQL & vbCr & ", " & funAjustaCampoSQL(Me._FK_Fornecedor, enumTipoDados.TP_DOUBLE)
                locSQL = locSQL & vbCr & "     )"
                If Not locConexao.Execute(locSQL) Then
                    Grava = False
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function ExcluiProduto() As Boolean
        Dim locSQL As String
        Dim locConexao As New clsConexao
        Dim locRetorno As Boolean


        locRetorno = True

        Try
            locSQL = "DELETE FROM PRODUTO_FORNECEDOR WHERE FK_PRODUTO = " & Me.FK_Produto
            If Not locConexao.Execute(locSQL) Then
                locRetorno = False
            End If

        Catch ex As Exception
            Throw ex
        End Try


        Return locRetorno
    End Function


    Public Function ExcluiFornecedor() As Boolean
        Dim locSQL As String
        Dim locConexao As New clsConexao
        Dim locRetorno As Boolean


        locRetorno = True

        Try
            locSQL = "DELETE FROM PRODUTO_FORNECEDOR WHERE FK_FORNECEDOR = " & Me.FK_Fornecedor
            If Not locConexao.Execute(locSQL) Then
                locRetorno = False
            End If

        Catch ex As Exception
            Throw ex
        End Try


        Return locRetorno
    End Function
End Class
