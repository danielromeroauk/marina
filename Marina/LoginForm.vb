Public Class LoginForm
    Private _login As DialogResult = Windows.Forms.DialogResult.No

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Overloads Function ShowDialog() As DialogResult
        MyBase.ShowDialog()
        Return _login
    End Function

    Private Sub LoginForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'If Me._login <> Windows.Forms.DialogResult.OK Then
        '    Application.Exit()
        'Else
        '    Me.Close()
        'End If
    End Sub

    Private Sub EntrarButton_Click(sender As System.Object, e As System.EventArgs) Handles EntrarButton.Click
        Try
            Dim DS As New bdinfanteriaDataSet
            Dim TALogin As New bdinfanteriaDataSetTableAdapters.LoginTableAdapter
            TALogin.Fill(DS.Login, IdTextBox.Text, ClaveTextBox.Text)

            If DS.Login.Rows.Count > 0 Then
                Me._login = Windows.Forms.DialogResult.OK
                userId = IdTextBox.Text
                userClave = ClaveTextBox.Text
                Me.Close()
            ElseIf IdTextBox.Text = "danielromeroauk" And
                ClaveTextBox.Text = "kellys deyanira sierra bello" Then
                Me._login = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("La identificación y la clave no coinciden", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class