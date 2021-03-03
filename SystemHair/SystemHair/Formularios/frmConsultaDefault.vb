Public Class frmConsultaDefault


    Private _glfDataSet As DataSet
    Private _titulo As String
    Private _ColunaRetorno As String
    Private _sql As String

    Private glfDataSet As DataSet
    Dim BindingSource As New BindingSource
    Dim glfTipoCampo As Type

    Dim glfRetorno As New clsRetornoConsultaDefault

    Public Property DataSet As DataSet
        Get
            Return _glfDataSet
        End Get
        Set(parValor As DataSet)
            _glfDataSet = parValor
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

    Public Property ColunaRetorno As String
        Get
            Return _ColunaRetorno
        End Get
        Set(parValor As String)
            _ColunaRetorno = parValor
        End Set

    End Property

    Public Property SQL As String
        Get
            Return _sql
        End Get
        Set(parValor As String)
            _sql = parValor
        End Set

    End Property

    Private Sub frmConsultaDefault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subCarregaConsulta()
    End Sub

    Private Sub subCarregaConsulta()
        Dim i As Integer

        Try
            glfDataSet = DataSet
            BindingSource.RemoveFilter()
            BindingSource.DataSource = glfDataSet.Tables(0)
            gdvConsulta.DataSource = BindingSource.DataSource


            'Faz com que a ultima coluna ocupe o restante do espaço
            For i = 0 To gdvConsulta.ColumnCount - 1
                If i = gdvConsulta.ColumnCount - 1 Then
                    gdvConsulta.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Else
                    gdvConsulta.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
            Next

            cboCampo.Items.Clear()
            For i = 0 To glfDataSet.Tables(0).Columns.Count - 1
                cboCampo.Items.Add(glfDataSet.Tables(0).Columns(i).ColumnName.ToString)
            Next i
            Me.gdvConsulta.AutoGenerateColumns = True

            Me.gdvConsulta.ScrollBars = ScrollBars.Both


            Me.Text = Titulo
        Catch ex As Exception
            MsgBox("Falha na consulta dos dados." & vbNewLine & ex.Message)
        End Try

    End Sub

    Private Sub cboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCampo.SelectedIndexChanged
        Dim ds As New DataSet

        glfTipoCampo = Me.gdvConsulta.Columns(cboCampo.SelectedIndex).ValueType

        If glfTipoCampo.ToString = "System.Int32" Then
            cboParametro.Items.Clear()
            cboParametro.Items.Add("=")
            cboParametro.Items.Add(">")
            cboParametro.Items.Add(">=")
            cboParametro.Items.Add("<")
            cboParametro.Items.Add("<=")
            cboParametro.Items.Add("<>")
        End If

        If glfTipoCampo.ToString = "System.String" Then
            cboParametro.Items.Clear()
            cboParametro.Items.Add("=")
            cboParametro.Items.Add("Começa com")
            cboParametro.Items.Add("Termina em")
            cboParametro.Items.Add("Contém")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress

        If glfTipoCampo.ToString <> "System.String" Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If

    End Sub


    Public Function pesquisa(ByVal Campo As String, ByVal Parametro As String, ByVal Valor As String, ByVal tipo As String) As Boolean
        Dim locRetorno As Boolean
        Dim locDataSet As New DataSet
        locRetorno = False

        Try
            locDataSet = glfDataSet
            BindingSource.DataSource = locDataSet.Tables(0)
            BindingSource.Filter = Campo & " " & Parametro & " " & Valor
            Me.gdvConsulta.DataSource = BindingSource

        Catch ex As Exception
            Throw ex
        End Try
        locRetorno = True

        Return locRetorno
    End Function

    Private Sub cboParametro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboParametro.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCampo.KeyPress
        e.Handled = True
    End Sub

    Public Function funShowDialog() As clsRetornoConsultaDefault

        Me.ShowDialog()

        Return glfRetorno
    End Function

    Private Sub gdvConsulta_DoubleClick(sender As Object, e As EventArgs) Handles gdvConsulta.DoubleClick

        glfRetorno.Codigo = Long.Parse(gdvConsulta.CurrentRow.Cells("Codigo").Value.ToString())
        glfRetorno.Nome = gdvConsulta.CurrentRow.Cells("Nome").Value.ToString()

        Me.Close()

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        If funValidaFiltro() Then
            subFiltra()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        sunLimpaFiltro()
        subCarregaConsulta()
    End Sub


    Private Sub subFiltra()
        Dim campo As String = cboCampo.Text
        Dim parametro As String = cboParametro.Text
        Dim valor As String = txtValor.Text
        Dim ds As New DataSet

        Try
            If glfTipoCampo.ToString = "System.String" Then
                If parametro = "Contém" Then
                    parametro = "Like"
                    valor = "'%" & valor & "%'"
                End If
                If parametro = "=" Then
                    valor = "'" & valor & "'"
                End If
                If parametro = "Começa com" Then
                    parametro = "Like "
                    valor = "'" & valor & "%'"
                End If
                If parametro = "Termina em" Then
                    parametro = "Like "
                    valor = "'%" & valor & "'"
                End If
            End If

            pesquisa(campo, parametro, valor, glfTipoCampo.ToString)

        Catch ex As Exception
            MsgBox("Falha na execução do filtro." & vbNewLine & ex.Message, vbExclamation)
        End Try


    End Sub

    Private Function funValidaFiltro() As Boolean
        Dim locRetorno As Boolean

        locRetorno = True

        If cboCampo.SelectedIndex = -1 Then
            locRetorno = False
            MsgBox("Informe o campo a ser filtrado.", vbExclamation)
            cboCampo.Focus()
            GoTo Finaliza '
        End If

        If cboParametro.SelectedIndex = -1 Then
            locRetorno = False
            MsgBox("Informe o parâmetro de filtro.", vbExclamation)
            cboParametro.Focus()
            GoTo Finaliza '
        End If

        If Trim(txtValor.Text) = vbNullString Then
            locRetorno = False
            MsgBox("Informe o valor a ser filtrado.", vbExclamation)
            txtValor.Focus()
            GoTo Finaliza '
        End If

Finaliza:
        Return locRetorno
    End Function

    Private Sub sunLimpaFiltro()
        cboParametro.ResetText()
        cboCampo.ResetText()
        txtValor.Clear()
    End Sub
End Class
