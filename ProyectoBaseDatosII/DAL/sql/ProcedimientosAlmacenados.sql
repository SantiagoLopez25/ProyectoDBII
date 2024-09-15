-- Creación de procedimientos almacenados

USE VentaMuebles
GO

-- Procedimiento para listar tipos de Proveedores
CREATE PROC ListarProveedor
AS
SELECT * FROM Proveedor ORDER BY id_Proveedor ASC
GO

-- Procedimiento para listar Marcas
CREATE PROC ListarMarca
AS
SELECT * FROM Marca 
WHERE Estado = 1
ORDER BY id_Marca ASC
GO

-- Procedimiento para listar Categorías
CREATE PROC ListarCategoria
AS
SELECT * FROM Categoria ORDER BY id_Categoria ASC
GO

-- Procedimiento para listar Empleado
CREATE PROC ListarEmpleado
AS
SELECT * FROM Empleado ORDER BY id_Empleado ASC
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

-- Procedimiento para actualizar una Categoría
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

CREATE PROC EliminarMarca
@id_Marca int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Marca 
    SET Estado = 0
    WHERE id_Marca = @id_Marca
END;
GO