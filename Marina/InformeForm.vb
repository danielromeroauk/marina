Imports Microsoft.Reporting.WinForms
Imports Word = Microsoft.Office.Interop.Word
Imports Marina.Module1

Public Class InformeForm

    Private _codOperacion As String = ""
    Private _DS As New bdinfanteriaDataSet

    Private Sub InformeForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim TAAmetralladoras As New bdinfanteriaDataSetTableAdapters.ametralladorasTableAdapter
            TAAmetralladoras.FillByOperacion(Me._DS.ametralladoras, Me._codOperacion)

            Dim TAAnexos As New bdinfanteriaDataSetTableAdapters.anexosTableAdapter
            TAAnexos.FillByOperacion(Me._DS.anexos, Me._codOperacion)

            Dim TAComunicaciones As New bdinfanteriaDataSetTableAdapters.comunicacionesTableAdapter
            TAComunicaciones.FillByOperacion(Me._DS.comunicaciones, Me._codOperacion)

            Dim TACoordenadas As New bdinfanteriaDataSetTableAdapters.coordenadasTableAdapter
            TACoordenadas.FillByOperacion(Me._DS.coordenadas, Me._codOperacion)

            Dim TAEjecucion As New bdinfanteriaDataSetTableAdapters.ejecucionTableAdapter
            TAEjecucion.FillByOperacion(Me._DS.ejecucion, Me._codOperacion)

            Dim TAEquiposEspeciales As New bdinfanteriaDataSetTableAdapters.equipos_especialesTableAdapter
            TAEquiposEspeciales.FillByOperacion(Me._DS.equipos_especiales, Me._codOperacion)

            Dim TAFirmas As New bdinfanteriaDataSetTableAdapters.firmasTableAdapter
            TAFirmas.FillByOperacion(Me._DS.firmas, Me._codOperacion)

            Dim TAFusiles As New bdinfanteriaDataSetTableAdapters.fusilesTableAdapter
            TAFusiles.FillByOperacion(Me._DS.fusiles, Me._codOperacion)

            Dim TAGranadas As New bdinfanteriaDataSetTableAdapters.granadasTableAdapter
            TAGranadas.FillByOperacion(Me._DS.granadas, Me._codOperacion)

            Dim TAInteligencias As New bdinfanteriaDataSetTableAdapters.inteligenciasTableAdapter
            TAInteligencias.FillByOperacion(Me._DS.inteligencias, Me._codOperacion)

            Dim TALanzagranadas As New bdinfanteriaDataSetTableAdapters.lanzagranadasTableAdapter
            TALanzagranadas.FillByOperacion(Me._DS.lanzagranadas, Me._codOperacion)

            Dim TAMision As New bdinfanteriaDataSetTableAdapters.misionTableAdapter
            TAMision.FillByOperacion(Me._DS.mision, Me._codOperacion)

            Dim TAMorteros As New bdinfanteriaDataSetTableAdapters.morterosTableAdapter
            TAMorteros.FillByOperacion(Me._DS.morteros, Me._codOperacion)

            Dim TAOperaciones As New bdinfanteriaDataSetTableAdapters.operacionesTableAdapter
            TAOperaciones.FillByOperacion(Me._DS.operaciones, Me._codOperacion)

            Dim TAPersonal As New bdinfanteriaDataSetTableAdapters.personalTableAdapter
            TAPersonal.FillByOperacion(Me._DS.personal, Me._codOperacion)

            Dim TAServiciosCombate As New bdinfanteriaDataSetTableAdapters.servicios_combateTableAdapter
            TAServiciosCombate.FillByOperacion(Me._DS.servicios_combate, Me._codOperacion)

            Dim TASituacion As New bdinfanteriaDataSetTableAdapters.situacionTableAdapter
            TASituacion.FillByOperacion(Me._DS.situacion, Me._codOperacion)

            Dim TAToe As New bdinfanteriaDataSetTableAdapters.toeTableAdapter
            TAToe.FillByOperacion(Me._DS.toe, Me._codOperacion)

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
    Public Overloads Sub ShowDialog(codOperacion As String)
        Me._codOperacion = codOperacion
        MyBase.ShowDialog()
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
            Trim(Me._DS.operaciones(0)("operacion").ToString) & " " & _
            Me._DS.operaciones(0)("nombre").ToString

        oDoc.Bookmarks.Item("procedimiento").Range.Text = _
            Me._DS.operaciones(0)("procedimiento")

        oDoc.Bookmarks.Item("consecutivo2").Range.Text = _
            Trim(Me._DS.operaciones(0)("operacion").ToString) & " " & _
            Me._DS.operaciones(0)("nombre").ToString

        oDoc.Bookmarks.Item("lugar_y_fecha").Range.Text = _
        Me._DS.operaciones(0)("lugar") & ", " & _
        Me._DS.operaciones(0)("fecha")

        oDoc.Bookmarks.Item("mensaje_referencia").Range.Text = _
            Me._DS.operaciones(0)("nombre")

        oDoc.Bookmarks.Item("autoriza_de").Range.Text = _
            Me._DS.operaciones(0)("de")

        oDoc.Bookmarks.Item("acc").Range.Text = _
            Me._DS.operaciones(0)("acc")

        oDoc.Bookmarks.Item("indicativo").Range.Text = _
            Me._DS.operaciones(0)("indicativo")

        oDoc.Bookmarks.Item("referencias").Range.Text = _
            Me._DS.operaciones(0)("referencias")

        oDoc.Bookmarks.Item("situacion").Range.Text = _
            Me._DS.situacion(0)("detalle")

        oDoc.Bookmarks.Item("enemigo").Range.Text = _
            Me._DS.situacion(0)("enemigo")

        oDoc.Bookmarks.Item("propias_tropas").Range.Text = _
            Me._DS.situacion(0)("propias_tropas")

        oDoc.Bookmarks.Item("agregaciones_situacion").Range.Text = _
            Me._DS.situacion(0)("agregaciones")

        oDoc.Bookmarks.Item("segregaciones_situacion").Range.Text = _
            Me._DS.situacion(0)("segregaciones")

        oDoc.Bookmarks.Item("mision").Range.Text = _
            Me._DS.mision(0)("detalle")

        oDoc.Bookmarks.Item("toe").Range.Text = _
            "Oficiales: " & Me._DS.toe(0)("oficiales") & "   " & _
            "Suboficiales: " & Me._DS.toe(0)("suboficiales") & "   " & _
            "IMP: " & Me._DS.toe(0)("imp") & "   " & _
            "IMR: " & Me._DS.toe(0)("imr") & "   " & _
            "Civiles: " & Me._DS.toe(0)("civiles") & "   " & vbCr & _
            "Agregaciones: " & Me._DS.toe(0)("agregaciones") & "   " & vbCr & _
            "Segregaciones: " & Me._DS.toe(0)("segregaciones")

        oDoc.Bookmarks.Item("intencion_comandante").Range.Text = _
            Me._DS.ejecucion(0)("intencion_comandante")

        oDoc.Bookmarks.Item("concepto_operacion").Range.Text = _
            Me._DS.ejecucion(0)("concepto_operacion")

        oDoc.Bookmarks.Item("maniobra").Range.Text = _
            Me._DS.ejecucion(0)("maniobra")

        oDoc.Bookmarks.Item("fuegos").Range.Text = _
            Me._DS.ejecucion(0)("fuegos")

        Dim inteligencias As String = ""
        For Each inteli As DataRow In Me._DS.inteligencias
            inteligencias &= vbCr & "Fecha de los hechos: " & inteli("fecha_hechos")
            inteligencias &= vbCr & "Coordenadas: " & getCoordenada(Decimal.Parse(inteli("latitud"))) & " N   " & _
                getCoordenada(Decimal.Parse(inteli("longitud"))) & " W"
            inteligencias &= vbCr & "Nombre del lugar: " & inteli("nombre_lugar")
            inteligencias &= vbCr & "Blanco: " & inteli("blanco")
            inteligencias &= vbCr & "Actividades: " & inteli("actividades")
            inteligencias &= vbCr & "Anotaciones: " & inteli("anotaciones") & vbCr
        Next
        oDoc.Bookmarks.Item("inteligencias").Range.Text = inteligencias

        oDoc.Bookmarks.Item("tareas_maniobra").Range.Text = _
            Me._DS.ejecucion(0)("tareas_maniobra")

        oDoc.Bookmarks.Item("tareas_combate").Range.Text = _
            Me._DS.ejecucion(0)("tareas_combate")

        oDoc.Bookmarks.Item("instrucciones_coordinacion").Range.Text = _
            Me._DS.ejecucion(0)("instrucciones_coordinacion")

        oDoc.Bookmarks.Item("instrucciones_juridicas").Range.Text = _
            Me._DS.ejecucion(0)("instrucciones_juridicas")

        oDoc.Bookmarks.Item("uso_fuerza").Range.Text = _
            Me._DS.ejecucion(0)("uso_fuerza_autorizada")

        oDoc.Bookmarks.Item("clase1").Range.Text = _
            Me._DS.servicios_combate(0)("clase1")

        oDoc.Bookmarks.Item("clase2").Range.Text = _
            Me._DS.servicios_combate(0)("clase2")

        oDoc.Bookmarks.Item("clase3").Range.Text = _
            Me._DS.servicios_combate(0)("clase3")

        oDoc.Bookmarks.Item("clase4").Range.Text = _
            Me._DS.servicios_combate(0)("clase4")

        oDoc.Bookmarks.Item("clase5").Range.Text = _
            Me._DS.servicios_combate(0)("clase5")

        oDoc.Bookmarks.Item("clase6").Range.Text = _
            Me._DS.servicios_combate(0)("clase6")

        oDoc.Bookmarks.Item("evacuaciones_medicas").Range.Text = _
            Me._DS.servicios_combate(0)("evacuaciones_medicas")

        oDoc.Bookmarks.Item("m60_estandar").Range.Text = _
            Me._DS.ametralladoras(0)("m60_estandar")

        oDoc.Bookmarks.Item("m60_e4").Range.Text = _
            Me._DS.ametralladoras(0)("m60_e4")

        oDoc.Bookmarks.Item("m249").Range.Text = _
            Me._DS.ametralladoras(0)("m249")

        oDoc.Bookmarks.Item("ss77").Range.Text = _
            Me._DS.ametralladoras(0)("ss77")

        oDoc.Bookmarks.Item("punto50").Range.Text = _
            Me._DS.ametralladoras(0)("punto50")

        oDoc.Bookmarks.Item("total_ametralladoras").Range.Text = ( _
            Me._DS.ametralladoras(0)("m60_estandar") + _
            Me._DS.ametralladoras(0)("m60_e4") + _
            Me._DS.ametralladoras(0)("m249") + _
            Me._DS.ametralladoras(0)("ss77") + _
            Me._DS.ametralladoras(0)("punto50"))

        oDoc.Bookmarks.Item("otras_ametralladoras").Range.Text = _
            Me._DS.ametralladoras(0)("otras_ametralladoras")

        oDoc.Bookmarks.Item("galil_ar").Range.Text = _
            Me._DS.fusiles(0)("galil_ar")

        oDoc.Bookmarks.Item("galil_ice").Range.Text = _
            Me._DS.fusiles(0)("galil_ice")

        oDoc.Bookmarks.Item("m16_a2").Range.Text = _
            Me._DS.fusiles(0)("m16_a2")

        oDoc.Bookmarks.Item("m16_m4").Range.Text = _
            Me._DS.fusiles(0)("m16_m4")

        oDoc.Bookmarks.Item("m16_a203").Range.Text = _
            Me._DS.fusiles(0)("m16_a203")

        oDoc.Bookmarks.Item("total_fusiles").Range.Text = ( _
            Me._DS.fusiles(0)("galil_ar") + _
            Me._DS.fusiles(0)("galil_ice") + _
            Me._DS.fusiles(0)("m16_a2") + _
            Me._DS.fusiles(0)("m16_m4") + _
            Me._DS.fusiles(0)("m16_a203"))

        oDoc.Bookmarks.Item("otros_fusiles").Range.Text = _
            Me._DS.fusiles(0)("otros_fusiles")

        oDoc.Bookmarks.Item("mano").Range.Text = _
            Me._DS.granadas(0)("mano")

        oDoc.Bookmarks.Item("humo").Range.Text = _
            Me._DS.granadas(0)("humo")

        oDoc.Bookmarks.Item("lacrimogena").Range.Text = _
            Me._DS.granadas(0)("lacrimogena")

        oDoc.Bookmarks.Item("total_granadas").Range.Text = ( _
            Me._DS.granadas(0)("mano") + _
            Me._DS.granadas(0)("humo") + _
             Me._DS.granadas(0)("lacrimogena"))

        oDoc.Bookmarks.Item("otras_granadas").Range.Text = _
            Me._DS.granadas(0)("otras_granadas")

        oDoc.Bookmarks.Item("mgl").Range.Text = _
            Me._DS.lanzagranadas(0)("mgl")

        oDoc.Bookmarks.Item("mk").Range.Text = _
            Me._DS.lanzagranadas(0)("mk")

        oDoc.Bookmarks.Item("m79").Range.Text = _
            Me._DS.lanzagranadas(0)("m79")

        oDoc.Bookmarks.Item("total_lanzagranadas").Range.Text = ( _
            Me._DS.lanzagranadas(0)("mgl") + _
            Me._DS.lanzagranadas(0)("mk") + _
            Me._DS.lanzagranadas(0)("m79"))

        oDoc.Bookmarks.Item("otros_lanzagranadas").Range.Text = _
            Me._DS.lanzagranadas(0)("otros_lanzagranadas")

        oDoc.Bookmarks.Item("mc_c370_60mm").Range.Text = _
            Me._DS.morteros(0)("mc_c370_60mm")

        oDoc.Bookmarks.Item("mc_c575_60mm").Range.Text = _
            Me._DS.morteros(0)("mc_575_60mm")

        oDoc.Bookmarks.Item("mc_fms_60mm").Range.Text = _
            Me._DS.morteros(0)("mc_fms_60mm")

        oDoc.Bookmarks.Item("m_brandt_60mm").Range.Text = _
            Me._DS.morteros(0)("m_brandt_60mm")

        oDoc.Bookmarks.Item("total_morteros").Range.Text = ( _
            Me._DS.morteros(0)("mc_c370_60mm") + _
            Me._DS.morteros(0)("mc_575_60mm") + _
            Me._DS.morteros(0)("mc_fms_60mm") + _
            Me._DS.morteros(0)("m_brandt_60mm"))

        oDoc.Bookmarks.Item("otros_morteros").Range.Text = _
            Me._DS.morteros(0)("otros_morteros")

        oDoc.Bookmarks.Item("visor_nocturno").Range.Text = _
            Me._DS.equipos_especiales(0)("visor_nocturno")

        oDoc.Bookmarks.Item("binoculares").Range.Text = _
            Me._DS.equipos_especiales(0)("binoculares")

        oDoc.Bookmarks.Item("camara_termica").Range.Text = _
            Me._DS.equipos_especiales(0)("camara_termica")

        oDoc.Bookmarks.Item("flasmers").Range.Text = _
            Me._DS.equipos_especiales(0)("flasmers")

        oDoc.Bookmarks.Item("kit_orientacion_nocturno").Range.Text = _
            Me._DS.equipos_especiales(0)("kit_orientacion_nocturno")

        oDoc.Bookmarks.Item("otros_equipos").Range.Text = _
            Me._DS.equipos_especiales(0)("otros_equipos")

        oDoc.Bookmarks.Item("vhf_7330").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_7330_cant")

        oDoc.Bookmarks.Item("vhf_7330_frec").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_7330_frec")

        oDoc.Bookmarks.Item("vhf_710").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_710_cant")

        oDoc.Bookmarks.Item("vhf_710_frec").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_710_frec")

        oDoc.Bookmarks.Item("vhf_930").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_930_cant")

        oDoc.Bookmarks.Item("vhf_930_frec").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_930_frec")

        oDoc.Bookmarks.Item("vhf_aereo").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_aereo_cant")

        oDoc.Bookmarks.Item("vhf_aereo_frec").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_aereo_frec")

        oDoc.Bookmarks.Item("vhf_escaner").Range.Text = _
            Me._DS.comunicaciones(0)("vhf_escaner")

        oDoc.Bookmarks.Item("hf_6020").Range.Text = _
            Me._DS.comunicaciones(0)("hf_6020_cant")

        oDoc.Bookmarks.Item("hf_6020_frec").Range.Text = _
            Me._DS.comunicaciones(0)("hf_6020_frec")

        oDoc.Bookmarks.Item("hf_escaner").Range.Text = _
            Me._DS.comunicaciones(0)("hf_escaner")

        oDoc.Bookmarks.Item("uhf_xts4250").Range.Text = _
            Me._DS.comunicaciones(0)("uhf_xts4250_cant")

        oDoc.Bookmarks.Item("uhf_xts4250_frec").Range.Text = _
            Me._DS.comunicaciones(0)("uhf_xts4250_frec")

        oDoc.Bookmarks.Item("uhf_xtr3000").Range.Text = _
            Me._DS.comunicaciones(0)("uhf_xtr3000_cant")

        oDoc.Bookmarks.Item("uhf_xtr3000_frec").Range.Text = _
            Me._DS.comunicaciones(0)("uhf_xtr3000_frec")

        oDoc.Bookmarks.Item("uhf_escaner").Range.Text = _
            Me._DS.comunicaciones(0)("uhf_escaner")

        oDoc.Bookmarks.Item("avantel").Range.Text = _
            Me._DS.comunicaciones(0)("avantel")

        oDoc.Bookmarks.Item("celular").Range.Text = _
            Me._DS.comunicaciones(0)("celular")

        oDoc.Bookmarks.Item("satelital").Range.Text = _
            Me._DS.comunicaciones(0)("satelital")

        oDoc.Bookmarks.Item("clave").Range.Text = _
            Me._DS.comunicaciones(0)("clave")

        oDoc.Bookmarks.Item("indicativos").Range.Text = _
            Me._DS.comunicaciones(0)("indicativos")

        oDoc.Bookmarks.Item("personal").Range.Text = _
            Me._DS.personal(0)("detalle")

        oDoc.Bookmarks.Item("autoriza").Range.Text = _
            Me._DS.firmas(0)("autoriza")

        oDoc.Bookmarks.Item("autentica").Range.Text = _
            Me._DS.firmas(0)("autentica")

        oDoc.Bookmarks.Item("recibe").Range.Text = _
            Me._DS.firmas(0)("recibe")

        Dim anexos As String = ""
        For Each anex As DataRow In Me._DS.anexos
            anexos &= vbCr & anex("nombre")
        Next
        oDoc.Bookmarks.Item("anexos").Range.Text = anexos

        oDoc.Bookmarks.Item("distribucion").Range.Text = _
            Me._DS.firmas(0)("distribucion")

    End Sub

    Private Sub CerrarOrdenfragmentariaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub okButton_Click(sender As System.Object, e As System.EventArgs) Handles okButton.Click
        Me.Close()
    End Sub
End Class