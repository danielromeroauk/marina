﻿Imports Marina.Module1

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
                Me.GuardarInteligenciaToolStripMenuItem.Enabled = False
                Dim DS As New bdinfanteriaDataSet
                Dim TAInteligencia As New bdinfanteriaDataSetTableAdapters.inteligenciasTableAdapter
                TAInteligencia.Insert( _
                    codigo:=CodigoTextBox.Text, _
                    latitud:=getLatitud(GradosLatNumericUpDown.Value, MinutosLatNumericUpDown.Value, SegundosLatNumericUpDown.Value), _
                    longitud:=getLongitud(GradosLgnNumericUpDown.Value, MinutosLgnNumericUpDown.Value, SegundosLgnNumericUpDown.Value), _
                    nombre_lugar:=NombreLugarTextBox.Text, _
                    blanco:=BlancoComboBox.Text, _
                    fecha_hechos:=FechaHechosDateTimePicker.Value, _
                    actividades:=getActividades(), _
                    anotaciones:=AnotacionesRichTextBox.Text)

                MsgBox("Registro de inteligencia guardado con éxito", MsgBoxStyle.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.GuardarInteligenciaToolStripMenuItem.Enabled = True
        End Try
    End Sub

    Private Function getActividades() As String
        Dim retornar As String = ""
        For Each elem As String In ActividadesCheckedListBox.CheckedItems
            retornar += elem.ToString & ". "
        Next

        Return retornar
    End Function

    Private Sub InteligenciaForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ContenedorForm.RegistrarInteligenciaToolStripMenuItem.Enabled = True
    End Sub

    Private Sub InteligenciaForm_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class