
-- Procedimiento para crear compra con detalle incluido
USE [VentaMuebles]
GO

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

-- Procedimiento para actualizar compra e insertar stock

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCompraYCrearStock]
    @id_Pedido INT,
    @CantidadRecibido INT,
    @FechaIngreso DATE,
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
            SELECT CantidadProducto, CantidadProducto, @FechaIngreso, 1, id_mueble
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


-- Procedimiento para listar productos con existencia menor a la mínima


/****** Object:  StoredProcedure [dbo].[reporteProductosExistencia]    Script Date: 10/11/2024 17:16:47 ******/
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

-- Procedimiento para listar los productos que más dinero generan entre 2 fechas


/****** Object:  StoredProcedure [dbo].[productosMasVendidosPorFecha]    Script Date: 10/11/2024 17:24:55 ******/
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




-- Procedimiento almacenado que muestra los métodos de pago que más generan entre 2 fechas

/****** Object:  StoredProcedure [dbo].[totalFactura]    Script Date: 10/11/2024 17:26:19 ******/
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


-- Procedimiento almacenado que muestra los productos que están pendientes de entrega y los que ya fueron entregados


/****** Object:  StoredProcedure [dbo].[estadoProductos]    Script Date: 12/11/2024 08:30:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[estadoProductos] 

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


-- Procedimiento almacenado que anula una factura


/****** Object:  StoredProcedure [dbo].[anularFactura]    Script Date: 12/11/2024 07:46:42 ******/
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







