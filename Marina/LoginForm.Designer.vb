<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.ClaveLabel = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.EntrarButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Text = "Inciar sesión"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EntrarButton)
        Me.Panel1.Controls.Add(Me.ClaveTextBox)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.ClaveLabel)
        Me.Panel1.Controls.Add(Me.IdLabel)
        Me.Panel1.Size = New System.Drawing.Size(272, 108)
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Location = New System.Drawing.Point(12, 16)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(89, 16)
        Me.IdLabel.TabIndex = 0
        Me.IdLabel.Text = "Identificación:"
        '
        'ClaveLabel
        '
        Me.ClaveLabel.AutoSize = True
        Me.ClaveLabel.Location = New System.Drawing.Point(55, 42)
        Me.ClaveLabel.Name = "ClaveLabel"
        Me.ClaveLabel.Size = New System.Drawing.Size(46, 16)
        Me.ClaveLabel.TabIndex = 1
        Me.ClaveLabel.Text = "Clave:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(108, 11)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(151, 22)
        Me.IdTextBox.TabIndex = 2
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.Location = New System.Drawing.Point(108, 42)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.Size = New System.Drawing.Size(151, 22)
        Me.ClaveTextBox.TabIndex = 3
        Me.ClaveTextBox.UseSystemPasswordChar = True
        '
        'EntrarButton
        '
        Me.EntrarButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.EntrarButton.Location = New System.Drawing.Point(184, 74)
        Me.EntrarButton.Name = "EntrarButton"
        Me.EntrarButton.Size = New System.Drawing.Size(75, 23)
        Me.EntrarButton.TabIndex = 4
        Me.EntrarButton.Text = "Entrar"
        Me.EntrarButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AcceptButton = Me.EntrarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.ClientSize = New System.Drawing.Size(296, 159)
        Me.ControlBox = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(312, 197)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(312, 197)
        Me.Name = "LoginForm"
        Me.ShowInTaskbar = False
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EntrarButton As System.Windows.Forms.Button
    Friend WithEvents ClaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClaveLabel As System.Windows.Forms.Label
    Friend WithEvents IdLabel As System.Windows.Forms.Label
End Class
