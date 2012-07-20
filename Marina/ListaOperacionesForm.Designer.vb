<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaOperacionesForm
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
        Me.OperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.OperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdinfanteriaDataSet = New Marina.bdinfanteriaDataSet()
        Me.FiltroTextBox = New System.Windows.Forms.TextBox()
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OperacionesTableAdapter = New Marina.bdinfanteriaDataSetTableAdapters.operacionesTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.OperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdinfanteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Size = New System.Drawing.Size(655, 23)
        Me.TituloLabel.Text = "Lista de operaciones (Filtro: consecutivo o nombre)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CancelarButton)
        Me.Panel1.Controls.Add(Me.FiltrarButton)
        Me.Panel1.Controls.Add(Me.FiltroTextBox)
        Me.Panel1.Controls.Add(Me.OperacionesDataGridView)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Size = New System.Drawing.Size(656, 371)
        '
        'OperacionesDataGridView
        '
        Me.OperacionesDataGridView.AllowUserToAddRows = False
        Me.OperacionesDataGridView.AllowUserToDeleteRows = False
        Me.OperacionesDataGridView.AllowUserToOrderColumns = True
        Me.OperacionesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OperacionesDataGridView.AutoGenerateColumns = False
        Me.OperacionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.OperacionesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.OperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DeDataGridViewTextBoxColumn, Me.AccDataGridViewTextBoxColumn})
        Me.OperacionesDataGridView.DataSource = Me.OperacionesBindingSource
        Me.OperacionesDataGridView.Location = New System.Drawing.Point(0, 58)
        Me.OperacionesDataGridView.MultiSelect = False
        Me.OperacionesDataGridView.Name = "OperacionesDataGridView"
        Me.OperacionesDataGridView.ReadOnly = True
        Me.OperacionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OperacionesDataGridView.Size = New System.Drawing.Size(656, 313)
        Me.OperacionesDataGridView.TabIndex = 0
        '
        'OperacionDataGridViewTextBoxColumn
        '
        Me.OperacionDataGridViewTextBoxColumn.DataPropertyName = "operacion"
        Me.OperacionDataGridViewTextBoxColumn.HeaderText = "Consecutivo"
        Me.OperacionDataGridViewTextBoxColumn.Name = "OperacionDataGridViewTextBoxColumn"
        Me.OperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperacionDataGridViewTextBoxColumn.Width = 107
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre operación"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 146
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 71
        '
        'DeDataGridViewTextBoxColumn
        '
        Me.DeDataGridViewTextBoxColumn.DataPropertyName = "de"
        Me.DeDataGridViewTextBoxColumn.HeaderText = "De"
        Me.DeDataGridViewTextBoxColumn.Name = "DeDataGridViewTextBoxColumn"
        Me.DeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeDataGridViewTextBoxColumn.Width = 51
        '
        'AccDataGridViewTextBoxColumn
        '
        Me.AccDataGridViewTextBoxColumn.DataPropertyName = "acc"
        Me.AccDataGridViewTextBoxColumn.HeaderText = "ACC"
        Me.AccDataGridViewTextBoxColumn.Name = "AccDataGridViewTextBoxColumn"
        Me.AccDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccDataGridViewTextBoxColumn.Width = 60
        '
        'OperacionesBindingSource
        '
        Me.OperacionesBindingSource.DataMember = "operaciones"
        Me.OperacionesBindingSource.DataSource = Me.BdinfanteriaDataSet
        '
        'BdinfanteriaDataSet
        '
        Me.BdinfanteriaDataSet.DataSetName = "bdinfanteriaDataSet"
        Me.BdinfanteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FiltroTextBox
        '
        Me.FiltroTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroTextBox.Location = New System.Drawing.Point(7, 16)
        Me.FiltroTextBox.Name = "FiltroTextBox"
        Me.FiltroTextBox.Size = New System.Drawing.Size(369, 22)
        Me.FiltroTextBox.TabIndex = 1
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.FiltrarButton.Location = New System.Drawing.Point(382, 16)
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
        Me.CancelarButton.Location = New System.Drawing.Point(577, 16)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 25)
        Me.CancelarButton.TabIndex = 3
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.Location = New System.Drawing.Point(463, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ver selección"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OperacionesTableAdapter
        '
        Me.OperacionesTableAdapter.ClearBeforeFill = True
        '
        'ListaOperacionesForm
        '
        Me.AcceptButton = Me.FiltrarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarButton
        Me.ClientSize = New System.Drawing.Size(680, 422)
        Me.Name = "ListaOperacionesForm"
        Me.Text = "ListaOperacionesForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdinfanteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OperacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FiltrarButton As System.Windows.Forms.Button
    Friend WithEvents FiltroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents NombreoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorizadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComandanteoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PropiastropasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BdinfanteriaDataSet As Marina.bdinfanteriaDataSet
    Friend WithEvents OperacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperacionesTableAdapter As Marina.bdinfanteriaDataSetTableAdapters.operacionesTableAdapter
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
