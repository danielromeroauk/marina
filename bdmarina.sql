USE [bdmarina]
GO
/****** Object:  ForeignKey [FK_toe_operaciones]    Script Date: 07/03/2012 16:20:20 ******/
ALTER TABLE [dbo].[toe] DROP CONSTRAINT [FK_toe_operaciones]
GO
/****** Object:  ForeignKey [FK_granadas_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[granadas] DROP CONSTRAINT [FK_granadas_operaciones]
GO
/****** Object:  ForeignKey [FK_fusiles_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[fusiles] DROP CONSTRAINT [FK_fusiles_operaciones]
GO
/****** Object:  ForeignKey [FK_firmas_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[firmas] DROP CONSTRAINT [FK_firmas_operaciones]
GO
/****** Object:  ForeignKey [FK_equipos_especiales_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[equipos_especiales] DROP CONSTRAINT [FK_equipos_especiales_operaciones]
GO
/****** Object:  ForeignKey [FK_ejecucion_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[ejecucion] DROP CONSTRAINT [FK_ejecucion_operaciones]
GO
/****** Object:  ForeignKey [FK_coordenadas_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[coordenadas] DROP CONSTRAINT [FK_coordenadas_operaciones]
GO
/****** Object:  ForeignKey [FK_comunicaciones_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[comunicaciones] DROP CONSTRAINT [FK_comunicaciones_operaciones]
GO
/****** Object:  ForeignKey [FK_anexos_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[anexos] DROP CONSTRAINT [FK_anexos_operaciones]
GO
/****** Object:  ForeignKey [FK_ametralladoras_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[ametralladoras] DROP CONSTRAINT [FK_ametralladoras_operaciones]
GO
/****** Object:  ForeignKey [FK_abastecimientos_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[abastecimientos] DROP CONSTRAINT [FK_abastecimientos_operaciones]
GO
/****** Object:  ForeignKey [FK_morteros_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[morteros] DROP CONSTRAINT [FK_morteros_operaciones]
GO
/****** Object:  ForeignKey [FK_lanzagranadas_operaciones]    Script Date: 07/03/2012 16:20:24 ******/
ALTER TABLE [dbo].[lanzagranadas] DROP CONSTRAINT [FK_lanzagranadas_operaciones]
GO
/****** Object:  Table [dbo].[lanzagranadas]    Script Date: 07/03/2012 16:20:24 ******/
ALTER TABLE [dbo].[lanzagranadas] DROP CONSTRAINT [FK_lanzagranadas_operaciones]
GO
DROP TABLE [dbo].[lanzagranadas]
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 07/03/2012 16:20:24 ******/
DROP PROCEDURE [dbo].[Login]
GO
/****** Object:  Table [dbo].[morteros]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[morteros] DROP CONSTRAINT [FK_morteros_operaciones]
GO
DROP TABLE [dbo].[morteros]
GO
/****** Object:  Table [dbo].[abastecimientos]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[abastecimientos] DROP CONSTRAINT [FK_abastecimientos_operaciones]
GO
DROP TABLE [dbo].[abastecimientos]
GO
/****** Object:  Table [dbo].[ametralladoras]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[ametralladoras] DROP CONSTRAINT [FK_ametralladoras_operaciones]
GO
DROP TABLE [dbo].[ametralladoras]
GO
/****** Object:  Table [dbo].[anexos]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[anexos] DROP CONSTRAINT [FK_anexos_operaciones]
GO
DROP TABLE [dbo].[anexos]
GO
/****** Object:  StoredProcedure [dbo].[CambiarClave]    Script Date: 07/03/2012 16:20:23 ******/
DROP PROCEDURE [dbo].[CambiarClave]
GO
/****** Object:  Table [dbo].[comunicaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[comunicaciones] DROP CONSTRAINT [FK_comunicaciones_operaciones]
GO
DROP TABLE [dbo].[comunicaciones]
GO
/****** Object:  Table [dbo].[coordenadas]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[coordenadas] DROP CONSTRAINT [FK_coordenadas_operaciones]
GO
DROP TABLE [dbo].[coordenadas]
GO
/****** Object:  Table [dbo].[ejecucion]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[ejecucion] DROP CONSTRAINT [FK_ejecucion_operaciones]
GO
DROP TABLE [dbo].[ejecucion]
GO
/****** Object:  Table [dbo].[equipos_especiales]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[equipos_especiales] DROP CONSTRAINT [FK_equipos_especiales_operaciones]
GO
DROP TABLE [dbo].[equipos_especiales]
GO
/****** Object:  Table [dbo].[firmas]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[firmas] DROP CONSTRAINT [FK_firmas_operaciones]
GO
DROP TABLE [dbo].[firmas]
GO
/****** Object:  Table [dbo].[fusiles]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[fusiles] DROP CONSTRAINT [FK_fusiles_operaciones]
GO
DROP TABLE [dbo].[fusiles]
GO
/****** Object:  Table [dbo].[granadas]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[granadas] DROP CONSTRAINT [FK_granadas_operaciones]
GO
DROP TABLE [dbo].[granadas]
GO
/****** Object:  StoredProcedure [dbo].[SelectByOperacion]    Script Date: 07/03/2012 16:20:23 ******/
DROP PROCEDURE [dbo].[SelectByOperacion]
GO
/****** Object:  Table [dbo].[toe]    Script Date: 07/03/2012 16:20:20 ******/
ALTER TABLE [dbo].[toe] DROP CONSTRAINT [FK_toe_operaciones]
GO
DROP TABLE [dbo].[toe]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 07/03/2012 16:20:20 ******/
DROP TABLE [dbo].[usuarios]
GO
/****** Object:  Table [dbo].[inteligencias]    Script Date: 07/03/2012 16:20:20 ******/
DROP TABLE [dbo].[inteligencias]
GO
/****** Object:  Table [dbo].[operaciones]    Script Date: 07/03/2012 16:20:20 ******/
DROP TABLE [dbo].[operaciones]
GO
/****** Object:  Table [dbo].[operaciones]    Script Date: 07/03/2012 16:20:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[operaciones](
	[operacion] [nchar](20) NOT NULL,
	[nombre_operacion] [varchar](300) NOT NULL,
	[procedimiento] [text] NOT NULL,
	[fecha_operacion] [date] NOT NULL,
	[autoriza_de] [varchar](300) NOT NULL,
	[comandante_operacion] [varchar](300) NOT NULL,
	[indicativo] [varchar](300) NOT NULL,
	[referencias] [text] NOT NULL,
	[situacion] [text] NOT NULL,
	[propias_tropas] [text] NOT NULL,
	[mision] [text] NOT NULL,
 CONSTRAINT [PK_operacion] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inteligencias]    Script Date: 07/03/2012 16:20:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inteligencias](
	[codigo] [nchar](20) NOT NULL,
	[latitud] [numeric](12, 9) NOT NULL,
	[longitud] [numeric](12, 9) NOT NULL,
	[nombre_lugar] [varchar](300) NOT NULL,
	[blanco] [varchar](300) NOT NULL,
	[fecha_hechos] [date] NOT NULL,
	[actividades] [varchar](300) NOT NULL,
	[anotaciones] [ntext] NULL,
 CONSTRAINT [PK_inteligencias] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 07/03/2012 16:20:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [nchar](20) NOT NULL,
	[nombre] [varchar](300) NULL,
	[clave] [varchar](300) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[toe]    Script Date: 07/03/2012 16:20:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[toe](
	[operacion] [nchar](20) NOT NULL,
	[oficiales] [numeric](18, 0) NOT NULL,
	[suboficiales] [numeric](18, 0) NOT NULL,
	[imp] [numeric](18, 0) NOT NULL,
	[imr] [numeric](18, 0) NOT NULL,
	[civiles] [numeric](18, 0) NOT NULL,
	[agregaciones] [ntext] NULL,
 CONSTRAINT [PK_toe] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SelectByOperacion]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectByOperacion]
(
	@operacion nchar(20)
)
AS
	SET NOCOUNT ON;
SELECT        operacion, nombre_operacion, procedimiento, fecha_operacion, autoriza_de, comandante_operacion, indicativo, referencias, situacion, propias_tropas, mision
FROM            operaciones
WHERE        (operacion = @operacion)
GO
/****** Object:  Table [dbo].[granadas]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[granadas](
	[operacion] [nchar](20) NOT NULL,
	[mano] [numeric](18, 0) NULL,
	[humo] [numeric](18, 0) NULL,
	[lacrimogeno] [numeric](18, 0) NULL,
	[otras_granadas] [ntext] NULL,
 CONSTRAINT [PK_granadas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fusiles]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fusiles](
	[operacion] [nchar](20) NOT NULL,
	[galil] [numeric](18, 0) NULL,
	[m16] [numeric](18, 0) NULL,
	[otros_fusiles] [ntext] NULL,
 CONSTRAINT [PK_fusiles] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[firmas]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[firmas](
	[operacion] [nchar](20) NOT NULL,
	[autoriza] [varchar](300) NOT NULL,
	[autentica] [varchar](300) NOT NULL,
	[recibe] [varchar](300) NOT NULL,
 CONSTRAINT [PK_firmas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[equipos_especiales]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[equipos_especiales](
	[operacion] [nchar](20) NOT NULL,
	[visor_nocturno] [numeric](18, 0) NULL,
	[binoculares] [numeric](18, 0) NULL,
	[camara_termica] [numeric](18, 0) NULL,
	[flasmers] [numeric](18, 0) NULL,
	[kit_orientacion_nocturno] [numeric](18, 0) NULL,
	[otros_equipos] [varchar](300) NULL,
 CONSTRAINT [PK_equipos_especiales] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ejecucion]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ejecucion](
	[operacion] [nchar](20) NOT NULL,
	[intencion_comandante] [ntext] NOT NULL,
	[concepto] [ntext] NOT NULL,
	[maniobra] [ntext] NOT NULL,
	[fuegos] [ntext] NOT NULL,
	[tareas_maniobra] [ntext] NOT NULL,
	[tareas_combate] [ntext] NOT NULL,
	[instrucciones_coordinacion] [ntext] NOT NULL,
	[nivel_hostilidad] [ntext] NOT NULL,
	[marco_juridico] [ntext] NOT NULL,
	[principios] [ntext] NOT NULL,
	[uso_fuerza] [ntext] NOT NULL,
	[instrucciones_especiales] [ntext] NOT NULL,
 CONSTRAINT [PK_ejecucion] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[coordenadas]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coordenadas](
	[operacion] [nchar](20) NOT NULL,
	[latitud1] [numeric](12, 9) NOT NULL,
	[longitud1] [numeric](12, 9) NOT NULL,
	[latitud3] [numeric](12, 9) NOT NULL,
	[longitud3] [numeric](12, 9) NOT NULL,
 CONSTRAINT [PK_coordenadas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comunicaciones]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comunicaciones](
	[operacion] [nchar](20) NOT NULL,
	[vhf_7330] [numeric](18, 0) NULL,
	[vhf_710] [numeric](18, 0) NULL,
	[vhf_930] [numeric](18, 0) NULL,
	[vhf_aereo] [numeric](18, 0) NULL,
	[vhf_escaner] [numeric](18, 0) NULL,
	[hf_6020] [numeric](18, 0) NULL,
	[hf_escaner] [numeric](18, 0) NULL,
	[uhf_xts4250] [numeric](18, 0) NULL,
	[uhf_xtr3000] [numeric](18, 0) NULL,
	[uhf_escaner] [numeric](18, 0) NULL,
	[avantel] [varchar](300) NULL,
	[celular] [varchar](300) NULL,
	[satelital] [varchar](300) NULL,
	[clave] [varchar](300) NULL,
	[complementos] [ntext] NULL,
 CONSTRAINT [PK_comunicaciones] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Santo y seña de las comunicaciones.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'comunicaciones', @level2type=N'COLUMN',@level2name=N'clave'
GO
/****** Object:  StoredProcedure [dbo].[CambiarClave]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CambiarClave]
(
	@clave varchar(300),
	@Original_id nchar(20),
	@Original_clave varchar(300)
)
AS
	SET NOCOUNT OFF;
UPDATE       usuarios
SET                clave = @clave
WHERE        (id = @Original_id) AND (clave = HASHBYTES('SHA1', @Original_clave))
GO
/****** Object:  Table [dbo].[anexos]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[anexos](
	[operacion] [nchar](20) NOT NULL,
	[nombre] [varchar](300) NOT NULL,
	[ruta] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ametralladoras]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ametralladoras](
	[operacion] [nchar](20) NOT NULL,
	[m60_estandar] [numeric](18, 0) NULL,
	[m60_e4] [numeric](18, 0) NULL,
	[m249] [numeric](18, 0) NULL,
	[ss77] [numeric](18, 0) NULL,
	[punto50] [numeric](18, 0) NULL,
	[otras_ametralladoras] [ntext] NULL,
 CONSTRAINT [PK_ametralladoras] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[abastecimientos]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[abastecimientos](
	[operacion] [nchar](20) NOT NULL,
	[clase1] [ntext] NULL,
	[clase2] [ntext] NULL,
	[clase3] [ntext] NULL,
	[clase4] [ntext] NULL,
	[clase5] [ntext] NULL,
	[clase6] [ntext] NULL,
	[evacuaciones_medicas] [ntext] NULL,
 CONSTRAINT [PK_abastecimientos] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[morteros]    Script Date: 07/03/2012 16:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[morteros](
	[operacion] [nchar](20) NOT NULL,
	[mc_c370_60mm] [numeric](18, 0) NULL,
	[mc_c575_60mm] [numeric](18, 0) NULL,
	[mc_fms_60mm] [numeric](18, 0) NULL,
	[m_brandt_60mm] [numeric](18, 0) NULL,
	[otros_morteros] [ntext] NULL,
 CONSTRAINT [PK_morteros] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 07/03/2012 16:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login]
(
	@id nchar(20),
	@clave varchar(300)
)
AS
	SET NOCOUNT ON;
SELECT        id, nombre, clave
FROM            usuarios
WHERE        (id = @id) AND (clave = HASHBYTES('SHA1', @clave))
GO
/****** Object:  Table [dbo].[lanzagranadas]    Script Date: 07/03/2012 16:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lanzagranadas](
	[operacion] [nchar](20) NOT NULL,
	[mgl] [numeric](18, 0) NULL,
	[mk] [numeric](18, 0) NULL,
	[m79] [numeric](18, 0) NULL,
	[m203] [numeric](18, 0) NULL,
 CONSTRAINT [PK_lanzagranadas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_toe_operaciones]    Script Date: 07/03/2012 16:20:20 ******/
ALTER TABLE [dbo].[toe]  WITH CHECK ADD  CONSTRAINT [FK_toe_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[toe] CHECK CONSTRAINT [FK_toe_operaciones]
GO
/****** Object:  ForeignKey [FK_granadas_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[granadas]  WITH CHECK ADD  CONSTRAINT [FK_granadas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[granadas] CHECK CONSTRAINT [FK_granadas_operaciones]
GO
/****** Object:  ForeignKey [FK_fusiles_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[fusiles]  WITH CHECK ADD  CONSTRAINT [FK_fusiles_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[fusiles] CHECK CONSTRAINT [FK_fusiles_operaciones]
GO
/****** Object:  ForeignKey [FK_firmas_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[firmas]  WITH CHECK ADD  CONSTRAINT [FK_firmas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[firmas] CHECK CONSTRAINT [FK_firmas_operaciones]
GO
/****** Object:  ForeignKey [FK_equipos_especiales_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[equipos_especiales]  WITH CHECK ADD  CONSTRAINT [FK_equipos_especiales_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[equipos_especiales] CHECK CONSTRAINT [FK_equipos_especiales_operaciones]
GO
/****** Object:  ForeignKey [FK_ejecucion_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[ejecucion]  WITH CHECK ADD  CONSTRAINT [FK_ejecucion_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ejecucion] CHECK CONSTRAINT [FK_ejecucion_operaciones]
GO
/****** Object:  ForeignKey [FK_coordenadas_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[coordenadas]  WITH CHECK ADD  CONSTRAINT [FK_coordenadas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[coordenadas] CHECK CONSTRAINT [FK_coordenadas_operaciones]
GO
/****** Object:  ForeignKey [FK_comunicaciones_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[comunicaciones]  WITH CHECK ADD  CONSTRAINT [FK_comunicaciones_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comunicaciones] CHECK CONSTRAINT [FK_comunicaciones_operaciones]
GO
/****** Object:  ForeignKey [FK_anexos_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[anexos]  WITH CHECK ADD  CONSTRAINT [FK_anexos_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[anexos] CHECK CONSTRAINT [FK_anexos_operaciones]
GO
/****** Object:  ForeignKey [FK_ametralladoras_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[ametralladoras]  WITH CHECK ADD  CONSTRAINT [FK_ametralladoras_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ametralladoras] CHECK CONSTRAINT [FK_ametralladoras_operaciones]
GO
/****** Object:  ForeignKey [FK_abastecimientos_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[abastecimientos]  WITH CHECK ADD  CONSTRAINT [FK_abastecimientos_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[abastecimientos] CHECK CONSTRAINT [FK_abastecimientos_operaciones]
GO
/****** Object:  ForeignKey [FK_morteros_operaciones]    Script Date: 07/03/2012 16:20:23 ******/
ALTER TABLE [dbo].[morteros]  WITH CHECK ADD  CONSTRAINT [FK_morteros_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[morteros] CHECK CONSTRAINT [FK_morteros_operaciones]
GO
/****** Object:  ForeignKey [FK_lanzagranadas_operaciones]    Script Date: 07/03/2012 16:20:24 ******/
ALTER TABLE [dbo].[lanzagranadas]  WITH CHECK ADD  CONSTRAINT [FK_lanzagranadas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[lanzagranadas] CHECK CONSTRAINT [FK_lanzagranadas_operaciones]
GO
