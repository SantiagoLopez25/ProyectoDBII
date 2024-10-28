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


-- Prueba 2

declare @tabla as udt_DetalleFactura
declare @resultado as varchar(200)


insert into @tabla (id_Mueble, cantidad)
values (11, 10)

select Muebles.id_mueble, Nombre from Muebles inner join @tabla t on t.id_Mueble = Muebles.id_mueble
select *From Stock


select *From TipoPago

EXEC GenerarFactura @detalle = @tabla, @serie = 'A-23',  @nombre_cliente = 'Marta Escobar',
@direccion_Facturacion = 'Quetzaltenagno', @telefono = '85436741', @correo = 'marta@gmail.com', 
@direccionEntrega = '10 avenida zona 9 Quetzaltenango, Quetzaltenango', @telefonoReferencia='85436741',
@descripcionEntrega ='Porton azul enfrente de Tiendita Doña Mari',
@fechaEntrega ='2024-10-25', @horaEntrega = '12:00:00', 
@idTTipoPago1= 6, @idTTipoPago2 = 1, @idTipoPago3 =2, @porcentajePago1 = 10, @porcentajePago2 = 50, @porcentajePago3 =40,
@id_Usuario=4, @resultado = @resultado OUTPUT


select @resultado as resultado


--Pueba 3

declare @tabla as udt_DetalleFactura
declare @resultado as varchar(200)


insert into @tabla (id_Mueble, cantidad)
values (1, 6)

----select *From Stock


--select *From TipoPago

EXEC GenerarFactura @detalle = @tabla, @serie = 'A-23',  @id_cliente =1,
@direccionEntrega = '4 calle Zona 3 San Marcos, San Marcos', @telefonoReferencia='43125789',
@descripcionEntrega ='Casa amarilla a 2 cuadras de Restaurante Comida, cuidado con el perro',
@fechaEntrega ='2024-10-30', @horaEntrega = '14:00:00',  
@idTTipoPago1= 4, @idTTipoPago2 = 5, @porcentajePago1 = 33, @porcentajePago2= 77, 
@id_Usuario=4, @resultado = @resultado OUTPUT


select @resultado as resultado



