<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroFornecedor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroFornecedor))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.btnPesquisarCodigo = New System.Windows.Forms.Button()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.Dados = New System.Windows.Forms.TabPage()
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
        Me.txtFoneCom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Observacoes = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnExcluiFornecedor = New System.Windows.Forms.Button()
        Me.lblNomeProduto = New System.Windows.Forms.Label()
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.dgProdutos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.Dados.SuspendLayout()
        Me.Observacoes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGravar, Me.btnExcluir, Me.btnLimpar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(679, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'btnPesquisarCodigo
        '
        Me.btnPesquisarCodigo.BackgroundImage = CType(resources.GetObject("btnPesquisarCodigo.BackgroundImage"), System.Drawing.Image)
        Me.btnPesquisarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisarCodigo.Location = New System.Drawing.Point(164, 42)
        Me.btnPesquisarCodigo.Name = "btnPesquisarCodigo"
        Me.btnPesquisarCodigo.Size = New System.Drawing.Size(27, 23)
        Me.btnPesquisarCodigo.TabIndex = 9
        Me.btnPesquisarCodigo.UseVisualStyleBackColor = True
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.Dados)
        Me.tabPrincipal.Controls.Add(Me.Observacoes)
        Me.tabPrincipal.Controls.Add(Me.TabPage1)
        Me.tabPrincipal.Location = New System.Drawing.Point(15, 85)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(651, 392)
        Me.tabPrincipal.TabIndex = 8
        '
        'Dados
        '
        Me.Dados.BackColor = System.Drawing.SystemColors.Control
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
        Me.Dados.Controls.Add(Me.txtFoneCom)
        Me.Dados.Controls.Add(Me.Label4)
        Me.Dados.Controls.Add(Me.txtNome)
        Me.Dados.Controls.Add(Me.Label2)
        Me.Dados.Location = New System.Drawing.Point(4, 22)
        Me.Dados.Name = "Dados"
        Me.Dados.Padding = New System.Windows.Forms.Padding(3)
        Me.Dados.Size = New System.Drawing.Size(643, 366)
        Me.Dados.TabIndex = 0
        Me.Dados.Text = "Dados"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(401, 160)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(228, 20)
        Me.txtCidade.TabIndex = 15
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
        Me.txtbairro.TabIndex = 13
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
        Me.txtEndereco.TabIndex = 11
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
        Me.txtEmail.TabIndex = 9
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
        Me.txtFoneCel.Location = New System.Drawing.Point(300, 53)
        Me.txtFoneCel.Name = "txtFoneCel"
        Me.txtFoneCel.Size = New System.Drawing.Size(114, 20)
        Me.txtFoneCel.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Celular:"
        '
        'txtFoneCom
        '
        Me.txtFoneCom.Location = New System.Drawing.Point(117, 53)
        Me.txtFoneCom.Name = "txtFoneCom"
        Me.txtFoneCom.Size = New System.Drawing.Size(114, 20)
        Me.txtFoneCom.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fone Comercial:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(117, 18)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(512, 20)
        Me.txtNome.TabIndex = 1
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
        Me.Observacoes.Size = New System.Drawing.Size(643, 366)
        Me.Observacoes.TabIndex = 1
        Me.Observacoes.Text = "Observações"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(265, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Informe as observações adicionais sobre o fornecedor:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(11, 31)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(618, 321)
        Me.txtObservacao.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnExcluiFornecedor)
        Me.TabPage1.Controls.Add(Me.lblNomeProduto)
        Me.TabPage1.Controls.Add(Me.btnProduto)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtProduto)
        Me.TabPage1.Controls.Add(Me.dgProdutos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(643, 366)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Produtos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnExcluiFornecedor
        '
        Me.btnExcluiFornecedor.BackgroundImage = CType(resources.GetObject("btnExcluiFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluiFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluiFornecedor.Location = New System.Drawing.Point(602, 11)
        Me.btnExcluiFornecedor.Name = "btnExcluiFornecedor"
        Me.btnExcluiFornecedor.Size = New System.Drawing.Size(25, 23)
        Me.btnExcluiFornecedor.TabIndex = 38
        Me.btnExcluiFornecedor.UseVisualStyleBackColor = True
        '
        'lblNomeProduto
        '
        Me.lblNomeProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeProduto.Location = New System.Drawing.Point(205, 13)
        Me.lblNomeProduto.Name = "lblNomeProduto"
        Me.lblNomeProduto.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.lblNomeProduto.Size = New System.Drawing.Size(385, 21)
        Me.lblNomeProduto.TabIndex = 37
        Me.lblNomeProduto.Text = "lblNomeProduto"
        '
        'btnProduto
        '
        Me.btnProduto.BackgroundImage = CType(resources.GetObject("btnProduto.BackgroundImage"), System.Drawing.Image)
        Me.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnProduto.Location = New System.Drawing.Point(175, 13)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(27, 23)
        Me.btnProduto.TabIndex = 36
        Me.btnProduto.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Código:"
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(69, 15)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtProduto.TabIndex = 34
        '
        'dgProdutos
        '
        Me.dgProdutos.AllowUserToAddRows = False
        Me.dgProdutos.AllowUserToDeleteRows = False
        Me.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProdutos.Location = New System.Drawing.Point(14, 40)
        Me.dgProdutos.Name = "dgProdutos"
        Me.dgProdutos.ReadOnly = True
        Me.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProdutos.Size = New System.Drawing.Size(614, 304)
        Me.dgProdutos.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(61, 44)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 6
        '
        'frmCadastroFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(679, 489)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnPesquisarCodigo)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastroFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fornecedor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tabPrincipal.ResumeLayout(False)
        Me.Dados.ResumeLayout(False)
        Me.Dados.PerformLayout()
        Me.Observacoes.ResumeLayout(False)
        Me.Observacoes.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGravar As ToolStripButton
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents btnLimpar As ToolStripButton
    Friend WithEvents btnPesquisarCodigo As Button
    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents Dados As TabPage
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
    Friend WithEvents txtFoneCom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Observacoes As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnProduto As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents dgProdutos As DataGridView
    Friend WithEvents lblNomeProduto As Label
    Friend WithEvents btnExcluiFornecedor As Button
End Class
