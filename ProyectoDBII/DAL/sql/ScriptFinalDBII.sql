USE [VentaMuebles]
GO
/****** Object:  UserDefinedTableType [dbo].[udt_DetalleFactura]    Script Date: 17/11/2024 13:03:23 ******/
CREATE TYPE [dbo].[udt_DetalleFactura] AS TABLE(
	[cantidad] [int] NOT NULL,
	[id_Mueble] [int] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udt_DetalleImprimir]    Script Date: 17/11/2024 13:03:23 ******/
CREATE TYPE [dbo].[udt_DetalleImprimir] AS TABLE(
	[cantidad] [int] NOT NULL,
	[id_Mueble] [int] NOT NULL,
	[total] [decimal](10, 2) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udt_DetallePedido]    Script Date: 17/11/2024 13:03:23 ******/
CREATE TYPE [dbo].[udt_DetallePedido] AS TABLE(
	[cantidad] [int] NOT NULL,
	[id_mueble] [int] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udt_Factura]    Script Date: 17/11/2024 13:03:23 ******/
CREATE TYPE [dbo].[udt_Factura] AS TABLE(
	[id_Factura] [int] NOT NULL,
	[id_Serie] [varchar](25) NOT NULL,
	[fechaFactura] [datetime] NOT NULL,
	[montoTotal] [decimal](18, 2) NOT NULL,
	[totalSinDescuetno] [decimal](18, 2) NOT NULL,
	[descuento] [decimal](10, 2) NOT NULL,
	[Cliente] [varchar](200) NOT NULL,
	[Direccion] [varchar](30) NOT NULL,
	[Usuario] [varchar](75) NOT NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[f_login]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Función para incicio de sesión
Create function [dbo].[f_login]
(
    @usuario varchar(100), @contrasennia varchar(100)
)
	--returns @tabla table (respuesta bit ,  rol varchar(50) )
	returns varchar(100)
	AS
	BEGIN
		declare @respuesta as varchar(100)

	-- Contraseña almacenanda en la base de datos
		declare @contraGuardada as varbinary(1000)
		select @contraGuardada = Password from usuario where usuario = @usuario
		


		declare @contraEncriptada as varbinary(1000)
		set @contraEncriptada = hashbytes('SHA2_512', convert(nvarchar(4000), @contrasennia))
		
		--declare @contraGuardada as varchar(100)
		--set @contraGuardada = convert (varchar(50), DECRYPTBYPASSPHRASE('BaseDeDatos2', @encriptada ))
		

	-- Rol del usuario
		declare @rol as varchar(50)
		select @rol =  nombre_Rol from usuario inner join rol on usuario.id_Rol = rol.id_Rol where usuario.Usuario = @usuario

	-- Comparación de la contraseña

		
		If @contraGuardada =@contraEncriptada
			--insert into @tabla values (1, @rol)
			set @respuesta = @rol
		Else
			set @respuesta = '0'
			--insert into @tabla values (0, ' ')
	RETURN @respuesta
END
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](25) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Cliente] [varchar](200) NOT NULL,
	[DireccionFacturacion] [varchar](30) NOT NULL,
	[Telefono] [varchar](10) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Descuentos] [decimal](3, 2) NOT NULL,
	[NIT] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[id_DetalleFactura] [int] IDENTITY(1,1) NOT NULL,
	[cantidadMuebles] [int] NOT NULL,
	[id_mueble] [int] NULL,
	[id_Factura] [int] NULL,
	[id_Serie] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_DetalleFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[id_DetallePedido] [int] IDENTITY(1,1) NOT NULL,
	[CantidadProducto] [int] NOT NULL,
	[id_Pedido] [int] NULL,
	[id_mueble] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_DetallePedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DireccionEntrega]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DireccionEntrega](
	[id_DirecciónEntrega] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[id_Cliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_DirecciónEntrega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Telefono] [varchar](8) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrega]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrega](
	[id_Entrega] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionEntrega] [varchar](200) NOT NULL,
	[TelefonoReferencia] [varchar](8) NOT NULL,
	[fechaEntrega] [date] NOT NULL,
	[horaEntrega] [time](7) NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_EstadoPedido] [int] NULL,
	[id_DirecciónEntrega] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Entrega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPedido_Entrega]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPedido_Entrega](
	[id_EstadoPedido] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_EstadoPedido] [varchar](25) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_EstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPedido_Proveedor]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPedido_Proveedor](
	[id_EstadoPedido] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_EstadoPedido] [varchar](30) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_EstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id_Factura] [int] IDENTITY(1,1) NOT NULL,
	[id_Serie] [varchar](25) NOT NULL,
	[fechaFactura] [datetime] NOT NULL,
	[montoTotal] [decimal](10, 2) NOT NULL,
	[totalSinDescuento] [decimal](10, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_Cliente] [int] NULL,
	[id_Usuario] [int] NULL,
	[id_Domicilio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[id_Modelo] [int] IDENTITY(1,1) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_Marca] [int] NULL,
	[id_Categoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Muebles]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muebles](
	[id_mueble] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](175) NOT NULL,
	[PrecioVenta] [float] NOT NULL,
	[Descuento] [decimal](3, 2) NOT NULL,
	[ExistenciaMinima] [int] NOT NULL,
	[TiempoGarantia] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_Modelo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mueble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[id_Pago] [int] IDENTITY(1,1) NOT NULL,
	[porcentaje] [decimal](4, 2) NOT NULL,
	[cantidad] [decimal](18, 2) NOT NULL,
	[id_TipoPago] [int] NOT NULL,
	[id_Factura] [int] NOT NULL,
	[id_Serie] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[id_Pedido] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[FechaPedido] [date] NOT NULL,
	[FechaRecibido] [date] NULL,
	[CantidadPedido] [int] NULL,
	[CantidadRecibido] [int] NULL,
	[TotalPagar] [decimal](10, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_EstadoPedido] [int] NULL,
	[id_TipoPago] [int] NULL,
	[id_Proveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[proveedor] [varchar](75) NOT NULL,
	[Direccion] [varchar](75) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[TelefonoExtra] [varchar](15) NULL,
	[Correo] [varchar](35) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[id_Rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre_Rol] [varchar](20) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SerieFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SerieFactura](
	[id_Serie] [varchar](25) NOT NULL,
	[fechaInicio] [smalldatetime] NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Serie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[id_Stock] [int] IDENTITY(1,1) NOT NULL,
	[CantidadInicial] [int] NOT NULL,
	[CantidadStock] [int] NOT NULL,
	[FechaIngreso] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_mueble] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPago]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPago](
	[id_TipoPago] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_TipoPago] [varchar](20) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_TipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](75) NOT NULL,
	[Password] [varbinary](2000) NOT NULL,
	[Estado] [bit] NOT NULL,
	[id_Rol] [int] NULL,
	[id_Empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (1, N'Silla', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (2, N'Sofa', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (3, N'Mesa', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (4, N'Cama', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (5, N'Closet', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (6, N'Lámpara', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (7, N'Cama Sofa', 1)
INSERT [dbo].[Categoria] ([id_Categoria], [categoria], [Estado]) VALUES (8, N'Litera', 1)
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id_Cliente], [Nombre_Cliente], [DireccionFacturacion], [Telefono], [Correo], [Estado], [Descuentos], [NIT]) VALUES (1, N'Emiliano Sarti', N'San Marcos', N'43125789', N'emiliano@gmail.com', 1, CAST(0.00 AS Decimal(3, 2)), N'12345678')
INSERT [dbo].[Cliente] ([id_Cliente], [Nombre_Cliente], [DireccionFacturacion], [Telefono], [Correo], [Estado], [Descuentos], [NIT]) VALUES (2, N'Juan Pablo Lopez Garcia', N'Ciudad', N'17921234', N'juanpaLG@gmail.com', 1, CAST(0.00 AS Decimal(3, 2)), N'CF')
INSERT [dbo].[Cliente] ([id_Cliente], [Nombre_Cliente], [DireccionFacturacion], [Telefono], [Correo], [Estado], [Descuentos], [NIT]) VALUES (3, N'Alexander Bollen', N'Quetzaltenango', N'12312312', N'', 1, CAST(0.00 AS Decimal(3, 2)), N'12312212')
INSERT [dbo].[Cliente] ([id_Cliente], [Nombre_Cliente], [DireccionFacturacion], [Telefono], [Correo], [Estado], [Descuentos], [NIT]) VALUES (4, N'Pedro Pescuezo', N'San Marcos', N'55445544', N'pedro@gmail.com', 1, CAST(0.00 AS Decimal(3, 2)), N'CF')
INSERT [dbo].[Cliente] ([id_Cliente], [Nombre_Cliente], [DireccionFacturacion], [Telefono], [Correo], [Estado], [Descuentos], [NIT]) VALUES (6, N'Pedro Cifuentes', N'Ciudad', N'98989898', N'', 1, CAST(0.00 AS Decimal(3, 2)), N'CF')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleFactura] ON 

INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (1, 2, 15, 1, N'A-23')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (2, 1, 9, 1, N'A-23')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (3, 4, 7, 1, N'A-23')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (4, 5, 6, 1, N'A-23')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (7, 1, 1, 4, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (8, 1, 3, 4, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (9, 1, 1, 5, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (10, 1, 5, 5, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (11, 1, 3, 6, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (12, 1, 5, 6, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (13, 5, 5, 7, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (14, 1, 5, 8, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (15, 1, 5, 12, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (16, 15, 11, 13, N'A-30')
INSERT [dbo].[DetalleFactura] ([id_DetalleFactura], [cantidadMuebles], [id_mueble], [id_Factura], [id_Serie]) VALUES (17, 5, 11, 15, N'A-30')
SET IDENTITY_INSERT [dbo].[DetalleFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallePedido] ON 

INSERT [dbo].[DetallePedido] ([id_DetallePedido], [CantidadProducto], [id_Pedido], [id_mueble]) VALUES (1, 20, 1, 3)
INSERT [dbo].[DetallePedido] ([id_DetallePedido], [CantidadProducto], [id_Pedido], [id_mueble]) VALUES (2, 30, 2, 14)
SET IDENTITY_INSERT [dbo].[DetallePedido] OFF
GO
SET IDENTITY_INSERT [dbo].[DireccionEntrega] ON 

INSERT [dbo].[DireccionEntrega] ([id_DirecciónEntrega], [Direccion], [id_Cliente]) VALUES (1, N'4 calle Zona 3 San Marcos, San Marcos', 1)
INSERT [dbo].[DireccionEntrega] ([id_DirecciónEntrega], [Direccion], [id_Cliente]) VALUES (2, N'19 Calle 7-87 zona 10 Quetgo, Quetgo', 2)
INSERT [dbo].[DireccionEntrega] ([id_DirecciónEntrega], [Direccion], [id_Cliente]) VALUES (3, N'8va Calle 7-87 Xela', 1)
INSERT [dbo].[DireccionEntrega] ([id_DirecciónEntrega], [Direccion], [id_Cliente]) VALUES (4, N'Universidad mesoamericana', 3)
INSERT [dbo].[DireccionEntrega] ([id_DirecciónEntrega], [Direccion], [id_Cliente]) VALUES (5, N'SSan Marcos', 4)
INSERT [dbo].[DireccionEntrega] ([id_DirecciónEntrega], [Direccion], [id_Cliente]) VALUES (7, N'4 calle zona 4 Salcajá', 6)
SET IDENTITY_INSERT [dbo].[DireccionEntrega] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id_Empleado], [Nombre], [Telefono], [Correo], [Estado]) VALUES (1, N'Juan Jose', N'77609876', N'juanjo@gmail.com', 1)
INSERT [dbo].[Empleado] ([id_Empleado], [Nombre], [Telefono], [Correo], [Estado]) VALUES (2, N'Valeria Valle', N'76341257', N'vale123@gmail.com', 1)
INSERT [dbo].[Empleado] ([id_Empleado], [Nombre], [Telefono], [Correo], [Estado]) VALUES (3, N'Gabriela Sandoval', N'99347512', N'Gabi@gmail.com', 1)
INSERT [dbo].[Empleado] ([id_Empleado], [Nombre], [Telefono], [Correo], [Estado]) VALUES (4, N'Jesus Sarti', N'78435567', N'Ye@gmail.com', 1)
INSERT [dbo].[Empleado] ([id_Empleado], [Nombre], [Telefono], [Correo], [Estado]) VALUES (5, N'Ottoniel Dominguez', N'12341234', N'otto@gmail.com', 1)
INSERT [dbo].[Empleado] ([id_Empleado], [Nombre], [Telefono], [Correo], [Estado]) VALUES (6, N'Santiago López', N'40781234', N'santiagol@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Entrega] ON 

INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (1, N'Casa amarilla a 2 cuadras de Restaurante Comida, cuidado con el perro', N'43125789', CAST(N'2024-10-20' AS Date), CAST(N'08:00:00' AS Time), 1, 3, 1)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (4, N'Enfrente de una iglesia', N'12345678', CAST(N'2024-10-23' AS Date), CAST(N'12:30:00' AS Time), 1, 2, 1)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (5, N'Enfrente de una abarrotería', N'12345678', CAST(N'2024-10-31' AS Date), CAST(N'12:35:00' AS Time), 1, 3, 2)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (6, N'Enfrente de un árbol', N'12345678', CAST(N'2024-10-31' AS Date), CAST(N'12:35:00' AS Time), 1, 1, 3)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (7, N'Entrega prueba', N'12312312', CAST(N'2024-10-29' AS Date), CAST(N'11:25:00' AS Time), 1, 3, 4)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (8, N'hola', N'12345678', CAST(N'2024-10-23' AS Date), CAST(N'13:30:00' AS Time), 1, 2, 1)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (12, N'', N'', CAST(N'2024-10-23' AS Date), CAST(N'12:40:00' AS Time), 1, 2, 1)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (13, N'Entrega en una casa', N'44554455', CAST(N'2024-11-15' AS Date), CAST(N'13:55:00' AS Time), 1, 3, 5)
INSERT [dbo].[Entrega] ([id_Entrega], [DescripcionEntrega], [TelefonoReferencia], [fechaEntrega], [horaEntrega], [Estado], [id_EstadoPedido], [id_DirecciónEntrega]) VALUES (15, N'Casa en la esquina de la cuadra', N'98989898', CAST(N'2024-11-25' AS Date), CAST(N'10:45:00' AS Time), 1, 1, 7)
SET IDENTITY_INSERT [dbo].[Entrega] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoPedido_Entrega] ON 

INSERT [dbo].[EstadoPedido_Entrega] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (1, N'Facturado', 1)
INSERT [dbo].[EstadoPedido_Entrega] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (2, N'Entregado', 1)
INSERT [dbo].[EstadoPedido_Entrega] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (3, N'Cancelado', 1)
INSERT [dbo].[EstadoPedido_Entrega] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (4, N'Enviado', 1)
SET IDENTITY_INSERT [dbo].[EstadoPedido_Entrega] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoPedido_Proveedor] ON 

INSERT [dbo].[EstadoPedido_Proveedor] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (1, N'En Proceso', 1)
INSERT [dbo].[EstadoPedido_Proveedor] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (2, N'Recibido Completo', 1)
INSERT [dbo].[EstadoPedido_Proveedor] ([id_EstadoPedido], [Nombre_EstadoPedido], [Estado]) VALUES (3, N'Cancelado', 1)
SET IDENTITY_INSERT [dbo].[EstadoPedido_Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (1, N'A-23', CAST(N'2024-10-23T10:32:23.580' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, 1, 4, 1)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (4, N'A-30', CAST(N'2024-10-23T10:53:09.613' AS DateTime), CAST(550.00 AS Decimal(10, 2)), CAST(550.00 AS Decimal(10, 2)), 1, 1, 1, 4)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (5, N'A-30', CAST(N'2024-10-23T11:04:01.970' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, 2, 1, 5)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (6, N'A-30', CAST(N'2024-10-23T11:15:02.783' AS DateTime), CAST(520.00 AS Decimal(10, 2)), CAST(520.00 AS Decimal(10, 2)), 1, 1, 1, 6)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (7, N'A-30', CAST(N'2024-10-23T11:28:20.770' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, 3, 1, 7)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (8, N'A-30', CAST(N'2024-10-23T11:46:49.793' AS DateTime), CAST(120.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), 1, 1, 1, 8)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (12, N'A-30', CAST(N'2024-10-23T11:55:11.330' AS DateTime), CAST(120.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), 1, 1, 4, 12)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (13, N'A-30', CAST(N'2024-11-11T18:39:37.273' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, 4, 4, 13)
INSERT [dbo].[Factura] ([id_Factura], [id_Serie], [fechaFactura], [montoTotal], [totalSinDescuento], [Estado], [id_Cliente], [id_Usuario], [id_Domicilio]) VALUES (15, N'A-30', CAST(N'2024-11-14T07:56:33.800' AS DateTime), CAST(500.00 AS Decimal(10, 2)), CAST(500.00 AS Decimal(10, 2)), 1, 6, 1, 15)
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([id_Marca], [marca], [Estado]) VALUES (1, N'Arketipo', 1)
INSERT [dbo].[Marca] ([id_Marca], [marca], [Estado]) VALUES (2, N'MueblesGT', 1)
INSERT [dbo].[Marca] ([id_Marca], [marca], [Estado]) VALUES (3, N'Muebles', 0)
INSERT [dbo].[Marca] ([id_Marca], [marca], [Estado]) VALUES (4, N'MuebleriaLosAltos', 1)
INSERT [dbo].[Marca] ([id_Marca], [marca], [Estado]) VALUES (5, N'Casa Bella', 1)
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelo] ON 

INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (1, N'Silla de Oficina', 1, 1, 1)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (2, N'Sofa Moderno', 1, 1, 2)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (3, N'Mesa de Centro', 1, 2, 3)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (4, N'Cama Doble', 1, 4, 4)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (5, N'Closet Empotrado', 1, 5, 5)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (6, N'Lámpara de Techo', 1, 4, 6)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (7, N'Cama Sofa Versátil', 1, 1, 7)
INSERT [dbo].[Modelo] ([id_Modelo], [modelo], [Estado], [id_Marca], [id_Categoria]) VALUES (8, N'Litera Infantil', 1, 5, 8)
SET IDENTITY_INSERT [dbo].[Modelo] OFF
GO
SET IDENTITY_INSERT [dbo].[Muebles] ON 

INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (1, N'Silla Moderna - Apoyabrazos', N'Silla Moderna con apoyabrazos', 150, CAST(0.00 AS Decimal(3, 2)), 5, 24, 1, 1)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (2, N'Silla Moderna - Sin Apoyabrazos', N'Silla Moderna sin apoyabrazos', 130, CAST(0.00 AS Decimal(3, 2)), 5, 24, 1, 1)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (3, N'Sofa Clásico - Dos plazas', N'Sofa Clásico de dos plazas', 400, CAST(0.00 AS Decimal(3, 2)), 2, 36, 1, 2)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (4, N'Sofa Clásico - Tres plazas', N'Sofa Clásico de tres plazas', 500, CAST(0.00 AS Decimal(3, 2)), 2, 36, 1, 2)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (5, N'Mesa de Centro - Rectangular', N'Mesa de Centro rectangular', 120, CAST(0.00 AS Decimal(3, 2)), 3, 12, 1, 3)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (6, N'Mesa de Centro - Circular', N'Mesa de Centro circular', 140, CAST(0.00 AS Decimal(3, 2)), 3, 12, 1, 3)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (7, N'Cama King Size - Cabecero', N'Cama King Size con cabecero', 800, CAST(0.00 AS Decimal(3, 2)), 1, 60, 1, 4)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (8, N'Cama King Size - Sin Cabecero', N'Cama King Size sin cabecero', 750, CAST(0.00 AS Decimal(3, 2)), 1, 60, 1, 4)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (9, N'Closet Empotrado - Madera', N'Closet Empotrado de madera', 600, CAST(0.00 AS Decimal(3, 2)), 2, 48, 1, 5)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (10, N'Closet Empotrado - Metal', N'Closet Empotrado de metal', 650, CAST(0.00 AS Decimal(3, 2)), 2, 48, 1, 5)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (11, N'Lámpara LED - Pie', N'Lámpara LED de pie', 100, CAST(0.00 AS Decimal(3, 2)), 10, 12, 1, 6)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (12, N'Lámpara LED - Mesa', N'Lámpara LED de mesa', 80, CAST(0.00 AS Decimal(3, 2)), 10, 12, 1, 6)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (13, N'Litera Compacta - Escritorio', N'Litera Compacta con escritorio', 300, CAST(0.00 AS Decimal(3, 2)), 2, 36, 1, 7)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (14, N'Litera Compacta - Sin Escritorio', N'Litera Compacta sin escritorio', 280, CAST(0.00 AS Decimal(3, 2)), 2, 36, 1, 7)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (15, N'Sofa Cama Deluxe - Cuero', N'Sofa Cama Deluxe de cuero', 600, CAST(0.00 AS Decimal(3, 2)), 2, 48, 1, 8)
INSERT [dbo].[Muebles] ([id_mueble], [Nombre], [Descripcion], [PrecioVenta], [Descuento], [ExistenciaMinima], [TiempoGarantia], [Estado], [id_Modelo]) VALUES (16, N'Sofa Cama Deluxe - Tela', N'Sofa Cama Deluxe de tela', 550, CAST(0.00 AS Decimal(3, 2)), 2, 48, 1, 8)
SET IDENTITY_INSERT [dbo].[Muebles] OFF
GO
SET IDENTITY_INSERT [dbo].[Pago] ON 

INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (1, CAST(50.00 AS Decimal(4, 2)), CAST(2850.00 AS Decimal(18, 2)), 1, 1, N'A-23')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (2, CAST(50.00 AS Decimal(4, 2)), CAST(2850.00 AS Decimal(18, 2)), 3, 1, N'A-23')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (5, CAST(0.00 AS Decimal(4, 2)), CAST(250.00 AS Decimal(18, 2)), 5, 4, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (6, CAST(0.00 AS Decimal(4, 2)), CAST(250.00 AS Decimal(18, 2)), 1, 4, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (7, CAST(0.00 AS Decimal(4, 2)), CAST(50.00 AS Decimal(18, 2)), 4, 4, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (8, CAST(0.00 AS Decimal(4, 2)), CAST(70.00 AS Decimal(18, 2)), 1, 5, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (9, CAST(0.00 AS Decimal(4, 2)), CAST(200.00 AS Decimal(18, 2)), 4, 5, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (10, CAST(0.00 AS Decimal(4, 2)), CAST(520.00 AS Decimal(18, 2)), 1, 6, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (11, CAST(0.00 AS Decimal(4, 2)), CAST(600.00 AS Decimal(18, 2)), 3, 7, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (12, CAST(0.00 AS Decimal(4, 2)), CAST(120.00 AS Decimal(18, 2)), 4, 8, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (13, CAST(0.00 AS Decimal(4, 2)), CAST(120.00 AS Decimal(18, 2)), 2, 12, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (14, CAST(0.00 AS Decimal(4, 2)), CAST(300.00 AS Decimal(18, 2)), 2, 13, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (15, CAST(0.00 AS Decimal(4, 2)), CAST(700.00 AS Decimal(18, 2)), 1, 13, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (16, CAST(0.00 AS Decimal(4, 2)), CAST(500.00 AS Decimal(18, 2)), 6, 13, N'A-30')
INSERT [dbo].[Pago] ([id_Pago], [porcentaje], [cantidad], [id_TipoPago], [id_Factura], [id_Serie]) VALUES (17, CAST(0.00 AS Decimal(4, 2)), CAST(500.00 AS Decimal(18, 2)), 1, 15, N'A-30')
SET IDENTITY_INSERT [dbo].[Pago] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([id_Pedido], [Descripcion], [FechaPedido], [FechaRecibido], [CantidadPedido], [CantidadRecibido], [TotalPagar], [Estado], [id_EstadoPedido], [id_TipoPago], [id_Proveedor]) VALUES (1, N'', CAST(N'2024-11-13' AS Date), NULL, 20, 20, CAST(8000.00 AS Decimal(10, 2)), 1, 2, 1, 3)
INSERT [dbo].[Pedido] ([id_Pedido], [Descripcion], [FechaPedido], [FechaRecibido], [CantidadPedido], [CantidadRecibido], [TotalPagar], [Estado], [id_EstadoPedido], [id_TipoPago], [id_Proveedor]) VALUES (2, N'Pedido a muebles fiesta', CAST(N'2024-11-14' AS Date), NULL, 30, 5, CAST(8400.00 AS Decimal(10, 2)), 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_Proveedor], [proveedor], [Direccion], [Telefono], [TelefonoExtra], [Correo], [Estado]) VALUES (1, N'Muebles fiesta', N'18 Av 8-78 zona 1 Quetgo', N'12345678', N'87654321', N'mueblesFiesta@gmail.com', 1)
INSERT [dbo].[Proveedor] ([id_Proveedor], [proveedor], [Direccion], [Telefono], [TelefonoExtra], [Correo], [Estado]) VALUES (2, N'Muebles Occidente', N'6 Calle 1-23 zona 3 Totonicapan', N'24681024', N'42018642', N'occMubles@gmail.com', 1)
INSERT [dbo].[Proveedor] ([id_Proveedor], [proveedor], [Direccion], [Telefono], [TelefonoExtra], [Correo], [Estado]) VALUES (3, N'La bendicion Muebleria', N'7 Av 4-12 zona 7 San Marcos', N'21252426', N'26242521', N'laBendiMuebles@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([id_Rol], [nombre_Rol], [Estado]) VALUES (1, N'Administrador', 1)
INSERT [dbo].[Rol] ([id_Rol], [nombre_Rol], [Estado]) VALUES (2, N'Bodeguero', 1)
INSERT [dbo].[Rol] ([id_Rol], [nombre_Rol], [Estado]) VALUES (3, N'Vendedor', 1)
INSERT [dbo].[Rol] ([id_Rol], [nombre_Rol], [Estado]) VALUES (4, N'Gerente', 1)
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
INSERT [dbo].[SerieFactura] ([id_Serie], [fechaInicio], [Estado]) VALUES (N'A-23', CAST(N'2024-10-05T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[SerieFactura] ([id_Serie], [fechaInicio], [Estado]) VALUES (N'A-30', CAST(N'2024-08-01T00:00:00' AS SmallDateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (1, 20, 3, CAST(N'2024-05-15' AS Date), 1, 1)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (2, 30, 11, CAST(N'2024-07-20' AS Date), 1, 1)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (3, 15, 0, CAST(N'2024-03-10' AS Date), 1, 2)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (4, 10, 1, CAST(N'2024-06-18' AS Date), 1, 3)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (5, 5, 2, CAST(N'2024-08-10' AS Date), 1, 3)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (6, 8, 0, CAST(N'2024-04-22' AS Date), 1, 4)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (7, 12, 0, CAST(N'2024-05-25' AS Date), 1, 5)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (8, 10, 7, CAST(N'2024-06-30' AS Date), 1, 5)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (9, 20, 10, CAST(N'2024-04-12' AS Date), 1, 6)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (10, 5, 0, CAST(N'2024-02-15' AS Date), 1, 7)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (11, 8, 6, CAST(N'2024-07-01' AS Date), 1, 7)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (12, 6, 0, CAST(N'2024-03-10' AS Date), 1, 8)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (13, 10, 3, CAST(N'2024-01-25' AS Date), 1, 9)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (14, 7, 0, CAST(N'2024-06-05' AS Date), 1, 10)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (15, 25, 10, CAST(N'2024-03-20' AS Date), 1, 11)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (16, 20, 0, CAST(N'2024-04-01' AS Date), 1, 12)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (17, 10, 4, CAST(N'2024-05-11' AS Date), 1, 13)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (18, 15, 8, CAST(N'2024-06-15' AS Date), 1, 13)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (19, 12, 0, CAST(N'2024-02-28' AS Date), 1, 14)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (20, 18, 9, CAST(N'2024-04-22' AS Date), 1, 15)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (21, 10, 0, CAST(N'2024-03-18' AS Date), 1, 16)
INSERT [dbo].[Stock] ([id_Stock], [CantidadInicial], [CantidadStock], [FechaIngreso], [Estado], [id_mueble]) VALUES (22, 20, 20, CAST(N'2024-11-14' AS Date), 1, 3)
SET IDENTITY_INSERT [dbo].[Stock] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoPago] ON 

INSERT [dbo].[TipoPago] ([id_TipoPago], [Nombre_TipoPago], [Estado]) VALUES (1, N'Efectivo', 1)
INSERT [dbo].[TipoPago] ([id_TipoPago], [Nombre_TipoPago], [Estado]) VALUES (2, N'Tarjeta de crédito', 1)
INSERT [dbo].[TipoPago] ([id_TipoPago], [Nombre_TipoPago], [Estado]) VALUES (3, N'Tarjeta de Débito', 1)
INSERT [dbo].[TipoPago] ([id_TipoPago], [Nombre_TipoPago], [Estado]) VALUES (4, N'Apple Pay', 1)
INSERT [dbo].[TipoPago] ([id_TipoPago], [Nombre_TipoPago], [Estado]) VALUES (5, N'Google Pay', 1)
INSERT [dbo].[TipoPago] ([id_TipoPago], [Nombre_TipoPago], [Estado]) VALUES (6, N'PayPal', 1)
SET IDENTITY_INSERT [dbo].[TipoPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_Usuario], [Usuario], [Password], [Estado], [id_Rol], [id_Empleado]) VALUES (1, N'Admin', 0xE1223D9BBCD82236F9F09AE1F5578E3CBBD4E8F48954CEAD3003BE60AC85629726DC04B1F875353459F97BA4A4283A1A6ADB89D3524BB4816C7125964097106C, 1, 1, 6)
INSERT [dbo].[Usuario] ([id_Usuario], [Usuario], [Password], [Estado], [id_Rol], [id_Empleado]) VALUES (2, N'ValeriaV', 0x2E15C943B679F39B07F0E79E4293EBA6F7338159970C77A94018569F577E7025697545AD443556FE92361B83F21435EAB253DBBA5E41EBB636B633241209A4FF, 1, 2, 2)
INSERT [dbo].[Usuario] ([id_Usuario], [Usuario], [Password], [Estado], [id_Rol], [id_Empleado]) VALUES (3, N'Jesus', 0xD5BFF99428217F82ABCA99105A51254B654BE9A96145E3BFBEBADCF4EC36D1B021ED05A1ADB978C2AB08E896F3EC3CB8EE5DC6B161C06F1744AAFF367ECB4CBF, 1, 1, 4)
INSERT [dbo].[Usuario] ([id_Usuario], [Usuario], [Password], [Estado], [id_Rol], [id_Empleado]) VALUES (4, N'Otto', 0xAAFF9106875B7964E8991352C0C0E4E8DB27A94E76086C993BC2470DBFF0C8CFCD1524D0C358424288B4E552F5D1A31274960BC43905763B1633F246A975FB73, 1, 3, 5)
INSERT [dbo].[Usuario] ([id_Usuario], [Usuario], [Password], [Estado], [id_Rol], [id_Empleado]) VALUES (5, N'juanjo', 0x7DDE3B93B0A76254ECF6AFF493067453F763DD9FFBBE99BA6228D66CF3C353C17E34E121385DC01C29DA7541BD342ED99D4DBB66936246FEC33FD41367E80E7D, 1, 4, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT ((0)) FOR [Descuentos]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Entrega] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[EstadoPedido_Entrega] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[EstadoPedido_Proveedor] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Marca] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Modelo] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Muebles] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Pedido] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Rol] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[TipoPago] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [Relationship11] FOREIGN KEY([id_mueble])
REFERENCES [dbo].[Muebles] ([id_mueble])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [Relationship11]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [Relationship12] FOREIGN KEY([id_Factura])
REFERENCES [dbo].[Factura] ([id_Factura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [Relationship12]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [Relationship10] FOREIGN KEY([id_mueble])
REFERENCES [dbo].[Muebles] ([id_mueble])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [Relationship10]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [Relationship9] FOREIGN KEY([id_Pedido])
REFERENCES [dbo].[Pedido] ([id_Pedido])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [Relationship9]
GO
ALTER TABLE [dbo].[DireccionEntrega]  WITH CHECK ADD  CONSTRAINT [Relationship23] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([id_Cliente])
GO
ALTER TABLE [dbo].[DireccionEntrega] CHECK CONSTRAINT [Relationship23]
GO
ALTER TABLE [dbo].[Entrega]  WITH CHECK ADD  CONSTRAINT [Relationship21] FOREIGN KEY([id_EstadoPedido])
REFERENCES [dbo].[EstadoPedido_Entrega] ([id_EstadoPedido])
GO
ALTER TABLE [dbo].[Entrega] CHECK CONSTRAINT [Relationship21]
GO
ALTER TABLE [dbo].[Entrega]  WITH CHECK ADD  CONSTRAINT [Relationship24] FOREIGN KEY([id_DirecciónEntrega])
REFERENCES [dbo].[DireccionEntrega] ([id_DirecciónEntrega])
GO
ALTER TABLE [dbo].[Entrega] CHECK CONSTRAINT [Relationship24]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Relationship13] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([id_Cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Relationship13]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Relationship16] FOREIGN KEY([id_Usuario])
REFERENCES [dbo].[Usuario] ([id_Usuario])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Relationship16]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Relationship18] FOREIGN KEY([id_Serie])
REFERENCES [dbo].[SerieFactura] ([id_Serie])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Relationship18]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Relationship22] FOREIGN KEY([id_Domicilio])
REFERENCES [dbo].[Entrega] ([id_Entrega])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Relationship22]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [Relationship1] FOREIGN KEY([id_Marca])
REFERENCES [dbo].[Marca] ([id_Marca])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [Relationship1]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [Relationship4] FOREIGN KEY([id_Categoria])
REFERENCES [dbo].[Categoria] ([id_Categoria])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [Relationship4]
GO
ALTER TABLE [dbo].[Muebles]  WITH CHECK ADD  CONSTRAINT [Relationship2] FOREIGN KEY([id_Modelo])
REFERENCES [dbo].[Modelo] ([id_Modelo])
GO
ALTER TABLE [dbo].[Muebles] CHECK CONSTRAINT [Relationship2]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([id_Factura])
REFERENCES [dbo].[Factura] ([id_Factura])
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([id_Serie])
REFERENCES [dbo].[SerieFactura] ([id_Serie])
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([id_TipoPago])
REFERENCES [dbo].[TipoPago] ([id_TipoPago])
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [Relationship6] FOREIGN KEY([id_EstadoPedido])
REFERENCES [dbo].[EstadoPedido_Proveedor] ([id_EstadoPedido])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [Relationship6]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [Relationship7] FOREIGN KEY([id_TipoPago])
REFERENCES [dbo].[TipoPago] ([id_TipoPago])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [Relationship7]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [Relationship8] FOREIGN KEY([id_Proveedor])
REFERENCES [dbo].[Proveedor] ([id_Proveedor])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [Relationship8]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [Relationship5] FOREIGN KEY([id_mueble])
REFERENCES [dbo].[Muebles] ([id_mueble])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [Relationship5]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([id_Empleado])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([id_Rol])
REFERENCES [dbo].[Rol] ([id_Rol])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Relationship14] FOREIGN KEY([id_Rol])
REFERENCES [dbo].[Rol] ([id_Rol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Relationship14]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Relationship15] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([id_Empleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Relationship15]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCategoria]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para actualizar una Categor�a
Create PROC [dbo].[ActualizarCategoria]
@id_Categoria int,
@Categoria varchar (25),
@Estado bit
AS BEGIN
	UPDATE Categoria SET
	categoria=@Categoria,
	Estado=@Estado
	WHERE id_Categoria = @id_Categoria
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCompraYCrearStock]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCompraYCrearStock]
    @id_Pedido INT,
    @CantidadRecibido INT,
    @FechaIngreso DATE = NULL,
    @resultado VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN actualizacion_compra
    BEGIN TRY
        DECLARE @CantidadPedido INT, @id_EstadoPedido INT;

        SELECT @CantidadPedido = CantidadPedido, @id_EstadoPedido = id_EstadoPedido
        FROM Pedido
        WHERE id_Pedido = @id_Pedido;

        UPDATE Pedido
        SET CantidadRecibido = @CantidadRecibido
        WHERE id_Pedido = @id_Pedido;

        IF @CantidadRecibido >= @CantidadPedido
        BEGIN
            UPDATE Pedido
            SET id_EstadoPedido = 2
            WHERE id_Pedido = @id_Pedido;

            INSERT INTO Stock (CantidadInicial, CantidadStock, FechaIngreso, Estado, id_mueble)
            SELECT CantidadProducto, CantidadProducto, GETDATE(), 1, id_mueble
            FROM DetallePedido
            WHERE id_Pedido = @id_Pedido;

            SET @resultado = 'Compra actualizada y stock creado';
        END
        ELSE
        BEGIN
            SET @resultado = 'Cantidad recibida actualizada, pero aún incompleta';
        END

        COMMIT TRAN actualizacion_compra;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN actualizacion_compra;
        SET @resultado = 'Ocurrió un error: ' + ERROR_MESSAGE();
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEmpleado]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para actualizar un Empleado
Create PROC [dbo].[ActualizarEmpleado]
@id_Empleado int,
@Nombre varchar (150),
@Telefono varchar (8),
@Correo varchar (100),
@Estado bit
AS BEGIN
	UPDATE Empleado SET
	Nombre=@Nombre,
	Telefono=@Telefono,
	Correo=@Correo,
	Estado=@Estado
	WHERE id_Empleado = @id_Empleado
END;
GO
/****** Object:  StoredProcedure [dbo].[actualizarInventario]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado para actualizar Stocks usando FIFO

CREATE procedure [dbo].[actualizarInventario]
	@productos udt_DetalleFactura READONLY
	--@inventario udtInventario READONLY
	AS 
	BEGIN 
	DECLARE @id_mueble INT;
    DECLARE @cantidad INT;
    DECLARE @cantidadRestante INT;
    DECLARE @id_Stock INT;
    DECLARE @CantidadStock INT;

  
    DECLARE productos_cursor CURSOR FOR
    SELECT id_mueble, cantidad
    FROM @productos;

    OPEN productos_cursor;

    FETCH NEXT FROM productos_cursor INTO @id_mueble, @cantidad;

   
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @cantidadRestante = @cantidad;

      
        DECLARE stock_cursor CURSOR FOR
        SELECT id_Stock, CantidadStock
        FROM Stock
        WHERE id_mueble = @id_mueble
          AND CantidadStock > 0
        ORDER BY FechaIngreso ASC;

        OPEN stock_cursor;

        FETCH NEXT FROM stock_cursor INTO @id_Stock, @CantidadStock;

       
        WHILE @@FETCH_STATUS = 0 AND @cantidadRestante > 0
        BEGIN
            IF @CantidadStock >= @cantidadRestante
            BEGIN
               
                UPDATE Stock
                SET CantidadStock = CantidadStock - @cantidadRestante
                WHERE id_Stock = @id_Stock;
                
                SET @cantidadRestante = 0; 
            END
            ELSE
            BEGIN
                
                UPDATE Stock
                SET CantidadStock = 0
                WHERE id_Stock = @id_Stock;
                
                SET @cantidadRestante = @cantidadRestante - @CantidadStock;
            END

            FETCH NEXT FROM stock_cursor INTO @id_Stock, @CantidadStock;
        END

        CLOSE stock_cursor;
        DEALLOCATE stock_cursor;

        
        FETCH NEXT FROM productos_cursor INTO @id_mueble, @cantidad;
    END

    CLOSE productos_cursor;
    DEALLOCATE productos_cursor;
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarMarca]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para actualizar una Marca
Create PROC [dbo].[ActualizarMarca]
@id_Marca int,
@Marca varchar (50),
@Estado bit
AS BEGIN
	UPDATE Marca SET
	marca=@Marca,
	Estado=@Estado
	WHERE id_Marca = @id_Marca
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProveedor]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para actualizar un Proveedor
Create PROC [dbo].[ActualizarProveedor]
@id_Proveedor int,
@Proveedor varchar(75),
@Direccion varchar(75),
@Telefono varchar(15),
@TelefonoExtra varchar(15),
@Correo varchar(35),
@Estado bit
AS BEGIN
	UPDATE Proveedor SET
	proveedor=@Proveedor,
	Direccion=@Direccion,
	Telefono=@Telefono,
	TelefonoExtra=@TelefonoExtra,
	Correo=@Correo,
	Estado=@Estado
	WHERE id_Proveedor = @id_Proveedor
END;
GO
/****** Object:  StoredProcedure [dbo].[anularFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[anularFactura](
	@idFactura int = 1
)

AS
BEGIN

	DECLARE @idEntrega AS INT
	
	DECLARE @id_mueble AS INT
    DECLARE @cantidad AS INT
    DECLARE @cantidadRestante AS INT
	DECLARE @cantidadInicial AS INT
    DECLARE @id_Stock AS INT
    DECLARE @CantidadStock AS INT
	
	

	

	UPDATE Factura set Estado = 0, montoTotal = 0, totalSinDescuento = 0 
	where id_Factura = @idFactura
	

	select @idEntrega = id_entrega from Entrega inner join 
	Factura on Factura.id_Domicilio = Entrega.id_Entrega where Factura.id_Factura = @idFactura
	


	
	UPDATE Entrega set id_EstadoPedido = 3 where id_Entrega = @idEntrega

	
	DECLARE productos_cursor CURSOR FOR
    SELECT id_mueble, cantidadMuebles
    FROM DetalleFactura
	where id_Factura = @idFactura

    OPEN productos_cursor
    FETCH NEXT FROM productos_cursor INTO @id_mueble, @cantidad

	WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @cantidadRestante = @cantidad

        DECLARE stock_cursor CURSOR FOR
        SELECT id_Stock, CantidadStock, CantidadInicial
        FROM Stock
        WHERE id_mueble = @id_mueble
        ORDER BY FechaIngreso DESC

        OPEN stock_cursor
        FETCH NEXT FROM stock_cursor INTO @id_Stock, @CantidadStock, @CantidadInicial

        
        WHILE @@FETCH_STATUS = 0 AND @cantidadRestante > 0
        BEGIN
            DECLARE @espacioDisponible INT
            SET @espacioDisponible = @CantidadInicial - @CantidadStock

            IF @espacioDisponible >= @cantidadRestante
            BEGIN
                
                UPDATE Stock
                SET CantidadStock = CantidadStock + @cantidadRestante
                WHERE id_Stock = @id_Stock
                
                SET @cantidadRestante = 0 
            END
            ELSE
            BEGIN
                
                UPDATE Stock
                SET CantidadStock = @CantidadInicial
                WHERE id_Stock = @id_Stock

                SET @cantidadRestante = @cantidadRestante - @espacioDisponible
            END

            
            FETCH NEXT FROM stock_cursor INTO @id_Stock, @CantidadStock, @CantidadInicial
        END

        CLOSE stock_cursor
        DEALLOCATE stock_cursor

        
        FETCH NEXT FROM productos_cursor INTO @id_mueble, @cantidad
    END

    CLOSE productos_cursor
    DEALLOCATE productos_cursor



	

END

GO
/****** Object:  StoredProcedure [dbo].[BuscarClientePorNit]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Procedimiento para buscar Cliente por Nit
CREATE PROC [dbo].[BuscarClientePorNit]
@nit varchar (8)
AS BEGIN
SELECT * FROM Cliente
WHERE  NIT LIKE @nit;
END;
GO
/****** Object:  StoredProcedure [dbo].[BuscarClientePorNombre]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para buscar Cliente por Nombre
CREATE PROC [dbo].[BuscarClientePorNombre]
@nombre_cliente varchar (175)
AS BEGIN
SELECT * FROM CLIENTE
WHERE Nombre_Cliente LIKE @nombre_cliente;
END;
GO
/****** Object:  StoredProcedure [dbo].[BuscarDireccionesEntregaCliente]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para buscar Direcciones de entrega por id_Cliente
CREATE PROC [dbo].[BuscarDireccionesEntregaCliente]
@id_cliente int
AS BEGIN
SELECT 
	DireccionEntrega.id_DirecciónEntrega as 'ID',
	DireccionEntrega.Direccion
FROM DireccionEntrega
	INNER JOIN Cliente on DireccionEntrega.id_Cliente = Cliente.id_Cliente
WHERE 
	DireccionEntrega.id_Cliente = @id_cliente
GROUP BY 
	DireccionEntrega.id_DirecciónEntrega,
	DireccionEntrega.Direccion
HAVING COUNT(*) > 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[BuscarDireccionesEntregaClientePorNombre]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para buscar Direcciones de entrega por id_Cliente
CREATE PROC [dbo].[BuscarDireccionesEntregaClientePorNombre]
    @nombre_cliente VARCHAR(200)
AS
BEGIN
    -- Convertir el nombre de cliente a mayúsculas para la comparación
    SELECT 
        DireccionEntrega.id_DirecciónEntrega AS 'ID',
        DireccionEntrega.Direccion
    FROM 
        DireccionEntrega
    INNER JOIN 
        Cliente ON DireccionEntrega.id_Cliente = Cliente.id_Cliente
    WHERE 
        UPPER(Cliente.Nombre_Cliente) = UPPER(@nombre_cliente);
END
GO
/****** Object:  StoredProcedure [dbo].[CompletarEntrega]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento para filtrar ventas por cliente o numero de factura
CREATE PROCEDURE [dbo].[CompletarEntrega]
@id_Entrega int
AS BEGIN
	UPDATE Entrega SET
	id_EstadoPedido=2
	WHERE id_Entrega = @id_Entrega
END;
GO
/****** Object:  StoredProcedure [dbo].[datosFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[datosFactura]
@idFactura int
AS
BEGIN
select id_Factura, id_Serie, fechaFactura, montoTotal, totalSinDescuento, Nombre_cliente, 
DireccionFacturacion, nit, Nombre from Factura inner join Cliente on Factura.id_Cliente = Cliente.id_Cliente 
inner join usuario on Factura.id_Usuario = Usuario.id_Usuario inner join Empleado on Usuario.id_Empleado = Empleado.id_Empleado
where id_Factura = @idFactura;






select marca, nombre, modelo, DetalleFactura.cantidadMuebles as 'Cantidad', SUM(muebles.PrecioVenta*cantidadMuebles) as 'Total' from Muebles 
		inner join DetalleFactura on DetalleFactura.id_mueble = Muebles.id_mueble inner join Modelo on Muebles.id_Modelo = Modelo.id_Modelo
		inner join Marca on Modelo.id_Marca = marca.id_Marca

		where DetalleFactura.id_Factura = @idFactura
		group by nombre, cantidadMuebles, marca, modelo




select  Nombre_TipoPago, cantidad from TipoPago inner join Pago on TipoPago.id_TipoPago = Pago.id_TipoPago
where pago.id_Factura = @idFactura;



				
		

END


GO
/****** Object:  StoredProcedure [dbo].[EliminarCategoria]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para eliminar categoria
CREATE PROC [dbo].[EliminarCategoria]
@id_Categoria int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Categoria 
    SET Estado = 0
    WHERE id_Categoria = @id_Categoria
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarCompra]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento para eliminar compra
CREATE PROC [dbo].[EliminarCompra]
@id_Pedido int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la compra
    UPDATE Pedido 
    SET Estado = 0
    WHERE id_Pedido = @id_Pedido
END;

GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para eliminar empleado
CREATE PROC [dbo].[EliminarEmpleado]
@id_Empleado int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Empleado 
    SET Estado = 0
    WHERE id_Empleado = @id_Empleado
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarMarca]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[EliminarMarca]
@id_Marca int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Marca 
    SET Estado = 0
    WHERE id_Marca = @id_Marca
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarProveedor]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para eliminar proveedores
CREATE PROC [dbo].[EliminarProveedor]
@id_Proveedor int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar el proveedor
    UPDATE Proveedor 
    SET Estado = 0
    WHERE id_Proveedor = @id_Proveedor
END;
GO
/****** Object:  StoredProcedure [dbo].[estadoProductos]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[estadoProductos] 

as 

BEGIN



select Muebles.Nombre, Nombre_EstadoPedido as 'Estado' from Muebles inner join DetalleFactura on Muebles.id_mueble = DetalleFactura.id_mueble
inner join Factura on Factura.id_Factura = DetalleFactura.id_DetalleFactura
inner join Entrega on Entrega.id_Entrega = Factura.id_Domicilio 
inner join EstadoPedido_Entrega on Entrega.id_EstadoPedido = EstadoPedido_Entrega.id_EstadoPedido
where entrega.id_EstadoPedido = 1 or Entrega.id_EstadoPedido = 4

select Muebles.Nombre, fechaEntrega from Muebles inner join DetalleFactura on Muebles.id_mueble = DetalleFactura.id_mueble
inner join Factura on Factura.id_Factura = DetalleFactura.id_DetalleFactura
inner join Entrega on Entrega.id_Entrega = Factura.id_Domicilio where entrega.id_EstadoPedido = 2
order by fechaEntrega desc




	

END 
GO
/****** Object:  StoredProcedure [dbo].[ExistenciasMuebles]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento para solicitar datos de stock
CREATE PROC [dbo].[ExistenciasMuebles]
AS
SELECT 
        M.id_mueble as 'ID', 
        M.Nombre as 'Nombre', 
		Modelo.modelo as 'Modelo',
        SUM(S.CantidadStock) AS 'Existencias',
		M.PrecioVenta as 'Precio',
		M.TiempoGarantia as 'Garantía',
		M.Descuento as 'Descuento'
    FROM Muebles M
    INNER JOIN  Stock S ON M.id_mueble = S.id_mueble
	INNER JOIN Modelo on M.id_Modelo = Modelo.id_Modelo
    WHERE 
        M.Estado = 1 AND S.Estado = 1 AND S.CantidadStock > 0
	GROUP BY 
        M.id_mueble, 
        M.Nombre,
		Modelo.modelo,
		M.PrecioVenta,
		M.TiempoGarantia,
		M.Descuento
GO
/****** Object:  StoredProcedure [dbo].[GenerarFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GenerarFactura]
@detalle udt_DetalleFactura READONLY, 
@serie varchar(150),
@id_cliente int = 0,
@nombre_cliente varchar(200) = null,
@direccion_Facturacion varchar(30) = null,
@telefono varchar(10) = null,
@correo varchar(50) = null,
@nit varchar(8) = 'CF',
@id_DireccionEntrega int = 0,
@direccionEntrega varchar(150) = null,
@descripcionEntrega varchar(200),
@telefonoReferencia varchar(8),
@fechaEntrega date,
@horaEntrega time,
@idTTipoPago1 int,
@idTTipoPago2 int = null,
@idTipoPago3 int = null,
@cantidad1 as decimal(10,2) = 0,
@cantidad2 as decimal(10,2) = 0,
@cantidad3 as decimal (10,2) =0,
@id_Usuario int,
@resultado varchar(200) OUTPUT
AS
BEGIN
	declare @id_Entrega as int
	
	set NOCOUNT ON
	BEGIN TRAN factura
		Begin Try
	
			

			
			-- Verificar que haya existencias de los productos
			IF EXISTS (SELECT d.id_mueble, SUM(Stock.CantidadStock) AS TotalStock
				FROM Stock INNER JOIN @detalle d ON Stock.id_mueble = d.id_Mueble
				GROUP BY d.id_mueble
				HAVING SUM(Stock.CantidadStock) <=0 or SUM(Stock.CantidadStock) < MAX( d.cantidad)
				)
				BEGIN
					set @resultado = 'No hay Stock suficiente'
					
				END
			
				ELSE
				BEGIN 

					IF (@id_cliente = 0)
					BEGIN 
						IF (@nit = '') set @nit ='CF'
						insert into Cliente (Nombre_Cliente, DireccionFacturacion, Telefono, Correo,Descuentos, NIT, Estado)
						values (@nombre_cliente, @direccion_Facturacion, @telefono, @correo, 0, @nit, 1)
						set @id_cliente = @@IDENTITY
					END
			
					IF (@id_DireccionEntrega = 0) 
						BEGIN
							insert into DireccionEntrega (Direccion, id_Cliente)
							values (@direccionEntrega, @id_cliente)
							set @id_DireccionEntrega = @@IDENTITY
						END

			
					INSERT INTO Entrega (DescripcionEntrega, TelefonoReferencia, Estado, id_EstadoPedido, id_DirecciónEntrega, fechaEntrega, horaEntrega)
					values (@descripcionEntrega, @telefonoReferencia, 1, 1, @id_DireccionEntrega, @fechaEntrega, @horaEntrega)
					set @id_Entrega = @@IDENTITY

					-- Asignación del total a una variable
					declare @total as decimal(10,2)
					select @total = SUM(PrecioVenta*d.cantidad)  from Muebles inner join @detalle d
						on muebles.id_Mueble = d.id_mueble 

					declare @descuento as decimal(10,2)
					select @descuento = SUM(PrecioVenta*d.cantidad*(Descuento/100))  from Muebles inner join @detalle d
						on muebles.id_Mueble = d.id_mueble 


					declare @totalDescuento as decimal(10,2)


					IF exists (select Descuentos from Cliente where id_Cliente = @id_cliente and Descuentos != 0)
						BEGIN 
							declare @descuentoCliente as decimal (3,2)
							select @descuentoCliente = Descuentos from Cliente where id_Cliente = @id_cliente and Descuentos != 0

							set @totalDescuento = @total - @descuento
							set @descuento = @descuento + (@totalDescuento * (@descuentoCliente/100))
							set @totalDescuento =@total - @descuento
						END 

					ELSE 
						BEGIN
							set @totalDescuento = @total - @descuento

						END

					
					
				
				
					insert into Factura (id_Serie, fechaFactura, montoTotal, totalSinDescuento,  Estado, id_Cliente, id_Usuario, id_Domicilio)
					values (@serie, GETDATE(), @totalDescuento, @total, 1, @id_cliente, @id_Usuario, @id_Entrega)

					declare @id_Factura as int
					set @id_Factura= @@IDENTITY

					--Guardar detalle
					insert into DetalleFactura (cantidadMuebles, id_mueble, id_Factura, id_Serie)
					select cantidad, id_mueble, @id_Factura, @serie from @detalle


					--Métodos de pago
					/*IF (@idTTipoPago2 is  null and @idTipoPago3 is null)
						begin
							set @cantidad1 = @totalDescuento
							set @porcentajePago1 = 100
							insert into Pago (porcentaje, cantidad, id_TipoPago, id_Factura, id_Serie)
							values (@porcentajePago1, @cantidad1, @idTTipoPago1, @id_Factura, @serie)
							--select @cantidad1, @cantidad2, @cantidad3
						end

					ELSE IF (@idTipoPago3 is null)
						BEGIN
							set @cantidad1 = @totalDescuento * @porcentajePago1/100
							set @cantidad2 = @totalDescuento * @porcentajePago2/100
							

							IF (@cantidad1 + @cantidad2 != @totalDescuento)
								BEGIN
									IF @cantidad1 < @cantidad2
											set @cantidad1 = @cantidad1 + (@totalDescuento - (@cantidad1 + @cantidad2))
									ELSE
										set @cantidad2 = @cantidad2 + (@totalDescuento - (@cantidad1 + @cantidad2))
					
								END

							insert into Pago (porcentaje, cantidad, id_TipoPago, id_Factura, id_Serie)
							values (@porcentajePago1, @cantidad1, @idTTipoPago1, @id_Factura, @serie),
							(@porcentajePago2, @cantidad2, @idTTipoPago2, @id_Factura, @serie)

		
						END

					ELSE 
						BEGIN
							set @cantidad1 = @totalDescuento * @porcentajePago1/100
							set @cantidad2 = @totalDescuento * @porcentajePago2/100
							set @cantidad3 = @totalDescuento * @porcentajePago3/100

							IF (@cantidad1 + @cantidad2+@cantidad3 != @totalDescuento)
								BEGIN
									IF ((@cantidad1 < @cantidad2) AND (@cantidad1<@cantidad3))
											set @cantidad1 = @cantidad1 + (@totalDescuento - (@cantidad1 + @cantidad2 +@cantidad3))
									ELSE IF ((@cantidad2 < @cantidad1) AND (@cantidad2<@cantidad3))
										set @cantidad2 = @cantidad2 + (@totalDescuento - (@cantidad1 + @cantidad2 +@cantidad3))
									ELSE IF ((@cantidad3 < @cantidad1) AND (@cantidad3<@cantidad2))
										set @cantidad3 = @cantidad3 + (@totalDescuento - (@cantidad1 + @cantidad2 +@cantidad3))
					
								END
			
							insert into Pago (porcentaje, cantidad, id_TipoPago, id_Factura, id_Serie)
							values (@porcentajePago1, @cantidad1, @idTTipoPago1, @id_Factura, @serie),
							(@porcentajePago2, @cantidad2, @idTTipoPago2, @id_Factura, @serie),
							(@porcentajePago3, @cantidad3, @idTipoPago3, @id_Factura, @serie)

						END*/


						if(@cantidad3!=0)
						begin
						insert into Pago (porcentaje, cantidad, id_TipoPago, id_Factura, id_Serie)
							values (0, @cantidad3, @idTipoPago3, @id_Factura, @serie)
						end

						if(@cantidad2!=0)
						begin
						insert into Pago (porcentaje, cantidad, id_TipoPago, id_Factura, id_Serie)
							values (0, @cantidad2, @idTTipoPago2, @id_Factura, @serie)
						end

						if(@cantidad1!=0)
						begin
						insert into Pago (porcentaje, cantidad, id_TipoPago, id_Factura, id_Serie)
							values (0, @cantidad1, @idTTipoPago1, @id_Factura, @serie)
						end


					-- Select para imprimir datos de la factura
					select id_Factura, id_Serie, fechaFactura, montoTotal, totalSinDescuento, Nombre_Cliente, DireccionFacturacion, Usuario	
					from Factura
					inner join Cliente on Cliente.id_Cliente = Factura.id_Cliente 
					inner join usuario on Factura.id_Usuario = usuario.id_Usuario
					where Factura.id_Factura = @id_Factura and Factura.id_Cliente = @id_cliente

					
					
					select muebles.Nombre, d.cantidad, SUM(PrecioVenta*d.cantidad) as 'Total' from Muebles
					inner join @detalle d on Muebles.id_mueble= d.id_Mueble
					group by Muebles.Nombre, d.cantidad

					-- Actualizar inventario (siguiendo el concepto FIFO)
					exec actualizarInventario @productos = @detalle

					set @resultado = 'Se gurado correctamente la factura'

				END

		--insert into DetalleFactura 
		
		COMMIT TRAN factura
	End Try
		
	Begin Catch
		Rollback TRAN factura
		set @resultado = 'Ocurrio un error: ' + ERROR_MESSAGE() + ' en la línea: ' + CONVERT(NVARCHAR(255), ERROR_LINE() ) + '.'
		
	End Catch 

End
GO
/****** Object:  StoredProcedure [dbo].[InsertarCategoria]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para registrar Nueva Categoria
CREATE PROC [dbo].[InsertarCategoria]
@Categoria varchar (25),
@Estado bit
AS
INSERT INTO Categoria 
VALUES (@Categoria, @Estado)
GO
/****** Object:  StoredProcedure [dbo].[InsertarEmpleado]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para registrar Nuevo Empleado
CREATE PROC [dbo].[InsertarEmpleado]
@Nombre varchar (150),
@Telefono varchar (8),
@Correo varchar (100),
@Estado bit
AS
INSERT INTO Empleado 
VALUES (@Nombre, @Telefono, @Correo, @Estado)
GO
/****** Object:  StoredProcedure [dbo].[InsertarMarca]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para registrar Nueva Marca
CREATE PROC [dbo].[InsertarMarca]
@Marca varchar (50),
@Estado bit
AS
INSERT INTO Marca 
VALUES (@Marca, @Estado)
GO
/****** Object:  StoredProcedure [dbo].[InsertarProveedor]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para registrar nuevo Proveedor
CREATE PROC [dbo].[InsertarProveedor]
@Proveedor varchar(75),
@Direccion varchar(75),
@Telefono varchar(15),
@TelefonoExtra varchar(15),
@Correo varchar(35),
@Estado bit
AS
INSERT INTO Proveedor 
VALUES (@Proveedor, @Direccion, @Telefono, @TelefonoExtra, @Correo, @Estado)
GO
/****** Object:  StoredProcedure [dbo].[ListarCategoria]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar Categor�as
CREATE PROC [dbo].[ListarCategoria]
AS
SELECT * FROM Categoria 
WHERE Estado = 1
ORDER BY id_Categoria ASC
GO
/****** Object:  StoredProcedure [dbo].[ListarCompras]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarCompras]
AS
Select
	Pedido.id_Pedido as 'ID',
	Pedido.Descripcion as 'Descripción',
	Pedido.FechaPedido as 'Pedido',
	Pedido.FechaRecibido as 'Recibido',
	Pedido.CantidadPedido as 'CANT Pedido',
	Pedido.CantidadRecibido as 'CANT Recibido',
	Pedido.TotalPagar as 'Pagado',
	EstadoPedido_Proveedor.Nombre_EstadoPedido as 'Estado',
	TipoPago.Nombre_TipoPago as 'Pagado Con',
	Proveedor.proveedor as 'Proveedor'

from Pedido
INNER JOIN EstadoPedido_Proveedor on Pedido.id_EstadoPedido = EstadoPedido_Proveedor.id_EstadoPedido
INNER JOIN TipoPago on Pedido.id_TipoPago = TipoPago.id_TipoPago
INNER JOIN Proveedor on Pedido.id_Proveedor = Proveedor.id_Proveedor
where Pedido.Estado = 1

ORDER BY 
	Pedido.FechaPedido DESC
GO
/****** Object:  StoredProcedure [dbo].[ListarEmpleado]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar Empleado
CREATE PROC [dbo].[ListarEmpleado]
AS
SELECT * FROM Empleado 
WHERE Estado = 1
ORDER BY id_Empleado ASC
GO
/****** Object:  StoredProcedure [dbo].[ListarEntregas]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarEntregas]
AS 
SELECT 
		Factura.id_Factura as 'ID',
		Factura.montoTotal as 'Total',
		Cliente.Nombre_Cliente as 'Compró',
		DireccionEntrega.Direccion as 'Entrega',
        Entrega.DescripcionEntrega,
        Entrega.TelefonoReferencia 'Tel. Referencia',
        Entrega.fechaEntrega as 'Entrega',
        Entrega.horaEntrega as 'Hora Entrega',
		EstadoPedido_Entrega.Nombre_EstadoPedido as 'Estado',
		Entrega.id_Entrega as 'ID_Entrega'
    FROM Factura
	INNER JOIN Entrega on Factura.id_Domicilio = Entrega.id_Entrega
    INNER JOIN DireccionEntrega on Entrega.id_DirecciónEntrega = DireccionEntrega.id_DirecciónEntrega
	INNER JOIN EstadoPedido_Entrega on Entrega.id_EstadoPedido = EstadoPedido_Entrega.id_EstadoPedido
	INNER JOIN Cliente on Factura.id_Cliente = Cliente.id_Cliente
	INNER JOIN Usuario on Factura.id_Usuario = Usuario.id_Usuario

	WHERE Factura.Estado = 1 AND Entrega.Estado = 1 AND EstadoPedido_Entrega.Nombre_EstadoPedido <> 'Entregado'
	ORDER BY Entrega.fechaEntrega DESC;


GO
/****** Object:  StoredProcedure [dbo].[ListarMarca]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PRocedimiento para listar marcas
CREATE PROC [dbo].[ListarMarca]
AS
SELECT * FROM Marca 
WHERE Estado = 1
ORDER BY id_Marca ASC
GO
/****** Object:  StoredProcedure [dbo].[ListarMuebles]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento para listar los muebles
CREATE PROC [dbo].[ListarMuebles]
AS
SELECT 
	Muebles.id_mueble as 'ID',
	Muebles.Nombre as 'Nombre Mueble',
	Muebles.PrecioVenta as 'Precio Venta',
	Muebles.Descuento as 'Descuento',
	Muebles.TiempoGarantia as 'Garantía',
	Modelo.modelo as 'Modelo'
FROM Muebles
INNER JOIN Modelo on Muebles.id_Modelo = Modelo.id_Modelo
	WHERE 
	Muebles.Estado = 1 AND Modelo.Estado = 1
ORDER BY 
	Muebles.id_mueble,
	Muebles.Nombre,
	Muebles.PrecioVenta,
	Muebles.Descuento,
	Muebles.TiempoGarantia
GO
/****** Object:  StoredProcedure [dbo].[ListarProveedor]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar tipos de Proveedores
CREATE PROC [dbo].[ListarProveedor]
AS
SELECT * FROM Proveedor
WHERE Estado = 1
ORDER BY id_Proveedor ASC
GO
/****** Object:  StoredProcedure [dbo].[ListarSeriesDeFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para buscar SerieFactura
CREATE PROC [dbo].[ListarSeriesDeFactura]
AS
Select id_Serie from SerieFactura
ORDER BY fechaInicio ASC
GO
/****** Object:  StoredProcedure [dbo].[ListarTiposPago]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar tipos de pago
CREATE PROC [dbo].[ListarTiposPago]
AS
SELECT 
	id_TipoPago,
	Nombre_TipoPago
FROM TipoPago
WHERE Estado = 1
ORDER BY Nombre_TipoPago ASC
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuarios]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento para listar usuarios

CREATE PROC [dbo].[ListarUsuarios]
AS BEGIN
   select id_Usuario, nombre, usuario, nombre_rol 
   from usuario inner join rol 
   on Usuario.id_Rol = rol.id_Rol 
   inner join Empleado 
   on Empleado.id_Empleado = Usuario.id_Empleado
END;

GO
/****** Object:  StoredProcedure [dbo].[ListarVentas]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar Ventas
CREATE PROC [dbo].[ListarVentas]
AS
Select
	Factura.id_Factura as 'ID',
	Factura.fechaFactura as 'Fecha',
	Factura.montoTotal as 'Total',
	Cliente.Nombre_Cliente as 'Compró',
	Usuario.Usuario as 'Atendió',
	DireccionEntrega.Direccion as 'Entrega'

from Factura
INNER JOIN Cliente on Factura.id_Cliente = Cliente.id_Cliente
INNER JOIN Usuario on Factura.id_Usuario = Usuario.id_Usuario
INNER JOIN Entrega on Factura.id_Domicilio = Entrega.id_Entrega
INNER JOIN DireccionEntrega on Entrega.id_DirecciónEntrega = DireccionEntrega.id_DirecciónEntrega
where factura.Estado = 1

ORDER BY 
	Factura.fechaFactura DESC
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[login] (
@usuario varchar(100), @contrasennia varchar(100)
)

AS 

BEGIN 


declare @respuesta as varchar(100)

	-- Contraseña almacenanda en la base de datos
		declare @contraGuardada as varbinary(1000)
		select @contraGuardada = Password from usuario where usuario = @usuario
		


		declare @contraEncriptada as varbinary(1000)
		set @contraEncriptada = hashbytes('SHA2_512', convert(nvarchar(4000), @contrasennia))
		
		--declare @contraGuardada as varchar(100)
		--set @contraGuardada = convert (varchar(50), DECRYPTBYPASSPHRASE('BaseDeDatos2', @encriptada ))
		

	-- Rol del usuario
		declare @rol as varchar(50)
		declare @idUsuario as int
		
		select @rol =  nombre_Rol from usuario inner join rol on usuario.id_Rol = rol.id_Rol where usuario.Usuario = @usuario
		select @idUsuario = id_Usuario from usuario where usuario.Usuario = @usuario
		
	-- Comparación de la contraseña

		
		If @contraGuardada =@contraEncriptada
			--insert into @tabla values (1, @rol)
			set @respuesta = @rol
		Else
			set @respuesta = '0'
			--insert into @tabla values (0, ' ')

		select @respuesta as 'Rol', @idUsuario as 'IdUsuario'

END
GO
/****** Object:  StoredProcedure [dbo].[p_usuarios]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_usuarios]
(
    @usuario varchar(100), @contrasennia varchar(100), @rol int, @empleado int, @idUsuario int, @opcion int  
)

AS
BEGIN

	declare @encriptado as varbinary(max)

	if @opcion = 1
		begin
			
			set @encriptado = hashbytes('SHA2_512', convert(nvarchar(4000), @contrasennia))
			insert into usuario values ( @usuario,  @encriptado, 1, @rol, @empleado)
		end
	else if @opcion = 2
		begin
			set @encriptado = hashbytes('SHA2_512', convert(nvarchar(4000), @contrasennia))
			update  usuario set Usuario	= @usuario, Usuario.Password =   @encriptado, Estado =  1, id_Rol =  @rol, id_Empleado = @empleado where id_Usuario = @idUsuario
		end
	else if @opcion = 3
		begin
			update usuario set Estado = 0
		end

		select *from Usuario
END;
GO
/****** Object:  StoredProcedure [dbo].[productosMasVendidosPorFecha]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[productosMasVendidosPorFecha] 
(
	@fehcaInicio date = '2024-10-01', @fechaFinal date = '2024-10-30'
)

as

BEGIN
select top(10) Muebles.Nombre, sum(cantidadMuebles*PrecioVenta) as 'Total generado' from muebles inner join DetalleFactura on Muebles.id_mueble = DetalleFactura.id_mueble
inner join Factura on Factura.id_Factura = DetalleFactura.id_Factura
where fechaFactura >= @fehcaInicio and fechaFactura <= @fechaFinal
and Factura.Estado = 1
group by Nombre
order by 'Total generado' desc


END




GO
/****** Object:  StoredProcedure [dbo].[RegistrarCompra]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarCompra]
    @Descripcion VARCHAR(200),
    @FechaPedido DATE = NULL,
    @FechaRecibido DATE = NULL,
    @CantidadPedido INT,
    @CantidadRecibido INT = NULL,
    @TotalPagar DECIMAL(10, 2),
    @Estado BIT,
    @id_EstadoPedido INT,
    @id_TipoPago INT,
    @id_Proveedor INT,
    @DetallePedido udt_DetallePedido READONLY,
    @resultado VARCHAR(200) OUTPUT
AS
BEGIN
    DECLARE @id_Pedido INT;
    SET NOCOUNT ON;
    BEGIN TRAN compra
    BEGIN TRY

        INSERT INTO Pedido (Descripcion, FechaPedido, FechaRecibido, CantidadPedido, CantidadRecibido, TotalPagar, Estado, id_EstadoPedido, id_TipoPago, id_Proveedor)
        VALUES (@Descripcion, GETDATE(), @FechaRecibido, @CantidadPedido, @CantidadRecibido, @TotalPagar, @Estado, @id_EstadoPedido, @id_TipoPago, @id_Proveedor);

        SET @id_Pedido = SCOPE_IDENTITY();

        INSERT INTO DetallePedido (CantidadProducto, id_Pedido, id_mueble)
        SELECT cantidad, @id_Pedido, id_mueble
        FROM @DetallePedido;

        -- Define el resultado según el estado
        IF @CantidadRecibido < @CantidadPedido AND @Estado = 0
        BEGIN
            UPDATE Pedido
            SET Estado = 1
            WHERE id_Pedido = @id_Pedido;
            SET @resultado = 'Compra registrada como pendiente';
        END
        ELSE
        BEGIN
            SET @resultado = 'Compra registrada correctamente';
        END

        COMMIT TRAN compra;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN compra;
        SET @resultado = 'Ocurrió un error: ' + ERROR_MESSAGE();
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[reporteProductosExistencia]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporteProductosExistencia] 


as

BEGIN
	

	select Stock.Id_mueble, Nombre, Modelo, Marca, PrecioVenta, TiempoGarantia,ExistenciaMinima, Sum(CantidadStock) as 'Cantidad Restante' 
	from Muebles inner join Stock on Muebles.id_mueble = Stock.id_mueble
	inner join Modelo on modelo.id_Modelo = Muebles.id_Modelo
	inner join Marca on marca.id_Marca = Modelo.id_Marca
	group by Nombre, PrecioVenta, TiempoGarantia, ExistenciaMinima, Muebles.id_mueble, Stock.id_mueble, modelo, marca
	having sum(CantidadStock) < ExistenciaMinima;

END 
GO
/****** Object:  StoredProcedure [dbo].[totalFactura]    Script Date: 17/11/2024 13:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[totalFactura] 
(
	@fehcaInicio date = '2024-10-01', @fechaFinal date = '2024-10-30'
)

as

BEGIN
select Nombre_TipoPago as 'Metodo', SUM(cantidad)as 'Total' from TipoPago inner join Pago on Pago.id_TipoPago = TipoPago.id_TipoPago
inner join Factura on Factura.id_Factura = Pago.id_Factura where fechaFactura >= @fehcaInicio and fechaFactura <= @fechaFinal
and Factura.Estado = 1
group by Nombre_TipoPago order by 'Total' desc

END




GO
