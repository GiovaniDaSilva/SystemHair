<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDefault
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaDefault))
        Me.gbCriterio = New System.Windows.Forms.GroupBox()
        Me.txtValor = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboParametro = New System.Windows.Forms.ComboBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.gdvConsulta = New System.Windows.Forms.DataGridView()
        Me.tsBotoes = New System.Windows.Forms.ToolStrip()
        Me.btnPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.gbCriterio.SuspendLayout()
        Me.gbResultado.SuspendLayout()
        CType(Me.gdvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCriterio
        '
        Me.gbCriterio.Controls.Add(Me.txtValor)
        Me.gbCriterio.Controls.Add(Me.Label3)
        Me.gbCriterio.Controls.Add(Me.Label2)
        Me.gbCriterio.Controls.Add(Me.Label1)
        Me.gbCriterio.Controls.Add(Me.cboParametro)
        Me.gbCriterio.Controls.Add(Me.cboCampo)
        Me.gbCriterio.Location = New System.Drawing.Point(15, 28)
        Me.gbCriterio.Name = "gbCriterio"
        Me.gbCriterio.Size = New System.Drawing.Size(552, 62)
        Me.gbCriterio.TabIndex = 3
        Me.gbCriterio.TabStop = False
        Me.gbCriterio.Text = "Filtros"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(345, 34)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValor.Size = New System.Drawing.Size(196, 20)
        Me.txtValor.TabIndex = 7
        Me.txtValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Parâmetro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Campo"
        '
        'cboParametro
        '
        Me.cboParametro.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboParametro.FormattingEnabled = True
        Me.cboParametro.Location = New System.Drawing.Point(183, 33)
        Me.cboParametro.Name = "cboParametro"
        Me.cboParametro.Size = New System.Drawing.Size(142, 21)
        Me.cboParametro.TabIndex = 1
        '
        'cboCampo
        '
        Me.cboCampo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Location = New System.Drawing.Point(6, 33)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(147, 21)
        Me.cboCampo.TabIndex = 0
        '
        'gbResultado
        '
        Me.gbResultado.Controls.Add(Me.gdvConsulta)
        Me.gbResultado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbResultado.Location = New System.Drawing.Point(0, 104)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Size = New System.Drawing.Size(579, 329)
        Me.gbResultado.TabIndex = 4
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'gdvConsulta
        '
        Me.gdvConsulta.AllowUserToAddRows = False
        Me.gdvConsulta.AllowUserToDeleteRows = False
        Me.gdvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvConsulta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gdvConsulta.Location = New System.Drawing.Point(3, 16)
        Me.gdvConsulta.MultiSelect = False
        Me.gdvConsulta.Name = "gdvConsulta"
        Me.gdvConsulta.ReadOnly = True
        Me.gdvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdvConsulta.Size = New System.Drawing.Size(573, 310)
        Me.gdvConsulta.TabIndex = 0
        '
        'tsBotoes
        '
        Me.tsBotoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPesquisar, Me.ToolStripButton1})
        Me.tsBotoes.Location = New System.Drawing.Point(0, 0)
        Me.tsBotoes.Name = "tsBotoes"
        Me.tsBotoes.Size = New System.Drawing.Size(579, 25)
        Me.tsBotoes.TabIndex = 12
        Me.tsBotoes.Text = "ToolStrip1"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(23, 22)
        Me.btnPesquisar.Text = "Pesquisar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Limpar"
        '
        'frmConsultaDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(579, 433)
        Me.Controls.Add(Me.tsBotoes)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.gbCriterio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsultaDefault"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaDefault"
        Me.gbCriterio.ResumeLayout(False)
        Me.gbCriterio.PerformLayout()
        Me.gbResultado.ResumeLayout(False)
        CType(Me.gdvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBotoes.ResumeLayout(False)
        Me.tsBotoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbCriterio As GroupBox
    Friend WithEvents txtValor As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboParametro As ComboBox
    Friend WithEvents cboCampo As ComboBox
    Friend WithEvents gbResultado As GroupBox
    Friend WithEvents gdvConsulta As DataGridView
    Friend WithEvents tsBotoes As ToolStrip
    Friend WithEvents btnPesquisar As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
