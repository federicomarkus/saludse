drop database SaludSe;
create database SaludSe;
use SaludSe;

/* SECTOR PRODUCTOS */ 
create table TipoProducto(
idTipoProducto int auto_increment,
descripcion varchar(50),
estado boolean,/*1=DISPONIBLE*/
constraint PK_tipoProducto primary key (idTipoProducto)
)ENGINE=INNODB;

/* SECTOR PRODUCTOS */ 
create table Productos(
idProducto int auto_increment,
nombre varchar(50),
marca varchar(50),
idTipoProducto int,
CantMedida float,
TipoMedida varchar(10),
stock int,
puntoPedido int,
calificacion int,
estado boolean,
constraint PK_productos primary key (idProducto),
constraint FK_productos1 foreign key (idTipoProducto) references TipoProducto(idTipoProducto)
)ENGINE=INNODB;

/* SECTOR ELABORACION */ 
create table Menu(   		/* MENUS YA PREPARADOS QUE SE VENDEN (tienen comida y bebida) */
idMenu int auto_increment,
nombre varchar(50),
empaquetamiento int,
/* precio float, */
caducidad int,
/* puntoP int, */
estado varchar(50),
constraint PK_Menu primary key (idMenu),
constraint FK_Menu foreign key (empaquetamiento) references Productos (idProducto)
)ENGINE=InnoDB;

/* SECTOR PRODUCTOS */ 
create table Proveedores(
idProveedor int auto_increment,
nombre varchar(50),
direccion varchar(50),
telefono varchar(20),
mail varchar(20),
contacto varchar(30),
calificacion int,
demoraAproximada int,
estado boolean,
constraint PK_proveedores primary key (idProveedor)
)ENGINE=INNODB;


/* SECTOR PRODUCTOS */ 
create table ProvProd(
idProveedor int,
idProducto int,
precio float,
constraint PK_provProd primary key (idProveedor,idProducto),
constraint FK_provProd1 foreign key (idProveedor) references Proveedores(idProveedor),
constraint FK_provProd2 foreign key (idProducto) references Productos(idProducto)
)ENGINE=INNODB;

/* SECTOR PRODUCTOS */ 
create table Orden(
idOrden int auto_increment,
idProveedor int,
fecha date,
prioridad boolean,/*1=URGENCIA; 0=ORDINARIO*/
pagado boolean,
cargado boolean,
constraint PK_orden primary key (idOrden),
constraint FK_orden1 foreign key (idProveedor) references proveedores(idProveedor)
)ENGINE=INNODB;

/* SECTOR PRODUCTOS */ 
create table OrdenProducto(
idOrden int,
idProducto int,
precioUnitario float,
cantidad int,
cargado boolean,
constraint PK_ordenProducto primary key (idOrden,idProducto),
constraint FK_ordenProducto2 foreign key (idProducto) references productos(idProducto),
constraint FK_ordenProducto3 foreign key (idOrden) references Orden(idOrden)
)ENGINE=INNODB;

/* SECTOR PRODUCTOS */ 
create table ComprasP(
idProducto int,
idOrden int,/*------------------AGREGO CAMPO idOrden SACO CAMPO fechaCompra*/
fechaCarga date,/*------------------ MODIFICACION --------------------*/
fechaVencimiento date,
estado boolean,
chequeado boolean,/*------------------AGREGADO------------------------*/
cantidad int,
constraint PK_comprasP primary key (idProducto,fechaCarga,idOrden),
constraint FK_comprasP1 foreign key (idProducto) references Productos(idProducto)
)ENGINE=INNODB;


/*-----NUEVO-----*/
create table verificacion(
fecha date primary key
)ENGINE=INNODB;
insert into verificacion values("2000/01/01");

/* SECTOR ADMINISTRATIVO */ /*se unifico con personal y personas*/
create table Personas(
idPersona int auto_increment primary key,
dni varchar(30),
nombre varchar(50),
apellido varchar(15),
telefono varchar(30),
direccion varchar(30),
fechaNac date,
nacionalidad varchar(30),
sexo varchar(10)
)Engine=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table Solicitante(
idSolicitante int auto_increment primary key,
idpersona int,
activo boolean, /*AGREGADO*/
pagado boolean, /*AGREGADO*/
constraint fk_Solicitante_b foreign key(idPersona) references Personas(idPersona)
)ENGINE=InnoDB;

/* SECTOR MONETARIO */ 
create table Cliente(
idCliente int auto_increment primary key,
idSolicitante int,
fechInc date,
constraint fk_cliente foreign key (idSolicitante) references Solicitante (idSolicitante)
)Engine=InnoDB;


/* SECTOR VENTAS */ 
create table Sucursales(
idSucursal int auto_increment primary key,
nombre varchar(50),
direccion varchar(50),
telefono varchar(20),
responsable varchar(50),
vigencia boolean,
vigenciaC date,
calificacion int,
idCliente int,
fecha_inauguracion date,
disponible boolean, /* AGREGADO */
constraint fk_sucursal foreign key (idCliente) references Cliente (idCliente)
)Engine=InnoDB;


/* SECTOR VENTAS */ 
create table MenuVenta(
idMenuVenta int auto_increment primary key,
idMenu int, 
idSucursal int,
precioVenta float,
stock int,
puntoPedido int,
constraint FK_MenuVenta1 foreign key (idMenu) references Menu(idMenu),
constraint FK_MenuVenta2 foreign key (idSucursal) references Sucursales(idSucursal)
)Engine=InnoDB;

/* SECTOR VENTAS
create table EmpleadosVentas (
idEmpleado int auto_increment primary key,
idPersona int,
tipoEmp boolean, /* 1=Administrador | 0=Usuario */
/*estado boolean, /* 1=De alta | 0=De baja */
/*constraint fk_empper foreign key(idPersona) references Personas(idPersona)
)Engine=InnoDB; Unificado con Empleados */

/* SECTOR ADMINISTRATIVO */
create table Sectores (
idSector int auto_increment primary key,
sector varchar(30)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */
create table Empleados( /*se unifico con empleadosventas y Empleados*/
idEmpleado int auto_increment primary key,
idPersona int,
idSector int,
cargo varchar(50), /* ----------------/ENTREGAS//AGREGADO (24/10/18)/------------------ */																					  
encargado boolean,
capacitado boolean,
estado boolean, /* 1=De alta | 0=De baja */
constraint fk_Empleados_b foreign key(idPersona) references Personas(idPersona),
constraint fk_Empleados_c foreign key(idSector) references Sectores(idSector)
)Engine=InnoDB;

/* SECTOR VENTAS */ 
create table Usuarios (
idUsuario int auto_increment primary key,
idEmpleado int,
usuario varchar(25),
contraseña varchar(50),
idSucursal int,
administrador boolean, /*0-NO / 1-SI*/
constraint fk_uemp foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;

/* SECTOR VENTAS */ 
create table ClienteVentas (
idClienteVentas int auto_increment primary key,
idPersona int,
tipoCli varchar(10), /* "Delivery" | "Salón" | "Retiro" */
estado boolean, /* 1=De alta | 0=De baja */
constraint fk_cliper foreign key(idPersona) references Personas(idPersona)
)Engine=InnoDB;

/* SECTOR VENTAS */ 
create table PedidosClientes (
idPedido int auto_increment primary key,
idClienteVentas int,
fechaPed date,
horaPed time,
estado varchar(25), /* "ACTIVO" | "CANCELADO" | "ENVIADO" | "ENTREGADO" */ /* ----------------/ENTREGAS//MODIFICADO (24/10/18)/------------------ */
constraint fk_pedcli foreign key(idClienteVentas) references ClienteVentas(idClienteVentas)
)Engine=InnoDB;
/*lowen*/

/* SECTOR VENTAS */ 
create table PedidoMenu (
idPedido int,
idMenuVenta int,
cant int,
observacion varchar(200),
constraint pk_pedmen primary key(idPedido, idMenuVenta),
constraint fk_pmen foreign key(idMenuVenta) references MenuVenta(idMenuVenta),
constraint fk_mped foreign key(idPedido) references PedidosClientes(idPedido)
)Engine=InnoDB;

/* SECTOR VENTAS */ 
create table Envios (
idEnvio int auto_increment primary key,
idPedido int,
direEnvio varchar(40),
fechaEnvio date,
entregado boolean, /*0-NO / 1-SI*/
constraint fk_eped foreign key(idPedido) references PedidosClientes(idPedido)
)Engine=InnoDB;


/* SECTOR VENTAS */ /*Se cambio la fk de idUsuario a idEmpleado*/
create table Ticket (
idTicket int auto_increment primary key,
idPedido int,
idEmpleado int,
fechaPago date,
horaPago time,
monto float,
estado boolean, /*Pagado 1 - Cancelado 0*/
constraint fk_tped foreign key(idPedido) references PedidosClientes(idPedido),
constraint fk_tusu foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;


/* SECTOR VENTAS */ 


/*create table PagosTicket (
idPagosTicket int auto_increment primary key,
idTicket int,
monto float,
fechaRegistro date,
constraint fk_pagtic foreign key(idTicket) references Ticket(idTicket)
)Engine=InnoDB;*/ /* Eliminada */


/* SECTOR ADMINISTRATIVO */
create table Servicios (
idServicio int auto_increment primary key,
nombre varchar(30)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */
create table SucuServicio (
idSucursal int,
idServicio int,
serviciosCumplidos boolean,
constraint pk_LibrosA primary key (idSucursal,idServicio),
constraint fk_SucuServicio_a foreign key(idSucursal) references Sucursales(idSucursal),
constraint fk_SucuServicio_b foreign key(idServicio) references Servicios(idServicio)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */
/*create table Personal (
idPersonal int auto_increment primary key,
nombre varchar(50),
apellido varchar(15),
telefono varchar(30),
direccion varchar(30),
fechaNac date,
dni varchar(30),
nacionalidad varchar(30),
sexo varchar(10),
idSucursal int,
constraint fk_Personal foreign key(idSucursal) references Sucursales(idSucursal)
)Engine=InnoDB;*/ /* Se unifico con Personas */

/* SECTOR ADMINISTRATIVO */
create table Pagos (
idPagos int auto_increment primary key,
monto float,
destinatario varchar(50),
fecha date,
descripcion varchar(80)
)Engine=InnoDB; 

/*lowen*/

/* SECTOR ADMINISTRATIVO */
create table Contrato (
idContrato int auto_increment primary key,
tipoDePago varchar(50),
fecha date,
idSucursal int,
idEmpresa int,
vigencia date,
monto float,
constraint fk_Contrato_a foreign key(idSucursal) references Sucursales(idSucursal)
/*constraint fk_Contrato_b foreign key(idEmpresa) references Empresa(idEmpresa)*/ /* REVISAR - FALTA TABLA EMPRESA :|*/
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */
create table ContratoEmpleado (
idContratoE int auto_increment primary key,
idEmpleado int,
fecha date,
monto float,
vigencia date,
constraint fk_ContratoE_b foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;

/*lowen*/

/* SECTOR ADMINISTRATIVO */

create table Stock (
idStock int auto_increment primary key,
idMenu int,
cantidad int,
idSucursal int,
puntoPedido int,
cargo varchar(50),
constraint fk_Stock_a foreign key(idSucursal) references Sucursales(idSucursal),
constraint fk_Stock_b foreign key(idMenu) references Menu(idMenu)
)Engine=InnoDB;


/* SECTOR ADMINISTRATIVO */
create table Pedido (
idPedido int auto_increment primary key,
idSucursal int,
fecha date,
pedidof boolean,
constraint fk_Pedido_a foreign key(idSucursal) references Sucursales(idSucursal)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */ 
create table PedidosDetalle(
idPedido int, /* CAMBIADO */
idMenu int,
cantidad int,
constraint pk_idPed primary key(idPedido,idMenu), 
constraint fk_PedidosMenu_PedidosSucursales foreign key(idPedido) references Pedido(idPedido), /* CAMBIADO */
constraint fk_PedidosMenu_Menu foreign key(idMenu) references Menu(idMenu) 
)ENGINE=InnoDB;

/* SECTOR ADMINISTRATIVO */
create table PagosSucursal (
idPagosS int auto_increment primary key,
idPagos int,
idSucursal int,
constraint fk_PagosSucursal_a foreign key(idSucursal) references Sucursales(idSucursal),
constraint fk_PagosSucursal_b foreign key(idPagos) references Pagos(idPagos)
)Engine=InnoDB;


/* SECTOR ADMINISTRATIVO */ 
create table Ventas (/*ESTA TABLA LA USAMOS PARA REGISTRAR LA ENTRADA Y SALIDA DEL DINERO. DEBERIA COINCIDIR CON ALGUNA TABLA DEL SECTOR VENTAS PERO DAUJAN NOS DIJO QUE NO HAY NINGUNA TABLA CON ESTE NOMBRE EN EL SECTOR VENTAS*/
idVenta int auto_increment primary key,
fecha date,
idEmpleado int,
constraint fk_Ventas foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */ 
create table ProductoVenta (
idVenta int primary key,
idMenu int,
idSucursal int,
constraint fk_ProductoVenta_a foreign key(idVenta) references Ventas(idVenta),
constraint fk_ProductoVenta_b foreign key(idMenu) references Menu(idMenu)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */ 
/*create table Informe (/*/////////////////////////ESTE INFORME DEBERIA VENIR DEL GRUPO DE VILLAVERDE, SIRVE PARA VERIFICAR SI LOS EMPLEADOS CUMPLEN CON LOS ESTANDARES DE LA FRANQUICIA//////////////  */
/*idInforme int auto_increment primary key,
descripcion varchar(50),
idEmpleado int,
constraint fk_Informe foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;*/

/* SECTOR ADMINISTRATIVO */ 
create table Capacitacion (
idCapacitacion int auto_increment primary key,
tipo varchar(50),
idSector int,
constraint fk_Capacitacion foreign key(idSector) references Sectores(idSector)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */ 
create table Curso (
idCurso int auto_increment primary key,
idCapacitacion int,
nombre varchar(50),
descripcion varchar(50),
duracion int,
hora int,
tipo varchar(30),
fecha date,
disponible boolean,
constraint fk_Cursos foreign key(idCapacitacion) references Capacitacion(idCapacitacion)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */ 
create table Ausencia (
idAusencia int auto_increment primary key,
idEmpleado int,
fecha  date, 
descripcion varchar(50),
duracion int,
constraint fk_Ausencia foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;

/*lowen*/

/* SECTOR ADMINISTRATIVO */ 
create table CursoPersonal (
idCurso int,
idPersona int,
finalizado  boolean, 
fechaDeInicio date,
constraint pk_LibrosA primary key (idPersona,idCurso),
constraint fk_CursoPersonal_a foreign key(idCurso) references Curso(idCurso),
constraint fk_CursoPersonal_b foreign key(idPersona) references Personas(idPersona)
)Engine=InnoDB;

/* SECTOR ADMINISTRATIVO */ 
create table CursoEmpleados (
idCurso int,
idEmpleado int,
finalizado  boolean, 
calificacion int,
fechaDeInicio date,
hora time,
constraint pk_LibrosA primary key (idCurso,idEmpleado),
constraint fk_CursoEmpleados_a foreign key(idCurso) references Curso(idCurso),
constraint fk_CursoEmpleados_b foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;

/* SECTOR RRHH */ 
create table Induccion(
idInduc int,
idEmpleado int,
realizado boolean,
calificacion int,
fecha date,
hora time,
constraint pk_induccion primary key (idInduc),
constraint fk_induccion foreign key(idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;


/* SECTOR RRHH */ 
create table Inspector(
idInspector int,
idPersona int, /* Se cambio los datos basicos por fk en persona */
disponible boolean, /*AGREGADO */
constraint pk_inspector primary key (idInspector),
constraint fk_inspector_b foreign key(idPersona) references Personas(idPersona)
)Engine=InnoDB;

/* SECTOR RRHH */ 
create table Inspeccion(
idInspeccion int,
idInspector int,
idSucursal int,
fecha date,
hora time,
asunto varchar(100), 
constraint pk_inspeccion primary key (idInspeccion),
constraint fk_inspeccion foreign key(idSucursal) references Sucursales(idSucursal),
constraint fk_inspeccion2 foreign key (idInspector) references Inspector(idInspector)
)Engine=InnoDB;

/* SECTOR RRHH */ 
create table CursoSucursal(
idSucursal int,
idCurso int,
constraint pk_cursoSucursal primary key(idSucursal,idCurso),
constraint fk_cursoSucursal foreign key(idSucursal) references Sucursales(idSucursal),
constraint fk_cursoSucursal2 foreign key(idCurso) references Curso(idCurso)
)Engine=InnoDB;  

/* SECTOR RRHH */ 
create table Capacitador(
idCap int,
idPersona int, /* Se cambio los datos basicos por fk en persona */
disponible boolean, /* AGREGADO */
constraint pk_capacitador primary key (idCap),
constraint fk_capicitador_b foreign key(idPersona) references Personas(idPersona)
)Engine=InnoDB;

/* SECTOR RRHH */ 
create table CursoCapacitador(
idCap int,
idCurso int,
fecha date,
hora time,
vigencia boolean,
constraint pk_cursoCapacitador primary key(idCap,idCurso),
constraint fk_cursoCapacitador foreign key(idCap) references Capacitador(idCap),
constraint fk_cursoCapacitador2 foreign key(idCurso) references Curso(idCurso)
)Engine=InnoDB;

/* SECTOR RRHH */ 
create table Normativa(
idNorma int,
desNorma varchar(200),
disponible boolean, /* AGREGADO */
constraint pk_normativa primary key(idNorma)
)Engine=InnoDB;

/* SECTOR MONETARIO */ 
create table movimientos( /* NUEVA */
idMov int auto_increment,
monto float,
fecha date,
tipo boolean, /* 1 entrada 0 salida*/
constraint PK_movimientos primary key(idMov)
)ENGINE=INNODB;

/* SECTOR MONETARIO */ 
create table cheque(
idCheque int auto_increment,
idMov int,
idProveedor int,
constraint PK_Cheque primary key(idCheque),
constraint FK_Chque_Movimientos foreign key (idMov) references movimientos (idMov),
constraint FK_Chque_Proveedores foreign key (idProveedor) references Proveedores (idProveedor) 
)ENGINE=INNODB;
/*lowen*/
/*BORRADO TABLA COBRO */

/* SECTOR MONETARIO */ 
create table recibo( /* NUEVO */
idRecibo int auto_increment,
idMov int, 
emisorPago int,
solicitante boolean,
constraint PK_Recibo primary key(idRecibo),


constraint FK_Movimiento foreign key (idMov) references movimientos (idMov)
)ENGINE=INNODB;
/* SECTOR MONETARIO */ 
create table Balance(
idBalance int auto_increment,
periodo varchar(30), /* el tiempo del cual se hace el analisis*/ 
fecha date, /* fecha de emision del balance*/
porcentaje float,
constraint PK_Balance primary key(idBalance)
)Engine=InnoDB;

/* SECTOR ADMINISTRACION */ 
create table ContratoMonetario(
idContratoMonetario int auto_increment primary key,
idSolicitante int,
costo int,
fecha date,
activo boolean, /* AGREGADO */
constraint fk_contrato_monetario foreign key (idSolicitante) references Solicitante (idSolicitante)
)Engine=InnoDB;

/* SECTOR ADMINISTRACION */ 
create table Desvinculacion(
idDesvin int auto_increment primary key,
idCliente int,
fecha date,
constraint fk_desvinculacion foreign key (idCliente) references Cliente (idCliente)
)Engine=InnoDB;

/* SECTOR ELABORACION */ 
create table Recetas(        /* LAS ELEMENTOS DEL MENU QUE TAMBIEN TIENEN SUS PROPIOS ELEMENTOS (hamburguesa tiene tomate, queso, medallon de carne) */
idReceta int auto_increment,
nombre varchar(50),
descripcion varchar(200),
estado varchar(50),
constraint PK_Recetas primary key (idReceta)
)ENGINE=InnoDB;	

/* SECTOR ELABORACION */ 
create table MenuProductos(   /* LOS PRODUCTOS QUE CONFORMAN EL MENU. PUEDEN SER RECETAS (hamburguesa) o PRODUCTOS (bebida) */
idMenuProductos int auto_increment,
idMenu int,
idElemento int, /* FOREIGN KEY DE RECETAS O PRODUCTOS */
cantidad int,
tipo varchar(50),
constraint PK_MenuProductos primary key (idMenuProductos),
constraint FK_MenuProductos foreign key (idMenu) references Menu (idMenu)

)ENGINE=InnoDB;

/* SECTOR ELABORACION */ 
create table RecetasProductos( 
idRecetasProductos int auto_increment,
idReceta int,
idProducto int,
cantidad int,
constraint PK_RecetasProductos primary key (idRecetasProductos),
constraint FK_RecetasProductos foreign key (idReceta) references Recetas (idReceta)
)ENGINE=InnoDB;

/* SECTOR ELABORACION */ 
create table SolicitudesProducto(
idSolicitud int auto_increment,
motivo varchar(100),
fecha Date,
fechaEntrega Date,
estado varchar(50),
constraint PK_Solicitudes primary key (idSolicitud)
)ENGINE=InnoDB;

/* SECTOR ELABORACION */ 
create table DetalleSolicitudProductos (
idSolicitud int,
idProducto int,
cantidad int,
constraint PK_DetalleSolicitud primary key (idSolicitud, idProducto),
constraint FK_DetalleSolicitud foreign key (idSolicitud) references SolicitudesProducto (idSolicitud),
constraint FK_DetalleSolicitud1 foreign key (idProducto) references Productos (idProducto)
)ENGINE=InnoDB;

/* SECTOR ENTREGAS */ 
/*create table ComprobantesPedidos(
idTicket int auto_increment primary key,
idPedido int,
idEmpleado int,
fechaPago date,
horaPago time,
constraint FK_ComprobantesPedidos foreign key (idPedido) references PedidosClientes (idPedido),
constraint FK_ComprobantesPedidos1 foreign key (idEmpleado) references Empleados(idEmpleado)
)Engine=InnoDB;*/

/* SECTOR ENTREGAS */ 
create table Vehiculo( /*CAMBIADA*/
idVehi int auto_increment primary key,
marca varchar(100),
modelo varchar(100),
patente varchar(30),
tipovehi varchar(50),
fechaIng date,
activa boolean, /* SI ESTA HACIENDO UN REPARTO O NO */
disponibilidad boolean, /*1=DISPONIBLE  0=NO DISPONIBLE*/
/* ----------------/ENTREGAS//AGREGADO (24/10/18)/------------------ */
activo boolean /* DELETEAR VEHICULO --> 1 = NO DELETEADO | 0 = DELETEADO */
)Engine=InnoDB;

/* SECTOR ENTREGAS */ 
create table Mantenimiento(
idMante int auto_increment primary key,
idVehi int, /*CAMBIADO*/
fechaEgreso date, /*AGREGADO*/
fechaIngreso date, /*AGREGADO*/
motivo varchar(40), /* Mantenimiento de rutina, accidente */
/* ----------------/ENTREGAS//AGREGADO (24/10/18)/------------------ */
activo boolean, /* deletear --> 1 = no deleteado | 0 = deleteado */
constraint FK_Mantenimiento foreign key (idVehi) references Vehiculo (idVehi) /* AGREGADO */
)Engine=InnoDB;

/* SECTOR ENTREGAS */ 
create table VehiculoEnvios( /* ----------------/ENTREGAS//MODIFICADO (24/10/18)/------------------ */
idMotoEnvio int auto_increment primary key,
idVehi int, /* CAMBIADO */
idEnvio int,
/* ----------------/ENTREGAS//AGREGADO (24/10/18)/------------------ */
activo boolean, /* deletear --> 1 = no deleteado | 0 = deleteado */
constraint FK_MotosEnvios1 foreign key (idVehi) references Vehiculo (idVehi), /* CAMBIADO */
constraint FK_MotosEnvios2 foreign key (idEnvio) references Envios (idEnvio)
)Engine=InnoDB;

/* SECTOR ENTREGAS */ 
create table PagosCorrectoEntrega(
idPagoCorrectoE int auto_increment primary key,
idPedido int,
idempleado int,/* ----------------/ENTREGAS//AGREGADO (24/10/18)/------------------ */
monto int,
fechaPago date, /*SERIA LA FECHA EN QUE SE ENVIO OSEA LA ACTUAL*/
constraint FK_PagosCorrectoEntrega foreign key (idPedido) references PedidosClientes (idPedido)
)Engine=InnoDB;

/* SECTOR ENTREGAS */ 
create table PagosIncorrectoEntrega(
idPagoIncorrectoE int auto_increment primary key,
idPedido int,
idempleado int,/* ----------------/ENTREGAS//AGREGADO (24/10/18)/------------------ */
fechaPago date,/*SERIA LA FECHA EN QUE SE ENVIO OSEA LA ACTUAL*/
pagoTotal int,
pagoEntregado int,
pagoFaltante int,		 
constraint FK_PagosIncorrectoEntrega foreign key (idPedido) references PedidosClientes (idPedido),
constraint fk_pagosincorrectoentrega2 foreign key (idempleado) references empleados (idempleado)
)Engine=InnoDB;

/* SECTOR ENTREGAS */ 
create table Turno(
idTurno int primary key,
turno varchar(20),
horainicio time,
horafin time
)Engine=InnoDB;

/* SECTOR ENTREGAS */ 
create table EmpleadoTurno(
idEmpTur int auto_increment primary key,
idEmpleado int,
idTurno int,
fecha date,
constraint FK_empleadoTurno foreign key (idEmpleado) references Empleados (idEmpleado),
constraint FK_empleadoTurno1 foreign key (idTurno) references Turno (idTurno)
)Engine=InnoDB;

/* SECTOR PEDIDO Y DISTRIBUCION */ 
create table PedidosSucursales(
idPedSucu int auto_increment, /* CAMBIADO */
idPedido int, /* AGREGADO */
idSucursal int,
fechaP date,
fechaE date,
estado varchar(30),
emergencia boolean,
extraordinario boolean,
constraint pk_idPed primary key(idPedSucu),
constraint fk_PedidosSucursales_Sucursales foreign key(idSucursal) references Sucursales(idSucursal),
constraint fk_PedidosSucursales_Pedido foreign key(idPedido) references Pedido(idPedido) /* AGREGADO */
)ENGINE=InnoDB;

/* SECTOR PEDIDO Y DISTRIBUCION */ 
/* BORRADO
 create table PedidosE(
idPedE int auto_increment,
idMenu int,
estado varchar(30),
fechaE date,
constraint pk_idPedE primary key (idPedE),
constraint fk_PedidosE_Menu foreign key(idMenu) references Menu(idMenu) 
)ENGINE=InnoDB;*/

/* SECTOR PEDIDO Y DISTRIBUCION */ 
create table Chofer(
idChofer int auto_increment,
nombre varchar(40),
apellido varchar(40),
dni int,
direccion varchar(100),
fechaN date,
telefono int,
constraint pk_idChofer primary key(idChofer)
)ENGINE=InnoDB;

/* SECTOR PEDIDO Y DISTRIBUCION */ 
create table TransporteDistribucion(
idTD int auto_increment,
patente varchar(10),
marca varchar(40),
modelo varchar(40),
constraint pk_idTD primary key(idTD)
)ENGINE=InnoDB;

/* SECTOR PEDIDO Y DISTRIBUCION */ 
create table HojaR(
idH int auto_increment,
idPed int,
idTD int,
idChofer int,
fecha date,
constraint pk_idD primary key(idH),
constraint fk_HojaR_PedidosSucursales foreign key(idPed) references PedidosSucursales(idPedSucu),
constraint fk_HojaR_TransporteDistribucion foreign key(idTD) references TransporteDistribucion(idTD),
constraint fk_HojaR_Chofer foreign key(idChofer) references Chofer(idChofer)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table Documentacion(
idDocumentacion int auto_increment primary key,
descripcion varchar(200)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table SolDocu(
idSolDoc int auto_increment primary key,
idSolicitante int,
idDocumentacion int,
constraint fk_sol_docu foreign key (idSolicitante) references Solicitante (idSolicitante),
constraint fk_sol_docu1 foreign key (idDocumentacion) references Documentacion (idDocumentacion)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table Averiguacion(
idAveriguacion int auto_increment primary key,
idSolicitante int,
gastosAdministrativos int,
resultado boolean, /* resultado para ver si tiene todos los documentos */
constraint fk_averiguacion foreign key (idSolicitante) references Solicitante (idSolicitante)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table Controles(
idControles int auto_increment primary key,
idCliente int,
controlPersonal boolean,
controlEspacio boolean,
constraint fk_controles foreign key (idCliente) references Cliente (idCliente)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table ContratoFranquicias(
idContratoFranquicias int auto_increment primary key,
idSolicitante int,
pbase int,
monto int,
fecha date,
constraint fk_contrato foreign key (idSolicitante) references Solicitante (idSolicitante)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table Auditoria(
idAuditoria int auto_increment primary key,
idCliente int,
descripcion varchar(40),
constraint fk_auditoria foreign key (idCliente) references Cliente (idCliente)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table AuditoriaEmpleados(
idAuditoriaEmpleados int auto_increment primary key,
idAuditoria int,
idEmpleado int,
constraint fk_auditoria_empleados foreign key (idAuditoria) references Auditoria (idAuditoria),
constraint fk_auditoria_empleados1 foreign key (idEmpleado) references Empleados (idEmpleado)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table Cuenta(
nroCuenta int auto_increment primary key,
idCliente int,
fechaApertura date,
saldo int,
estado boolean,
constraint fk_cuenta foreign key (idCliente) references Cliente (idCliente)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table EspacioFisico(
idEspacioFisico int auto_increment primary key,
idCliente int,
descripcion varchar(100),
dimensiones boolean,
mobiliarios boolean,
colores boolean,
panelesPublicitarios boolean,
constraint fk_espacio foreign key (idCliente) references Cliente (idCliente)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table ContratoPago(
idContratoPago int auto_increment primary key,
idContratoFranquicias int,
estado boolean,
monto int,
cuotaN int,
constraint fk_contrato_pago foreign key (idContratoFranquicias) references ContratoFranquicias (idContratoFranquicias)
)ENGINE=InnoDB;

/* SECTOR FRANQUICIAS */ 
create table control_marca (
id_control int auto_increment primary key,
idSucursal int,
fecha date,
descripcion varchar(200),
cumplida boolean,
control_marca boolean, /*booleano para verificar si es control de marca o control de espacio fisico*/
constraint fk_control_marca foreign key (idSucursal) references sucursales(idSucursal)
);

/* -------------------------------------------------------------------------------------------------------------------------------------*/
/* -------------------------------------------------------------------------------------------------------------------------------------*/
/* -------------------------------------------------------------------------------------------------------------------------------------*/
/* ------------------------------------------------------------------INSERT-------------------------------------------------------------*/
/* -------------------------------------------------------------------------------------------------------------------------------------*/
/* -------------------------------------------------------------------------------------------------------------------------------------*/
/* -------------------------------------------------------------------------------------------------------------------------------------*/

insert into sectores values
(1, "Elaboracion"),
(2, "Franquicia"),
(3, "Productos"),
(4, "Ventas"),
(5, "Distribucion y Pedido"),
(6, "Adminisitracion"),
(7, "Capacitacion"),
(8, "Entrega"),
(9, "Finanzas"),
(10, "Administrador Sistema");

insert into personas values
(1000,null,"Administrador",null,null,null,null,null,null), /* ADMINISTRADOR */
(1,35456456,"Angelica","Muñiz",1502938408,"Costa rica 3463","1990/08/30","Argentina","Feminino"),/* CLIENTES */
(2,34523346,"Monica","Rodriguez",1523451234,"Paraguay 1423","1985/09/23","Argentina","Femenino"),/* CLIENTES */
(3,34589454,"German","Velasquez",1534564356,"San Blas 1423","1975/09/23","Argentina","Masculino"),/* CLIENTES */
(4,34568977,"Franco","Gutierrez",1535464383,"Bernaldez 1423","1989/09/23","Argentina","Masculino"),/* CLIENTES */
(5,34111111,"Roberto","Atroz",1534534234,"Bahia Blanca 1242","1989/02/14","Argentina","Masculino"),/* REPARTIDOR - (ENTREGAS) */
(6,42555665,"Oscar","Mesa",1578955634,"Camarones 2344","1991/12/30","Argentina","Masculino"),		/* REPARTIDOR - (ENTREGAS) */
(7,38956545,"Daniel","Ortiz",1545645687,"Costa rica 3463","1990/08/30","Argentina","Masculino"),	/* REPARTIDOR - (ENTREGAS) */
(8,29356545,"Juan","Lopez",1534657843,"Bacacay 1242","1989/02/14","Argentina","Masculino"),		/* REPARTIDOR - (ENTREGAS) */
(9,35688998,"Leandro","Monte",1534646807,"Montiel 2344","1991/12/30","Argentina","Masculino"),		/* REPARTIDOR - (ENTREGAS) */
(10,34455454,"Julio","Max",1545678458,"Uruguay 1423","1985/09/23","Argentina","Masculino"),			/* REPARTIDOR - (ENTREGAS) */
(11,35698558,"Matias","Muñoz",1557895737,"Cervantes 1242","1989/02/14","Argentina","Masculino"),	/* REPARTIDOR - (ENTREGAS) */
(12,33565665,"Oscar","Santilla",1535674685,"Marcos Paz 2344","1991/12/30","Argentina","Masculino"),	/* REPARTIDOR - (ENTREGAS) */
(13,21002212,"Fernando","Ramos",1590786743,"Venezuela 3463","1990/08/30","Argentina","Masculino"),	/* REPARTIDOR - (ENTREGAS) */
(14,25655656,"Ignacio","Torres",1596736376,"Lascano 3463","1997/08/30","Argentina","Masculino"),	/* REPARTIDOR - (ENTREGAS) */
(15,35658558,"Anastacia","Bobo",1502938408,"Costa rica 3463","1990/08/30","Argentina","Feminino"),	/* SOLICITANTE */
(16,23654545,"Brian","Capo",1585687453,"Haití 3463","1993/10/30","Argentina","Masculino"),	/* EMPLEADO DE VENTAS */
(17,23562565,"Jose","Perez",1585611153,"Jamaica 256","1993/09/25","Argentina","Masculino"),	/* EMPLEADO DE PRODUCTOS */
(18,33333333,"Raul","Herrera",152458596,"Luxemburgo 150","2000/02/23","Argentina","Masculino"),	/* EMPLEADO DE ELABORACION */
(19,"38940021","Sandra","Gon","42500124","Lope de Vega 5555","1999/06/23","Argentina","Femenino"),
(20,"35369877","Rodrigo","Gomez","44883069","Av. Lope de Vega 7500","1998/07/21","Argentina","Masculino"),
(21,"40976224","Pablo","Goncalves","47620727","Pueyredon 136","1999/11/09","Argentina","Masculino"),
(22,"42339478","Leandro","perez","46542345","lope de vega 3322","12/12/1990", "Argentino","Masculino"), /* SOLICITANTE */
(23,"21758394","oscar","Rodriguez","11356785","Beiro 1723","2018/09/12","Argentino","Masculino"),  /* SOLICITANTE */
(24,25632552,"Pablo","Hernandez",1524568975,"Canada 2052","2000/02/24","Argentina","Masculino"),	/* EMPLEADO DE ADMINISTRACION */

insert into empleados values
(1000,1000,10,"Administrador",1,1,1),
(1,5,8,"Repartidor",0,1,1),
(2,6,8,"Repartidor",0,1,1),
(3,7,8,"Repartidor",0,1,1),
(4,8,8,"Repartidor",0,1,1),
(5,9,8,"Repartidor",0,1,1),
(6,10,8,"Repartidor",0,1,1),
(7,11,8,"Encargado",0,1,1),
(8,12,8,"Encargado",0,1,1),
(9,13,8,"Encargado",0,1,1),
(10,14,8,"Repartidor",0,1,1),
(11,16,4,"Encargado",0,1,1),
(12,17,3,"Encargado",1,1,1),
(13,18,1,"Encargado",1,1,1)
(14,24,6,"Encargado",1,1,1);

insert into usuarios values
(1000,1000,"admin","admin",null,true),
(1,8,"entrega","entrega",null,false),
(2,12,"producto", "producto",null,false),
(3,13,"elaboracion","elaboracion",null,false),
(4,14,"administracion","administracion",null,false);

insert into proveedores values
(1, "Cola-Coca", "Av. Cabildo 678", "4599-8625", "colacoca@contactinfo.com", "Bart Thompson", 3, 50, 1),
(2, "Bepis", "Angel Gallardo 5695", "4568-5512", "contactonfo@bepis.con.ar", "Sebastian Morales", 5, 2, 1),
(3, "Bimbo", "Florida 339", "4124-0215", "bimbo@contactinfo.com", "Cecilia Rodriguez", 10, 21, 1),
(4, "Barraza", "Rivadavia 5202", "4581-3323", "contactonfo@barraza.con.ar", "Esther Morales", 8, 11, 0),
(5, "Villavicencio", "Av. Federico Lacroze 2667", "46532526", "villavicencio@hotmail.com", "Esteban Belkano", 4, 10, 1),
(6, "Diarco", "Av. Francisco Beiro 5877", "46365526", "info@diarco.com", "Luis Pasteur", 5, 5, 1),
(7, "LaSerenisima", "Gaona 2365", "47586970", "info@laserenisima.com", "Lautaro Croft", 5, 7, 1),
(8, "Sancor", "Av. Alvear 4567", "46213659", "sancor@hotmail.com", "Esteban Gomez", 5, 8, 1),
(9, "El Verdurin", "Av. Alvarez Thomas 988", "32563659", "tuverdurin@hotmail.com", "Tomas Gondria", 5, 2, 1),
(10, "Coca-Cola", "Corrientes 5100", "41245789", "info@cocacola.com", "Denisse Diaz", 5, 3, 1),
(11, "Proveedor Cajas", "Av. San Martin 852", "42269943", "cajas@gmail.com", "Gonzalo Martinez", 5,1,1);

insert into TipoProducto values
(1, "Empaquetamiento", 1),
(2, "Harinas", 1),
(3, "Lacteos", 1),
(4, "Pescados", 1),
(5, "Bebidas", 1),
(6, "Carnes", 1),
(7, "Vegetales", 1),
(8, "Frutas", 1),
(9, "Embutidos", 1);

insert into Productos values
(1, "Caja chica", "SaludSe", 1, 1, "Unidad", 200, 10, 5, 1),
(2, "Caja mediana", "SaludSe", 1, 1, "Unidad", 200, 10, 5, 1),
(3, "Caja grande", "SaludSe", 1, 1, "Unidad", 200, 10, 5, 1),
(4, "Leche", "LaSerenisima", 3, 1, "Litro", 500, 100, 5, 1),
(5, "Manteca", "LaSerenisima", 3, 0.5, "KG", 300, 50, 5, 1),
(6, "Agua", "Villavicencio", 5, 2, "Litro", 700, 120, 5, 1),
(7, "Manzana", "Cervi", 8, 1, "KG", 100, 10, 3, 1),
(8, "Cebolla", "La Cebollita", 7, 1, "KG", 60, 10, 4, 1);

insert into ProvProd values
( 5, 6, 20),
( 7, 2, 30),
( 7, 5, 40),
( 9, 7, 40),
( 9, 8, 20),
( 11, 1, 10),
( 11, 2, 15),
( 11, 3, 20);

insert into menu values
(1, "Pollo al spiedo con papas al horno", 1, 3, "Activo"),
(2, "Guiso de lentejas", 1, 3,  "Activo"),
(3, "Tarta de calabaza", 1, 3,  "Activo"),
(4, "Tarta de atun", 1, 3,  "Activo"),
(5, "Tarta de cebolla y queso", 1, 3,  "Activo"),
(6, "Tarta de verduras", 1, 3,  "Activo"),
(7, "Carne con ensalada de tomate, lechuga y zanahoria", 1, 3,  "Activo"),
(8, "Pizza vegana", 1, 3,  "Activo"),
(9, "Ensalada de frutas", 1, 3,  "Activo"),
(10, "Tortilla de espinaca", 1, 3,  "Activo"),
(11, "Canelones de verdura", 1, 3,  "Activo"),
(12, "Risotto", 1, 3,  "Activo"),
(13, "Ñoquis de espinaca", 1, 3,  "Activo"),
(14, "Sandwich de tomate, lechuga, zanahoria y huevo", 1, 3, "Activo"),
(15, "Wok", 1, 3, 1),
(16, "Cerdo con arroz", 1, 3,  "Activo");

insert into Chofer values
(1,"Wanchope","Economy",31644890,"messe 933","1970/08/13",1574823912),
(2,"El","Javinski",30291314,"nasni 124","1975/03/21",1583723612);

insert into TransporteDistribucion values
(1,"abc123","fiat","500"),
(2,"efg523","chevrolet","corsa");

insert into solicitante values
(1,15,1,1),
(2,22,1,1),
(3,23,1,1);

insert into cliente values
(1,1,"2018/10/24"),
(2,2,"2018/11/24"),
(3,3,"2018/12/24");

insert into sucursales values
(1,"Sucursal Chacarita","baigorria 2323","45456","anita",false,"11/11/2012",5,1,"12/12/2192",1),
(2,"Sucursal Fuerte Apache","nogoya 2323","45645","oscar",false,"11/11/2012",10,2,"12/12/2192",1),
(3,"SaludSe Devoto", "Beiro 2632","11637485", "Juan Perez",1,"2018/09/18",8,3,"2012/08/18",1);

insert into MenuVenta values
(1,1,1,210,40,20),   /* 1 */
(2,2,1,90.00,40,20), /* 2 */
(3,3,1,60.00,40,20), /* 2 */
(4,4,1,70.00,40,20), /* 3 */
(5,5,1,60.00,40,20), /* 3,5 */
(6,6,1,150.00,40,20),/* 4,5 */
(7,7,1,100.00,40,20),/* 4,6 */
(8,8,1,30.00,40,20), /* 4,6 */
(9,9,1,40.00,40,20), /* 6 */
(10,10,1,70.00,40,20);/* 6 */

insert into ClienteVentas values
(1,1,"Delivery",1),
(2,2,"Delivery",1),
(3,3,"Delivery",1),
(4,4,"Delivery",1);

insert into PedidosClientes values
(1,1,"2018/10/21","18:30:00","Entregado"),
(2,2,"2018/10/21","18:40:00","Entregado"),
(3,3,"2018/10/21","18:50:00","Entregado"),
(4,4,"2018/10/21","19:10:00","Entregado"),
(5,1,"2018/10/21","19:20:00","Cancelado"),
(6,2,"2018/10/21","19:30:00","Cancelado"),
(7,3,"2018/10/21","19:40:00","Cancelado"),
(8,4,"2018/10/21","19:50:00","Cancelado"),
(9,1,"2018/10/21","20:00:00","Enviado"),
(10,2,"2018/10/21","20:10:00","Enviado"),
(11,3,"2018/10/21","20:20:00","Enviado"),
(12,4,"2018/10/21","20:30:00","Enviado"),
(13,1,"2018/10/21","20:40:00","Enviado"),
(14,2,"2018/10/21","20:50:00","Enviado"),
(15,3,"2018/10/21","21:00:00","Activo"),
(16,4,"2018/10/21","21:10:00","Activo"),
(17,1,"2018/10/21","21:20:00","Activo"),
(18,2,"2018/10/21","21:30:00","Activo");

insert into PedidoMenu values
(4,6,1,"Sin sal"),
(4,7,1,""),
(4,8,1,""),
(5,4,1,""),
(5,5,1,""),
(6,2,1,"Sin lentejas"),
(6,3,1,"Sin calabaza"),
(7,1,1,"Sin sal"),
(8,1,1,"Con fritas"),
(9,2,1,""),
(9,3,1,""),
(10,4,1,"Sin atún"),
(10,5,1,""),
(11,6,1,""),
(11,7,1,""),
(11,8,1,""),
(12,5,1,""),
(12,6,1,""),
(13,7,1,""),
(13,8,1,""),
(13,9,1,""),
(13,10,1,""),
(14,1,1,"Con ensalada"),
(15,2,1,""),
(16,3,1,""),
(17,4,1,""),
(17,5,1,""),
(18,6,1,""),
(18,7,1,""),
(18,8,1,"");

insert into Envios values
(1,1,"Gaona 3456","2018/10/21",1),
(2,2,"Galicia 5632","2018/10/21",1),
(3,3,"Mercedez 3476","2018/10/21",1),
(4,4,"Bermudez 4567","2018/10/21",1),
(5,5,"Gaona 3456","2018/10/21",0),
(6,6,"Galicia 5632","2018/10/21",0),
(7,7,"Mercedez 3476","2018/10/21",0),
(8,8,"Bermudez 4567","2018/10/21",0),
(9,9,"Gaona 3456","2018/10/21",1),
(10,10,"Galicia 5632","2018/10/21",1),
(11,11,"Mercedez 3476","2018/10/21",1),
(12,12,"Bermudez 4567","2018/10/21",1),
(13,13,"Gaona 3456","2018/10/21",0),
(14,14,"Galicia 5632","2018/10/21",0),
(15,15,"Mercedez 3476",null,0),
(16,16,"Bermudez 4567",null,0),
(17,17,"Gaona 3456",null,0),
(18,18,"Galicia 5632",null,0);

insert into Ticket values
(1,1,11,"2018/10/21","18:45:00",210,1),
(2,2,11,"2018/10/21","18:55:00",150,1),
(3,3,11,"2018/10/21","19:05:00",130,1),
(4,4,11,"2018/10/21","19:15:00",280,1),
(5,5,11,null,null,130,0),
(6,6,11,null,null,150,0),
(7,7,11,null,null,210,0),
(8,8,11,null,null,210,0),
(9,9,11,null,null,210,1),
(10,10,11,null,null,150,1),
(11,11,11,null,null,130,1),
(12,12,11,null,null,280,1),
(13,13,11,null,null,240,1),
(14,14,11,null,null,210,1),
(15,15,11,null,null,210,1),
(16,16,11,null,null,150,1),
(17,17,11,null,null,130,1),
(18,18,11,null,null,280,1);

insert into VEHICULO values
(1,"Honda","SDH-125 STORM","A123BCD","Moto","2018/09/01",1,1,1),
(2,"Honda","TITAN CG 150","B321CDE","Moto","2018/09/03",1,1,1),
(3,"Yamaha","FZ1-N","C456DEF","Moto","2018/09/05",1,1,1),
(4,"Yamaha","FZ8-S","D654EFG","Moto","2018/09/07",0,1,1),
(5,"Suzuki","EN 125-2A","E789FGH","Moto","2018/09/09",0,1,1),
(6,"Suzuki","GN 125","F987GHI","Moto","2018/09/11",1,1,1),
(7,"Zanella","RX 150","G101HIJ","Moto","2018/09/13",0,0,1),  	/* FUERA DE SERVICIO */
(8,"Zanella","RX 150 G3","H102IJK","Moto","2018/09/15",0,0,1),/* FUERA DE SERVICIO */
(9,"Sym","WOLF 125 I","I103JKL","Moto","2018/09/17",0,0,1),	/* FUERA DE SERVICIO */
(10,"Sym","XS 125","J104KLM","Moto","2018/09/19",0,0,1);		/* FUERA DE SERVICIO */

insert into mantenimiento values
(1,1,"2018/09/01","2018/09/02","Rutina",1),
(2,2,"2018/09/03","2018/09/04","Rutina",1),
(3,3,"2018/09/05","2018/09/06","Rutina",1),
(4,4,"2018/09/07","2018/09/08","Rutina",1),
(5,5,"2018/09/09","2018/09/10","Rutina",1),
(6,6,"2018/09/11","2018/09/12","Rutina",1),
(7,7,"2018/09/13","2018/09/14","Rutina",1),
(8,8,"2018/09/15","2018/09/16","Rutina",1),
(9,9,"2018/09/17","2018/09/18","Rutina",1),
(10,10,"2018/09/19","2018/09/20","Rutina",1),
(11,1,"2018/10/02","2018/10/03","Rutina",1),
(12,2,"2018/10/04","2018/10/05","Rutina",1),
(13,3,"2018/10/06","2018/10/07","Rutina",1),
(14,4,"2018/10/08","2018/10/09","Rutina",1),
(15,5,"2018/10/10","2018/10/11","Rutina",1),
(16,6,"2018/10/12","2018/10/13","Rutina",1),
(17,7,"2018/10/14","2018/10/15","Rutina",1),
(18,8,"2018/10/16","2018/10/17","Rutina",1),
(19,9,"2018/10/18","2018/10/19","Rutina",1),
(20,10,"2018/10/20","2018/10/21","Rutina",1);

insert into vehiculoenvios values
(1,2,1,1),
(2,2,2,1),
(3,1,3,1),
(4,1,4,1),
(5,4,5,1),
(6,4,6,1);

insert into Turno values
(1,"Mañana","08:00:00","16:00:00"),
(2,"Tarde","16:00:00","00:00:00"),
(3,"Noche","00:00:00","08:00:00");

insert into movimientos values
(1, 30000, "2017/10/17",0),
(2, 100000, "2018/06/16",1),
(3, 17000, "2017/10/23",0),
(4, 100000, "2002/02/02",1),
(5, 100000, "2002/02/02",1),
(6, 15000, "2018/06/18",0),
(7, 30000, "2017/10/17",0);

insert into empleadoturno values
(1,1,1,"2018/10/10"),
(2,2,2,"2018/10/10"),
(3,4,1,"2018/10/10"),
(4,5,2,"2018/10/10"),
(5,6,3,"2018/10/10"),
(6,7,1,"2018/10/10"),
(7,8,2,"2018/10/10"),
(8,9,3,"2018/10/10"),
(9,10,1,"2018/10/10"),
(10,1,2,"2018/10/17"),
(11,2,3,"2018/10/17"),
(12,3,1,"2018/10/17"),
(13,4,2,"2018/10/17"),
(14,5,3,"2018/10/17"),
(15,6,1,"2018/10/17"),
(16,7,2,"2018/10/17"),
(17,8,3,"2018/10/17"),
(18,9,1,"2018/10/17"),
(19,10,2,"2018/10/17");

insert into Servicios values
(1,"publicidad de combos"),
(2,"publicidad de franquicia");

insert into Pagos values
(1,40000,"Sucursal","2018/10/17","Pago por regalia"),
(2,20000,"Sucursal","2018/09/17","Pago por publicidad");

insert into SucuServicio values
(1,1,1),
(1,2,0);

insert into capacitacion values 
('',"Contable",1),
('',"Cocina",1);

insert into curso values
('',2,"Curso de contable","Curso de administracion contable",5,15,"contable","2016/06/06",1),
('', 1, "Cocina", "Cocina", 2, 2, "Cocina", "20/03/2017",1); 

insert into cursoPersonal values
(1,1,true,"2018/04/04");

insert into CursoEmpleados values
(2,1,1,8,"2016/07/08","17:00"); 

insert into Orden values
(1, 1, "2018/08/22", 0, 0,0),
(2, 5, "2018/11/20", 0, 0,0),
(3, 3, "2018/04/12", 1, 0,0),
(4, 4, "2018/10/02", 0, 0,0),
(5, 1, "2018/10/02", 0, 0,0),
(6, 1, "2018/05/15", 1, 0,0);

insert into OrdenProducto values
( 5, 4, 150, 1,0),
( 5, 3, 150, 1,0),
( 3, 5, 100, 2,0),
( 3, 1, 100, 2,0),
( 4, 8, 100, 3,0),
( 4, 7, 100, 3,0),
( 2, 7, 150, 8,0),
( 2, 8, 150, 8,0),
( 1, 6, 160, 7,0),
( 6, 2, 160, 7,0),
( 6, 6, 160, 7,0),
( 1, 3, 160, 7,0);

insert into pedido values
('',1,"2018/01/10",0),
('',1,"2018/01/10",1),
('',2,"2018/01/10",1),
('',2,"2018/01/10",0);
 
 
insert into PedidosDetalle values
(1,1,15),
(1,3,10),
(2,2,20),
(2,4,7),
(3,1,40),
(3,3,33),
(3,4,33),
(4,2,2),
(4,1,53);
 
insert into pagossucursal values
(1,1,1),
(2,1,2),
(3,2,1),
(4,2,2);
 
insert into control_marca values
('',1,"2018/09/17","Control de marca",1,1),
('',1,"2018/09/17","Control de vestimenta",0,1),
('',2,"2018/09/17","Control de marca",0,1),
('',2,"2018/09/17","Control de vestimenta",1,1),
('',1,"2018/09/17","Control de la iluminacion",1,0),
('',1,"2018/09/17","Control de las dimensiones",0,0),
('',2,"2018/09/17","Control de la iluminacion",0,0),
('',2,"2018/09/17","Control de la dimensiones",1,0);