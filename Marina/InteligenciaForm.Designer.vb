<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InteligenciaForm
    Inherits PlantillaForm

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
        Me.components = New System.ComponentModel.Container()
        Me.CodigoLabel = New System.Windows.Forms.Label()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NombreLugarTextBox = New System.Windows.Forms.TextBox()
        Me.BlancoComboBox = New System.Windows.Forms.ComboBox()
        Me.SegundosLgnNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SegundosLatNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LatitudLabel = New System.Windows.Forms.Label()
        Me.GradosLatNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MinutosLgnNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradosLgnNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradosLabel = New System.Windows.Forms.Label()
        Me.MinutosLabel = New System.Windows.Forms.Label()
        Me.SegundosLabel = New System.Windows.Forms.Label()
        Me.MinutosLatNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LongitudLabel = New System.Windows.Forms.Label()
        Me.NombreLugarLabel = New System.Windows.Forms.Label()
        Me.BlancoLabel = New System.Windows.Forms.Label()
        Me.FechaHechosDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.ActividadesGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActividadesCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.AnotacionesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AnotacionesLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarInteligenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundosLgnNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundosLatNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosLatNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MinutosLgnNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosLgnNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutosLatNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActividadesGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Location = New System.Drawing.Point(13, 33)
        Me.TituloLabel.Size = New System.Drawing.Size(648, 23)
        Me.TituloLabel.Text = "Nuevo Registro de inteligencia"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AnotacionesLabel)
        Me.Panel1.Controls.Add(Me.AnotacionesRichTextBox)
        Me.Panel1.Controls.Add(Me.ActividadesGroupBox)
        Me.Panel1.Controls.Add(Me.FechaLabel)
        Me.Panel1.Controls.Add(Me.FechaHechosDateTimePicker)
        Me.Panel1.Controls.Add(Me.BlancoLabel)
        Me.Panel1.Controls.Add(Me.BlancoComboBox)
        Me.Panel1.Controls.Add(Me.NombreLugarTextBox)
        Me.Panel1.Controls.Add(Me.NombreLugarLabel)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.CodigoTextBox)
        Me.Panel1.Controls.Add(Me.CodigoLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Size = New System.Drawing.Size(649, 445)
        '
        'CodigoLabel
        '
        Me.CodigoLabel.AutoSize = True
        Me.CodigoLabel.Location = New System.Drawing.Point(38, 21)
        Me.CodigoLabel.Name = "CodigoLabel"
        Me.CodigoLabel.Size = New System.Drawing.Size(55, 16)
        Me.CodigoLabel.TabIndex = 0
        Me.CodigoLabel.Text = "Código:"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(96, 21)
        Me.CodigoTextBox.MaxLength = 20
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(108, 22)
        Me.CodigoTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CodigoTextBox, "Máximo 20 caracteres.")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'NombreLugarTextBox
        '
        Me.NombreLugarTextBox.Location = New System.Drawing.Point(41, 217)
        Me.NombreLugarTextBox.MaxLength = 20
        Me.NombreLugarTextBox.Name = "NombreLugarTextBox"
        Me.NombreLugarTextBox.Size = New System.Drawing.Size(247, 22)
        Me.NombreLugarTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.NombreLugarTextBox, "Máximo 300 caracteres.")
        '
        'BlancoComboBox
        '
        Me.BlancoComboBox.FormattingEnabled = True
        Me.BlancoComboBox.Items.AddRange(New Object() {"FARC", "ELN", "BACRIM", "DELINCUENCIA COMÚN"})
        Me.BlancoComboBox.Location = New System.Drawing.Point(41, 270)
        Me.BlancoComboBox.Name = "BlancoComboBox"
        Me.BlancoComboBox.Size = New System.Drawing.Size(247, 24)
        Me.BlancoComboBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BlancoComboBox, "Seleecione uno de la lista o digite uno." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Máximo 300 caracteres.")
        '
        'SegundosLgnNumericUpDown
        '
        Me.SegundosLgnNumericUpDown.DecimalPlaces = 2
        Me.SegundosLgnNumericUpDown.Location = New System.Drawing.Point(190, 47)
        Me.SegundosLgnNumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SegundosLgnNumericUpDown.Name = "SegundosLgnNumericUpDown"
        Me.SegundosLgnNumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.SegundosLgnNumericUpDown.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.SegundosLgnNumericUpDown, "El separador decimal es la coma.")
        '
        'SegundosLatNumericUpDown
        '
        Me.SegundosLatNumericUpDown.DecimalPlaces = 2
        Me.SegundosLatNumericUpDown.Location = New System.Drawing.Point(190, 19)
        Me.SegundosLatNumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SegundosLatNumericUpDown.Name = "SegundosLatNumericUpDown"
        Me.SegundosLatNumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.SegundosLatNumericUpDown.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.SegundosLatNumericUpDown, "El separador decimal es la coma.")
        '
        'LatitudLabel
        '
        Me.LatitudLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LatitudLabel.AutoSize = True
        Me.LatitudLabel.Location = New System.Drawing.Point(15, 16)
        Me.LatitudLabel.Name = "LatitudLabel"
        Me.LatitudLabel.Size = New System.Drawing.Size(50, 28)
        Me.LatitudLabel.TabIndex = 3
        Me.LatitudLabel.Text = "Latitud:"
        Me.LatitudLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GradosLatNumericUpDown
        '
        Me.GradosLatNumericUpDown.Location = New System.Drawing.Point(71, 19)
        Me.GradosLatNumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.GradosLatNumericUpDown.Name = "GradosLatNumericUpDown"
        Me.GradosLatNumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.GradosLatNumericUpDown.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.SegundosLgnNumericUpDown, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MinutosLgnNumericUpDown, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GradosLgnNumericUpDown, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LatitudLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GradosLatNumericUpDown, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GradosLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MinutosLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SegundosLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MinutosLatNumericUpDown, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SegundosLatNumericUpDown, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LongitudLabel, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(25, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(263, 72)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'MinutosLgnNumericUpDown
        '
        Me.MinutosLgnNumericUpDown.Location = New System.Drawing.Point(130, 47)
        Me.MinutosLgnNumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinutosLgnNumericUpDown.Name = "MinutosLgnNumericUpDown"
        Me.MinutosLgnNumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.MinutosLgnNumericUpDown.TabIndex = 9
        '
        'GradosLgnNumericUpDown
        '
        Me.GradosLgnNumericUpDown.Location = New System.Drawing.Point(71, 47)
        Me.GradosLgnNumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.GradosLgnNumericUpDown.Name = "GradosLgnNumericUpDown"
        Me.GradosLgnNumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.GradosLgnNumericUpDown.TabIndex = 8
        '
        'GradosLabel
        '
        Me.GradosLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradosLabel.AutoSize = True
        Me.GradosLabel.Location = New System.Drawing.Point(71, 0)
        Me.GradosLabel.Name = "GradosLabel"
        Me.GradosLabel.Size = New System.Drawing.Size(53, 16)
        Me.GradosLabel.TabIndex = 0
        Me.GradosLabel.Text = "Grados"
        Me.GradosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinutosLabel
        '
        Me.MinutosLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinutosLabel.AutoSize = True
        Me.MinutosLabel.Location = New System.Drawing.Point(130, 0)
        Me.MinutosLabel.Name = "MinutosLabel"
        Me.MinutosLabel.Size = New System.Drawing.Size(54, 16)
        Me.MinutosLabel.TabIndex = 1
        Me.MinutosLabel.Text = "Minutos"
        Me.MinutosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SegundosLabel
        '
        Me.SegundosLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SegundosLabel.AutoSize = True
        Me.SegundosLabel.Location = New System.Drawing.Point(190, 0)
        Me.SegundosLabel.Name = "SegundosLabel"
        Me.SegundosLabel.Size = New System.Drawing.Size(70, 16)
        Me.SegundosLabel.TabIndex = 2
        Me.SegundosLabel.Text = "Segundos"
        Me.SegundosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinutosLatNumericUpDown
        '
        Me.MinutosLatNumericUpDown.Location = New System.Drawing.Point(130, 19)
        Me.MinutosLatNumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinutosLatNumericUpDown.Name = "MinutosLatNumericUpDown"
        Me.MinutosLatNumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.MinutosLatNumericUpDown.TabIndex = 5
        '
        'LongitudLabel
        '
        Me.LongitudLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LongitudLabel.AutoSize = True
        Me.LongitudLabel.Location = New System.Drawing.Point(3, 44)
        Me.LongitudLabel.Name = "LongitudLabel"
        Me.LongitudLabel.Size = New System.Drawing.Size(62, 28)
        Me.LongitudLabel.TabIndex = 7
        Me.LongitudLabel.Text = "Longitud:"
        Me.LongitudLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreLugarLabel
        '
        Me.NombreLugarLabel.AutoSize = True
        Me.NombreLugarLabel.Location = New System.Drawing.Point(38, 195)
        Me.NombreLugarLabel.Name = "NombreLugarLabel"
        Me.NombreLugarLabel.Size = New System.Drawing.Size(115, 16)
        Me.NombreLugarLabel.TabIndex = 5
        Me.NombreLugarLabel.Text = "Nombre del lugar:"
        '
        'BlancoLabel
        '
        Me.BlancoLabel.AutoSize = True
        Me.BlancoLabel.Location = New System.Drawing.Point(38, 251)
        Me.BlancoLabel.Name = "BlancoLabel"
        Me.BlancoLabel.Size = New System.Drawing.Size(53, 16)
        Me.BlancoLabel.TabIndex = 7
        Me.BlancoLabel.Text = "Blanco:"
        '
        'FechaHechosDateTimePicker
        '
        Me.FechaHechosDateTimePicker.Location = New System.Drawing.Point(41, 164)
        Me.FechaHechosDateTimePicker.Name = "FechaHechosDateTimePicker"
        Me.FechaHechosDateTimePicker.Size = New System.Drawing.Size(247, 22)
        Me.FechaHechosDateTimePicker.TabIndex = 4
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(38, 145)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(136, 16)
        Me.FechaLabel.TabIndex = 3
        Me.FechaLabel.Text = "Fecha de los hechos:"
        '
        'ActividadesGroupBox
        '
        Me.ActividadesGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ActividadesGroupBox.Controls.Add(Me.ActividadesCheckedListBox)
        Me.ActividadesGroupBox.ForeColor = System.Drawing.Color.White
        Me.ActividadesGroupBox.Location = New System.Drawing.Point(342, 48)
        Me.ActividadesGroupBox.Name = "ActividadesGroupBox"
        Me.ActividadesGroupBox.Size = New System.Drawing.Size(263, 362)
        Me.ActividadesGroupBox.TabIndex = 9
        Me.ActividadesGroupBox.TabStop = False
        Me.ActividadesGroupBox.Text = "Actividades"
        '
        'ActividadesCheckedListBox
        '
        Me.ActividadesCheckedListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadesCheckedListBox.BackColor = System.Drawing.Color.Black
        Me.ActividadesCheckedListBox.ForeColor = System.Drawing.Color.White
        Me.ActividadesCheckedListBox.FormattingEnabled = True
        Me.ActividadesCheckedListBox.Items.AddRange(New Object() {"Abastecimiento", "Abigeato", "Artefacto explosivo", "Asesinato", "Baja enemigo", "Caleta", "Campamento", "Campo minado", "Captura", "Contacto armado", "Contrabando", "Desplazamiento forzado", "Emboscada", "Entrega terrorista", "Extorsión", "Hostigamiento", "Indicio enemigo", "Información de inteligencia", "Inteligencia externa", "Laboratorio", "Liberación secuestrado", "Material decomizado", "Narcotráfico", "Presencia de bandoleros", "Reclutamiento forzoso", "Retén ilegal", "Secuestro", "Terrorismo"})
        Me.ActividadesCheckedListBox.Location = New System.Drawing.Point(6, 26)
        Me.ActividadesCheckedListBox.Name = "ActividadesCheckedListBox"
        Me.ActividadesCheckedListBox.Size = New System.Drawing.Size(251, 310)
        Me.ActividadesCheckedListBox.TabIndex = 0
        '
        'AnotacionesRichTextBox
        '
        Me.AnotacionesRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AnotacionesRichTextBox.Location = New System.Drawing.Point(41, 332)
        Me.AnotacionesRichTextBox.Name = "AnotacionesRichTextBox"
        Me.AnotacionesRichTextBox.Size = New System.Drawing.Size(281, 78)
        Me.AnotacionesRichTextBox.TabIndex = 11
        Me.AnotacionesRichTextBox.Text = ""
        '
        'AnotacionesLabel
        '
        Me.AnotacionesLabel.AutoSize = True
        Me.AnotacionesLabel.Location = New System.Drawing.Point(43, 313)
        Me.AnotacionesLabel.Name = "AnotacionesLabel"
        Me.AnotacionesLabel.Size = New System.Drawing.Size(86, 16)
        Me.AnotacionesLabel.TabIndex = 10
        Me.AnotacionesLabel.Text = "Anotaciones:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarInteligenciaToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 87)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarInteligenciaToolStripMenuItem
        '
        Me.GuardarInteligenciaToolStripMenuItem.Image = Global.Marina.My.Resources.Resources.filesaveas
        Me.GuardarInteligenciaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GuardarInteligenciaToolStripMenuItem.Name = "GuardarInteligenciaToolStripMenuItem"
        Me.GuardarInteligenciaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarInteligenciaToolStripMenuItem.Size = New System.Drawing.Size(125, 83)
        Me.GuardarInteligenciaToolStripMenuItem.Text = "&Guardar inteligencia"
        Me.GuardarInteligenciaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = Global.Marina.My.Resources.Resources._stop
        Me.CancelarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(129, 83)
        Me.CancelarToolStripMenuItem.Text = "&Cancelar inteligencia"
        Me.CancelarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InteligenciaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(673, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InteligenciaForm"
        Me.Text = "InteligenciaForm"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.TituloLabel, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundosLgnNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundosLatNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosLatNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MinutosLgnNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosLgnNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutosLatNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActividadesGroupBox.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CodigoLabel As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LatitudLabel As System.Windows.Forms.Label
    Friend WithEvents GradosLatNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GradosLabel As System.Windows.Forms.Label
    Friend WithEvents MinutosLabel As System.Windows.Forms.Label
    Friend WithEvents SegundosLabel As System.Windows.Forms.Label
    Friend WithEvents MinutosLatNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SegundosLatNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SegundosLgnNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MinutosLgnNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GradosLgnNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LongitudLabel As System.Windows.Forms.Label
    Friend WithEvents BlancoLabel As System.Windows.Forms.Label
    Friend WithEvents BlancoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NombreLugarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreLugarLabel As System.Windows.Forms.Label
    Friend WithEvents ActividadesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents FechaHechosDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ActividadesCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents AnotacionesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AnotacionesLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarInteligenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
