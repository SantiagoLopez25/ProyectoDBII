-- Prueba 1

declare @tabla as udt_DetalleFactura
declare @resultado as varchar(200)

insert into @tabla (id_Mueble, cantidad)
values (15, 2), (9,1), (7,4), (6,5)


EXEC GenerarFactura @detalle = @tabla, @serie = 'A-23',  @nombre_cliente = 'Emiliano Sarti',
@direccion_Facturacion = 'San Marcos', @telefono = '43125789', @correo = 'emiliano@gmail.com', 
@direccionEntrega = '4 calle Zona 3 San Marcos, San Marcos', @telefonoReferencia='43125789',
@descripcionEntrega ='Casa amarilla a 2 cuadras de Restaurante Comida, cuidado con el perro',
@fechaEntrega ='2024-10-20', @horaEntrega = '08:00:00', 
@idTTipoPago1= 1, @idTTipoPago2 = 3, @porcentajePago1 = 50, @porcentajePago2 = 50,
@id_Usuario=4, @resultado = @resultado OUTPUT
