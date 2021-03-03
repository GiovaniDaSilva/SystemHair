Public Class frmCadastroProduto
    Dim glfProduto As New clsProduto
    Dim glfFornecedor As New clsFornecedor

    Dim glfDataTableFornecedor As New DataTable()
    Dim glfRowNew As DataRow
    Dim glfDataSetFornecedor As New DataSet()

    Dim glfDataTableProdutoFornecedor As New DataTable()
    Dim glfDataSetProdutoFornecedor As New DataSet()


    Private Sub btnPesquisarCodigo_Click(sender As Object, e As EventArgs) Handles btnPesquisarCodigo.Click
        Dim locRetorno As clsRetornoConsultaDefault
        locRetorno = glfProduto.ConsultaF2()

        txtCodigo.Text = locRetorno.Codigo

        If txtCodigo.Text <> "0" Then
            CarregaProduto()
            txtCodigo.Enabled = False
        Else
            txtCodigo.Text = ""
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        End If

    End Sub

    Private Function CarregaProduto() As Boolean

        If glfProduto.Inicializa(CInt(txtCodigo.Text)) Then
            txtCodigo.Text = CStr(glfProduto.Codigo)
            txtNome.Text = glfProduto.Nome
            txtValor.Text = glfProduto.Valor
            If txtValor.Text <> vbNullString Then txtValor.Text = Format(Convert.ToDouble(glfProduto.Valor), "#,##0.00")
            txtDescricao.Text = glfProduto.Descricao

            CarregaProdutoFornecedor()

            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text <> vbNullString Then
            If CarregaProduto() Then
                txtCodigo.Enabled = False
            Else
                MsgBox("Produto não cadastrado.", vbExclamation)
                txtCodigo.Clear()
                txtCodigo.Focus()
            End If

        Else
            txtCodigo.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        subLimpaFormulario()
    End Sub

    Private Sub subLimpaFormulario()
        txtNome.Clear()
        txtCodigo.Clear()
        txtValor.Clear()
        txtDescricao.Clear()
        txtCodigo.Enabled = True

        glfProduto.ID = 0
        glfFornecedor.ID = 0

        glfDataSetFornecedor.Clear()
        glfDataSetProdutoFornecedor.Clear()
        tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(0)
        txtCodigo.Focus()
    End Sub

    Private Sub subGrava()
        Dim locProdutoFornecedor As New clsProdutoFornecedor

        subALimentaDadosProduto()

        If Not subValidaCamposTela() Then Exit Sub
        If glfProduto.Grava() Then

            subALimentaDadosProdutoFornecedor()

            locProdutoFornecedor.FK_Produto = glfProduto.ID
            locProdutoFornecedor.DataSet = glfDataSetProdutoFornecedor
            locProdutoFornecedor.ExcluiProduto()

            If locProdutoFornecedor.Grava() Then
                subLimpaFormulario()
            End If

        End If

    End Sub

    Private Sub subExclui()

        If Not glfProduto.Exclui() Then
            Exit Sub
        End If

        subLimpaFormulario()
    End Sub


    Private Sub subALimentaDadosProduto()
        glfProduto.Codigo = CInt(IIf(txtCodigo.Text = vbNullString, 0, txtCodigo.Text))
        glfProduto.Nome = txtNome.Text
        glfProduto.Valor = txtValor.Text
        glfProduto.Descricao = txtDescricao.Text
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        subExclui()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        subGrava()
    End Sub

    Private Sub txtDescricao_Leave(sender As Object, e As EventArgs) Handles txtDescricao.Leave
        If txtCodigo.Enabled = False Then
            tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(1)
            txtFornecedor.Focus()
        End If
    End Sub


    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        Try
            If txtValor.Text <> vbNullString Then
                txtValor.Text = Format(Convert.ToDouble(txtValor.Text), "#,##0.00")
            End If
        Catch ex As Exception
            MsgBox("Valor Inválido.", vbExclamation)
            txtValor.Focus()
        End Try
    End Sub

    Private Function subValidaCamposTela() As Boolean

        Dim locRetorno As Boolean

        locRetorno = True

        If Trim(txtNome.Text) = vbNullString Then
            If Not clsRotinas.funCampoObrigatorio(txtNome) Then
                locRetorno = False
                tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(0)
                txtNome.Focus()
                GoTo Finaliza
            End If
        End If

        If Not clsRotinas.funValidaTamanho(txtNome.Text, clsRotinas.TAMANHO_NOME) Then
            locRetorno = False
            txtNome.Focus()
            GoTo Finaliza
        End If


        If Trim(txtValor.Text) <> vbNullString Then
            If Not clsRotinas.funValidaValor(txtValor.Text) Then
                locRetorno = False
                tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(0)
                txtValor.Focus()
                GoTo Finaliza
            End If
        End If
Finaliza:
        Return locRetorno
    End Function

    Private Sub btnFornecedor_Click(sender As Object, e As EventArgs) Handles btnFornecedor.Click
        Dim locRetorno As clsRetornoConsultaDefault

        locRetorno = glfFornecedor.ConsultaF2()
        txtFornecedor.Text = locRetorno.Codigo
        lblNomeFornecedor.Text = locRetorno.Nome

        txtFornecedor.Focus()
    End Sub

    Private Sub frmCadastroProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glfDataSetFornecedor.Tables.Add(glfDataTableFornecedor)
        glfDataSetFornecedor.Tables(0).Columns.Add("Codigo", GetType(Long))
        glfDataSetFornecedor.Tables(0).Columns(0).AutoIncrementSeed = 1
        glfDataSetFornecedor.Tables(0).Columns(0).Unique = True
        glfDataSetFornecedor.Tables(0).Columns.Add("Nome", GetType(String))
        dgFornecedor.DataSource = glfDataSetFornecedor.Tables(0)
        dgFornecedor.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lblNomeFornecedor.Text = ""


        glfDataSetProdutoFornecedor.Tables.Add(glfDataTableProdutoFornecedor)
        glfDataSetProdutoFornecedor.Tables(0).Columns.Add("FK_PRODUTO", GetType(Long))
        glfDataSetProdutoFornecedor.Tables(0).Columns.Add("FK_FORNECEDOR", GetType(Long))
    End Sub

    Private Sub txtFornecedor_Leave(sender As Object, e As EventArgs) Handles txtFornecedor.Leave

        If Val(txtFornecedor.Text) = 0 Then
            txtFornecedor.Text = ""
        End If
        If txtFornecedor.Text = vbNullString Then Exit Sub


        If CarregaFornecedor() Then

            If funFornecedorJaInformado(Val(txtFornecedor.Text)) Then
                MsgBox("O fornecedor já foi informado.", vbExclamation)
                txtFornecedor.Focus()
                Exit Sub '
            End If

            glfRowNew = glfDataSetFornecedor.Tables(0).NewRow
            glfRowNew("Codigo") = txtFornecedor.Text
            glfRowNew("Nome") = lblNomeFornecedor.Text
            glfDataSetFornecedor.Tables(0).Rows.Add(glfRowNew)
            glfDataSetFornecedor.AcceptChanges()

            txtFornecedor.Clear()
            lblNomeFornecedor.Text = vbNullString
        Else
            MsgBox("Fornecedor não cadastrado.", vbExclamation)
            txtFornecedor.Clear()
            txtFornecedor.Focus()
        End If

    End Sub


    Private Function funFornecedorJaInformado(ByVal parCodigo As Long) As Boolean
        Dim locRetorno As Boolean
        Dim locFiltro As String
        Dim foundRows() As Data.DataRow

        locRetorno = False

        If dgFornecedor.Rows.Count > 0 Then
            locFiltro = "Codigo = '" & parCodigo & "'"
            foundRows = glfDataSetFornecedor.Tables(0).Select(locFiltro)

            If foundRows.Count >= 1 Then
                locRetorno = True
            End If
        End If

        Return locRetorno
    End Function

    Private Function CarregaFornecedor() As Boolean
        If glfFornecedor.Inicializa(CInt(txtFornecedor.Text)) Then
            txtFornecedor.Text = CStr(glfFornecedor.Codigo)
            lblNomeFornecedor.Text = glfFornecedor.Nome
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcluiFornecedor.Click
        Dim rowSelected() As DataRow
        rowSelected = glfDataSetFornecedor.Tables(0).Select("Codigo = '" & Long.Parse(dgFornecedor.CurrentRow.Cells("Codigo").Value.ToString()) & "'")
        glfDataSetFornecedor.Tables(0).Rows().Remove(rowSelected(0))
    End Sub


    Private Sub subALimentaDadosProdutoFornecedor()

        For i As Integer = 0 To glfDataSetFornecedor.Tables(0).Rows.Count - 1
            glfRowNew = glfDataSetProdutoFornecedor.Tables(0).NewRow
            glfRowNew("FK_FORNECEDOR") = clsRotinas.funRetornaID("FORNECEDOR", "CODIGO", glfDataSetFornecedor.Tables(0).Rows(i)("Codigo"))
            glfRowNew("FK_PRODUTO") = glfProduto.ID
            glfDataSetProdutoFornecedor.Tables(0).Rows.Add(glfRowNew)
        Next

    End Sub


    Private Sub CarregaProdutoFornecedor()
        Dim locConexao As New clsConexao
        Dim locDataSet As DataSet

        locDataSet = locConexao.ExecuteQueryDataSet("SELECT FK_FORNECEDOR FROM PRODUTO_FORNECEDOR WHERE FK_PRODUTO = " & glfProduto.ID)

        For i As Integer = 0 To locDataSet.Tables(0).Rows.Count - 1

            glfRowNew = glfDataSetFornecedor.Tables(0).NewRow
            glfRowNew("Codigo") = clsRotinas.funRetornaColuna("FORNECEDOR", "ID", locDataSet.Tables(0).Rows(i)("FK_Fornecedor"), "Codigo")
            glfRowNew("Nome") = clsRotinas.funRetornaColuna("FORNECEDOR", "ID", locDataSet.Tables(0).Rows(i)("FK_Fornecedor"), "Nome")
            glfDataSetFornecedor.Tables(0).Rows.Add(glfRowNew)

        Next

        glfDataSetFornecedor.AcceptChanges()
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e, True) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFornecedor.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e) Then
            e.Handled = True
        End If
    End Sub
End Class

