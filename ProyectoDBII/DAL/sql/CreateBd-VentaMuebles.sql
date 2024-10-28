IF NOT EXISTS (SELECT * FROM sys.databases WHERE name='VentaMuebles')
CREATE DATABASE VentaMuebles
GO

USE VentaMuebles
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categoria')
DROP TABLE Categoria
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cliente')
DROP TABLE Cliente
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'DetalleFactura')
DROP TABLE DetalleFactura
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'DetallePedido')
DROP TABLE DetallePedido
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'DireccionEntrega')
DROP TABLE DireccionEntrega
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Empleado')
DROP TABLE Empleado
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EstadoPedido_Entrega')
DROP TABLE EstadoPedido_Entrega
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EstadoPedido_Proveedor')
DROP TABLE EstadoPedido_Proveedor
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Factura')
DROP TABLE Factura
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Marca')
DROP TABLE Marca
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Modelo')
DROP TABLE Modelo
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Muebles')
DROP TABLE Muebles
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Pedido')
DROP TABLE Pedido
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Proveedor')
DROP TABLE Proveedor
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Rol')
DROP TABLE Rol
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SerieFactura')
DROP TABLE SerieFactura
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Stock')
DROP TABLE Stock
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TipoPago')
DROP TABLE TipoPago
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario')
DROP TABLE Usuario
GO

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Pago')
DROP TABLE Pago
GO

IF OBJECT_ID('dbo.ListarProveedor') IS NOT NULL
BEGIN
	DROP PROC ListarProveedor;
END;
IF OBJECT_ID('dbo.ListarMarca') IS NOT NULL
BEGIN
	DROP PROC ListarMarca;
END;
IF OBJECT_ID('dbo.ListarCategoria') IS NOT NULL
BEGIN
	DROP PROC ListarCategoria;
END;
IF OBJECT_ID('dbo.ListarEmpleado') IS NOT NULL
BEGIN
	DROP PROC ListarEmpleado;
END;
IF OBJECT_ID('dbo.InsertarProveedor') IS NOT NULL
BEGIN
	DROP PROC InsertarProveedor;
END;
IF OBJECT_ID('dbo.InsertarMarca') IS NOT NULL
BEGIN
	DROP PROC InsertarMarca;
END;
IF OBJECT_ID('dbo.InsertarCategoria') IS NOT NULL
BEGIN
	DROP PROC InsertarCategoria;
END;
IF OBJECT_ID('dbo.InsertarEmpleado') IS NOT NULL
BEGIN
	DROP PROC InsertarEmpleado;
END;
IF OBJECT_ID('dbo.ActualizarProveedor') IS NOT NULL
BEGIN
	DROP PROC ActualizarProveedor;
END;
IF OBJECT_ID('dbo.ActualizarMarca') IS NOT NULL
BEGIN
	DROP PROC ActualizarMarca;
END;
IF OBJECT_ID('dbo.ActualizarCategoria') IS NOT NULL
BEGIN
	DROP PROC ActualizarCategoria;
END;
IF OBJECT_ID('dbo.ActualizarEmpleado') IS NOT NULL
BEGIN
	DROP PROC ActualizarEmpleado;
END;
IF OBJECT_ID('dbo.EliminarMarca') IS NOT NULL
BEGIN
	DROP PROC EliminarMarca;
END;
IF OBJECT_ID('dbo.EliminarCategoria') IS NOT NULL
BEGIN
	DROP PROC EliminarCategoria;
END;
IF OBJECT_ID('dbo.EliminarEmpleado') IS NOT NULL
BEGIN
	DROP PROC EliminarEmpleado;
END;
IF OBJECT_ID('dbo.EliminarProveedor') IS NOT NULL
BEGIN
	DROP PROC EliminarProveedor;
END;
GO
										/******  CREATE TABLES  ******/
CREATE TABLE    Categoria (
	 id_Categoria INTEGER PRIMARY KEY IDENTITY(1,1),
	 categoria   varchar (25) NOT NULL,
	 Estado   bit  NOT NULL,
);
GO


/****** Object:  Table    Cliente     Script Date: 1/09/2024 20:09:38 ******/
CREATE TABLE Cliente (
	 id_Cliente INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre_Cliente varchar(200) NOT NULL,
	 DireccionFacturacion varchar(30) NOT NULL,
	 Telefono varchar(10) NOT NULL,
	 Correo varchar(50) NOT NULL,
	 Estado bit NOT NULL,
	 Descuentos decimal(3,2) NOT NULL,
	 NIT varchar(8) NULL
); 
GO

CREATE TABLE DetalleFactura (
	 id_DetalleFactura INTEGER PRIMARY KEY IDENTITY(1,1),
	 cantidadMuebles int NOT NULL,
	 id_mueble int NULL,
	 id_Factura int NULL,
	 id_Serie varchar(25) NULL
); 
GO

CREATE TABLE DetallePedido (
	 id_DetallePedido INTEGER PRIMARY KEY IDENTITY(1,1),
	 CantidadProducto int NOT NULL,
	 id_Pedido int NULL,
	 id_mueble int NULL
); 
GO

CREATE TABLE DireccionEntrega (
	 id_DirecciónEntrega INTEGER PRIMARY KEY IDENTITY(1,1),
	 Direccion varchar(150) NOT NULL,
	 id_Cliente int NULL
); 
GO

CREATE TABLE Empleado (
	 id_Empleado INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre varchar(150) NOT NULL,
	 Telefono varchar(8) NOT NULL,
	 Correo varchar(100) NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE Entrega (
	 id_Entrega INTEGER PRIMARY KEY IDENTITY(1,1),
	 DescripcionEntrega varchar(200) NOT NULL,
	 TelefonoReferencia varchar(8) NOT NULL,
	 fechaEntrega date NOT NULL,
	 horaEntrega time NOT NULL,
	 Estado bit NOT NULL,
	 id_EstadoPedido int NULL,
	 id_DirecciónEntrega int NULL
); 
GO

CREATE TABLE EstadoPedido_Entrega (
	 id_EstadoPedido INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre_EstadoPedido varchar(25) NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE EstadoPedido_Proveedor (
	 id_EstadoPedido INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre_EstadoPedido varchar(30) NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE Factura (
	 id_Factura INTEGER PRIMARY KEY IDENTITY(1,1),
	 id_Serie varchar(25) NOT NULL,
	 fechaFactura datetime NOT NULL,
	 montoTotal decimal(10, 2) NOT NULL,
	 totalSinDescuento decimal (10,2) NOT NULL,
	 Estado bit NOT NULL,
	 id_Cliente int NULL,
	 id_Usuario int NULL,
	 id_Domicilio int NULL
); 
GO

CREATE TABLE Marca (
	 id_Marca INTEGER PRIMARY KEY IDENTITY(1,1),
	 marca varchar(50) NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE Modelo (
	 id_Modelo INTEGER PRIMARY KEY IDENTITY(1,1),
	 modelo varchar(50) NOT NULL,
	 Estado bit NOT NULL,
	 id_Marca int NULL,
	 id_Categoria int NULL
); 
GO

CREATE TABLE Muebles (
	 id_mueble INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre varchar(100) NOT NULL,
	 Descripcion varchar(175) NOT NULL,
	 PrecioVenta float NOT NULL,
	 Descuento decimal(3, 2) NOT NULL,
	 ExistenciaMinima int NOT NULL,
	 TiempoGarantia int NOT NULL,
	 Estado bit NOT NULL,
	 id_Modelo int NULL
); 
GO

CREATE TABLE Pedido (
	 id_Pedido INTEGER PRIMARY KEY IDENTITY(1,1),
	 Descripcion varchar(200) NOT NULL,
	 FechaPedido date NOT NULL,
	 FechaRecibido date NULL,
	 CantidadPedido int NULL,
	 CantidadRecibido int NULL,
	 TotalPagar decimal(10, 2) NOT NULL,
	 Estado bit NOT NULL,
	 id_EstadoPedido int NULL,
	 id_TipoPago int NULL,
	 id_Proveedor int NULL
); 
GO

CREATE TABLE Proveedor (
	 id_Proveedor INTEGER PRIMARY KEY IDENTITY(1,1),
	 proveedor varchar(75) NOT NULL,
	 Direccion varchar(75) NOT NULL,
	 Telefono varchar(15) NOT NULL,
	 TelefonoExtra varchar(15) NULL,
	 Correo varchar(35) NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE Rol (
	 id_Rol INTEGER PRIMARY KEY IDENTITY(1,1),
	 nombre_Rol varchar(20) NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE SerieFactura (
	 id_Serie varchar(25) PRIMARY KEY,
	 fechaInicio smalldatetime NOT NULL,
	 Estado bit NOT NULL
); 
GO

CREATE TABLE Stock (
	 id_Stock INTEGER PRIMARY KEY IDENTITY(1,1),
	 CantidadInicial int NOT NULL,
	 CantidadStock int NOT NULL,
	 FechaIngreso date NOT NULL,
	 Estado bit NOT NULL,
	 id_mueble int NULL
); 
GO

CREATE TABLE TipoPago (
	 id_TipoPago INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre_TipoPago varchar(20) NOT NULL,
	 Estado bit NOT NULL
); 
GO



CREATE TABLE    Usuario (
	 id_Usuario INTEGER PRIMARY KEY IDENTITY(1,1),
	 Usuario   varchar (75) NOT NULL,
	 Password   varbinary (2000) NOT NULL,
	 Estado   bit  NOT NULL,
	 id_Rol   int  NULL,
	 id_Empleado   int  NOT NULL,
	 FOREIGN KEY (id_Rol) REFERENCES Rol(id_Rol),
	 FOREIGN KEY (id_Empleado) REFERENCES Empleado(id_Empleado),
); 
GO

CREATE TABLE Pago (
    id_Pago INTEGER PRIMARY KEY IDENTITY(1,1),
    porcentaje DECIMAL(4,2) NOT NULL,
    cantidad DECIMAL(18,2) NOT NULL,
    id_TipoPago INT NOT NULL,
    id_Factura INT NOT NULL,
    id_Serie VARCHAR(25) NOT NULL,
    FOREIGN KEY (id_TipoPago) REFERENCES TipoPago(id_TipoPago),
    FOREIGN KEY (id_Factura) REFERENCES Factura(id_Factura),
    FOREIGN KEY (id_Serie) REFERENCES SerieFactura(id_Serie)
);
GO




ALTER TABLE    Categoria  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Cliente  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Cliente  ADD  DEFAULT ((0)) FOR  Descuentos 
GO
ALTER TABLE    Empleado  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Entrega  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    EstadoPedido_Entrega  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    EstadoPedido_Proveedor  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Factura  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Marca  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Modelo  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Muebles  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Pedido  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Proveedor  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Rol  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    TipoPago  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    Usuario  ADD  DEFAULT ((1)) FOR  Estado 
GO
ALTER TABLE    DetalleFactura   WITH CHECK ADD  CONSTRAINT  Relationship11  FOREIGN KEY( id_mueble )
REFERENCES    Muebles  ( id_mueble )
GO
ALTER TABLE    DetalleFactura  CHECK CONSTRAINT  Relationship11 
GO
ALTER TABLE DetalleFactura 
WITH CHECK ADD CONSTRAINT Relationship12 
FOREIGN KEY (id_Factura) 
REFERENCES Factura(id_Factura);
GO
ALTER TABLE    DetalleFactura  CHECK CONSTRAINT  Relationship12 
GO
ALTER TABLE    DetallePedido   WITH CHECK ADD  CONSTRAINT  Relationship10  FOREIGN KEY( id_mueble )
REFERENCES    Muebles  ( id_mueble )
GO
ALTER TABLE    DetallePedido  CHECK CONSTRAINT  Relationship10 
GO
ALTER TABLE    DetallePedido   WITH CHECK ADD  CONSTRAINT  Relationship9  FOREIGN KEY( id_Pedido )
REFERENCES    Pedido  ( id_Pedido )
GO
ALTER TABLE    DetallePedido  CHECK CONSTRAINT  Relationship9 
GO
ALTER TABLE    DireccionEntrega   WITH CHECK ADD  CONSTRAINT  Relationship23  FOREIGN KEY( id_Cliente )
REFERENCES    Cliente  ( id_Cliente )
GO
ALTER TABLE    DireccionEntrega  CHECK CONSTRAINT  Relationship23 
GO
ALTER TABLE    Entrega   WITH CHECK ADD  CONSTRAINT  Relationship21  FOREIGN KEY( id_EstadoPedido )
REFERENCES    EstadoPedido_Entrega  ( id_EstadoPedido )
GO
ALTER TABLE    Entrega  CHECK CONSTRAINT  Relationship21 
GO
ALTER TABLE    Entrega   WITH CHECK ADD  CONSTRAINT  Relationship24  FOREIGN KEY( id_DirecciónEntrega )
REFERENCES    DireccionEntrega  ( id_DirecciónEntrega )
GO
ALTER TABLE    Entrega  CHECK CONSTRAINT  Relationship24 
GO
ALTER TABLE    Factura   WITH CHECK ADD  CONSTRAINT  Relationship13  FOREIGN KEY( id_Cliente )
REFERENCES    Cliente  ( id_Cliente )
GO
ALTER TABLE    Factura  CHECK CONSTRAINT  Relationship13 
GO
ALTER TABLE    Factura   WITH CHECK ADD  CONSTRAINT  Relationship16  FOREIGN KEY( id_Usuario )
REFERENCES    Usuario  ( id_Usuario )
GO
ALTER TABLE    Factura  CHECK CONSTRAINT  Relationship16 
GO
ALTER TABLE    Factura   WITH CHECK ADD  CONSTRAINT  Relationship18  FOREIGN KEY( id_Serie )
REFERENCES    SerieFactura  ( id_Serie )
GO
ALTER TABLE    Factura  CHECK CONSTRAINT  Relationship18 
GO
ALTER TABLE    Factura   WITH CHECK ADD  CONSTRAINT  Relationship22  FOREIGN KEY( id_Domicilio )
REFERENCES    Entrega  ( id_Entrega )
GO
ALTER TABLE    Factura  CHECK CONSTRAINT  Relationship22 
GO
ALTER TABLE    Modelo   WITH CHECK ADD  CONSTRAINT  Relationship1  FOREIGN KEY( id_Marca )
REFERENCES    Marca  ( id_Marca )
GO
ALTER TABLE    Modelo  CHECK CONSTRAINT  Relationship1 
GO
ALTER TABLE    Modelo   WITH CHECK ADD  CONSTRAINT  Relationship4  FOREIGN KEY( id_Categoria )
REFERENCES    Categoria  ( id_Categoria )
GO
ALTER TABLE    Modelo  CHECK CONSTRAINT  Relationship4 
GO
ALTER TABLE    Muebles   WITH CHECK ADD  CONSTRAINT  Relationship2  FOREIGN KEY( id_Modelo )
REFERENCES    Modelo  ( id_Modelo )
GO
ALTER TABLE    Muebles  CHECK CONSTRAINT  Relationship2 
GO
ALTER TABLE    Pedido   WITH CHECK ADD  CONSTRAINT  Relationship6  FOREIGN KEY( id_EstadoPedido )
REFERENCES    EstadoPedido_Proveedor  ( id_EstadoPedido )
GO
ALTER TABLE    Pedido  CHECK CONSTRAINT  Relationship6 
GO
ALTER TABLE    Pedido   WITH CHECK ADD  CONSTRAINT  Relationship7  FOREIGN KEY( id_TipoPago )
REFERENCES    TipoPago  ( id_TipoPago )
GO
ALTER TABLE    Pedido  CHECK CONSTRAINT  Relationship7 
GO
ALTER TABLE    Pedido   WITH CHECK ADD  CONSTRAINT  Relationship8  FOREIGN KEY( id_Proveedor )
REFERENCES    Proveedor  ( id_Proveedor )
GO
ALTER TABLE    Pedido  CHECK CONSTRAINT  Relationship8 
GO
ALTER TABLE    Stock   WITH CHECK ADD  CONSTRAINT  Relationship5  FOREIGN KEY( id_mueble )
REFERENCES    Muebles  ( id_mueble )
GO
ALTER TABLE    Stock  CHECK CONSTRAINT  Relationship5 
GO
ALTER TABLE    Usuario   WITH CHECK ADD  CONSTRAINT  Relationship14  FOREIGN KEY( id_Rol )
REFERENCES    Rol  ( id_Rol )
GO
ALTER TABLE    Usuario  CHECK CONSTRAINT  Relationship14 
GO
ALTER TABLE    Usuario   WITH CHECK ADD  CONSTRAINT  Relationship15  FOREIGN KEY( id_Empleado )
REFERENCES    Empleado  ( id_Empleado )
GO
ALTER TABLE    Usuario  CHECK CONSTRAINT  Relationship15 
GO
