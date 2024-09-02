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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function    f_login 
(
    @usuario varchar(100), @contrasennia varchar(100)
)
--returns @tabla table (respuesta bit ,  rol varchar(50) )
returns varchar(100)
AS
BEGIN
	declare @respuesta as varchar(100)

-- Contraseña almacenanda en la base de datos
	declare @encriptada as varbinary(1000)
	select @encriptada = Password from usuario where usuario = @usuario
	
	declare @contraGuardada as varchar(100)
	set @contraGuardada = convert (varchar(50), DECRYPTBYPASSPHRASE('BaseDeDatos2', @encriptada ))
	

-- Rol del usuario
	declare @rol as varchar(50)
	select @rol =  nombre_Rol from usuario inner join rol on usuario.id_Rol = rol.id_Rol where usuario.Usuario = @usuario

-- Comparación de la contraseña

	
	If @contraGuardada =@contrasennia
		--insert into @tabla values (1, @rol)
		set @respuesta = @rol
	Else
		set @respuesta = '0'
		 --insert into @tabla values (0, ' ')

	RETURN @respuesta
END
GO

										/******  CREATE TABLES  ******/
CREATE TABLE    Categoria (
	 id_Categoria INTEGER PRIMARY KEY IDENTITY(1,1),
	 categoria   varchar (25) NOT NULL,
	 Estado   bit  NOT NULL,
);
GO


/****** Object:  Table    Cliente     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    Cliente (
	 id_Cliente   int  IDENTITY(1,1) NOT NULL,
	 Nombre_Cliente   varchar (200) NOT NULL,
	 DireccionFacturacion   varchar (30) NOT NULL,
	 Telefono   varchar (10) NOT NULL,
	 Correo   varchar (50) NOT NULL,
	 Estado   bit  NOT NULL,
	 Descuentos   bit  NULL,
	 NIT   varchar (8) NULL,
 CONSTRAINT  PK_Cliente  PRIMARY KEY CLUSTERED 
(
	 id_Cliente  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    DetalleFactura     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    DetalleFactura (
	 id_DetalleFactura   int  IDENTITY(1,1) NOT NULL,
	 cantidadMuebles   int  NOT NULL,
	 id_mueble   int  NULL,
	 id_Factura   int  NULL,
	 id_Serie   varchar (25) NULL,
 CONSTRAINT  PK_DetalleFactura  PRIMARY KEY CLUSTERED 
(
	 id_DetalleFactura  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    DetallePedido     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    DetallePedido (
	 id_DetallePedido   int  IDENTITY(1,1) NOT NULL,
	 CantidadProducto   int  NOT NULL,
	 id_Pedido   int  NULL,
	 id_mueble   int  NULL,
 CONSTRAINT  PK_DetallePedido  PRIMARY KEY CLUSTERED 
(
	 id_DetallePedido  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    DireccionEntrega     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    DireccionEntrega (
	 id_DirecciónEntrega   int  IDENTITY(1,1) NOT NULL,
	 Direccion   varchar (150) NOT NULL,
	 id_Cliente   int  NULL,
 CONSTRAINT  PK_DireccionEntrega  PRIMARY KEY CLUSTERED 
(
	 id_DirecciónEntrega  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO

CREATE TABLE    Empleado (
	 id_Empleado INTEGER PRIMARY KEY IDENTITY(1,1),
	 Nombre   varchar (150) NOT NULL,
	 Telefono   varchar (8) NOT NULL,
	 Correo   varchar (100) NOT NULL,
	 Estado   bit  NOT NULL,
);
GO

/****** Object:  Table    Entrega     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    Entrega (
	 id_Entrega   int  IDENTITY(1,1) NOT NULL,
	 DescripcionEntrega   varchar (200) NOT NULL,
	 TelefonoReferencia   varchar (8) NOT NULL,
	 Estado   bit  NOT NULL,
	 id_EstadoPedido   int  NULL,
	 id_DirecciónEntrega   int  NULL,
 CONSTRAINT  PK_Entrega  PRIMARY KEY CLUSTERED 
(
	 id_Entrega  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    EstadoPedido_Entrega     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    EstadoPedido_Entrega (
	 id_EstadoPedido   int  IDENTITY(1,1) NOT NULL,
	 Nombre_EstadoPedido   varchar (25) NOT NULL,
	 Estado   bit  NOT NULL,
 CONSTRAINT  PK_EstadoPedido_Entrega  PRIMARY KEY CLUSTERED 
(
	 id_EstadoPedido  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    EstadoPedido_Proveedor     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    EstadoPedido_Proveedor (
	 id_EstadoPedido   int  IDENTITY(1,1) NOT NULL,
	 Nombre_EstadoPedido   varchar (30) NOT NULL,
	 Estado   bit  NOT NULL,
 CONSTRAINT  PK_EstadoPedido_Proveedor  PRIMARY KEY CLUSTERED 
(
	 id_EstadoPedido  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    Factura     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    Factura (
	 id_Factura   int  IDENTITY(1,1) NOT NULL,
	 id_Serie   varchar (25) NOT NULL,
	 fechaFactura   datetime  NOT NULL,
	 montoTotal   decimal (10, 2) NOT NULL,
	 Estado   bit  NOT NULL,
	 id_Cliente   int  NULL,
	 id_Usuario   int  NULL,
	 id_TipoPago   int  NULL,
	 id_Domicilio   int  NULL,
 CONSTRAINT  PK_Factura  PRIMARY KEY CLUSTERED 
(
	 id_Factura  ASC,
	 id_Serie  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO


CREATE TABLE    Marca (
	 id_Marca INTEGER PRIMARY KEY IDENTITY(1,1),
	 marca   varchar (50) NOT NULL,
	 Estado   bit  NOT NULL,
);
GO

CREATE TABLE    Modelo (
	 id_Modelo INTEGER PRIMARY KEY IDENTITY(1,1),
	 modelo   varchar (50) NOT NULL,
	 Estado   bit  NOT NULL,
	 id_Marca   int  NULL,
	 id_Categoria   int  NULL,
); 
GO

/****** Object:  Table    Muebles     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    Muebles (
	 id_mueble   int  IDENTITY(1,1) NOT NULL,
	 Descripcion   varchar (175) NOT NULL,
	 PrecioVenta   float  NOT NULL,
	 Descuento   decimal (3, 2) NOT NULL,
	 ExistenciaMinima   int  NOT NULL,
	 TiempoGarantia   int  NOT NULL,
	 Estado   bit  NOT NULL,
	 id_Modelo   int  NULL,
 CONSTRAINT  PK_Muebles  PRIMARY KEY CLUSTERED 
(
	 id_mueble  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    Pedido     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    Pedido (
	 id_Pedido   int  IDENTITY(1,1) NOT NULL,
	 Descripcion   varchar (200) NOT NULL,
	 FechaPedido   date  NOT NULL,
	 FechaRecibido   date  NULL,
	 CantidadPedido   int  NULL,
	 CantidadRecibido   int  NULL,
	 TotalPagar   decimal (10, 2) NOT NULL,
	 Estado   bit  NOT NULL,
	 id_EstadoPedido   int  NULL,
	 id_TipoPago   int  NULL,
	 id_Proveedor   int  NULL,
 CONSTRAINT  PK_Pedido  PRIMARY KEY CLUSTERED 
(
	 id_Pedido  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    Proveedor     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Proveedor(
	id_Proveedor int IDENTITY(1,1) NOT NULL,
	proveedor varchar(75) NOT NULL,
	Direccion varchar(75) NOT NULL,
	Telefono varchar(15) NOT NULL,
	TelefonoExtra varchar(15) NULL,
	Correo varchar(35) NOT NULL,
	Estado bit NOT NULL,
 CONSTRAINT  PK_Proveedor  PRIMARY KEY CLUSTERED 
(
	 id_Proveedor  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO


CREATE TABLE    Rol (
	id_Rol INTEGER PRIMARY KEY IDENTITY(1,1),
	nombre_Rol   varchar (20) NOT NULL,
	Estado  bit  NOT NULL,
);
GO


/****** Object:  Table    SerieFactura     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    SerieFactura (
	 id_Serie   varchar (25) NOT NULL,
	 fechaInicio   smalldatetime  NOT NULL,
	 Estado   bit  NOT NULL,
 CONSTRAINT  PK_SerieFactura  PRIMARY KEY CLUSTERED 
(
	 id_Serie  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    Stock     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    Stock (
	 id_Stock   int  IDENTITY(1,1) NOT NULL,
	 CantidadInicial   int  NOT NULL,
	 CantidadStock   int  NOT NULL,
	 FechaIngreso   date  NOT NULL,
	 Estado   bit  NOT NULL,
	 id_mueble   int  NULL,
 CONSTRAINT  PK_Stock  PRIMARY KEY CLUSTERED 
(
	 id_Stock  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
GO
/****** Object:  Table    TipoPago     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE    TipoPago (
	 id_TipoPago   int  IDENTITY(1,1) NOT NULL,
	 Nombre_TipoPago   varchar (20) NOT NULL,
	 Estado   bit  NOT NULL,
 CONSTRAINT  PK_TipoPago  PRIMARY KEY CLUSTERED 
(
	 id_TipoPago  ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON  PRIMARY 
) ON  PRIMARY 
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
	('Admin', 0x0200000014ABC2E4AD7605FF087438F19DFF29B9557291126CD8B381A114CE0B8E09CA95, 1, 1, 6),
	('ValeriaV', 0x02000000A7C052F2326BE29BF59D4A2ACE309D1E0F5736851300F8E4C552569E2AF38A046AE0C325BF8F322BC050E1CB94F2F0D6, 1, 2, 2),
	('Jesus', 0x02000000A8147B3F33733B8B38DD269F6C18C835ED6C4303522A40E2D2013866F0B548B3, 1, 1, 4),
	('Otto', 0x020000002C6E0BF9806CE2BBC6742AA1CC2B2DDF9577AF35CBE3E6F96024FF4526533AF1, 1, 3, 5),
	('juanjo', 0x02000000ED67E8E8F44C59EF4921AACF8ECDEEF9B2932BB70095DAD51A7120765A52261092D107BDA85D82D7B1443E63CA0EFC6A, 1, 4, 1);

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
ALTER TABLE    DetalleFactura   WITH CHECK ADD  CONSTRAINT  Relationship12  FOREIGN KEY( id_Factura ,  id_Serie )
REFERENCES    Factura  ( id_Factura ,  id_Serie )
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
/****** Object:  StoredProcedure    f_crearUsuario     Script Date: 1/09/2024 20:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure    f_crearUsuario 
(
    @usuario varchar(100), @contrasennia varchar(100), @rol int, @empleado int  
)

AS
BEGIN

	declare @encriptado as varbinary(max)
	set @encriptado = ENCRYPTBYPASSPHRASE ('BaseDeDatos2', @contrasennia)

	insert into usuario values ( N'Admin',  @encriptado, 1, 1, 6)
END
GO
