Marina
===============
Con SQLServer 2008 como sistema manejador de base de datos, Marina recupera y organiza la información de una orden fragmentaria de la Infantería de Marina Nº 52 en Arauca (Arauca - Colombia).
Ubica cada campo de cada una de las tablas de la Base de datos bdmarina en su correspondiente marcador creado previamente en una plantilla de Microsoft Office Word.

-------
bdinfanteria: Sólo generalidades, no es un script válido.
-------
Tabla: operaciones
operacion varchar(20) key
nombre varchar(300)
procedimiento varchar(300)
lugar varchar(300)
fecha date
de varchar(300)
acc varchar(300)
indicativo varchar(300)
referencias text

Tabla: situacion
operacion varchar(20) key, foreign key
detalle text
enemigo text
propias_tropas text
agregaciones text
segregaciones text

Tabla: mision
operacion varchar(20) key, foreign key
detalle text

Tabla: toe
operacion varchar(20) key, foreign key
oficiales int
suboficiales int
imp int
imr int
civiles int
agregaciones text
segregaciones text

Tabla: ejecucion
operacion varchar(20) key, foreign key
intencion_comandante text
concepto_operacion text
maniobra text
fuegos text
tareas_maniobra text
tareas_combate text
instrucciones_coordinacion text
instrucciones_juridicas text
uso_fuerza_autorizada text

Tabla: servicios_combate
operacion varchar(20) key, foreign key
clase1 text
clase2 text
clase3 text
clase4 text
clase5 text
clase6 text
evacuaciones_medicas text

Tabla: ametralladoras
operacion varchar(20) key, foreign key
m60_estandar int
m60_e4 int
m249 int
ss77 int
punto50 int
otras_ametralladoras text

Tabla: fusiles
operacion varchar(20) key, foreign key
galil_ar int
galil_ice int
m16_a2 int
m16_m4 int
m16_a203 int
otros_fusiles text

Tabla: granadas
operacion varhcar(20) key, foreign key
mano int
humo int
lacrimogena int
otras_granadas text

Tabla: lanzagranadas
operacion varchar(20) key, foreign key
mgl int
mk int
m79 int
otros_lanzagranadas text

Tabla: morteros
operacion varchar(20) key, foreign key
mc_c370_60mm int
mc_c575_60mm int
mc_fms_60mm int
m_brandt_60mm int
otros_morteros text

Tabla: equipos_especiales
operacion varchar(20) key, foreign key
visor_nocturno int
binoculares int
camara_termica int
flasmers int
kit_orientacion_nocturno int
otros_equipos text

Tabla: comunicaciones
operacion key, foreign key
vhf_7330_cant int
vhf_7330_frec varchar(300)
vhf_710_cant int
vhf_710_frec varchar(300)
vhf_930_cant int
vhf_930_frec varchar(300)
vhf_aereo_cant int
vhf_aereo_frec varchar(300)
vhf_escaner int
hf_6020_cant int
hf_6020_frec varchar(300)
hf_escaner int
uhf_xts4250_cant int
uhf_xts4250_frec varchar(300)
uhf_xtr3000_cant int
uhf_xtr3000_frec varchar(300)
uhf_escaner int
avantel varchar(300)
celular varchar(300)
satelital varchar(300)
clave varchar(300)
indicativos text

Tabla: personal
operacion varchar(20) key, foreign key
detalle text

Tabla: coordenadas
operacion varchar(20) key, foreign key
latitud1 decimal
longitud1 decimal
latitud3 decimal
longitud3 decimal

Tabla: anexos
operacion varchar(20) foreign key
nombre varchar(300)
ruta text

Tabla: firmas
operacion varchar(20) key, foreign key
autoriza varchar(300)
autentica varchar(300)
recibe varchar(300)
distribucion text

Tabla: usuarios
id varchar(20)
nombre varchar(300)
clave varchar(40) cifrada con SHA1

Tabla: inteligencias
codigo varchar(20) key
latitud decimal
longitud decimal
nombre_lugar varchar(300)
blanco varchar(300)
fecha_hechos date
actividades varchar(300)
anotaciones text