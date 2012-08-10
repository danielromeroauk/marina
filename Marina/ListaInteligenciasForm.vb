Public Class ListaInteligenciasForm

    Private Sub ListaInteligenciasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InteligenciasTableAdapter.Fill(Me.BdinfanteriaDataSet.inteligencias)
    End Sub

    Private Sub FiltrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltrarButton.Click
        Try
            Me.InteligenciasTableAdapter.FillByFiltro(Me.BdinfanteriaDataSet.inteligencias, _
                codigo:="%" & codigoTextBox.Text & "%", _
                lugar:="%" & lugarTextBox.Text & "%", _
                blanco:="%" & blancoComboBox.Text & "%", _
                desde:=desdeDateTimePicker.Value,
                hasta:=hastaDateTimePicker.Value,
                actividades:="%" & actividadComboBox.Text & "%")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class