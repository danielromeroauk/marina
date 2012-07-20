Imports System.Transactions
Imports Marina.Module1
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class OperacionForm

    'TODO: 
    'Size del Group: 1150, 476
    'Location Group: 5, 12
    'Location siguienteLinkLabel: 1080, 15
    'Location atrasLinkLabel: 1105, 45

    Private Sub GuardarTodoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarTodoToolStripMenuItem.Click
        Try
            Using tx As New TransactionScope

                If Me.Validate And Me.camposDiligenciados Then

                    Dim TAOperacion As New bdinfanteriaDataSetTableAdapters.operacionesTableAdapter
                    TAOperacion.Insert( _
                        operacion:=operacionTextBox.Text, _
                        nombre:=nombre_operacionTextBox.Text, _
                        procedimiento:=procedimientoComboBox.Text, _
                        lugar:=lugarTextBox.Text, _
                        fecha:=fecha_operacionDateTimePicker.Value, _
                        de:=deTextBox.Text, _
                        acc:=accTextBox.Text, _
                        indicativo:=IndicativoTextBox.Text, _
                        referencias:=referenciasRichTextBox.Text)

                    Dim TASituacion As New bdinfanteriaDataSetTableAdapters.situacionTableAdapter
                    TASituacion.Insert( _
                        operacion:=operacionTextBox.Text, _
                        detalle:=detalleSituacionRichTextBox.Text, _
                        enemigo:=enemigoRichTextBox.Text, _
                        propias_tropas:=propiasTropasRichTextBox.Text, _
                        agregaciones:=agregacionesSituacionRichTextBox.Text, _
                        segregaciones:=segregacionesSituacionRichTextBox.Text)

                    Dim TAMision As New bdinfanteriaDataSetTableAdapters.misionTableAdapter
                    TAMision.Insert( _
                        operacion:=operacionTextBox.Text, _
                        detalle:=misionRichTextBox.Text)

                    Dim TAToe As New bdinfanteriaDataSetTableAdapters.toeTableAdapter
                    TAToe.Insert( _
                        operacion:=operacionTextBox.Text, _
                        oficiales:=oficialesNumericUpDown.Value, _
                        suboficiales:=SuboficialesNumericUpDown.Value, _
                        imp:=impNumericUpDown.Value, _
                        imr:=imrNumericUpDown.Value, _
                        civiles:=CivilesNumericUpDown.Value, _
                        agregaciones:=agregacionesToeTextBox.Text, _
                        segregaciones:=segregacionesToeTextBox.Text)

                    Dim TAEjecucion As New bdinfanteriaDataSetTableAdapters.ejecucionTableAdapter
                    TAEjecucion.Insert( _
                        operacion:=operacionTextBox.Text, _
                        intencion_comandante:=intencionComandanteRichTextBox.Text, _
                        concepto_operacion:=conceptoOperacionRichTextBox.Text, _
                        maniobra:=maniobraRichTextBox.Text, _
                        fuegos:=fuegosRichTextBox.Text, _
                        tareas_maniobra:=tareasManiobraRichTextBox.Text, _
                        tareas_combate:=tareasCombateRichTextBox.Text, _
                        instrucciones_coordinacion:=instruccionesCoordinacionRichTextBox.Text, _
                        instrucciones_juridicas:=instruccionesJuridicasRichTextBox.Text, _
                        uso_fuerza_autorizada:=usoFuerzaRichTextBox.Text)

                    Dim TAServiciosCombate As New bdinfanteriaDataSetTableAdapters.servicios_combateTableAdapter
                    TAServiciosCombate.Insert( _
                        operacion:=operacionTextBox.Text, _
                        clase1:=Clase1RichTextBox.Text, _
                        clase2:=Clase2RichTextBox.Text, _
                        clase3:=Clase3RichTextBox.Text, _
                        clase4:=Clase4RichTextBox.Text, _
                        clase5:=Clase5RichTextBox.Text, _
                        clase6:=Clase6RichTextBox.Text, _
                        evacuaciones_medicas:=evacuacionesMedicasRichTextBox.Text)

                    Dim TAComunicaciones As New bdinfanteriaDataSetTableAdapters.comunicacionesTableAdapter
                    TAComunicaciones.Insert( _
                        operacion:=operacionTextBox.Text, _
                        vhf_7330_cant:=vhf7330NumericUpDown.Value, _
                        vhf_7330_frec:=vhf7330TextBox.Text, _
                        vhf_710_cant:=vhf710NumericUpDown.Value, _
                        vhf_710_frec:=vhf710TextBox.Text, _
                        vhf_930_cant:=vhf930NumericUpDown.Value, _
                        vhf_930_frec:=vhf930TextBox.Text, _
                        vhf_aereo_cant:=vhfAereoNumericUpDown.Value, _
                        vhf_aereo_frec:=vhfAereoTextBox.Text, _
                        vhf_escaner:=vhfEscanerNumericUpDown.Value, _
                        hf_6020_cant:=hf6020NumericUpDown.Value, _
                        hf_6020_frec:=hf6020TextBox.Text, _
                        hf_escaner:=hfEscanerNumericUpDown.Value, _
                        uhf_xts4250_cant:=uhfXTS4250NumericUpDown.Value, _
                        uhf_xts4250_frec:=uhfXTS4250TextBox.Text, _
                        uhf_xtr3000_cant:=uhfXTR3000NumericUpDown.Value, _
                        uhf_xtr3000_frec:=uhfXTR3000TextBox.Text, _
                        uhf_escaner:=uhfEscanerNumericUpDown.Value, _
                        avantel:=AvantelTextBox.Text, _
                        celular:=CelularTextBox.Text, _
                        satelital:=satelitalTextBox.Text, _
                        clave:=ClaveComTextBox.Text, _
                        indicativos:=indicativosRichTextBox.Text)

                    Dim TAAmetralladoras As New bdinfanteriaDataSetTableAdapters.ametralladorasTableAdapter
                    TAAmetralladoras.Insert( _
                        operacion:=operacionTextBox.Text, _
                        m60_estandar:=m60EstandarNumericUpDown.Value, _
                        m60_e4:=m60E4NumericUpDown.Value, _
                        m249:=M249NumericUpDown.Value, _
                        ss77:=ss77NumericUpDown.Value, _
                        punto50:=punto50NumericUpDown.Value, _
                        otras_ametralladoras:=otrasAmetralladorasTextBox.Text)

                    Dim TAFusiles As New bdinfanteriaDataSetTableAdapters.fusilesTableAdapter
                    TAFusiles.Insert( _
                        operacion:=operacionTextBox.Text, _
                        galil_ar:=galil_arNumericUpDown.Value, _
                        galil_ice:=galil_iceNumericUpDown.Value, _
                        m16_a2:=m16_a2NumericUpDown.Value, _
                        m16_m4:=m16_m4NumericUpDown.Value, _
                        m16_a203:=m16_a203NumericUpDown.Value, _
                        otros_fusiles:=otrosFusilesTextBox.Text)

                    Dim TAMorteros As New bdinfanteriaDataSetTableAdapters.morterosTableAdapter
                    TAMorteros.Insert( _
                        operacion:=operacionTextBox.Text, _
                        mc_c370_60mm:=mc_c370_60mmNumericUpDown.Value, _
                        mc_575_60mm:=mc_c575_60mmNumericUpDown.Value, _
                        mc_fms_60mm:=mc_fms_60mmNumericUpDown.Value, _
                        m_brandt_60mm:=m_brandt_60mmNumericUpDown.Value, _
                        otros_morteros:=otrosMorterosTextBox.Text)

                    Dim TAEquiposEspeciales As New bdinfanteriaDataSetTableAdapters.equipos_especialesTableAdapter
                    TAEquiposEspeciales.Insert( _
                        operacion:=operacionTextBox.Text, _
                        visor_nocturno:=visorNocturnoNumericUpDown.Value, _
                        binoculares:=binocularesNumericUpDown.Value, _
                        camara_termica:=camaraTermicaNumericUpDown.Value, _
                        flasmers:=flasmersNumericUpDown.Value, _
                        kit_orientacion_nocturno:=kitOrientacionNocturnoNumericUpDown.Value, _
                        otros_equipos:=otrosEquiposTextBox.Text)

                    Dim TAGranadas As New bdinfanteriaDataSetTableAdapters.granadasTableAdapter
                    TAGranadas.Insert( _
                        operacion:=operacionTextBox.Text, _
                        mano:=manoNumericUpDown.Value, _
                        humo:=humoNumericUpDown.Value, _
                        lacrimogena:=lacrimogenaNumericUpDown.Value, _
                        otras_granadas:=otrasGranadasTextBox.Text)

                    Dim TALanzagranadas As New bdinfanteriaDataSetTableAdapters.lanzagranadasTableAdapter
                    TALanzagranadas.Insert( _
                        operacion:=operacionTextBox.Text, _
                        mgl:=mglNumericUpDown.Value, _
                        mk:=mkNumericUpDown.Value, _
                        m79:=m79NumericUpDown.Value, _
                        otros_lanzagranadas:=otrosLanzagranadasTextBox.Text)

                    Dim TAPersonal As New bdinfanteriaDataSetTableAdapters.personalTableAdapter
                    TAPersonal.Insert( _
                        operacion:=operacionTextBox.Text, _
                        detalle:=personalRichTextBox.Text)

                    Dim TACoordenadas As New bdinfanteriaDataSetTableAdapters.coordenadasTableAdapter
                    TACoordenadas.Insert( _
                        operacion:=operacionTextBox.Text, _
                        latitud1:=getLatitud(gradosLat1NumericUpDown.Value, minutosLat1NumericUpDown.Value, segundosLat1NumericUpDown.Value), _
                        longitud1:=getLongitud(gradosLgn1NumericUpDown.Value, minutosLgn1NumericUpDown.Value, segundosLgn1NumericUpDown.Value), _
                        latitud3:=getLatitud(gradosLat3NumericUpDown.Value, minutosLat3NumericUpDown.Value, segundosLat3NumericUpDown.Value), _
                        longitud3:=getLongitud(gradosLng3NumericUpDown.Value, minutosLng3NumericUpDown.Value, segundosLng3NumericUpDown.Value))

                    Dim TAFirmas As New bdinfanteriaDataSetTableAdapters.firmasTableAdapter
                    TAFirmas.Insert( _
                        operacion:=operacionTextBox.Text, _
                        autoriza:=autorizaTextBox.Text, _
                        autentica:=autenticaTextBox.Text, _
                        recibe:=recibeTextBox.Text, _
                        distribucion:=distribucionRichTextBox.Text)

                    CopiarYRegistrarAnexos()

                    MsgBox("Datos de operación guardados satisfactoriamente", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("No se puede guardar la operación, aún faltan datos por diligenciar", MsgBoxStyle.Information)
                End If

                tx.Complete()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarTodoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarTodoToolStripMenuItem.Click
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

    Private Sub operacionTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles operacionTextBox.Validating
        If operacionTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(operacionTextBox, "Introduzca un código para la operación")
        Else
            ErrorProvider1.SetError(operacionTextBox, Nothing)
        End If
    End Sub

    Private Sub nombre_operacionTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles nombre_operacionTextBox.Validating
        If nombre_operacionTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(nombre_operacionTextBox, "Introduzca un nombre para la operación")
        Else
            ErrorProvider1.SetError(nombre_operacionTextBox, Nothing)
        End If
    End Sub

    ''' <summary>
    ''' Oculta todos los groups de operaciones.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ocultarGrupos()
        operacionGroupBox.Visible = False
        situacionGroupBox.Visible = False
        misionGroupBox.Visible = False
        coordenadasGroupBox.Visible = False
        Ejecucion1GroupBox.Visible = False
        Ejecucion2GroupBox.Visible = False
        juridicasGroupBox.Visible = False
        serviciosCombateGroupBox.Visible = False
        comunicacionesGroupBox.Visible = False
        armamentoGroupBox.Visible = False
        anexosGroupBox.Visible = False
        personalGroupBox.Visible = False
        firmasGroupBox.Visible = False
    End Sub

    Private Sub operacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperacionesToolStripMenuItem.Click, atras11LinkLabel.Click
        ocultarGrupos()
        operacionGroupBox.Visible = True
    End Sub

    Private Sub situacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles situacionToolStripMenuItem.Click, siguiente1LinkLabel.Click, atras10LinkLabel.Click
        ocultarGrupos()
        situacionGroupBox.Visible = True
    End Sub

    Private Sub misionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles misionToolStripMenuItem.Click, siguiente2LinkLabel.Click, atras9LinkLabel.Click
        ocultarGrupos()
        misionGroupBox.Visible = True
    End Sub

    Private Sub CoordenadasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CoordenadasToolStripMenuItem.Click, siguiente3LinkLabel.Click, atras8LinkLabel.Click
        ocultarGrupos()
        coordenadasGroupBox.Visible = True
    End Sub

    Private Function camposDiligenciados() As Boolean
        If operacionTextBox.Text.Length = 0 Or
            nombre_operacionTextBox.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Ejecucion1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion1ToolStripMenuItem.Click, siguiente4LinkLabel.Click, atras7LinkLabel.Click
        ocultarGrupos()
        Ejecucion1GroupBox.Visible = True
    End Sub

    Private Sub Ejecucion2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion2ToolStripMenuItem.Click, siguiente5LinkLabel.Click, LinkLabel1.Click
        ocultarGrupos()
        Ejecucion2GroupBox.Visible = True
    End Sub

    Private Sub juridicasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles juridicasToolStripMenuItem.Click, siguiente6LinkLabel.Click, atras6LinkLabel.Click
        ocultarGrupos()
        juridicasGroupBox.Visible = True
    End Sub

    Private Sub TarjetaRojaRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TarjetaRojaRadioButton.CheckedChanged
        If TarjetaRojaRadioButton.Checked Then
            TarjetaAzulRadioButton.Checked = False
            usoFuerzaRichTextBox.Text = "1. Podrá hacer uso de la fuerza contra un objetivo militar o blanco lícito, siempre y cuando:" & vbCrLf & _
"- Esté enmarcado en una orden de operaciones; y" & vbCrLf & _
"- Lo identifique como el objetivo militar o blanco lícito, al momento de hacer uso de las armas." & vbCrLf & vbCrLf & _
"2. Cuando las circunstancias lo permitan, favorezca las desmovilizaciones y las capturas sobre las muertes en combate." & vbCrLf & vbCrLf & _
"3. Haga uso de las armas en forma dirigida y no indiscriminada, reduciendo al máximo daños contra bienes y personas protegidas." & vbCrLf & vbCrLf & _
"4. Siempre podrá hacer uso de las armas en legítima defensa cuando esté en peligro su vida o la de terceros."
        End If
    End Sub

    Private Sub TarjetaAzulRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TarjetaAzulRadioButton.CheckedChanged
        If TarjetaAzulRadioButton.Checked Then
            TarjetaRojaRadioButton.Checked = False
            usoFuerzaRichTextBox.Text = "1. Haga uso de la fuerza como última opción." & vbCrLf & vbCrLf & _
"2. Identifíquese como miembro de las FFMM." & vbCrLf & vbCrLf & _
"3. De una clara advertencia de su intención de emplear armas de fuego." & vbCrLf & vbCrLf & _
"4. Haga uso de su arma de manera proporcional a la amenaza que está enfrentando." & vbCrLf & vbCrLf & _
"5. Siempre podrá hacer uso de su arma en legítima defensa cuando esté en peligro su vida o la de terceros."
        End If
    End Sub

    Private Sub ServiciosCombateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles serviciosCombateToolStripMenuItem.Click, siguiente7LinkLabel.Click, atras5LinkLabel.Click
        ocultarGrupos()
        serviciosCombateGroupBox.Visible = True
    End Sub

    Private Sub ComunicacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComunicacionesToolStripMenuItem.Click, siguiente8LinkLabel.Click, atras4LinkLabel.Click
        ocultarGrupos()
        comunicacionesGroupBox.Visible = True
    End Sub

    Private Sub ArmamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArmamentoToolStripMenuItem.Click, siguiente9LinkLabel.Click, atras3LinkLabel.Click
        ocultarGrupos()
        armamentoGroupBox.Visible = True
    End Sub

    Private Sub AgregarAnexoButton_Click(sender As System.Object, e As System.EventArgs) Handles agregarAnexoButton.Click
        Try
            OpenFileDialog1.ShowDialog()
            If YaSeEncuentra(OpenFileDialog1.SafeFileNames(0)) Then
                MsgBox("Ya existe el archivo " & OpenFileDialog1.SafeFileNames(0) & " en la lista de anexos.", MsgBoxStyle.Information)
            Else
                anexosDataGridView.Rows.Add(OpenFileDialog1.SafeFileNames(0), OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QuitarButton_Click(sender As System.Object, e As System.EventArgs) Handles quitarButton.Click
        Try
            If anexosDataGridView.SelectedRows.Count > 0 Then
                anexosDataGridView.Rows.Remove(anexosDataGridView.SelectedRows(0))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Devuelve True si el nombre del archivo ya está en el DataGrid AnexosDatagridView.
    ''' </summary>
    ''' <param name="nombreArchivo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function YaSeEncuentra(nombreArchivo As String) As Boolean
        For Each fila As DataGridViewRow In anexosDataGridView.Rows
            If fila.Cells("nombreArchivo").Value = nombreArchivo Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Mueve todos los archivos en la lista de AnexosDataGridView a la carpeta de la operación.
    ''' Y Guarda el registro de cada anexo en la base de datos.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CopiarYRegistrarAnexos()
        Dim carpetaAnexos As String = My.Application.Info.DirectoryPath & "\anexos\" & operacionTextBox.Text & "\"
        If Not Directory.Exists(carpetaAnexos) Then
            Directory.CreateDirectory(carpetaAnexos)
        End If

        For Each fila As DataGridViewRow In anexosDataGridView.Rows
            My.Computer.FileSystem.CopyFile(fila.Cells("ruta").Value, carpetaAnexos & fila.Cells("nombreArchivo").Value, UIOption.AllDialogs, UICancelOption.ThrowException)

            Dim TAAnexos As New bdinfanteriaDataSetTableAdapters.anexosTableAdapter
            TAAnexos.Insert( _
                operacion:=operacionTextBox.Text, _
                nombre:=fila.Cells("nombreArchivo").Value, _
                ruta:=carpetaAnexos & fila.Cells("nombreArchivo").Value)
        Next
    End Sub

    Private Sub AnexosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnexosToolStripMenuItem.Click, siguiente11LinkLabel.Click, atras1LinkLabel.Click
        ocultarGrupos()
        anexosGroupBox.Visible = True
    End Sub

    Private Sub FirmasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirmasToolStripMenuItem.Click, siguiente12LinkLabel.Click
        ocultarGrupos()
        firmasGroupBox.Visible = True
    End Sub

    Private Sub OperacionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ocultarGrupos()
        operacionGroupBox.Visible = True
        fecha_operacionDateTimePicker.Value = Now
        procedimientoComboBox.SelectedIndex = 0
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PersonalToolStripMenuItem.Click, siguiente10LinkLabel.Click, atras2LinkLabel.Click
        ocultarGrupos()
        personalGroupBox.Visible = True
    End Sub
End Class