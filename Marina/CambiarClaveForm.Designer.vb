<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarClaveForm
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
        Me.NuevaClaveTextBox = New System.Windows.Forms.TextBox()
        Me.NuevaClaveLabel = New System.Windows.Forms.Label()
        Me.ConfirmarClaveTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmarClaveLabel = New System.Windows.Forms.Label()
        Me.CambiarButton = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Size = New System.Drawing.Size(311, 23)
        Me.TituloLabel.Text = "Cambiar Clave"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CancelarButton)
        Me.Panel1.Controls.Add(Me.CambiarButton)
        Me.Panel1.Controls.Add(Me.ConfirmarClaveTextBox)
        Me.Panel1.Controls.Add(Me.ConfirmarClaveLabel)
        Me.Panel1.Controls.Add(Me.NuevaClaveTextBox)
        Me.Panel1.Controls.Add(Me.NuevaClaveLabel)
        Me.Panel1.Size = New System.Drawing.Size(312, 139)
        '
        'NuevaClaveTextBox
        '
        Me.NuevaClaveTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevaClaveTextBox.Location = New System.Drawing.Point(116, 18)
        Me.NuevaClaveTextBox.MaxLength = 300
        Me.NuevaClaveTextBox.Name = "NuevaClaveTextBox"
        Me.NuevaClaveTextBox.Size = New System.Drawing.Size(175, 22)
        Me.NuevaClaveTextBox.TabIndex = 3
        Me.NuevaClaveTextBox.UseSystemPasswordChar = True
        '
        'NuevaClaveLabel
        '
        Me.NuevaClaveLabel.AutoSize = True
        Me.NuevaClaveLabel.Location = New System.Drawing.Point(24, 18)
        Me.NuevaClaveLabel.Name = "NuevaClaveLabel"
        Me.NuevaClaveLabel.Size = New System.Drawing.Size(87, 16)
        Me.NuevaClaveLabel.TabIndex = 2
        Me.NuevaClaveLabel.Text = "Nueva clave:"
        '
        'ConfirmarClaveTextBox
        '
        Me.ConfirmarClaveTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfirmarClaveTextBox.Location = New System.Drawing.Point(116, 56)
        Me.ConfirmarClaveTextBox.MaxLength = 300
        Me.ConfirmarClaveTextBox.Name = "ConfirmarClaveTextBox"
        Me.ConfirmarClaveTextBox.Size = New System.Drawing.Size(175, 22)
        Me.ConfirmarClaveTextBox.TabIndex = 5
        Me.ConfirmarClaveTextBox.UseSystemPasswordChar = True
        '
        'ConfirmarClaveLabel
        '
        Me.ConfirmarClaveLabel.AutoSize = True
        Me.ConfirmarClaveLabel.Location = New System.Drawing.Point(25, 46)
        Me.ConfirmarClaveLabel.Name = "ConfirmarClaveLabel"
        Me.ConfirmarClaveLabel.Size = New System.Drawing.Size(84, 32)
        Me.ConfirmarClaveLabel.TabIndex = 4
        Me.ConfirmarClaveLabel.Text = "Confirmar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nueva clave:"
        '
        'CambiarButton
        '
        Me.CambiarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.CambiarButton.Location = New System.Drawing.Point(216, 90)
        Me.CambiarButton.Name = "CambiarButton"
        Me.CambiarButton.Size = New System.Drawing.Size(75, 23)
        Me.CambiarButton.TabIndex = 6
        Me.CambiarButton.Text = "Cambiar"
        Me.CambiarButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CancelarButton
        '
        Me.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.CancelarButton.Location = New System.Drawing.Point(135, 90)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 7
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'CambiarClaveForm
        '
        Me.AcceptButton = Me.CambiarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarButton
        Me.ClientSize = New System.Drawing.Size(336, 190)
        Me.MaximumSize = New System.Drawing.Size(352, 300)
        Me.MinimumSize = New System.Drawing.Size(352, 228)
        Me.Name = "CambiarClaveForm"
        Me.Text = "CambiarClaveForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CambiarButton As System.Windows.Forms.Button
    Friend WithEvents ConfirmarClaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmarClaveLabel As System.Windows.Forms.Label
    Friend WithEvents NuevaClaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NuevaClaveLabel As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
End Class
