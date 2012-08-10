<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaInteligenciasForm
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
        Me.InteligenciasDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrelugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechahechosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnotacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteligenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdinfanteriaDataSet = New Marina.bdinfanteriaDataSet()
        Me.codigoTextBox = New System.Windows.Forms.TextBox()
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.InteligenciasTableAdapter = New Marina.bdinfanteriaDataSetTableAdapters.inteligenciasTableAdapter()
        Me.codigoLabel = New System.Windows.Forms.Label()
        Me.filtrosGroupBox = New System.Windows.Forms.GroupBox()
        Me.rangoFechasGroupBox = New System.Windows.Forms.GroupBox()
        Me.hastaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.desdeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.hastaLabel = New System.Windows.Forms.Label()
        Me.desdeLabel = New System.Windows.Forms.Label()
        Me.actividadLabel = New System.Windows.Forms.Label()
        Me.blancoComboBox = New System.Windows.Forms.ComboBox()
        Me.blancoLabel = New System.Windows.Forms.Label()
        Me.actividadComboBox = New System.Windows.Forms.ComboBox()
        Me.lugarLabel = New System.Windows.Forms.Label()
        Me.lugarTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.InteligenciasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InteligenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdinfanteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filtrosGroupBox.SuspendLayout()
        Me.rangoFechasGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Size = New System.Drawing.Size(855, 23)
        Me.TituloLabel.Text = "Lista de Inteligencias"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.filtrosGroupBox)
        Me.Panel1.Controls.Add(Me.InteligenciasDataGridView)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Size = New System.Drawing.Size(856, 371)
        '
        'InteligenciasDataGridView
        '
        Me.InteligenciasDataGridView.AllowUserToAddRows = False
        Me.InteligenciasDataGridView.AllowUserToDeleteRows = False
        Me.InteligenciasDataGridView.AllowUserToOrderColumns = True
        Me.InteligenciasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InteligenciasDataGridView.AutoGenerateColumns = False
        Me.InteligenciasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.InteligenciasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InteligenciasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.LatitudDataGridViewTextBoxColumn, Me.LongitudDataGridViewTextBoxColumn, Me.NombrelugarDataGridViewTextBoxColumn, Me.BlancoDataGridViewTextBoxColumn, Me.FechahechosDataGridViewTextBoxColumn, Me.ActividadesDataGridViewTextBoxColumn, Me.AnotacionesDataGridViewTextBoxColumn})
        Me.InteligenciasDataGridView.DataSource = Me.InteligenciasBindingSource
        Me.InteligenciasDataGridView.Location = New System.Drawing.Point(446, 6)
        Me.InteligenciasDataGridView.Name = "InteligenciasDataGridView"
        Me.InteligenciasDataGridView.ReadOnly = True
        Me.InteligenciasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InteligenciasDataGridView.Size = New System.Drawing.Size(410, 365)
        Me.InteligenciasDataGridView.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 77
        '
        'LatitudDataGridViewTextBoxColumn
        '
        Me.LatitudDataGridViewTextBoxColumn.DataPropertyName = "latitud"
        Me.LatitudDataGridViewTextBoxColumn.HeaderText = "latitud"
        Me.LatitudDataGridViewTextBoxColumn.Name = "LatitudDataGridViewTextBoxColumn"
        Me.LatitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.LatitudDataGridViewTextBoxColumn.Visible = False
        Me.LatitudDataGridViewTextBoxColumn.Width = 68
        '
        'LongitudDataGridViewTextBoxColumn
        '
        Me.LongitudDataGridViewTextBoxColumn.DataPropertyName = "longitud"
        Me.LongitudDataGridViewTextBoxColumn.HeaderText = "longitud"
        Me.LongitudDataGridViewTextBoxColumn.Name = "LongitudDataGridViewTextBoxColumn"
        Me.LongitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.LongitudDataGridViewTextBoxColumn.Visible = False
        Me.LongitudDataGridViewTextBoxColumn.Width = 80
        '
        'NombrelugarDataGridViewTextBoxColumn
        '
        Me.NombrelugarDataGridViewTextBoxColumn.DataPropertyName = "nombre_lugar"
        Me.NombrelugarDataGridViewTextBoxColumn.HeaderText = "Nombre del lugar"
        Me.NombrelugarDataGridViewTextBoxColumn.Name = "NombrelugarDataGridViewTextBoxColumn"
        Me.NombrelugarDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombrelugarDataGridViewTextBoxColumn.Width = 137
        '
        'BlancoDataGridViewTextBoxColumn
        '
        Me.BlancoDataGridViewTextBoxColumn.DataPropertyName = "blanco"
        Me.BlancoDataGridViewTextBoxColumn.HeaderText = "Blanco"
        Me.BlancoDataGridViewTextBoxColumn.Name = "BlancoDataGridViewTextBoxColumn"
        Me.BlancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BlancoDataGridViewTextBoxColumn.Width = 75
        '
        'FechahechosDataGridViewTextBoxColumn
        '
        Me.FechahechosDataGridViewTextBoxColumn.DataPropertyName = "fecha_hechos"
        Me.FechahechosDataGridViewTextBoxColumn.HeaderText = "Fecha de los hechos"
        Me.FechahechosDataGridViewTextBoxColumn.Name = "FechahechosDataGridViewTextBoxColumn"
        Me.FechahechosDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechahechosDataGridViewTextBoxColumn.Width = 158
        '
        'ActividadesDataGridViewTextBoxColumn
        '
        Me.ActividadesDataGridViewTextBoxColumn.DataPropertyName = "actividades"
        Me.ActividadesDataGridViewTextBoxColumn.HeaderText = "Actividades"
        Me.ActividadesDataGridViewTextBoxColumn.Name = "ActividadesDataGridViewTextBoxColumn"
        Me.ActividadesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActividadesDataGridViewTextBoxColumn.Width = 104
        '
        'AnotacionesDataGridViewTextBoxColumn
        '
        Me.AnotacionesDataGridViewTextBoxColumn.DataPropertyName = "anotaciones"
        Me.AnotacionesDataGridViewTextBoxColumn.HeaderText = "Anotaciones"
        Me.AnotacionesDataGridViewTextBoxColumn.Name = "AnotacionesDataGridViewTextBoxColumn"
        Me.AnotacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnotacionesDataGridViewTextBoxColumn.Width = 108
        '
        'InteligenciasBindingSource
        '
        Me.InteligenciasBindingSource.DataMember = "inteligencias"
        Me.InteligenciasBindingSource.DataSource = Me.BdinfanteriaDataSet
        '
        'BdinfanteriaDataSet
        '
        Me.BdinfanteriaDataSet.DataSetName = "bdinfanteriaDataSet"
        Me.BdinfanteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'codigoTextBox
        '
        Me.codigoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.codigoTextBox.Location = New System.Drawing.Point(67, 25)
        Me.codigoTextBox.Name = "codigoTextBox"
        Me.codigoTextBox.Size = New System.Drawing.Size(329, 22)
        Me.codigoTextBox.TabIndex = 1
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.FiltrarButton.Location = New System.Drawing.Point(236, 297)
        Me.FiltrarButton.Name = "FiltrarButton"
        Me.FiltrarButton.Size = New System.Drawing.Size(75, 25)
        Me.FiltrarButton.TabIndex = 2
        Me.FiltrarButton.Text = "Filtrar"
        Me.FiltrarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.CancelarButton.Location = New System.Drawing.Point(321, 297)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 25)
        Me.CancelarButton.TabIndex = 3
        Me.CancelarButton.Text = "Cerrar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'InteligenciasTableAdapter
        '
        Me.InteligenciasTableAdapter.ClearBeforeFill = True
        '
        'codigoLabel
        '
        Me.codigoLabel.AutoSize = True
        Me.codigoLabel.ForeColor = System.Drawing.Color.White
        Me.codigoLabel.Location = New System.Drawing.Point(6, 28)
        Me.codigoLabel.Name = "codigoLabel"
        Me.codigoLabel.Size = New System.Drawing.Size(55, 16)
        Me.codigoLabel.TabIndex = 5
        Me.codigoLabel.Text = "Código:"
        '
        'filtrosGroupBox
        '
        Me.filtrosGroupBox.Controls.Add(Me.rangoFechasGroupBox)
        Me.filtrosGroupBox.Controls.Add(Me.CancelarButton)
        Me.filtrosGroupBox.Controls.Add(Me.actividadLabel)
        Me.filtrosGroupBox.Controls.Add(Me.blancoComboBox)
        Me.filtrosGroupBox.Controls.Add(Me.blancoLabel)
        Me.filtrosGroupBox.Controls.Add(Me.actividadComboBox)
        Me.filtrosGroupBox.Controls.Add(Me.lugarLabel)
        Me.filtrosGroupBox.Controls.Add(Me.lugarTextBox)
        Me.filtrosGroupBox.Controls.Add(Me.codigoLabel)
        Me.filtrosGroupBox.Controls.Add(Me.codigoTextBox)
        Me.filtrosGroupBox.Controls.Add(Me.FiltrarButton)
        Me.filtrosGroupBox.ForeColor = System.Drawing.Color.White
        Me.filtrosGroupBox.Location = New System.Drawing.Point(7, 6)
        Me.filtrosGroupBox.Name = "filtrosGroupBox"
        Me.filtrosGroupBox.Size = New System.Drawing.Size(413, 332)
        Me.filtrosGroupBox.TabIndex = 6
        Me.filtrosGroupBox.TabStop = False
        Me.filtrosGroupBox.Text = "Filtros"
        '
        'rangoFechasGroupBox
        '
        Me.rangoFechasGroupBox.Controls.Add(Me.hastaDateTimePicker)
        Me.rangoFechasGroupBox.Controls.Add(Me.desdeDateTimePicker)
        Me.rangoFechasGroupBox.Controls.Add(Me.hastaLabel)
        Me.rangoFechasGroupBox.Controls.Add(Me.desdeLabel)
        Me.rangoFechasGroupBox.ForeColor = System.Drawing.Color.White
        Me.rangoFechasGroupBox.Location = New System.Drawing.Point(36, 175)
        Me.rangoFechasGroupBox.Name = "rangoFechasGroupBox"
        Me.rangoFechasGroupBox.Size = New System.Drawing.Size(356, 104)
        Me.rangoFechasGroupBox.TabIndex = 15
        Me.rangoFechasGroupBox.TabStop = False
        Me.rangoFechasGroupBox.Text = "Rango de fecha"
        '
        'hastaDateTimePicker
        '
        Me.hastaDateTimePicker.Location = New System.Drawing.Point(69, 62)
        Me.hastaDateTimePicker.Name = "hastaDateTimePicker"
        Me.hastaDateTimePicker.Size = New System.Drawing.Size(268, 22)
        Me.hastaDateTimePicker.TabIndex = 17
        '
        'desdeDateTimePicker
        '
        Me.desdeDateTimePicker.Location = New System.Drawing.Point(69, 25)
        Me.desdeDateTimePicker.Name = "desdeDateTimePicker"
        Me.desdeDateTimePicker.Size = New System.Drawing.Size(268, 22)
        Me.desdeDateTimePicker.TabIndex = 16
        '
        'hastaLabel
        '
        Me.hastaLabel.AutoSize = True
        Me.hastaLabel.ForeColor = System.Drawing.Color.White
        Me.hastaLabel.Location = New System.Drawing.Point(18, 67)
        Me.hastaLabel.Name = "hastaLabel"
        Me.hastaLabel.Size = New System.Drawing.Size(47, 16)
        Me.hastaLabel.TabIndex = 15
        Me.hastaLabel.Text = "Hasta:"
        '
        'desdeLabel
        '
        Me.desdeLabel.AutoSize = True
        Me.desdeLabel.ForeColor = System.Drawing.Color.White
        Me.desdeLabel.Location = New System.Drawing.Point(13, 30)
        Me.desdeLabel.Name = "desdeLabel"
        Me.desdeLabel.Size = New System.Drawing.Size(52, 16)
        Me.desdeLabel.TabIndex = 14
        Me.desdeLabel.Text = "Desde:"
        '
        'actividadLabel
        '
        Me.actividadLabel.AutoSize = True
        Me.actividadLabel.ForeColor = System.Drawing.Color.White
        Me.actividadLabel.Location = New System.Drawing.Point(6, 114)
        Me.actividadLabel.Name = "actividadLabel"
        Me.actividadLabel.Size = New System.Drawing.Size(67, 16)
        Me.actividadLabel.TabIndex = 13
        Me.actividadLabel.Text = "Actividad:"
        '
        'blancoComboBox
        '
        Me.blancoComboBox.FormattingEnabled = True
        Me.blancoComboBox.Items.AddRange(New Object() {"FARC", "ELN", "BACRIM", "DELINCUENCIA COMÚN"})
        Me.blancoComboBox.Location = New System.Drawing.Point(67, 81)
        Me.blancoComboBox.Name = "blancoComboBox"
        Me.blancoComboBox.Size = New System.Drawing.Size(329, 24)
        Me.blancoComboBox.TabIndex = 12
        '
        'blancoLabel
        '
        Me.blancoLabel.AutoSize = True
        Me.blancoLabel.ForeColor = System.Drawing.Color.White
        Me.blancoLabel.Location = New System.Drawing.Point(6, 84)
        Me.blancoLabel.Name = "blancoLabel"
        Me.blancoLabel.Size = New System.Drawing.Size(53, 16)
        Me.blancoLabel.TabIndex = 10
        Me.blancoLabel.Text = "Blanco:"
        '
        'actividadComboBox
        '
        Me.actividadComboBox.FormattingEnabled = True
        Me.actividadComboBox.Items.AddRange(New Object() {"Abastecimiento", "Abigeato", "Artefacto explosivo", "Asesinato", "Baja enemigo", "Caleta", "Campamento", "Campo minado", "Captura", "Contacto armado", "Contrabando", "Desplazamiento forzado", "Emboscada", "Entrega terrorista", "Extorsión", "Hostigamiento", "Indicio enemigo", "Información de inteligencia", "Inteligencia externa", "Laboratorio", "Liberación secuestrado", "Material decomizado", "Narcotráfico", "Presencia de bandoleros", "Reclutamiento forzoso", "Retén ilegal", "Secuestro", "Terrorismo"})
        Me.actividadComboBox.Location = New System.Drawing.Point(79, 111)
        Me.actividadComboBox.Name = "actividadComboBox"
        Me.actividadComboBox.Size = New System.Drawing.Size(317, 24)
        Me.actividadComboBox.TabIndex = 9
        '
        'lugarLabel
        '
        Me.lugarLabel.AutoSize = True
        Me.lugarLabel.ForeColor = System.Drawing.Color.White
        Me.lugarLabel.Location = New System.Drawing.Point(6, 56)
        Me.lugarLabel.Name = "lugarLabel"
        Me.lugarLabel.Size = New System.Drawing.Size(115, 16)
        Me.lugarLabel.TabIndex = 8
        Me.lugarLabel.Text = "Nombre del lugar:"
        '
        'lugarTextBox
        '
        Me.lugarTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lugarTextBox.Location = New System.Drawing.Point(127, 53)
        Me.lugarTextBox.Name = "lugarTextBox"
        Me.lugarTextBox.Size = New System.Drawing.Size(269, 22)
        Me.lugarTextBox.TabIndex = 6
        '
        'ListaInteligenciasForm
        '
        Me.AcceptButton = Me.FiltrarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarButton
        Me.ClientSize = New System.Drawing.Size(880, 422)
        Me.ControlBox = False
        Me.Name = "ListaInteligenciasForm"
        Me.Text = "ListaInteligenciasForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.InteligenciasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InteligenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdinfanteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filtrosGroupBox.ResumeLayout(False)
        Me.filtrosGroupBox.PerformLayout()
        Me.rangoFechasGroupBox.ResumeLayout(False)
        Me.rangoFechasGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InteligenciasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FiltrarButton As System.Windows.Forms.Button
    Friend WithEvents codigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents NombreoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorizadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComandanteoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PropiastropasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BdinfanteriaDataSet As Marina.bdinfanteriaDataSet
    Friend WithEvents InteligenciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InteligenciasTableAdapter As Marina.bdinfanteriaDataSetTableAdapters.inteligenciasTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LatitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrelugarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechahechosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnotacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents filtrosGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents blancoLabel As System.Windows.Forms.Label
    Friend WithEvents actividadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lugarLabel As System.Windows.Forms.Label
    Friend WithEvents lugarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents codigoLabel As System.Windows.Forms.Label
    Friend WithEvents rangoFechasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hastaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents desdeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents hastaLabel As System.Windows.Forms.Label
    Friend WithEvents desdeLabel As System.Windows.Forms.Label
    Friend WithEvents actividadLabel As System.Windows.Forms.Label
    Friend WithEvents blancoComboBox As System.Windows.Forms.ComboBox
End Class
