-- Creaci�n de procedimientos almacenados

USE VentaMuebles
GO

-- Procedimiento para listar tipos de Proveedores
CREATE PROC ListarProveedor
AS
SELECT * FROM Proveedor
WHERE Estado = 1
ORDER BY id_Proveedor ASC
GO

--PRocedimiento para listar marcas
CREATE PROC ListarMarca
AS
SELECT * FROM Marca 
WHERE Estado = 1
ORDER BY id_Marca ASC
GO

-- Procedimiento para listar Categor�as
CREATE PROC ListarCategoria
AS
SELECT * FROM Categoria 
WHERE Estado = 1
ORDER BY id_Categoria ASC
GO

-- Procedimiento para listar Empleado
CREATE PROC ListarEmpleado
AS
SELECT * FROM Empleado 
WHERE Estado = 1
ORDER BY id_Empleado ASC
GO

-- Procedimiento para registrar nuevo Proveedor
CREATE PROC InsertarProveedor
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

-- Procedimiento para registrar Nueva Marca
CREATE PROC InsertarMarca
@Marca varchar (50),
@Estado bit
AS
INSERT INTO Marca 
VALUES (@Marca, @Estado)
GO

-- Procedimiento para registrar Nueva Categoria
CREATE PROC InsertarCategoria
@Categoria varchar (25),
@Estado bit
AS
INSERT INTO Categoria 
VALUES (@Categoria, @Estado)
GO

-- Procedimiento para registrar Nuevo Empleado
CREATE PROC InsertarEmpleado
@Nombre varchar (150),
@Telefono varchar (8),
@Correo varchar (100),
@Estado bit
AS
INSERT INTO Empleado 
VALUES (@Nombre, @Telefono, @Correo, @Estado)
GO

-- Procedimiento para actualizar un Proveedor
Create PROC ActualizarProveedor
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

-- Procedimiento para actualizar una Marca
Create PROC ActualizarMarca
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

-- Procedimiento para actualizar una Categor�a
Create PROC ActualizarCategoria
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

-- Procedimiento para actualizar un Empleado
Create PROC ActualizarEmpleado
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

--Procedimiento para eliminar marcas

CREATE PROC EliminarMarca
@id_Marca int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Marca 
    SET Estado = 0
    WHERE id_Marca = @id_Marca
END;

GO

--Procedimiento para eliminar proveedores
CREATE PROC EliminarProveedor
@id_Proveedor int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar el proveedor
    UPDATE Proveedor 
    SET Estado = 0
    WHERE id_Proveedor = @id_Proveedor
END;
GO

-- Procedimiento almacenado que permite crear un usuario, actualizarlo y deshabilitarlo

/****** Object:  StoredProcedure [dbo].[f_crearUsuario]    Script Date: 4/09/2024 07:43:10 ******/
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
END
GO

-- Procedimiento para listar usuarios
CREATE PROC ListarUsuarios
AS BEGIN
   select id_Usuario, nombre, usuario, nombre_rol 
   from usuario inner join rol 
   on Usuario.id_Rol = rol.id_Rol 
   inner join Empleado 
   on Empleado.id_Empleado = Usuario.id_Empleado
END;

GO

