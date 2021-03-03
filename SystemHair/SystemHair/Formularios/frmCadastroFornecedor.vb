Public Class frmCadastroFornecedor
    Dim glfFornecedor As New clsFornecedor
    Dim glfProduto As New clsProduto

    Dim glfDataTableProduto As New DataTable()
    Dim glfRowNew As DataRow
    Dim glfDataSetProduto As New DataSet()

    Dim glfDataTableProdutoFornecedor As New DataTable()
    Dim glfDataSetProdutoFornecedor As New DataSet()


    Private Sub btnPesquisarCodigo_Click(sender As Object, e As EventArgs) Handles btnPesquisarCodigo.Click
        Dim locRetorno As clsRetornoConsultaDefault
        locRetorno = glfFornecedor.ConsultaF2()

        txtCodigo.Text = locRetorno.Codigo

        If txtCodigo.Text <> "0" Then
            CarregaFornecedor()
            txtCodigo.Enabled = False
        Else
            txtCodigo.Text = ""
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        End If
    End Sub



    Private Function CarregaFornecedor() As Boolean
        If glfFornecedor.Inicializa(CInt(txtCodigo.Text)) Then
            txtCodigo.Text = CStr(glfFornecedor.Codigo)
            txtNome.Text = glfFornecedor.Nome
            txtFoneCom.Text = glfFornecedor.FoneRes
            txtFoneCel.Text = glfFornecedor.FoneCel
            txtEmail.Text = glfFornecedor.Email
            txtEndereco.Text = glfFornecedor.Endereco
            txtCidade.Text = glfFornecedor.Cidade
            txtbairro.Text = glfFornecedor.Bairro
            txtObservacao.Text = glfFornecedor.Observacao


            CarregaProdutoFornecedor()

            Return True
        Else
            Return False
        End If
    End Function


    Private Sub CarregaProdutoFornecedor()
        Dim locConexao As New clsConexao
        Dim locDataSet As DataSet

        locDataSet = locConexao.ExecuteQueryDataSet("SELECT FK_PRODUTO FROM PRODUTO_FORNECEDOR WHERE FK_FORNECEDOR = " & glfFornecedor.ID)

        For i As Integer = 0 To locDataSet.Tables(0).Rows.Count - 1

            glfRowNew = glfDataSetProduto.Tables(0).NewRow
            glfRowNew("Codigo") = clsRotinas.funRetornaColuna("PRODUTO", "ID", locDataSet.Tables(0).Rows(i)("FK_Produto"), "Codigo")
            glfRowNew("Nome") = clsRotinas.funRetornaColuna("PRODUTO", "ID", locDataSet.Tables(0).Rows(i)("FK_Produto"), "Nome")
            glfDataSetProduto.Tables(0).Rows.Add(glfRowNew)

        Next

        glfDataSetProduto.AcceptChanges()
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text <> vbNullString Then
            If CarregaFornecedor() Then
                txtCodigo.Enabled = False
            Else
                MsgBox("Fornecedor não cadastrado.", vbExclamation)
                txtCodigo.Clear()
                txtCodigo.Focus()
            End If

        Else
            txtCodigo.Enabled = False
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        subGrava()
    End Sub

    Private Sub subGrava()
        Dim locProdutoFornecedor As New clsProdutoFornecedor

        If Not funValidaCamposTela() Then Exit Sub
        subALimentaDadosFornecedor()
        If glfFornecedor.Grava() Then

            subALimentaDadosProdutoFornecedor()

            locProdutoFornecedor.FK_Fornecedor = glfFornecedor.ID
            locProdutoFornecedor.DataSet = glfDataSetProdutoFornecedor
            locProdutoFornecedor.ExcluiFornecedor()

            If locProdutoFornecedor.Grava() Then
                subLimpaFormulario()
            End If

        End If

    End Sub

    Private Sub subALimentaDadosProdutoFornecedor()

        For i As Integer = 0 To glfDataSetProduto.Tables(0).Rows.Count - 1
            glfRowNew = glfDataSetProdutoFornecedor.Tables(0).NewRow
            glfRowNew("FK_FORNECEDOR") = glfFornecedor.ID
            glfRowNew("FK_PRODUTO") = clsRotinas.funRetornaID("PRODUTO", "CODIGO", glfDataSetProduto.Tables(0).Rows(i)("Codigo"))
            glfDataSetProdutoFornecedor.Tables(0).Rows.Add(glfRowNew)
        Next

    End Sub

    Private Sub subExclui()
        If Not glfFornecedor.Exclui() Then
            Exit Sub
        End If
        subLimpaFormulario()
    End Sub

    Private Sub subLimpaFormulario()
        txtNome.Clear()
        txtCodigo.Clear()
        txtFoneCel.Clear()
        txtFoneCom.Clear()
        txtEmail.Clear()
        txtEndereco.Clear()
        txtbairro.Clear()
        txtCidade.Clear()
        txtObservacao.Clear()
        txtCodigo.Enabled = True


        glfProduto.ID = 0
        glfFornecedor.ID = 0

        glfDataSetProduto.Clear()
        glfDataSetProdutoFornecedor.Clear()

        tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(0)

        txtCodigo.Focus()
    End Sub

    Private Sub subALimentaDadosFornecedor()
        glfFornecedor.Codigo = CInt(IIf(txtCodigo.Text = vbNullString, 0, txtCodigo.Text))
        glfFornecedor.Nome = txtNome.Text
        glfFornecedor.FoneRes = txtFoneCom.Text
        glfFornecedor.FoneCel = txtFoneCel.Text
        glfFornecedor.Email = txtEmail.Text
        glfFornecedor.Endereco = txtEndereco.Text
        glfFornecedor.Cidade = txtCidade.Text
        glfFornecedor.Bairro = txtbairro.Text
        glfFornecedor.Observacao = txtObservacao.Text
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        subExclui()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        subLimpaFormulario()
    End Sub

    Private Function funValidaCamposTela() As Boolean

        Dim locRetorno As Boolean

        locRetorno = True

        If Trim(txtNome.Text) = vbNullString Then
            If Not clsRotinas.funCampoObrigatorio(txtNome) Then
                locRetorno = False
                txtNome.Focus()
                GoTo Finaliza
            End If
        End If

        If Not clsRotinas.funValidaTamanho(txtNome.Text, clsRotinas.TAMANHO_NOME) Then
            locRetorno = False
            txtNome.Focus()
            GoTo Finaliza
        End If


        If Not clsRotinas.funValidaTamanho(txtFoneCel.Text, clsRotinas.TAMANHO_FONE) Then
            locRetorno = False
            txtFoneCel.Focus()
            GoTo Finaliza
        End If

        If Not clsRotinas.funValidaTamanho(txtFoneCom.Text, clsRotinas.TAMANHO_FONE) Then
            locRetorno = False
            txtFoneCom.Focus()
            GoTo Finaliza
        End If

Finaliza:
        Return locRetorno
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProduto.Click

        Dim locRetorno As clsRetornoConsultaDefault

        locRetorno = glfProduto.ConsultaF2()
        txtProduto.Text = locRetorno.Codigo
        lblNomeProduto.Text = locRetorno.Nome

        txtProduto.Focus()
    End Sub

    Private Sub frmCadastroFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        glfDataSetProduto.Tables.Add(glfDataTableProduto)
        glfDataSetProduto.Tables(0).Columns.Add("Codigo", GetType(Long))
        glfDataSetProduto.Tables(0).Columns(0).AutoIncrementSeed = 1
        glfDataSetProduto.Tables(0).Columns(0).Unique = True
        glfDataSetProduto.Tables(0).Columns.Add("Nome", GetType(String))
        dgProdutos.DataSource = glfDataSetProduto.Tables(0)
        dgProdutos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lblNomeProduto.Text = ""

        glfDataSetProdutoFornecedor.Tables.Add(glfDataTableProdutoFornecedor)
        glfDataSetProdutoFornecedor.Tables(0).Columns.Add("FK_PRODUTO", GetType(Long))
        glfDataSetProdutoFornecedor.Tables(0).Columns.Add("FK_FORNECEDOR", GetType(Long))

    End Sub

    Private Sub txtProduto_Leave(sender As Object, e As EventArgs) Handles txtProduto.Leave

        If Val(txtProduto.Text) = 0 Then
            txtProduto.Text = ""
        End If
        If txtProduto.Text = vbNullString Then Exit Sub


        If CarregaProduto() Then

            If funProdutoJaInformado(Val(txtProduto.Text)) Then
                MsgBox("O Produto já foi informado.", vbExclamation)
                txtProduto.Focus()
                Exit Sub '
            End If

            glfRowNew = glfDataSetProduto.Tables(0).NewRow
            glfRowNew("Codigo") = txtProduto.Text
            glfRowNew("Nome") = lblNomeProduto.Text
            glfDataSetProduto.Tables(0).Rows.Add(glfRowNew)
            glfDataSetProduto.AcceptChanges()

            txtProduto.Clear()
            lblNomeProduto.Text = vbNullString
        Else
            MsgBox("Produto não cadastrado.", vbExclamation)
            txtProduto.Clear()
            txtProduto.Focus()
        End If
    End Sub


    Private Function CarregaProduto() As Boolean
        If glfProduto.Inicializa(CInt(txtProduto.Text)) Then
            txtProduto.Text = CStr(glfProduto.Codigo)
            lblNomeProduto.Text = glfProduto.Nome
            Return True
        Else
            Return False
        End If
    End Function

    Private Function funProdutoJaInformado(ByVal parCodigo As Long) As Boolean
        Dim locRetorno As Boolean
        Dim locFiltro As String
        Dim foundRows() As Data.DataRow

        locRetorno = False

        If dgProdutos.Rows.Count > 0 Then
            locFiltro = "Codigo = '" & parCodigo & "'"
            foundRows = glfDataSetProduto.Tables(0).Select(locFiltro)

            If foundRows.Count >= 1 Then
                locRetorno = True
            End If
        End If

        Return locRetorno
    End Function

    Private Sub btnExcluiFornecedor_Click(sender As Object, e As EventArgs) Handles btnExcluiFornecedor.Click
        Dim rowSelected() As DataRow
        rowSelected = glfDataSetProduto.Tables(0).Select("Codigo = '" & Long.Parse(dgProdutos.CurrentRow.Cells("Codigo").Value.ToString()) & "'")
        glfDataSetProduto.Tables(0).Rows().Remove(rowSelected(0))
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProduto.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCidade_Leave(sender As Object, e As EventArgs) Handles txtCidade.Leave
        If txtCodigo.Enabled = False Then
            tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(1)
            txtObservacao.Focus()
        End If
    End Sub

    Private Sub txtObservacao_Leave(sender As Object, e As EventArgs) Handles txtObservacao.Leave
        If txtCodigo.Enabled = False Then
            tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(2)
            txtProduto.Focus()
        End If
    End Sub
End Class