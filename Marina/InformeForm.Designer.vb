<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeForm
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
        Me.okButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Location = New System.Drawing.Point(13, 35)
        Me.TituloLabel.Size = New System.Drawing.Size(271, 93)
        Me.TituloLabel.Text = "Orden Fragmentaria"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.okButton)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(12, 152)
        Me.Panel1.Size = New System.Drawing.Size(272, 52)
        '
        'okButton
        '
        Me.okButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.okButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.okButton.Location = New System.Drawing.Point(99, 16)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'InformeForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 216)
        Me.ControlBox = False
        Me.Name = "InformeForm"
        Me.Text = "InformeForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents okButton As System.Windows.Forms.Button
End Class
