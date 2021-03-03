Public Class frmCadastroCliente
    Private glfCliente As New clsCliente

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        subLimpaFormulario()
    End Sub

    Private Sub subLimpaFormulario()
        txtNome.Clear()
        txtCodigo.Clear()
        txtDataNascimento.Clear()
        txtFoneCel.Clear()
        txtFoneRes.Clear()
        txtEmail.Clear()
        txtEndereco.Clear()
        txtbairro.Clear()
        txtCidade.Clear()
        txtObservacao.Clear()
        txtCodigo.Enabled = True

        glfCliente.ID = 0

        tabPrincipal.SelectTab(0)
        txtCodigo.Focus()
    End Sub



    Private Sub subGrava()
        If Not funValidaCamposTela() Then Exit Sub
        subALimentaDadosCLiente()
        If glfCliente.Grava() Then
            subLimpaFormulario()
        End If

    End Sub

    Private Sub subExclui()
        If Not glfCliente.Exclui() Then
            Exit Sub
        End If
        subLimpaFormulario()
    End Sub

    Private Sub subALimentaDadosCLiente()
        glfCliente.Codigo = CInt(IIf(txtCodigo.Text = vbNullString, 0, txtCodigo.Text))
        glfCliente.Nome = txtNome.Text
        glfCliente.DataNasc = txtDataNascimento.Text
        glfCliente.FoneRes = txtFoneRes.Text
        glfCliente.FoneCel = txtFoneCel.Text
        glfCliente.Email = txtEmail.Text
        glfCliente.Endereco = txtEndereco.Text
        glfCliente.Cidade = txtCidade.Text
        glfCliente.Bairro = txtbairro.Text
        glfCliente.Observacao = txtObservacao.Text
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        subGrava()
        tabPrincipal.SelectTab(0)
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text <> vbNullString Then
            If CarregaCliente() Then
                txtCodigo.Enabled = False
            Else
                MsgBox("Cliente não cadastrado.", vbExclamation)
                txtCodigo.Clear()
                txtCodigo.Focus()
            End If

        Else
            txtCodigo.Enabled = False
        End If
    End Sub


    Private Function CarregaCliente() As Boolean

        If glfCliente.Inicializa(CInt(txtCodigo.Text)) Then
            txtCodigo.Text = CStr(glfCliente.Codigo)
            txtNome.Text = glfCliente.Nome
            txtDataNascimento.Text = glfCliente.DataNasc
            txtFoneRes.Text = glfCliente.FoneRes
            txtFoneCel.Text = glfCliente.FoneCel
            txtEmail.Text = glfCliente.Email
            txtEndereco.Text = glfCliente.Endereco
            txtCidade.Text = glfCliente.Cidade
            txtbairro.Text = glfCliente.Bairro
            txtObservacao.Text = glfCliente.Observacao

            tabPrincipal.SelectTab(0)

            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtCidade_Leave(sender As Object, e As EventArgs) Handles txtCidade.Leave
        tabPrincipal.SelectedTab = tabPrincipal.TabPages.Item(1)
        txtObservacao.Focus()
    End Sub

    Private Sub txtObservacao_Leave(sender As Object, e As EventArgs) Handles txtObservacao.Leave
        tsBotoes.Focus()
    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        subExclui()
    End Sub

    Private Sub btnPesquisarCodigo_Click(sender As Object, e As EventArgs) Handles btnPesquisarCodigo.Click
        Dim locRetorno As clsRetornoConsultaDefault
        locRetorno = glfCliente.ConsultaF2()

        txtCodigo.Text = locRetorno.Codigo

        If txtCodigo.Text <> "0" Then
            CarregaCliente()
            txtCodigo.Enabled = False
        Else
            txtCodigo.Enabled = True
            txtCodigo.Text = ""
            txtCodigo.Focus()
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e) Then
            e.Handled = True
        End If
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


        If txtDataNascimento.Text <> clsRotinas.DATA_ZERO Then
            If Not clsRotinas.funValidaData(txtDataNascimento.Text) Then
                locRetorno = False
                txtDataNascimento.Focus()
                GoTo Finaliza
            End If
        End If


        If Not clsRotinas.funValidaTamanho(txtFoneCel.Text, clsRotinas.TAMANHO_FONE) Then
            locRetorno = False
            txtFoneCel.Focus()
            GoTo Finaliza
        End If

        If Not clsRotinas.funValidaTamanho(txtFoneRes.Text, clsRotinas.TAMANHO_FONE) Then
            locRetorno = False
            txtFoneRes.Focus()
            GoTo Finaliza
        End If
Finaliza:
        Return locRetorno
    End Function


End Class