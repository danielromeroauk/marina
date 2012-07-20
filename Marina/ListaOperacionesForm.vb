Public Class ListaOperacionesForm

    Private _getCodOperacion As Boolean = False

    Private Sub ListaOperacionesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdinfanteriaDataSet.operaciones' Puede moverla o quitarla según sea necesario.
        Me.OperacionesTableAdapter.Fill(Me.BdinfanteriaDataSet.operaciones)
    End Sub

    Private Sub FiltrarButton_Click(sender As System.Object, e As System.EventArgs) Handles FiltrarButton.Click
        Try
            Me.OperacionesTableAdapter.FillByCodONombre(Me.BdinfanteriaDataSet.operaciones, "%" & FiltroTextBox.Text & "%", "%" & FiltroTextBox.Text & "%")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Devuelve el código de la operación seleccionada por el usuario.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function ShowDialog(getCodOperacion As Boolean) As String
        Me._getCodOperacion = getCodOperacion
        MyBase.ShowDialog()
        Try
            If Me._getCodOperacion Then
                Return OperacionesDataGridView.SelectedRows(0).Cells(0).Value
            Else
                Return Nothing
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub OperacionesDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OperacionesDataGridView.CellDoubleClick
        Me.Close()
    End Sub

    Private Sub CancelarButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelarButton.Click
        Me._getCodOperacion = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class