<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.pngMenu = New System.Windows.Forms.Panel()
        Me.btnFornecedor = New System.Windows.Forms.Button()
        Me.btnCadastroProduto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCadastroServico = New System.Windows.Forms.Button()
        Me.btnCadastroCliente = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoDeAgendamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pngMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pngMenu
        '
        Me.pngMenu.Controls.Add(Me.btnFornecedor)
        Me.pngMenu.Controls.Add(Me.btnCadastroProduto)
        Me.pngMenu.Controls.Add(Me.Button1)
        Me.pngMenu.Controls.Add(Me.btnCadastroServico)
        Me.pngMenu.Controls.Add(Me.btnCadastroCliente)
        Me.pngMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pngMenu.Location = New System.Drawing.Point(0, 24)
        Me.pngMenu.Name = "pngMenu"
        Me.pngMenu.Size = New System.Drawing.Size(854, 92)
        Me.pngMenu.TabIndex = 1
        '
        'btnFornecedor
        '
        Me.btnFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFornecedor.BackgroundImage = CType(resources.GetObject("btnFornecedor.BackgroundImage"), System.Drawing.Image)
        Me.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFornecedor.Location = New System.Drawing.Point(467, 0)
        Me.btnFornecedor.Name = "btnFornecedor"
        Me.btnFornecedor.Size = New System.Drawing.Size(110, 90)
        Me.btnFornecedor.TabIndex = 5
        Me.btnFornecedor.TabStop = False
        Me.btnFornecedor.UseVisualStyleBackColor = False
        '
        'btnCadastroProduto
        '
        Me.btnCadastroProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadastroProduto.BackgroundImage = CType(resources.GetObject("btnCadastroProduto.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastroProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCadastroProduto.Location = New System.Drawing.Point(351, 0)
        Me.btnCadastroProduto.Name = "btnCadastroProduto"
        Me.btnCadastroProduto.Size = New System.Drawing.Size(110, 90)
        Me.btnCadastroProduto.TabIndex = 4
        Me.btnCadastroProduto.TabStop = False
        Me.btnCadastroProduto.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(119, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 90)
        Me.Button1.TabIndex = 3
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCadastroServico
        '
        Me.btnCadastroServico.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadastroServico.BackgroundImage = CType(resources.GetObject("btnCadastroServico.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastroServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCadastroServico.Location = New System.Drawing.Point(235, 0)
        Me.btnCadastroServico.Name = "btnCadastroServico"
        Me.btnCadastroServico.Size = New System.Drawing.Size(110, 90)
        Me.btnCadastroServico.TabIndex = 2
        Me.btnCadastroServico.TabStop = False
        Me.btnCadastroServico.UseVisualStyleBackColor = False
        '
        'btnCadastroCliente
        '
        Me.btnCadastroCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadastroCliente.BackgroundImage = CType(resources.GetObject("btnCadastroCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCadastroCliente.Location = New System.Drawing.Point(3, 0)
        Me.btnCadastroCliente.Name = "btnCadastroCliente"
        Me.btnCadastroCliente.Size = New System.Drawing.Size(110, 90)
        Me.btnCadastroCliente.TabIndex = 0
        Me.btnCadastroCliente.TabStop = False
        Me.btnCadastroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCadastroCliente.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.SuporteToolStripMenuItem, Me.OcultarMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.CadastroToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.FornecedoresToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistóricoDeAgendamentosToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'HistóricoDeAgendamentosToolStripMenuItem
        '
        Me.HistóricoDeAgendamentosToolStripMenuItem.Name = "HistóricoDeAgendamentosToolStripMenuItem"
        Me.HistóricoDeAgendamentosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.HistóricoDeAgendamentosToolStripMenuItem.Text = "Histórico Clientes"
        '
        'SuporteToolStripMenuItem
        '
        Me.SuporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContatoToolStripMenuItem})
        Me.SuporteToolStripMenuItem.Name = "SuporteToolStripMenuItem"
        Me.SuporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SuporteToolStripMenuItem.Text = "Suporte"
        '
        'ContatoToolStripMenuItem
        '
        Me.ContatoToolStripMenuItem.Name = "ContatoToolStripMenuItem"
        Me.ContatoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ContatoToolStripMenuItem.Text = "Contato"
        '
        'OcultarMenuToolStripMenuItem
        '
        Me.OcultarMenuToolStripMenuItem.Name = "OcultarMenuToolStripMenuItem"
        Me.OcultarMenuToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.OcultarMenuToolStripMenuItem.Text = ">> Ocultar Menu"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(854, 621)
        Me.Controls.Add(Me.pngMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " System Hair - Versão 0.1 - BETA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pngMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pngMenu As Panel
    Friend WithEvents btnCadastroServico As Button
    Friend WithEvents btnCadastroCliente As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoDeAgendamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCadastroProduto As Button
    Friend WithEvents btnFornecedor As Button
    Friend WithEvents OcultarMenuToolStripMenuItem As ToolStripMenuItem
End Class
