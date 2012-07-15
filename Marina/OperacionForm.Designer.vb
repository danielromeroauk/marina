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
        Dim OperacionLabel As System.Windows.Forms.Label
        Dim Nombre_operacionLabel As System.Windows.Forms.Label
        Dim ProcedimientoLabel As System.Windows.Forms.Label
        Dim Fecha_operacionLabel As System.Windows.Forms.Label
        Dim Autoriza_deLabel As System.Windows.Forms.Label
        Dim Comandante_operacionLabel As System.Windows.Forms.Label
        Dim IndicativoLabel As System.Windows.Forms.Label
        Dim ReferenciasLabel As System.Windows.Forms.Label
        Dim SituacionLabel As System.Windows.Forms.Label
        Dim Propias_tropasRichTextBoxLabel As System.Windows.Forms.Label
        Dim MisionLabel As System.Windows.Forms.Label
        Dim AutorizaLabel As System.Windows.Forms.Label
        Dim AutenticaLabel As System.Windows.Forms.Label
        Dim RecibeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperacionForm))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OperacionTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_operacionTextBox = New System.Windows.Forms.TextBox()
        Me.Autoriza_deTextBox = New System.Windows.Forms.TextBox()
        Me.SegundosLgn1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SegundosLat1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SegundosLng3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SegundosLat3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Operaciones1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Operaciones2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoordenadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjecucionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejecucion6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbastecimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComunicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArmamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnexosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Operaciones1GroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Operaciones2LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ProcedimientoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_operacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Comandante_operacionTextBox = New System.Windows.Forms.TextBox()
        Me.IndicativoTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SituacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ToeGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgregacionesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AgregacionesLabel = New System.Windows.Forms.Label()
        Me.CivilesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CivilesLabel = New System.Windows.Forms.Label()
        Me.imrNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.imrLabel = New System.Windows.Forms.Label()
        Me.impNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.impLabel = New System.Windows.Forms.Label()
        Me.SuboficialesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SuboficialesLabel = New System.Windows.Forms.Label()
        Me.OficialesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.OficialesLabel = New System.Windows.Forms.Label()
        Me.CoordenadasGroupBox = New System.Windows.Forms.GroupBox()
        Me.Punto3Label = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MinutosLng3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradosLng3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Latitud3Label = New System.Windows.Forms.Label()
        Me.GradosLat3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Grados3Label = New System.Windows.Forms.Label()
        Me.Minutos3Label = New System.Windows.Forms.Label()
        Me.Segundos3Label = New System.Windows.Forms.Label()
        Me.MinutosLat3NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Longitud3Label = New System.Windows.Forms.Label()
        Me.Punto1Label = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MinutosLgn1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradosLgn1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Latitud1Label = New System.Windows.Forms.Label()
        Me.GradosLat1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Grados1Label = New System.Windows.Forms.Label()
        Me.Minutos1Label = New System.Windows.Forms.Label()
        Me.Segundos1Label = New System.Windows.Forms.Label()
        Me.MinutosLat1NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Longitud1Label = New System.Windows.Forms.Label()
        Me.Ejecucion1GroupBox = New System.Windows.Forms.GroupBox()
        Me.ConceptoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IntencionComandanteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.IntencionComandanteLabel = New System.Windows.Forms.Label()
        Me.Ejecucion2GroupBox = New System.Windows.Forms.GroupBox()
        Me.FuegosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FuegosLabel = New System.Windows.Forms.Label()
        Me.ManiobraRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.maniobraLabel = New System.Windows.Forms.Label()
        Me.Ejecucion3GroupBox = New System.Windows.Forms.GroupBox()
        Me.TareasCombateRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TareasCombateLabel = New System.Windows.Forms.Label()
        Me.TareasManiobraRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TareasManiobraLabel = New System.Windows.Forms.Label()
        Me.Ejecucion4GroupBox = New System.Windows.Forms.GroupBox()
        Me.NivelHostilidadRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NivelHostilidadLabel = New System.Windows.Forms.Label()
        Me.InstruccionesCoordinacionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.InstruccionesCoordinacionLabel = New System.Windows.Forms.Label()
        Me.Ejecucion5GroupBox = New System.Windows.Forms.GroupBox()
        Me.PrincipiosRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.PrincipiosLabel = New System.Windows.Forms.Label()
        Me.MarcoJuridicoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MarcoJuridicoLabel = New System.Windows.Forms.Label()
        Me.Ejecucion6GroupBox = New System.Windows.Forms.GroupBox()
        Me.TarjetaAzulRadioButton = New System.Windows.Forms.RadioButton()
        Me.TarjetaRojaRadioButton = New System.Windows.Forms.RadioButton()
        Me.InstruccionesEspecialesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.InstruccionesEspecialesLabel = New System.Windows.Forms.Label()
        Me.UsoFuerzaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.UsoFuerzaLabel = New System.Windows.Forms.Label()
        Me.AbastecimientosGroupBox = New System.Windows.Forms.GroupBox()
        Me.EvacuacionesMedicasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.EvacuacionesMedicasLabel = New System.Windows.Forms.Label()
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
        Me.ComunicacionesGroupBox = New System.Windows.Forms.GroupBox()
        Me.ComplementosTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementosLabel = New System.Windows.Forms.Label()
        Me.OtrosComGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClaveComTextBox = New System.Windows.Forms.TextBox()
        Me.SatelitalTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.AvantelTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveLabel = New System.Windows.Forms.Label()
        Me.SatelitalLabel = New System.Windows.Forms.Label()
        Me.CelularLabel = New System.Windows.Forms.Label()
        Me.AvantelLabel = New System.Windows.Forms.Label()
        Me.UHFGroupBox = New System.Windows.Forms.GroupBox()
        Me.uhfEscanerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.uhfEscanerLabel = New System.Windows.Forms.Label()
        Me.uhfXTR3000NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.uhfXTR3000Label = New System.Windows.Forms.Label()
        Me.uhfXTS4250NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.xts4250Label = New System.Windows.Forms.Label()
        Me.HFGroupBox = New System.Windows.Forms.GroupBox()
        Me.hfEscanerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.hfEscanerLabel = New System.Windows.Forms.Label()
        Me.hf6020NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.hf6020Label = New System.Windows.Forms.Label()
        Me.VHFGroupBox = New System.Windows.Forms.GroupBox()
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
        Me.ArmamentoGroupBox = New System.Windows.Forms.GroupBox()
        Me.MorterosGroupBox = New System.Windows.Forms.GroupBox()
        Me.m_brandt_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m_brandt_60mmLabel = New System.Windows.Forms.Label()
        Me.mc_fms_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mc_fms_60mmLabel = New System.Windows.Forms.Label()
        Me.OtrosMorterosTextBox = New System.Windows.Forms.TextBox()
        Me.OtrosMorterosLabel = New System.Windows.Forms.Label()
        Me.mc_c575_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mc_c575_60mmLabel = New System.Windows.Forms.Label()
        Me.mc_c370_60mmNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.mc_c370_60mmLabel = New System.Windows.Forms.Label()
        Me.LanzagranadasGroupBox = New System.Windows.Forms.GroupBox()
        Me.M203NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.M203Label = New System.Windows.Forms.Label()
        Me.M79NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.M79Label = New System.Windows.Forms.Label()
        Me.MKNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MKLabel = New System.Windows.Forms.Label()
        Me.MGLNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MGLLabel = New System.Windows.Forms.Label()
        Me.GranadasGroupBox = New System.Windows.Forms.GroupBox()
        Me.OtrasGranadasTextBox = New System.Windows.Forms.TextBox()
        Me.OtrasGranadasLabel = New System.Windows.Forms.Label()
        Me.LacrimogenoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LacrimogenoLabel = New System.Windows.Forms.Label()
        Me.HumoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HumoLabel = New System.Windows.Forms.Label()
        Me.ManoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ManoLabel = New System.Windows.Forms.Label()
        Me.FusilesGroupBox = New System.Windows.Forms.GroupBox()
        Me.OtrosFusilesTextBox = New System.Windows.Forms.TextBox()
        Me.OtrosFusilesLabel = New System.Windows.Forms.Label()
        Me.m16NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m16Label = New System.Windows.Forms.Label()
        Me.GalilNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GalilLabel = New System.Windows.Forms.Label()
        Me.EquiposEspecialesGroupBox = New System.Windows.Forms.GroupBox()
        Me.OtrosEquiposTextBox = New System.Windows.Forms.TextBox()
        Me.OtrosEquiposLabel = New System.Windows.Forms.Label()
        Me.KitOrientacionNocturnoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.KitOrientacionNocturnoLabel = New System.Windows.Forms.Label()
        Me.FlasmersNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.FlasmersLabel = New System.Windows.Forms.Label()
        Me.CamaraTermicaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CamaraTermicaLabel = New System.Windows.Forms.Label()
        Me.BinocularesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BinocularesLabel = New System.Windows.Forms.Label()
        Me.VisorNocturnoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.VisorNocturnoLabel = New System.Windows.Forms.Label()
        Me.AmetralladorasGroupBox = New System.Windows.Forms.GroupBox()
        Me.OtrasAmetralladorasTextBox = New System.Windows.Forms.TextBox()
        Me.OtrassAmetralladorasLabel = New System.Windows.Forms.Label()
        Me.Punto50NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Punto50Label = New System.Windows.Forms.Label()
        Me.ss77NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ss77Label = New System.Windows.Forms.Label()
        Me.M249NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.M249Label = New System.Windows.Forms.Label()
        Me.m60E4NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m60E4Label = New System.Windows.Forms.Label()
        Me.m60EstandarNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.m60EstandarLabel = New System.Windows.Forms.Label()
        Me.Operaciones2GroupBox = New System.Windows.Forms.GroupBox()
        Me.Propias_tropasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MisionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.FirmasGroupBox = New System.Windows.Forms.GroupBox()
        Me.RecibeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AutenticaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AutorizaRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AnexosGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnexosDataGridView = New System.Windows.Forms.DataGridView()
        Me.nombreArchivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuitarButton = New System.Windows.Forms.Button()
        Me.AgregarAnexoButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Operaciones1LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.toeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel14 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel15 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel16 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel17 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel18 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel19 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel20 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel21 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel22 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel23 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel24 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.LinkLabel25 = New System.Windows.Forms.LinkLabel()
        OperacionLabel = New System.Windows.Forms.Label()
        Nombre_operacionLabel = New System.Windows.Forms.Label()
        ProcedimientoLabel = New System.Windows.Forms.Label()
        Fecha_operacionLabel = New System.Windows.Forms.Label()
        Autoriza_deLabel = New System.Windows.Forms.Label()
        Comandante_operacionLabel = New System.Windows.Forms.Label()
        IndicativoLabel = New System.Windows.Forms.Label()
        ReferenciasLabel = New System.Windows.Forms.Label()
        SituacionLabel = New System.Windows.Forms.Label()
        Propias_tropasRichTextBoxLabel = New System.Windows.Forms.Label()
        MisionLabel = New System.Windows.Forms.Label()
        AutorizaLabel = New System.Windows.Forms.Label()
        AutenticaLabel = New System.Windows.Forms.Label()
        RecibeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SegundosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Operaciones1GroupBox.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ToeGroupBox.SuspendLayout()
        CType(Me.CivilesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imrNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.impNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuboficialesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficialesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoordenadasGroupBox.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.MinutosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MinutosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ejecucion1GroupBox.SuspendLayout()
        Me.Ejecucion2GroupBox.SuspendLayout()
        Me.Ejecucion3GroupBox.SuspendLayout()
        Me.Ejecucion4GroupBox.SuspendLayout()
        Me.Ejecucion5GroupBox.SuspendLayout()
        Me.Ejecucion6GroupBox.SuspendLayout()
        Me.AbastecimientosGroupBox.SuspendLayout()
        Me.ComunicacionesGroupBox.SuspendLayout()
        Me.OtrosComGroupBox.SuspendLayout()
        Me.UHFGroupBox.SuspendLayout()
        CType(Me.uhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uhfXTR3000NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uhfXTS4250NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HFGroupBox.SuspendLayout()
        CType(Me.hfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hf6020NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VHFGroupBox.SuspendLayout()
        CType(Me.vhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhfAereoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhf930NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhf710NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhf7330NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArmamentoGroupBox.SuspendLayout()
        Me.MorterosGroupBox.SuspendLayout()
        CType(Me.m_brandt_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc_fms_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc_c575_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc_c370_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LanzagranadasGroupBox.SuspendLayout()
        CType(Me.M203NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M79NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MKNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MGLNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GranadasGroupBox.SuspendLayout()
        CType(Me.LacrimogenoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HumoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FusilesGroupBox.SuspendLayout()
        CType(Me.m16NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GalilNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquiposEspecialesGroupBox.SuspendLayout()
        CType(Me.KitOrientacionNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlasmersNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamaraTermicaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinocularesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisorNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AmetralladorasGroupBox.SuspendLayout()
        CType(Me.Punto50NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ss77NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M249NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m60E4NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m60EstandarNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Operaciones2GroupBox.SuspendLayout()
        Me.FirmasGroupBox.SuspendLayout()
        Me.AnexosGroupBox.SuspendLayout()
        CType(Me.AnexosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.FirmasGroupBox)
        Me.Panel1.Controls.Add(Me.AnexosGroupBox)
        Me.Panel1.Controls.Add(Me.ArmamentoGroupBox)
        Me.Panel1.Controls.Add(Me.ComunicacionesGroupBox)
        Me.Panel1.Controls.Add(Me.AbastecimientosGroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion6GroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion5GroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion4GroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion3GroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion2GroupBox)
        Me.Panel1.Controls.Add(Me.Ejecucion1GroupBox)
        Me.Panel1.Controls.Add(Me.CoordenadasGroupBox)
        Me.Panel1.Controls.Add(Me.ToeGroupBox)
        Me.Panel1.Controls.Add(Me.Operaciones2GroupBox)
        Me.Panel1.Controls.Add(Me.Operaciones1GroupBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Size = New System.Drawing.Size(1160, 500)
        '
        'OperacionLabel
        '
        OperacionLabel.AutoSize = True
        OperacionLabel.Location = New System.Drawing.Point(19, 27)
        OperacionLabel.Name = "OperacionLabel"
        OperacionLabel.Size = New System.Drawing.Size(149, 16)
        OperacionLabel.TabIndex = 0
        OperacionLabel.Text = "Consecutivo operación:"
        '
        'Nombre_operacionLabel
        '
        Nombre_operacionLabel.AutoSize = True
        Nombre_operacionLabel.Location = New System.Drawing.Point(49, 55)
        Nombre_operacionLabel.Name = "Nombre_operacionLabel"
        Nombre_operacionLabel.Size = New System.Drawing.Size(124, 16)
        Nombre_operacionLabel.TabIndex = 2
        Nombre_operacionLabel.Text = "Nombre operación:"
        '
        'ProcedimientoLabel
        '
        ProcedimientoLabel.AutoSize = True
        ProcedimientoLabel.Location = New System.Drawing.Point(73, 83)
        ProcedimientoLabel.Name = "ProcedimientoLabel"
        ProcedimientoLabel.Size = New System.Drawing.Size(98, 16)
        ProcedimientoLabel.TabIndex = 4
        ProcedimientoLabel.Text = "Procedimiento:"
        '
        'Fecha_operacionLabel
        '
        Fecha_operacionLabel.AutoSize = True
        Fecha_operacionLabel.Location = New System.Drawing.Point(62, 112)
        Fecha_operacionLabel.Name = "Fecha_operacionLabel"
        Fecha_operacionLabel.Size = New System.Drawing.Size(113, 16)
        Fecha_operacionLabel.TabIndex = 6
        Fecha_operacionLabel.Text = "Fecha operación:"
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
        'ReferenciasLabel
        '
        ReferenciasLabel.AutoSize = True
        ReferenciasLabel.Location = New System.Drawing.Point(16, 149)
        ReferenciasLabel.Name = "ReferenciasLabel"
        ReferenciasLabel.Size = New System.Drawing.Size(84, 16)
        ReferenciasLabel.TabIndex = 14
        ReferenciasLabel.Text = "Referencias:"
        '
        'SituacionLabel
        '
        SituacionLabel.AutoSize = True
        SituacionLabel.Location = New System.Drawing.Point(556, 149)
        SituacionLabel.Name = "SituacionLabel"
        SituacionLabel.Size = New System.Drawing.Size(66, 16)
        SituacionLabel.TabIndex = 16
        SituacionLabel.Text = "Situación:"
        '
        'Propias_tropasRichTextBoxLabel
        '
        Propias_tropasRichTextBoxLabel.AutoSize = True
        Propias_tropasRichTextBoxLabel.Location = New System.Drawing.Point(19, 21)
        Propias_tropasRichTextBoxLabel.Name = "Propias_tropasRichTextBoxLabel"
        Propias_tropasRichTextBoxLabel.Size = New System.Drawing.Size(99, 16)
        Propias_tropasRichTextBoxLabel.TabIndex = 18
        Propias_tropasRichTextBoxLabel.Text = "Propias tropas:"
        '
        'MisionLabel
        '
        MisionLabel.AutoSize = True
        MisionLabel.Location = New System.Drawing.Point(574, 21)
        MisionLabel.Name = "MisionLabel"
        MisionLabel.Size = New System.Drawing.Size(50, 16)
        MisionLabel.TabIndex = 20
        MisionLabel.Text = "Misión:"
        '
        'AutorizaLabel
        '
        AutorizaLabel.AutoSize = True
        AutorizaLabel.Location = New System.Drawing.Point(17, 32)
        AutorizaLabel.Name = "AutorizaLabel"
        AutorizaLabel.Size = New System.Drawing.Size(59, 16)
        AutorizaLabel.TabIndex = 18
        AutorizaLabel.Text = "Autoriza:"
        '
        'AutenticaLabel
        '
        AutenticaLabel.AutoSize = True
        AutenticaLabel.Location = New System.Drawing.Point(10, 135)
        AutenticaLabel.Name = "AutenticaLabel"
        AutenticaLabel.Size = New System.Drawing.Size(66, 16)
        AutenticaLabel.TabIndex = 20
        AutenticaLabel.Text = "Autentica:"
        '
        'RecibeLabel
        '
        RecibeLabel.AutoSize = True
        RecibeLabel.Location = New System.Drawing.Point(21, 238)
        RecibeLabel.Name = "RecibeLabel"
        RecibeLabel.Size = New System.Drawing.Size(55, 16)
        RecibeLabel.TabIndex = 22
        RecibeLabel.Text = "Recibe:"
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
        'OperacionTextBox
        '
        Me.OperacionTextBox.Location = New System.Drawing.Point(176, 24)
        Me.OperacionTextBox.MaxLength = 20
        Me.OperacionTextBox.Name = "OperacionTextBox"
        Me.OperacionTextBox.Size = New System.Drawing.Size(250, 22)
        Me.OperacionTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.OperacionTextBox, "Consecutivo de la operación, puede ser alfanumérico " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de máximo 20 caracteres.")
        '
        'Nombre_operacionTextBox
        '
        Me.Nombre_operacionTextBox.Location = New System.Drawing.Point(176, 52)
        Me.Nombre_operacionTextBox.MaxLength = 300
        Me.Nombre_operacionTextBox.Name = "Nombre_operacionTextBox"
        Me.Nombre_operacionTextBox.Size = New System.Drawing.Size(250, 22)
        Me.Nombre_operacionTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Nombre_operacionTextBox, "Máximo 300 caracteres.")
        '
        'Autoriza_deTextBox
        '
        Me.Autoriza_deTextBox.Location = New System.Drawing.Point(670, 21)
        Me.Autoriza_deTextBox.MaxLength = 300
        Me.Autoriza_deTextBox.Name = "Autoriza_deTextBox"
        Me.Autoriza_deTextBox.Size = New System.Drawing.Size(250, 22)
        Me.Autoriza_deTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Autoriza_deTextBox, "Texto del campo ""De""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Que aparecerá en la página 1 de la orden fragmentaria.")
        '
        'SegundosLgn1NumericUpDown
        '
        Me.SegundosLgn1NumericUpDown.DecimalPlaces = 2
        Me.SegundosLgn1NumericUpDown.Location = New System.Drawing.Point(190, 47)
        Me.SegundosLgn1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SegundosLgn1NumericUpDown.Name = "SegundosLgn1NumericUpDown"
        Me.SegundosLgn1NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.SegundosLgn1NumericUpDown.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.SegundosLgn1NumericUpDown, "El separador decimal es la coma.")
        '
        'SegundosLat1NumericUpDown
        '
        Me.SegundosLat1NumericUpDown.DecimalPlaces = 2
        Me.SegundosLat1NumericUpDown.Location = New System.Drawing.Point(190, 19)
        Me.SegundosLat1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SegundosLat1NumericUpDown.Name = "SegundosLat1NumericUpDown"
        Me.SegundosLat1NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.SegundosLat1NumericUpDown.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.SegundosLat1NumericUpDown, "El separador decimal es la coma.")
        '
        'SegundosLng3NumericUpDown
        '
        Me.SegundosLng3NumericUpDown.DecimalPlaces = 2
        Me.SegundosLng3NumericUpDown.Location = New System.Drawing.Point(190, 47)
        Me.SegundosLng3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SegundosLng3NumericUpDown.Name = "SegundosLng3NumericUpDown"
        Me.SegundosLng3NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.SegundosLng3NumericUpDown.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.SegundosLng3NumericUpDown, "El separador decimal es la coma.")
        '
        'SegundosLat3NumericUpDown
        '
        Me.SegundosLat3NumericUpDown.DecimalPlaces = 2
        Me.SegundosLat3NumericUpDown.Location = New System.Drawing.Point(190, 19)
        Me.SegundosLat3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SegundosLat3NumericUpDown.Name = "SegundosLat3NumericUpDown"
        Me.SegundosLat3NumericUpDown.Size = New System.Drawing.Size(67, 22)
        Me.SegundosLat3NumericUpDown.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.SegundosLat3NumericUpDown, "El separador decimal es la coma.")
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
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Operaciones1ToolStripMenuItem, Me.Operaciones2ToolStripMenuItem, Me.TOEToolStripMenuItem, Me.CoordenadasToolStripMenuItem, Me.EjecucionToolStripMenuItem, Me.AbastecimientosToolStripMenuItem, Me.ComunicacionesToolStripMenuItem, Me.ArmamentoToolStripMenuItem, Me.AnexosToolStripMenuItem, Me.FirmasToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "&Datos"
        '
        'Operaciones1ToolStripMenuItem
        '
        Me.Operaciones1ToolStripMenuItem.Name = "Operaciones1ToolStripMenuItem"
        Me.Operaciones1ToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.Operaciones1ToolStripMenuItem.Text = "&Básicos"
        '
        'Operaciones2ToolStripMenuItem
        '
        Me.Operaciones2ToolStripMenuItem.Name = "Operaciones2ToolStripMenuItem"
        Me.Operaciones2ToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.Operaciones2ToolStripMenuItem.Text = "Propias tropas | Misio&n"
        '
        'TOEToolStripMenuItem
        '
        Me.TOEToolStripMenuItem.Name = "TOEToolStripMenuItem"
        Me.TOEToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TOEToolStripMenuItem.Text = "&TOE"
        '
        'CoordenadasToolStripMenuItem
        '
        Me.CoordenadasToolStripMenuItem.Name = "CoordenadasToolStripMenuItem"
        Me.CoordenadasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CoordenadasToolStripMenuItem.Text = "&Coordenadas"
        '
        'EjecucionToolStripMenuItem
        '
        Me.EjecucionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejecucion1ToolStripMenuItem, Me.Ejecucion2ToolStripMenuItem, Me.Ejecucion3ToolStripMenuItem, Me.Ejecucion4ToolStripMenuItem, Me.Ejecucion5ToolStripMenuItem, Me.Ejecucion6ToolStripMenuItem})
        Me.EjecucionToolStripMenuItem.Name = "EjecucionToolStripMenuItem"
        Me.EjecucionToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EjecucionToolStripMenuItem.Text = "&Ejecución"
        '
        'Ejecucion1ToolStripMenuItem
        '
        Me.Ejecucion1ToolStripMenuItem.Name = "Ejecucion1ToolStripMenuItem"
        Me.Ejecucion1ToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.Ejecucion1ToolStripMenuItem.Text = "Intención co&mandante | Concepto"
        '
        'Ejecucion2ToolStripMenuItem
        '
        Me.Ejecucion2ToolStripMenuItem.Name = "Ejecucion2ToolStripMenuItem"
        Me.Ejecucion2ToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.Ejecucion2ToolStripMenuItem.Text = "Maniobra | Fuegos"
        '
        'Ejecucion3ToolStripMenuItem
        '
        Me.Ejecucion3ToolStripMenuItem.Name = "Ejecucion3ToolStripMenuItem"
        Me.Ejecucion3ToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.Ejecucion3ToolStripMenuItem.Text = "Tareas: Maniobra | Combate"
        '
        'Ejecucion4ToolStripMenuItem
        '
        Me.Ejecucion4ToolStripMenuItem.Name = "Ejecucion4ToolStripMenuItem"
        Me.Ejecucion4ToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.Ejecucion4ToolStripMenuItem.Text = "Instrucciones coordinación | Nivel de hostilidad"
        '
        'Ejecucion5ToolStripMenuItem
        '
        Me.Ejecucion5ToolStripMenuItem.Name = "Ejecucion5ToolStripMenuItem"
        Me.Ejecucion5ToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.Ejecucion5ToolStripMenuItem.Text = "Marco jurídico | Principios"
        '
        'Ejecucion6ToolStripMenuItem
        '
        Me.Ejecucion6ToolStripMenuItem.Name = "Ejecucion6ToolStripMenuItem"
        Me.Ejecucion6ToolStripMenuItem.Size = New System.Drawing.Size(324, 22)
        Me.Ejecucion6ToolStripMenuItem.Text = "Uso de fuerza | Instrucciones especiales"
        '
        'AbastecimientosToolStripMenuItem
        '
        Me.AbastecimientosToolStripMenuItem.Name = "AbastecimientosToolStripMenuItem"
        Me.AbastecimientosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AbastecimientosToolStripMenuItem.Text = "&Abastecimientos"
        '
        'ComunicacionesToolStripMenuItem
        '
        Me.ComunicacionesToolStripMenuItem.Name = "ComunicacionesToolStripMenuItem"
        Me.ComunicacionesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ComunicacionesToolStripMenuItem.Text = "Co&municaciones"
        '
        'ArmamentoToolStripMenuItem
        '
        Me.ArmamentoToolStripMenuItem.Name = "ArmamentoToolStripMenuItem"
        Me.ArmamentoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ArmamentoToolStripMenuItem.Text = "A&rmamento"
        '
        'AnexosToolStripMenuItem
        '
        Me.AnexosToolStripMenuItem.Name = "AnexosToolStripMenuItem"
        Me.AnexosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnexosToolStripMenuItem.Text = "Ane&xos"
        '
        'FirmasToolStripMenuItem
        '
        Me.FirmasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FirmasToolStripMenuItem.Name = "FirmasToolStripMenuItem"
        Me.FirmasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.FirmasToolStripMenuItem.Text = "&Firmas"
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
        'Operaciones1GroupBox
        '
        Me.Operaciones1GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Operaciones1GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.Operaciones1GroupBox.Controls.Add(Me.TableLayoutPanel3)
        Me.Operaciones1GroupBox.Controls.Add(OperacionLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.OperacionTextBox)
        Me.Operaciones1GroupBox.Controls.Add(Nombre_operacionLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.Nombre_operacionTextBox)
        Me.Operaciones1GroupBox.Controls.Add(ProcedimientoLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.ProcedimientoTextBox)
        Me.Operaciones1GroupBox.Controls.Add(Fecha_operacionLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.Fecha_operacionDateTimePicker)
        Me.Operaciones1GroupBox.Controls.Add(Autoriza_deLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.Autoriza_deTextBox)
        Me.Operaciones1GroupBox.Controls.Add(Comandante_operacionLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.Comandante_operacionTextBox)
        Me.Operaciones1GroupBox.Controls.Add(IndicativoLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.IndicativoTextBox)
        Me.Operaciones1GroupBox.Controls.Add(ReferenciasLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.ReferenciasRichTextBox)
        Me.Operaciones1GroupBox.Controls.Add(SituacionLabel)
        Me.Operaciones1GroupBox.Controls.Add(Me.SituacionRichTextBox)
        Me.Operaciones1GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Operaciones1GroupBox.Name = "Operaciones1GroupBox"
        Me.Operaciones1GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Operaciones1GroupBox.TabIndex = 1
        Me.Operaciones1GroupBox.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Operaciones2LinkLabel, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1050, 24)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'Operaciones2LinkLabel
        '
        Me.Operaciones2LinkLabel.AutoSize = True
        Me.Operaciones2LinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.Operaciones2LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.Operaciones2LinkLabel.Location = New System.Drawing.Point(3, 0)
        Me.Operaciones2LinkLabel.Name = "Operaciones2LinkLabel"
        Me.Operaciones2LinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.Operaciones2LinkLabel.TabIndex = 1
        Me.Operaciones2LinkLabel.TabStop = True
        Me.Operaciones2LinkLabel.Text = "Siguiente"
        Me.Operaciones2LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProcedimientoTextBox
        '
        Me.ProcedimientoTextBox.Location = New System.Drawing.Point(176, 80)
        Me.ProcedimientoTextBox.MaxLength = 300
        Me.ProcedimientoTextBox.Name = "ProcedimientoTextBox"
        Me.ProcedimientoTextBox.Size = New System.Drawing.Size(250, 22)
        Me.ProcedimientoTextBox.TabIndex = 5
        '
        'Fecha_operacionDateTimePicker
        '
        Me.Fecha_operacionDateTimePicker.Location = New System.Drawing.Point(176, 108)
        Me.Fecha_operacionDateTimePicker.Name = "Fecha_operacionDateTimePicker"
        Me.Fecha_operacionDateTimePicker.Size = New System.Drawing.Size(250, 22)
        Me.Fecha_operacionDateTimePicker.TabIndex = 7
        Me.Fecha_operacionDateTimePicker.Value = New Date(2012, 6, 23, 0, 0, 0, 0)
        '
        'Comandante_operacionTextBox
        '
        Me.Comandante_operacionTextBox.Location = New System.Drawing.Point(670, 49)
        Me.Comandante_operacionTextBox.MaxLength = 300
        Me.Comandante_operacionTextBox.Name = "Comandante_operacionTextBox"
        Me.Comandante_operacionTextBox.Size = New System.Drawing.Size(250, 22)
        Me.Comandante_operacionTextBox.TabIndex = 11
        '
        'IndicativoTextBox
        '
        Me.IndicativoTextBox.Location = New System.Drawing.Point(670, 77)
        Me.IndicativoTextBox.MaxLength = 300
        Me.IndicativoTextBox.Name = "IndicativoTextBox"
        Me.IndicativoTextBox.Size = New System.Drawing.Size(250, 22)
        Me.IndicativoTextBox.TabIndex = 13
        '
        'ReferenciasRichTextBox
        '
        Me.ReferenciasRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ReferenciasRichTextBox.Location = New System.Drawing.Point(19, 168)
        Me.ReferenciasRichTextBox.Name = "ReferenciasRichTextBox"
        Me.ReferenciasRichTextBox.Size = New System.Drawing.Size(501, 286)
        Me.ReferenciasRichTextBox.TabIndex = 15
        Me.ReferenciasRichTextBox.Text = resources.GetString("ReferenciasRichTextBox.Text")
        '
        'SituacionRichTextBox
        '
        Me.SituacionRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SituacionRichTextBox.Location = New System.Drawing.Point(556, 168)
        Me.SituacionRichTextBox.Name = "SituacionRichTextBox"
        Me.SituacionRichTextBox.Size = New System.Drawing.Size(564, 286)
        Me.SituacionRichTextBox.TabIndex = 17
        Me.SituacionRichTextBox.Text = ""
        '
        'ToeGroupBox
        '
        Me.ToeGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToeGroupBox.Controls.Add(Me.TableLayoutPanel5)
        Me.ToeGroupBox.Controls.Add(Me.AgregacionesRichTextBox)
        Me.ToeGroupBox.Controls.Add(Me.AgregacionesLabel)
        Me.ToeGroupBox.Controls.Add(Me.CivilesNumericUpDown)
        Me.ToeGroupBox.Controls.Add(Me.CivilesLabel)
        Me.ToeGroupBox.Controls.Add(Me.imrNumericUpDown)
        Me.ToeGroupBox.Controls.Add(Me.imrLabel)
        Me.ToeGroupBox.Controls.Add(Me.impNumericUpDown)
        Me.ToeGroupBox.Controls.Add(Me.impLabel)
        Me.ToeGroupBox.Controls.Add(Me.SuboficialesNumericUpDown)
        Me.ToeGroupBox.Controls.Add(Me.SuboficialesLabel)
        Me.ToeGroupBox.Controls.Add(Me.OficialesNumericUpDown)
        Me.ToeGroupBox.Controls.Add(Me.OficialesLabel)
        Me.ToeGroupBox.ForeColor = System.Drawing.Color.White
        Me.ToeGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.ToeGroupBox.Name = "ToeGroupBox"
        Me.ToeGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.ToeGroupBox.TabIndex = 3
        Me.ToeGroupBox.TabStop = False
        Me.ToeGroupBox.Text = "TOE"
        '
        'AgregacionesRichTextBox
        '
        Me.AgregacionesRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregacionesRichTextBox.Location = New System.Drawing.Point(371, 60)
        Me.AgregacionesRichTextBox.Name = "AgregacionesRichTextBox"
        Me.AgregacionesRichTextBox.Size = New System.Drawing.Size(567, 115)
        Me.AgregacionesRichTextBox.TabIndex = 11
        Me.AgregacionesRichTextBox.Text = ""
        '
        'AgregacionesLabel
        '
        Me.AgregacionesLabel.AutoSize = True
        Me.AgregacionesLabel.Location = New System.Drawing.Point(368, 41)
        Me.AgregacionesLabel.Name = "AgregacionesLabel"
        Me.AgregacionesLabel.Size = New System.Drawing.Size(96, 16)
        Me.AgregacionesLabel.TabIndex = 10
        Me.AgregacionesLabel.Text = "Agregaciones:"
        '
        'CivilesNumericUpDown
        '
        Me.CivilesNumericUpDown.Location = New System.Drawing.Point(163, 153)
        Me.CivilesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.CivilesNumericUpDown.Name = "CivilesNumericUpDown"
        Me.CivilesNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.CivilesNumericUpDown.TabIndex = 9
        '
        'CivilesLabel
        '
        Me.CivilesLabel.AutoSize = True
        Me.CivilesLabel.Location = New System.Drawing.Point(105, 157)
        Me.CivilesLabel.Name = "CivilesLabel"
        Me.CivilesLabel.Size = New System.Drawing.Size(51, 16)
        Me.CivilesLabel.TabIndex = 8
        Me.CivilesLabel.Text = "Civiles:"
        '
        'imrNumericUpDown
        '
        Me.imrNumericUpDown.Location = New System.Drawing.Point(163, 125)
        Me.imrNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.imrNumericUpDown.Name = "imrNumericUpDown"
        Me.imrNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.imrNumericUpDown.TabIndex = 7
        '
        'imrLabel
        '
        Me.imrLabel.AutoSize = True
        Me.imrLabel.Location = New System.Drawing.Point(122, 127)
        Me.imrLabel.Name = "imrLabel"
        Me.imrLabel.Size = New System.Drawing.Size(35, 16)
        Me.imrLabel.TabIndex = 6
        Me.imrLabel.Text = "IMR:"
        '
        'impNumericUpDown
        '
        Me.impNumericUpDown.Location = New System.Drawing.Point(163, 97)
        Me.impNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.impNumericUpDown.Name = "impNumericUpDown"
        Me.impNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.impNumericUpDown.TabIndex = 5
        '
        'impLabel
        '
        Me.impLabel.AutoSize = True
        Me.impLabel.Location = New System.Drawing.Point(122, 99)
        Me.impLabel.Name = "impLabel"
        Me.impLabel.Size = New System.Drawing.Size(34, 16)
        Me.impLabel.TabIndex = 4
        Me.impLabel.Text = "IMP:"
        '
        'SuboficialesNumericUpDown
        '
        Me.SuboficialesNumericUpDown.Location = New System.Drawing.Point(163, 69)
        Me.SuboficialesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.SuboficialesNumericUpDown.Name = "SuboficialesNumericUpDown"
        Me.SuboficialesNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.SuboficialesNumericUpDown.TabIndex = 3
        '
        'SuboficialesLabel
        '
        Me.SuboficialesLabel.AutoSize = True
        Me.SuboficialesLabel.Location = New System.Drawing.Point(71, 71)
        Me.SuboficialesLabel.Name = "SuboficialesLabel"
        Me.SuboficialesLabel.Size = New System.Drawing.Size(85, 16)
        Me.SuboficialesLabel.TabIndex = 2
        Me.SuboficialesLabel.Text = "Suboficiales:"
        '
        'OficialesNumericUpDown
        '
        Me.OficialesNumericUpDown.Location = New System.Drawing.Point(163, 41)
        Me.OficialesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.OficialesNumericUpDown.Name = "OficialesNumericUpDown"
        Me.OficialesNumericUpDown.Size = New System.Drawing.Size(120, 22)
        Me.OficialesNumericUpDown.TabIndex = 1
        '
        'OficialesLabel
        '
        Me.OficialesLabel.AutoSize = True
        Me.OficialesLabel.Location = New System.Drawing.Point(93, 43)
        Me.OficialesLabel.Name = "OficialesLabel"
        Me.OficialesLabel.Size = New System.Drawing.Size(63, 16)
        Me.OficialesLabel.TabIndex = 0
        Me.OficialesLabel.Text = "Oficiales:"
        '
        'CoordenadasGroupBox
        '
        Me.CoordenadasGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoordenadasGroupBox.Controls.Add(Me.TableLayoutPanel6)
        Me.CoordenadasGroupBox.Controls.Add(Me.Punto3Label)
        Me.CoordenadasGroupBox.Controls.Add(Me.TableLayoutPanel2)
        Me.CoordenadasGroupBox.Controls.Add(Me.Punto1Label)
        Me.CoordenadasGroupBox.Controls.Add(Me.TableLayoutPanel1)
        Me.CoordenadasGroupBox.ForeColor = System.Drawing.Color.White
        Me.CoordenadasGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.CoordenadasGroupBox.Name = "CoordenadasGroupBox"
        Me.CoordenadasGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.CoordenadasGroupBox.TabIndex = 4
        Me.CoordenadasGroupBox.TabStop = False
        Me.CoordenadasGroupBox.Text = "Coordenadas"
        '
        'Punto3Label
        '
        Me.Punto3Label.AutoSize = True
        Me.Punto3Label.Location = New System.Drawing.Point(470, 39)
        Me.Punto3Label.Name = "Punto3Label"
        Me.Punto3Label.Size = New System.Drawing.Size(268, 16)
        Me.Punto3Label.TabIndex = 6
        Me.Punto3Label.Text = "Punto inferior derecho del área o cuadrante."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.SegundosLng3NumericUpDown, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.MinutosLng3NumericUpDown, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.GradosLng3NumericUpDown, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Latitud3Label, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GradosLat3NumericUpDown, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Grados3Label, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Minutos3Label, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Segundos3Label, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MinutosLat3NumericUpDown, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SegundosLat3NumericUpDown, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Longitud3Label, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(476, 69)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(263, 72)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'MinutosLng3NumericUpDown
        '
        Me.MinutosLng3NumericUpDown.Location = New System.Drawing.Point(130, 47)
        Me.MinutosLng3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinutosLng3NumericUpDown.Name = "MinutosLng3NumericUpDown"
        Me.MinutosLng3NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.MinutosLng3NumericUpDown.TabIndex = 9
        '
        'GradosLng3NumericUpDown
        '
        Me.GradosLng3NumericUpDown.Location = New System.Drawing.Point(71, 47)
        Me.GradosLng3NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.GradosLng3NumericUpDown.Name = "GradosLng3NumericUpDown"
        Me.GradosLng3NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.GradosLng3NumericUpDown.TabIndex = 8
        '
        'Latitud3Label
        '
        Me.Latitud3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Latitud3Label.AutoSize = True
        Me.Latitud3Label.Location = New System.Drawing.Point(15, 16)
        Me.Latitud3Label.Name = "Latitud3Label"
        Me.Latitud3Label.Size = New System.Drawing.Size(50, 28)
        Me.Latitud3Label.TabIndex = 3
        Me.Latitud3Label.Text = "Latitud:"
        Me.Latitud3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GradosLat3NumericUpDown
        '
        Me.GradosLat3NumericUpDown.Location = New System.Drawing.Point(71, 19)
        Me.GradosLat3NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.GradosLat3NumericUpDown.Name = "GradosLat3NumericUpDown"
        Me.GradosLat3NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.GradosLat3NumericUpDown.TabIndex = 4
        '
        'Grados3Label
        '
        Me.Grados3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grados3Label.AutoSize = True
        Me.Grados3Label.Location = New System.Drawing.Point(71, 0)
        Me.Grados3Label.Name = "Grados3Label"
        Me.Grados3Label.Size = New System.Drawing.Size(53, 16)
        Me.Grados3Label.TabIndex = 0
        Me.Grados3Label.Text = "Grados"
        Me.Grados3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Minutos3Label
        '
        Me.Minutos3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minutos3Label.AutoSize = True
        Me.Minutos3Label.Location = New System.Drawing.Point(130, 0)
        Me.Minutos3Label.Name = "Minutos3Label"
        Me.Minutos3Label.Size = New System.Drawing.Size(54, 16)
        Me.Minutos3Label.TabIndex = 1
        Me.Minutos3Label.Text = "Minutos"
        Me.Minutos3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Segundos3Label
        '
        Me.Segundos3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Segundos3Label.AutoSize = True
        Me.Segundos3Label.Location = New System.Drawing.Point(190, 0)
        Me.Segundos3Label.Name = "Segundos3Label"
        Me.Segundos3Label.Size = New System.Drawing.Size(70, 16)
        Me.Segundos3Label.TabIndex = 2
        Me.Segundos3Label.Text = "Segundos"
        Me.Segundos3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinutosLat3NumericUpDown
        '
        Me.MinutosLat3NumericUpDown.Location = New System.Drawing.Point(130, 19)
        Me.MinutosLat3NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinutosLat3NumericUpDown.Name = "MinutosLat3NumericUpDown"
        Me.MinutosLat3NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.MinutosLat3NumericUpDown.TabIndex = 5
        '
        'Longitud3Label
        '
        Me.Longitud3Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Longitud3Label.AutoSize = True
        Me.Longitud3Label.Location = New System.Drawing.Point(3, 44)
        Me.Longitud3Label.Name = "Longitud3Label"
        Me.Longitud3Label.Size = New System.Drawing.Size(62, 28)
        Me.Longitud3Label.TabIndex = 7
        Me.Longitud3Label.Text = "Longitud:"
        Me.Longitud3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Punto1Label
        '
        Me.Punto1Label.AutoSize = True
        Me.Punto1Label.Location = New System.Drawing.Point(68, 39)
        Me.Punto1Label.Name = "Punto1Label"
        Me.Punto1Label.Size = New System.Drawing.Size(282, 16)
        Me.Punto1Label.TabIndex = 4
        Me.Punto1Label.Text = "Punto superior izquierdo del área o cuadrante."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.SegundosLgn1NumericUpDown, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MinutosLgn1NumericUpDown, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GradosLgn1NumericUpDown, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Latitud1Label, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GradosLat1NumericUpDown, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Grados1Label, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Minutos1Label, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Segundos1Label, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MinutosLat1NumericUpDown, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SegundosLat1NumericUpDown, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Longitud1Label, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(74, 69)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(263, 72)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'MinutosLgn1NumericUpDown
        '
        Me.MinutosLgn1NumericUpDown.Location = New System.Drawing.Point(130, 47)
        Me.MinutosLgn1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinutosLgn1NumericUpDown.Name = "MinutosLgn1NumericUpDown"
        Me.MinutosLgn1NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.MinutosLgn1NumericUpDown.TabIndex = 9
        '
        'GradosLgn1NumericUpDown
        '
        Me.GradosLgn1NumericUpDown.Location = New System.Drawing.Point(71, 47)
        Me.GradosLgn1NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.GradosLgn1NumericUpDown.Name = "GradosLgn1NumericUpDown"
        Me.GradosLgn1NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.GradosLgn1NumericUpDown.TabIndex = 8
        '
        'Latitud1Label
        '
        Me.Latitud1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Latitud1Label.AutoSize = True
        Me.Latitud1Label.Location = New System.Drawing.Point(15, 16)
        Me.Latitud1Label.Name = "Latitud1Label"
        Me.Latitud1Label.Size = New System.Drawing.Size(50, 28)
        Me.Latitud1Label.TabIndex = 3
        Me.Latitud1Label.Text = "Latitud:"
        Me.Latitud1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GradosLat1NumericUpDown
        '
        Me.GradosLat1NumericUpDown.Location = New System.Drawing.Point(71, 19)
        Me.GradosLat1NumericUpDown.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.GradosLat1NumericUpDown.Name = "GradosLat1NumericUpDown"
        Me.GradosLat1NumericUpDown.Size = New System.Drawing.Size(53, 22)
        Me.GradosLat1NumericUpDown.TabIndex = 4
        '
        'Grados1Label
        '
        Me.Grados1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grados1Label.AutoSize = True
        Me.Grados1Label.Location = New System.Drawing.Point(71, 0)
        Me.Grados1Label.Name = "Grados1Label"
        Me.Grados1Label.Size = New System.Drawing.Size(53, 16)
        Me.Grados1Label.TabIndex = 0
        Me.Grados1Label.Text = "Grados"
        Me.Grados1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Minutos1Label
        '
        Me.Minutos1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minutos1Label.AutoSize = True
        Me.Minutos1Label.Location = New System.Drawing.Point(130, 0)
        Me.Minutos1Label.Name = "Minutos1Label"
        Me.Minutos1Label.Size = New System.Drawing.Size(54, 16)
        Me.Minutos1Label.TabIndex = 1
        Me.Minutos1Label.Text = "Minutos"
        Me.Minutos1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Segundos1Label
        '
        Me.Segundos1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Segundos1Label.AutoSize = True
        Me.Segundos1Label.Location = New System.Drawing.Point(190, 0)
        Me.Segundos1Label.Name = "Segundos1Label"
        Me.Segundos1Label.Size = New System.Drawing.Size(70, 16)
        Me.Segundos1Label.TabIndex = 2
        Me.Segundos1Label.Text = "Segundos"
        Me.Segundos1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinutosLat1NumericUpDown
        '
        Me.MinutosLat1NumericUpDown.Location = New System.Drawing.Point(130, 19)
        Me.MinutosLat1NumericUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.MinutosLat1NumericUpDown.Name = "MinutosLat1NumericUpDown"
        Me.MinutosLat1NumericUpDown.Size = New System.Drawing.Size(52, 22)
        Me.MinutosLat1NumericUpDown.TabIndex = 5
        '
        'Longitud1Label
        '
        Me.Longitud1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Longitud1Label.AutoSize = True
        Me.Longitud1Label.Location = New System.Drawing.Point(3, 44)
        Me.Longitud1Label.Name = "Longitud1Label"
        Me.Longitud1Label.Size = New System.Drawing.Size(62, 28)
        Me.Longitud1Label.TabIndex = 7
        Me.Longitud1Label.Text = "Longitud:"
        Me.Longitud1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ejecucion1GroupBox
        '
        Me.Ejecucion1GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion1GroupBox.Controls.Add(Me.TableLayoutPanel7)
        Me.Ejecucion1GroupBox.Controls.Add(Me.ConceptoRichTextBox)
        Me.Ejecucion1GroupBox.Controls.Add(Me.Label1)
        Me.Ejecucion1GroupBox.Controls.Add(Me.IntencionComandanteRichTextBox)
        Me.Ejecucion1GroupBox.Controls.Add(Me.IntencionComandanteLabel)
        Me.Ejecucion1GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion1GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion1GroupBox.Name = "Ejecucion1GroupBox"
        Me.Ejecucion1GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Ejecucion1GroupBox.TabIndex = 7
        Me.Ejecucion1GroupBox.TabStop = False
        Me.Ejecucion1GroupBox.Text = "Ejecución"
        '
        'ConceptoRichTextBox
        '
        Me.ConceptoRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConceptoRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.ConceptoRichTextBox.Name = "ConceptoRichTextBox"
        Me.ConceptoRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.ConceptoRichTextBox.TabIndex = 3
        Me.ConceptoRichTextBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Concepto:"
        '
        'IntencionComandanteRichTextBox
        '
        Me.IntencionComandanteRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IntencionComandanteRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.IntencionComandanteRichTextBox.Name = "IntencionComandanteRichTextBox"
        Me.IntencionComandanteRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.IntencionComandanteRichTextBox.TabIndex = 1
        Me.IntencionComandanteRichTextBox.Text = ""
        '
        'IntencionComandanteLabel
        '
        Me.IntencionComandanteLabel.AutoSize = True
        Me.IntencionComandanteLabel.Location = New System.Drawing.Point(52, 41)
        Me.IntencionComandanteLabel.Name = "IntencionComandanteLabel"
        Me.IntencionComandanteLabel.Size = New System.Drawing.Size(164, 16)
        Me.IntencionComandanteLabel.TabIndex = 0
        Me.IntencionComandanteLabel.Text = "Intención del comandante:"
        '
        'Ejecucion2GroupBox
        '
        Me.Ejecucion2GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion2GroupBox.Controls.Add(Me.TableLayoutPanel8)
        Me.Ejecucion2GroupBox.Controls.Add(Me.FuegosRichTextBox)
        Me.Ejecucion2GroupBox.Controls.Add(Me.FuegosLabel)
        Me.Ejecucion2GroupBox.Controls.Add(Me.ManiobraRichTextBox)
        Me.Ejecucion2GroupBox.Controls.Add(Me.maniobraLabel)
        Me.Ejecucion2GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion2GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion2GroupBox.Name = "Ejecucion2GroupBox"
        Me.Ejecucion2GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Ejecucion2GroupBox.TabIndex = 8
        Me.Ejecucion2GroupBox.TabStop = False
        Me.Ejecucion2GroupBox.Text = "Ejecución"
        '
        'FuegosRichTextBox
        '
        Me.FuegosRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FuegosRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.FuegosRichTextBox.Name = "FuegosRichTextBox"
        Me.FuegosRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.FuegosRichTextBox.TabIndex = 3
        Me.FuegosRichTextBox.Text = ""
        '
        'FuegosLabel
        '
        Me.FuegosLabel.AutoSize = True
        Me.FuegosLabel.Location = New System.Drawing.Point(514, 43)
        Me.FuegosLabel.Name = "FuegosLabel"
        Me.FuegosLabel.Size = New System.Drawing.Size(57, 16)
        Me.FuegosLabel.TabIndex = 2
        Me.FuegosLabel.Text = "Fuegos:"
        '
        'ManiobraRichTextBox
        '
        Me.ManiobraRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ManiobraRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.ManiobraRichTextBox.Name = "ManiobraRichTextBox"
        Me.ManiobraRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.ManiobraRichTextBox.TabIndex = 1
        Me.ManiobraRichTextBox.Text = ""
        '
        'maniobraLabel
        '
        Me.maniobraLabel.AutoSize = True
        Me.maniobraLabel.Location = New System.Drawing.Point(52, 41)
        Me.maniobraLabel.Name = "maniobraLabel"
        Me.maniobraLabel.Size = New System.Drawing.Size(68, 16)
        Me.maniobraLabel.TabIndex = 0
        Me.maniobraLabel.Text = "Maniobra:"
        '
        'Ejecucion3GroupBox
        '
        Me.Ejecucion3GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion3GroupBox.Controls.Add(Me.TableLayoutPanel9)
        Me.Ejecucion3GroupBox.Controls.Add(Me.TareasCombateRichTextBox)
        Me.Ejecucion3GroupBox.Controls.Add(Me.TareasCombateLabel)
        Me.Ejecucion3GroupBox.Controls.Add(Me.TareasManiobraRichTextBox)
        Me.Ejecucion3GroupBox.Controls.Add(Me.TareasManiobraLabel)
        Me.Ejecucion3GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion3GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion3GroupBox.Name = "Ejecucion3GroupBox"
        Me.Ejecucion3GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Ejecucion3GroupBox.TabIndex = 9
        Me.Ejecucion3GroupBox.TabStop = False
        Me.Ejecucion3GroupBox.Text = "Ejecución"
        '
        'TareasCombateRichTextBox
        '
        Me.TareasCombateRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TareasCombateRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.TareasCombateRichTextBox.Name = "TareasCombateRichTextBox"
        Me.TareasCombateRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.TareasCombateRichTextBox.TabIndex = 3
        Me.TareasCombateRichTextBox.Text = ""
        '
        'TareasCombateLabel
        '
        Me.TareasCombateLabel.AutoSize = True
        Me.TareasCombateLabel.Location = New System.Drawing.Point(514, 43)
        Me.TareasCombateLabel.Name = "TareasCombateLabel"
        Me.TareasCombateLabel.Size = New System.Drawing.Size(113, 16)
        Me.TareasCombateLabel.TabIndex = 2
        Me.TareasCombateLabel.Text = "Tareas Combate:"
        '
        'TareasManiobraRichTextBox
        '
        Me.TareasManiobraRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TareasManiobraRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.TareasManiobraRichTextBox.Name = "TareasManiobraRichTextBox"
        Me.TareasManiobraRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.TareasManiobraRichTextBox.TabIndex = 1
        Me.TareasManiobraRichTextBox.Text = ""
        '
        'TareasManiobraLabel
        '
        Me.TareasManiobraLabel.AutoSize = True
        Me.TareasManiobraLabel.Location = New System.Drawing.Point(52, 41)
        Me.TareasManiobraLabel.Name = "TareasManiobraLabel"
        Me.TareasManiobraLabel.Size = New System.Drawing.Size(115, 16)
        Me.TareasManiobraLabel.TabIndex = 0
        Me.TareasManiobraLabel.Text = "Tareas Maniobra:"
        '
        'Ejecucion4GroupBox
        '
        Me.Ejecucion4GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion4GroupBox.Controls.Add(Me.TableLayoutPanel10)
        Me.Ejecucion4GroupBox.Controls.Add(Me.NivelHostilidadRichTextBox)
        Me.Ejecucion4GroupBox.Controls.Add(Me.NivelHostilidadLabel)
        Me.Ejecucion4GroupBox.Controls.Add(Me.InstruccionesCoordinacionRichTextBox)
        Me.Ejecucion4GroupBox.Controls.Add(Me.InstruccionesCoordinacionLabel)
        Me.Ejecucion4GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion4GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion4GroupBox.Name = "Ejecucion4GroupBox"
        Me.Ejecucion4GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Ejecucion4GroupBox.TabIndex = 10
        Me.Ejecucion4GroupBox.TabStop = False
        Me.Ejecucion4GroupBox.Text = "Ejecución"
        '
        'NivelHostilidadRichTextBox
        '
        Me.NivelHostilidadRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NivelHostilidadRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.NivelHostilidadRichTextBox.Name = "NivelHostilidadRichTextBox"
        Me.NivelHostilidadRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.NivelHostilidadRichTextBox.TabIndex = 3
        Me.NivelHostilidadRichTextBox.Text = ""
        '
        'NivelHostilidadLabel
        '
        Me.NivelHostilidadLabel.AutoSize = True
        Me.NivelHostilidadLabel.Location = New System.Drawing.Point(514, 43)
        Me.NivelHostilidadLabel.Name = "NivelHostilidadLabel"
        Me.NivelHostilidadLabel.Size = New System.Drawing.Size(122, 16)
        Me.NivelHostilidadLabel.TabIndex = 2
        Me.NivelHostilidadLabel.Text = "Nivel de hostilidad:"
        '
        'InstruccionesCoordinacionRichTextBox
        '
        Me.InstruccionesCoordinacionRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InstruccionesCoordinacionRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.InstruccionesCoordinacionRichTextBox.Name = "InstruccionesCoordinacionRichTextBox"
        Me.InstruccionesCoordinacionRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.InstruccionesCoordinacionRichTextBox.TabIndex = 1
        Me.InstruccionesCoordinacionRichTextBox.Text = ""
        '
        'InstruccionesCoordinacionLabel
        '
        Me.InstruccionesCoordinacionLabel.AutoSize = True
        Me.InstruccionesCoordinacionLabel.Location = New System.Drawing.Point(52, 41)
        Me.InstruccionesCoordinacionLabel.Name = "InstruccionesCoordinacionLabel"
        Me.InstruccionesCoordinacionLabel.Size = New System.Drawing.Size(170, 16)
        Me.InstruccionesCoordinacionLabel.TabIndex = 0
        Me.InstruccionesCoordinacionLabel.Text = "Instrucciones coordinación:"
        '
        'Ejecucion5GroupBox
        '
        Me.Ejecucion5GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion5GroupBox.Controls.Add(Me.TableLayoutPanel11)
        Me.Ejecucion5GroupBox.Controls.Add(Me.PrincipiosRichTextBox)
        Me.Ejecucion5GroupBox.Controls.Add(Me.PrincipiosLabel)
        Me.Ejecucion5GroupBox.Controls.Add(Me.MarcoJuridicoRichTextBox)
        Me.Ejecucion5GroupBox.Controls.Add(Me.MarcoJuridicoLabel)
        Me.Ejecucion5GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion5GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion5GroupBox.Name = "Ejecucion5GroupBox"
        Me.Ejecucion5GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Ejecucion5GroupBox.TabIndex = 11
        Me.Ejecucion5GroupBox.TabStop = False
        Me.Ejecucion5GroupBox.Text = "Ejecución"
        '
        'PrincipiosRichTextBox
        '
        Me.PrincipiosRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrincipiosRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.PrincipiosRichTextBox.Name = "PrincipiosRichTextBox"
        Me.PrincipiosRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.PrincipiosRichTextBox.TabIndex = 3
        Me.PrincipiosRichTextBox.Text = ""
        '
        'PrincipiosLabel
        '
        Me.PrincipiosLabel.AutoSize = True
        Me.PrincipiosLabel.Location = New System.Drawing.Point(514, 43)
        Me.PrincipiosLabel.Name = "PrincipiosLabel"
        Me.PrincipiosLabel.Size = New System.Drawing.Size(70, 16)
        Me.PrincipiosLabel.TabIndex = 2
        Me.PrincipiosLabel.Text = "Principios:"
        '
        'MarcoJuridicoRichTextBox
        '
        Me.MarcoJuridicoRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MarcoJuridicoRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.MarcoJuridicoRichTextBox.Name = "MarcoJuridicoRichTextBox"
        Me.MarcoJuridicoRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.MarcoJuridicoRichTextBox.TabIndex = 1
        Me.MarcoJuridicoRichTextBox.Text = ""
        '
        'MarcoJuridicoLabel
        '
        Me.MarcoJuridicoLabel.AutoSize = True
        Me.MarcoJuridicoLabel.Location = New System.Drawing.Point(52, 41)
        Me.MarcoJuridicoLabel.Name = "MarcoJuridicoLabel"
        Me.MarcoJuridicoLabel.Size = New System.Drawing.Size(99, 16)
        Me.MarcoJuridicoLabel.TabIndex = 0
        Me.MarcoJuridicoLabel.Text = "Marco Jurídico:"
        '
        'Ejecucion6GroupBox
        '
        Me.Ejecucion6GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ejecucion6GroupBox.Controls.Add(Me.TableLayoutPanel12)
        Me.Ejecucion6GroupBox.Controls.Add(Me.TarjetaAzulRadioButton)
        Me.Ejecucion6GroupBox.Controls.Add(Me.TarjetaRojaRadioButton)
        Me.Ejecucion6GroupBox.Controls.Add(Me.InstruccionesEspecialesRichTextBox)
        Me.Ejecucion6GroupBox.Controls.Add(Me.InstruccionesEspecialesLabel)
        Me.Ejecucion6GroupBox.Controls.Add(Me.UsoFuerzaRichTextBox)
        Me.Ejecucion6GroupBox.Controls.Add(Me.UsoFuerzaLabel)
        Me.Ejecucion6GroupBox.ForeColor = System.Drawing.Color.White
        Me.Ejecucion6GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Ejecucion6GroupBox.Name = "Ejecucion6GroupBox"
        Me.Ejecucion6GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Ejecucion6GroupBox.TabIndex = 12
        Me.Ejecucion6GroupBox.TabStop = False
        Me.Ejecucion6GroupBox.Text = "Ejecución"
        '
        'TarjetaAzulRadioButton
        '
        Me.TarjetaAzulRadioButton.AutoSize = True
        Me.TarjetaAzulRadioButton.Checked = True
        Me.TarjetaAzulRadioButton.Location = New System.Drawing.Point(264, 39)
        Me.TarjetaAzulRadioButton.Name = "TarjetaAzulRadioButton"
        Me.TarjetaAzulRadioButton.Size = New System.Drawing.Size(94, 20)
        Me.TarjetaAzulRadioButton.TabIndex = 5
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
        Me.TarjetaRojaRadioButton.TabIndex = 4
        Me.TarjetaRojaRadioButton.Text = "TarjetaRoja"
        Me.TarjetaRojaRadioButton.UseVisualStyleBackColor = True
        '
        'InstruccionesEspecialesRichTextBox
        '
        Me.InstruccionesEspecialesRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InstruccionesEspecialesRichTextBox.Location = New System.Drawing.Point(517, 66)
        Me.InstruccionesEspecialesRichTextBox.Name = "InstruccionesEspecialesRichTextBox"
        Me.InstruccionesEspecialesRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.InstruccionesEspecialesRichTextBox.TabIndex = 3
        Me.InstruccionesEspecialesRichTextBox.Text = ""
        '
        'InstruccionesEspecialesLabel
        '
        Me.InstruccionesEspecialesLabel.AutoSize = True
        Me.InstruccionesEspecialesLabel.Location = New System.Drawing.Point(514, 43)
        Me.InstruccionesEspecialesLabel.Name = "InstruccionesEspecialesLabel"
        Me.InstruccionesEspecialesLabel.Size = New System.Drawing.Size(159, 16)
        Me.InstruccionesEspecialesLabel.TabIndex = 2
        Me.InstruccionesEspecialesLabel.Text = "Instrucciones especiales:"
        '
        'UsoFuerzaRichTextBox
        '
        Me.UsoFuerzaRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UsoFuerzaRichTextBox.Location = New System.Drawing.Point(52, 68)
        Me.UsoFuerzaRichTextBox.Name = "UsoFuerzaRichTextBox"
        Me.UsoFuerzaRichTextBox.Size = New System.Drawing.Size(412, 384)
        Me.UsoFuerzaRichTextBox.TabIndex = 1
        Me.UsoFuerzaRichTextBox.Text = resources.GetString("UsoFuerzaRichTextBox.Text")
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
        'AbastecimientosGroupBox
        '
        Me.AbastecimientosGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbastecimientosGroupBox.Controls.Add(Me.TableLayoutPanel13)
        Me.AbastecimientosGroupBox.Controls.Add(Me.EvacuacionesMedicasRichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.EvacuacionesMedicasLabel)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase6RichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase6Label)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase5RichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase5Label)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase4RichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase4Label)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase3RichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase3Label)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase2RichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase2Label)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase1RichTextBox)
        Me.AbastecimientosGroupBox.Controls.Add(Me.Clase1Label)
        Me.AbastecimientosGroupBox.ForeColor = System.Drawing.Color.White
        Me.AbastecimientosGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.AbastecimientosGroupBox.Name = "AbastecimientosGroupBox"
        Me.AbastecimientosGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.AbastecimientosGroupBox.TabIndex = 13
        Me.AbastecimientosGroupBox.TabStop = False
        Me.AbastecimientosGroupBox.Text = "Abastecimientos"
        '
        'EvacuacionesMedicasRichTextBox
        '
        Me.EvacuacionesMedicasRichTextBox.Location = New System.Drawing.Point(55, 328)
        Me.EvacuacionesMedicasRichTextBox.Name = "EvacuacionesMedicasRichTextBox"
        Me.EvacuacionesMedicasRichTextBox.Size = New System.Drawing.Size(868, 106)
        Me.EvacuacionesMedicasRichTextBox.TabIndex = 13
        Me.EvacuacionesMedicasRichTextBox.Text = ""
        '
        'EvacuacionesMedicasLabel
        '
        Me.EvacuacionesMedicasLabel.AutoSize = True
        Me.EvacuacionesMedicasLabel.Location = New System.Drawing.Point(52, 306)
        Me.EvacuacionesMedicasLabel.Name = "EvacuacionesMedicasLabel"
        Me.EvacuacionesMedicasLabel.Size = New System.Drawing.Size(152, 16)
        Me.EvacuacionesMedicasLabel.TabIndex = 12
        Me.EvacuacionesMedicasLabel.Text = "Evacuaciones Médicas:"
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
        'ComunicacionesGroupBox
        '
        Me.ComunicacionesGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComunicacionesGroupBox.Controls.Add(Me.TableLayoutPanel14)
        Me.ComunicacionesGroupBox.Controls.Add(Me.ComplementosTextBox)
        Me.ComunicacionesGroupBox.Controls.Add(Me.ComplementosLabel)
        Me.ComunicacionesGroupBox.Controls.Add(Me.OtrosComGroupBox)
        Me.ComunicacionesGroupBox.Controls.Add(Me.UHFGroupBox)
        Me.ComunicacionesGroupBox.Controls.Add(Me.HFGroupBox)
        Me.ComunicacionesGroupBox.Controls.Add(Me.VHFGroupBox)
        Me.ComunicacionesGroupBox.ForeColor = System.Drawing.Color.White
        Me.ComunicacionesGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.ComunicacionesGroupBox.Name = "ComunicacionesGroupBox"
        Me.ComunicacionesGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.ComunicacionesGroupBox.TabIndex = 14
        Me.ComunicacionesGroupBox.TabStop = False
        Me.ComunicacionesGroupBox.Text = "Comunicaciones"
        '
        'ComplementosTextBox
        '
        Me.ComplementosTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComplementosTextBox.Location = New System.Drawing.Point(52, 306)
        Me.ComplementosTextBox.Multiline = True
        Me.ComplementosTextBox.Name = "ComplementosTextBox"
        Me.ComplementosTextBox.Size = New System.Drawing.Size(1077, 128)
        Me.ComplementosTextBox.TabIndex = 5
        '
        'ComplementosLabel
        '
        Me.ComplementosLabel.AutoSize = True
        Me.ComplementosLabel.Location = New System.Drawing.Point(49, 281)
        Me.ComplementosLabel.Name = "ComplementosLabel"
        Me.ComplementosLabel.Size = New System.Drawing.Size(102, 16)
        Me.ComplementosLabel.TabIndex = 4
        Me.ComplementosLabel.Text = "Complementos:"
        '
        'OtrosComGroupBox
        '
        Me.OtrosComGroupBox.Controls.Add(Me.ClaveComTextBox)
        Me.OtrosComGroupBox.Controls.Add(Me.SatelitalTextBox)
        Me.OtrosComGroupBox.Controls.Add(Me.CelularTextBox)
        Me.OtrosComGroupBox.Controls.Add(Me.AvantelTextBox)
        Me.OtrosComGroupBox.Controls.Add(Me.ClaveLabel)
        Me.OtrosComGroupBox.Controls.Add(Me.SatelitalLabel)
        Me.OtrosComGroupBox.Controls.Add(Me.CelularLabel)
        Me.OtrosComGroupBox.Controls.Add(Me.AvantelLabel)
        Me.OtrosComGroupBox.ForeColor = System.Drawing.Color.White
        Me.OtrosComGroupBox.Location = New System.Drawing.Point(691, 68)
        Me.OtrosComGroupBox.Name = "OtrosComGroupBox"
        Me.OtrosComGroupBox.Size = New System.Drawing.Size(237, 146)
        Me.OtrosComGroupBox.TabIndex = 3
        Me.OtrosComGroupBox.TabStop = False
        Me.OtrosComGroupBox.Text = "Otros"
        '
        'ClaveComTextBox
        '
        Me.ClaveComTextBox.Location = New System.Drawing.Point(110, 105)
        Me.ClaveComTextBox.MaxLength = 300
        Me.ClaveComTextBox.Name = "ClaveComTextBox"
        Me.ClaveComTextBox.Size = New System.Drawing.Size(118, 22)
        Me.ClaveComTextBox.TabIndex = 7
        '
        'SatelitalTextBox
        '
        Me.SatelitalTextBox.Location = New System.Drawing.Point(110, 79)
        Me.SatelitalTextBox.MaxLength = 300
        Me.SatelitalTextBox.Name = "SatelitalTextBox"
        Me.SatelitalTextBox.Size = New System.Drawing.Size(118, 22)
        Me.SatelitalTextBox.TabIndex = 5
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
        'SatelitalLabel
        '
        Me.SatelitalLabel.AutoSize = True
        Me.SatelitalLabel.Location = New System.Drawing.Point(46, 81)
        Me.SatelitalLabel.Name = "SatelitalLabel"
        Me.SatelitalLabel.Size = New System.Drawing.Size(59, 16)
        Me.SatelitalLabel.TabIndex = 4
        Me.SatelitalLabel.Text = "Satelital:"
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
        Me.UHFGroupBox.Controls.Add(Me.uhfEscanerNumericUpDown)
        Me.UHFGroupBox.Controls.Add(Me.uhfEscanerLabel)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTR3000NumericUpDown)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTR3000Label)
        Me.UHFGroupBox.Controls.Add(Me.uhfXTS4250NumericUpDown)
        Me.UHFGroupBox.Controls.Add(Me.xts4250Label)
        Me.UHFGroupBox.ForeColor = System.Drawing.Color.White
        Me.UHFGroupBox.Location = New System.Drawing.Point(478, 71)
        Me.UHFGroupBox.Name = "UHFGroupBox"
        Me.UHFGroupBox.Size = New System.Drawing.Size(170, 115)
        Me.UHFGroupBox.TabIndex = 2
        Me.UHFGroupBox.TabStop = False
        Me.UHFGroupBox.Text = "UHF"
        '
        'uhfEscanerNumericUpDown
        '
        Me.uhfEscanerNumericUpDown.Location = New System.Drawing.Point(80, 80)
        Me.uhfEscanerNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.uhfEscanerNumericUpDown.Name = "uhfEscanerNumericUpDown"
        Me.uhfEscanerNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.uhfEscanerNumericUpDown.TabIndex = 5
        '
        'uhfEscanerLabel
        '
        Me.uhfEscanerLabel.AutoSize = True
        Me.uhfEscanerLabel.Location = New System.Drawing.Point(13, 82)
        Me.uhfEscanerLabel.Name = "uhfEscanerLabel"
        Me.uhfEscanerLabel.Size = New System.Drawing.Size(61, 16)
        Me.uhfEscanerLabel.TabIndex = 4
        Me.uhfEscanerLabel.Text = "Escáner:"
        '
        'uhfXTR3000NumericUpDown
        '
        Me.uhfXTR3000NumericUpDown.Location = New System.Drawing.Point(80, 54)
        Me.uhfXTR3000NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.uhfXTR3000NumericUpDown.Name = "uhfXTR3000NumericUpDown"
        Me.uhfXTR3000NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.uhfXTR3000NumericUpDown.TabIndex = 3
        '
        'uhfXTR3000Label
        '
        Me.uhfXTR3000Label.AutoSize = True
        Me.uhfXTR3000Label.Location = New System.Drawing.Point(8, 56)
        Me.uhfXTR3000Label.Name = "uhfXTR3000Label"
        Me.uhfXTR3000Label.Size = New System.Drawing.Size(66, 16)
        Me.uhfXTR3000Label.TabIndex = 2
        Me.uhfXTR3000Label.Text = "XTR3000:"
        '
        'uhfXTS4250NumericUpDown
        '
        Me.uhfXTS4250NumericUpDown.Location = New System.Drawing.Point(80, 27)
        Me.uhfXTS4250NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.uhfXTS4250NumericUpDown.Name = "uhfXTS4250NumericUpDown"
        Me.uhfXTS4250NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.uhfXTS4250NumericUpDown.TabIndex = 1
        '
        'xts4250Label
        '
        Me.xts4250Label.AutoSize = True
        Me.xts4250Label.Location = New System.Drawing.Point(9, 32)
        Me.xts4250Label.Name = "xts4250Label"
        Me.xts4250Label.Size = New System.Drawing.Size(65, 16)
        Me.xts4250Label.TabIndex = 0
        Me.xts4250Label.Text = "XTS4250:"
        '
        'HFGroupBox
        '
        Me.HFGroupBox.Controls.Add(Me.hfEscanerNumericUpDown)
        Me.HFGroupBox.Controls.Add(Me.hfEscanerLabel)
        Me.HFGroupBox.Controls.Add(Me.hf6020NumericUpDown)
        Me.HFGroupBox.Controls.Add(Me.hf6020Label)
        Me.HFGroupBox.ForeColor = System.Drawing.Color.White
        Me.HFGroupBox.Location = New System.Drawing.Point(265, 71)
        Me.HFGroupBox.Name = "HFGroupBox"
        Me.HFGroupBox.Size = New System.Drawing.Size(170, 94)
        Me.HFGroupBox.TabIndex = 1
        Me.HFGroupBox.TabStop = False
        Me.HFGroupBox.Text = "HF"
        '
        'hfEscanerNumericUpDown
        '
        Me.hfEscanerNumericUpDown.Location = New System.Drawing.Point(80, 54)
        Me.hfEscanerNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.hfEscanerNumericUpDown.Name = "hfEscanerNumericUpDown"
        Me.hfEscanerNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.hfEscanerNumericUpDown.TabIndex = 3
        '
        'hfEscanerLabel
        '
        Me.hfEscanerLabel.AutoSize = True
        Me.hfEscanerLabel.Location = New System.Drawing.Point(13, 56)
        Me.hfEscanerLabel.Name = "hfEscanerLabel"
        Me.hfEscanerLabel.Size = New System.Drawing.Size(61, 16)
        Me.hfEscanerLabel.TabIndex = 2
        Me.hfEscanerLabel.Text = "Escáner:"
        '
        'hf6020NumericUpDown
        '
        Me.hf6020NumericUpDown.Location = New System.Drawing.Point(80, 27)
        Me.hf6020NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.hf6020NumericUpDown.Name = "hf6020NumericUpDown"
        Me.hf6020NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.hf6020NumericUpDown.TabIndex = 1
        '
        'hf6020Label
        '
        Me.hf6020Label.AutoSize = True
        Me.hf6020Label.Location = New System.Drawing.Point(35, 29)
        Me.hf6020Label.Name = "hf6020Label"
        Me.hf6020Label.Size = New System.Drawing.Size(39, 16)
        Me.hf6020Label.TabIndex = 0
        Me.hf6020Label.Text = "6020:"
        '
        'VHFGroupBox
        '
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
        Me.VHFGroupBox.Location = New System.Drawing.Point(52, 68)
        Me.VHFGroupBox.Name = "VHFGroupBox"
        Me.VHFGroupBox.Size = New System.Drawing.Size(170, 173)
        Me.VHFGroupBox.TabIndex = 0
        Me.VHFGroupBox.TabStop = False
        Me.VHFGroupBox.Text = "VHF"
        '
        'vhfEscanerNumericUpDown
        '
        Me.vhfEscanerNumericUpDown.Location = New System.Drawing.Point(80, 135)
        Me.vhfEscanerNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhfEscanerNumericUpDown.Name = "vhfEscanerNumericUpDown"
        Me.vhfEscanerNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhfEscanerNumericUpDown.TabIndex = 9
        '
        'vhfEscanerLabel
        '
        Me.vhfEscanerLabel.AutoSize = True
        Me.vhfEscanerLabel.Location = New System.Drawing.Point(13, 137)
        Me.vhfEscanerLabel.Name = "vhfEscanerLabel"
        Me.vhfEscanerLabel.Size = New System.Drawing.Size(61, 16)
        Me.vhfEscanerLabel.TabIndex = 8
        Me.vhfEscanerLabel.Text = "Escáner:"
        '
        'vhfAereoNumericUpDown
        '
        Me.vhfAereoNumericUpDown.Location = New System.Drawing.Point(80, 108)
        Me.vhfAereoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhfAereoNumericUpDown.Name = "vhfAereoNumericUpDown"
        Me.vhfAereoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhfAereoNumericUpDown.TabIndex = 7
        '
        'vfhAereoLabel
        '
        Me.vfhAereoLabel.AutoSize = True
        Me.vfhAereoLabel.Location = New System.Drawing.Point(26, 109)
        Me.vfhAereoLabel.Name = "vfhAereoLabel"
        Me.vfhAereoLabel.Size = New System.Drawing.Size(48, 16)
        Me.vfhAereoLabel.TabIndex = 6
        Me.vfhAereoLabel.Text = "Aéreo:"
        '
        'vhf930NumericUpDown
        '
        Me.vhf930NumericUpDown.Location = New System.Drawing.Point(80, 81)
        Me.vhf930NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhf930NumericUpDown.Name = "vhf930NumericUpDown"
        Me.vhf930NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhf930NumericUpDown.TabIndex = 5
        '
        'vhf930Label
        '
        Me.vhf930Label.AutoSize = True
        Me.vhf930Label.Location = New System.Drawing.Point(42, 81)
        Me.vhf930Label.Name = "vhf930Label"
        Me.vhf930Label.Size = New System.Drawing.Size(32, 16)
        Me.vhf930Label.TabIndex = 4
        Me.vhf930Label.Text = "930:"
        '
        'vhf710NumericUpDown
        '
        Me.vhf710NumericUpDown.Location = New System.Drawing.Point(80, 54)
        Me.vhf710NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhf710NumericUpDown.Name = "vhf710NumericUpDown"
        Me.vhf710NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhf710NumericUpDown.TabIndex = 3
        '
        'vhf710Label
        '
        Me.vhf710Label.AutoSize = True
        Me.vhf710Label.Location = New System.Drawing.Point(42, 56)
        Me.vhf710Label.Name = "vhf710Label"
        Me.vhf710Label.Size = New System.Drawing.Size(32, 16)
        Me.vhf710Label.TabIndex = 2
        Me.vhf710Label.Text = "710:"
        '
        'vhf7330NumericUpDown
        '
        Me.vhf7330NumericUpDown.Location = New System.Drawing.Point(80, 27)
        Me.vhf7330NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.vhf7330NumericUpDown.Name = "vhf7330NumericUpDown"
        Me.vhf7330NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.vhf7330NumericUpDown.TabIndex = 1
        '
        'vhf7330Label
        '
        Me.vhf7330Label.AutoSize = True
        Me.vhf7330Label.Location = New System.Drawing.Point(35, 29)
        Me.vhf7330Label.Name = "vhf7330Label"
        Me.vhf7330Label.Size = New System.Drawing.Size(39, 16)
        Me.vhf7330Label.TabIndex = 0
        Me.vhf7330Label.Text = "7330:"
        '
        'ArmamentoGroupBox
        '
        Me.ArmamentoGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArmamentoGroupBox.Controls.Add(Me.TableLayoutPanel15)
        Me.ArmamentoGroupBox.Controls.Add(Me.MorterosGroupBox)
        Me.ArmamentoGroupBox.Controls.Add(Me.LanzagranadasGroupBox)
        Me.ArmamentoGroupBox.Controls.Add(Me.GranadasGroupBox)
        Me.ArmamentoGroupBox.Controls.Add(Me.FusilesGroupBox)
        Me.ArmamentoGroupBox.Controls.Add(Me.EquiposEspecialesGroupBox)
        Me.ArmamentoGroupBox.Controls.Add(Me.AmetralladorasGroupBox)
        Me.ArmamentoGroupBox.ForeColor = System.Drawing.Color.White
        Me.ArmamentoGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.ArmamentoGroupBox.Name = "ArmamentoGroupBox"
        Me.ArmamentoGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.ArmamentoGroupBox.TabIndex = 15
        Me.ArmamentoGroupBox.TabStop = False
        Me.ArmamentoGroupBox.Text = "Armamento"
        '
        'MorterosGroupBox
        '
        Me.MorterosGroupBox.Controls.Add(Me.m_brandt_60mmNumericUpDown)
        Me.MorterosGroupBox.Controls.Add(Me.m_brandt_60mmLabel)
        Me.MorterosGroupBox.Controls.Add(Me.mc_fms_60mmNumericUpDown)
        Me.MorterosGroupBox.Controls.Add(Me.mc_fms_60mmLabel)
        Me.MorterosGroupBox.Controls.Add(Me.OtrosMorterosTextBox)
        Me.MorterosGroupBox.Controls.Add(Me.OtrosMorterosLabel)
        Me.MorterosGroupBox.Controls.Add(Me.mc_c575_60mmNumericUpDown)
        Me.MorterosGroupBox.Controls.Add(Me.mc_c575_60mmLabel)
        Me.MorterosGroupBox.Controls.Add(Me.mc_c370_60mmNumericUpDown)
        Me.MorterosGroupBox.Controls.Add(Me.mc_c370_60mmLabel)
        Me.MorterosGroupBox.ForeColor = System.Drawing.Color.White
        Me.MorterosGroupBox.Location = New System.Drawing.Point(849, 68)
        Me.MorterosGroupBox.Name = "MorterosGroupBox"
        Me.MorterosGroupBox.Size = New System.Drawing.Size(244, 333)
        Me.MorterosGroupBox.TabIndex = 6
        Me.MorterosGroupBox.TabStop = False
        Me.MorterosGroupBox.Text = "Morteros"
        '
        'm_brandt_60mmNumericUpDown
        '
        Me.m_brandt_60mmNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m_brandt_60mmNumericUpDown.Location = New System.Drawing.Point(154, 109)
        Me.m_brandt_60mmNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m_brandt_60mmNumericUpDown.Name = "m_brandt_60mmNumericUpDown"
        Me.m_brandt_60mmNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m_brandt_60mmNumericUpDown.TabIndex = 9
        '
        'm_brandt_60mmLabel
        '
        Me.m_brandt_60mmLabel.AutoSize = True
        Me.m_brandt_60mmLabel.Location = New System.Drawing.Point(44, 109)
        Me.m_brandt_60mmLabel.Name = "m_brandt_60mmLabel"
        Me.m_brandt_60mmLabel.Size = New System.Drawing.Size(107, 16)
        Me.m_brandt_60mmLabel.TabIndex = 8
        Me.m_brandt_60mmLabel.Text = "BRANDT 60MM:"
        '
        'mc_fms_60mmNumericUpDown
        '
        Me.mc_fms_60mmNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mc_fms_60mmNumericUpDown.Location = New System.Drawing.Point(154, 82)
        Me.mc_fms_60mmNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.mc_fms_60mmNumericUpDown.Name = "mc_fms_60mmNumericUpDown"
        Me.mc_fms_60mmNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.mc_fms_60mmNumericUpDown.TabIndex = 7
        '
        'mc_fms_60mmLabel
        '
        Me.mc_fms_60mmLabel.AutoSize = True
        Me.mc_fms_60mmLabel.Location = New System.Drawing.Point(11, 84)
        Me.mc_fms_60mmLabel.Name = "mc_fms_60mmLabel"
        Me.mc_fms_60mmLabel.Size = New System.Drawing.Size(140, 16)
        Me.mc_fms_60mmLabel.TabIndex = 6
        Me.mc_fms_60mmLabel.Text = "Comando FMS 60MM:"
        '
        'OtrosMorterosTextBox
        '
        Me.OtrosMorterosTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrosMorterosTextBox.Location = New System.Drawing.Point(9, 160)
        Me.OtrosMorterosTextBox.Multiline = True
        Me.OtrosMorterosTextBox.Name = "OtrosMorterosTextBox"
        Me.OtrosMorterosTextBox.Size = New System.Drawing.Size(219, 156)
        Me.OtrosMorterosTextBox.TabIndex = 5
        '
        'OtrosMorterosLabel
        '
        Me.OtrosMorterosLabel.AutoSize = True
        Me.OtrosMorterosLabel.Location = New System.Drawing.Point(9, 141)
        Me.OtrosMorterosLabel.Name = "OtrosMorterosLabel"
        Me.OtrosMorterosLabel.Size = New System.Drawing.Size(99, 16)
        Me.OtrosMorterosLabel.TabIndex = 4
        Me.OtrosMorterosLabel.Text = "Otros morteros:"
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
        Me.mc_c575_60mmLabel.Location = New System.Drawing.Point(9, 54)
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
        'LanzagranadasGroupBox
        '
        Me.LanzagranadasGroupBox.Controls.Add(Me.M203NumericUpDown)
        Me.LanzagranadasGroupBox.Controls.Add(Me.M203Label)
        Me.LanzagranadasGroupBox.Controls.Add(Me.M79NumericUpDown)
        Me.LanzagranadasGroupBox.Controls.Add(Me.M79Label)
        Me.LanzagranadasGroupBox.Controls.Add(Me.MKNumericUpDown)
        Me.LanzagranadasGroupBox.Controls.Add(Me.MKLabel)
        Me.LanzagranadasGroupBox.Controls.Add(Me.MGLNumericUpDown)
        Me.LanzagranadasGroupBox.Controls.Add(Me.MGLLabel)
        Me.LanzagranadasGroupBox.ForeColor = System.Drawing.Color.White
        Me.LanzagranadasGroupBox.Location = New System.Drawing.Point(685, 69)
        Me.LanzagranadasGroupBox.Name = "LanzagranadasGroupBox"
        Me.LanzagranadasGroupBox.Size = New System.Drawing.Size(151, 145)
        Me.LanzagranadasGroupBox.TabIndex = 4
        Me.LanzagranadasGroupBox.TabStop = False
        Me.LanzagranadasGroupBox.Text = "Lanzagranadas"
        '
        'M203NumericUpDown
        '
        Me.M203NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.M203NumericUpDown.Location = New System.Drawing.Point(61, 108)
        Me.M203NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.M203NumericUpDown.Name = "M203NumericUpDown"
        Me.M203NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.M203NumericUpDown.TabIndex = 7
        '
        'M203Label
        '
        Me.M203Label.AutoSize = True
        Me.M203Label.Location = New System.Drawing.Point(12, 110)
        Me.M203Label.Name = "M203Label"
        Me.M203Label.Size = New System.Drawing.Size(43, 16)
        Me.M203Label.TabIndex = 6
        Me.M203Label.Text = "M203:"
        '
        'M79NumericUpDown
        '
        Me.M79NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.M79NumericUpDown.Location = New System.Drawing.Point(61, 81)
        Me.M79NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.M79NumericUpDown.Name = "M79NumericUpDown"
        Me.M79NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.M79NumericUpDown.TabIndex = 5
        '
        'M79Label
        '
        Me.M79Label.AutoSize = True
        Me.M79Label.Location = New System.Drawing.Point(19, 83)
        Me.M79Label.Name = "M79Label"
        Me.M79Label.Size = New System.Drawing.Size(36, 16)
        Me.M79Label.TabIndex = 4
        Me.M79Label.Text = "M79:"
        '
        'MKNumericUpDown
        '
        Me.MKNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MKNumericUpDown.Location = New System.Drawing.Point(61, 54)
        Me.MKNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.MKNumericUpDown.Name = "MKNumericUpDown"
        Me.MKNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.MKNumericUpDown.TabIndex = 3
        '
        'MKLabel
        '
        Me.MKLabel.AutoSize = True
        Me.MKLabel.Location = New System.Drawing.Point(25, 56)
        Me.MKLabel.Name = "MKLabel"
        Me.MKLabel.Size = New System.Drawing.Size(30, 16)
        Me.MKLabel.TabIndex = 2
        Me.MKLabel.Text = "MK:"
        '
        'MGLNumericUpDown
        '
        Me.MGLNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MGLNumericUpDown.Location = New System.Drawing.Point(61, 27)
        Me.MGLNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.MGLNumericUpDown.Name = "MGLNumericUpDown"
        Me.MGLNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.MGLNumericUpDown.TabIndex = 1
        '
        'MGLLabel
        '
        Me.MGLLabel.AutoSize = True
        Me.MGLLabel.Location = New System.Drawing.Point(16, 29)
        Me.MGLLabel.Name = "MGLLabel"
        Me.MGLLabel.Size = New System.Drawing.Size(39, 16)
        Me.MGLLabel.TabIndex = 0
        Me.MGLLabel.Text = "MGL:"
        '
        'GranadasGroupBox
        '
        Me.GranadasGroupBox.Controls.Add(Me.OtrasGranadasTextBox)
        Me.GranadasGroupBox.Controls.Add(Me.OtrasGranadasLabel)
        Me.GranadasGroupBox.Controls.Add(Me.LacrimogenoNumericUpDown)
        Me.GranadasGroupBox.Controls.Add(Me.LacrimogenoLabel)
        Me.GranadasGroupBox.Controls.Add(Me.HumoNumericUpDown)
        Me.GranadasGroupBox.Controls.Add(Me.HumoLabel)
        Me.GranadasGroupBox.Controls.Add(Me.ManoNumericUpDown)
        Me.GranadasGroupBox.Controls.Add(Me.ManoLabel)
        Me.GranadasGroupBox.ForeColor = System.Drawing.Color.White
        Me.GranadasGroupBox.Location = New System.Drawing.Point(465, 69)
        Me.GranadasGroupBox.Name = "GranadasGroupBox"
        Me.GranadasGroupBox.Size = New System.Drawing.Size(208, 332)
        Me.GranadasGroupBox.TabIndex = 3
        Me.GranadasGroupBox.TabStop = False
        Me.GranadasGroupBox.Text = "Granadas"
        '
        'OtrasGranadasTextBox
        '
        Me.OtrasGranadasTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrasGranadasTextBox.Location = New System.Drawing.Point(14, 134)
        Me.OtrasGranadasTextBox.Multiline = True
        Me.OtrasGranadasTextBox.Name = "OtrasGranadasTextBox"
        Me.OtrasGranadasTextBox.Size = New System.Drawing.Size(181, 181)
        Me.OtrasGranadasTextBox.TabIndex = 7
        '
        'OtrasGranadasLabel
        '
        Me.OtrasGranadasLabel.AutoSize = True
        Me.OtrasGranadasLabel.Location = New System.Drawing.Point(17, 113)
        Me.OtrasGranadasLabel.Name = "OtrasGranadasLabel"
        Me.OtrasGranadasLabel.Size = New System.Drawing.Size(104, 16)
        Me.OtrasGranadasLabel.TabIndex = 6
        Me.OtrasGranadasLabel.Text = "Otras granadas:"
        Me.OtrasGranadasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LacrimogenoNumericUpDown
        '
        Me.LacrimogenoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LacrimogenoNumericUpDown.Location = New System.Drawing.Point(121, 79)
        Me.LacrimogenoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.LacrimogenoNumericUpDown.Name = "LacrimogenoNumericUpDown"
        Me.LacrimogenoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.LacrimogenoNumericUpDown.TabIndex = 5
        '
        'LacrimogenoLabel
        '
        Me.LacrimogenoLabel.AutoSize = True
        Me.LacrimogenoLabel.Location = New System.Drawing.Point(25, 81)
        Me.LacrimogenoLabel.Name = "LacrimogenoLabel"
        Me.LacrimogenoLabel.Size = New System.Drawing.Size(90, 16)
        Me.LacrimogenoLabel.TabIndex = 4
        Me.LacrimogenoLabel.Text = "Lacrimógeno:"
        Me.LacrimogenoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HumoNumericUpDown
        '
        Me.HumoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HumoNumericUpDown.Location = New System.Drawing.Point(121, 54)
        Me.HumoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.HumoNumericUpDown.Name = "HumoNumericUpDown"
        Me.HumoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.HumoNumericUpDown.TabIndex = 3
        '
        'HumoLabel
        '
        Me.HumoLabel.AutoSize = True
        Me.HumoLabel.Location = New System.Drawing.Point(50, 56)
        Me.HumoLabel.Name = "HumoLabel"
        Me.HumoLabel.Size = New System.Drawing.Size(65, 16)
        Me.HumoLabel.TabIndex = 2
        Me.HumoLabel.Text = "De humo:"
        '
        'ManoNumericUpDown
        '
        Me.ManoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManoNumericUpDown.Location = New System.Drawing.Point(121, 29)
        Me.ManoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.ManoNumericUpDown.Name = "ManoNumericUpDown"
        Me.ManoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.ManoNumericUpDown.TabIndex = 1
        '
        'ManoLabel
        '
        Me.ManoLabel.AutoSize = True
        Me.ManoLabel.Location = New System.Drawing.Point(49, 31)
        Me.ManoLabel.Name = "ManoLabel"
        Me.ManoLabel.Size = New System.Drawing.Size(66, 16)
        Me.ManoLabel.TabIndex = 0
        Me.ManoLabel.Text = "De mano:"
        '
        'FusilesGroupBox
        '
        Me.FusilesGroupBox.Controls.Add(Me.OtrosFusilesTextBox)
        Me.FusilesGroupBox.Controls.Add(Me.OtrosFusilesLabel)
        Me.FusilesGroupBox.Controls.Add(Me.m16NumericUpDown)
        Me.FusilesGroupBox.Controls.Add(Me.m16Label)
        Me.FusilesGroupBox.Controls.Add(Me.GalilNumericUpDown)
        Me.FusilesGroupBox.Controls.Add(Me.GalilLabel)
        Me.FusilesGroupBox.ForeColor = System.Drawing.Color.White
        Me.FusilesGroupBox.Location = New System.Drawing.Point(686, 220)
        Me.FusilesGroupBox.Name = "FusilesGroupBox"
        Me.FusilesGroupBox.Size = New System.Drawing.Size(151, 181)
        Me.FusilesGroupBox.TabIndex = 1
        Me.FusilesGroupBox.TabStop = False
        Me.FusilesGroupBox.Text = "Fusiles"
        '
        'OtrosFusilesTextBox
        '
        Me.OtrosFusilesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrosFusilesTextBox.Location = New System.Drawing.Point(9, 109)
        Me.OtrosFusilesTextBox.Multiline = True
        Me.OtrosFusilesTextBox.Name = "OtrosFusilesTextBox"
        Me.OtrosFusilesTextBox.Size = New System.Drawing.Size(126, 55)
        Me.OtrosFusilesTextBox.TabIndex = 5
        '
        'OtrosFusilesLabel
        '
        Me.OtrosFusilesLabel.AutoSize = True
        Me.OtrosFusilesLabel.Location = New System.Drawing.Point(6, 89)
        Me.OtrosFusilesLabel.Name = "OtrosFusilesLabel"
        Me.OtrosFusilesLabel.Size = New System.Drawing.Size(84, 16)
        Me.OtrosFusilesLabel.TabIndex = 4
        Me.OtrosFusilesLabel.Text = "Otros fusiles:"
        '
        'm16NumericUpDown
        '
        Me.m16NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.m16NumericUpDown.Location = New System.Drawing.Point(61, 54)
        Me.m16NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.m16NumericUpDown.Name = "m16NumericUpDown"
        Me.m16NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.m16NumericUpDown.TabIndex = 3
        '
        'm16Label
        '
        Me.m16Label.AutoSize = True
        Me.m16Label.Location = New System.Drawing.Point(20, 57)
        Me.m16Label.Name = "m16Label"
        Me.m16Label.Size = New System.Drawing.Size(36, 16)
        Me.m16Label.TabIndex = 2
        Me.m16Label.Text = "M16:"
        '
        'GalilNumericUpDown
        '
        Me.GalilNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GalilNumericUpDown.Location = New System.Drawing.Point(61, 27)
        Me.GalilNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.GalilNumericUpDown.Name = "GalilNumericUpDown"
        Me.GalilNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.GalilNumericUpDown.TabIndex = 1
        '
        'GalilLabel
        '
        Me.GalilLabel.AutoSize = True
        Me.GalilLabel.Location = New System.Drawing.Point(9, 31)
        Me.GalilLabel.Name = "GalilLabel"
        Me.GalilLabel.Size = New System.Drawing.Size(47, 16)
        Me.GalilLabel.TabIndex = 0
        Me.GalilLabel.Text = "GALIL:"
        '
        'EquiposEspecialesGroupBox
        '
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.OtrosEquiposTextBox)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.OtrosEquiposLabel)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.KitOrientacionNocturnoNumericUpDown)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.KitOrientacionNocturnoLabel)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.FlasmersNumericUpDown)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.FlasmersLabel)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.CamaraTermicaNumericUpDown)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.CamaraTermicaLabel)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.BinocularesNumericUpDown)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.BinocularesLabel)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.VisorNocturnoNumericUpDown)
        Me.EquiposEspecialesGroupBox.Controls.Add(Me.VisorNocturnoLabel)
        Me.EquiposEspecialesGroupBox.ForeColor = System.Drawing.Color.White
        Me.EquiposEspecialesGroupBox.Location = New System.Drawing.Point(234, 71)
        Me.EquiposEspecialesGroupBox.Name = "EquiposEspecialesGroupBox"
        Me.EquiposEspecialesGroupBox.Size = New System.Drawing.Size(220, 330)
        Me.EquiposEspecialesGroupBox.TabIndex = 2
        Me.EquiposEspecialesGroupBox.TabStop = False
        Me.EquiposEspecialesGroupBox.Text = "Equipos especiales"
        '
        'OtrosEquiposTextBox
        '
        Me.OtrosEquiposTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrosEquiposTextBox.Location = New System.Drawing.Point(16, 197)
        Me.OtrosEquiposTextBox.Multiline = True
        Me.OtrosEquiposTextBox.Name = "OtrosEquiposTextBox"
        Me.OtrosEquiposTextBox.Size = New System.Drawing.Size(188, 116)
        Me.OtrosEquiposTextBox.TabIndex = 11
        '
        'OtrosEquiposLabel
        '
        Me.OtrosEquiposLabel.AutoSize = True
        Me.OtrosEquiposLabel.Location = New System.Drawing.Point(19, 175)
        Me.OtrosEquiposLabel.Name = "OtrosEquiposLabel"
        Me.OtrosEquiposLabel.Size = New System.Drawing.Size(95, 16)
        Me.OtrosEquiposLabel.TabIndex = 10
        Me.OtrosEquiposLabel.Text = "Otros equipos:"
        Me.OtrosEquiposLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'KitOrientacionNocturnoNumericUpDown
        '
        Me.KitOrientacionNocturnoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KitOrientacionNocturnoNumericUpDown.Location = New System.Drawing.Point(130, 127)
        Me.KitOrientacionNocturnoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.KitOrientacionNocturnoNumericUpDown.Name = "KitOrientacionNocturnoNumericUpDown"
        Me.KitOrientacionNocturnoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.KitOrientacionNocturnoNumericUpDown.TabIndex = 9
        '
        'KitOrientacionNocturnoLabel
        '
        Me.KitOrientacionNocturnoLabel.AutoSize = True
        Me.KitOrientacionNocturnoLabel.Location = New System.Drawing.Point(13, 129)
        Me.KitOrientacionNocturnoLabel.Name = "KitOrientacionNocturnoLabel"
        Me.KitOrientacionNocturnoLabel.Size = New System.Drawing.Size(113, 32)
        Me.KitOrientacionNocturnoLabel.TabIndex = 8
        Me.KitOrientacionNocturnoLabel.Text = "Kit de orientación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nocturno:"
        Me.KitOrientacionNocturnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlasmersNumericUpDown
        '
        Me.FlasmersNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlasmersNumericUpDown.Location = New System.Drawing.Point(130, 102)
        Me.FlasmersNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.FlasmersNumericUpDown.Name = "FlasmersNumericUpDown"
        Me.FlasmersNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.FlasmersNumericUpDown.TabIndex = 7
        '
        'FlasmersLabel
        '
        Me.FlasmersLabel.AutoSize = True
        Me.FlasmersLabel.Location = New System.Drawing.Point(59, 104)
        Me.FlasmersLabel.Name = "FlasmersLabel"
        Me.FlasmersLabel.Size = New System.Drawing.Size(67, 16)
        Me.FlasmersLabel.TabIndex = 6
        Me.FlasmersLabel.Text = "Flasmers:"
        '
        'CamaraTermicaNumericUpDown
        '
        Me.CamaraTermicaNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CamaraTermicaNumericUpDown.Location = New System.Drawing.Point(130, 77)
        Me.CamaraTermicaNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.CamaraTermicaNumericUpDown.Name = "CamaraTermicaNumericUpDown"
        Me.CamaraTermicaNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.CamaraTermicaNumericUpDown.TabIndex = 5
        '
        'CamaraTermicaLabel
        '
        Me.CamaraTermicaLabel.AutoSize = True
        Me.CamaraTermicaLabel.Location = New System.Drawing.Point(20, 79)
        Me.CamaraTermicaLabel.Name = "CamaraTermicaLabel"
        Me.CamaraTermicaLabel.Size = New System.Drawing.Size(106, 16)
        Me.CamaraTermicaLabel.TabIndex = 4
        Me.CamaraTermicaLabel.Text = "Cámara térmica:"
        '
        'BinocularesNumericUpDown
        '
        Me.BinocularesNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BinocularesNumericUpDown.Location = New System.Drawing.Point(130, 52)
        Me.BinocularesNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.BinocularesNumericUpDown.Name = "BinocularesNumericUpDown"
        Me.BinocularesNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.BinocularesNumericUpDown.TabIndex = 3
        '
        'BinocularesLabel
        '
        Me.BinocularesLabel.AutoSize = True
        Me.BinocularesLabel.Location = New System.Drawing.Point(44, 54)
        Me.BinocularesLabel.Name = "BinocularesLabel"
        Me.BinocularesLabel.Size = New System.Drawing.Size(82, 16)
        Me.BinocularesLabel.TabIndex = 2
        Me.BinocularesLabel.Text = "Binoculares:"
        '
        'VisorNocturnoNumericUpDown
        '
        Me.VisorNocturnoNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorNocturnoNumericUpDown.Location = New System.Drawing.Point(130, 27)
        Me.VisorNocturnoNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.VisorNocturnoNumericUpDown.Name = "VisorNocturnoNumericUpDown"
        Me.VisorNocturnoNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.VisorNocturnoNumericUpDown.TabIndex = 1
        '
        'VisorNocturnoLabel
        '
        Me.VisorNocturnoLabel.AutoSize = True
        Me.VisorNocturnoLabel.Location = New System.Drawing.Point(27, 29)
        Me.VisorNocturnoLabel.Name = "VisorNocturnoLabel"
        Me.VisorNocturnoLabel.Size = New System.Drawing.Size(99, 16)
        Me.VisorNocturnoLabel.TabIndex = 0
        Me.VisorNocturnoLabel.Text = "Visor Nocturno:"
        '
        'AmetralladorasGroupBox
        '
        Me.AmetralladorasGroupBox.Controls.Add(Me.OtrasAmetralladorasTextBox)
        Me.AmetralladorasGroupBox.Controls.Add(Me.OtrassAmetralladorasLabel)
        Me.AmetralladorasGroupBox.Controls.Add(Me.Punto50NumericUpDown)
        Me.AmetralladorasGroupBox.Controls.Add(Me.Punto50Label)
        Me.AmetralladorasGroupBox.Controls.Add(Me.ss77NumericUpDown)
        Me.AmetralladorasGroupBox.Controls.Add(Me.ss77Label)
        Me.AmetralladorasGroupBox.Controls.Add(Me.M249NumericUpDown)
        Me.AmetralladorasGroupBox.Controls.Add(Me.M249Label)
        Me.AmetralladorasGroupBox.Controls.Add(Me.m60E4NumericUpDown)
        Me.AmetralladorasGroupBox.Controls.Add(Me.m60E4Label)
        Me.AmetralladorasGroupBox.Controls.Add(Me.m60EstandarNumericUpDown)
        Me.AmetralladorasGroupBox.Controls.Add(Me.m60EstandarLabel)
        Me.AmetralladorasGroupBox.ForeColor = System.Drawing.Color.White
        Me.AmetralladorasGroupBox.Location = New System.Drawing.Point(22, 68)
        Me.AmetralladorasGroupBox.Name = "AmetralladorasGroupBox"
        Me.AmetralladorasGroupBox.Size = New System.Drawing.Size(200, 333)
        Me.AmetralladorasGroupBox.TabIndex = 0
        Me.AmetralladorasGroupBox.TabStop = False
        Me.AmetralladorasGroupBox.Text = "Ametralladoras"
        '
        'OtrasAmetralladorasTextBox
        '
        Me.OtrasAmetralladorasTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrasAmetralladorasTextBox.Location = New System.Drawing.Point(6, 200)
        Me.OtrasAmetralladorasTextBox.Multiline = True
        Me.OtrasAmetralladorasTextBox.Name = "OtrasAmetralladorasTextBox"
        Me.OtrasAmetralladorasTextBox.Size = New System.Drawing.Size(188, 116)
        Me.OtrasAmetralladorasTextBox.TabIndex = 13
        '
        'OtrassAmetralladorasLabel
        '
        Me.OtrassAmetralladorasLabel.AutoSize = True
        Me.OtrassAmetralladorasLabel.Location = New System.Drawing.Point(7, 179)
        Me.OtrassAmetralladorasLabel.Name = "OtrassAmetralladorasLabel"
        Me.OtrassAmetralladorasLabel.Size = New System.Drawing.Size(137, 16)
        Me.OtrassAmetralladorasLabel.TabIndex = 12
        Me.OtrassAmetralladorasLabel.Text = "Otras ametralladoras:"
        Me.OtrassAmetralladorasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Punto50NumericUpDown
        '
        Me.Punto50NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Punto50NumericUpDown.Location = New System.Drawing.Point(110, 135)
        Me.Punto50NumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.Punto50NumericUpDown.Name = "Punto50NumericUpDown"
        Me.Punto50NumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.Punto50NumericUpDown.TabIndex = 9
        '
        'Punto50Label
        '
        Me.Punto50Label.AutoSize = True
        Me.Punto50Label.Location = New System.Drawing.Point(79, 137)
        Me.Punto50Label.Name = "Punto50Label"
        Me.Punto50Label.Size = New System.Drawing.Size(28, 16)
        Me.Punto50Label.TabIndex = 8
        Me.Punto50Label.Text = ".50:"
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
        Me.ss77Label.Location = New System.Drawing.Point(64, 109)
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
        Me.M249Label.Location = New System.Drawing.Point(64, 81)
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
        'Operaciones2GroupBox
        '
        Me.Operaciones2GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Operaciones2GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.Operaciones2GroupBox.Controls.Add(Me.TableLayoutPanel4)
        Me.Operaciones2GroupBox.Controls.Add(Propias_tropasRichTextBoxLabel)
        Me.Operaciones2GroupBox.Controls.Add(Me.Propias_tropasRichTextBox)
        Me.Operaciones2GroupBox.Controls.Add(MisionLabel)
        Me.Operaciones2GroupBox.Controls.Add(Me.MisionRichTextBox)
        Me.Operaciones2GroupBox.Location = New System.Drawing.Point(5, 12)
        Me.Operaciones2GroupBox.Name = "Operaciones2GroupBox"
        Me.Operaciones2GroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.Operaciones2GroupBox.TabIndex = 16
        Me.Operaciones2GroupBox.TabStop = False
        '
        'Propias_tropasRichTextBox
        '
        Me.Propias_tropasRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Propias_tropasRichTextBox.Location = New System.Drawing.Point(19, 41)
        Me.Propias_tropasRichTextBox.Name = "Propias_tropasRichTextBox"
        Me.Propias_tropasRichTextBox.Size = New System.Drawing.Size(531, 409)
        Me.Propias_tropasRichTextBox.TabIndex = 19
        Me.Propias_tropasRichTextBox.Text = ""
        '
        'MisionRichTextBox
        '
        Me.MisionRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MisionRichTextBox.Location = New System.Drawing.Point(577, 41)
        Me.MisionRichTextBox.Name = "MisionRichTextBox"
        Me.MisionRichTextBox.Size = New System.Drawing.Size(490, 413)
        Me.MisionRichTextBox.TabIndex = 21
        Me.MisionRichTextBox.Text = ""
        '
        'FirmasGroupBox
        '
        Me.FirmasGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirmasGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.FirmasGroupBox.Controls.Add(Me.TableLayoutPanel17)
        Me.FirmasGroupBox.Controls.Add(Me.RecibeRichTextBox)
        Me.FirmasGroupBox.Controls.Add(RecibeLabel)
        Me.FirmasGroupBox.Controls.Add(Me.AutenticaRichTextBox)
        Me.FirmasGroupBox.Controls.Add(AutenticaLabel)
        Me.FirmasGroupBox.Controls.Add(Me.AutorizaRichTextBox)
        Me.FirmasGroupBox.Controls.Add(AutorizaLabel)
        Me.FirmasGroupBox.ForeColor = System.Drawing.Color.White
        Me.FirmasGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.FirmasGroupBox.Name = "FirmasGroupBox"
        Me.FirmasGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.FirmasGroupBox.TabIndex = 17
        Me.FirmasGroupBox.TabStop = False
        Me.FirmasGroupBox.Text = "Firmas"
        '
        'RecibeRichTextBox
        '
        Me.RecibeRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecibeRichTextBox.Location = New System.Drawing.Point(80, 227)
        Me.RecibeRichTextBox.Name = "RecibeRichTextBox"
        Me.RecibeRichTextBox.Size = New System.Drawing.Size(956, 96)
        Me.RecibeRichTextBox.TabIndex = 23
        Me.RecibeRichTextBox.Text = ""
        '
        'AutenticaRichTextBox
        '
        Me.AutenticaRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutenticaRichTextBox.Location = New System.Drawing.Point(80, 124)
        Me.AutenticaRichTextBox.Name = "AutenticaRichTextBox"
        Me.AutenticaRichTextBox.Size = New System.Drawing.Size(956, 96)
        Me.AutenticaRichTextBox.TabIndex = 21
        Me.AutenticaRichTextBox.Text = ""
        '
        'AutorizaRichTextBox
        '
        Me.AutorizaRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutorizaRichTextBox.Location = New System.Drawing.Point(81, 21)
        Me.AutorizaRichTextBox.Name = "AutorizaRichTextBox"
        Me.AutorizaRichTextBox.Size = New System.Drawing.Size(956, 96)
        Me.AutorizaRichTextBox.TabIndex = 19
        Me.AutorizaRichTextBox.Text = ""
        '
        'AnexosGroupBox
        '
        Me.AnexosGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnexosGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AnexosGroupBox.Controls.Add(Me.TableLayoutPanel16)
        Me.AnexosGroupBox.Controls.Add(Me.AnexosDataGridView)
        Me.AnexosGroupBox.Controls.Add(Me.QuitarButton)
        Me.AnexosGroupBox.Controls.Add(Me.AgregarAnexoButton)
        Me.AnexosGroupBox.ForeColor = System.Drawing.Color.White
        Me.AnexosGroupBox.Location = New System.Drawing.Point(5, 12)
        Me.AnexosGroupBox.Name = "AnexosGroupBox"
        Me.AnexosGroupBox.Size = New System.Drawing.Size(1150, 476)
        Me.AnexosGroupBox.TabIndex = 18
        Me.AnexosGroupBox.TabStop = False
        Me.AnexosGroupBox.Text = "Anexos"
        '
        'AnexosDataGridView
        '
        Me.AnexosDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.AnexosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.AnexosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnexosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AnexosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AnexosDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.AnexosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnexosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreArchivo, Me.ruta})
        Me.AnexosDataGridView.GridColor = System.Drawing.Color.Black
        Me.AnexosDataGridView.Location = New System.Drawing.Point(19, 71)
        Me.AnexosDataGridView.Name = "AnexosDataGridView"
        Me.AnexosDataGridView.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AnexosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        Me.AnexosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.AnexosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AnexosDataGridView.Size = New System.Drawing.Size(1110, 383)
        Me.AnexosDataGridView.TabIndex = 22
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
        'QuitarButton
        '
        Me.QuitarButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.QuitarButton.Location = New System.Drawing.Point(204, 29)
        Me.QuitarButton.Name = "QuitarButton"
        Me.QuitarButton.Size = New System.Drawing.Size(184, 29)
        Me.QuitarButton.TabIndex = 21
        Me.QuitarButton.Text = "Quitar anexo seleccionado"
        Me.QuitarButton.UseVisualStyleBackColor = True
        '
        'AgregarAnexoButton
        '
        Me.AgregarAnexoButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.AgregarAnexoButton.Location = New System.Drawing.Point(19, 29)
        Me.AgregarAnexoButton.Name = "AgregarAnexoButton"
        Me.AgregarAnexoButton.Size = New System.Drawing.Size(179, 29)
        Me.AgregarAnexoButton.TabIndex = 20
        Me.AgregarAnexoButton.Text = "Agregar archivo anexo"
        Me.AgregarAnexoButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Todos los archivos|*.*"
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.Title = "Seleccionar anexo"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Operaciones1LinkLabel, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.toeLinkLabel, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1073, 21)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel4.TabIndex = 22
        '
        'Operaciones1LinkLabel
        '
        Me.Operaciones1LinkLabel.AutoSize = True
        Me.Operaciones1LinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.Operaciones1LinkLabel.Location = New System.Drawing.Point(3, 22)
        Me.Operaciones1LinkLabel.Name = "Operaciones1LinkLabel"
        Me.Operaciones1LinkLabel.Size = New System.Drawing.Size(39, 16)
        Me.Operaciones1LinkLabel.TabIndex = 2
        Me.Operaciones1LinkLabel.TabStop = True
        Me.Operaciones1LinkLabel.Text = "Atrás"
        Me.Operaciones1LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toeLinkLabel
        '
        Me.toeLinkLabel.AutoSize = True
        Me.toeLinkLabel.ForeColor = System.Drawing.Color.Yellow
        Me.toeLinkLabel.LinkColor = System.Drawing.Color.Yellow
        Me.toeLinkLabel.Location = New System.Drawing.Point(3, 0)
        Me.toeLinkLabel.Name = "toeLinkLabel"
        Me.toeLinkLabel.Size = New System.Drawing.Size(64, 16)
        Me.toeLinkLabel.TabIndex = 1
        Me.toeLinkLabel.TabStop = True
        Me.toeLinkLabel.Text = "Siguiente"
        Me.toeLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.LinkLabel1, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.LinkLabel2, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1058, 27)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel5.TabIndex = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Atrás"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Siguiente"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.LinkLabel3, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.LinkLabel4, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(1006, 45)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel6.TabIndex = 24
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel3.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Atrás"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel4.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel4.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel4.TabIndex = 1
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Siguiente"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.LinkLabel5, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.LinkLabel6, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(1054, 29)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel7.TabIndex = 24
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel5.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel5.TabIndex = 2
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Atrás"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel6.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel6.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel6.TabIndex = 1
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Siguiente"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.LinkLabel7, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.LinkLabel8, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(1064, 38)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel8.TabIndex = 24
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel7.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel7.TabIndex = 2
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Atrás"
        Me.LinkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel8.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel8.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel8.TabIndex = 1
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Siguiente"
        Me.LinkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.LinkLabel9, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.LinkLabel10, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(1069, 32)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel9.TabIndex = 24
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel9.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel9.TabIndex = 2
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Atrás"
        Me.LinkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel10.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel10.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel10.TabIndex = 1
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "Siguiente"
        Me.LinkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.LinkLabel11, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.LinkLabel12, 0, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(1060, 32)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel10.TabIndex = 24
        '
        'LinkLabel11
        '
        Me.LinkLabel11.AutoSize = True
        Me.LinkLabel11.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel11.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel11.TabIndex = 2
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "Atrás"
        Me.LinkLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel12.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel12.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel12.TabIndex = 1
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Siguiente"
        Me.LinkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.LinkLabel13, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.LinkLabel14, 0, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(1054, 44)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel11.TabIndex = 24
        '
        'LinkLabel13
        '
        Me.LinkLabel13.AutoSize = True
        Me.LinkLabel13.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel13.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel13.TabIndex = 2
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "Atrás"
        Me.LinkLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel14
        '
        Me.LinkLabel14.AutoSize = True
        Me.LinkLabel14.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel14.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel14.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel14.Name = "LinkLabel14"
        Me.LinkLabel14.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel14.TabIndex = 1
        Me.LinkLabel14.TabStop = True
        Me.LinkLabel14.Text = "Siguiente"
        Me.LinkLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.LinkLabel15, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.LinkLabel16, 0, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(1056, 38)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel12.TabIndex = 24
        '
        'LinkLabel15
        '
        Me.LinkLabel15.AutoSize = True
        Me.LinkLabel15.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel15.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel15.Name = "LinkLabel15"
        Me.LinkLabel15.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel15.TabIndex = 2
        Me.LinkLabel15.TabStop = True
        Me.LinkLabel15.Text = "Atrás"
        Me.LinkLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel16
        '
        Me.LinkLabel16.AutoSize = True
        Me.LinkLabel16.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel16.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel16.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel16.Name = "LinkLabel16"
        Me.LinkLabel16.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel16.TabIndex = 1
        Me.LinkLabel16.TabStop = True
        Me.LinkLabel16.Text = "Siguiente"
        Me.LinkLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.LinkLabel17, 0, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.LinkLabel18, 0, 0)
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(1040, 38)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 2
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel13.TabIndex = 24
        '
        'LinkLabel17
        '
        Me.LinkLabel17.AutoSize = True
        Me.LinkLabel17.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel17.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel17.Name = "LinkLabel17"
        Me.LinkLabel17.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel17.TabIndex = 2
        Me.LinkLabel17.TabStop = True
        Me.LinkLabel17.Text = "Atrás"
        Me.LinkLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel18
        '
        Me.LinkLabel18.AutoSize = True
        Me.LinkLabel18.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel18.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel18.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel18.Name = "LinkLabel18"
        Me.LinkLabel18.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel18.TabIndex = 1
        Me.LinkLabel18.TabStop = True
        Me.LinkLabel18.Text = "Siguiente"
        Me.LinkLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.LinkLabel19, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.LinkLabel20, 0, 0)
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(1058, 44)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel14.TabIndex = 24
        '
        'LinkLabel19
        '
        Me.LinkLabel19.AutoSize = True
        Me.LinkLabel19.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel19.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel19.Name = "LinkLabel19"
        Me.LinkLabel19.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel19.TabIndex = 2
        Me.LinkLabel19.TabStop = True
        Me.LinkLabel19.Text = "Atrás"
        Me.LinkLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel20
        '
        Me.LinkLabel20.AutoSize = True
        Me.LinkLabel20.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel20.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel20.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel20.Name = "LinkLabel20"
        Me.LinkLabel20.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel20.TabIndex = 1
        Me.LinkLabel20.TabStop = True
        Me.LinkLabel20.Text = "Siguiente"
        Me.LinkLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel15.ColumnCount = 1
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.LinkLabel21, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.LinkLabel22, 0, 0)
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(1066, 24)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel15.TabIndex = 24
        '
        'LinkLabel21
        '
        Me.LinkLabel21.AutoSize = True
        Me.LinkLabel21.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel21.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel21.Name = "LinkLabel21"
        Me.LinkLabel21.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel21.TabIndex = 2
        Me.LinkLabel21.TabStop = True
        Me.LinkLabel21.Text = "Atrás"
        Me.LinkLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel22
        '
        Me.LinkLabel22.AutoSize = True
        Me.LinkLabel22.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel22.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel22.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel22.Name = "LinkLabel22"
        Me.LinkLabel22.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel22.TabIndex = 1
        Me.LinkLabel22.TabStop = True
        Me.LinkLabel22.Text = "Siguiente"
        Me.LinkLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel16.ColumnCount = 1
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel23, 0, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.LinkLabel24, 0, 0)
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(1056, 17)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel16.TabIndex = 24
        '
        'LinkLabel23
        '
        Me.LinkLabel23.AutoSize = True
        Me.LinkLabel23.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel23.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel23.Name = "LinkLabel23"
        Me.LinkLabel23.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel23.TabIndex = 2
        Me.LinkLabel23.TabStop = True
        Me.LinkLabel23.Text = "Atrás"
        Me.LinkLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel24
        '
        Me.LinkLabel24.AutoSize = True
        Me.LinkLabel24.ForeColor = System.Drawing.Color.Yellow
        Me.LinkLabel24.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel24.Location = New System.Drawing.Point(3, 0)
        Me.LinkLabel24.Name = "LinkLabel24"
        Me.LinkLabel24.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel24.TabIndex = 1
        Me.LinkLabel24.TabStop = True
        Me.LinkLabel24.Text = "Siguiente"
        Me.LinkLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel17.ColumnCount = 1
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.LinkLabel25, 0, 1)
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(1073, 21)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 2
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(71, 44)
        Me.TableLayoutPanel17.TabIndex = 24
        '
        'LinkLabel25
        '
        Me.LinkLabel25.AutoSize = True
        Me.LinkLabel25.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel25.Location = New System.Drawing.Point(3, 22)
        Me.LinkLabel25.Name = "LinkLabel25"
        Me.LinkLabel25.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel25.TabIndex = 2
        Me.LinkLabel25.TabStop = True
        Me.LinkLabel25.Text = "Atrás"
        Me.LinkLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OperacionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1184, 595)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "OperacionForm"
        Me.Text = "OperacionForm"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.TituloLabel, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.SegundosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Operaciones1GroupBox.ResumeLayout(False)
        Me.Operaciones1GroupBox.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ToeGroupBox.ResumeLayout(False)
        Me.ToeGroupBox.PerformLayout()
        CType(Me.CivilesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imrNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.impNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuboficialesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficialesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoordenadasGroupBox.ResumeLayout(False)
        Me.CoordenadasGroupBox.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.MinutosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosLng3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutosLat3NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MinutosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosLgn1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutosLat1NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ejecucion1GroupBox.ResumeLayout(False)
        Me.Ejecucion1GroupBox.PerformLayout()
        Me.Ejecucion2GroupBox.ResumeLayout(False)
        Me.Ejecucion2GroupBox.PerformLayout()
        Me.Ejecucion3GroupBox.ResumeLayout(False)
        Me.Ejecucion3GroupBox.PerformLayout()
        Me.Ejecucion4GroupBox.ResumeLayout(False)
        Me.Ejecucion4GroupBox.PerformLayout()
        Me.Ejecucion5GroupBox.ResumeLayout(False)
        Me.Ejecucion5GroupBox.PerformLayout()
        Me.Ejecucion6GroupBox.ResumeLayout(False)
        Me.Ejecucion6GroupBox.PerformLayout()
        Me.AbastecimientosGroupBox.ResumeLayout(False)
        Me.AbastecimientosGroupBox.PerformLayout()
        Me.ComunicacionesGroupBox.ResumeLayout(False)
        Me.ComunicacionesGroupBox.PerformLayout()
        Me.OtrosComGroupBox.ResumeLayout(False)
        Me.OtrosComGroupBox.PerformLayout()
        Me.UHFGroupBox.ResumeLayout(False)
        Me.UHFGroupBox.PerformLayout()
        CType(Me.uhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uhfXTR3000NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uhfXTS4250NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HFGroupBox.ResumeLayout(False)
        Me.HFGroupBox.PerformLayout()
        CType(Me.hfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hf6020NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VHFGroupBox.ResumeLayout(False)
        Me.VHFGroupBox.PerformLayout()
        CType(Me.vhfEscanerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhfAereoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhf930NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhf710NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhf7330NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArmamentoGroupBox.ResumeLayout(False)
        Me.MorterosGroupBox.ResumeLayout(False)
        Me.MorterosGroupBox.PerformLayout()
        CType(Me.m_brandt_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc_fms_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc_c575_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc_c370_60mmNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LanzagranadasGroupBox.ResumeLayout(False)
        Me.LanzagranadasGroupBox.PerformLayout()
        CType(Me.M203NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M79NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MKNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MGLNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GranadasGroupBox.ResumeLayout(False)
        Me.GranadasGroupBox.PerformLayout()
        CType(Me.LacrimogenoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HumoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FusilesGroupBox.ResumeLayout(False)
        Me.FusilesGroupBox.PerformLayout()
        CType(Me.m16NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GalilNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquiposEspecialesGroupBox.ResumeLayout(False)
        Me.EquiposEspecialesGroupBox.PerformLayout()
        CType(Me.KitOrientacionNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlasmersNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamaraTermicaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinocularesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisorNocturnoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AmetralladorasGroupBox.ResumeLayout(False)
        Me.AmetralladorasGroupBox.PerformLayout()
        CType(Me.Punto50NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ss77NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M249NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m60E4NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m60EstandarNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Operaciones2GroupBox.ResumeLayout(False)
        Me.Operaciones2GroupBox.PerformLayout()
        Me.FirmasGroupBox.ResumeLayout(False)
        Me.FirmasGroupBox.PerformLayout()
        Me.AnexosGroupBox.ResumeLayout(False)
        CType(Me.AnexosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.TableLayoutPanel17.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Operaciones1GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OperacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_operacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProcedimientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_operacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Autoriza_deTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comandante_operacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndicativoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SituacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ToeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AgregacionesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AgregacionesLabel As System.Windows.Forms.Label
    Friend WithEvents CivilesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CivilesLabel As System.Windows.Forms.Label
    Friend WithEvents imrNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents imrLabel As System.Windows.Forms.Label
    Friend WithEvents impNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents impLabel As System.Windows.Forms.Label
    Friend WithEvents SuboficialesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SuboficialesLabel As System.Windows.Forms.Label
    Friend WithEvents OficialesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents OficialesLabel As System.Windows.Forms.Label
    Friend WithEvents Operaciones1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoordenadasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Punto3Label As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SegundosLng3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MinutosLng3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GradosLng3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Latitud3Label As System.Windows.Forms.Label
    Friend WithEvents GradosLat3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Grados3Label As System.Windows.Forms.Label
    Friend WithEvents Minutos3Label As System.Windows.Forms.Label
    Friend WithEvents Segundos3Label As System.Windows.Forms.Label
    Friend WithEvents MinutosLat3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SegundosLat3NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Longitud3Label As System.Windows.Forms.Label
    Friend WithEvents Punto1Label As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SegundosLgn1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MinutosLgn1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GradosLgn1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Latitud1Label As System.Windows.Forms.Label
    Friend WithEvents GradosLat1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Grados1Label As System.Windows.Forms.Label
    Friend WithEvents Minutos1Label As System.Windows.Forms.Label
    Friend WithEvents Segundos1Label As System.Windows.Forms.Label
    Friend WithEvents MinutosLat1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SegundosLat1NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Longitud1Label As System.Windows.Forms.Label
    Friend WithEvents CoordenadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion1GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ConceptoRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IntencionComandanteRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents IntencionComandanteLabel As System.Windows.Forms.Label
    Friend WithEvents EjecucionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion2GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FuegosRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents FuegosLabel As System.Windows.Forms.Label
    Friend WithEvents ManiobraRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents maniobraLabel As System.Windows.Forms.Label
    Friend WithEvents Ejecucion2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejecucion3GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TareasCombateRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TareasCombateLabel As System.Windows.Forms.Label
    Friend WithEvents TareasManiobraRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TareasManiobraLabel As System.Windows.Forms.Label
    Friend WithEvents Ejecucion4GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NivelHostilidadRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NivelHostilidadLabel As System.Windows.Forms.Label
    Friend WithEvents InstruccionesCoordinacionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents InstruccionesCoordinacionLabel As System.Windows.Forms.Label
    Friend WithEvents Ejecucion5GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PrincipiosRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents PrincipiosLabel As System.Windows.Forms.Label
    Friend WithEvents MarcoJuridicoRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MarcoJuridicoLabel As System.Windows.Forms.Label
    Friend WithEvents Ejecucion6GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents InstruccionesEspecialesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents InstruccionesEspecialesLabel As System.Windows.Forms.Label
    Friend WithEvents UsoFuerzaRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UsoFuerzaLabel As System.Windows.Forms.Label
    Friend WithEvents TarjetaAzulRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TarjetaRojaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AbastecimientosGroupBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents EvacuacionesMedicasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents EvacuacionesMedicasLabel As System.Windows.Forms.Label
    Friend WithEvents AbastecimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComunicacionesGroupBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents HFGroupBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents xts4250Label As System.Windows.Forms.Label
    Friend WithEvents OtrosComGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ClaveLabel As System.Windows.Forms.Label
    Friend WithEvents SatelitalLabel As System.Windows.Forms.Label
    Friend WithEvents CelularLabel As System.Windows.Forms.Label
    Friend WithEvents AvantelLabel As System.Windows.Forms.Label
    Friend WithEvents ClaveComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SatelitalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AvantelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComunicacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArmamentoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LanzagranadasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MKNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MKLabel As System.Windows.Forms.Label
    Friend WithEvents MGLNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MGLLabel As System.Windows.Forms.Label
    Friend WithEvents GranadasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FusilesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents m16NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m16Label As System.Windows.Forms.Label
    Friend WithEvents GalilNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GalilLabel As System.Windows.Forms.Label
    Friend WithEvents EquiposEspecialesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BinocularesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BinocularesLabel As System.Windows.Forms.Label
    Friend WithEvents VisorNocturnoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents VisorNocturnoLabel As System.Windows.Forms.Label
    Friend WithEvents AmetralladorasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Punto50NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Punto50Label As System.Windows.Forms.Label
    Friend WithEvents ss77NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ss77Label As System.Windows.Forms.Label
    Friend WithEvents M249NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents M249Label As System.Windows.Forms.Label
    Friend WithEvents m60E4NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m60E4Label As System.Windows.Forms.Label
    Friend WithEvents m60EstandarNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m60EstandarLabel As System.Windows.Forms.Label
    Friend WithEvents ArmamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KitOrientacionNocturnoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents KitOrientacionNocturnoLabel As System.Windows.Forms.Label
    Friend WithEvents FlasmersNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents FlasmersLabel As System.Windows.Forms.Label
    Friend WithEvents CamaraTermicaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CamaraTermicaLabel As System.Windows.Forms.Label
    Friend WithEvents OtrosEquiposTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrosEquiposLabel As System.Windows.Forms.Label
    Friend WithEvents OtrasGranadasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrasGranadasLabel As System.Windows.Forms.Label
    Friend WithEvents LacrimogenoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LacrimogenoLabel As System.Windows.Forms.Label
    Friend WithEvents HumoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HumoLabel As System.Windows.Forms.Label
    Friend WithEvents ManoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ManoLabel As System.Windows.Forms.Label
    Friend WithEvents M203NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents M203Label As System.Windows.Forms.Label
    Friend WithEvents M79NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents M79Label As System.Windows.Forms.Label
    Friend WithEvents Operaciones2GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Propias_tropasRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MisionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Operaciones2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmasGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RecibeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AutenticaRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AutorizaRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AnexosGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AgregarAnexoButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents QuitarButton As System.Windows.Forms.Button
    Friend WithEvents AnexosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents nombreArchivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplementosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplementosLabel As System.Windows.Forms.Label
    Friend WithEvents OtrasAmetralladorasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrassAmetralladorasLabel As System.Windows.Forms.Label
    Friend WithEvents OtrosFusilesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrosFusilesLabel As System.Windows.Forms.Label
    Friend WithEvents MorterosGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OtrosMorterosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrosMorterosLabel As System.Windows.Forms.Label
    Friend WithEvents mc_c575_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mc_c575_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents mc_c370_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mc_c370_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents m_brandt_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents m_brandt_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents mc_fms_60mmNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents mc_fms_60mmLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Operaciones2LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Operaciones1LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents toeLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel17 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel25 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel16 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel23 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel24 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel15 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel21 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel22 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel14 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel19 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel20 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel17 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel18 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel15 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel16 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel13 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel14 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel11 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel12 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel10 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
End Class
