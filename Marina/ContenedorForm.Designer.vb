<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarInteligenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistarOperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarClaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenFragmentariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarInteligenciaToolStripMenuItem, Me.RegistarOperacionToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 87)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarInteligenciaToolStripMenuItem
        '
        Me.RegistrarInteligenciaToolStripMenuItem.Image = CType(resources.GetObject("RegistrarInteligenciaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarInteligenciaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RegistrarInteligenciaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrarInteligenciaToolStripMenuItem.Name = "RegistrarInteligenciaToolStripMenuItem"
        Me.RegistrarInteligenciaToolStripMenuItem.Size = New System.Drawing.Size(129, 83)
        Me.RegistrarInteligenciaToolStripMenuItem.Text = "Registrar &Inteligencia"
        Me.RegistrarInteligenciaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RegistrarInteligenciaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.RegistrarInteligenciaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RegistarOperacionToolStripMenuItem
        '
        Me.RegistarOperacionToolStripMenuItem.Image = CType(resources.GetObject("RegistarOperacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistarOperacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistarOperacionToolStripMenuItem.Name = "RegistarOperacionToolStripMenuItem"
        Me.RegistarOperacionToolStripMenuItem.Size = New System.Drawing.Size(119, 83)
        Me.RegistarOperacionToolStripMenuItem.Text = "Registar &Operación"
        Me.RegistarOperacionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarClaveToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = CType(resources.GetObject("AyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(76, 83)
        Me.AyudaToolStripMenuItem.Text = "A&yuda"
        Me.AyudaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CambiarClaveToolStripMenuItem
        '
        Me.CambiarClaveToolStripMenuItem.Name = "CambiarClaveToolStripMenuItem"
        Me.CambiarClaveToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CambiarClaveToolStripMenuItem.Text = "Ca&mbiar clave"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenFragmentariaToolStripMenuItem})
        Me.InformesToolStripMenuItem.Image = CType(resources.GetObject("InformesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InformesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(76, 83)
        Me.InformesToolStripMenuItem.Text = "Infor&mes"
        Me.InformesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OrdenFragmentariaToolStripMenuItem
        '
        Me.OrdenFragmentariaToolStripMenuItem.Name = "OrdenFragmentariaToolStripMenuItem"
        Me.OrdenFragmentariaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.OrdenFragmentariaToolStripMenuItem.Text = "&Orden fragmentaria"
        '
        'ContenedorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "ContenedorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infantería de Marina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistarOperacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarInteligenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarClaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenFragmentariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
