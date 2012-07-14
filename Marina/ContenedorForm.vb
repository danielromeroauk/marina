Public Class ContenedorForm

    Private Sub ContenedorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim loginF As New LoginForm
        If loginF.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub RegistarOperacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistarOperacionToolStripMenuItem.Click
        Dim operacionF As New OperacionForm
        operacionF.MdiParent = Me
        operacionF.WindowState = FormWindowState.Maximized
        operacionF.Show()
    End Sub

    Private Sub RegistrarInteligenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarInteligenciaToolStripMenuItem.Click
        Dim inteligenciaF As New InteligenciaForm
        inteligenciaF.MdiParent = Me
        inteligenciaF.WindowState = FormWindowState.Maximized
        inteligenciaF.Show()
    End Sub

    Private Sub CambiarClaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarClaveToolStripMenuItem.Click
        Dim cambiarF As New CambiarClaveForm
        cambiarF.ShowDialog()
    End Sub

    Private Sub OrdenFragmentariaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrdenFragmentariaToolStripMenuItem.Click
        Dim listaOperacionesF As New ListaOperacionesForm
        'listaOperacionesF.MdiParent = Me
        'listaOperacionesF.WindowState = FormWindowState.Maximized

        Dim codOperacion As String = listaOperacionesF.ShowDialog(getCodOperacion:=True)

        If Not IsNothing(codOperacion) Then
            Dim informeF As New InformeForm
            informeF.MdiParent = Me
            informeF.WindowState = FormWindowState.Maximized
            informeF.Show(codOperacion:=codOperacion)
        End If

    End Sub
End Class
