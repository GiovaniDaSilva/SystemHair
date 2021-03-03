<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroProduto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.tabPrincipal = New System.Windows.Forms.TabControl()
        Me.Produto = New System.Windows.Forms.TabPage()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Fornecedores = New System.Windows.Forms.TabPage()
        Me.btnExcluiFornecedor = New System.Windows.Forms.Button()
        Me.lblNomeFornecedor = New System.Windows.Forms.Label()
        Me.btnFornecedor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.dgFornecedor = New System.Windows.Forms.DataGridView()
        Me.btnPesquisarCodigo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        Me.Produto.SuspendLayout()
        Me.Fornecedores.SuspendLayout()
        CType(Me.dgFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGravar, Me.btnExcluir, Me.btnLimpar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(658, 25)
        Me.ToolStrip1.TabIndex = 14
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
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.Produto)
        Me.tabPrincipal.Controls.Add(Me.Fornecedores)
        Me.tabPrincipal.Location = New System.Drawing.Point(12, 60)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedIndex = 0
        Me.tabPrincipal.Size = New System.Drawing.Size(634, 386)
        Me.tabPrincipal.TabIndex = 15
        '
        'Produto
        '
        Me.Produto.Controls.Add(Me.txtValor)
        Me.Produto.Controls.Add(Me.Label4)
        Me.Produto.Controls.Add(Me.txtDescricao)
        Me.Produto.Controls.Add(Me.Label3)
        Me.Produto.Controls.Add(Me.Label2)
        Me.Produto.Controls.Add(Me.txtNome)
        Me.Produto.Location = New System.Drawing.Point(4, 22)
        Me.Produto.Name = "Produto"
        Me.Produto.Padding = New System.Windows.Forms.Padding(3)
        Me.Produto.Size = New System.Drawing.Size(626, 360)
        Me.Produto.TabIndex = 0
        Me.Produto.Text = "Produto"
        Me.Produto.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(71, 54)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 20)
        Me.txtValor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Valor:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(71, 90)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(533, 252)
        Me.txtDescricao.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Descrição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(71, 17)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(533, 20)
        Me.txtNome.TabIndex = 2
        '
        'Fornecedores
        '
        Me.Fornecedores.Controls.Add(Me.btnExcluiFornecedor)
        Me.Fornecedores.Controls.Add(Me.lblNomeFornecedor)
        Me.Fornecedores.Controls.Add(Me.btnFornecedor)
        Me.Fornecedores.Controls.Add(Me.Label5)
        Me.Fornecedores.Controls.Add(Me.txtFornecedor)
        Me.Fornecedores.Controls.Add(Me.dgFornecedor)
        Me.Fornecedores.Location = New System.Drawing.Point(4, 22)
        Me.Fornecedores.Name = "Fornecedores"
        Me.Fornecedores.Padding = New System.Windows.Forms.Padding(3)
        Me.Fornecedores.Size = New System.Drawing.Size(626, 360)
        Me.Fornecedores.TabIndex = 1
        Me.Fornecedores.Text = "Fornecedores"
        Me.Fornecedores.UseVisualStyleBackColor = True
        '
        'btnExcluiFornecedor
        '
        Me.btnExcluiFornecedor.BackgroundImage = CType(resources.GetObject("btnExcluiFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluiFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluiFornecedor.Location = New System.Drawing.Point(595, 12)
        Me.btnExcluiFornecedor.Name = "btnExcluiFornecedor"
        Me.btnExcluiFornecedor.Size = New System.Drawing.Size(25, 23)
        Me.btnExcluiFornecedor.TabIndex = 34
        Me.btnExcluiFornecedor.UseVisualStyleBackColor = True
        '
        'lblNomeFornecedor
        '
        Me.lblNomeFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeFornecedor.Location = New System.Drawing.Point(195, 9)
        Me.lblNomeFornecedor.Name = "lblNomeFornecedor"
        Me.lblNomeFornecedor.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.lblNomeFornecedor.Size = New System.Drawing.Size(394, 21)
        Me.lblNomeFornecedor.TabIndex = 33
        Me.lblNomeFornecedor.Text = "lblNomeFornecedor"
        '
        'btnFornecedor
        '
        Me.btnFornecedor.BackgroundImage = CType(resources.GetObject("btnFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFornecedor.Location = New System.Drawing.Point(162, 7)
        Me.btnFornecedor.Name = "btnFornecedor"
        Me.btnFornecedor.Size = New System.Drawing.Size(27, 23)
        Me.btnFornecedor.TabIndex = 32
        Me.btnFornecedor.TabStop = False
        Me.btnFornecedor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Código:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(59, 9)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(100, 20)
        Me.txtFornecedor.TabIndex = 5
        '
        'dgFornecedor
        '
        Me.dgFornecedor.AllowUserToAddRows = False
        Me.dgFornecedor.AllowUserToDeleteRows = False
        Me.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFornecedor.Location = New System.Drawing.Point(6, 41)
        Me.dgFornecedor.MultiSelect = False
        Me.dgFornecedor.Name = "dgFornecedor"
        Me.dgFornecedor.ReadOnly = True
        Me.dgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFornecedor.Size = New System.Drawing.Size(614, 313)
        Me.dgFornecedor.TabIndex = 6
        '
        'btnPesquisarCodigo
        '
        Me.btnPesquisarCodigo.BackgroundImage = CType(resources.GetObject("btnPesquisarCodigo.BackgroundImage"), System.Drawing.Image)
        Me.btnPesquisarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisarCodigo.Location = New System.Drawing.Point(178, 31)
        Me.btnPesquisarCodigo.Name = "btnPesquisarCodigo"
        Me.btnPesquisarCodigo.Size = New System.Drawing.Size(27, 23)
        Me.btnPesquisarCodigo.TabIndex = 29
        Me.btnPesquisarCodigo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(75, 33)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'frmCadastroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(658, 458)
        Me.Controls.Add(Me.btnPesquisarCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastroProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tabPrincipal.ResumeLayout(False)
        Me.Produto.ResumeLayout(False)
        Me.Produto.PerformLayout()
        Me.Fornecedores.ResumeLayout(False)
        Me.Fornecedores.PerformLayout()
        CType(Me.dgFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGravar As ToolStripButton
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents btnLimpar As ToolStripButton
    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents Produto As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Fornecedores As TabPage
    Friend WithEvents btnPesquisarCodigo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnFornecedor As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFornecedor As TextBox
    Friend WithEvents dgFornecedor As DataGridView
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblNomeFornecedor As Label
    Friend WithEvents btnExcluiFornecedor As Button
End Class
