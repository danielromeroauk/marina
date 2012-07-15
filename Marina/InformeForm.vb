Imports Microsoft.Reporting.WinForms
Imports Word = Microsoft.Office.Interop.Word
Imports Marina.Module1

Public Class InformeForm

    Private _codOperacion As String = ""

    Private Sub InformeForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.morteros' Puede moverla o quitarla según sea necesario.
        Me.morterosTableAdapter.Fill(Me.bdmarinaDataSet.morteros)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.abastecimientos' Puede moverla o quitarla según sea necesario.
        Me.abastecimientosTableAdapter.Fill(Me.bdmarinaDataSet.abastecimientos)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.ametralladoras' Puede moverla o quitarla según sea necesario.
        Me.ametralladorasTableAdapter.Fill(Me.bdmarinaDataSet.ametralladoras)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.anexos' Puede moverla o quitarla según sea necesario.
        Me.anexosTableAdapter.Fill(Me.bdmarinaDataSet.anexos)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.comunicaciones' Puede moverla o quitarla según sea necesario.
        Me.comunicacionesTableAdapter.Fill(Me.bdmarinaDataSet.comunicaciones)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.coordenadas' Puede moverla o quitarla según sea necesario.
        Me.coordenadasTableAdapter.Fill(Me.bdmarinaDataSet.coordenadas)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.ejecucion' Puede moverla o quitarla según sea necesario.
        Me.ejecucionTableAdapter.Fill(Me.bdmarinaDataSet.ejecucion)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.equipos_especiales' Puede moverla o quitarla según sea necesario.
        Me.equipos_especialesTableAdapter.Fill(Me.bdmarinaDataSet.equipos_especiales)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.firmas' Puede moverla o quitarla según sea necesario.
        Me.firmasTableAdapter.Fill(Me.bdmarinaDataSet.firmas)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.fusiles' Puede moverla o quitarla según sea necesario.
        Me.fusilesTableAdapter.Fill(Me.bdmarinaDataSet.fusiles)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.granadas' Puede moverla o quitarla según sea necesario.
        Me.granadasTableAdapter.Fill(Me.bdmarinaDataSet.granadas)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.inteligencias' Puede moverla o quitarla según sea necesario.
        Me.inteligenciasTableAdapter.Fill(Me.bdmarinaDataSet.inteligencias)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.lanzagranadas' Puede moverla o quitarla según sea necesario.
        Me.lanzagranadasTableAdapter.Fill(Me.bdmarinaDataSet.lanzagranadas)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.operaciones' Puede moverla o quitarla según sea necesario.
        Me.operacionesTableAdapter.Fill(Me.bdmarinaDataSet.operaciones)
        'TODO: esta línea de código carga datos en la tabla 'bdmarinaDataSet.toe' Puede moverla o quitarla según sea necesario.
        Me.toeTableAdapter.Fill(Me.bdmarinaDataSet.toe)
        Try
            Me.abastecimientosTableAdapter.FillByOperacion(Me.bdmarinaDataSet.abastecimientos, _codOperacion)
            Me.ametralladorasTableAdapter.FillByOperacion(Me.bdmarinaDataSet.ametralladoras, _codOperacion)
            Me.anexosTableAdapter.FillByOperacion(Me.bdmarinaDataSet.anexos, _codOperacion)
            Me.comunicacionesTableAdapter.FillByOperacion(Me.bdmarinaDataSet.comunicaciones, _codOperacion)
            Me.coordenadasTableAdapter.FillByOperacion(Me.bdmarinaDataSet.coordenadas, _codOperacion)
            Me.ejecucionTableAdapter.FillByOperacion(Me.bdmarinaDataSet.ejecucion, _codOperacion)
            Me.equipos_especialesTableAdapter.FillByOperacion(Me.bdmarinaDataSet.equipos_especiales, _codOperacion)
            Me.firmasTableAdapter.FillByOperacion(Me.bdmarinaDataSet.firmas, _codOperacion)
            Me.fusilesTableAdapter.FillByOperacion(Me.bdmarinaDataSet.fusiles, _codOperacion)
            Me.granadasTableAdapter.FillByOperacion(Me.bdmarinaDataSet.granadas, _codOperacion)
            Me.lanzagranadasTableAdapter.FillByOperacion(Me.bdmarinaDataSet.lanzagranadas, _codOperacion)
            Me.operacionesTableAdapter.FillByOperacion(Me.bdmarinaDataSet.operaciones, _codOperacion)
            Me.toeTableAdapter.FillByOperacion(Me.bdmarinaDataSet.toe, _codOperacion)
            Me.inteligenciasTableAdapter.FillByOperacion(Me.bdmarinaDataSet.inteligencias, _codOperacion)

            'Me.ReportViewer1.Visible = True
            'Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'Me.ReportViewer1.RefreshReport()
            'Me.ReportViewer1.ZoomMode = ZoomMode.Percent
            'Me.ReportViewer1.ZoomPercent = 100

            crearDocumentoWordOrdenFragmentaria()
            TituloLabel.Text = "La Orden Fragmentaria fue generada con éxito en Microsoft Office Word"
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Muestra la orden Fragmentaria de la operación cuyo consecutivo sea codOperacion.
    ''' </summary>
    ''' <param name="codOperacion"></param>
    ''' <remarks></remarks>
    Public Overloads Sub Show(codOperacion As String)
        Me._codOperacion = codOperacion
        MyBase.Show()
    End Sub

    ''' <summary>
    ''' Genera la orden fragmentaria en el formato establecido.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub crearDocumentoWordOrdenFragmentaria()
        Dim oWord As word.Application
        Dim oDoc As word.Document

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add(My.Application.Info.DirectoryPath & "\formatoOrdenFragmentaria.dotx")

        oDoc.Bookmarks.Item("consecutivo1").Range.Text = _
            Trim(Me.bdmarinaDataSet.operaciones(0)("operacion").ToString) & " " & _
            Me.bdmarinaDataSet.operaciones(0)("nombre_operacion").ToString

        oDoc.Bookmarks.Item("procedimiento").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("procedimiento")

        oDoc.Bookmarks.Item("autoridad").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("autoriza_de")

        oDoc.Bookmarks.Item("consecutivo2").Range.Text = _
            Trim(Me.bdmarinaDataSet.operaciones(0)("operacion").ToString) & " " & _
            Me.bdmarinaDataSet.operaciones(0)("nombre_operacion").ToString

        oDoc.Bookmarks.Item("lugar_y_fecha").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("fecha_operacion")

        oDoc.Bookmarks.Item("mensaje_referencia").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("nombre_operacion")

        oDoc.Bookmarks.Item("autoriza_de").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("autoriza_de")

        oDoc.Bookmarks.Item("acc").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("comandante_operacion")

        oDoc.Bookmarks.Item("indicativo").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("indicativo")

        oDoc.Bookmarks.Item("referencias").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("referencias")

        oDoc.Bookmarks.Item("toe").Range.Text = _
            "Oficiales: " & Me.bdmarinaDataSet.toe(0)("oficiales") & "   " & _
            "Suboficiales: " & Me.bdmarinaDataSet.toe(0)("suboficiales") & "   " & _
            "IMP: " & Me.bdmarinaDataSet.toe(0)("imp") & "   " & _
            "IMR: " & Me.bdmarinaDataSet.toe(0)("imr") & "   " & _
            "Civiles: " & Me.bdmarinaDataSet.toe(0)("civiles") & "   " & vbCr & _
            "Agregaciones: " & Me.bdmarinaDataSet.toe(0)("agregaciones")

        oDoc.Bookmarks.Item("situacion").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("situacion")

        Dim inteligencias As String = ""
        For Each inteli As DataRow In bdmarinaDataSet.inteligencias
            inteligencias &= vbCr & "Fecha de los hechos: " & inteli("fecha_hechos")
            inteligencias &= vbCr & "Coordenadas: " & getCoordenada(Decimal.Parse(inteli("latitud"))) & " N   " & _
                getCoordenada(Decimal.Parse(inteli("longitud"))) & " W"
            inteligencias &= vbCr & "Nombre del lugar: " & inteli("nombre_lugar")
            inteligencias &= vbCr & "Blanco: " & inteli("blanco")
            inteligencias &= vbCr & "Actividades: " & inteli("actividades")
            inteligencias &= vbCr & "Anotaciones: " & inteli("anotaciones") & vbCr
        Next
        oDoc.Bookmarks.Item("inteligencias").Range.Text = inteligencias

        oDoc.Bookmarks.Item("propias_tropas").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("propias_tropas")

        oDoc.Bookmarks.Item("mision").Range.Text = _
            Me.bdmarinaDataSet.operaciones(0)("mision")

        oDoc.Bookmarks.Item("intencion_comandante").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("intencion_comandante")

        oDoc.Bookmarks.Item("concepto_operacion").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("concepto")

        oDoc.Bookmarks.Item("maniobra").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("maniobra")

        oDoc.Bookmarks.Item("fuegos").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("fuegos")

        oDoc.Bookmarks.Item("tareas_maniobra").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("tareas_maniobra")

        oDoc.Bookmarks.Item("tareas_combate").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("tareas_combate")

        oDoc.Bookmarks.Item("instrucciones_coordinacion").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("instrucciones_coordinacion")

        oDoc.Bookmarks.Item("nivel_hostilidad").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("nivel_hostilidad")

        oDoc.Bookmarks.Item("marco_juridico").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("marco_juridico")

        oDoc.Bookmarks.Item("principios").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("principios")

        oDoc.Bookmarks.Item("uso_fuerza").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("uso_fuerza")

        oDoc.Bookmarks.Item("instrucciones_especiales").Range.Text = _
            Me.bdmarinaDataSet.ejecucion(0)("instrucciones_especiales")

        oDoc.Bookmarks.Item("clase1").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("clase1")

        oDoc.Bookmarks.Item("clase2").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("clase2")

        oDoc.Bookmarks.Item("clase3").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("clase3")

        oDoc.Bookmarks.Item("clase4").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("clase4")

        oDoc.Bookmarks.Item("clase5").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("clase5")

        oDoc.Bookmarks.Item("clase6").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("clase6")

        oDoc.Bookmarks.Item("evacuaciones_medicas").Range.Text = _
            Me.bdmarinaDataSet.abastecimientos(0)("evacuaciones_medicas")

        oDoc.Bookmarks.Item("vhf_7330").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("vhf_7330")

        oDoc.Bookmarks.Item("vhf_710").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("vhf_710")

        oDoc.Bookmarks.Item("vhf_930").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("vhf_930")

        oDoc.Bookmarks.Item("vhf_aereo").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("vhf_aereo")

        oDoc.Bookmarks.Item("vhf_escaner").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("vhf_escaner")

        oDoc.Bookmarks.Item("hf_6020").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("hf_6020")

        oDoc.Bookmarks.Item("hf_escaner").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("hf_escaner")

        oDoc.Bookmarks.Item("uhf_xts4250").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("uhf_xts4250")

        oDoc.Bookmarks.Item("uhf_xtr3000").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("uhf_xtr3000")

        oDoc.Bookmarks.Item("uhf_escaner").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("uhf_escaner")

        oDoc.Bookmarks.Item("avantel").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("avantel")

        oDoc.Bookmarks.Item("celular").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("celular")

        oDoc.Bookmarks.Item("satelital").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("satelital")

        oDoc.Bookmarks.Item("clave").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("clave")

        oDoc.Bookmarks.Item("complementos").Range.Text = _
            Me.bdmarinaDataSet.comunicaciones(0)("complementos")

        oDoc.Bookmarks.Item("m60_estandar").Range.Text = _
            Me.bdmarinaDataSet.ametralladoras(0)("m60_estandar")

        oDoc.Bookmarks.Item("m60_e4").Range.Text = _
            Me.bdmarinaDataSet.ametralladoras(0)("m60_e4")

        oDoc.Bookmarks.Item("m249").Range.Text = _
            Me.bdmarinaDataSet.ametralladoras(0)("m249")

        oDoc.Bookmarks.Item("ss77").Range.Text = _
            Me.bdmarinaDataSet.ametralladoras(0)("ss77")

        oDoc.Bookmarks.Item("punto50").Range.Text = _
            Me.bdmarinaDataSet.ametralladoras(0)("punto50")

        oDoc.Bookmarks.Item("otras_ametralladoras").Range.Text = _
            Me.bdmarinaDataSet.ametralladoras(0)("otras_ametralladoras")

        oDoc.Bookmarks.Item("galil").Range.Text = _
            Me.bdmarinaDataSet.fusiles(0)("galil")

        oDoc.Bookmarks.Item("m16").Range.Text = _
            Me.bdmarinaDataSet.fusiles(0)("m16")

        oDoc.Bookmarks.Item("otros_fusiles").Range.Text = _
            Me.bdmarinaDataSet.fusiles(0)("otros_fusiles")

        oDoc.Bookmarks.Item("mano").Range.Text = _
            Me.bdmarinaDataSet.granadas(0)("mano")

        oDoc.Bookmarks.Item("humo").Range.Text = _
            Me.bdmarinaDataSet.granadas(0)("humo")

        oDoc.Bookmarks.Item("lacrimogeno").Range.Text = _
            Me.bdmarinaDataSet.granadas(0)("lacrimogeno")

        oDoc.Bookmarks.Item("otras_granadas").Range.Text = _
            Me.bdmarinaDataSet.granadas(0)("otras_granadas")

        oDoc.Bookmarks.Item("mgl").Range.Text = _
            Me.bdmarinaDataSet.lanzagranadas(0)("mgl")

        oDoc.Bookmarks.Item("mk").Range.Text = _
            Me.bdmarinaDataSet.lanzagranadas(0)("mk")

        oDoc.Bookmarks.Item("m79").Range.Text = _
            Me.bdmarinaDataSet.lanzagranadas(0)("m79")

        oDoc.Bookmarks.Item("m203").Range.Text = _
            Me.bdmarinaDataSet.lanzagranadas(0)("m203")

        oDoc.Bookmarks.Item("mc_c370_60mm").Range.Text = _
            Me.bdmarinaDataSet.morteros(0)("mc_c370_60mm")

        oDoc.Bookmarks.Item("mc_c575_60mm").Range.Text = _
            Me.bdmarinaDataSet.morteros(0)("mc_c575_60mm")

        oDoc.Bookmarks.Item("mc_fms_60mm").Range.Text = _
            Me.bdmarinaDataSet.morteros(0)("mc_fms_60mm")

        oDoc.Bookmarks.Item("m_brandt_60mm").Range.Text = _
            Me.bdmarinaDataSet.morteros(0)("m_brandt_60mm")

        oDoc.Bookmarks.Item("otros_morteros").Range.Text = _
            Me.bdmarinaDataSet.morteros(0)("otros_morteros")

        oDoc.Bookmarks.Item("autoriza").Range.Text = _
            Me.bdmarinaDataSet.firmas(0)("autoriza")

        oDoc.Bookmarks.Item("autentica").Range.Text = _
            Me.bdmarinaDataSet.firmas(0)("autentica")

        oDoc.Bookmarks.Item("recibe").Range.Text = _
            Me.bdmarinaDataSet.firmas(0)("recibe")

        Dim anexos As String = ""
        For Each anex As DataRow In bdmarinaDataSet.anexos
            anexos &= vbCr & anex("nombre")
        Next
        oDoc.Bookmarks.Item("anexos").Range.Text = anexos
    End Sub

    Private Sub CerrarOrdenfragmentariaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarOrdenfragmentariaToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class