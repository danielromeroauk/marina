Imports System.Transactions
Imports Marina.Module1
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class OperacionForm

    'TODO: 
    'Size del group: 950, 476
    'Location Group: 5, 12

    Private Sub GuardarTodoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarTodoToolStripMenuItem.Click
        Try
            Using tx As New TransactionScope

                If Me.Validate And Me.camposDiligenciados Then

                    Dim TAOperacion As New bdmarinaDataSetTableAdapters.operacionesTableAdapter
                    TAOperacion.Insert(OperacionTextBox.Text, Nombre_operacionTextBox.Text, ProcedimientoTextBox.Text, Fecha_operacionDateTimePicker.Value, Autoriza_deTextBox.Text, Comandante_operacionTextBox.Text, IndicativoTextBox.Text, ReferenciasRichTextBox.Text, SituacionRichTextBox.Text, Propias_tropasRichTextBox.Text, MisionRichTextBox.Text)

                    Dim TAToe As New bdmarinaDataSetTableAdapters.toeTableAdapter
                    TAToe.Insert(OperacionTextBox.Text, OficialesNumericUpDown.Value, SuboficialesNumericUpDown.Value, impNumericUpDown.Value, imrNumericUpDown.Value, CivilesNumericUpDown.Value, AgregacionesRichTextBox.Text)

                    Dim TACoordenadas As New bdmarinaDataSetTableAdapters.coordenadasTableAdapter
                    TACoordenadas.Insert(OperacionTextBox.Text, _
                                        getLatitud(GradosLat1NumericUpDown.Value, MinutosLat1NumericUpDown.Value, SegundosLat1NumericUpDown.Value), _
                                        getLongitud(GradosLgn1NumericUpDown.Value, MinutosLgn1NumericUpDown.Value, SegundosLgn1NumericUpDown.Value), _
                                        getLatitud(GradosLat3NumericUpDown.Value, MinutosLat3NumericUpDown.Value, SegundosLat3NumericUpDown.Value), _
                                        getLongitud(GradosLng3NumericUpDown.Value, MinutosLng3NumericUpDown.Value, SegundosLng3NumericUpDown.Value))

                    Dim TAEjecucion As New bdmarinaDataSetTableAdapters.ejecucionTableAdapter
                    TAEjecucion.Insert(OperacionTextBox.Text, _
                                       IntencionComandanteRichTextBox.Text, _
                                       ConceptoRichTextBox.Text, _
                                       ManiobraRichTextBox.Text, _
                                       FuegosRichTextBox.Text, _
                                       TareasManiobraRichTextBox.Text, _
                                       TareasCombateRichTextBox.Text, _
                                       InstruccionesCoordinacionRichTextBox.Text, _
                                       NivelHostilidadRichTextBox.Text, _
                                       MarcoJuridicoRichTextBox.Text, _
                                       PrincipiosRichTextBox.Text, _
                                       UsoFuerzaRichTextBox.Text, _
                                       InstruccionesEspecialesRichTextBox.Text)

                    Dim TAAbastecimientos As New bdmarinaDataSetTableAdapters.abastecimientosTableAdapter
                    TAAbastecimientos.Insert(OperacionTextBox.Text, _
                                             Clase1RichTextBox.Text, _
                                             Clase2RichTextBox.Text, _
                                             Clase3RichTextBox.Text, _
                                             Clase4RichTextBox.Text, _
                                             Clase5RichTextBox.Text, _
                                             Clase6RichTextBox.Text, _
                                             EvacuacionesMedicasRichTextBox.Text)

                    Dim TAComunicaciones As New bdmarinaDataSetTableAdapters.comunicacionesTableAdapter
                    TAComunicaciones.Insert(OperacionTextBox.Text, _
                                            vhf7330NumericUpDown.Value, _
                                            vhf710NumericUpDown.Value, _
                                            vhf930NumericUpDown.Value, _
                                            vhfAereoNumericUpDown.Value, _
                                            vhfEscanerNumericUpDown.Value, _
                                            hf6020NumericUpDown.Value, _
                                            hfEscanerNumericUpDown.Value, _
                                            uhfXTS4250NumericUpDown.Value, _
                                            uhfXTR3000NumericUpDown.Value, _
                                            uhfEscanerNumericUpDown.Value, _
                                            AvantelTextBox.Text, _
                                            CelularTextBox.Text, _
                                            SatelitalTextBox.Text, _
                                            ClaveComTextBox.Text, _
                                            ComplementosTextBox.Text)

                    Dim TAAmetralladoras As New bdmarinaDataSetTableAdapters.ametralladorasTableAdapter
                    TAAmetralladoras.Insert(OperacionTextBox.Text, _
                                            m60EstandarNumericUpDown.Value, _
                                            m60E4NumericUpDown.Value, _
                                            M249NumericUpDown.Value, _
                                            ss77NumericUpDown.Value, _
                                            Punto50NumericUpDown.Value, _
                                            OtrasAmetralladorasTextBox.Text)

                    Dim TAFusiles As New bdmarinaDataSetTableAdapters.fusilesTableAdapter
                    TAFusiles.Insert(OperacionTextBox.Text, _
                                     GalilNumericUpDown.Value, _
                                     m16NumericUpDown.Value, _
                                     OtrosFusilesTextBox.Text)

                    Dim TAEquiposEspeciales As New bdmarinaDataSetTableAdapters.equipos_especialesTableAdapter
                    TAEquiposEspeciales.Insert(OperacionTextBox.Text, _
                                               VisorNocturnoNumericUpDown.Value, _
                                               BinocularesNumericUpDown.Value, _
                                               CamaraTermicaNumericUpDown.Value, _
                                               FlasmersNumericUpDown.Value, _
                                               KitOrientacionNocturnoNumericUpDown.Value, _
                                               OtrosEquiposTextBox.Text)

                    Dim TAGranadas As New bdmarinaDataSetTableAdapters.granadasTableAdapter
                    TAGranadas.Insert(OperacionTextBox.Text, _
                                      ManoNumericUpDown.Value, _
                                      HumoNumericUpDown.Value, _
                                      LacrimogenoNumericUpDown.Value, _
                                      OtrasGranadasTextBox.Text)

                    Dim TALanzagranadas As New bdmarinaDataSetTableAdapters.lanzagranadasTableAdapter
                    TALanzagranadas.Insert(OperacionTextBox.Text, _
                                           MGLNumericUpDown.Value, _
                                           MKNumericUpDown.Value, _
                                           M79NumericUpDown.Value, _
                                           M203NumericUpDown.Value)

                    Dim TAMorteros As New bdmarinaDataSetTableAdapters.morterosTableAdapter
                    TAMorteros.Insert(OperacionTextBox.Text, _
                                      mc_c370_60mmNumericUpDown.Value, _
                                      mc_c575_60mmNumericUpDown.Value, _
                                      mc_fms_60mmNumericUpDown.Value, _
                                      m_brandt_60mmNumericUpDown.Value, _
                                      OtrosMorterosTextBox.Text)

                    Dim TAFirmas As New bdmarinaDataSetTableAdapters.firmasTableAdapter
                    TAFirmas.Insert(OperacionTextBox.Text, _
                                    AutorizaRichTextBox.Text, _
                                    AutenticaRichTextBox.Text, _
                                    RecibeRichTextBox.Text)

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

    Private Sub OperacionTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If OperacionTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(OperacionTextBox, "Introduzca un código para la operación")
        Else
            ErrorProvider1.SetError(OperacionTextBox, Nothing)
        End If
    End Sub

    Private Sub Nombre_operacionTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If Nombre_operacionTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(Nombre_operacionTextBox, "Introduzca un nombre para la operación")
        Else
            ErrorProvider1.SetError(Nombre_operacionTextBox, Nothing)
        End If
    End Sub

    Private Sub ProcedimientoTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If ProcedimientoTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(ProcedimientoTextBox, "Introduzca el procedimiento de la operación")
        Else
            ErrorProvider1.SetError(ProcedimientoTextBox, Nothing)
        End If
    End Sub

    Private Sub Autoriza_deTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If Autoriza_deTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(Autoriza_deTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(Autoriza_deTextBox, Nothing)
        End If
    End Sub

    Private Sub Comandante_operacionTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If Comandante_operacionTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(Comandante_operacionTextBox, "Introduzca el comandante de la operación")
        Else
            ErrorProvider1.SetError(Comandante_operacionTextBox, Nothing)
        End If
    End Sub

    Private Sub IndicativoTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If IndicativoTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(IndicativoTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(IndicativoTextBox, Nothing)
        End If
    End Sub

    Private Sub ReferenciasRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If ReferenciasRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(ReferenciasRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(ReferenciasRichTextBox, Nothing)
        End If
    End Sub

    Private Sub SituacionRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
        If SituacionRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(SituacionRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(SituacionRichTextBox, Nothing)
        End If
    End Sub

    Private Sub Propias_tropasRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles Propias_tropasRichTextBox.Validating
        If Propias_tropasRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(Propias_tropasRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(Propias_tropasRichTextBox, Nothing)
        End If
    End Sub

    Private Sub MisionRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles MisionRichTextBox.Validating
        If MisionRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(MisionRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(MisionRichTextBox, Nothing)
        End If
    End Sub

    ''' <summary>
    ''' Oculta todos los groups de operaciones.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ocultarGrupos()
        Operaciones1GroupBox.Visible = False
        Operaciones2GroupBox.Visible = False
        ToeGroupBox.Visible = False
        CoordenadasGroupBox.Visible = False
        Ejecucion1GroupBox.Visible = False
        Ejecucion2GroupBox.Visible = False
        Ejecucion3GroupBox.Visible = False
        Ejecucion4GroupBox.Visible = False
        Ejecucion5GroupBox.Visible = False
        Ejecucion6GroupBox.Visible = False
        AbastecimientosGroupBox.Visible = False
        ComunicacionesGroupBox.Visible = False
        ArmamentoGroupBox.Visible = False
        AnexosGroupBox.Visible = False
        FirmasGroupBox.Visible = False
    End Sub

    Private Sub Operaciones1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Operaciones1ToolStripMenuItem.Click, Operaciones1LinkLabel.Click
        ocultarGrupos()
        Operaciones1GroupBox.Visible = True
    End Sub

    Private Sub Operaciones2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Operaciones2ToolStripMenuItem.Click, Operaciones2LinkLabel.Click, LinkLabel1.Click
        ocultarGrupos()
        Operaciones2GroupBox.Visible = True
    End Sub

    Private Sub TOEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TOEToolStripMenuItem.Click, toeLinkLabel.Click, LinkLabel3.Click
        ocultarGrupos()
        ToeGroupBox.Visible = True
    End Sub

    Private Sub CoordenadasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CoordenadasToolStripMenuItem.Click, LinkLabel2.Click, LinkLabel5.Click
        ocultarGrupos()
        CoordenadasGroupBox.Visible = True
    End Sub

    Private Function camposDiligenciados() As Boolean
        If OperacionTextBox.Text.Length = 0 Or
            Nombre_operacionTextBox.Text.Length = 0 Or
            ProcedimientoTextBox.Text.Length = 0 Or
            Autoriza_deTextBox.Text.Length = 0 Or
            Comandante_operacionTextBox.Text.Length = 0 Or
            IndicativoTextBox.Text.Length = 0 Or
            ReferenciasRichTextBox.Text.Length = 0 Or
            SituacionRichTextBox.Text.Length = 0 Or
            Propias_tropasRichTextBox.Text.Length = 0 Or
            MisionRichTextBox.Text.Length = 0 Or
            IntencionComandanteRichTextBox.Text.Length = 0 Or
            ConceptoRichTextBox.Text.Length = 0 Or
            ManiobraRichTextBox.Text.Length = 0 Or
            FuegosRichTextBox.Text.Length = 0 Or
            TareasManiobraRichTextBox.Text.Length = 0 Or
            TareasCombateRichTextBox.Text.Length = 0 Or
            InstruccionesCoordinacionRichTextBox.Text.Length = 0 Or
            NivelHostilidadRichTextBox.Text.Length = 0 Or
            MarcoJuridicoRichTextBox.Text.Length = 0 Or
            PrincipiosRichTextBox.Text.Length = 0 Or
            UsoFuerzaRichTextBox.Text.Length = 0 Or
            InstruccionesEspecialesRichTextBox.Text.Length = 0 Or
            AutorizaRichTextBox.Text.Length = 0 Or
            AutenticaRichTextBox.Text.Length = 0 Or
            RecibeRichTextBox.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Ejecucion1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion1ToolStripMenuItem.Click, LinkLabel4.Click, LinkLabel7.Click
        ocultarGrupos()
        Ejecucion1GroupBox.Visible = True
    End Sub

    Private Sub Ejecucion2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion2ToolStripMenuItem.Click, LinkLabel9.Click, LinkLabel6.Click
        ocultarGrupos()
        Ejecucion2GroupBox.Visible = True
    End Sub

    Private Sub Ejecucion3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion3ToolStripMenuItem.Click, LinkLabel8.Click, LinkLabel11.Click
        ocultarGrupos()
        Ejecucion3GroupBox.Visible = True
    End Sub

    Private Sub Ejecucion4ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion4ToolStripMenuItem.Click, LinkLabel13.Click, LinkLabel10.Click
        ocultarGrupos()
        Ejecucion4GroupBox.Visible = True
    End Sub

    Private Sub Ejecucion5ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion5ToolStripMenuItem.Click, LinkLabel15.Click, LinkLabel12.Click
        ocultarGrupos()
        Ejecucion5GroupBox.Visible = True
    End Sub

    Private Sub Ejecucion6ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Ejecucion6ToolStripMenuItem.Click, LinkLabel17.Click, LinkLabel14.Click
        ocultarGrupos()
        Ejecucion6GroupBox.Visible = True
    End Sub

    Private Sub TarjetaRojaRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TarjetaRojaRadioButton.CheckedChanged
        If TarjetaRojaRadioButton.Checked Then
            TarjetaAzulRadioButton.Checked = False
            UsoFuerzaRichTextBox.Text = "1. Podrá hacer uso de la fuerza contra un objetivo militar o blanco lícito, siempre y cuando:" & vbCrLf & _
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
            UsoFuerzaRichTextBox.Text = "1. Haga uso de la fuerza como última opción." & vbCrLf & vbCrLf & _
"2. Identifíquese como miembro de las FFMM." & vbCrLf & vbCrLf & _
"3. De una clara advertencia de su intención de emplear armas de fuego." & vbCrLf & vbCrLf & _
"4. Haga uso de su arma de manera proporcional a la amenaza que está enfrentando." & vbCrLf & vbCrLf & _
"5. Siempre podrá hacer uso de su arma en legítima defensa cuando esté en peligro su vida o la de terceros."
        End If
    End Sub

    Private Sub IntencionComandanteRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles IntencionComandanteRichTextBox.Validating
        If IntencionComandanteRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(IntencionComandanteRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(IntencionComandanteRichTextBox, Nothing)
        End If
    End Sub

    Private Sub ConceptoRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ConceptoRichTextBox.Validating
        If ConceptoRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(ConceptoRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(ConceptoRichTextBox, Nothing)
        End If
    End Sub

    Private Sub ManiobraRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ManiobraRichTextBox.Validating
        If ManiobraRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(ManiobraRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(ManiobraRichTextBox, Nothing)
        End If
    End Sub

    Private Sub FuegosRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles FuegosRichTextBox.Validating
        If FuegosRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(FuegosRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(FuegosRichTextBox, Nothing)
        End If
    End Sub

    Private Sub TareasManiobraRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TareasManiobraRichTextBox.Validating
        If TareasManiobraRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(TareasManiobraRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(TareasManiobraRichTextBox, Nothing)
        End If
    End Sub

    Private Sub TareasCombateRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TareasCombateRichTextBox.Validating
        If TareasCombateRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(TareasCombateRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(TareasCombateRichTextBox, Nothing)
        End If
    End Sub

    Private Sub InstruccionesCoordinacionRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles InstruccionesCoordinacionRichTextBox.Validating
        If InstruccionesCoordinacionRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(InstruccionesCoordinacionRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(InstruccionesCoordinacionRichTextBox, Nothing)
        End If
    End Sub

    Private Sub NivelHostilidadRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles NivelHostilidadRichTextBox.Validating
        If NivelHostilidadRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(NivelHostilidadRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(NivelHostilidadRichTextBox, Nothing)
        End If
    End Sub

    Private Sub MarcoJuridicoRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles MarcoJuridicoRichTextBox.Validating
        If MarcoJuridicoRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(MarcoJuridicoRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(MarcoJuridicoRichTextBox, Nothing)
        End If
    End Sub

    Private Sub PrincipiosRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles PrincipiosRichTextBox.Validating
        If PrincipiosRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(PrincipiosRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(PrincipiosRichTextBox, Nothing)
        End If
    End Sub

    Private Sub UsoFuerzaRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles UsoFuerzaRichTextBox.Validating
        If UsoFuerzaRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(UsoFuerzaRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(UsoFuerzaRichTextBox, Nothing)
        End If
    End Sub

    Private Sub InstruccionesEspecialesRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles InstruccionesEspecialesRichTextBox.Validating
        If InstruccionesEspecialesRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(InstruccionesEspecialesRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(InstruccionesEspecialesRichTextBox, Nothing)
        End If
    End Sub

    Private Sub AbastecimientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbastecimientosToolStripMenuItem.Click, LinkLabel19.Click, LinkLabel16.Click
        ocultarGrupos()
        AbastecimientosGroupBox.Visible = True
    End Sub

    Private Sub ComunicacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComunicacionesToolStripMenuItem.Click, LinkLabel21.Click, LinkLabel18.Click
        ocultarGrupos()
        ComunicacionesGroupBox.Visible = True
    End Sub

    Private Sub ArmamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArmamentoToolStripMenuItem.Click, LinkLabel23.Click, LinkLabel20.Click
        ocultarGrupos()
        ArmamentoGroupBox.Visible = True
    End Sub

    Private Sub AutorizaRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles AutorizaRichTextBox.Validating
        If AutorizaRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(AutorizaRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(AutorizaRichTextBox, Nothing)
        End If
    End Sub

    Private Sub AutenticaRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles AutenticaRichTextBox.Validating
        If AutenticaRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(AutenticaRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(AutenticaRichTextBox, Nothing)
        End If
    End Sub

    Private Sub RecibeRichTextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles RecibeRichTextBox.Validating
        If RecibeRichTextBox.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(RecibeRichTextBox, "Este campo no puede estar vacío")
        Else
            ErrorProvider1.SetError(RecibeRichTextBox, Nothing)
        End If
    End Sub

    Private Sub AgregarAnexoButton_Click(sender As System.Object, e As System.EventArgs) Handles AgregarAnexoButton.Click
        Try
            OpenFileDialog1.ShowDialog()
            If YaSeEncuentra(OpenFileDialog1.SafeFileNames(0)) Then
                MsgBox("Ya existe el archivo " & OpenFileDialog1.SafeFileNames(0) & " en la lista de anexos.", MsgBoxStyle.Information)
            Else
                AnexosDataGridView.Rows.Add(OpenFileDialog1.SafeFileNames(0), OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QuitarButton_Click(sender As System.Object, e As System.EventArgs) Handles QuitarButton.Click
        Try
            If AnexosDataGridView.SelectedRows.Count > 0 Then
                AnexosDataGridView.Rows.Remove(AnexosDataGridView.SelectedRows(0))
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
        For Each fila As DataGridViewRow In AnexosDataGridView.Rows
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
        Dim carpetaAnexos As String = My.Application.Info.DirectoryPath & "\anexos\" & OperacionTextBox.Text & "\"
        If Not Directory.Exists(carpetaAnexos) Then
            Directory.CreateDirectory(carpetaAnexos)
        End If

        For Each fila As DataGridViewRow In AnexosDataGridView.Rows
            My.Computer.FileSystem.CopyFile(fila.Cells("ruta").Value, carpetaAnexos & fila.Cells("nombreArchivo").Value, UIOption.AllDialogs, UICancelOption.ThrowException)

            Dim TAAnexos As New bdmarinaDataSetTableAdapters.anexosTableAdapter
            TAAnexos.Insert(operacion:=OperacionTextBox.Text, _
                            nombre:=fila.Cells("nombreArchivo").Value, _
                            ruta:=carpetaAnexos & fila.Cells("nombreArchivo").Value)
        Next
    End Sub

    Private Sub AnexosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnexosToolStripMenuItem.Click, LinkLabel25.Click, LinkLabel22.Click
        ocultarGrupos()
        AnexosGroupBox.Visible = True
    End Sub

    Private Sub FirmasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FirmasToolStripMenuItem.Click, LinkLabel24.Click
        ocultarGrupos()
        FirmasGroupBox.Visible = True
    End Sub

    Private Sub OperacionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ocultarGrupos()
        Operaciones1GroupBox.Visible = True
        Fecha_operacionDateTimePicker.Value = Now
    End Sub

End Class