Imports Marina.Module1

Public Class CambiarClaveForm

    Private Sub CambiarButton_Click(sender As System.Object, e As System.EventArgs) Handles CambiarButton.Click
        Try

            If NuevaClaveTextBox.Text.Length < 6 Then
                MsgBox("La clave debe tener como mímino 6 caracteres.", MsgBoxStyle.Information)
            ElseIf NuevaClaveTextBox.Text <> ConfirmarClaveTextBox.Text Then
                MsgBox("Las claves no coinciden.", MsgBoxStyle.Information)
            Else
                Dim TAUsuarios As New bdmarinaDataSetTableAdapters.usuariosTableAdapter
                TAUsuarios.CambiarClave(NuevaClaveTextBox.Text, userId, userClave)
                MsgBox("Clave cambiada", MsgBoxStyle.Information)
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub CambiarClaveForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim loginF As New LoginForm
        loginF.Text = "Conceder permiso de cambio de clave"
        If loginF.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class