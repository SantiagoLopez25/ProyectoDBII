-- Creaci�n de procedimientos almacenados

USE VentaMuebles
GO
--Procedimiento para listar los muebles
CREATE PROC ListarMuebles
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

-- Procedimiento para listar tipos de pago
CREATE PROC ListarTiposPago
AS
SELECT 
	id_TipoPago,
	Nombre_TipoPago
FROM TipoPago
WHERE Estado = 1
ORDER BY Nombre_TipoPago ASC
GO

-- Procedimiento para buscar Cliente por Nit
CREATE PROC BuscarClientePorNit
@nit varchar (8)
AS BEGIN
SELECT * FROM Cliente
WHERE  NIT LIKE @nit
END;
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

--Procedimiento para solicitar datos de stock
CREATE PROC ExistenciasMuebles
AS
SELECT 
        M.id_mueble, 
        M.Nombre, 
        SUM(S.CantidadStock) AS TotalExistencias,
		M.PrecioVenta
    FROM Muebles M
    INNER JOIN  Stock S ON M.id_mueble = S.id_mueble
    WHERE 
        M.Estado = 1 AND S.Estado = 1 AND S.CantidadStock > 0
	GROUP BY 
        M.id_mueble, 
        M.Nombre,
		M.PrecioVenta
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

--Procedimiento para eliminar categoria
CREATE PROC EliminarCategoria
@id_Categoria int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Categoria 
    SET Estado = 0
    WHERE id_Categoria = @id_Categoria
END;
GO

--Procedimiento para eliminar empleado
CREATE PROC EliminarEmpleado
@id_Empleado int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la marca
    UPDATE Empleado 
    SET Estado = 0
    WHERE id_Empleado = @id_Empleado
END;
GO


	

-- Procedimiento almacenado que permite crear un usuario, actualizarlo y deshabilitarlo

GO
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
END;
GO


--Procedimiento para listar usuarios

CREATE PROC ListarUsuarios
AS BEGIN
   select id_Usuario, nombre, usuario, nombre_rol 
   from usuario inner join rol 
   on Usuario.id_Rol = rol.id_Rol 
   inner join Empleado 
   on Empleado.id_Empleado = Usuario.id_Empleado
END;

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


-- Procedimiento almacenado para la facturación

CREATE procedure [dbo].[GenerarFactura]
@detalle udt_DetalleFactura READONLY, 
@serie varchar(150),
@id_cliente int = null,
@nombre_cliente varchar(200) = null,
@direccion_Facturacion varchar(30) = null,
@telefono varchar(10) = null,
@correo varchar(50) = null,
@nit varchar(8) = 'CF',
@id_DireccionEntrega int = null,
@direccionEntrega varchar(150) = null,
@descripcionEntrega varchar(200),
@telefonoReferencia varchar(8),
@fechaEntrega date,
@horaEntrega time,
@idTTipoPago1 int,
@idTTipoPago2 int = null,
@idTipoPago3 int = null,
@porcentajePago1 decimal(4,1) = null, 
@porcentajePago2 decimal(4,1) = null,
@porcentajePago3 decimal(4,1) = null,
@id_Usuario int,
@resultado varchar(200) OUTPUT
AS
BEGIN
	declare @id_Entrega as int
	declare @cantidad1 as decimal(10,2)
	declare @cantidad2 as decimal(10,2)
	declare @cantidad3 as decimal (10,2)
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
					Rollback TRAN factura
				END
			
				ELSE
				BEGIN 

					IF (@id_cliente is null)
					BEGIN 
						insert into Cliente (Nombre_Cliente, DireccionFacturacion, Telefono, Correo,Descuentos, NIT, Estado)
						values (@nombre_cliente, @direccion_Facturacion, @telefono, @correo, 0, @nit, 1)
						set @id_cliente = @@IDENTITY
					END
			
					IF (@id_DireccionEntrega is null) 
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
					IF (@idTTipoPago2 is  null and @idTipoPago3 is null)
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

						END


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


				END

		--insert into DetalleFactura 
		set @resultado = 'Se guardo correctamente la factura'
		COMMIT TRAN factura
	End Try
		
	Begin Catch
		Rollback TRAN factura
		set @resultado = 'Ocurrio un error: ' + ERROR_MESSAGE() + ' en la línea: ' + CONVERT(NVARCHAR(255), ERROR_LINE() ) + '.'
		
	End Catch 

End
GO