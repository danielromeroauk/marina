<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperacionForm
    Inherits PlantillaForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim operacionLabel As System.Windows.Forms.Label
        Dim nombre_operacionLabel As System.Windows.Forms.Label
        Dim procedimientoLabel As System.Windows.Forms.Label
        Dim fecha_operacionLabel As System.Windows.Forms.Label
        Dim Autoriza_deLabel As System.Windows.Forms.Label
        Dim Comandante_operacionLabel As System.Windows.Forms.Label
        Dim IndicativoLabel As System.Windows.Forms.Label
        Dim referenciasLabel As System.Windows.Forms.Label
        Dim detalleSituacionLabel As System.Windows.Forms.Label
        Dim enemigoLabel As System.Windows.Forms.Label
        Dim autorizaLabel As System.Windows.Forms.Label
        Dim autenticaLabel As System.Windows.Forms.Label
        Dim recibeLabel As System.Windows.Forms.Label
        Dim lugarLabel As System.Windows.Forms.Label
        Dim propiasTropasLabel As System.Windows.Forms.Label
        Dim segregacionesSituacionLabel As System.Windows.Forms.Label
        Dim agregacionesSituacionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperacionForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.operacionTextBox = New System.Windows.Forms.TextBox()
        Me.nombre_operacionTextBox = New System.Windows.Forms.TextBox()
        Me.deTextBox = New System.Windows.Forms.TextBox()
        Me.segundosLgn1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.segundosLat1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.segundosLng3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.segundosLat3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.situacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.misionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoordenadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjecucionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.juridicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.serviciosCombateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComunicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArmamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnexosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.operacionGroupBox = New System.Windows.Forms.GroupBox()
        Me.siguiente1LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.lugarTextBox = New System.Windows.Forms.TextBox()
        Me.procedimientoComboBox = New System.Windows.Forms.ComboBox()
        Me.fecha_operacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.accTextBox = New System.Windows.Forms.TextBox()
        Me.IndicativoTextBox = New System.Windows.Forms.TextBox()
        Me.referenciasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.misionGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras10LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente3LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.toeGroupBox = New System.Windows.Forms.GroupBox()
        Me.segregacionesToeTextBox = New System.Windows.Forms.TextBox()
        Me.segregacionesToeLabel = New System.Windows.Forms.Label()
        Me.agregacionesToeTextBox = New System.Windows.Forms.TextBox()
        Me.agregacionesToeLabel = New System.Windows.Forms.Label()
        Me.oficialesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.oficialesLabel = New System.Windows.Forms.Label()
        Me.CivilesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SuboficialesLabel = New System.Windows.Forms.Label()
        Me.CivilesLabel = New System.Windows.Forms.Label()
        Me.SuboficialesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.imrNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.impLabel = New System.Windows.Forms.Label()
        Me.imrLabel = New System.Windows.Forms.Label()
        Me.impNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.coordenadasGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras9LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente4LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.punto3Label = New System.Windows.Forms.Label()
        Me.punto3TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.minutosLng3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.gradosLng3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.latitud3Label = New System.Windows.Forms.Label()
        Me.gradosLat3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.grados3Label = New System.Windows.Forms.Label()
        Me.minutos3Label = New System.Windows.Forms.Label()
        Me.segundos3Label = New System.Windows.Forms.Label()
        Me.minutosLat3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.longitud3Label = New System.Windows.Forms.Label()
        Me.punto1Label = New System.Windows.Forms.Label()
        Me.punto1TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.minutosLgn1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.gradosLgn1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.latitud1Label = New System.Windows.Forms.Label()
        Me.gradosLat1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.grados1Label = New System.Windows.Forms.Label()
        Me.minutos1Label = New System.Windows.Forms.Label()
        Me.segundos1Label = New System.Windows.Forms.Label()
        Me.minutosLat1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.longitud1Label = New System.Windows.Forms.Label()
        Me.Ejecucion1GroupBox = New System.Windows.Forms.GroupBox()
        Me.atras8LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente5LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.conceptoOperacionGroupBox = New System.Windows.Forms.GroupBox()
        Me.fuegosLabel = New System.Windows.Forms.Label()
        Me.maniobraLabel = New System.Windows.Forms.Label()
        Me.intencionComandanteLabel = New System.Windows.Forms.Label()
        Me.Ejecucion2GroupBox = New System.Windows.Forms.GroupBox()
        Me.atras7LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente6LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.instruccionesCoordinacionLabel = New System.Windows.Forms.Label()
        Me.tareasCombateLabel = New System.Windows.Forms.Label()
        Me.tareasManiobraLabel = New System.Windows.Forms.Label()
        Me.juridicasGroupBox = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.siguiente7LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TarjetaAzulRadioButton = New System.Windows.Forms.RadioButton()
        Me.TarjetaRojaRadioButton = New System.Windows.Forms.RadioButton()
        Me.instruccionesJuridicasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.instruccionesJuridicasLabel = New System.Windows.Forms.Label()
        Me.usoFuerzaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.UsoFuerzaLabel = New System.Windows.Forms.Label()
        Me.serviciosCombateGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras6LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente8LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.evacuacionesMedicasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.evacuacionesMedicasLabel = New System.Windows.Forms.Label()
        Me.Clase6RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Clase6Label = New System.Windows.Forms.Label()
        Me.Clase5RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Clase5Label = New System.Windows.Forms.Label()
        Me.Clase4RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Clase4Label = New System.Windows.Forms.Label()
        Me.Clase3RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Clase3Label = New System.Windows.Forms.Label()
        Me.Clase2RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Clase2Label = New System.Windows.Forms.Label()
        Me.Clase1RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Clase1Label = New System.Windows.Forms.Label()
        Me.comunicacionesGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras5LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente9LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.indicativosGroupBox = New System.Windows.Forms.GroupBox()
        Me.otrosComGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClaveComTextBox = New System.Windows.Forms.TextBox()
        Me.satelitalTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.AvantelTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveLabel = New System.Windows.Forms.Label()
        Me.satelitalLabel = New System.Windows.Forms.Label()
        Me.CelularLabel = New System.Windows.Forms.Label()
        Me.AvantelLabel = New System.Windows.Forms.Label()
        Me.UHFGroupBox = New System.Windows.Forms.GroupBox()
        Me.uhfCantidadLabel = New System.Windows.Forms.Label()
        Me.uhfXTR3000TextBox = New System.Windows.Forms.TextBox()
        Me.uhfFrecuenciaLabel = New System.Windows.Forms.Label()
        Me.uhfXTS4250TextBox = New System.Windows.Forms.TextBox()
        Me.uhfEscanerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.uhfEscanerLabel = New System.Windows.Forms.Label()
        Me.uhfXTR3000NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.uhfXTR3000Label = New System.Windows.Forms.Label()
        Me.uhfXTS4250NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.uhfXTS4250Label = New System.Windows.Forms.Label()
        Me.hfGroupBox = New System.Windows.Forms.GroupBox()
        Me.hfCantidadLabel = New System.Windows.Forms.Label()
        Me.hfFrecuenciaLabel = New System.Windows.Forms.Label()
        Me.hf6020TextBox = New System.Windows.Forms.TextBox()
        Me.hfEscanerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.hfEscanerLabel = New System.Windows.Forms.Label()
        Me.hf6020NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.hf6020Label = New System.Windows.Forms.Label()
        Me.VHFGroupBox = New System.Windows.Forms.GroupBox()
        Me.vhfCantidadLabel = New System.Windows.Forms.Label()
        Me.vhfAereoTextBox = New System.Windows.Forms.TextBox()
        Me.vhf930TextBox = New System.Windows.Forms.TextBox()
        Me.vhf710TextBox = New System.Windows.Forms.TextBox()
        Me.vhfFrecuenciaLabel = New System.Windows.Forms.Label()
        Me.vhf7330TextBox = New System.Windows.Forms.TextBox()
        Me.vhfEscanerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.vhfEscanerLabel = New System.Windows.Forms.Label()
        Me.vhfAereoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.vfhAereoLabel = New System.Windows.Forms.Label()
        Me.vhf930NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.vhf930Label = New System.Windows.Forms.Label()
        Me.vhf710NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.vhf710Label = New System.Windows.Forms.Label()
        Me.vhf7330NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.vhf7330Label = New System.Windows.Forms.Label()
        Me.armamentoGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras4LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente10LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.morterosGroupBox = New System.Windows.Forms.GroupBox()
        Me.m_brandt_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m_brandt_60mmLabel = New System.Windows.Forms.Label()
        Me.mc_fms_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mc_fms_60mmLabel = New System.Windows.Forms.Label()
        Me.otrosMorterosTextBox = New System.Windows.Forms.TextBox()
        Me.otrosMorterosLabel = New System.Windows.Forms.Label()
        Me.mc_c575_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mc_c575_60mmLabel = New System.Windows.Forms.Label()
        Me.mc_c370_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mc_c370_60mmLabel = New System.Windows.Forms.Label()
        Me.lanzagranadasGroupBox = New System.Windows.Forms.GroupBox()
        Me.otrosLanzagranadasTextBox = New System.Windows.Forms.TextBox()
        Me.otrosLanzagranadasLabel = New System.Windows.Forms.Label()
        Me.m79NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m79Label = New System.Windows.Forms.Label()
        Me.mkNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mkLabel = New System.Windows.Forms.Label()
        Me.mglNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mglLabel = New System.Windows.Forms.Label()
        Me.granadasGroupBox = New System.Windows.Forms.GroupBox()
        Me.otrasGranadasTextBox = New System.Windows.Forms.TextBox()
        Me.otrasGranadasLabel = New System.Windows.Forms.Label()
        Me.lacrimogenaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lacrimogenaLabel = New System.Windows.Forms.Label()
        Me.humoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.humoLabel = New System.Windows.Forms.Label()
        Me.manoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.manoLabel = New System.Windows.Forms.Label()
        Me.fusilesGroupBox = New System.Windows.Forms.GroupBox()
        Me.m16_a203Label = New System.Windows.Forms.Label()
        Me.m16_m4Label = New System.Windows.Forms.Label()
        Me.m16_a2Label = New System.Windows.Forms.Label()
        Me.m16_a203NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m16_m4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m16_a2NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.otrosFusilesTextBox = New System.Windows.Forms.TextBox()
        Me.otrosFusilesLabel = New System.Windows.Forms.Label()
        Me.galil_iceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.galil_iceLabel = New System.Windows.Forms.Label()
        Me.galil_arNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.galil_arLabel = New System.Windows.Forms.Label()
        Me.equiposEspecialesGroupBox = New System.Windows.Forms.GroupBox()
        Me.otrosEquiposTextBox = New System.Windows.Forms.TextBox()
        Me.otrosEquiposLabel = New System.Windows.Forms.Label()
        Me.kitOrientacionNocturnoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.kitOrientacionNocturnoLabel = New System.Windows.Forms.Label()
        Me.flasmersNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.flasmersLabel = New System.Windows.Forms.Label()
        Me.camaraTermicaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.camaraTermicaLabel = New System.Windows.Forms.Label()
        Me.binocularesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.binocularesLabel = New System.Windows.Forms.Label()
        Me.visorNocturnoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.visorNocturnoLabel = New System.Windows.Forms.Label()
        Me.ametralladorasGroupBox = New System.Windows.Forms.GroupBox()
        Me.otrasAmetralladorasTextBox = New System.Windows.Forms.TextBox()
        Me.otrasAmetralladorasLabel = New System.Windows.Forms.Label()
        Me.punto50NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.punto50Label = New System.Windows.Forms.Label()
        Me.ss77NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ss77Label = New System.Windows.Forms.Label()
        Me.M249NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.M249Label = New System.Windows.Forms.Label()
        Me.m60E4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m60E4Label = New System.Windows.Forms.Label()
        Me.m60EstandarNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m60EstandarLabel = New System.Windows.Forms.Label()
        Me.situacionGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras11LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente2LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.detalleSituacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.firmasGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras1LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.distribucionGroupBox = New System.Windows.Forms.GroupBox()
        Me.recibeTextBox = New System.Windows.Forms.TextBox()
        Me.autenticaTextBox = New System.Windows.Forms.TextBox()
        Me.autorizaTextBox = New System.Windows.Forms.TextBox()
        Me.anexosGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras2LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente12LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.anexosDataGridView = New System.Windows.Forms.DataGridView()
        Me.nombreArchivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quitarButton = New System.Windows.Forms.Button()
        Me.agregarAnexoButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.personalGroupBox = New System.Windows.Forms.GroupBox()
        Me.atras3LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.siguiente11LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.personalRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.indicativosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.enemigoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.propiasTropasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.agregacionesSituacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.segregacionesSituacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.detalleMisionGroupBox = New System.Windows.Forms.GroupBox()
        Me.misionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.intencionComandanteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.conceptoOperacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.maniobraRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.fuegosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.tareasManiobraRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.tareasCombateRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.instruccionesCoordinacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.distribucionRichTextBox = New System.Windows.Forms.RichTextBox()
        operacionLabel = New System.Windows.Forms.Label()
        nombre_operacionLabel = New System.Windows.Forms.Label()
        procedimientoLabel = New System.Windows.Forms.Label()
        fecha_operacionLabel = New System.Windows.Forms.Label()
        Autoriza_deLabel = New System.Windows.Forms.Label()
        Comandante_operacionLabel = New System.Windows.Forms.Label()
        IndicativoLabel = New System.Windows.Forms.Label()
        referenciasLabel = New System.Windows.Forms.Label()
        detalleSituacionLabel = New System.Windows.Forms.Label()
        enemigoLabel = New System.Windows.Forms.Label()
        autorizaLabel = New System.Windows.Forms.Label()
        autenticaLabel = New System.Windows.Forms.Label()
        recibeLabel = New System.Windows.Forms.Label()
        lugarLabel = New System.Windows.Forms.Label()
        propiasTropasLabel = New System.Windows.Forms.Label()
        segregacionesSituacionLabel = New System.Windows.Forms.Label()
        agregacionesSituacionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.segundosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segundosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segundosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segundosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.operacionGroupBox.SuspendLayout()
        Me.misionGroupBox.SuspendLayout()
        Me.toeGroupBox.SuspendLayout()
        CType(Me.oficialesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CivilesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuboficialesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imrNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.impNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.coordenadasGroupBox.SuspendLayout()
        Me.punto3TableLayoutPanel.SuspendLayout()
        CType(Me.minutosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minutosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.punto1TableLayoutPanel.SuspendLayout()
        CType(Me.minutosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minutosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ejecucion1GroupBox.SuspendLayout()
        Me.conceptoOperacionGroupBox.SuspendLayout()
        Me.Ejecucion2GroupBox.SuspendLayout()
        Me.juridicasGroupBox.SuspendLayout()
        Me.serviciosCombateGroupBox.SuspendLayout()
        Me.comunicacionesGroupBox.SuspendLayout()
        Me.indicativosGroupBox.SuspendLayout()
        Me.otrosComGroupBox.SuspendLayout()
        Me.UHFGroupBox.SuspendLayout()
        CType(Me.uhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uhfXTR3000NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uhfXTS4250NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hfGroupBox.SuspendLayout()
        CType(Me.hfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hf6020NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VHFGroupBox.SuspendLayout()
        CType(Me.vhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhfAereoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhf930NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhf710NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhf7330NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.armamentoGroupBox.SuspendLayout()
        Me.morterosGroupBox.SuspendLayout()
        CType(Me.m_brandt_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc_fms_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc_c575_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc_c370_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lanzagranadasGroupBox.SuspendLayout()
        CType(Me.m79NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mkNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mglNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.granadasGroupBox.SuspendLayout()
        CType(Me.lacrimogenaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.humoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fusilesGroupBox.SuspendLayout()
        CType(Me.m16_a203NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m16_m4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m16_a2NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.galil_iceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.galil_arNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.equiposEspecialesGroupBox.SuspendLayout()
        CType(Me.kitOrientacionNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flasmersNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.camaraTermicaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binocularesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visorNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ametralladorasGroupBox.SuspendLayout()
        CType(Me.punto50NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ss77NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M249NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m60E4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m60EstandarNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.situacionGroupBox.SuspendLayout()
        Me.firmasGroupBox.SuspendLayout()
        Me.distribucionGroupBox.SuspendLayout()
        Me.anexosGroupBox.SuspendLayout()
        CType(Me.anexosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.personalGroupBox.SuspendLayout()
        Me.detalleMisionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        Me.TituloLabel.Location = New System.Drawing.Point(13, 43)
        Me.TituloLabel.Size = New System.Drawing.Size(1159, 23)
        Me.TituloLabel.Text = "Registro de Nueva Operación"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.firmasGroupBox)
        Me.Panel1.Controls.Add(Me.armamentoGroupBox)
        Me.Panel1.Controls.Add(Me.serviciosCombateGroupBox)
        Me.Panel1.Controls.Add(Me.juridicasGroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion2GroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion1GroupBox)
        Me.Panel1.Controls.Add(Me.misionGroupBox)
        Me.Panel1.Controls.Add(Me.situacionGroupBox)
        Me.Panel1.Controls.Add(Me.comunicacionesGroupBox)
        Me.Panel1.Controls.Add(Me.operacionGroupBox)
        Me.Panel1.Controls.Add(Me.personalGroupBox)
        Me.Panel1.Controls.Add(Me.coordenadasGroupBox)
        Me.Panel1.Controls.Add(Me.anexosGroupBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Size = New System.Drawing.Size(1160, 521)
        '
        'operacionLabel
        '
        operacionLabel.AutoSize = True
        operacionLabel.Location = New System.Drawing.Point(19, 27)
        operacionLabel.Name = "operacionLabel"
        operacionLabel.Size = New System.Drawing.Size(149, 16)
        operacionLabel.TabIndex = 0
        operacionLabel.Text = "Consecutivo operación:"
        '
        'nombre_operacionLabel
        '
        nombre_operacionLabel.AutoSize = True
        nombre_operacionLabel.Location = New System.Drawing.Point(49, 55)
        nombre_operacionLabel.Name = "nombre_operacionLabel"
        nombre_operacionLabel.Size = New System.Drawing.Size(124, 16)
        nombre_operacionLabel.TabIndex = 2
        nombre_operacionLabel.Text = "Nombre operación:"
        '
        'procedimientoLabel
        '
        procedimientoLabel.AutoSize = True
        procedimientoLabel.Location = New System.Drawing.Point(73, 83)
        procedimientoLabel.Name = "procedimientoLabel"
        procedimientoLabel.Size = New System.Drawing.Size(98, 16)
        procedimientoLabel.TabIndex = 4
        procedimientoLabel.Text = "Procedimiento:"
        '
        'fecha_operacionLabel
        '
        fecha_operacionLabel.AutoSize = True
        fecha_operacionLabel.Location = New System.Drawing.Point(62, 112)
        fecha_operacionLabel.Name = "fecha_operacionLabel"
        fecha_operacionLabel.Size = New System.Drawing.Size(113, 16)
        fecha_operacionLabel.TabIndex = 6
        fecha_operacionLabel.Text = "Fecha operación:"
        '
        'Autoriza_deLabel
        '
        Autoriza_deLabel.AutoSize = True
        Autoriza_deLabel.Location = New System.Drawing.Point(587, 24)
        Autoriza_deLabel.Name = "Autoriza_deLabel"
        Autoriza_deLabel.Size = New System.Drawing.Size(78, 16)
        Autoriza_deLabel.TabIndex = 8
        Autoriza_deLabel.Text = "Autoriza de:"
        '
        'Comandante_operacionLabel
        '
        Comandante_operacionLabel.AutoSize = True
        Comandante_operacionLabel.Location = New System.Drawing.Point(514, 52)
        Comandante_operacionLabel.Name = "Comandante_operacionLabel"
        Comandante_operacionLabel.Size = New System.Drawing.Size(152, 16)
        Comandante_operacionLabel.TabIndex = 10
        Comandante_operacionLabel.Text = "Comandante operación:"
        '
        'IndicativoLabel
        '
        IndicativoLabel.AutoSize = True
        IndicativoLabel.Location = New System.Drawing.Point(596, 80)
        IndicativoLabel.Name = "IndicativoLabel"
        IndicativoLabel.Size = New System.Drawing.Size(68, 16)
        IndicativoLabel.TabIndex = 12
        IndicativoLabel.Text = "Indicativo:"
        '
        'referenciasLabel
        '
        referenciasLabel.AutoSize = True
        referenciasLabel.Location = New System.Drawing.Point(16, 149)
        referenciasLabel.Name = "referenciasLabel"
        referenciasLabel.Size = New System.Drawing.Size(84, 16)
        referenciasLabel.TabIndex = 14
        referenciasLabel.Text = "Referencias:"
        '
        'detalleSituacionLabel
        '
        detalleSituacionLabel.AutoSize = True
        detalleSituacionLabel.Location = New System.Drawing.Point(19, 21)
        detalleSituacionLabel.Name = "detalleSituacionLabel"
        detalleSituacionLabel.Size = New System.Drawing.Size(54, 16)
        detalleSituacionLabel.TabIndex = 0
        detalleSituacionLabel.Text = "Detalle:"
        '
        'enemigoLabel
        '
        enemigoLabel.AutoSize = True
        enemigoLabel.Location = New System.Drawing.Point(590, 21)
        enemigoLabel.Name = "enemigoLabel"
        enemigoLabel.Size = New System.Drawing.Size(79, 16)
        enemigoLabel.TabIndex = 2
        enemigoLabel.Text = "a. Enemigo:"
        '
        'autorizaLabel
        '
        autorizaLabel.AutoSize = True
        autorizaLabel.Location = New System.Drawing.Point(14, 116)
        autorizaLabel.Name = "autorizaLabel"
        autorizaLabel.Size = New System.Drawing.Size(59, 16)
        autorizaLabel.TabIndex = 18
        autorizaLabel.Text = "Autoriza:"
        '
        'autenticaLabel
        '
        autenticaLabel.AutoSize = True
        autenticaLabel.Location = New System.Drawing.Point(7, 184)
        autenticaLabel.Name = "autenticaLabel"
        autenticaLabel.Size = New System.Drawing.Size(66, 16)
        autenticaLabel.TabIndex = 20
        autenticaLabel.Text = "Autentica:"
        '
        'recibeLabel
        '
        recibeLabel.AutoSize = True
        recibeLabel.Location = New System.Drawing.Point(18, 252)
        recibeLabel.Name = "recibeLabel"
        recibeLabel.Size = New System.Drawing.Size(55, 16)
        recibeLabel.TabIndex = 22
        recibeLabel.Text = "Recibe:"
        '
        'lugarLabel
        '
        lugarLabel.AutoSize = True
        lugarLabel.Location = New System.Drawing.Point(619, 108)
        lugarLabel.Name = "lugarLabel"
        lugarLabel.Size = New System.Drawing.Size(45, 16)
        lugarLabel.TabIndex = 20
        lugarLabel.Text = "Lugar:"
        '
        'propiasTropasLabel
        '
        propiasTropasLabel.AutoSize = True
        propiasTropasLabel.Location = New System.Drawing.Point(590, 135)
        propiasTropasLabel.Name = "propiasTropasLabel"
        propiasTropasLabel.Size = New System.Drawing.Size(113, 16)
        propiasTropasLabel.TabIndex = 4
        propiasTropasLabel.Text = "b. Propias tropas:"
        '
        'segregacionesSituacionLabel
        '
        segregacionesSituacionLabel.AutoSize = True
        segregacionesSituacionLabel.Location = New System.Drawing.Point(590, 375)
        segregacionesSituacionLabel.Name = "segregacionesSituacionLabel"
        segregacionesSituacionLabel.Size = New System.Drawing.Size(118, 16)
        segregacionesSituacionLabel.TabIndex = 8
        segregacionesSituacionLabel.Text = "d. Segregaciones:"
        '
        'agregacionesSituacionLabel
        '
        agregacionesSituacionLabel.AutoSize = True
        agregacionesSituacionLabel.Location = New System.Drawing.Point(590, 261)
        agregacionesSituacionLabel.Name = "agregacionesSituacionLabel"
        agregacionesSituacionLabel.Size = New System.Drawing.Size(109, 16)
        agregacionesSituacionLabel.TabIndex = 6
        agregacionesSituacionLabel.Text = "c. Agregaciones:"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'operacionTextBox
        '
        Me.operacionTextBox.Location = New System.Drawing.Point(176, 24)
        Me.operacionTextBox.MaxLength = 20
        Me.operacionTextBox.Name = "operacionTextBox"
        Me.operacionTextBox.Size = New System.Drawing.Size(250, 22)
        Me.operacionTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.operacionTextBox, "Consecutivo de la operación, puede ser alfanumérico " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de máximo 20 caracteres.")
        '
        'nombre_operacionTextBox
        '
        Me.nombre_operacionTextBox.Location = New System.Drawing.Point(176, 52)
        Me.nombre_operacionTextBox.MaxLength = 300
        Me.nombre_operacionTextBox.Name = "nombre_operacionTextBox"
        Me.nombre_operacionTextBox.Size = New System.Drawing.Size(250, 22)
        Me.nombre_operacionTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.nombre_operacionTextBox, "Máximo 300 caracteres.")
        '
        'deTextBox
        '
        Me.deTextBox.Location = New System.Drawing.Point(670, 21)
        Me.deTextBox.MaxLength = 300
        Me.deTextBox.Name = "deTextBox"
        Me.deTextBox.Size = New System.Drawing.Size(250, 22)
        Me.deTextBox.TabIndex = 9
        Me.deTextBox.Text = "CBFIM52"
        Me.ToolTip1.SetToolTip(Me.deTextBox, "Texto del campo ""De""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Que aparecerá en la página 1 de la orden fragmentaria.")
        '
        'segundosLgn1NumericUpDown
        '
        Me.segundosLgn1NumericUpDown.DecimalPlaces = 2
        Me.segundosLgn1NumericUpDown.Location = New System.Drawing.Point(190, 47)
        Me.segundosLgn1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.segundosLgn1NumericUpDown.Name = "segundosLgn1NumericUpDown"
        Me.segundosLgn1NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.segundosLgn1NumericUpDown.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.segundosLgn1NumericUpDown, "El separador decimal es la coma.")
        '
        'segundosLat1NumericUpDown
        '
        Me.segundosLat1NumericUpDown.DecimalPlaces = 2
        Me.segundosLat1NumericUpDown.Location = New System.Drawing.Point(190, 19)
        Me.segundosLat1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.segundosLat1NumericUpDown.Name = "segundosLat1NumericUpDown"
        Me.segundosLat1NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.segundosLat1NumericUpDown.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.segundosLat1NumericUpDown, "El separador decimal es la coma.")
        '
        'segundosLng3NumericUpDown
        '
        Me.segundosLng3NumericUpDown.DecimalPlaces = 2
        Me.segundosLng3NumericUpDown.Location = New System.Drawing.Point(190, 47)
        Me.segundosLng3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.segundosLng3NumericUpDown.Name = "segundosLng3NumericUpDown"
        Me.segundosLng3NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.segundosLng3NumericUpDown.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.segundosLng3NumericUpDown, "El separador decimal es la coma.")
        '
        'segundosLat3NumericUpDown
        '
        Me.segundosLat3NumericUpDown.DecimalPlaces = 2
        Me.segundosLat3NumericUpDown.Location = New System.Drawing.Point(190, 19)
        Me.segundosLat3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.segundosLat3NumericUpDown.Name = "segundosLat3NumericUpDown"
        Me.segundosLat3NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.segundosLat3NumericUpDown.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.segundosLat3NumericUpDown, "El separador decimal es la coma.")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.GuardarTodoToolStripMenuItem, Me.CancelarTodoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.situacionToolStripMenuItem, Me.misionToolStripMenuItem, Me.CoordenadasToolStripMenuItem, Me.EjecucionToolStripMenuItem, Me.juridicasToolStripMenuItem, Me.serviciosCombateToolStripMenuItem, Me.ComunicacionesToolStripMenuItem, Me.ArmamentoToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.AnexosToolStripMenuItem, Me.FirmasToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "&Datos"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.OperacionesToolStripMenuItem.Text = "&Básicos"
        '
        'situacionToolStripMenuItem
        '
        Me.situacionToolStripMenuItem.Name = "situacionToolStripMenuItem"
        Me.situacionToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.situacionToolStripMenuItem.Text = "&Situación"
        '
        'misionToolStripMenuItem
        '
        Me.misionToolStripMenuItem.Name = "misionToolStripMenuItem"
        Me.misionToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.misionToolStripMenuItem.Text = "&Misión | TOE"
        '
        'CoordenadasToolStripMenuItem
        '
        Me.CoordenadasToolStripMenuItem.Name = "CoordenadasToolStripMenuItem"
        Me.CoordenadasToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.CoordenadasToolStripMenuItem.Text = "&Coordenadas"
        '
        'EjecucionToolStripMenuItem
        '
        Me.EjecucionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejecucion1ToolStripMenuItem, Me.Ejecucion2ToolStripMenuItem})
        Me.EjecucionToolStripMenuItem.Name = "EjecucionToolStripMenuItem"
        Me.EjecucionToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.EjecucionToolStripMenuItem.Text = "&Ejecución"
        '
        'Ejecucion1ToolStripMenuItem
        '
        Me.Ejecucion1ToolStripMenuItem.Name = "Ejecucion1ToolStripMenuItem"
        Me.Ejecucion1ToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.Ejecucion1ToolStripMenuItem.Text = "Intención co&mandante | Concepto"
        '
        'Ejecucion2ToolStripMenuItem
        '
        Me.Ejecucion2ToolStripMenuItem.Name = "Ejecucion2ToolStripMenuItem"
        Me.Ejecucion2ToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.Ejecucion2ToolStripMenuItem.Text = "Instrucciones"
        '
        'juridicasToolStripMenuItem
        '
        Me.juridicasToolStripMenuItem.Name = "juridicasToolStripMenuItem"
        Me.juridicasToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.juridicasToolStripMenuItem.Text = "Uso de fuerza | Instrucciones juridicas"
        '
        'serviciosCombateToolStripMenuItem
        '
        Me.serviciosCombateToolStripMenuItem.Name = "serviciosCombateToolStripMenuItem"
        Me.serviciosCombateToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.serviciosCombateToolStripMenuItem.Text = "&Apoyo de servicios para el combate"
        '
        'ComunicacionesToolStripMenuItem
        '
        Me.ComunicacionesToolStripMenuItem.Name = "ComunicacionesToolStripMenuItem"
        Me.ComunicacionesToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.ComunicacionesToolStripMenuItem.Text = "Co&municaciones"
        '
        'ArmamentoToolStripMenuItem
        '
        Me.ArmamentoToolStripMenuItem.Name = "ArmamentoToolStripMenuItem"
        Me.ArmamentoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.ArmamentoToolStripMenuItem.Text = "A&rmamento"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.PersonalToolStripMenuItem.Text = "&Personal"
        '
        'AnexosToolStripMenuItem
        '
        Me.AnexosToolStripMenuItem.Name = "AnexosToolStripMenuItem"
        Me.AnexosToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.AnexosToolStripMenuItem.Text = "Ane&xos"
        '
        'FirmasToolStripMenuItem
        '
        Me.FirmasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FirmasToolStripMenuItem.Name = "FirmasToolStripMenuItem"
        Me.FirmasToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.FirmasToolStripMenuItem.Text = "&Firmas | Distribución"
        '
        'GuardarTodoToolStripMenuItem
        '
        Me.GuardarTodoToolStripMenuItem.Name = "GuardarTodoToolStripMenuItem"
        Me.GuardarTodoToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.GuardarTodoToolStripMenuItem.Text = "&Guardar todo"
        Me.GuardarTodoToolStripMenuItem.ToolTipText = "Guarda todos los datos de la operación en la base de datos."
        '
        'CancelarTodoToolStripMenuItem
        '
        Me.CancelarTodoToolStripMenuItem.Name = "CancelarTodoToolStripMenuItem"
        Me.CancelarTodoToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.CancelarTodoToolStripMenuItem.Text = "&Cancelar todo"
        Me.CancelarTodoToolStripMenuItem.ToolTipText = "Cancela todos los datos ingresados, sin guardar nada en la base de datos."
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'operacionGroupBox
        '
        Me.operacionGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.operacionGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.operacionGroupBox.Controls.Add(Me.siguiente1LinkLabel)
        Me.operacionGroupBox.Controls.Add(lugarLabel)
        Me.operacionGroupBox.Controls.Add(Me.lugarTextBox)
        Me.operacionGroupBox.Controls.Add(Me.procedimientoComboBox)
        Me.operacionGroupBox.Controls.Add(operacionLabel)
        Me.operacionGroupBox.Controls.Add(Me.operacionTextBox)
        Me.operacionGroupBox.Controls.Add(nombre_operacionLabel)
        Me.operacionGroupBox.Controls.Add(Me.nombre_operacionTextBox)
        Me.operacionGroupBox.Controls.Add(procedimientoLabel)
        Me.operacionGroupBox.Controls.Add(fecha_operacionLabel)
        Me.operacionGroupBox.Controls.Add(Me.fecha_operacionDateTimePicker)
        Me.operacionGroupBox.Controls.Add(Autoriza_deLabel)
        Me.operacionGroupBox.Controls.Add(Me.deTextBox)
        Me.operacionGroupBox.Controls.Add(Comandante_operacionLabel)
        Me.operacionGroupBox.Controls.Add(Me.accTextBox)
        Me.operacionGroupBox.Controls.Add(IndicativoLabel)
        Me.operacionGroupBox.Controls.Add(Me.IndicativoTextBox)
        Me.operacionGroupBox.Controls.Add(referenciasLabel)
        Me.operacionGroupBox.Controls.Add(Me.referenciasRichTextBox)
        Me.operacionGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.operacionGroupBox.Name = "operacionGroupBox"
        Me.operacionGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.operacionGroupBox.TabIndex = 1
        Me.operacionGroupBox.TabStop = False
        '
        'siguiente1LinkLabel
        '
        Me.siguiente1LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente1LinkLabel.AutoSize = True
        Me.siguiente1LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente1LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente1LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente1LinkLabel.Name = "siguiente1LinkLabel"
        Me.siguiente1LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente1LinkLabel.TabIndex = 1
        Me.siguiente1LinkLabel.TabStop = True
        Me.siguiente1LinkLabel.Text = "Siguiente"
        Me.siguiente1LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lugarTextBox
        '
        Me.lugarTextBox.Location = New System.Drawing.Point(670, 105)
        Me.lugarTextBox.MaxLength = 300
        Me.lugarTextBox.Name = "lugarTextBox"
        Me.lugarTextBox.Size = New System.Drawing.Size(250, 22)
        Me.lugarTextBox.TabIndex = 21
        Me.lugarTextBox.Text = "Arauca, Arauca"
        '
        'procedimientoComboBox
        '
        Me.procedimientoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.procedimientoComboBox.FormattingEnabled = True
        Me.procedimientoComboBox.Items.AddRange(New Object() {"OPERACIÓN FLUVIAL", "OPERACIÓN TERRESTRE"})
        Me.procedimientoComboBox.Location = New System.Drawing.Point(176, 80)
        Me.procedimientoComboBox.Name = "procedimientoComboBox"
        Me.procedimientoComboBox.Size = New System.Drawing.Size(250, 24)
        Me.procedimientoComboBox.TabIndex = 5
        '
        'fecha_operacionDateTimePicker
        '
        Me.fecha_operacionDateTimePicker.Location = New System.Drawing.Point(176, 108)
        Me.fecha_operacionDateTimePicker.Name = "fecha_operacionDateTimePicker"
        Me.fecha_operacionDateTimePicker.Size = New System.Drawing.Size(250, 22)
        Me.fecha_operacionDateTimePicker.TabIndex = 7
        Me.fecha_operacionDateTimePicker.Value = New Date(2012, 6, 23, 0, 0, 0, 0)
        '
        'accTextBox
        '
        Me.accTextBox.Location = New System.Drawing.Point(670, 49)
        Me.accTextBox.MaxLength = 300
        Me.accTextBox.Name = "accTextBox"
        Me.accTextBox.Size = New System.Drawing.Size(250, 22)
        Me.accTextBox.TabIndex = 11
        '
        'IndicativoTextBox
        '
        Me.IndicativoTextBox.Location = New System.Drawing.Point(670, 77)
        Me.IndicativoTextBox.MaxLength = 300
        Me.IndicativoTextBox.Name = "IndicativoTextBox"
        Me.IndicativoTextBox.Size = New System.Drawing.Size(250, 22)
        Me.IndicativoTextBox.TabIndex = 13
        '
        'referenciasRichTextBox
        '
        Me.referenciasRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.referenciasRichTextBox.Location = New System.Drawing.Point(19, 168)
        Me.referenciasRichTextBox.Name = "referenciasRichTextBox"
        Me.referenciasRichTextBox.Size = New System.Drawing.Size(903, 307)
        Me.referenciasRichTextBox.TabIndex = 15
        Me.referenciasRichTextBox.Text = resources.GetString("referenciasRichTextBox.Text")
        '
        'misionGroupBox
        '
        Me.misionGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.misionGroupBox.Controls.Add(Me.detalleMisionGroupBox)
        Me.misionGroupBox.Controls.Add(Me.atras10LinkLabel)
        Me.misionGroupBox.Controls.Add(Me.siguiente3LinkLabel)
        Me.misionGroupBox.Controls.Add(Me.toeGroupBox)
        Me.misionGroupBox.ForeColor = System.Drawing.Color.White
        Me.misionGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.misionGroupBox.Name = "misionGroupBox"
        Me.misionGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.misionGroupBox.TabIndex = 3
        Me.misionGroupBox.TabStop = False
        '
        'atras10LinkLabel
        '
        Me.atras10LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras10LinkLabel.AutoSize = True
        Me.atras10LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras10LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras10LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras10LinkLabel.Name = "atras10LinkLabel"
        Me.atras10LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras10LinkLabel.TabIndex = 25
        Me.atras10LinkLabel.TabStop = True
        Me.atras10LinkLabel.Text = "Atrás"
        Me.atras10LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente3LinkLabel
        '
        Me.siguiente3LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente3LinkLabel.AutoSize = True
        Me.siguiente3LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente3LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente3LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente3LinkLabel.Name = "siguiente3LinkLabel"
        Me.siguiente3LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente3LinkLabel.TabIndex = 0
        Me.siguiente3LinkLabel.TabStop = True
        Me.siguiente3LinkLabel.Text = "Siguiente"
        Me.siguiente3LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toeGroupBox
        '
        Me.toeGroupBox.Controls.Add(Me.segregacionesToeTextBox)
        Me.toeGroupBox.Controls.Add(Me.segregacionesToeLabel)
        Me.toeGroupBox.Controls.Add(Me.agregacionesToeTextBox)
        Me.toeGroupBox.Controls.Add(Me.agregacionesToeLabel)
        Me.toeGroupBox.Controls.Add(Me.oficialesNumericUpDown)
        Me.toeGroupBox.Controls.Add(Me.oficialesLabel)
        Me.toeGroupBox.Controls.Add(Me.CivilesNumericUpDown)
        Me.toeGroupBox.Controls.Add(Me.SuboficialesLabel)
        Me.toeGroupBox.Controls.Add(Me.CivilesLabel)
        Me.toeGroupBox.Controls.Add(Me.SuboficialesNumericUpDown)
        Me.toeGroupBox.Controls.Add(Me.imrNumericUpDown)
        Me.toeGroupBox.Controls.Add(Me.impLabel)
        Me.toeGroupBox.Controls.Add(Me.imrLabel)
        Me.toeGroupBox.Controls.Add(Me.impNumericUpDown)
        Me.toeGroupBox.ForeColor = System.Drawing.Color.White
        Me.toeGroupBox.Location = New System.Drawing.Point(747, 27)
        Me.toeGroupBox.Name = "toeGroupBox"
        Me.toeGroupBox.Size = New System.Drawing.Size(261, 413)
        Me.toeGroupBox.TabIndex = 2
        Me.toeGroupBox.TabStop = False
        Me.toeGroupBox.Text = "TOE"
        '
        'segregacionesToeTextBox
        '
        Me.segregacionesToeTextBox.Location = New System.Drawing.Point(35, 320)
        Me.segregacionesToeTextBox.Multiline = True
        Me.segregacionesToeTextBox.Name = "segregacionesToeTextBox"
        Me.segregacionesToeTextBox.Size = New System.Drawing.Size(205, 75)
        Me.segregacionesToeTextBox.TabIndex = 13
        '
        'segregacionesToeLabel
        '
        Me.segregacionesToeLabel.AutoSize = True
        Me.segregacionesToeLabel.Location = New System.Drawing.Point(35, 300)
        Me.segregacionesToeLabel.Name = "segregacionesToeLabel"
        Me.segregacionesToeLabel.Size = New System.Drawing.Size(104, 16)
        Me.segregacionesToeLabel.TabIndex = 12
        Me.segregacionesToeLabel.Text = "Segregaciones:"
        '
        'agregacionesToeTextBox
        '
        Me.agregacionesToeTextBox.Location = New System.Drawing.Point(35, 209)
        Me.agregacionesToeTextBox.Multiline = True
        Me.agregacionesToeTextBox.Name = "agregacionesToeTextBox"
        Me.agregacionesToeTextBox.Size = New System.Drawing.Size(205, 75)
        Me.agregacionesToeTextBox.TabIndex = 11
        '
        'agregacionesToeLabel
        '
        Me.agregacionesToeLabel.AutoSize = True
        Me.agregacionesToeLabel.Location = New System.Drawing.Point(35, 189)
        Me.agregacionesToeLabel.Name = "agregacionesToeLabel"
        Me.agregacionesToeLabel.Size = New System.Drawing.Size(96, 16)
        Me.agregacionesToeLabel.TabIndex = 10
        Me.agregacionesToeLabel.Text = "Agregaciones:"
        '
        'oficialesNumericUpDown
        '
        Me.oficialesNumericUpDown.Location = New System.Drawing.Point(120, 28)
        Me.oficialesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.oficialesNumericUpDown.Name = "oficialesNumericUpDown"
        Me.oficialesNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.oficialesNumericUpDown.TabIndex = 1
        '
        'oficialesLabel
        '
        Me.oficialesLabel.AutoSize = True
        Me.oficialesLabel.Location = New System.Drawing.Point(50, 30)
        Me.oficialesLabel.Name = "oficialesLabel"
        Me.oficialesLabel.Size = New System.Drawing.Size(63, 16)
        Me.oficialesLabel.TabIndex = 0
        Me.oficialesLabel.Text = "Oficiales:"
        '
        'CivilesNumericUpDown
        '
        Me.CivilesNumericUpDown.Location = New System.Drawing.Point(120, 140)
        Me.CivilesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.CivilesNumericUpDown.Name = "CivilesNumericUpDown"
        Me.CivilesNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.CivilesNumericUpDown.TabIndex = 9
        '
        'SuboficialesLabel
        '
        Me.SuboficialesLabel.AutoSize = True
        Me.SuboficialesLabel.Location = New System.Drawing.Point(28, 58)
        Me.SuboficialesLabel.Name = "SuboficialesLabel"
        Me.SuboficialesLabel.Size = New System.Drawing.Size(85, 16)
        Me.SuboficialesLabel.TabIndex = 2
        Me.SuboficialesLabel.Text = "Suboficiales:"
        '
        'CivilesLabel
        '
        Me.CivilesLabel.AutoSize = True
        Me.CivilesLabel.Location = New System.Drawing.Point(62, 144)
        Me.CivilesLabel.Name = "CivilesLabel"
        Me.CivilesLabel.Size = New System.Drawing.Size(51, 16)
        Me.CivilesLabel.TabIndex = 8
        Me.CivilesLabel.Text = "Civiles:"
        '
        'SuboficialesNumericUpDown
        '
        Me.SuboficialesNumericUpDown.Location = New System.Drawing.Point(120, 56)
        Me.SuboficialesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.SuboficialesNumericUpDown.Name = "SuboficialesNumericUpDown"
        Me.SuboficialesNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.SuboficialesNumericUpDown.TabIndex = 3
        '
        'imrNumericUpDown
        '
        Me.imrNumericUpDown.Location = New System.Drawing.Point(120, 112)
        Me.imrNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.imrNumericUpDown.Name = "imrNumericUpDown"
        Me.imrNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.imrNumericUpDown.TabIndex = 7
        '
        'impLabel
        '
        Me.impLabel.AutoSize = True
        Me.impLabel.Location = New System.Drawing.Point(79, 86)
        Me.impLabel.Name = "impLabel"
        Me.impLabel.Size = New System.Drawing.Size(34, 16)
        Me.impLabel.TabIndex = 4
        Me.impLabel.Text = "IMP:"
        '
        'imrLabel
        '
        Me.imrLabel.AutoSize = True
        Me.imrLabel.Location = New System.Drawing.Point(79, 114)
        Me.imrLabel.Name = "imrLabel"
        Me.imrLabel.Size = New System.Drawing.Size(35, 16)
        Me.imrLabel.TabIndex = 6
        Me.imrLabel.Text = "IMR:"
        '
        'impNumericUpDown
        '
        Me.impNumericUpDown.Location = New System.Drawing.Point(120, 84)
        Me.impNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.impNumericUpDown.Name = "impNumericUpDown"
        Me.impNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.impNumericUpDown.TabIndex = 5
        '
        'coordenadasGroupBox
        '
        Me.coordenadasGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.coordenadasGroupBox.Controls.Add(Me.atras9LinkLabel)
        Me.coordenadasGroupBox.Controls.Add(Me.siguiente4LinkLabel)
        Me.coordenadasGroupBox.Controls.Add(Me.punto3Label)
        Me.coordenadasGroupBox.Controls.Add(Me.punto3TableLayoutPanel)
        Me.coordenadasGroupBox.Controls.Add(Me.punto1Label)
        Me.coordenadasGroupBox.Controls.Add(Me.punto1TableLayoutPanel)
        Me.coordenadasGroupBox.ForeColor = System.Drawing.Color.White
        Me.coordenadasGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.coordenadasGroupBox.Name = "coordenadasGroupBox"
        Me.coordenadasGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.coordenadasGroupBox.TabIndex = 4
        Me.coordenadasGroupBox.TabStop = False
        Me.coordenadasGroupBox.Text = "Coordenadas"
        '
        'atras9LinkLabel
        '
        Me.atras9LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras9LinkLabel.AutoSize = True
        Me.atras9LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras9LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras9LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras9LinkLabel.Name = "atras9LinkLabel"
        Me.atras9LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras9LinkLabel.TabIndex = 25
        Me.atras9LinkLabel.TabStop = True
        Me.atras9LinkLabel.Text = "Atrás"
        Me.atras9LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente4LinkLabel
        '
        Me.siguiente4LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente4LinkLabel.AutoSize = True
        Me.siguiente4LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente4LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente4LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente4LinkLabel.Name = "siguiente4LinkLabel"
        Me.siguiente4LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente4LinkLabel.TabIndex = 7
        Me.siguiente4LinkLabel.TabStop = True
        Me.siguiente4LinkLabel.Text = "Siguiente"
        Me.siguiente4LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'punto3Label
        '
        Me.punto3Label.AutoSize = True
        Me.punto3Label.Location = New System.Drawing.Point(470, 39)
        Me.punto3Label.Name = "punto3Label"
        Me.punto3Label.Size = New System.Drawing.Size(268, 16)
        Me.punto3Label.TabIndex = 6
        Me.punto3Label.Text = "Punto inferior derecho del área o cuadrante."
        '
        'punto3TableLayoutPanel
        '
        Me.punto3TableLayoutPanel.AutoSize = True
        Me.punto3TableLayoutPanel.ColumnCount = 4
        Me.punto3TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto3TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto3TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto3TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto3TableLayoutPanel.Controls.Add(Me.segundosLng3NumericUpDown, 3, 2)
        Me.punto3TableLayoutPanel.Controls.Add(Me.minutosLng3NumericUpDown, 2, 2)
        Me.punto3TableLayoutPanel.Controls.Add(Me.gradosLng3NumericUpDown, 1, 2)
        Me.punto3TableLayoutPanel.Controls.Add(Me.latitud3Label, 0, 1)
        Me.punto3TableLayoutPanel.Controls.Add(Me.gradosLat3NumericUpDown, 1, 1)
        Me.punto3TableLayoutPanel.Controls.Add(Me.grados3Label, 1, 0)
        Me.punto3TableLayoutPanel.Controls.Add(Me.minutos3Label, 2, 0)
        Me.punto3TableLayoutPanel.Controls.Add(Me.segundos3Label, 3, 0)
        Me.punto3TableLayoutPanel.Controls.Add(Me.minutosLat3NumericUpDown, 2, 1)
        Me.punto3TableLayoutPanel.Controls.Add(Me.segundosLat3NumericUpDown, 3, 1)
        Me.punto3TableLayoutPanel.Controls.Add(Me.longitud3Label, 0, 2)
        Me.punto3TableLayoutPanel.Location = New System.Drawing.Point(476, 69)
        Me.punto3TableLayoutPanel.Name = "punto3TableLayoutPanel"
        Me.punto3TableLayoutPanel.RowCount = 3
        Me.punto3TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.punto3TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.punto3TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.punto3TableLayoutPanel.Size = New System.Drawing.Size(263, 72)
        Me.punto3TableLayoutPanel.TabIndex = 5
        '
        'minutosLng3NumericUpDown
        '
        Me.minutosLng3NumericUpDown.Location = New System.Drawing.Point(130, 47)
        Me.minutosLng3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.minutosLng3NumericUpDown.Name = "minutosLng3NumericUpDown"
        Me.minutosLng3NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.minutosLng3NumericUpDown.TabIndex = 9
        '
        'gradosLng3NumericUpDown
        '
        Me.gradosLng3NumericUpDown.Location = New System.Drawing.Point(71, 47)
        Me.gradosLng3NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.gradosLng3NumericUpDown.Name = "gradosLng3NumericUpDown"
        Me.gradosLng3NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.gradosLng3NumericUpDown.TabIndex = 8
        '
        'latitud3Label
        '
        Me.latitud3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.latitud3Label.AutoSize = True
        Me.latitud3Label.Location = New System.Drawing.Point(15, 16)
        Me.latitud3Label.Name = "latitud3Label"
        Me.latitud3Label.Size = New System.Drawing.Size(50, 28)
        Me.latitud3Label.TabIndex = 3
        Me.latitud3Label.Text = "Latitud:"
        Me.latitud3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gradosLat3NumericUpDown
        '
        Me.gradosLat3NumericUpDown.Location = New System.Drawing.Point(71, 19)
        Me.gradosLat3NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.gradosLat3NumericUpDown.Name = "gradosLat3NumericUpDown"
        Me.gradosLat3NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.gradosLat3NumericUpDown.TabIndex = 4
        '
        'grados3Label
        '
        Me.grados3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grados3Label.AutoSize = True
        Me.grados3Label.Location = New System.Drawing.Point(71, 0)
        Me.grados3Label.Name = "grados3Label"
        Me.grados3Label.Size = New System.Drawing.Size(53, 16)
        Me.grados3Label.TabIndex = 0
        Me.grados3Label.Text = "Grados"
        Me.grados3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutos3Label
        '
        Me.minutos3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minutos3Label.AutoSize = True
        Me.minutos3Label.Location = New System.Drawing.Point(130, 0)
        Me.minutos3Label.Name = "minutos3Label"
        Me.minutos3Label.Size = New System.Drawing.Size(54, 16)
        Me.minutos3Label.TabIndex = 1
        Me.minutos3Label.Text = "Minutos"
        Me.minutos3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'segundos3Label
        '
        Me.segundos3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.segundos3Label.AutoSize = True
        Me.segundos3Label.Location = New System.Drawing.Point(190, 0)
        Me.segundos3Label.Name = "segundos3Label"
        Me.segundos3Label.Size = New System.Drawing.Size(70, 16)
        Me.segundos3Label.TabIndex = 2
        Me.segundos3Label.Text = "Segundos"
        Me.segundos3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutosLat3NumericUpDown
        '
        Me.minutosLat3NumericUpDown.Location = New System.Drawing.Point(130, 19)
        Me.minutosLat3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.minutosLat3NumericUpDown.Name = "minutosLat3NumericUpDown"
        Me.minutosLat3NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.minutosLat3NumericUpDown.TabIndex = 5
        '
        'longitud3Label
        '
        Me.longitud3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.longitud3Label.AutoSize = True
        Me.longitud3Label.Location = New System.Drawing.Point(3, 44)
        Me.longitud3Label.Name = "longitud3Label"
        Me.longitud3Label.Size = New System.Drawing.Size(62, 28)
        Me.longitud3Label.TabIndex = 7
        Me.longitud3Label.Text = "Longitud:"
        Me.longitud3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'punto1Label
        '
        Me.punto1Label.AutoSize = True
        Me.punto1Label.Location = New System.Drawing.Point(68, 39)
        Me.punto1Label.Name = "punto1Label"
        Me.punto1Label.Size = New System.Drawing.Size(282, 16)
        Me.punto1Label.TabIndex = 4
        Me.punto1Label.Text = "Punto superior izquierdo del área o cuadrante."
        '
        'punto1TableLayoutPanel
        '
        Me.punto1TableLayoutPanel.AutoSize = True
        Me.punto1TableLayoutPanel.ColumnCount = 4
        Me.punto1TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto1TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto1TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto1TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.punto1TableLayoutPanel.Controls.Add(Me.segundosLgn1NumericUpDown, 3, 2)
        Me.punto1TableLayoutPanel.Controls.Add(Me.minutosLgn1NumericUpDown, 2, 2)
        Me.punto1TableLayoutPanel.Controls.Add(Me.gradosLgn1NumericUpDown, 1, 2)
        Me.punto1TableLayoutPanel.Controls.Add(Me.latitud1Label, 0, 1)
        Me.punto1TableLayoutPanel.Controls.Add(Me.gradosLat1NumericUpDown, 1, 1)
        Me.punto1TableLayoutPanel.Controls.Add(Me.grados1Label, 1, 0)
        Me.punto1TableLayoutPanel.Controls.Add(Me.minutos1Label, 2, 0)
        Me.punto1TableLayoutPanel.Controls.Add(Me.segundos1Label, 3, 0)
        Me.punto1TableLayoutPanel.Controls.Add(Me.minutosLat1NumericUpDown, 2, 1)
        Me.punto1TableLayoutPanel.Controls.Add(Me.segundosLat1NumericUpDown, 3, 1)
        Me.punto1TableLayoutPanel.Controls.Add(Me.longitud1Label, 0, 2)
        Me.punto1TableLayoutPanel.Location = New System.Drawing.Point(74, 69)
        Me.punto1TableLayoutPanel.Name = "punto1TableLayoutPanel"
        Me.punto1TableLayoutPanel.RowCount = 3
        Me.punto1TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.punto1TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.punto1TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.punto1TableLayoutPanel.Size = New System.Drawing.Size(263, 72)
        Me.punto1TableLayoutPanel.TabIndex = 3
        '
        'minutosLgn1NumericUpDown
        '
        Me.minutosLgn1NumericUpDown.Location = New System.Drawing.Point(130, 47)
        Me.minutosLgn1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.minutosLgn1NumericUpDown.Name = "minutosLgn1NumericUpDown"
        Me.minutosLgn1NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.minutosLgn1NumericUpDown.TabIndex = 9
        '
        'gradosLgn1NumericUpDown
        '
        Me.gradosLgn1NumericUpDown.Location = New System.Drawing.Point(71, 47)
        Me.gradosLgn1NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.gradosLgn1NumericUpDown.Name = "gradosLgn1NumericUpDown"
        Me.gradosLgn1NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.gradosLgn1NumericUpDown.TabIndex = 8
        '
        'latitud1Label
        '
        Me.latitud1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.latitud1Label.AutoSize = True
        Me.latitud1Label.Location = New System.Drawing.Point(15, 16)
        Me.latitud1Label.Name = "latitud1Label"
        Me.latitud1Label.Size = New System.Drawing.Size(50, 28)
        Me.latitud1Label.TabIndex = 3
        Me.latitud1Label.Text = "Latitud:"
        Me.latitud1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gradosLat1NumericUpDown
        '
        Me.gradosLat1NumericUpDown.Location = New System.Drawing.Point(71, 19)
        Me.gradosLat1NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.gradosLat1NumericUpDown.Name = "gradosLat1NumericUpDown"
        Me.gradosLat1NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.gradosLat1NumericUpDown.TabIndex = 4
        '
        'grados1Label
        '
        Me.grados1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grados1Label.AutoSize = True
        Me.grados1Label.Location = New System.Drawing.Point(71, 0)
        Me.grados1Label.Name = "grados1Label"
        Me.grados1Label.Size = New System.Drawing.Size(53, 16)
        Me.grados1Label.TabIndex = 0
        Me.grados1Label.Text = "Grados"
        Me.grados1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutos1Label
        '
        Me.minutos1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minutos1Label.AutoSize = True
        Me.minutos1Label.Location = New System.Drawing.Point(130, 0)
        Me.minutos1Label.Name = "minutos1Label"
        Me.minutos1Label.Size = New System.Drawing.Size(54, 16)
        Me.minutos1Label.TabIndex = 1
        Me.minutos1Label.Text = "Minutos"
        Me.minutos1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'segundos1Label
        '
        Me.segundos1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.segundos1Label.AutoSize = True
        Me.segundos1Label.Location = New System.Drawing.Point(190, 0)
        Me.segundos1Label.Name = "segundos1Label"
        Me.segundos1Label.Size = New System.Drawing.Size(70, 16)
        Me.segundos1Label.TabIndex = 2
        Me.segundos1Label.Text = "Segundos"
        Me.segundos1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutosLat1NumericUpDown
        '
        Me.minutosLat1NumericUpDown.Location = New System.Drawing.Point(130, 19)
        Me.minutosLat1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.minutosLat1NumericUpDown.Name = "minutosLat1NumericUpDown"
        Me.minutosLat1NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.minutosLat1NumericUpDown.TabIndex = 5
        '
        'longitud1Label
        '
        Me.longitud1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.longitud1Label.AutoSize = True
        Me.longitud1Label.Location = New System.Drawing.Point(3, 44)
        Me.longitud1Label.Name = "longitud1Label"
        Me.longitud1Label.Size = New System.Drawing.Size(62, 28)
        Me.longitud1Label.TabIndex = 7
        Me.longitud1Label.Text = "Longitud:"
        Me.longitud1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ejecucion1GroupBox
        '
        Me.Ejecucion1GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion1GroupBox.Controls.Add(Me.intencionComandanteRichTextBox)
        Me.Ejecucion1GroupBox.Controls.Add(Me.atras8LinkLabel)
        Me.Ejecucion1GroupBox.Controls.Add(Me.siguiente5LinkLabel)
        Me.Ejecucion1GroupBox.Controls.Add(Me.conceptoOperacionGroupBox)
        Me.Ejecucion1GroupBox.Controls.Add(Me.intencionComandanteLabel)
        Me.Ejecucion1GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion1GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion1GroupBox.Name = "Ejecucion1GroupBox"
        Me.Ejecucion1GroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.Ejecucion1GroupBox.TabIndex = 7
        Me.Ejecucion1GroupBox.TabStop = False
        Me.Ejecucion1GroupBox.Text = "Ejecución"
        '
        'atras8LinkLabel
        '
        Me.atras8LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras8LinkLabel.AutoSize = True
        Me.atras8LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras8LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras8LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras8LinkLabel.Name = "atras8LinkLabel"
        Me.atras8LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras8LinkLabel.TabIndex = 25
        Me.atras8LinkLabel.TabStop = True
        Me.atras8LinkLabel.Text = "Atrás"
        Me.atras8LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente5LinkLabel
        '
        Me.siguiente5LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente5LinkLabel.AutoSize = True
        Me.siguiente5LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente5LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente5LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente5LinkLabel.Name = "siguiente5LinkLabel"
        Me.siguiente5LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente5LinkLabel.TabIndex = 8
        Me.siguiente5LinkLabel.TabStop = True
        Me.siguiente5LinkLabel.Text = "Siguiente"
        Me.siguiente5LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'conceptoOperacionGroupBox
        '
        Me.conceptoOperacionGroupBox.Controls.Add(Me.fuegosRichTextBox)
        Me.conceptoOperacionGroupBox.Controls.Add(Me.maniobraRichTextBox)
        Me.conceptoOperacionGroupBox.Controls.Add(Me.conceptoOperacionRichTextBox)
        Me.conceptoOperacionGroupBox.Controls.Add(Me.fuegosLabel)
        Me.conceptoOperacionGroupBox.Controls.Add(Me.maniobraLabel)
        Me.conceptoOperacionGroupBox.ForeColor = System.Drawing.Color.White
        Me.conceptoOperacionGroupBox.Location = New System.Drawing.Point(540, 38)
        Me.conceptoOperacionGroupBox.Name = "conceptoOperacionGroupBox"
        Me.conceptoOperacionGroupBox.Size = New System.Drawing.Size(504, 417)
        Me.conceptoOperacionGroupBox.TabIndex = 2
        Me.conceptoOperacionGroupBox.TabStop = False
        Me.conceptoOperacionGroupBox.Text = "Concepto de la operación"
        '
        'fuegosLabel
        '
        Me.fuegosLabel.AutoSize = True
        Me.fuegosLabel.Location = New System.Drawing.Point(16, 277)
        Me.fuegosLabel.Name = "fuegosLabel"
        Me.fuegosLabel.Size = New System.Drawing.Size(57, 16)
        Me.fuegosLabel.TabIndex = 3
        Me.fuegosLabel.Text = "Fuegos:"
        '
        'maniobraLabel
        '
        Me.maniobraLabel.AutoSize = True
        Me.maniobraLabel.Location = New System.Drawing.Point(16, 144)
        Me.maniobraLabel.Name = "maniobraLabel"
        Me.maniobraLabel.Size = New System.Drawing.Size(68, 16)
        Me.maniobraLabel.TabIndex = 1
        Me.maniobraLabel.Text = "Maniobra:"
        '
        'intencionComandanteLabel
        '
        Me.intencionComandanteLabel.AutoSize = True
        Me.intencionComandanteLabel.Location = New System.Drawing.Point(34, 35)
        Me.intencionComandanteLabel.Name = "intencionComandanteLabel"
        Me.intencionComandanteLabel.Size = New System.Drawing.Size(164, 16)
        Me.intencionComandanteLabel.TabIndex = 0
        Me.intencionComandanteLabel.Text = "Intención del comandante:"
        '
        'Ejecucion2GroupBox
        '
        Me.Ejecucion2GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion2GroupBox.Controls.Add(Me.instruccionesCoordinacionRichTextBox)
        Me.Ejecucion2GroupBox.Controls.Add(Me.tareasCombateRichTextBox)
        Me.Ejecucion2GroupBox.Controls.Add(Me.tareasManiobraRichTextBox)
        Me.Ejecucion2GroupBox.Controls.Add(Me.atras7LinkLabel)
        Me.Ejecucion2GroupBox.Controls.Add(Me.siguiente6LinkLabel)
        Me.Ejecucion2GroupBox.Controls.Add(Me.instruccionesCoordinacionLabel)
        Me.Ejecucion2GroupBox.Controls.Add(Me.tareasCombateLabel)
        Me.Ejecucion2GroupBox.Controls.Add(Me.tareasManiobraLabel)
        Me.Ejecucion2GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion2GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion2GroupBox.Name = "Ejecucion2GroupBox"
        Me.Ejecucion2GroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.Ejecucion2GroupBox.TabIndex = 8
        Me.Ejecucion2GroupBox.TabStop = False
        Me.Ejecucion2GroupBox.Text = "Ejecución"
        '
        'atras7LinkLabel
        '
        Me.atras7LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras7LinkLabel.AutoSize = True
        Me.atras7LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras7LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras7LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras7LinkLabel.Name = "atras7LinkLabel"
        Me.atras7LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras7LinkLabel.TabIndex = 25
        Me.atras7LinkLabel.TabStop = True
        Me.atras7LinkLabel.Text = "Atrás"
        Me.atras7LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente6LinkLabel
        '
        Me.siguiente6LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente6LinkLabel.AutoSize = True
        Me.siguiente6LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente6LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente6LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente6LinkLabel.Name = "siguiente6LinkLabel"
        Me.siguiente6LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente6LinkLabel.TabIndex = 8
        Me.siguiente6LinkLabel.TabStop = True
        Me.siguiente6LinkLabel.Text = "Siguiente"
        Me.siguiente6LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'instruccionesCoordinacionLabel
        '
        Me.instruccionesCoordinacionLabel.AutoSize = True
        Me.instruccionesCoordinacionLabel.Location = New System.Drawing.Point(559, 39)
        Me.instruccionesCoordinacionLabel.Name = "instruccionesCoordinacionLabel"
        Me.instruccionesCoordinacionLabel.Size = New System.Drawing.Size(189, 16)
        Me.instruccionesCoordinacionLabel.TabIndex = 4
        Me.instruccionesCoordinacionLabel.Text = "Instrucciones de coordinación:"
        '
        'tareasCombateLabel
        '
        Me.tareasCombateLabel.AutoSize = True
        Me.tareasCombateLabel.Location = New System.Drawing.Point(19, 250)
        Me.tareasCombateLabel.Name = "tareasCombateLabel"
        Me.tareasCombateLabel.Size = New System.Drawing.Size(261, 16)
        Me.tareasCombateLabel.TabIndex = 2
        Me.tareasCombateLabel.Text = "Tareas a unidades de apoyo de combate:"
        '
        'tareasManiobraLabel
        '
        Me.tareasManiobraLabel.AutoSize = True
        Me.tareasManiobraLabel.Location = New System.Drawing.Point(19, 39)
        Me.tareasManiobraLabel.Name = "tareasManiobraLabel"
        Me.tareasManiobraLabel.Size = New System.Drawing.Size(204, 16)
        Me.tareasManiobraLabel.TabIndex = 0
        Me.tareasManiobraLabel.Text = "Tareas a unidades de maniobra:"
        '
        'juridicasGroupBox
        '
        Me.juridicasGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.juridicasGroupBox.Controls.Add(Me.LinkLabel1)
        Me.juridicasGroupBox.Controls.Add(Me.siguiente7LinkLabel)
        Me.juridicasGroupBox.Controls.Add(Me.TarjetaAzulRadioButton)
        Me.juridicasGroupBox.Controls.Add(Me.TarjetaRojaRadioButton)
        Me.juridicasGroupBox.Controls.Add(Me.instruccionesJuridicasRichTextBox)
        Me.juridicasGroupBox.Controls.Add(Me.instruccionesJuridicasLabel)
        Me.juridicasGroupBox.Controls.Add(Me.usoFuerzaRichTextBox)
        Me.juridicasGroupBox.Controls.Add(Me.UsoFuerzaLabel)
        Me.juridicasGroupBox.ForeColor = System.Drawing.Color.White
        Me.juridicasGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.juridicasGroupBox.Name = "juridicasGroupBox"
        Me.juridicasGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.juridicasGroupBox.TabIndex = 12
        Me.juridicasGroupBox.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(1105, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Atrás"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente7LinkLabel
        '
        Me.siguiente7LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente7LinkLabel.AutoSize = True
        Me.siguiente7LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente7LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente7LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente7LinkLabel.Name = "siguiente7LinkLabel"
        Me.siguiente7LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente7LinkLabel.TabIndex = 8
        Me.siguiente7LinkLabel.TabStop = True
        Me.siguiente7LinkLabel.Text = "Siguiente"
        Me.siguiente7LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TarjetaAzulRadioButton
        '
        Me.TarjetaAzulRadioButton.AutoSize = True
        Me.TarjetaAzulRadioButton.Checked = True
        Me.TarjetaAzulRadioButton.Location = New System.Drawing.Point(264, 39)
        Me.TarjetaAzulRadioButton.Name = "TarjetaAzulRadioButton"
        Me.TarjetaAzulRadioButton.Size = New System.Drawing.Size(94, 20)
        Me.TarjetaAzulRadioButton.TabIndex = 2
        Me.TarjetaAzulRadioButton.TabStop = True
        Me.TarjetaAzulRadioButton.Text = "TarjetaAzul"
        Me.TarjetaAzulRadioButton.UseVisualStyleBackColor = True
        '
        'TarjetaRojaRadioButton
        '
        Me.TarjetaRojaRadioButton.AutoSize = True
        Me.TarjetaRojaRadioButton.Location = New System.Drawing.Point(152, 39)
        Me.TarjetaRojaRadioButton.Name = "TarjetaRojaRadioButton"
        Me.TarjetaRojaRadioButton.Size = New System.Drawing.Size(98, 20)
        Me.TarjetaRojaRadioButton.TabIndex = 1
        Me.TarjetaRojaRadioButton.Text = "TarjetaRoja"
        Me.TarjetaRojaRadioButton.UseVisualStyleBackColor = True
        '
        'instruccionesJuridicasRichTextBox
        '
        Me.instruccionesJuridicasRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.instruccionesJuridicasRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.instruccionesJuridicasRichTextBox.Name = "instruccionesJuridicasRichTextBox"
        Me.instruccionesJuridicasRichTextBox.Size = New System.Drawing.Size(412, 405)
        Me.instruccionesJuridicasRichTextBox.TabIndex = 5
        Me.instruccionesJuridicasRichTextBox.Text = ""
        '
        'instruccionesJuridicasLabel
        '
        Me.instruccionesJuridicasLabel.AutoSize = True
        Me.instruccionesJuridicasLabel.Location = New System.Drawing.Point(514, 43)
        Me.instruccionesJuridicasLabel.Name = "instruccionesJuridicasLabel"
        Me.instruccionesJuridicasLabel.Size = New System.Drawing.Size(142, 16)
        Me.instruccionesJuridicasLabel.TabIndex = 4
        Me.instruccionesJuridicasLabel.Text = "Instrucciones jurídicas:"
        '
        'usoFuerzaRichTextBox
        '
        Me.usoFuerzaRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.usoFuerzaRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.usoFuerzaRichTextBox.Name = "usoFuerzaRichTextBox"
        Me.usoFuerzaRichTextBox.Size = New System.Drawing.Size(412, 405)
        Me.usoFuerzaRichTextBox.TabIndex = 3
        Me.usoFuerzaRichTextBox.Text = resources.GetString("usoFuerzaRichTextBox.Text")
        '
        'UsoFuerzaLabel
        '
        Me.UsoFuerzaLabel.AutoSize = True
        Me.UsoFuerzaLabel.Location = New System.Drawing.Point(52, 41)
        Me.UsoFuerzaLabel.Name = "UsoFuerzaLabel"
        Me.UsoFuerzaLabel.Size = New System.Drawing.Size(94, 16)
        Me.UsoFuerzaLabel.TabIndex = 0
        Me.UsoFuerzaLabel.Text = "Uso de fuerza:"
        '
        'serviciosCombateGroupBox
        '
        Me.serviciosCombateGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serviciosCombateGroupBox.Controls.Add(Me.atras6LinkLabel)
        Me.serviciosCombateGroupBox.Controls.Add(Me.siguiente8LinkLabel)
        Me.serviciosCombateGroupBox.Controls.Add(Me.evacuacionesMedicasRichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.evacuacionesMedicasLabel)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase6RichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase6Label)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase5RichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase5Label)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase4RichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase4Label)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase3RichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase3Label)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase2RichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase2Label)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase1RichTextBox)
        Me.serviciosCombateGroupBox.Controls.Add(Me.Clase1Label)
        Me.serviciosCombateGroupBox.ForeColor = System.Drawing.Color.White
        Me.serviciosCombateGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.serviciosCombateGroupBox.Name = "serviciosCombateGroupBox"
        Me.serviciosCombateGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.serviciosCombateGroupBox.TabIndex = 13
        Me.serviciosCombateGroupBox.TabStop = False
        Me.serviciosCombateGroupBox.Text = "Apoyo de servicios para el combate"
        '
        'atras6LinkLabel
        '
        Me.atras6LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras6LinkLabel.AutoSize = True
        Me.atras6LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras6LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras6LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras6LinkLabel.Name = "atras6LinkLabel"
        Me.atras6LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras6LinkLabel.TabIndex = 25
        Me.atras6LinkLabel.TabStop = True
        Me.atras6LinkLabel.Text = "Atrás"
        Me.atras6LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente8LinkLabel
        '
        Me.siguiente8LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente8LinkLabel.AutoSize = True
        Me.siguiente8LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente8LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente8LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente8LinkLabel.Name = "siguiente8LinkLabel"
        Me.siguiente8LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente8LinkLabel.TabIndex = 14
        Me.siguiente8LinkLabel.TabStop = True
        Me.siguiente8LinkLabel.Text = "Siguiente"
        Me.siguiente8LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'evacuacionesMedicasRichTextBox
        '
        Me.evacuacionesMedicasRichTextBox.Location = New System.Drawing.Point(55, 328)
        Me.evacuacionesMedicasRichTextBox.Name = "evacuacionesMedicasRichTextBox"
        Me.evacuacionesMedicasRichTextBox.Size = New System.Drawing.Size(868, 106)
        Me.evacuacionesMedicasRichTextBox.TabIndex = 13
        Me.evacuacionesMedicasRichTextBox.Text = ""
        '
        'evacuacionesMedicasLabel
        '
        Me.evacuacionesMedicasLabel.AutoSize = True
        Me.evacuacionesMedicasLabel.Location = New System.Drawing.Point(52, 306)
        Me.evacuacionesMedicasLabel.Name = "evacuacionesMedicasLabel"
        Me.evacuacionesMedicasLabel.Size = New System.Drawing.Size(152, 16)
        Me.evacuacionesMedicasLabel.TabIndex = 12
        Me.evacuacionesMedicasLabel.Text = "Evacuaciones Médicas:"
        '
        'Clase6RichTextBox
        '
        Me.Clase6RichTextBox.Location = New System.Drawing.Point(599, 195)
        Me.Clase6RichTextBox.Name = "Clase6RichTextBox"
        Me.Clase6RichTextBox.Size = New System.Drawing.Size(324, 70)
        Me.Clase6RichTextBox.TabIndex = 11
        Me.Clase6RichTextBox.Text = "Enfermería BFIM 52, Botiquín"
        '
        'Clase6Label
        '
        Me.Clase6Label.AutoSize = True
        Me.Clase6Label.Location = New System.Drawing.Point(537, 198)
        Me.Clase6Label.Name = "Clase6Label"
        Me.Clase6Label.Size = New System.Drawing.Size(56, 16)
        Me.Clase6Label.TabIndex = 10
        Me.Clase6Label.Text = "Clase 6:"
        '
        'Clase5RichTextBox
        '
        Me.Clase5RichTextBox.Location = New System.Drawing.Point(599, 119)
        Me.Clase5RichTextBox.Name = "Clase5RichTextBox"
        Me.Clase5RichTextBox.Size = New System.Drawing.Size(324, 70)
        Me.Clase5RichTextBox.TabIndex = 9
        Me.Clase5RichTextBox.Text = "00 5.56 suelta, 00 5.56 eslabonada, 7,62 eslabonada, 00 .50 eslabonada, 00 granad" & _
    "as 40mm, 00 granadas 80mm"
        '
        'Clase5Label
        '
        Me.Clase5Label.AutoSize = True
        Me.Clase5Label.Location = New System.Drawing.Point(537, 122)
        Me.Clase5Label.Name = "Clase5Label"
        Me.Clase5Label.Size = New System.Drawing.Size(56, 16)
        Me.Clase5Label.TabIndex = 8
        Me.Clase5Label.Text = "Clase 5:"
        '
        'Clase4RichTextBox
        '
        Me.Clase4RichTextBox.Location = New System.Drawing.Point(599, 41)
        Me.Clase4RichTextBox.Name = "Clase4RichTextBox"
        Me.Clase4RichTextBox.Size = New System.Drawing.Size(324, 70)
        Me.Clase4RichTextBox.TabIndex = 7
        Me.Clase4RichTextBox.Text = "Material de Guerra, Acuerdo asignación"
        '
        'Clase4Label
        '
        Me.Clase4Label.AutoSize = True
        Me.Clase4Label.Location = New System.Drawing.Point(537, 44)
        Me.Clase4Label.Name = "Clase4Label"
        Me.Clase4Label.Size = New System.Drawing.Size(56, 16)
        Me.Clase4Label.TabIndex = 6
        Me.Clase4Label.Text = "Clase 4:"
        '
        'Clase3RichTextBox
        '
        Me.Clase3RichTextBox.Location = New System.Drawing.Point(114, 192)
        Me.Clase3RichTextBox.Name = "Clase3RichTextBox"
        Me.Clase3RichTextBox.Size = New System.Drawing.Size(324, 70)
        Me.Clase3RichTextBox.TabIndex = 5
        Me.Clase3RichTextBox.Text = "Combustible y lubricantes, 00 Gln de Gasolina, 00 Gln ACPM"
        '
        'Clase3Label
        '
        Me.Clase3Label.AutoSize = True
        Me.Clase3Label.Location = New System.Drawing.Point(52, 195)
        Me.Clase3Label.Name = "Clase3Label"
        Me.Clase3Label.Size = New System.Drawing.Size(56, 16)
        Me.Clase3Label.TabIndex = 4
        Me.Clase3Label.Text = "Clase 3:"
        '
        'Clase2RichTextBox
        '
        Me.Clase2RichTextBox.Location = New System.Drawing.Point(114, 116)
        Me.Clase2RichTextBox.Name = "Clase2RichTextBox"
        Me.Clase2RichTextBox.Size = New System.Drawing.Size(324, 70)
        Me.Clase2RichTextBox.TabIndex = 3
        Me.Clase2RichTextBox.Text = "00 Camuflados, 00 Marmitas, 00 Morrales, 00 Sintelitas, 00 Carpajiles, 00 Hamacas" & _
    ", 00 Estufa ACPM"
        '
        'Clase2Label
        '
        Me.Clase2Label.AutoSize = True
        Me.Clase2Label.Location = New System.Drawing.Point(52, 119)
        Me.Clase2Label.Name = "Clase2Label"
        Me.Clase2Label.Size = New System.Drawing.Size(56, 16)
        Me.Clase2Label.TabIndex = 2
        Me.Clase2Label.Text = "Clase 2:"
        '
        'Clase1RichTextBox
        '
        Me.Clase1RichTextBox.Location = New System.Drawing.Point(114, 38)
        Me.Clase1RichTextBox.Name = "Clase1RichTextBox"
        Me.Clase1RichTextBox.Size = New System.Drawing.Size(324, 70)
        Me.Clase1RichTextBox.TabIndex = 1
        Me.Clase1RichTextBox.Text = "Víveres frescos, Comida caliente, Raciones de campaña"
        '
        'Clase1Label
        '
        Me.Clase1Label.AutoSize = True
        Me.Clase1Label.Location = New System.Drawing.Point(52, 41)
        Me.Clase1Label.Name = "Clase1Label"
        Me.Clase1Label.Size = New System.Drawing.Size(56, 16)
        Me.Clase1Label.TabIndex = 0
        Me.Clase1Label.Text = "Clase 1:"
        '
        'comunicacionesGroupBox
        '
        Me.comunicacionesGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comunicacionesGroupBox.Controls.Add(Me.atras5LinkLabel)
        Me.comunicacionesGroupBox.Controls.Add(Me.siguiente9LinkLabel)
        Me.comunicacionesGroupBox.Controls.Add(Me.indicativosGroupBox)
        Me.comunicacionesGroupBox.Controls.Add(Me.otrosComGroupBox)
        Me.comunicacionesGroupBox.Controls.Add(Me.UHFGroupBox)
        Me.comunicacionesGroupBox.Controls.Add(Me.hfGroupBox)
        Me.comunicacionesGroupBox.Controls.Add(Me.VHFGroupBox)
        Me.comunicacionesGroupBox.ForeColor = System.Drawing.Color.White
        Me.comunicacionesGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.comunicacionesGroupBox.Name = "comunicacionesGroupBox"
        Me.comunicacionesGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.comunicacionesGroupBox.TabIndex = 14
        Me.comunicacionesGroupBox.TabStop = False
        Me.comunicacionesGroupBox.Text = "Comunicaciones"
        '
        'atras5LinkLabel
        '
        Me.atras5LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras5LinkLabel.AutoSize = True
        Me.atras5LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras5LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras5LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras5LinkLabel.Name = "atras5LinkLabel"
        Me.atras5LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras5LinkLabel.TabIndex = 25
        Me.atras5LinkLabel.TabStop = True
        Me.atras5LinkLabel.Text = "Atrás"
        Me.atras5LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente9LinkLabel
        '
        Me.siguiente9LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente9LinkLabel.AutoSize = True
        Me.siguiente9LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente9LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente9LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente9LinkLabel.Name = "siguiente9LinkLabel"
        Me.siguiente9LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente9LinkLabel.TabIndex = 8
        Me.siguiente9LinkLabel.TabStop = True
        Me.siguiente9LinkLabel.Text = "Siguiente"
        Me.siguiente9LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'indicativosGroupBox
        '
        Me.indicativosGroupBox.Controls.Add(Me.indicativosRichTextBox)
        Me.indicativosGroupBox.ForeColor = System.Drawing.Color.White
        Me.indicativosGroupBox.Location = New System.Drawing.Point(360, 279)
        Me.indicativosGroupBox.Name = "indicativosGroupBox"
        Me.indicativosGroupBox.Size = New System.Drawing.Size(358, 146)
        Me.indicativosGroupBox.TabIndex = 4
        Me.indicativosGroupBox.TabStop = False
        Me.indicativosGroupBox.Text = "Indicativos"
        '
        'otrosComGroupBox
        '
        Me.otrosComGroupBox.Controls.Add(Me.ClaveComTextBox)
        Me.otrosComGroupBox.Controls.Add(Me.satelitalTextBox)
        Me.otrosComGroupBox.Controls.Add(Me.CelularTextBox)
        Me.otrosComGroupBox.Controls.Add(Me.AvantelTextBox)
        Me.otrosComGroupBox.Controls.Add(Me.ClaveLabel)
        Me.otrosComGroupBox.Controls.Add(Me.satelitalLabel)
        Me.otrosComGroupBox.Controls.Add(Me.CelularLabel)
        Me.otrosComGroupBox.Controls.Add(Me.AvantelLabel)
        Me.otrosComGroupBox.ForeColor = System.Drawing.Color.White
        Me.otrosComGroupBox.Location = New System.Drawing.Point(28, 279)
        Me.otrosComGroupBox.Name = "otrosComGroupBox"
        Me.otrosComGroupBox.Size = New System.Drawing.Size(237, 146)
        Me.otrosComGroupBox.TabIndex = 3
        Me.otrosComGroupBox.TabStop = False
        '
        'ClaveComTextBox
        '
        Me.ClaveComTextBox.Location = New System.Drawing.Point(110, 105)
        Me.ClaveComTextBox.MaxLength = 300
        Me.ClaveComTextBox.Name = "ClaveComTextBox"
        Me.ClaveComTextBox.Size = New System.Drawing.Size(118, 22)
        Me.ClaveComTextBox.TabIndex = 7
        '
        'satelitalTextBox
        '
        Me.satelitalTextBox.Location = New System.Drawing.Point(110, 79)
        Me.satelitalTextBox.MaxLength = 300
        Me.satelitalTextBox.Name = "satelitalTextBox"
        Me.satelitalTextBox.Size = New System.Drawing.Size(118, 22)
        Me.satelitalTextBox.TabIndex = 5
        '
        'CelularTextBox
        '
        Me.CelularTextBox.Location = New System.Drawing.Point(110, 53)
        Me.CelularTextBox.MaxLength = 300
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(118, 22)
        Me.CelularTextBox.TabIndex = 3
        '
        'AvantelTextBox
        '
        Me.AvantelTextBox.Location = New System.Drawing.Point(110, 27)
        Me.AvantelTextBox.MaxLength = 300
        Me.AvantelTextBox.Name = "AvantelTextBox"
        Me.AvantelTextBox.Size = New System.Drawing.Size(118, 22)
        Me.AvantelTextBox.TabIndex = 1
        '
        'ClaveLabel
        '
        Me.ClaveLabel.AutoSize = True
        Me.ClaveLabel.Location = New System.Drawing.Point(16, 109)
        Me.ClaveLabel.Name = "ClaveLabel"
        Me.ClaveLabel.Size = New System.Drawing.Size(89, 16)
        Me.ClaveLabel.TabIndex = 6
        Me.ClaveLabel.Text = "Santo y seña:"
        '
        'satelitalLabel
        '
        Me.satelitalLabel.AutoSize = True
        Me.satelitalLabel.Location = New System.Drawing.Point(46, 81)
        Me.satelitalLabel.Name = "satelitalLabel"
        Me.satelitalLabel.Size = New System.Drawing.Size(59, 16)
        Me.satelitalLabel.TabIndex = 4
        Me.satelitalLabel.Text = "Satelital:"
        '
        'CelularLabel
        '
        Me.CelularLabel.AutoSize = True
        Me.CelularLabel.Location = New System.Drawing.Point(52, 56)
        Me.CelularLabel.Name = "CelularLabel"
        Me.CelularLabel.Size = New System.Drawing.Size(53, 16)
        Me.CelularLabel.TabIndex = 2
        Me.CelularLabel.Text = "Celular:"
        '
        'AvantelLabel
        '
        Me.AvantelLabel.AutoSize = True
        Me.AvantelLabel.Location = New System.Drawing.Point(49, 29)
        Me.AvantelLabel.Name = "AvantelLabel"
        Me.AvantelLabel.Size = New System.Drawing.Size(56, 16)
        Me.AvantelLabel.TabIndex = 0
        Me.AvantelLabel.Text = "Avantel:"
        '
        'UHFGroupBox
        '
        Me.UHFGroupBox.Controls.Add(Me.uhfCantidadLabel)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTR3000TextBox)
        Me.UHFGroupBox.Controls.Add(Me.uhfFrecuenciaLabel)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTS4250TextBox)
        Me.UHFGroupBox.Controls.Add(Me.uhfEscanerNumericUpDown)
        Me.UHFGroupBox.Controls.Add(Me.uhfEscanerLabel)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTR3000NumericUpDown)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTR3000Label)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTS4250NumericUpDown)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTS4250Label)
        Me.UHFGroupBox.ForeColor = System.Drawing.Color.White
        Me.UHFGroupBox.Location = New System.Drawing.Point(360, 38)
        Me.UHFGroupBox.Name = "UHFGroupBox"
        Me.UHFGroupBox.Size = New System.Drawing.Size(296, 142)
        Me.UHFGroupBox.TabIndex = 1
        Me.UHFGroupBox.TabStop = False
        Me.UHFGroupBox.Text = "UHF"
        '
        'uhfCantidadLabel
        '
        Me.uhfCantidadLabel.AutoSize = True
        Me.uhfCantidadLabel.Location = New System.Drawing.Point(85, 25)
        Me.uhfCantidadLabel.Name = "uhfCantidadLabel"
        Me.uhfCantidadLabel.Size = New System.Drawing.Size(62, 16)
        Me.uhfCantidadLabel.TabIndex = 0
        Me.uhfCantidadLabel.Text = "Cantidad"
        '
        'uhfXTR3000TextBox
        '
        Me.uhfXTR3000TextBox.Location = New System.Drawing.Point(161, 75)
        Me.uhfXTR3000TextBox.MaxLength = 300
        Me.uhfXTR3000TextBox.Name = "uhfXTR3000TextBox"
        Me.uhfXTR3000TextBox.Size = New System.Drawing.Size(118, 22)
        Me.uhfXTR3000TextBox.TabIndex = 7
        '
        'uhfFrecuenciaLabel
        '
        Me.uhfFrecuenciaLabel.AutoSize = True
        Me.uhfFrecuenciaLabel.Location = New System.Drawing.Point(176, 25)
        Me.uhfFrecuenciaLabel.Name = "uhfFrecuenciaLabel"
        Me.uhfFrecuenciaLabel.Size = New System.Drawing.Size(75, 16)
        Me.uhfFrecuenciaLabel.TabIndex = 1
        Me.uhfFrecuenciaLabel.Text = "Frecuencia"
        '
        'uhfXTS4250TextBox
        '
        Me.uhfXTS4250TextBox.Location = New System.Drawing.Point(161, 48)
        Me.uhfXTS4250TextBox.MaxLength = 300
        Me.uhfXTS4250TextBox.Name = "uhfXTS4250TextBox"
        Me.uhfXTS4250TextBox.Size = New System.Drawing.Size(118, 22)
        Me.uhfXTS4250TextBox.TabIndex = 4
        '
        'uhfEscanerNumericUpDown
        '
        Me.uhfEscanerNumericUpDown.Location = New System.Drawing.Point(82, 101)
        Me.uhfEscanerNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.uhfEscanerNumericUpDown.Name = "uhfEscanerNumericUpDown"
        Me.uhfEscanerNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.uhfEscanerNumericUpDown.TabIndex = 9
        '
        'uhfEscanerLabel
        '
        Me.uhfEscanerLabel.AutoSize = True
        Me.uhfEscanerLabel.Location = New System.Drawing.Point(15, 103)
        Me.uhfEscanerLabel.Name = "uhfEscanerLabel"
        Me.uhfEscanerLabel.Size = New System.Drawing.Size(61, 16)
        Me.uhfEscanerLabel.TabIndex = 8
        Me.uhfEscanerLabel.Text = "Escáner:"
        '
        'uhfXTR3000NumericUpDown
        '
        Me.uhfXTR3000NumericUpDown.Location = New System.Drawing.Point(82, 75)
        Me.uhfXTR3000NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.uhfXTR3000NumericUpDown.Name = "uhfXTR3000NumericUpDown"
        Me.uhfXTR3000NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.uhfXTR3000NumericUpDown.TabIndex = 6
        '
        'uhfXTR3000Label
        '
        Me.uhfXTR3000Label.AutoSize = True
        Me.uhfXTR3000Label.Location = New System.Drawing.Point(10, 77)
        Me.uhfXTR3000Label.Name = "uhfXTR3000Label"
        Me.uhfXTR3000Label.Size = New System.Drawing.Size(66, 16)
        Me.uhfXTR3000Label.TabIndex = 5
        Me.uhfXTR3000Label.Text = "XTR3000:"
        '
        'uhfXTS4250NumericUpDown
        '
        Me.uhfXTS4250NumericUpDown.Location = New System.Drawing.Point(82, 48)
        Me.uhfXTS4250NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.uhfXTS4250NumericUpDown.Name = "uhfXTS4250NumericUpDown"
        Me.uhfXTS4250NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.uhfXTS4250NumericUpDown.TabIndex = 3
        '
        'uhfXTS4250Label
        '
        Me.uhfXTS4250Label.AutoSize = True
        Me.uhfXTS4250Label.Location = New System.Drawing.Point(11, 53)
        Me.uhfXTS4250Label.Name = "uhfXTS4250Label"
        Me.uhfXTS4250Label.Size = New System.Drawing.Size(65, 16)
        Me.uhfXTS4250Label.TabIndex = 2
        Me.uhfXTS4250Label.Text = "XTS4250:"
        '
        'hfGroupBox
        '
        Me.hfGroupBox.Controls.Add(Me.hfCantidadLabel)
        Me.hfGroupBox.Controls.Add(Me.hfFrecuenciaLabel)
        Me.hfGroupBox.Controls.Add(Me.hf6020TextBox)
        Me.hfGroupBox.Controls.Add(Me.hfEscanerNumericUpDown)
        Me.hfGroupBox.Controls.Add(Me.hfEscanerLabel)
        Me.hfGroupBox.Controls.Add(Me.hf6020NumericUpDown)
        Me.hfGroupBox.Controls.Add(Me.hf6020Label)
        Me.hfGroupBox.ForeColor = System.Drawing.Color.White
        Me.hfGroupBox.Location = New System.Drawing.Point(695, 38)
        Me.hfGroupBox.Name = "hfGroupBox"
        Me.hfGroupBox.Size = New System.Drawing.Size(292, 135)
        Me.hfGroupBox.TabIndex = 2
        Me.hfGroupBox.TabStop = False
        Me.hfGroupBox.Text = "HF"
        '
        'hfCantidadLabel
        '
        Me.hfCantidadLabel.AutoSize = True
        Me.hfCantidadLabel.Location = New System.Drawing.Point(83, 20)
        Me.hfCantidadLabel.Name = "hfCantidadLabel"
        Me.hfCantidadLabel.Size = New System.Drawing.Size(62, 16)
        Me.hfCantidadLabel.TabIndex = 0
        Me.hfCantidadLabel.Text = "Cantidad"
        '
        'hfFrecuenciaLabel
        '
        Me.hfFrecuenciaLabel.AutoSize = True
        Me.hfFrecuenciaLabel.Location = New System.Drawing.Point(174, 20)
        Me.hfFrecuenciaLabel.Name = "hfFrecuenciaLabel"
        Me.hfFrecuenciaLabel.Size = New System.Drawing.Size(75, 16)
        Me.hfFrecuenciaLabel.TabIndex = 1
        Me.hfFrecuenciaLabel.Text = "Frecuencia"
        '
        'hf6020TextBox
        '
        Me.hf6020TextBox.Location = New System.Drawing.Point(159, 43)
        Me.hf6020TextBox.MaxLength = 300
        Me.hf6020TextBox.Name = "hf6020TextBox"
        Me.hf6020TextBox.Size = New System.Drawing.Size(118, 22)
        Me.hf6020TextBox.TabIndex = 4
        '
        'hfEscanerNumericUpDown
        '
        Me.hfEscanerNumericUpDown.Location = New System.Drawing.Point(80, 70)
        Me.hfEscanerNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.hfEscanerNumericUpDown.Name = "hfEscanerNumericUpDown"
        Me.hfEscanerNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.hfEscanerNumericUpDown.TabIndex = 6
        '
        'hfEscanerLabel
        '
        Me.hfEscanerLabel.AutoSize = True
        Me.hfEscanerLabel.Location = New System.Drawing.Point(13, 72)
        Me.hfEscanerLabel.Name = "hfEscanerLabel"
        Me.hfEscanerLabel.Size = New System.Drawing.Size(61, 16)
        Me.hfEscanerLabel.TabIndex = 5
        Me.hfEscanerLabel.Text = "Escáner:"
        '
        'hf6020NumericUpDown
        '
        Me.hf6020NumericUpDown.Location = New System.Drawing.Point(80, 43)
        Me.hf6020NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.hf6020NumericUpDown.Name = "hf6020NumericUpDown"
        Me.hf6020NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.hf6020NumericUpDown.TabIndex = 3
        '
        'hf6020Label
        '
        Me.hf6020Label.AutoSize = True
        Me.hf6020Label.Location = New System.Drawing.Point(35, 45)
        Me.hf6020Label.Name = "hf6020Label"
        Me.hf6020Label.Size = New System.Drawing.Size(39, 16)
        Me.hf6020Label.TabIndex = 2
        Me.hf6020Label.Text = "6020:"
        '
        'VHFGroupBox
        '
        Me.VHFGroupBox.Controls.Add(Me.vhfCantidadLabel)
        Me.VHFGroupBox.Controls.Add(Me.vhfAereoTextBox)
        Me.VHFGroupBox.Controls.Add(Me.vhf930TextBox)
        Me.VHFGroupBox.Controls.Add(Me.vhf710TextBox)
        Me.VHFGroupBox.Controls.Add(Me.vhfFrecuenciaLabel)
        Me.VHFGroupBox.Controls.Add(Me.vhf7330TextBox)
        Me.VHFGroupBox.Controls.Add(Me.vhfEscanerNumericUpDown)
        Me.VHFGroupBox.Controls.Add(Me.vhfEscanerLabel)
        Me.VHFGroupBox.Controls.Add(Me.vhfAereoNumericUpDown)
        Me.VHFGroupBox.Controls.Add(Me.vfhAereoLabel)
        Me.VHFGroupBox.Controls.Add(Me.vhf930NumericUpDown)
        Me.VHFGroupBox.Controls.Add(Me.vhf930Label)
        Me.VHFGroupBox.Controls.Add(Me.vhf710NumericUpDown)
        Me.VHFGroupBox.Controls.Add(Me.vhf710Label)
        Me.VHFGroupBox.Controls.Add(Me.vhf7330NumericUpDown)
        Me.VHFGroupBox.Controls.Add(Me.vhf7330Label)
        Me.VHFGroupBox.ForeColor = System.Drawing.Color.White
        Me.VHFGroupBox.Location = New System.Drawing.Point(24, 38)
        Me.VHFGroupBox.Name = "VHFGroupBox"
        Me.VHFGroupBox.Size = New System.Drawing.Size(308, 199)
        Me.VHFGroupBox.TabIndex = 0
        Me.VHFGroupBox.TabStop = False
        Me.VHFGroupBox.Text = "VHF"
        '
        'vhfCantidadLabel
        '
        Me.vhfCantidadLabel.AutoSize = True
        Me.vhfCantidadLabel.Location = New System.Drawing.Point(85, 26)
        Me.vhfCantidadLabel.Name = "vhfCantidadLabel"
        Me.vhfCantidadLabel.Size = New System.Drawing.Size(62, 16)
        Me.vhfCantidadLabel.TabIndex = 0
        Me.vhfCantidadLabel.Text = "Cantidad"
        '
        'vhfAereoTextBox
        '
        Me.vhfAereoTextBox.Location = New System.Drawing.Point(161, 131)
        Me.vhfAereoTextBox.MaxLength = 300
        Me.vhfAereoTextBox.Name = "vhfAereoTextBox"
        Me.vhfAereoTextBox.Size = New System.Drawing.Size(118, 22)
        Me.vhfAereoTextBox.TabIndex = 13
        '
        'vhf930TextBox
        '
        Me.vhf930TextBox.Location = New System.Drawing.Point(161, 104)
        Me.vhf930TextBox.MaxLength = 300
        Me.vhf930TextBox.Name = "vhf930TextBox"
        Me.vhf930TextBox.Size = New System.Drawing.Size(118, 22)
        Me.vhf930TextBox.TabIndex = 10
        '
        'vhf710TextBox
        '
        Me.vhf710TextBox.Location = New System.Drawing.Point(161, 77)
        Me.vhf710TextBox.MaxLength = 300
        Me.vhf710TextBox.Name = "vhf710TextBox"
        Me.vhf710TextBox.Size = New System.Drawing.Size(118, 22)
        Me.vhf710TextBox.TabIndex = 7
        '
        'vhfFrecuenciaLabel
        '
        Me.vhfFrecuenciaLabel.AutoSize = True
        Me.vhfFrecuenciaLabel.Location = New System.Drawing.Point(176, 26)
        Me.vhfFrecuenciaLabel.Name = "vhfFrecuenciaLabel"
        Me.vhfFrecuenciaLabel.Size = New System.Drawing.Size(75, 16)
        Me.vhfFrecuenciaLabel.TabIndex = 1
        Me.vhfFrecuenciaLabel.Text = "Frecuencia"
        '
        'vhf7330TextBox
        '
        Me.vhf7330TextBox.Location = New System.Drawing.Point(161, 50)
        Me.vhf7330TextBox.MaxLength = 300
        Me.vhf7330TextBox.Name = "vhf7330TextBox"
        Me.vhf7330TextBox.Size = New System.Drawing.Size(118, 22)
        Me.vhf7330TextBox.TabIndex = 4
        '
        'vhfEscanerNumericUpDown
        '
        Me.vhfEscanerNumericUpDown.Location = New System.Drawing.Point(80, 158)
        Me.vhfEscanerNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhfEscanerNumericUpDown.Name = "vhfEscanerNumericUpDown"
        Me.vhfEscanerNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhfEscanerNumericUpDown.TabIndex = 15
        '
        'vhfEscanerLabel
        '
        Me.vhfEscanerLabel.AutoSize = True
        Me.vhfEscanerLabel.Location = New System.Drawing.Point(13, 160)
        Me.vhfEscanerLabel.Name = "vhfEscanerLabel"
        Me.vhfEscanerLabel.Size = New System.Drawing.Size(61, 16)
        Me.vhfEscanerLabel.TabIndex = 14
        Me.vhfEscanerLabel.Text = "Escáner:"
        '
        'vhfAereoNumericUpDown
        '
        Me.vhfAereoNumericUpDown.Location = New System.Drawing.Point(80, 131)
        Me.vhfAereoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhfAereoNumericUpDown.Name = "vhfAereoNumericUpDown"
        Me.vhfAereoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhfAereoNumericUpDown.TabIndex = 12
        '
        'vfhAereoLabel
        '
        Me.vfhAereoLabel.AutoSize = True
        Me.vfhAereoLabel.Location = New System.Drawing.Point(26, 132)
        Me.vfhAereoLabel.Name = "vfhAereoLabel"
        Me.vfhAereoLabel.Size = New System.Drawing.Size(48, 16)
        Me.vfhAereoLabel.TabIndex = 11
        Me.vfhAereoLabel.Text = "Aéreo:"
        '
        'vhf930NumericUpDown
        '
        Me.vhf930NumericUpDown.Location = New System.Drawing.Point(80, 104)
        Me.vhf930NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhf930NumericUpDown.Name = "vhf930NumericUpDown"
        Me.vhf930NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhf930NumericUpDown.TabIndex = 9
        '
        'vhf930Label
        '
        Me.vhf930Label.AutoSize = True
        Me.vhf930Label.Location = New System.Drawing.Point(42, 104)
        Me.vhf930Label.Name = "vhf930Label"
        Me.vhf930Label.Size = New System.Drawing.Size(32, 16)
        Me.vhf930Label.TabIndex = 8
        Me.vhf930Label.Text = "930:"
        '
        'vhf710NumericUpDown
        '
        Me.vhf710NumericUpDown.Location = New System.Drawing.Point(80, 77)
        Me.vhf710NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhf710NumericUpDown.Name = "vhf710NumericUpDown"
        Me.vhf710NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhf710NumericUpDown.TabIndex = 6
        '
        'vhf710Label
        '
        Me.vhf710Label.AutoSize = True
        Me.vhf710Label.Location = New System.Drawing.Point(42, 79)
        Me.vhf710Label.Name = "vhf710Label"
        Me.vhf710Label.Size = New System.Drawing.Size(32, 16)
        Me.vhf710Label.TabIndex = 5
        Me.vhf710Label.Text = "710:"
        '
        'vhf7330NumericUpDown
        '
        Me.vhf7330NumericUpDown.Location = New System.Drawing.Point(80, 50)
        Me.vhf7330NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhf7330NumericUpDown.Name = "vhf7330NumericUpDown"
        Me.vhf7330NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhf7330NumericUpDown.TabIndex = 3
        '
        'vhf7330Label
        '
        Me.vhf7330Label.AutoSize = True
        Me.vhf7330Label.Location = New System.Drawing.Point(35, 52)
        Me.vhf7330Label.Name = "vhf7330Label"
        Me.vhf7330Label.Size = New System.Drawing.Size(39, 16)
        Me.vhf7330Label.TabIndex = 2
        Me.vhf7330Label.Text = "7330:"
        '
        'armamentoGroupBox
        '
        Me.armamentoGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.armamentoGroupBox.Controls.Add(Me.atras4LinkLabel)
        Me.armamentoGroupBox.Controls.Add(Me.siguiente10LinkLabel)
        Me.armamentoGroupBox.Controls.Add(Me.morterosGroupBox)
        Me.armamentoGroupBox.Controls.Add(Me.lanzagranadasGroupBox)
        Me.armamentoGroupBox.Controls.Add(Me.granadasGroupBox)
        Me.armamentoGroupBox.Controls.Add(Me.fusilesGroupBox)
        Me.armamentoGroupBox.Controls.Add(Me.equiposEspecialesGroupBox)
        Me.armamentoGroupBox.Controls.Add(Me.ametralladorasGroupBox)
        Me.armamentoGroupBox.ForeColor = System.Drawing.Color.White
        Me.armamentoGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.armamentoGroupBox.Name = "armamentoGroupBox"
        Me.armamentoGroupBox.Size = New System.Drawing.Size(1150, 509)
        Me.armamentoGroupBox.TabIndex = 15
        Me.armamentoGroupBox.TabStop = False
        Me.armamentoGroupBox.Text = "Armamento"
        '
        'atras4LinkLabel
        '
        Me.atras4LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras4LinkLabel.AutoSize = True
        Me.atras4LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras4LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras4LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras4LinkLabel.Name = "atras4LinkLabel"
        Me.atras4LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras4LinkLabel.TabIndex = 25
        Me.atras4LinkLabel.TabStop = True
        Me.atras4LinkLabel.Text = "Atrás"
        Me.atras4LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente10LinkLabel
        '
        Me.siguiente10LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente10LinkLabel.AutoSize = True
        Me.siguiente10LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente10LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente10LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente10LinkLabel.Name = "siguiente10LinkLabel"
        Me.siguiente10LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente10LinkLabel.TabIndex = 8
        Me.siguiente10LinkLabel.TabStop = True
        Me.siguiente10LinkLabel.Text = "Siguiente"
        Me.siguiente10LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'morterosGroupBox
        '
        Me.morterosGroupBox.Controls.Add(Me.m_brandt_60mmNumericUpDown)
        Me.morterosGroupBox.Controls.Add(Me.m_brandt_60mmLabel)
        Me.morterosGroupBox.Controls.Add(Me.mc_fms_60mmNumericUpDown)
        Me.morterosGroupBox.Controls.Add(Me.mc_fms_60mmLabel)
        Me.morterosGroupBox.Controls.Add(Me.otrosMorterosTextBox)
        Me.morterosGroupBox.Controls.Add(Me.otrosMorterosLabel)
        Me.morterosGroupBox.Controls.Add(Me.mc_c575_60mmNumericUpDown)
        Me.morterosGroupBox.Controls.Add(Me.mc_c575_60mmLabel)
        Me.morterosGroupBox.Controls.Add(Me.mc_c370_60mmNumericUpDown)
        Me.morterosGroupBox.Controls.Add(Me.mc_c370_60mmLabel)
        Me.morterosGroupBox.ForeColor = System.Drawing.Color.White
        Me.morterosGroupBox.Location = New System.Drawing.Point(503, 24)
        Me.morterosGroupBox.Name = "morterosGroupBox"
        Me.morterosGroupBox.Size = New System.Drawing.Size(244, 254)
        Me.morterosGroupBox.TabIndex = 2
        Me.morterosGroupBox.TabStop = False
        Me.morterosGroupBox.Text = "Morteros"
        '
        'm_brandt_60mmNumericUpDown
        '
        Me.m_brandt_60mmNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_brandt_60mmNumericUpDown.Location = New System.Drawing.Point(154, 109)
        Me.m_brandt_60mmNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m_brandt_60mmNumericUpDown.Name = "m_brandt_60mmNumericUpDown"
        Me.m_brandt_60mmNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m_brandt_60mmNumericUpDown.TabIndex = 7
        '
        'm_brandt_60mmLabel
        '
        Me.m_brandt_60mmLabel.AutoSize = True
        Me.m_brandt_60mmLabel.Location = New System.Drawing.Point(44, 112)
        Me.m_brandt_60mmLabel.Name = "m_brandt_60mmLabel"
        Me.m_brandt_60mmLabel.Size = New System.Drawing.Size(107, 16)
        Me.m_brandt_60mmLabel.TabIndex = 6
        Me.m_brandt_60mmLabel.Text = "BRANDT 60MM:"
        '
        'mc_fms_60mmNumericUpDown
        '
        Me.mc_fms_60mmNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mc_fms_60mmNumericUpDown.Location = New System.Drawing.Point(154, 82)
        Me.mc_fms_60mmNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mc_fms_60mmNumericUpDown.Name = "mc_fms_60mmNumericUpDown"
        Me.mc_fms_60mmNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.mc_fms_60mmNumericUpDown.TabIndex = 5
        '
        'mc_fms_60mmLabel
        '
        Me.mc_fms_60mmLabel.AutoSize = True
        Me.mc_fms_60mmLabel.Location = New System.Drawing.Point(11, 84)
        Me.mc_fms_60mmLabel.Name = "mc_fms_60mmLabel"
        Me.mc_fms_60mmLabel.Size = New System.Drawing.Size(140, 16)
        Me.mc_fms_60mmLabel.TabIndex = 4
        Me.mc_fms_60mmLabel.Text = "Comando FMS 60MM:"
        '
        'otrosMorterosTextBox
        '
        Me.otrosMorterosTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otrosMorterosTextBox.Location = New System.Drawing.Point(9, 197)
        Me.otrosMorterosTextBox.Multiline = True
        Me.otrosMorterosTextBox.Name = "otrosMorterosTextBox"
        Me.otrosMorterosTextBox.Size = New System.Drawing.Size(219, 51)
        Me.otrosMorterosTextBox.TabIndex = 9
        '
        'otrosMorterosLabel
        '
        Me.otrosMorterosLabel.AutoSize = True
        Me.otrosMorterosLabel.Location = New System.Drawing.Point(9, 175)
        Me.otrosMorterosLabel.Name = "otrosMorterosLabel"
        Me.otrosMorterosLabel.Size = New System.Drawing.Size(99, 16)
        Me.otrosMorterosLabel.TabIndex = 8
        Me.otrosMorterosLabel.Text = "Otros morteros:"
        '
        'mc_c575_60mmNumericUpDown
        '
        Me.mc_c575_60mmNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mc_c575_60mmNumericUpDown.Location = New System.Drawing.Point(154, 54)
        Me.mc_c575_60mmNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mc_c575_60mmNumericUpDown.Name = "mc_c575_60mmNumericUpDown"
        Me.mc_c575_60mmNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.mc_c575_60mmNumericUpDown.TabIndex = 3
        '
        'mc_c575_60mmLabel
        '
        Me.mc_c575_60mmLabel.AutoSize = True
        Me.mc_c575_60mmLabel.Location = New System.Drawing.Point(9, 57)
        Me.mc_c575_60mmLabel.Name = "mc_c575_60mmLabel"
        Me.mc_c575_60mmLabel.Size = New System.Drawing.Size(142, 16)
        Me.mc_c575_60mmLabel.TabIndex = 2
        Me.mc_c575_60mmLabel.Text = "Comando C575 60MM:"
        '
        'mc_c370_60mmNumericUpDown
        '
        Me.mc_c370_60mmNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mc_c370_60mmNumericUpDown.Location = New System.Drawing.Point(154, 27)
        Me.mc_c370_60mmNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mc_c370_60mmNumericUpDown.Name = "mc_c370_60mmNumericUpDown"
        Me.mc_c370_60mmNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.mc_c370_60mmNumericUpDown.TabIndex = 1
        '
        'mc_c370_60mmLabel
        '
        Me.mc_c370_60mmLabel.AutoSize = True
        Me.mc_c370_60mmLabel.Location = New System.Drawing.Point(9, 29)
        Me.mc_c370_60mmLabel.Name = "mc_c370_60mmLabel"
        Me.mc_c370_60mmLabel.Size = New System.Drawing.Size(142, 16)
        Me.mc_c370_60mmLabel.TabIndex = 0
        Me.mc_c370_60mmLabel.Text = "Comando C370 60MM:"
        '
        'lanzagranadasGroupBox
        '
        Me.lanzagranadasGroupBox.Controls.Add(Me.otrosLanzagranadasTextBox)
        Me.lanzagranadasGroupBox.Controls.Add(Me.otrosLanzagranadasLabel)
        Me.lanzagranadasGroupBox.Controls.Add(Me.m79NumericUpDown)
        Me.lanzagranadasGroupBox.Controls.Add(Me.m79Label)
        Me.lanzagranadasGroupBox.Controls.Add(Me.mkNumericUpDown)
        Me.lanzagranadasGroupBox.Controls.Add(Me.mkLabel)
        Me.lanzagranadasGroupBox.Controls.Add(Me.mglNumericUpDown)
        Me.lanzagranadasGroupBox.Controls.Add(Me.mglLabel)
        Me.lanzagranadasGroupBox.ForeColor = System.Drawing.Color.White
        Me.lanzagranadasGroupBox.Location = New System.Drawing.Point(263, 298)
        Me.lanzagranadasGroupBox.Name = "lanzagranadasGroupBox"
        Me.lanzagranadasGroupBox.Size = New System.Drawing.Size(200, 193)
        Me.lanzagranadasGroupBox.TabIndex = 5
        Me.lanzagranadasGroupBox.TabStop = False
        Me.lanzagranadasGroupBox.Text = "Lanzagranadas"
        '
        'otrosLanzagranadasTextBox
        '
        Me.otrosLanzagranadasTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otrosLanzagranadasTextBox.Location = New System.Drawing.Point(12, 136)
        Me.otrosLanzagranadasTextBox.Multiline = True
        Me.otrosLanzagranadasTextBox.Name = "otrosLanzagranadasTextBox"
        Me.otrosLanzagranadasTextBox.Size = New System.Drawing.Size(173, 51)
        Me.otrosLanzagranadasTextBox.TabIndex = 7
        '
        'otrosLanzagranadasLabel
        '
        Me.otrosLanzagranadasLabel.AutoSize = True
        Me.otrosLanzagranadasLabel.Location = New System.Drawing.Point(15, 113)
        Me.otrosLanzagranadasLabel.Name = "otrosLanzagranadasLabel"
        Me.otrosLanzagranadasLabel.Size = New System.Drawing.Size(122, 16)
        Me.otrosLanzagranadasLabel.TabIndex = 6
        Me.otrosLanzagranadasLabel.Text = "Otros langranadas:"
        Me.otrosLanzagranadasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'm79NumericUpDown
        '
        Me.m79NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m79NumericUpDown.Location = New System.Drawing.Point(110, 81)
        Me.m79NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m79NumericUpDown.Name = "m79NumericUpDown"
        Me.m79NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m79NumericUpDown.TabIndex = 5
        '
        'm79Label
        '
        Me.m79Label.AutoSize = True
        Me.m79Label.Location = New System.Drawing.Point(69, 84)
        Me.m79Label.Name = "m79Label"
        Me.m79Label.Size = New System.Drawing.Size(36, 16)
        Me.m79Label.TabIndex = 4
        Me.m79Label.Text = "M79:"
        '
        'mkNumericUpDown
        '
        Me.mkNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mkNumericUpDown.Location = New System.Drawing.Point(110, 54)
        Me.mkNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mkNumericUpDown.Name = "mkNumericUpDown"
        Me.mkNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.mkNumericUpDown.TabIndex = 3
        '
        'mkLabel
        '
        Me.mkLabel.AutoSize = True
        Me.mkLabel.Location = New System.Drawing.Point(75, 57)
        Me.mkLabel.Name = "mkLabel"
        Me.mkLabel.Size = New System.Drawing.Size(30, 16)
        Me.mkLabel.TabIndex = 2
        Me.mkLabel.Text = "MK:"
        '
        'mglNumericUpDown
        '
        Me.mglNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mglNumericUpDown.Location = New System.Drawing.Point(110, 27)
        Me.mglNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mglNumericUpDown.Name = "mglNumericUpDown"
        Me.mglNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.mglNumericUpDown.TabIndex = 1
        '
        'mglLabel
        '
        Me.mglLabel.AutoSize = True
        Me.mglLabel.Location = New System.Drawing.Point(66, 31)
        Me.mglLabel.Name = "mglLabel"
        Me.mglLabel.Size = New System.Drawing.Size(39, 16)
        Me.mglLabel.TabIndex = 0
        Me.mglLabel.Text = "MGL:"
        '
        'granadasGroupBox
        '
        Me.granadasGroupBox.Controls.Add(Me.otrasGranadasTextBox)
        Me.granadasGroupBox.Controls.Add(Me.otrasGranadasLabel)
        Me.granadasGroupBox.Controls.Add(Me.lacrimogenaNumericUpDown)
        Me.granadasGroupBox.Controls.Add(Me.lacrimogenaLabel)
        Me.granadasGroupBox.Controls.Add(Me.humoNumericUpDown)
        Me.granadasGroupBox.Controls.Add(Me.humoLabel)
        Me.granadasGroupBox.Controls.Add(Me.manoNumericUpDown)
        Me.granadasGroupBox.Controls.Add(Me.manoLabel)
        Me.granadasGroupBox.ForeColor = System.Drawing.Color.White
        Me.granadasGroupBox.Location = New System.Drawing.Point(23, 298)
        Me.granadasGroupBox.Name = "granadasGroupBox"
        Me.granadasGroupBox.Size = New System.Drawing.Size(200, 193)
        Me.granadasGroupBox.TabIndex = 4
        Me.granadasGroupBox.TabStop = False
        Me.granadasGroupBox.Text = "Granadas"
        '
        'otrasGranadasTextBox
        '
        Me.otrasGranadasTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otrasGranadasTextBox.Location = New System.Drawing.Point(14, 136)
        Me.otrasGranadasTextBox.Multiline = True
        Me.otrasGranadasTextBox.Name = "otrasGranadasTextBox"
        Me.otrasGranadasTextBox.Size = New System.Drawing.Size(173, 51)
        Me.otrasGranadasTextBox.TabIndex = 7
        '
        'otrasGranadasLabel
        '
        Me.otrasGranadasLabel.AutoSize = True
        Me.otrasGranadasLabel.Location = New System.Drawing.Point(17, 113)
        Me.otrasGranadasLabel.Name = "otrasGranadasLabel"
        Me.otrasGranadasLabel.Size = New System.Drawing.Size(104, 16)
        Me.otrasGranadasLabel.TabIndex = 6
        Me.otrasGranadasLabel.Text = "Otras granadas:"
        Me.otrasGranadasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lacrimogenaNumericUpDown
        '
        Me.lacrimogenaNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lacrimogenaNumericUpDown.Location = New System.Drawing.Point(113, 79)
        Me.lacrimogenaNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.lacrimogenaNumericUpDown.Name = "lacrimogenaNumericUpDown"
        Me.lacrimogenaNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.lacrimogenaNumericUpDown.TabIndex = 5
        '
        'lacrimogenaLabel
        '
        Me.lacrimogenaLabel.AutoSize = True
        Me.lacrimogenaLabel.Location = New System.Drawing.Point(19, 81)
        Me.lacrimogenaLabel.Name = "lacrimogenaLabel"
        Me.lacrimogenaLabel.Size = New System.Drawing.Size(90, 16)
        Me.lacrimogenaLabel.TabIndex = 4
        Me.lacrimogenaLabel.Text = "Lacrimógena:"
        Me.lacrimogenaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'humoNumericUpDown
        '
        Me.humoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.humoNumericUpDown.Location = New System.Drawing.Point(113, 54)
        Me.humoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.humoNumericUpDown.Name = "humoNumericUpDown"
        Me.humoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.humoNumericUpDown.TabIndex = 3
        '
        'humoLabel
        '
        Me.humoLabel.AutoSize = True
        Me.humoLabel.Location = New System.Drawing.Point(44, 56)
        Me.humoLabel.Name = "humoLabel"
        Me.humoLabel.Size = New System.Drawing.Size(65, 16)
        Me.humoLabel.TabIndex = 2
        Me.humoLabel.Text = "De humo:"
        '
        'manoNumericUpDown
        '
        Me.manoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.manoNumericUpDown.Location = New System.Drawing.Point(113, 29)
        Me.manoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.manoNumericUpDown.Name = "manoNumericUpDown"
        Me.manoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.manoNumericUpDown.TabIndex = 1
        '
        'manoLabel
        '
        Me.manoLabel.AutoSize = True
        Me.manoLabel.Location = New System.Drawing.Point(43, 31)
        Me.manoLabel.Name = "manoLabel"
        Me.manoLabel.Size = New System.Drawing.Size(66, 16)
        Me.manoLabel.TabIndex = 0
        Me.manoLabel.Text = "De mano:"
        '
        'fusilesGroupBox
        '
        Me.fusilesGroupBox.Controls.Add(Me.m16_a203Label)
        Me.fusilesGroupBox.Controls.Add(Me.m16_m4Label)
        Me.fusilesGroupBox.Controls.Add(Me.m16_a2Label)
        Me.fusilesGroupBox.Controls.Add(Me.m16_a203NumericUpDown)
        Me.fusilesGroupBox.Controls.Add(Me.m16_m4NumericUpDown)
        Me.fusilesGroupBox.Controls.Add(Me.m16_a2NumericUpDown)
        Me.fusilesGroupBox.Controls.Add(Me.otrosFusilesTextBox)
        Me.fusilesGroupBox.Controls.Add(Me.otrosFusilesLabel)
        Me.fusilesGroupBox.Controls.Add(Me.galil_iceNumericUpDown)
        Me.fusilesGroupBox.Controls.Add(Me.galil_iceLabel)
        Me.fusilesGroupBox.Controls.Add(Me.galil_arNumericUpDown)
        Me.fusilesGroupBox.Controls.Add(Me.galil_arLabel)
        Me.fusilesGroupBox.ForeColor = System.Drawing.Color.White
        Me.fusilesGroupBox.Location = New System.Drawing.Point(263, 24)
        Me.fusilesGroupBox.Name = "fusilesGroupBox"
        Me.fusilesGroupBox.Size = New System.Drawing.Size(200, 254)
        Me.fusilesGroupBox.TabIndex = 1
        Me.fusilesGroupBox.TabStop = False
        Me.fusilesGroupBox.Text = "Fusiles"
        '
        'm16_a203Label
        '
        Me.m16_a203Label.AutoSize = True
        Me.m16_a203Label.Location = New System.Drawing.Point(41, 131)
        Me.m16_a203Label.Name = "m16_a203Label"
        Me.m16_a203Label.Size = New System.Drawing.Size(69, 16)
        Me.m16_a203Label.TabIndex = 8
        Me.m16_a203Label.Text = "M16 A203:"
        '
        'm16_m4Label
        '
        Me.m16_m4Label.AutoSize = True
        Me.m16_m4Label.Location = New System.Drawing.Point(53, 106)
        Me.m16_m4Label.Name = "m16_m4Label"
        Me.m16_m4Label.Size = New System.Drawing.Size(57, 16)
        Me.m16_m4Label.TabIndex = 6
        Me.m16_m4Label.Text = "M16 M4:"
        '
        'm16_a2Label
        '
        Me.m16_a2Label.AutoSize = True
        Me.m16_a2Label.Location = New System.Drawing.Point(55, 81)
        Me.m16_a2Label.Name = "m16_a2Label"
        Me.m16_a2Label.Size = New System.Drawing.Size(55, 16)
        Me.m16_a2Label.TabIndex = 4
        Me.m16_a2Label.Text = "M16 A2:"
        '
        'm16_a203NumericUpDown
        '
        Me.m16_a203NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m16_a203NumericUpDown.Location = New System.Drawing.Point(113, 131)
        Me.m16_a203NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m16_a203NumericUpDown.Name = "m16_a203NumericUpDown"
        Me.m16_a203NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m16_a203NumericUpDown.TabIndex = 9
        '
        'm16_m4NumericUpDown
        '
        Me.m16_m4NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m16_m4NumericUpDown.Location = New System.Drawing.Point(113, 105)
        Me.m16_m4NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m16_m4NumericUpDown.Name = "m16_m4NumericUpDown"
        Me.m16_m4NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m16_m4NumericUpDown.TabIndex = 7
        '
        'm16_a2NumericUpDown
        '
        Me.m16_a2NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m16_a2NumericUpDown.Location = New System.Drawing.Point(113, 79)
        Me.m16_a2NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m16_a2NumericUpDown.Name = "m16_a2NumericUpDown"
        Me.m16_a2NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m16_a2NumericUpDown.TabIndex = 5
        '
        'otrosFusilesTextBox
        '
        Me.otrosFusilesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otrosFusilesTextBox.Location = New System.Drawing.Point(9, 197)
        Me.otrosFusilesTextBox.Multiline = True
        Me.otrosFusilesTextBox.Name = "otrosFusilesTextBox"
        Me.otrosFusilesTextBox.Size = New System.Drawing.Size(179, 51)
        Me.otrosFusilesTextBox.TabIndex = 11
        '
        'otrosFusilesLabel
        '
        Me.otrosFusilesLabel.AutoSize = True
        Me.otrosFusilesLabel.Location = New System.Drawing.Point(12, 176)
        Me.otrosFusilesLabel.Name = "otrosFusilesLabel"
        Me.otrosFusilesLabel.Size = New System.Drawing.Size(84, 16)
        Me.otrosFusilesLabel.TabIndex = 10
        Me.otrosFusilesLabel.Text = "Otros fusiles:"
        '
        'galil_iceNumericUpDown
        '
        Me.galil_iceNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.galil_iceNumericUpDown.Location = New System.Drawing.Point(113, 53)
        Me.galil_iceNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.galil_iceNumericUpDown.Name = "galil_iceNumericUpDown"
        Me.galil_iceNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.galil_iceNumericUpDown.TabIndex = 3
        '
        'galil_iceLabel
        '
        Me.galil_iceLabel.AutoSize = True
        Me.galil_iceLabel.Location = New System.Drawing.Point(39, 56)
        Me.galil_iceLabel.Name = "galil_iceLabel"
        Me.galil_iceLabel.Size = New System.Drawing.Size(71, 16)
        Me.galil_iceLabel.TabIndex = 2
        Me.galil_iceLabel.Text = "GALIL ICE:"
        '
        'galil_arNumericUpDown
        '
        Me.galil_arNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.galil_arNumericUpDown.Location = New System.Drawing.Point(113, 27)
        Me.galil_arNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.galil_arNumericUpDown.Name = "galil_arNumericUpDown"
        Me.galil_arNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.galil_arNumericUpDown.TabIndex = 1
        '
        'galil_arLabel
        '
        Me.galil_arLabel.AutoSize = True
        Me.galil_arLabel.Location = New System.Drawing.Point(41, 31)
        Me.galil_arLabel.Name = "galil_arLabel"
        Me.galil_arLabel.Size = New System.Drawing.Size(69, 16)
        Me.galil_arLabel.TabIndex = 0
        Me.galil_arLabel.Text = "GALIL AR:"
        '
        'equiposEspecialesGroupBox
        '
        Me.equiposEspecialesGroupBox.Controls.Add(Me.otrosEquiposTextBox)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.otrosEquiposLabel)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.kitOrientacionNocturnoNumericUpDown)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.kitOrientacionNocturnoLabel)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.flasmersNumericUpDown)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.flasmersLabel)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.camaraTermicaNumericUpDown)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.camaraTermicaLabel)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.binocularesNumericUpDown)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.binocularesLabel)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.visorNocturnoNumericUpDown)
        Me.equiposEspecialesGroupBox.Controls.Add(Me.visorNocturnoLabel)
        Me.equiposEspecialesGroupBox.ForeColor = System.Drawing.Color.White
        Me.equiposEspecialesGroupBox.Location = New System.Drawing.Point(787, 24)
        Me.equiposEspecialesGroupBox.Name = "equiposEspecialesGroupBox"
        Me.equiposEspecialesGroupBox.Size = New System.Drawing.Size(220, 254)
        Me.equiposEspecialesGroupBox.TabIndex = 3
        Me.equiposEspecialesGroupBox.TabStop = False
        Me.equiposEspecialesGroupBox.Text = "Equipos especiales"
        '
        'otrosEquiposTextBox
        '
        Me.otrosEquiposTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otrosEquiposTextBox.Location = New System.Drawing.Point(16, 197)
        Me.otrosEquiposTextBox.Multiline = True
        Me.otrosEquiposTextBox.Name = "otrosEquiposTextBox"
        Me.otrosEquiposTextBox.Size = New System.Drawing.Size(188, 51)
        Me.otrosEquiposTextBox.TabIndex = 11
        '
        'otrosEquiposLabel
        '
        Me.otrosEquiposLabel.AutoSize = True
        Me.otrosEquiposLabel.Location = New System.Drawing.Point(19, 175)
        Me.otrosEquiposLabel.Name = "otrosEquiposLabel"
        Me.otrosEquiposLabel.Size = New System.Drawing.Size(95, 16)
        Me.otrosEquiposLabel.TabIndex = 10
        Me.otrosEquiposLabel.Text = "Otros equipos:"
        Me.otrosEquiposLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'kitOrientacionNocturnoNumericUpDown
        '
        Me.kitOrientacionNocturnoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kitOrientacionNocturnoNumericUpDown.Location = New System.Drawing.Point(130, 127)
        Me.kitOrientacionNocturnoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.kitOrientacionNocturnoNumericUpDown.Name = "kitOrientacionNocturnoNumericUpDown"
        Me.kitOrientacionNocturnoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.kitOrientacionNocturnoNumericUpDown.TabIndex = 9
        '
        'kitOrientacionNocturnoLabel
        '
        Me.kitOrientacionNocturnoLabel.AutoSize = True
        Me.kitOrientacionNocturnoLabel.Location = New System.Drawing.Point(13, 129)
        Me.kitOrientacionNocturnoLabel.Name = "kitOrientacionNocturnoLabel"
        Me.kitOrientacionNocturnoLabel.Size = New System.Drawing.Size(113, 32)
        Me.kitOrientacionNocturnoLabel.TabIndex = 8
        Me.kitOrientacionNocturnoLabel.Text = "Kit de orientación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nocturno:"
        Me.kitOrientacionNocturnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flasmersNumericUpDown
        '
        Me.flasmersNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flasmersNumericUpDown.Location = New System.Drawing.Point(130, 102)
        Me.flasmersNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.flasmersNumericUpDown.Name = "flasmersNumericUpDown"
        Me.flasmersNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.flasmersNumericUpDown.TabIndex = 7
        '
        'flasmersLabel
        '
        Me.flasmersLabel.AutoSize = True
        Me.flasmersLabel.Location = New System.Drawing.Point(59, 104)
        Me.flasmersLabel.Name = "flasmersLabel"
        Me.flasmersLabel.Size = New System.Drawing.Size(67, 16)
        Me.flasmersLabel.TabIndex = 6
        Me.flasmersLabel.Text = "Flasmers:"
        '
        'camaraTermicaNumericUpDown
        '
        Me.camaraTermicaNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.camaraTermicaNumericUpDown.Location = New System.Drawing.Point(130, 77)
        Me.camaraTermicaNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.camaraTermicaNumericUpDown.Name = "camaraTermicaNumericUpDown"
        Me.camaraTermicaNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.camaraTermicaNumericUpDown.TabIndex = 5
        '
        'camaraTermicaLabel
        '
        Me.camaraTermicaLabel.AutoSize = True
        Me.camaraTermicaLabel.Location = New System.Drawing.Point(20, 79)
        Me.camaraTermicaLabel.Name = "camaraTermicaLabel"
        Me.camaraTermicaLabel.Size = New System.Drawing.Size(106, 16)
        Me.camaraTermicaLabel.TabIndex = 4
        Me.camaraTermicaLabel.Text = "Cámara térmica:"
        '
        'binocularesNumericUpDown
        '
        Me.binocularesNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.binocularesNumericUpDown.Location = New System.Drawing.Point(130, 52)
        Me.binocularesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.binocularesNumericUpDown.Name = "binocularesNumericUpDown"
        Me.binocularesNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.binocularesNumericUpDown.TabIndex = 3
        '
        'binocularesLabel
        '
        Me.binocularesLabel.AutoSize = True
        Me.binocularesLabel.Location = New System.Drawing.Point(44, 54)
        Me.binocularesLabel.Name = "binocularesLabel"
        Me.binocularesLabel.Size = New System.Drawing.Size(82, 16)
        Me.binocularesLabel.TabIndex = 2
        Me.binocularesLabel.Text = "Binoculares:"
        '
        'visorNocturnoNumericUpDown
        '
        Me.visorNocturnoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.visorNocturnoNumericUpDown.Location = New System.Drawing.Point(130, 27)
        Me.visorNocturnoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.visorNocturnoNumericUpDown.Name = "visorNocturnoNumericUpDown"
        Me.visorNocturnoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.visorNocturnoNumericUpDown.TabIndex = 1
        '
        'visorNocturnoLabel
        '
        Me.visorNocturnoLabel.AutoSize = True
        Me.visorNocturnoLabel.Location = New System.Drawing.Point(27, 29)
        Me.visorNocturnoLabel.Name = "visorNocturnoLabel"
        Me.visorNocturnoLabel.Size = New System.Drawing.Size(99, 16)
        Me.visorNocturnoLabel.TabIndex = 0
        Me.visorNocturnoLabel.Text = "Visor Nocturno:"
        '
        'ametralladorasGroupBox
        '
        Me.ametralladorasGroupBox.Controls.Add(Me.otrasAmetralladorasTextBox)
        Me.ametralladorasGroupBox.Controls.Add(Me.otrasAmetralladorasLabel)
        Me.ametralladorasGroupBox.Controls.Add(Me.punto50NumericUpDown)
        Me.ametralladorasGroupBox.Controls.Add(Me.punto50Label)
        Me.ametralladorasGroupBox.Controls.Add(Me.ss77NumericUpDown)
        Me.ametralladorasGroupBox.Controls.Add(Me.ss77Label)
        Me.ametralladorasGroupBox.Controls.Add(Me.M249NumericUpDown)
        Me.ametralladorasGroupBox.Controls.Add(Me.M249Label)
        Me.ametralladorasGroupBox.Controls.Add(Me.m60E4NumericUpDown)
        Me.ametralladorasGroupBox.Controls.Add(Me.m60E4Label)
        Me.ametralladorasGroupBox.Controls.Add(Me.m60EstandarNumericUpDown)
        Me.ametralladorasGroupBox.Controls.Add(Me.m60EstandarLabel)
        Me.ametralladorasGroupBox.ForeColor = System.Drawing.Color.White
        Me.ametralladorasGroupBox.Location = New System.Drawing.Point(23, 24)
        Me.ametralladorasGroupBox.Name = "ametralladorasGroupBox"
        Me.ametralladorasGroupBox.Size = New System.Drawing.Size(200, 257)
        Me.ametralladorasGroupBox.TabIndex = 0
        Me.ametralladorasGroupBox.TabStop = False
        Me.ametralladorasGroupBox.Text = "Ametralladoras"
        '
        'otrasAmetralladorasTextBox
        '
        Me.otrasAmetralladorasTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.otrasAmetralladorasTextBox.Location = New System.Drawing.Point(6, 200)
        Me.otrasAmetralladorasTextBox.Multiline = True
        Me.otrasAmetralladorasTextBox.Name = "otrasAmetralladorasTextBox"
        Me.otrasAmetralladorasTextBox.Size = New System.Drawing.Size(188, 51)
        Me.otrasAmetralladorasTextBox.TabIndex = 11
        '
        'otrasAmetralladorasLabel
        '
        Me.otrasAmetralladorasLabel.AutoSize = True
        Me.otrasAmetralladorasLabel.Location = New System.Drawing.Point(7, 179)
        Me.otrasAmetralladorasLabel.Name = "otrasAmetralladorasLabel"
        Me.otrasAmetralladorasLabel.Size = New System.Drawing.Size(137, 16)
        Me.otrasAmetralladorasLabel.TabIndex = 10
        Me.otrasAmetralladorasLabel.Text = "Otras ametralladoras:"
        Me.otrasAmetralladorasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'punto50NumericUpDown
        '
        Me.punto50NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.punto50NumericUpDown.Location = New System.Drawing.Point(110, 135)
        Me.punto50NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.punto50NumericUpDown.Name = "punto50NumericUpDown"
        Me.punto50NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.punto50NumericUpDown.TabIndex = 9
        '
        'punto50Label
        '
        Me.punto50Label.AutoSize = True
        Me.punto50Label.Location = New System.Drawing.Point(79, 137)
        Me.punto50Label.Name = "punto50Label"
        Me.punto50Label.Size = New System.Drawing.Size(28, 16)
        Me.punto50Label.TabIndex = 8
        Me.punto50Label.Text = ".50:"
        '
        'ss77NumericUpDown
        '
        Me.ss77NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ss77NumericUpDown.Location = New System.Drawing.Point(110, 108)
        Me.ss77NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.ss77NumericUpDown.Name = "ss77NumericUpDown"
        Me.ss77NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.ss77NumericUpDown.TabIndex = 7
        '
        'ss77Label
        '
        Me.ss77Label.AutoSize = True
        Me.ss77Label.Location = New System.Drawing.Point(64, 110)
        Me.ss77Label.Name = "ss77Label"
        Me.ss77Label.Size = New System.Drawing.Size(43, 16)
        Me.ss77Label.TabIndex = 6
        Me.ss77Label.Text = "SS77:"
        '
        'M249NumericUpDown
        '
        Me.M249NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.M249NumericUpDown.Location = New System.Drawing.Point(110, 81)
        Me.M249NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.M249NumericUpDown.Name = "M249NumericUpDown"
        Me.M249NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.M249NumericUpDown.TabIndex = 5
        '
        'M249Label
        '
        Me.M249Label.AutoSize = True
        Me.M249Label.Location = New System.Drawing.Point(64, 82)
        Me.M249Label.Name = "M249Label"
        Me.M249Label.Size = New System.Drawing.Size(43, 16)
        Me.M249Label.TabIndex = 4
        Me.M249Label.Text = "M249:"
        '
        'm60E4NumericUpDown
        '
        Me.m60E4NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m60E4NumericUpDown.Location = New System.Drawing.Point(110, 54)
        Me.m60E4NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m60E4NumericUpDown.Name = "m60E4NumericUpDown"
        Me.m60E4NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m60E4NumericUpDown.TabIndex = 3
        '
        'm60E4Label
        '
        Me.m60E4Label.AutoSize = True
        Me.m60E4Label.Location = New System.Drawing.Point(52, 56)
        Me.m60E4Label.Name = "m60E4Label"
        Me.m60E4Label.Size = New System.Drawing.Size(55, 16)
        Me.m60E4Label.TabIndex = 2
        Me.m60E4Label.Text = "M60 E4:"
        '
        'm60EstandarNumericUpDown
        '
        Me.m60EstandarNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m60EstandarNumericUpDown.Location = New System.Drawing.Point(110, 27)
        Me.m60EstandarNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m60EstandarNumericUpDown.Name = "m60EstandarNumericUpDown"
        Me.m60EstandarNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m60EstandarNumericUpDown.TabIndex = 1
        '
        'm60EstandarLabel
        '
        Me.m60EstandarLabel.AutoSize = True
        Me.m60EstandarLabel.Location = New System.Drawing.Point(15, 29)
        Me.m60EstandarLabel.Name = "m60EstandarLabel"
        Me.m60EstandarLabel.Size = New System.Drawing.Size(92, 16)
        Me.m60EstandarLabel.TabIndex = 0
        Me.m60EstandarLabel.Text = "M60 estándar:"
        '
        'situacionGroupBox
        '
        Me.situacionGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.situacionGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.situacionGroupBox.Controls.Add(Me.segregacionesSituacionRichTextBox)
        Me.situacionGroupBox.Controls.Add(Me.agregacionesSituacionRichTextBox)
        Me.situacionGroupBox.Controls.Add(Me.propiasTropasRichTextBox)
        Me.situacionGroupBox.Controls.Add(Me.enemigoRichTextBox)
        Me.situacionGroupBox.Controls.Add(Me.atras11LinkLabel)
        Me.situacionGroupBox.Controls.Add(Me.siguiente2LinkLabel)
        Me.situacionGroupBox.Controls.Add(segregacionesSituacionLabel)
        Me.situacionGroupBox.Controls.Add(agregacionesSituacionLabel)
        Me.situacionGroupBox.Controls.Add(propiasTropasLabel)
        Me.situacionGroupBox.Controls.Add(detalleSituacionLabel)
        Me.situacionGroupBox.Controls.Add(Me.detalleSituacionRichTextBox)
        Me.situacionGroupBox.Controls.Add(enemigoLabel)
        Me.situacionGroupBox.ForeColor = System.Drawing.Color.White
        Me.situacionGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.situacionGroupBox.Name = "situacionGroupBox"
        Me.situacionGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.situacionGroupBox.TabIndex = 16
        Me.situacionGroupBox.TabStop = False
        Me.situacionGroupBox.Text = "Situación"
        '
        'atras11LinkLabel
        '
        Me.atras11LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras11LinkLabel.AutoSize = True
        Me.atras11LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras11LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras11LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras11LinkLabel.Name = "atras11LinkLabel"
        Me.atras11LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras11LinkLabel.TabIndex = 25
        Me.atras11LinkLabel.TabStop = True
        Me.atras11LinkLabel.Text = "Atrás"
        Me.atras11LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente2LinkLabel
        '
        Me.siguiente2LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente2LinkLabel.AutoSize = True
        Me.siguiente2LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente2LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente2LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente2LinkLabel.Name = "siguiente2LinkLabel"
        Me.siguiente2LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente2LinkLabel.TabIndex = 10
        Me.siguiente2LinkLabel.TabStop = True
        Me.siguiente2LinkLabel.Text = "Siguiente"
        Me.siguiente2LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'detalleSituacionRichTextBox
        '
        Me.detalleSituacionRichTextBox.Location = New System.Drawing.Point(19, 41)
        Me.detalleSituacionRichTextBox.Name = "detalleSituacionRichTextBox"
        Me.detalleSituacionRichTextBox.Size = New System.Drawing.Size(531, 440)
        Me.detalleSituacionRichTextBox.TabIndex = 1
        Me.detalleSituacionRichTextBox.Text = ""
        '
        'firmasGroupBox
        '
        Me.firmasGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.firmasGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.firmasGroupBox.Controls.Add(Me.atras1LinkLabel)
        Me.firmasGroupBox.Controls.Add(Me.distribucionGroupBox)
        Me.firmasGroupBox.Controls.Add(Me.recibeTextBox)
        Me.firmasGroupBox.Controls.Add(Me.autenticaTextBox)
        Me.firmasGroupBox.Controls.Add(Me.autorizaTextBox)
        Me.firmasGroupBox.Controls.Add(recibeLabel)
        Me.firmasGroupBox.Controls.Add(autenticaLabel)
        Me.firmasGroupBox.Controls.Add(autorizaLabel)
        Me.firmasGroupBox.ForeColor = System.Drawing.Color.White
        Me.firmasGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.firmasGroupBox.Name = "firmasGroupBox"
        Me.firmasGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.firmasGroupBox.TabIndex = 17
        Me.firmasGroupBox.TabStop = False
        Me.firmasGroupBox.Text = "Firmas"
        '
        'atras1LinkLabel
        '
        Me.atras1LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras1LinkLabel.AutoSize = True
        Me.atras1LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras1LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras1LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras1LinkLabel.Name = "atras1LinkLabel"
        Me.atras1LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras1LinkLabel.TabIndex = 29
        Me.atras1LinkLabel.TabStop = True
        Me.atras1LinkLabel.Text = "Atrás"
        Me.atras1LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'distribucionGroupBox
        '
        Me.distribucionGroupBox.Controls.Add(Me.distribucionRichTextBox)
        Me.distribucionGroupBox.ForeColor = System.Drawing.Color.White
        Me.distribucionGroupBox.Location = New System.Drawing.Point(695, 111)
        Me.distribucionGroupBox.Name = "distribucionGroupBox"
        Me.distribucionGroupBox.Size = New System.Drawing.Size(283, 196)
        Me.distribucionGroupBox.TabIndex = 28
        Me.distribucionGroupBox.TabStop = False
        Me.distribucionGroupBox.Text = "Distribución"
        '
        'recibeTextBox
        '
        Me.recibeTextBox.Location = New System.Drawing.Point(77, 247)
        Me.recibeTextBox.Multiline = True
        Me.recibeTextBox.Name = "recibeTextBox"
        Me.recibeTextBox.Size = New System.Drawing.Size(420, 60)
        Me.recibeTextBox.TabIndex = 27
        '
        'autenticaTextBox
        '
        Me.autenticaTextBox.Location = New System.Drawing.Point(77, 179)
        Me.autenticaTextBox.Multiline = True
        Me.autenticaTextBox.Name = "autenticaTextBox"
        Me.autenticaTextBox.Size = New System.Drawing.Size(420, 60)
        Me.autenticaTextBox.TabIndex = 26
        '
        'autorizaTextBox
        '
        Me.autorizaTextBox.Location = New System.Drawing.Point(77, 111)
        Me.autorizaTextBox.Multiline = True
        Me.autorizaTextBox.Name = "autorizaTextBox"
        Me.autorizaTextBox.Size = New System.Drawing.Size(420, 60)
        Me.autorizaTextBox.TabIndex = 25
        '
        'anexosGroupBox
        '
        Me.anexosGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.anexosGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.anexosGroupBox.Controls.Add(Me.atras2LinkLabel)
        Me.anexosGroupBox.Controls.Add(Me.siguiente12LinkLabel)
        Me.anexosGroupBox.Controls.Add(Me.anexosDataGridView)
        Me.anexosGroupBox.Controls.Add(Me.quitarButton)
        Me.anexosGroupBox.Controls.Add(Me.agregarAnexoButton)
        Me.anexosGroupBox.ForeColor = System.Drawing.Color.White
        Me.anexosGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.anexosGroupBox.Name = "anexosGroupBox"
        Me.anexosGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.anexosGroupBox.TabIndex = 18
        Me.anexosGroupBox.TabStop = False
        Me.anexosGroupBox.Text = "Anexos"
        '
        'atras2LinkLabel
        '
        Me.atras2LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras2LinkLabel.AutoSize = True
        Me.atras2LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras2LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras2LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras2LinkLabel.Name = "atras2LinkLabel"
        Me.atras2LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras2LinkLabel.TabIndex = 24
        Me.atras2LinkLabel.TabStop = True
        Me.atras2LinkLabel.Text = "Atrás"
        Me.atras2LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente12LinkLabel
        '
        Me.siguiente12LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente12LinkLabel.AutoSize = True
        Me.siguiente12LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente12LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente12LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente12LinkLabel.Name = "siguiente12LinkLabel"
        Me.siguiente12LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente12LinkLabel.TabIndex = 23
        Me.siguiente12LinkLabel.TabStop = True
        Me.siguiente12LinkLabel.Text = "Siguiente"
        Me.siguiente12LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'anexosDataGridView
        '
        Me.anexosDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.anexosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.anexosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.anexosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.anexosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.anexosDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.anexosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.anexosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreArchivo, Me.ruta})
        Me.anexosDataGridView.GridColor = System.Drawing.Color.Black
        Me.anexosDataGridView.Location = New System.Drawing.Point(19, 71)
        Me.anexosDataGridView.Name = "anexosDataGridView"
        Me.anexosDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.anexosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        Me.anexosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.anexosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.anexosDataGridView.Size = New System.Drawing.Size(1110, 404)
        Me.anexosDataGridView.TabIndex = 22
        '
        'nombreArchivo
        '
        Me.nombreArchivo.HeaderText = "Nombre del archivo"
        Me.nombreArchivo.Name = "nombreArchivo"
        Me.nombreArchivo.ReadOnly = True
        Me.nombreArchivo.Width = 138
        '
        'ruta
        '
        Me.ruta.HeaderText = "Ruta"
        Me.ruta.Name = "ruta"
        Me.ruta.ReadOnly = True
        Me.ruta.Width = 61
        '
        'quitarButton
        '
        Me.quitarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.quitarButton.Location = New System.Drawing.Point(204, 29)
        Me.quitarButton.Name = "quitarButton"
        Me.quitarButton.Size = New System.Drawing.Size(184, 29)
        Me.quitarButton.TabIndex = 21
        Me.quitarButton.Text = "Quitar anexo seleccionado"
        Me.quitarButton.UseVisualStyleBackColor = True
        '
        'agregarAnexoButton
        '
        Me.agregarAnexoButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.agregarAnexoButton.Location = New System.Drawing.Point(19, 29)
        Me.agregarAnexoButton.Name = "agregarAnexoButton"
        Me.agregarAnexoButton.Size = New System.Drawing.Size(179, 29)
        Me.agregarAnexoButton.TabIndex = 20
        Me.agregarAnexoButton.Text = "Agregar archivo anexo"
        Me.agregarAnexoButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Todos los archivos|*.*"
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.Title = "Seleccionar anexo"
        '
        'personalGroupBox
        '
        Me.personalGroupBox.Controls.Add(Me.personalRichTextBox)
        Me.personalGroupBox.Controls.Add(Me.atras3LinkLabel)
        Me.personalGroupBox.Controls.Add(Me.siguiente11LinkLabel)
        Me.personalGroupBox.ForeColor = System.Drawing.Color.White
        Me.personalGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.personalGroupBox.Name = "personalGroupBox"
        Me.personalGroupBox.Size = New System.Drawing.Size(1150, 497)
        Me.personalGroupBox.TabIndex = 19
        Me.personalGroupBox.TabStop = False
        Me.personalGroupBox.Text = "Personal"
        '
        'atras3LinkLabel
        '
        Me.atras3LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.atras3LinkLabel.AutoSize = True
        Me.atras3LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.atras3LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.atras3LinkLabel.Location = New System.Drawing.Point(1105, 45)
        Me.atras3LinkLabel.Name = "atras3LinkLabel"
        Me.atras3LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.atras3LinkLabel.TabIndex = 25
        Me.atras3LinkLabel.TabStop = True
        Me.atras3LinkLabel.Text = "Atrás"
        Me.atras3LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'siguiente11LinkLabel
        '
        Me.siguiente11LinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siguiente11LinkLabel.AutoSize = True
        Me.siguiente11LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.siguiente11LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.siguiente11LinkLabel.Location = New System.Drawing.Point(1080, 15)
        Me.siguiente11LinkLabel.Name = "siguiente11LinkLabel"
        Me.siguiente11LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.siguiente11LinkLabel.TabIndex = 8
        Me.siguiente11LinkLabel.TabStop = True
        Me.siguiente11LinkLabel.Text = "Siguiente"
        Me.siguiente11LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'personalRichTextBox
        '
        Me.personalRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.personalRichTextBox.Location = New System.Drawing.Point(7, 25)
        Me.personalRichTextBox.Name = "personalRichTextBox"
        Me.personalRichTextBox.Size = New System.Drawing.Size(936, 464)
        Me.personalRichTextBox.TabIndex = 26
        Me.personalRichTextBox.Text = ""
        '
        'indicativosRichTextBox
        '
        Me.indicativosRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.indicativosRichTextBox.Location = New System.Drawing.Point(7, 25)
        Me.indicativosRichTextBox.MaxLength = 32767
        Me.indicativosRichTextBox.Name = "indicativosRichTextBox"
        Me.indicativosRichTextBox.Size = New System.Drawing.Size(344, 113)
        Me.indicativosRichTextBox.TabIndex = 0
        Me.indicativosRichTextBox.Text = ""
        '
        'enemigoRichTextBox
        '
        Me.enemigoRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enemigoRichTextBox.Location = New System.Drawing.Point(590, 39)
        Me.enemigoRichTextBox.MaxLength = 32767
        Me.enemigoRichTextBox.Name = "enemigoRichTextBox"
        Me.enemigoRichTextBox.Size = New System.Drawing.Size(413, 80)
        Me.enemigoRichTextBox.TabIndex = 26
        Me.enemigoRichTextBox.Text = ""
        '
        'propiasTropasRichTextBox
        '
        Me.propiasTropasRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propiasTropasRichTextBox.Location = New System.Drawing.Point(590, 154)
        Me.propiasTropasRichTextBox.MaxLength = 32767
        Me.propiasTropasRichTextBox.Name = "propiasTropasRichTextBox"
        Me.propiasTropasRichTextBox.Size = New System.Drawing.Size(413, 80)
        Me.propiasTropasRichTextBox.TabIndex = 27
        Me.propiasTropasRichTextBox.Text = ""
        '
        'agregacionesSituacionRichTextBox
        '
        Me.agregacionesSituacionRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agregacionesSituacionRichTextBox.Location = New System.Drawing.Point(590, 279)
        Me.agregacionesSituacionRichTextBox.MaxLength = 32767
        Me.agregacionesSituacionRichTextBox.Name = "agregacionesSituacionRichTextBox"
        Me.agregacionesSituacionRichTextBox.Size = New System.Drawing.Size(413, 80)
        Me.agregacionesSituacionRichTextBox.TabIndex = 28
        Me.agregacionesSituacionRichTextBox.Text = ""
        '
        'segregacionesSituacionRichTextBox
        '
        Me.segregacionesSituacionRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.segregacionesSituacionRichTextBox.Location = New System.Drawing.Point(590, 394)
        Me.segregacionesSituacionRichTextBox.MaxLength = 32767
        Me.segregacionesSituacionRichTextBox.Name = "segregacionesSituacionRichTextBox"
        Me.segregacionesSituacionRichTextBox.Size = New System.Drawing.Size(413, 80)
        Me.segregacionesSituacionRichTextBox.TabIndex = 29
        Me.segregacionesSituacionRichTextBox.Text = ""
        '
        'detalleMisionGroupBox
        '
        Me.detalleMisionGroupBox.Controls.Add(Me.misionRichTextBox)
        Me.detalleMisionGroupBox.ForeColor = System.Drawing.Color.White
        Me.detalleMisionGroupBox.Location = New System.Drawing.Point(43, 27)
        Me.detalleMisionGroupBox.Name = "detalleMisionGroupBox"
        Me.detalleMisionGroupBox.Size = New System.Drawing.Size(596, 413)
        Me.detalleMisionGroupBox.TabIndex = 26
        Me.detalleMisionGroupBox.TabStop = False
        Me.detalleMisionGroupBox.Text = "MISIÓN"
        '
        'misionRichTextBox
        '
        Me.misionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.misionRichTextBox.Location = New System.Drawing.Point(3, 18)
        Me.misionRichTextBox.Name = "misionRichTextBox"
        Me.misionRichTextBox.Size = New System.Drawing.Size(590, 392)
        Me.misionRichTextBox.TabIndex = 0
        Me.misionRichTextBox.Text = ""
        '
        'intencionComandanteRichTextBox
        '
        Me.intencionComandanteRichTextBox.Location = New System.Drawing.Point(37, 55)
        Me.intencionComandanteRichTextBox.MaxLength = 32767
        Me.intencionComandanteRichTextBox.Name = "intencionComandanteRichTextBox"
        Me.intencionComandanteRichTextBox.Size = New System.Drawing.Size(398, 400)
        Me.intencionComandanteRichTextBox.TabIndex = 26
        Me.intencionComandanteRichTextBox.Text = ""
        '
        'conceptoOperacionRichTextBox
        '
        Me.conceptoOperacionRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.conceptoOperacionRichTextBox.Location = New System.Drawing.Point(16, 20)
        Me.conceptoOperacionRichTextBox.MaxLength = 32767
        Me.conceptoOperacionRichTextBox.Name = "conceptoOperacionRichTextBox"
        Me.conceptoOperacionRichTextBox.Size = New System.Drawing.Size(474, 106)
        Me.conceptoOperacionRichTextBox.TabIndex = 5
        Me.conceptoOperacionRichTextBox.Text = ""
        '
        'maniobraRichTextBox
        '
        Me.maniobraRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maniobraRichTextBox.Location = New System.Drawing.Point(15, 162)
        Me.maniobraRichTextBox.MaxLength = 32767
        Me.maniobraRichTextBox.Name = "maniobraRichTextBox"
        Me.maniobraRichTextBox.Size = New System.Drawing.Size(474, 106)
        Me.maniobraRichTextBox.TabIndex = 6
        Me.maniobraRichTextBox.Text = ""
        '
        'fuegosRichTextBox
        '
        Me.fuegosRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fuegosRichTextBox.Location = New System.Drawing.Point(15, 295)
        Me.fuegosRichTextBox.MaxLength = 32767
        Me.fuegosRichTextBox.Name = "fuegosRichTextBox"
        Me.fuegosRichTextBox.Size = New System.Drawing.Size(474, 106)
        Me.fuegosRichTextBox.TabIndex = 7
        Me.fuegosRichTextBox.Text = ""
        '
        'tareasManiobraRichTextBox
        '
        Me.tareasManiobraRichTextBox.Location = New System.Drawing.Point(19, 57)
        Me.tareasManiobraRichTextBox.MaxLength = 32767
        Me.tareasManiobraRichTextBox.Name = "tareasManiobraRichTextBox"
        Me.tareasManiobraRichTextBox.Size = New System.Drawing.Size(489, 163)
        Me.tareasManiobraRichTextBox.TabIndex = 26
        Me.tareasManiobraRichTextBox.Text = ""
        '
        'tareasCombateRichTextBox
        '
        Me.tareasCombateRichTextBox.Location = New System.Drawing.Point(19, 268)
        Me.tareasCombateRichTextBox.MaxLength = 32767
        Me.tareasCombateRichTextBox.Name = "tareasCombateRichTextBox"
        Me.tareasCombateRichTextBox.Size = New System.Drawing.Size(489, 163)
        Me.tareasCombateRichTextBox.TabIndex = 27
        Me.tareasCombateRichTextBox.Text = ""
        '
        'instruccionesCoordinacionRichTextBox
        '
        Me.instruccionesCoordinacionRichTextBox.Location = New System.Drawing.Point(559, 57)
        Me.instruccionesCoordinacionRichTextBox.MaxLength = 32767
        Me.instruccionesCoordinacionRichTextBox.Name = "instruccionesCoordinacionRichTextBox"
        Me.instruccionesCoordinacionRichTextBox.Size = New System.Drawing.Size(489, 374)
        Me.instruccionesCoordinacionRichTextBox.TabIndex = 28
        Me.instruccionesCoordinacionRichTextBox.Text = ""
        '
        'distribucionRichTextBox
        '
        Me.distribucionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.distribucionRichTextBox.Location = New System.Drawing.Point(3, 18)
        Me.distribucionRichTextBox.Name = "distribucionRichTextBox"
        Me.distribucionRichTextBox.Size = New System.Drawing.Size(277, 175)
        Me.distribucionRichTextBox.TabIndex = 0
        Me.distribucionRichTextBox.Text = ""
        '
        'OperacionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1184, 602)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "OperacionForm"
        Me.Text = "OperacionForm"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.TituloLabel, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.segundosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segundosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segundosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segundosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.operacionGroupBox.ResumeLayout(False)
        Me.operacionGroupBox.PerformLayout()
        Me.misionGroupBox.ResumeLayout(False)
        Me.misionGroupBox.PerformLayout()
        Me.toeGroupBox.ResumeLayout(False)
        Me.toeGroupBox.PerformLayout()
        CType(Me.oficialesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CivilesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuboficialesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imrNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.impNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.coordenadasGroupBox.ResumeLayout(False)
        Me.coordenadasGroupBox.PerformLayout()
        Me.punto3TableLayoutPanel.ResumeLayout(False)
        Me.punto3TableLayoutPanel.PerformLayout()
        CType(Me.minutosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minutosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.punto1TableLayoutPanel.ResumeLayout(False)
        Me.punto1TableLayoutPanel.PerformLayout()
        CType(Me.minutosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minutosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ejecucion1GroupBox.ResumeLayout(False)
        Me.Ejecucion1GroupBox.PerformLayout()
        Me.conceptoOperacionGroupBox.ResumeLayout(False)
        Me.conceptoOperacionGroupBox.PerformLayout()
        Me.Ejecucion2GroupBox.ResumeLayout(False)
        Me.Ejecucion2GroupBox.PerformLayout()
        Me.juridicasGroupBox.ResumeLayout(False)
        Me.juridicasGroupBox.PerformLayout()
        Me.serviciosCombateGroupBox.ResumeLayout(False)
        Me.serviciosCombateGroupBox.PerformLayout()
        Me.comunicacionesGroupBox.ResumeLayout(False)
        Me.comunicacionesGroupBox.PerformLayout()
        Me.indicativosGroupBox.ResumeLayout(False)
        Me.otrosComGroupBox.ResumeLayout(False)
        Me.otrosComGroupBox.PerformLayout()
        Me.UHFGroupBox.ResumeLayout(False)
        Me.UHFGroupBox.PerformLayout()
        CType(Me.uhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uhfXTR3000NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uhfXTS4250NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hfGroupBox.ResumeLayout(False)
        Me.hfGroupBox.PerformLayout()
        CType(Me.hfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hf6020NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VHFGroupBox.ResumeLayout(False)
        Me.VHFGroupBox.PerformLayout()
        CType(Me.vhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhfAereoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhf930NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhf710NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhf7330NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.armamentoGroupBox.ResumeLayout(False)
        Me.armamentoGroupBox.PerformLayout()
        Me.morterosGroupBox.ResumeLayout(False)
        Me.morterosGroupBox.PerformLayout()
        CType(Me.m_brandt_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc_fms_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc_c575_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc_c370_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lanzagranadasGroupBox.ResumeLayout(False)
        Me.lanzagranadasGroupBox.PerformLayout()
        CType(Me.m79NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mkNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mglNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.granadasGroupBox.ResumeLayout(False)
        Me.granadasGroupBox.PerformLayout()
        CType(Me.lacrimogenaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.humoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fusilesGroupBox.ResumeLayout(False)
        Me.fusilesGroupBox.PerformLayout()
        CType(Me.m16_a203NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m16_m4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m16_a2NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.galil_iceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.galil_arNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.equiposEspecialesGroupBox.ResumeLayout(False)
        Me.equiposEspecialesGroupBox.PerformLayout()
        CType(Me.kitOrientacionNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flasmersNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.camaraTermicaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binocularesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visorNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ametralladorasGroupBox.ResumeLayout(False)
        Me.ametralladorasGroupBox.PerformLayout()
        CType(Me.punto50NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ss77NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M249NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m60E4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m60EstandarNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.situacionGroupBox.ResumeLayout(False)
        Me.situacionGroupBox.PerformLayout()
        Me.firmasGroupBox.ResumeLayout(False)
        Me.firmasGroupBox.PerformLayout()
        Me.distribucionGroupBox.ResumeLayout(False)
        Me.anexosGroupBox.ResumeLayout(False)
        Me.anexosGroupBox.PerformLayout()
        CType(Me.anexosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.personalGroupBox.ResumeLayout(False)
        Me.personalGroupBox.PerformLayout()
        Me.detalleMisionGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents operacionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents operacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nombre_operacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fecha_operacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents deTextBox As System.Windows.Forms.TextBox
    Friend WithEvents accTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndicativoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents referenciasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents misionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CivilesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CivilesLabel As System.Windows.Forms.Label
    Friend WithEvents imrNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents imrLabel As System.Windows.Forms.Label
    Friend WithEvents impNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents impLabel As System.Windows.Forms.Label
    Friend WithEvents SuboficialesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SuboficialesLabel As System.Windows.Forms.Label
    Friend WithEvents oficialesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents oficialesLabel As System.Windows.Forms.Label
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents misionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents coordenadasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents punto3Label As System.Windows.Forms.Label
    Friend WithEvents punto3TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents segundosLng3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents minutosLng3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents gradosLng3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents latitud3Label As System.Windows.Forms.Label
    Friend WithEvents gradosLat3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents grados3Label As System.Windows.Forms.Label
    Friend WithEvents minutos3Label As System.Windows.Forms.Label
    Friend WithEvents segundos3Label As System.Windows.Forms.Label
    Friend WithEvents minutosLat3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents segundosLat3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents longitud3Label As System.Windows.Forms.Label
    Friend WithEvents punto1Label As System.Windows.Forms.Label
    Friend WithEvents punto1TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents segundosLgn1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents minutosLgn1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents gradosLgn1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents latitud1Label As System.Windows.Forms.Label
    Friend WithEvents gradosLat1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents grados1Label As System.Windows.Forms.Label
    Friend WithEvents minutos1Label As System.Windows.Forms.Label
    Friend WithEvents segundos1Label As System.Windows.Forms.Label
    Friend WithEvents minutosLat1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents segundosLat1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents longitud1Label As System.Windows.Forms.Label
    Friend WithEvents CoordenadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion1GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents intencionComandanteLabel As System.Windows.Forms.Label
    Friend WithEvents EjecucionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion2GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents tareasManiobraLabel As System.Windows.Forms.Label
    Friend WithEvents Ejecucion2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents juridicasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents instruccionesJuridicasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents instruccionesJuridicasLabel As System.Windows.Forms.Label
    Friend WithEvents usoFuerzaRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UsoFuerzaLabel As System.Windows.Forms.Label
    Friend WithEvents TarjetaAzulRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TarjetaRojaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents serviciosCombateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Clase1RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Clase1Label As System.Windows.Forms.Label
    Friend WithEvents Clase6RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Clase6Label As System.Windows.Forms.Label
    Friend WithEvents Clase5RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Clase5Label As System.Windows.Forms.Label
    Friend WithEvents Clase4RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Clase4Label As System.Windows.Forms.Label
    Friend WithEvents Clase3RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Clase3Label As System.Windows.Forms.Label
    Friend WithEvents Clase2RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Clase2Label As System.Windows.Forms.Label
    Friend WithEvents evacuacionesMedicasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents evacuacionesMedicasLabel As System.Windows.Forms.Label
    Friend WithEvents serviciosCombateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents comunicacionesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents VHFGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents vhfEscanerNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents vhfEscanerLabel As System.Windows.Forms.Label
    Friend WithEvents vhfAereoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents vfhAereoLabel As System.Windows.Forms.Label
    Friend WithEvents vhf930NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents vhf930Label As System.Windows.Forms.Label
    Friend WithEvents vhf710NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents vhf710Label As System.Windows.Forms.Label
    Friend WithEvents vhf7330NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents vhf7330Label As System.Windows.Forms.Label
    Friend WithEvents hfGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hfEscanerNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents hfEscanerLabel As System.Windows.Forms.Label
    Friend WithEvents hf6020NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents hf6020Label As System.Windows.Forms.Label
    Friend WithEvents UHFGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents uhfEscanerNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents uhfEscanerLabel As System.Windows.Forms.Label
    Friend WithEvents uhfXTR3000NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents uhfXTR3000Label As System.Windows.Forms.Label
    Friend WithEvents uhfXTS4250NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents uhfXTS4250Label As System.Windows.Forms.Label
    Friend WithEvents otrosComGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ClaveLabel As System.Windows.Forms.Label
    Friend WithEvents satelitalLabel As System.Windows.Forms.Label
    Friend WithEvents CelularLabel As System.Windows.Forms.Label
    Friend WithEvents AvantelLabel As System.Windows.Forms.Label
    Friend WithEvents ClaveComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents satelitalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AvantelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComunicacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents armamentoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lanzagranadasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents mkNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mkLabel As System.Windows.Forms.Label
    Friend WithEvents mglNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mglLabel As System.Windows.Forms.Label
    Friend WithEvents granadasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents fusilesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents galil_iceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents galil_iceLabel As System.Windows.Forms.Label
    Friend WithEvents galil_arNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents galil_arLabel As System.Windows.Forms.Label
    Friend WithEvents equiposEspecialesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents binocularesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents binocularesLabel As System.Windows.Forms.Label
    Friend WithEvents visorNocturnoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents visorNocturnoLabel As System.Windows.Forms.Label
    Friend WithEvents ametralladorasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents punto50NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents punto50Label As System.Windows.Forms.Label
    Friend WithEvents ss77NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ss77Label As System.Windows.Forms.Label
    Friend WithEvents M249NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents M249Label As System.Windows.Forms.Label
    Friend WithEvents m60E4NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m60E4Label As System.Windows.Forms.Label
    Friend WithEvents m60EstandarNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m60EstandarLabel As System.Windows.Forms.Label
    Friend WithEvents ArmamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kitOrientacionNocturnoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents kitOrientacionNocturnoLabel As System.Windows.Forms.Label
    Friend WithEvents flasmersNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents flasmersLabel As System.Windows.Forms.Label
    Friend WithEvents camaraTermicaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents camaraTermicaLabel As System.Windows.Forms.Label
    Friend WithEvents otrosEquiposTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrosEquiposLabel As System.Windows.Forms.Label
    Friend WithEvents otrasGranadasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrasGranadasLabel As System.Windows.Forms.Label
    Friend WithEvents lacrimogenaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents lacrimogenaLabel As System.Windows.Forms.Label
    Friend WithEvents humoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents humoLabel As System.Windows.Forms.Label
    Friend WithEvents manoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents manoLabel As System.Windows.Forms.Label
    Friend WithEvents m79NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m79Label As System.Windows.Forms.Label
    Friend WithEvents situacionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents detalleSituacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents situacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents firmasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents anexosGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents agregarAnexoButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents quitarButton As System.Windows.Forms.Button
    Friend WithEvents anexosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents nombreArchivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents otrasAmetralladorasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrasAmetralladorasLabel As System.Windows.Forms.Label
    Friend WithEvents otrosFusilesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrosFusilesLabel As System.Windows.Forms.Label
    Friend WithEvents morterosGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents otrosMorterosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrosMorterosLabel As System.Windows.Forms.Label
    Friend WithEvents mc_c575_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mc_c575_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents mc_c370_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mc_c370_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents m_brandt_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m_brandt_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents mc_fms_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mc_fms_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents siguiente1LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente3LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents procedimientoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lugarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents toeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents segregacionesToeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents segregacionesToeLabel As System.Windows.Forms.Label
    Friend WithEvents agregacionesToeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents agregacionesToeLabel As System.Windows.Forms.Label
    Friend WithEvents conceptoOperacionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents fuegosLabel As System.Windows.Forms.Label
    Friend WithEvents maniobraLabel As System.Windows.Forms.Label
    Friend WithEvents instruccionesCoordinacionLabel As System.Windows.Forms.Label
    Friend WithEvents tareasCombateLabel As System.Windows.Forms.Label
    Friend WithEvents juridicasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uhfCantidadLabel As System.Windows.Forms.Label
    Friend WithEvents uhfXTR3000TextBox As System.Windows.Forms.TextBox
    Friend WithEvents uhfFrecuenciaLabel As System.Windows.Forms.Label
    Friend WithEvents uhfXTS4250TextBox As System.Windows.Forms.TextBox
    Friend WithEvents vhfCantidadLabel As System.Windows.Forms.Label
    Friend WithEvents vhfAereoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vhf930TextBox As System.Windows.Forms.TextBox
    Friend WithEvents vhf710TextBox As System.Windows.Forms.TextBox
    Friend WithEvents vhfFrecuenciaLabel As System.Windows.Forms.Label
    Friend WithEvents vhf7330TextBox As System.Windows.Forms.TextBox
    Friend WithEvents indicativosGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hfCantidadLabel As System.Windows.Forms.Label
    Friend WithEvents hfFrecuenciaLabel As System.Windows.Forms.Label
    Friend WithEvents hf6020TextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrosLanzagranadasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents otrosLanzagranadasLabel As System.Windows.Forms.Label
    Friend WithEvents m16_a203Label As System.Windows.Forms.Label
    Friend WithEvents m16_m4Label As System.Windows.Forms.Label
    Friend WithEvents m16_a2Label As System.Windows.Forms.Label
    Friend WithEvents m16_a203NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m16_m4NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m16_a2NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents personalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents distribucionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents recibeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents autenticaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents autorizaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents siguiente2LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente4LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente5LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente6LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente7LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente8LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente9LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente10LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente11LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents siguiente12LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras2LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras4LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras3LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras1LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras10LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras9LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras8LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras7LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents atras6LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras5LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents atras11LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents personalRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents indicativosRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents segregacionesSituacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents agregacionesSituacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents propiasTropasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents enemigoRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents detalleMisionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents misionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents intencionComandanteRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents fuegosRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents maniobraRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents conceptoOperacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents instruccionesCoordinacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents tareasCombateRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents tareasManiobraRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents distribucionRichTextBox As System.Windows.Forms.RichTextBox
End Class
