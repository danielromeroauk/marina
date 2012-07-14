Imports Marina.Module1

Public Class InteligenciaForm

    Private Sub CodigoTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles CodigoTextBox.Validating
        If CodigoTextBox.TextLength = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(CodigoTextBox, "Introduzca un código")
        Else
            ErrorProvider1.SetError(CodigoTextBox, Nothing)
        End If
    End Sub

    Private Sub NombreLugarTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles NombreLugarTextBox.Validating
        If NombreLugarTextBox.TextLength = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(NombreLugarTextBox, "Introduzca el nombre del lugar")
        Else
            ErrorProvider1.SetError(NombreLugarTextBox, Nothing)
        End If
    End Sub

    Private Sub BlancoComboBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles BlancoComboBox.Validating
        If BlancoComboBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(BlancoComboBox, "Seleccione un valor de la lista o digite uno.")
        Else
            ErrorProvider1.SetError(BlancoComboBox, Nothing)
        End If
    End Sub

    Private Sub AnotacionesRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles AnotacionesRichTextBox.Validating
        If AnotacionesRichTextBox.TextLength = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(AnotacionesRichTextBox, "Introduzca anotaciones.")
        Else
            ErrorProvider1.SetError(AnotacionesRichTextBox, Nothing)
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

    Private Sub GuardarInteligenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarInteligenciaToolStripMenuItem.Click
        Try
            If Me.Validate Then
                Dim DS As New bdmarinaDataSet
                Dim TAInteligencia As New bdmarinaDataSetTableAdapters.inteligenciasTableAdapter
                TAInteligencia.Insert(CodigoTextBox.Text, _
                            getLatitud(GradosLatNumericUpDown.Value, MinutosLatNumericUpDown.Value, SegundosLatNumericUpDown.Value), _
                            getLongitud(GradosLgnNumericUpDown.Value, MinutosLgnNumericUpDown.Value, SegundosLgnNumericUpDown.Value), _
                            NombreLugarTextBox.Text, _
                            BlancoComboBox.Text, _
                            FechaHechosDateTimePicker.Value, _
                            getActividades, _
                            AnotacionesRichTextBox.Text)
                MsgBox("Registro de inteligencia guardado con éxito", MsgBoxStyle.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function getActividades() As String
        Dim retornar As String = ""
        For Each elem As String In ActividadesCheckedListBox.CheckedItems
            retornar += elem.ToString & ". "
        Next

        Return retornar
    End Function

End Class