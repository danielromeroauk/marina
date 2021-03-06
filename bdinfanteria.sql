USE [bdinfanteria]
GO
/****** Object:  Table [dbo].[operaciones]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[operaciones](
	[operacion] [varchar](20) NOT NULL,
	[nombre] [varchar](300) NULL,
	[procedimiento] [varchar](300) NULL,
	[lugar] [varchar](300) NULL,
	[fecha] [date] NULL,
	[de] [varchar](300) NULL,
	[acc] [varchar](300) NULL,
	[indicativo] [varchar](300) NULL,
	[referencias] [text] NULL,
 CONSTRAINT [PK_operaciones] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inteligencias]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inteligencias](
	[codigo] [varchar](20) NOT NULL,
	[latitud] [numeric](9, 6) NULL,
	[longitud] [numeric](9, 6) NULL,
	[nombre_lugar] [varchar](300) NULL,
	[blanco] [varchar](300) NULL,
	[fecha_hechos] [date] NULL,
	[actividades] [varchar](300) NULL,
	[anotaciones] [text] NULL,
 CONSTRAINT [PK_inteligencias] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [varchar](20) NOT NULL,
	[nombre] [varchar](300) NULL,
	[clave] [varchar](40) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[usuarios] ([id], [nombre], [clave]) VALUES (N'arauca', N'Arauca', N'5j+y°LTWMÂFæ9T(«')
/****** Object:  Table [dbo].[toe]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[toe](
	[operacion] [varchar](20) NOT NULL,
	[oficiales] [numeric](9, 0) NULL,
	[suboficiales] [numeric](9, 0) NULL,
	[imp] [numeric](9, 0) NULL,
	[imr] [numeric](9, 0) NULL,
	[civiles] [numeric](9, 0) NULL,
	[agregaciones] [text] NULL,
	[segregaciones] [text] NULL,
 CONSTRAINT [PK_toe] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[situacion]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[situacion](
	[operacion] [varchar](20) NOT NULL,
	[detalle] [text] NULL,
	[enemigo] [text] NULL,
	[propias_tropas] [text] NULL,
	[agregaciones] [text] NULL,
	[segregaciones] [text] NULL,
 CONSTRAINT [PK_situacion] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[servicios_combate]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[servicios_combate](
	[operacion] [varchar](20) NOT NULL,
	[clase1] [text] NULL,
	[clase2] [text] NULL,
	[clase3] [text] NULL,
	[clase4] [text] NULL,
	[clase5] [text] NULL,
	[clase6] [text] NULL,
	[evacuaciones_medicas] [text] NULL,
 CONSTRAINT [PK_servicios_combate] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personal]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personal](
	[operacion] [varchar](20) NOT NULL,
	[detalle] [text] NULL,
 CONSTRAINT [PK_personal] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[granadas]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[granadas](
	[operacion] [varchar](20) NOT NULL,
	[mano] [numeric](9, 0) NULL,
	[humo] [numeric](9, 0) NULL,
	[lacrimogena] [numeric](9, 0) NULL,
	[otras_granadas] [text] NULL,
 CONSTRAINT [PK_granadas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fusiles]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fusiles](
	[operacion] [varchar](20) NOT NULL,
	[galil_ar] [numeric](9, 0) NULL,
	[galil_ice] [numeric](9, 0) NULL,
	[m16_a2] [numeric](9, 0) NULL,
	[m16_m4] [numeric](9, 0) NULL,
	[m16_a203] [numeric](9, 0) NULL,
	[otros_fusiles] [text] NULL,
 CONSTRAINT [PK_fusiles] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[firmas]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[firmas](
	[operacion] [varchar](20) NOT NULL,
	[autoriza] [varchar](300) NULL,
	[autentica] [varchar](300) NULL,
	[recibe] [varchar](300) NULL,
	[distribucion] [text] NULL,
 CONSTRAINT [PK_firmas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[equipos_especiales]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[equipos_especiales](
	[operacion] [varchar](20) NOT NULL,
	[visor_nocturno] [numeric](9, 0) NULL,
	[binoculares] [numeric](9, 0) NULL,
	[camara_termica] [numeric](9, 0) NULL,
	[flasmers] [numeric](9, 0) NULL,
	[kit_orientacion_nocturno] [numeric](9, 0) NULL,
	[otros_equipos] [text] NULL,
 CONSTRAINT [PK_equipos_especiales] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ejecucion]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ejecucion](
	[operacion] [varchar](20) NOT NULL,
	[intencion_comandante] [text] NULL,
	[concepto_operacion] [text] NULL,
	[maniobra] [text] NULL,
	[fuegos] [text] NULL,
	[tareas_maniobra] [text] NULL,
	[tareas_combate] [text] NULL,
	[instrucciones_coordinacion] [text] NULL,
	[instrucciones_juridicas] [text] NULL,
	[uso_fuerza_autorizada] [text] NULL,
 CONSTRAINT [PK_ejecucion] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[coordenadas]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[coordenadas](
	[operacion] [varchar](20) NOT NULL,
	[latitud1] [numeric](9, 6) NULL,
	[longitud1] [numeric](9, 6) NULL,
	[latitud3] [numeric](9, 6) NULL,
	[longitud3] [numeric](9, 6) NULL,
 CONSTRAINT [PK_coordenadas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comunicaciones]    Script Date: 08/10/2012 01:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comunicaciones](
	[operacion] [varchar](20) NOT NULL,
	[vhf_7330_cant] [numeric](9, 0) NULL,
	[vhf_7330_frec] [varchar](300) NULL,
	[vhf_710_cant] [numeric](9, 0) NULL,
	[vhf_710_frec] [varchar](300) NULL,
	[vhf_930_cant] [numeric](9, 0) NULL,
	[vhf_930_frec] [varchar](300) NULL,
	[vhf_aereo_cant] [numeric](9, 0) NULL,
	[vhf_aereo_frec] [varchar](300) NULL,
	[vhf_escaner] [numeric](9, 0) NULL,
	[hf_6020_cant] [numeric](9, 0) NULL,
	[hf_6020_frec] [varchar](300) NULL,
	[hf_escaner] [numeric](9, 0) NULL,
	[uhf_xts4250_cant] [numeric](9, 0) NULL,
	[uhf_xts4250_frec] [varchar](300) NULL,
	[uhf_xtr3000_cant] [numeric](9, 0) NULL,
	[uhf_xtr3000_frec] [varchar](300) NULL,
	[uhf_escaner] [numeric](9, 0) NULL,
	[avantel] [varchar](300) NULL,
	[celular] [varchar](300) NULL,
	[satelital] [varchar](300) NULL,
	[clave] [varchar](300) NULL,
	[indicativos] [text] NULL,
 CONSTRAINT [PK_comunicaciones] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[CambiarClave]    Script Date: 08/10/2012 01:28:53 ******/
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
/****** Object:  Table [dbo].[anexos]    Script Date: 08/10/2012 01:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[anexos](
	[operacion] [varchar](20) NOT NULL,
	[nombre] [varchar](300) NULL,
	[ruta] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ametralladoras]    Script Date: 08/10/2012 01:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ametralladoras](
	[operacion] [varchar](20) NOT NULL,
	[m60_estandar] [numeric](9, 0) NULL,
	[m60_e4] [numeric](9, 0) NULL,
	[m249] [numeric](9, 0) NULL,
	[ss77] [numeric](9, 0) NULL,
	[punto50] [numeric](9, 0) NULL,
	[otras_ametralladoras] [text] NULL,
 CONSTRAINT [PK_ametralladoras] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[morteros]    Script Date: 08/10/2012 01:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[morteros](
	[operacion] [varchar](20) NOT NULL,
	[mc_c370_60mm] [numeric](9, 0) NULL,
	[mc_575_60mm] [numeric](9, 0) NULL,
	[mc_fms_60mm] [numeric](9, 0) NULL,
	[m_brandt_60mm] [numeric](9, 0) NULL,
	[otros_morteros] [text] NULL,
 CONSTRAINT [PK_morteros] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[mision]    Script Date: 08/10/2012 01:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mision](
	[operacion] [varchar](20) NOT NULL,
	[detalle] [text] NULL,
 CONSTRAINT [PK_mision] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 08/10/2012 01:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Login]
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
/****** Object:  Table [dbo].[lanzagranadas]    Script Date: 08/10/2012 01:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lanzagranadas](
	[operacion] [varchar](20) NOT NULL,
	[mgl] [numeric](9, 0) NULL,
	[mk] [numeric](9, 0) NULL,
	[m79] [numeric](9, 0) NULL,
	[otros_lanzagranadas] [text] NULL,
 CONSTRAINT [PK_lanzagranadas] PRIMARY KEY CLUSTERED 
(
	[operacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_toe_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[toe]  WITH CHECK ADD  CONSTRAINT [FK_toe_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[toe] CHECK CONSTRAINT [FK_toe_operaciones]
GO
/****** Object:  ForeignKey [FK_situacion_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[situacion]  WITH CHECK ADD  CONSTRAINT [FK_situacion_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[situacion] CHECK CONSTRAINT [FK_situacion_operaciones]
GO
/****** Object:  ForeignKey [FK_servicios_combate_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[servicios_combate]  WITH CHECK ADD  CONSTRAINT [FK_servicios_combate_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[servicios_combate] CHECK CONSTRAINT [FK_servicios_combate_operaciones]
GO
/****** Object:  ForeignKey [FK_personal_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[personal]  WITH CHECK ADD  CONSTRAINT [FK_personal_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[personal] CHECK CONSTRAINT [FK_personal_operaciones]
GO
/****** Object:  ForeignKey [FK_granadas_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[granadas]  WITH CHECK ADD  CONSTRAINT [FK_granadas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[granadas] CHECK CONSTRAINT [FK_granadas_operaciones]
GO
/****** Object:  ForeignKey [FK_fusiles_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[fusiles]  WITH CHECK ADD  CONSTRAINT [FK_fusiles_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[fusiles] CHECK CONSTRAINT [FK_fusiles_operaciones]
GO
/****** Object:  ForeignKey [FK_firmas_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[firmas]  WITH CHECK ADD  CONSTRAINT [FK_firmas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[firmas] CHECK CONSTRAINT [FK_firmas_operaciones]
GO
/****** Object:  ForeignKey [FK_equipos_especiales_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[equipos_especiales]  WITH CHECK ADD  CONSTRAINT [FK_equipos_especiales_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[equipos_especiales] CHECK CONSTRAINT [FK_equipos_especiales_operaciones]
GO
/****** Object:  ForeignKey [FK_ejecucion_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[ejecucion]  WITH CHECK ADD  CONSTRAINT [FK_ejecucion_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ejecucion] CHECK CONSTRAINT [FK_ejecucion_operaciones]
GO
/****** Object:  ForeignKey [FK_coordenadas_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[coordenadas]  WITH CHECK ADD  CONSTRAINT [FK_coordenadas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[coordenadas] CHECK CONSTRAINT [FK_coordenadas_operaciones]
GO
/****** Object:  ForeignKey [FK_comunicaciones_operaciones]    Script Date: 08/10/2012 01:28:51 ******/
ALTER TABLE [dbo].[comunicaciones]  WITH CHECK ADD  CONSTRAINT [FK_comunicaciones_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comunicaciones] CHECK CONSTRAINT [FK_comunicaciones_operaciones]
GO
/****** Object:  ForeignKey [FK_anexos_operaciones]    Script Date: 08/10/2012 01:28:53 ******/
ALTER TABLE [dbo].[anexos]  WITH CHECK ADD  CONSTRAINT [FK_anexos_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[anexos] CHECK CONSTRAINT [FK_anexos_operaciones]
GO
/****** Object:  ForeignKey [FK_ametralladoras_operaciones]    Script Date: 08/10/2012 01:28:53 ******/
ALTER TABLE [dbo].[ametralladoras]  WITH CHECK ADD  CONSTRAINT [FK_ametralladoras_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ametralladoras] CHECK CONSTRAINT [FK_ametralladoras_operaciones]
GO
/****** Object:  ForeignKey [FK_morteros_operaciones]    Script Date: 08/10/2012 01:28:53 ******/
ALTER TABLE [dbo].[morteros]  WITH CHECK ADD  CONSTRAINT [FK_morteros_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[morteros] CHECK CONSTRAINT [FK_morteros_operaciones]
GO
/****** Object:  ForeignKey [FK_mision_operaciones]    Script Date: 08/10/2012 01:28:53 ******/
ALTER TABLE [dbo].[mision]  WITH CHECK ADD  CONSTRAINT [FK_mision_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[mision] CHECK CONSTRAINT [FK_mision_operaciones]
GO
/****** Object:  ForeignKey [FK_lanzagranadas_operaciones]    Script Date: 08/10/2012 01:28:53 ******/
ALTER TABLE [dbo].[lanzagranadas]  WITH CHECK ADD  CONSTRAINT [FK_lanzagranadas_operaciones] FOREIGN KEY([operacion])
REFERENCES [dbo].[operaciones] ([operacion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[lanzagranadas] CHECK CONSTRAINT [FK_lanzagranadas_operaciones]
GO
