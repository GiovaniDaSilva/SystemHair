Public Class frmHistoricoCliente
    Dim glfCliente As New clsCliente

    Private Sub btnPesquisarCodigo_Click(sender As Object, e As EventArgs) Handles btnPesquisarCodigo.Click
        Dim locRetorno As clsRetornoConsultaDefault
        locRetorno = glfCliente.ConsultaF2()

        txtCodigo.Text = locRetorno.Codigo
        lblNomeCLiente.Text = locRetorno.Nome

        If txtCodigo.Text <> vbNullString Then
            subCarregaCliente()
            txtCodigo.Enabled = False
        Else
            txtCodigo.Enabled = False
        End If
    End Sub


    Private Sub subCarregaCliente()

    End Sub

    Private Sub frmHistoricoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNomeCLiente.Text = ""
    End Sub
End Class