-- Procedimiento para listar productos con existencia menor a la mínima

USE [VentaMuebles]
GO
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

USE [VentaMuebles]
GO
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
inner join Factura on Factura.id_Factura = DetalleFactura.id_DetalleFactura
where fechaFactura > @fehcaInicio and fechaFactura < @fechaFinal
group by Nombre
order by 'Total generado' desc


END




-- Procedimiento almacenado que muestra los métodos de pago que más generan entre 2 fechas

USE [VentaMuebles]
GO
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
inner join Factura on Factura.id_Factura = Pago.id_Factura where fechaFactura > @fehcaInicio and fechaFactura < @fechaFinal
group by Nombre_TipoPago order by 'Total' desc

END


-- Procedimiento almacenado que muestra los productos que están pendientes de entrega y los que ya fueron entregados

USE [VentaMuebles]
GO
/****** Object:  StoredProcedure [dbo].[estadoProductos]    Script Date: 10/11/2024 17:28:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[estadoProductos] 

as 

BEGIN

select *from EstadoPedido_Entrega


select Muebles.Nombre from Muebles inner join DetalleFactura on Muebles.id_mueble = DetalleFactura.id_mueble
inner join Factura on Factura.id_Factura = DetalleFactura.id_DetalleFactura
inner join Entrega on Entrega.id_Entrega = Factura.id_Domicilio where entrega.id_EstadoPedido = 1 or Entrega.id_EstadoPedido = 4

select Muebles.Nombre, fechaEntrega from Muebles inner join DetalleFactura on Muebles.id_mueble = DetalleFactura.id_mueble
inner join Factura on Factura.id_Factura = DetalleFactura.id_DetalleFactura
inner join Entrega on Entrega.id_Entrega = Factura.id_Domicilio where entrega.id_EstadoPedido = 2
order by fechaEntrega desc




	

END 


-- Procedimiento almacenado que anula una factura

create procedure anularFactura(
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





