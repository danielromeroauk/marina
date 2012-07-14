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
        Me.NombreoperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcedimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaoperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComandanteoperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndicativoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropiastropasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdmarinaDataSet = New Marina.bdmarinaDataSet()
        Me.OperacionesTableAdapter = New Marina.bdmarinaDataSetTableAdapters.operacionesTableAdapter()
        Me.FiltroTextBox = New System.Windows.Forms.TextBox()
        Me.FiltrarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.OperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdmarinaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Size = New System.Drawing.Size(655, 23)
        Me.TituloLabel.Text = "Lista de operaciones (Filtro: consecutivo o nombre)"
        '
        'Panel1
        '
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
        Me.OperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionDataGridViewTextBoxColumn, Me.NombreoperacionDataGridViewTextBoxColumn, Me.ProcedimientoDataGridViewTextBoxColumn, Me.FechaoperacionDataGridViewTextBoxColumn, Me.AutorizadeDataGridViewTextBoxColumn, Me.ComandanteoperacionDataGridViewTextBoxColumn, Me.IndicativoDataGridViewTextBoxColumn, Me.ReferenciasDataGridViewTextBoxColumn, Me.SituacionDataGridViewTextBoxColumn, Me.PropiastropasDataGridViewTextBoxColumn, Me.MisionDataGridViewTextBoxColumn})
        Me.OperacionesDataGridView.DataSource = Me.OperacionesBindingSource
        Me.OperacionesDataGridView.Location = New System.Drawing.Point(0, 76)
        Me.OperacionesDataGridView.MultiSelect = False
        Me.OperacionesDataGridView.Name = "OperacionesDataGridView"
        Me.OperacionesDataGridView.ReadOnly = True
        Me.OperacionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OperacionesDataGridView.Size = New System.Drawing.Size(656, 295)
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
        'NombreoperacionDataGridViewTextBoxColumn
        '
        Me.NombreoperacionDataGridViewTextBoxColumn.DataPropertyName = "nombre_operacion"
        Me.NombreoperacionDataGridViewTextBoxColumn.HeaderText = "Nombre Operacion"
        Me.NombreoperacionDataGridViewTextBoxColumn.Name = "NombreoperacionDataGridViewTextBoxColumn"
        Me.NombreoperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreoperacionDataGridViewTextBoxColumn.Width = 148
        '
        'ProcedimientoDataGridViewTextBoxColumn
        '
        Me.ProcedimientoDataGridViewTextBoxColumn.DataPropertyName = "procedimiento"
        Me.ProcedimientoDataGridViewTextBoxColumn.HeaderText = "procedimiento"
        Me.ProcedimientoDataGridViewTextBoxColumn.Name = "ProcedimientoDataGridViewTextBoxColumn"
        Me.ProcedimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProcedimientoDataGridViewTextBoxColumn.Visible = False
        Me.ProcedimientoDataGridViewTextBoxColumn.Width = 119
        '
        'FechaoperacionDataGridViewTextBoxColumn
        '
        Me.FechaoperacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_operacion"
        Me.FechaoperacionDataGridViewTextBoxColumn.HeaderText = "Fecha Operacion"
        Me.FechaoperacionDataGridViewTextBoxColumn.Name = "FechaoperacionDataGridViewTextBoxColumn"
        Me.FechaoperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaoperacionDataGridViewTextBoxColumn.Width = 137
        '
        'AutorizadeDataGridViewTextBoxColumn
        '
        Me.AutorizadeDataGridViewTextBoxColumn.DataPropertyName = "autoriza_de"
        Me.AutorizadeDataGridViewTextBoxColumn.HeaderText = "autoriza_de"
        Me.AutorizadeDataGridViewTextBoxColumn.Name = "AutorizadeDataGridViewTextBoxColumn"
        Me.AutorizadeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AutorizadeDataGridViewTextBoxColumn.Visible = False
        Me.AutorizadeDataGridViewTextBoxColumn.Width = 103
        '
        'ComandanteoperacionDataGridViewTextBoxColumn
        '
        Me.ComandanteoperacionDataGridViewTextBoxColumn.DataPropertyName = "comandante_operacion"
        Me.ComandanteoperacionDataGridViewTextBoxColumn.HeaderText = "Comandante Operacion"
        Me.ComandanteoperacionDataGridViewTextBoxColumn.Name = "ComandanteoperacionDataGridViewTextBoxColumn"
        Me.ComandanteoperacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComandanteoperacionDataGridViewTextBoxColumn.Width = 176
        '
        'IndicativoDataGridViewTextBoxColumn
        '
        Me.IndicativoDataGridViewTextBoxColumn.DataPropertyName = "indicativo"
        Me.IndicativoDataGridViewTextBoxColumn.HeaderText = "indicativo"
        Me.IndicativoDataGridViewTextBoxColumn.Name = "IndicativoDataGridViewTextBoxColumn"
        Me.IndicativoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndicativoDataGridViewTextBoxColumn.Visible = False
        Me.IndicativoDataGridViewTextBoxColumn.Width = 90
        '
        'ReferenciasDataGridViewTextBoxColumn
        '
        Me.ReferenciasDataGridViewTextBoxColumn.DataPropertyName = "referencias"
        Me.ReferenciasDataGridViewTextBoxColumn.HeaderText = "referencias"
        Me.ReferenciasDataGridViewTextBoxColumn.Name = "ReferenciasDataGridViewTextBoxColumn"
        Me.ReferenciasDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReferenciasDataGridViewTextBoxColumn.Visible = False
        '
        'SituacionDataGridViewTextBoxColumn
        '
        Me.SituacionDataGridViewTextBoxColumn.DataPropertyName = "situacion"
        Me.SituacionDataGridViewTextBoxColumn.HeaderText = "situacion"
        Me.SituacionDataGridViewTextBoxColumn.Name = "SituacionDataGridViewTextBoxColumn"
        Me.SituacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SituacionDataGridViewTextBoxColumn.Visible = False
        Me.SituacionDataGridViewTextBoxColumn.Width = 86
        '
        'PropiastropasDataGridViewTextBoxColumn
        '
        Me.PropiastropasDataGridViewTextBoxColumn.DataPropertyName = "propias_tropas"
        Me.PropiastropasDataGridViewTextBoxColumn.HeaderText = "propias_tropas"
        Me.PropiastropasDataGridViewTextBoxColumn.Name = "PropiastropasDataGridViewTextBoxColumn"
        Me.PropiastropasDataGridViewTextBoxColumn.ReadOnly = True
        Me.PropiastropasDataGridViewTextBoxColumn.Visible = False
        Me.PropiastropasDataGridViewTextBoxColumn.Width = 124
        '
        'MisionDataGridViewTextBoxColumn
        '
        Me.MisionDataGridViewTextBoxColumn.DataPropertyName = "mision"
        Me.MisionDataGridViewTextBoxColumn.HeaderText = "mision"
        Me.MisionDataGridViewTextBoxColumn.Name = "MisionDataGridViewTextBoxColumn"
        Me.MisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.MisionDataGridViewTextBoxColumn.Visible = False
        Me.MisionDataGridViewTextBoxColumn.Width = 72
        '
        'OperacionesBindingSource
        '
        Me.OperacionesBindingSource.DataMember = "operaciones"
        Me.OperacionesBindingSource.DataSource = Me.BdmarinaDataSet
        '
        'BdmarinaDataSet
        '
        Me.BdmarinaDataSet.DataSetName = "bdmarinaDataSet"
        Me.BdmarinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperacionesTableAdapter
        '
        Me.OperacionesTableAdapter.ClearBeforeFill = True
        '
        'FiltroTextBox
        '
        Me.FiltroTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroTextBox.Location = New System.Drawing.Point(7, 16)
        Me.FiltroTextBox.Name = "FiltroTextBox"
        Me.FiltroTextBox.Size = New System.Drawing.Size(483, 22)
        Me.FiltroTextBox.TabIndex = 1
        '
        'FiltrarButton
        '
        Me.FiltrarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltrarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.FiltrarButton.Location = New System.Drawing.Point(496, 15)
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
        CType(Me.BdmarinaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OperacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BdmarinaDataSet As Marina.bdmarinaDataSet
    Friend WithEvents OperacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperacionesTableAdapter As Marina.bdmarinaDataSetTableAdapters.operacionesTableAdapter
    Friend WithEvents FiltrarButton As System.Windows.Forms.Button
    Friend WithEvents FiltroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents OperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcedimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorizadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComandanteoperacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndicativoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PropiastropasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
