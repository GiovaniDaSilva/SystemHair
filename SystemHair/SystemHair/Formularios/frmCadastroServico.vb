Public Class frmCadastroServico
    Dim glfServico As New clsServicos

    Private Sub btnPesquisarCodigo_Click(sender As Object, e As EventArgs) Handles btnPesquisarCodigo.Click
        Dim locRetorno As clsRetornoConsultaDefault
        locRetorno = glfServico.ConsultaF2()
        txtCodigo.Text = locRetorno.Codigo

        If txtCodigo.Text <> "0" Then
            CarregaServico()
            txtCodigo.Enabled = False
        Else
            txtCodigo.Text = ""
            txtCodigo.Enabled = True
            txtCodigo.Focus()
        End If
    End Sub

    Private Function CarregaServico() As Boolean

        If glfServico.Inicializa(CInt(txtCodigo.Text)) Then
            txtCodigo.Text = CStr(glfServico.Codigo)
            txtNome.Text = glfServico.Nome
            txtValor.Text = glfServico.Valor
            If txtValor.Text <> vbNullString Then txtValor.Text = Format(Convert.ToDouble(glfServico.Valor), "#,##0.00")
            txtDescricao.Text = glfServico.Descricao
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text <> vbNullString Then
            If CarregaServico() Then
                txtCodigo.Enabled = False
            Else
                MsgBox("Serviço não cadastrado.", vbExclamation)
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

        glfServico.ID = 0
        txtCodigo.Focus()
    End Sub

    Private Sub subGrava()
        subALimentaDadosProduto()
        If Not subValidaCamposTela() Then Exit Sub
        If glfServico.Grava() Then
            subLimpaFormulario()
        End If
    End Sub

    Private Sub subExclui()
        If Not glfServico.Exclui() Then
            Exit Sub
        End If
        subLimpaFormulario()
    End Sub


    Private Sub subALimentaDadosProduto()
        glfServico.Codigo = CInt(IIf(txtCodigo.Text = vbNullString, 0, txtCodigo.Text))
        glfServico.Nome = txtNome.Text
        glfServico.Valor = txtValor.Text
        glfServico.Descricao = txtDescricao.Text
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        subExclui()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        subGrava()
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
                txtValor.Focus()
                GoTo Finaliza
            End If
        End If
Finaliza:
        Return locRetorno
    End Function

    Private Sub txtDescricao_Leave(sender As Object, e As EventArgs) Handles txtDescricao.Leave
        barraBotoes.Focus()
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Not clsRotinas.funSomenteCaracterNumerico(sender, e, True) Then
            e.Handled = True
        End If
    End Sub

End Class