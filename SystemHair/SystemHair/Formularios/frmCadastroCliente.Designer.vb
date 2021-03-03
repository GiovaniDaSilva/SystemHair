<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroCliente))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.Dados = New System.Windows.Forms.TabPage()
        Me.txtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFoneCel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFoneRes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Observacoes = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.btnPesquisarCodigo = New System.Windows.Forms.Button()
        Me.tsBotoes = New System.Windows.Forms.ToolStrip()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.tabPrincipal.SuspendLayout()
        Me.Dados.SuspendLayout()
        Me.Observacoes.SuspendLayout()
        Me.tsBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(61, 42)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.Dados)
        Me.tabPrincipal.Controls.Add(Me.Observacoes)
        Me.tabPrincipal.Location = New System.Drawing.Point(12, 87)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(651, 357)
        Me.tabPrincipal.TabIndex = 4
        '
        'Dados
        '
        Me.Dados.BackColor = System.Drawing.SystemColors.Control
        Me.Dados.Controls.Add(Me.txtDataNascimento)
        Me.Dados.Controls.Add(Me.txtCidade)
        Me.Dados.Controls.Add(Me.Label9)
        Me.Dados.Controls.Add(Me.txtbairro)
        Me.Dados.Controls.Add(Me.Label8)
        Me.Dados.Controls.Add(Me.txtEndereco)
        Me.Dados.Controls.Add(Me.Label7)
        Me.Dados.Controls.Add(Me.txtEmail)
        Me.Dados.Controls.Add(Me.Label6)
        Me.Dados.Controls.Add(Me.txtFoneCel)
        Me.Dados.Controls.Add(Me.Label5)
        Me.Dados.Controls.Add(Me.txtFoneRes)
        Me.Dados.Controls.Add(Me.Label4)
        Me.Dados.Controls.Add(Me.Label3)
        Me.Dados.Controls.Add(Me.txtNome)
        Me.Dados.Controls.Add(Me.Label2)
        Me.Dados.Location = New System.Drawing.Point(4, 22)
        Me.Dados.Name = "Dados"
        Me.Dados.Padding = New System.Windows.Forms.Padding(3)
        Me.Dados.Size = New System.Drawing.Size(643, 331)
        Me.Dados.TabIndex = 0
        Me.Dados.Text = "Dados"
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Location = New System.Drawing.Point(119, 52)
        Me.txtDataNascimento.Mask = "00/00/0000"
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(109, 20)
        Me.txtDataNascimento.TabIndex = 3
        Me.txtDataNascimento.ValidatingType = GetType(Date)
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(401, 160)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(228, 20)
        Me.txtCidade.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Cidade:"
        '
        'txtbairro
        '
        Me.txtbairro.Location = New System.Drawing.Point(117, 160)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(228, 20)
        Me.txtbairro.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Bairro:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(117, 124)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(512, 20)
        Me.txtEndereco.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Endereço:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 88)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(512, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "E-mail:"
        '
        'txtFoneCel
        '
        Me.txtFoneCel.Location = New System.Drawing.Point(515, 52)
        Me.txtFoneCel.Name = "txtFoneCel"
        Me.txtFoneCel.Size = New System.Drawing.Size(114, 20)
        Me.txtFoneCel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(467, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Celular:"
        '
        'txtFoneRes
        '
        Me.txtFoneRes.Location = New System.Drawing.Point(332, 52)
        Me.txtFoneRes.Name = "txtFoneRes"
        Me.txtFoneRes.Size = New System.Drawing.Size(114, 20)
        Me.txtFoneRes.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fone Residêncial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de Nascimento:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(117, 18)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(512, 20)
        Me.txtNome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome:"
        '
        'Observacoes
        '
        Me.Observacoes.BackColor = System.Drawing.SystemColors.Control
        Me.Observacoes.Controls.Add(Me.Label10)
        Me.Observacoes.Controls.Add(Me.txtObservacao)
        Me.Observacoes.Location = New System.Drawing.Point(4, 22)
        Me.Observacoes.Name = "Observacoes"
        Me.Observacoes.Padding = New System.Windows.Forms.Padding(3)
        Me.Observacoes.Size = New System.Drawing.Size(643, 331)
        Me.Observacoes.TabIndex = 1
        Me.Observacoes.Text = "Observações"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(245, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Informe as observações adicionais sobre o cliente:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(3, 30)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(637, 298)
        Me.txtObservacao.TabIndex = 10
        '
        'btnPesquisarCodigo
        '
        Me.btnPesquisarCodigo.BackgroundImage = CType(resources.GetObject("btnPesquisarCodigo.BackgroundImage"), System.Drawing.Image)
        Me.btnPesquisarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisarCodigo.Location = New System.Drawing.Point(164, 40)
        Me.btnPesquisarCodigo.Name = "btnPesquisarCodigo"
        Me.btnPesquisarCodigo.Size = New System.Drawing.Size(27, 23)
        Me.btnPesquisarCodigo.TabIndex = 2
        Me.btnPesquisarCodigo.TabStop = False
        Me.btnPesquisarCodigo.UseVisualStyleBackColor = True
        '
        'tsBotoes
        '
        Me.tsBotoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGravar, Me.btnExcluir, Me.btnLimpar})
        Me.tsBotoes.Location = New System.Drawing.Point(0, 0)
        Me.tsBotoes.Name = "tsBotoes"
        Me.tsBotoes.Size = New System.Drawing.Size(675, 25)
        Me.tsBotoes.TabIndex = 11
        Me.tsBotoes.Text = "ToolStrip1"
        '
        'btnGravar
        '
        Me.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(23, 22)
        Me.btnGravar.Text = "Gravar"
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(23, 22)
        Me.btnExcluir.Text = "Excluir"
        '
        'btnLimpar
        '
        Me.btnLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(23, 22)
        Me.btnLimpar.Text = "Limpar"
        '
        'frmCadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(675, 456)
        Me.Controls.Add(Me.tsBotoes)
        Me.Controls.Add(Me.btnPesquisarCodigo)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente"
        Me.tabPrincipal.ResumeLayout(False)
        Me.Dados.ResumeLayout(False)
        Me.Dados.PerformLayout()
        Me.Observacoes.ResumeLayout(False)
        Me.Observacoes.PerformLayout()
        Me.tsBotoes.ResumeLayout(False)
        Me.tsBotoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents Dados As TabPage
    Friend WithEvents Observacoes As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbairro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFoneCel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFoneRes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnPesquisarCodigo As Button
    Friend WithEvents tsBotoes As ToolStrip
    Friend WithEvents btnGravar As ToolStripButton
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents btnLimpar As ToolStripButton
    Friend WithEvents txtDataNascimento As MaskedTextBox
End Class
