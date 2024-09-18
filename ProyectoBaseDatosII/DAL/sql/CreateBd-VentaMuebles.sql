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
	 Descuentos bit NULL,
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
	 Estado bit NOT NULL,
	 id_Cliente int NULL,
	 id_Usuario int NULL,
	 id_TipoPago int NULL,
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


INSERT INTO Empleado (Nombre,Telefono,Correo,Estado) 
VALUES 
	('Juan Jose', '77609876', 'juanjo@gmail.com', 1),
	('Valeria Valle', '76341257', 'vale123@gmail.com', 1),
	('Gabriela Sandoval', '99347512', 'Gabi@gmail.com', 1),
	('Jesus Sarti', '78435567', 'Ye@gmail.com', 1),
	('Ottoniel Dominguez', '12341234', 'otto@gmail.com', 1),
	('Santiago López', '40781234', 'santiagol@gmail.com', 1); 
INSERT INTO Rol (nombre_Rol,Estado) 
VALUES 
	('Administrador', 1),
	('Bodeguero', 1),
	('Vendedor', 1),
	('Gerente', 1);
INSERT INTO Usuario  (Usuario,Password,Estado,id_Rol,id_Empleado)
VALUES 
	('Admin', 0xE1223D9BBCD82236F9F09AE1F5578E3CBBD4E8F48954CEAD3003BE60AC85629726DC04B1F875353459F97BA4A4283A1A6ADB89D3524BB4816C7125964097106C, 1, 1, 6),
	('ValeriaV', 0x2E15C943B679F39B07F0E79E4293EBA6F7338159970C77A94018569F577E7025697545AD443556FE92361B83F21435EAB253DBBA5E41EBB636B633241209A4FF, 1, 2, 2),
	('Jesus', 0xD5BFF99428217F82ABCA99105A51254B654BE9A96145E3BFBEBADCF4EC36D1B021ED05A1ADB978C2AB08E896F3EC3CB8EE5DC6B161C06F1744AAFF367ECB4CBF, 1, 1, 4),
	('Otto', 0xAAFF9106875B7964E8991352C0C0E4E8DB27A94E76086C993BC2470DBFF0C8CFCD1524D0C358424288B4E552F5D1A31274960BC43905763B1633F246A975FB73, 1, 3, 5),
	('juanjo', 0x7DDE3B93B0A76254ECF6AFF493067453F763DD9FFBBE99BA6228D66CF3C353C17E34E121385DC01C29DA7541BD342ED99D4DBB66936246FEC33FD41367E80E7D, 1, 4, 1);

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
ALTER TABLE    Factura   WITH CHECK ADD  CONSTRAINT  Relationship19  FOREIGN KEY( id_TipoPago )
REFERENCES    TipoPago  ( id_TipoPago )
GO
ALTER TABLE    Factura  CHECK CONSTRAINT  Relationship19 
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
