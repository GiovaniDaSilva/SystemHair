Public Class frmPrincipal
    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCadastroCliente_Click(sender As Object, e As EventArgs) Handles btnCadastroCliente.Click
        subChamaTelaCadastroCliente()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        subChamaTelaCadastroCliente()
    End Sub

    Private Sub subChamaTelaCadastroCliente()
        Dim frmCadastroCliente As New frmCadastroCliente()

        frmCadastroCliente.MdiParent = Me
            frmCadastroCliente.Show()

    End Sub

    Private Sub subChamaTelaCadastroServico()
        Dim frmCadastroServico As New frmCadastroServico()
        frmCadastroServico.MdiParent = Me
        frmCadastroServico.Show()
    End Sub

    Private Sub btnCadastroServico_Click(sender As Object, e As EventArgs) Handles btnCadastroServico.Click
        subChamaTelaCadastroServico()
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem.Click
        subChamaTelaCadastroServico()
    End Sub

    Private Sub subChamaTelaHistoricoCliente()
        Dim frmHistoricoCliente As New frmHistoricoCliente()
        frmHistoricoCliente.MdiParent = Me
        frmHistoricoCliente.Show()
    End Sub

    Private Sub subChamaTelaCadastroProduto()
        Dim frmCadastroProduto As New frmCadastroProduto
        frmCadastroProduto.mdiParent = Me
        frmCadastroProduto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        subChamaTelaHistoricoCliente()
    End Sub

    Private Sub HistóricoDeAgendamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoDeAgendamentosToolStripMenuItem.Click
        subChamaTelaHistoricoCliente()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCadastroProduto.Click
        subChamaTelaCadastroProduto()
    End Sub

    Private Sub btnFornecedor_Click(sender As Object, e As EventArgs) Handles btnFornecedor.Click
        subChamaTelaCadastroFornecedor()
    End Sub

    Private Sub subChamaTelaCadastroFornecedor()
        Dim frmCadastroFornecedor As New frmCadastroFornecedor
        frmCadastroFornecedor.MdiParent = Me
        frmCadastroFornecedor.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        subChamaTelaCadastroFornecedor()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        subChamaTelaCadastroProduto()
    End Sub

    Private Sub OcultarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcultarMenuToolStripMenuItem.Click
        pngMenu.Visible = Not pngMenu.Visible

        If pngMenu.Visible Then
            OcultarMenuToolStripMenuItem.Text = ">> Ocultar Menu"
        Else
            OcultarMenuToolStripMenuItem.Text = ">> Exibir Menu"
        End If
    End Sub
End Class
