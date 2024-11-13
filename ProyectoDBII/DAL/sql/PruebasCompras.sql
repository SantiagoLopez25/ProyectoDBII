USE VentaMuebles
GO

DECLARE @DetallePedido udt_DetallePedido;
DECLARE @resultado VARCHAR(200);
DECLARE @FechaActual DATE = GETDATE(); 


INSERT INTO @DetallePedido (cantidad, id_mueble)
VALUES 
    (5, 1), 
    (3, 2);  

-- Ejecuta el procedimiento almacenado
EXEC [dbo].[RegistrarCompra]
    @Descripcion = 'Prueba 2',
    @FechaPedido = @FechaActual,  
    @FechaRecibido = NULL, 
    @CantidadPedido = 8, 
    @CantidadRecibido = NULL, 
    @TotalPagar = 150.75, 
    @Estado = 1, 
    @id_EstadoPedido = 1, 
    @id_TipoPago = 1, 
    @id_Proveedor = 1, 
    @DetallePedido = @DetallePedido,
    @resultado = @resultado OUTPUT;

-- Muestra el resultado
SELECT @resultado AS Resultado;


-- PRUEBA PARA ACTUALIZAR LA COMPRA CON CANTIDAD INCOMPLETA
DECLARE @resultado VARCHAR(200);
DECLARE @FechaActual DATE = GETDATE();
EXEC [dbo].[ActualizarCompraYCrearStock]
    @id_Pedido = 7,            -- ID del pedido que deseas actualizar
    @CantidadRecibido = 5,      
    @FechaIngreso = @FechaActual,  
    @resultado = @resultado OUTPUT;

SELECT @resultado AS Resultado;


-- PRUEBA PARA ACTUALIZAR CON CANTIDAD COMPLETA
DECLARE @resultado VARCHAR(200);
DECLARE @FechaActual DATE = GETDATE();
EXEC [dbo].[ActualizarCompraYCrearStock]
    @id_Pedido = 7,            -- ID del pedido que deseas actualizar
    @CantidadRecibido = 8,     
    @FechaIngreso = @FechaActual,  
    @resultado = @resultado OUTPUT;

SELECT @resultado AS Resultado;
