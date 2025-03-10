-- Creaci�n de procedimientos almacenados

USE VentaMuebles
GO

-- Procedimiento para listar tipos de pago
CREATE PROC ListarEstadoPedido
AS
SELECT 
	id_EstadoPedido,
	Nombre_EstadoPedido
FROM EstadoPedido_Entrega
WHERE Estado = 1
ORDER BY Nombre_EstadoPedido ASC
GO

--Procedimiento para listar entregas
CREATE PROCEDURE ListarEntregas
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
--Procedimiento para filtrar ventas por cliente o numero de factura
CREATE PROCEDURE CompletarEntrega
@id_Entrega int
AS BEGIN
	UPDATE Entrega SET
	id_EstadoPedido=2
	WHERE id_Entrega = @id_Entrega
END;
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
WHERE  NIT LIKE @nit;
END;
GO

--Procedimiento para buscar Direcciones de entrega por id_Cliente
CREATE PROC BuscarDireccionesEntregaCliente
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

--Procedimiento para buscar Cliente por Nombre
CREATE PROC BuscarClientePorNombre
@nombre_cliente varchar (175)
AS BEGIN
SELECT * FROM CLIENTE
WHERE Nombre_Cliente LIKE @nombre_cliente;
END;
GO


--Procedimiento para buscar Direcciones de entrega por id_Cliente
CREATE PROC BuscarDireccionesEntregaClientePorNombre
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

-- Procedimiento para listar Ventas
CREATE PROC ListarVentas
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
INNER JOIN Cliente on Factura.id_Cliente = Cliente.id_Cliente
INNER JOIN Usuario on Factura.id_Usuario = Usuario.id_Usuario
INNER JOIN Entrega on Factura.id_Domicilio = Entrega.id_Entrega
INNER JOIN DireccionEntrega on Entrega.id_DirecciónEntrega = DireccionEntrega.id_DirecciónEntrega
where factura.Estado = 1

ORDER BY 
	Factura.fechaFactura DESC
GO



-- Procedimiento para listar Compras
CREATE PROC ListarCompras
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

--Procedimiento para eliminar compra
CREATE PROC EliminarCompra
@id_Pedido int
AS BEGIN
    -- Cambiar el estado a 0 (falso) para ocultar la compra
    UPDATE Pedido 
    SET Estado = 0
    WHERE id_Pedido = @id_Pedido
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

-- Procedimiento para buscar SerieFactura
CREATE PROC ListarSeriesDeFactura
AS
Select id_Serie from SerieFactura
ORDER BY fechaInicio ASC
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

USE [VentaMuebles]
GO
/****** Object:  StoredProcedure [dbo].[GenerarFactura]    Script Date: 23/10/2024 07:54:40 ******/
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
					/*select id_Factura, id_Serie, fechaFactura, montoTotal, totalSinDescuento, Nombre_Cliente, DireccionFacturacion, Usuario	
					from Factura
					inner join Cliente on Cliente.id_Cliente = Factura.id_Cliente 
					inner join usuario on Factura.id_Usuario = usuario.id_Usuario
					where Factura.id_Factura = @id_Factura and Factura.id_Cliente = @id_cliente

					
					
					select muebles.Nombre, d.cantidad, SUM(PrecioVenta*d.cantidad) as 'Total' from Muebles
					inner join @detalle d on Muebles.id_mueble= d.id_Mueble
					group by Muebles.Nombre, d.cantidad*/

					-- Actualizar inventario (siguiendo el concepto FIFO)
					exec actualizarInventario @productos = @detalle


				set @resultado = 'Se ha guardado correctamente la factura'
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


-- Procedimiento para obtener los datos de la factura (para su impresión)
USE [VentaMuebles]
GO
/****** Object:  StoredProcedure [dbo].[datosFactura]    Script Date: 22/10/2024 17:29:34 ******/
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


