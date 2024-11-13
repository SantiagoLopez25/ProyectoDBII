USE  VentaMuebles
GO

INSERT INTO Empleado (Nombre,Telefono,Correo,Estado) 
VALUES 
	('Juan Jose', '77609876', 'juanjo@gmail.com', 1),
	('Valeria Valle', '76341257', 'vale123@gmail.com', 1),
	('Gabriela Sandoval', '99347512', 'Gabi@gmail.com', 1),
	('Jesus Sarti', '78435567', 'Ye@gmail.com', 1),
	('Ottoniel Dominguez', '12341234', 'otto@gmail.com', 1),
	('Santiago López', '40781234', 'santiagol@gmail.com', 1); 
INSERT INTO Rol (nombre_Rol,Estado) 
VALUES 
	('Administrador', 1),
	('Bodeguero', 1),
	('Vendedor', 1),
	('Gerente', 1);
INSERT INTO Usuario  (Usuario,Password,Estado,id_Rol,id_Empleado)
VALUES 
	('Admin', 0xE1223D9BBCD82236F9F09AE1F5578E3CBBD4E8F48954CEAD3003BE60AC85629726DC04B1F875353459F97BA4A4283A1A6ADB89D3524BB4816C7125964097106C, 1, 1, 6),
	('ValeriaV', 0x2E15C943B679F39B07F0E79E4293EBA6F7338159970C77A94018569F577E7025697545AD443556FE92361B83F21435EAB253DBBA5E41EBB636B633241209A4FF, 1, 2, 2),
	('Jesus', 0xD5BFF99428217F82ABCA99105A51254B654BE9A96145E3BFBEBADCF4EC36D1B021ED05A1ADB978C2AB08E896F3EC3CB8EE5DC6B161C06F1744AAFF367ECB4CBF, 1, 1, 4),
	('Otto', 0xAAFF9106875B7964E8991352C0C0E4E8DB27A94E76086C993BC2470DBFF0C8CFCD1524D0C358424288B4E552F5D1A31274960BC43905763B1633F246A975FB73, 1, 3, 5),
	('juanjo', 0x7DDE3B93B0A76254ECF6AFF493067453F763DD9FFBBE99BA6228D66CF3C353C17E34E121385DC01C29DA7541BD342ED99D4DBB66936246FEC33FD41367E80E7D, 1, 4, 1);

insert into marca (marca) values ('Arketipo'), ('MueblesGT'), ('Muebles'), ('MuebleriaLosAltos'), ('Casa Bella')
UPDATE marca set estado = 0 where id_Marca = 3;


insert into Categoria (categoria) values ('Silla'), ('Sofa'), ('Mesa'),
('Cama'), ('Closet'), ('Lámpara'), ('Cama Sofa'), ('Litera')


INSERT INTO Modelo(modelo, Estado, id_Marca, id_Categoria)
VALUES 
('Silla de Oficina', 1, 1, 1),   -- Relacionada con arketipo y Silla
('Sofa Moderno', 1, 1, 2),       -- Relacionada con arketipo y Sofa
('Mesa de Centro', 1, 2, 3),     -- Relacionada con MueblesGT y Mesa
('Cama Doble', 1, 4, 4),         -- Relacionada con MuebleriaLosAltos y Cama
('Closet Empotrado', 1, 5, 5),   -- Relacionada con Casa Bella y Closet
('Lámpara de Techo', 1, 4, 6),   -- Relacionada con MuebleriaLosAltos y Lámpara
('Cama Sofa Versátil', 1, 1, 7), -- Relacionada con arketipo y Cama Sofa
('Litera Infantil', 1, 5, 8); 


INSERT INTO Muebles (Descripcion, PrecioVenta, Descuento, ExistenciaMinima, TiempoGarantia, Estado, id_Modelo, Nombre)
VALUES
-- Silla Moderna - Variaciones
('Silla Moderna con apoyabrazos', 150.00, 0.0, 5, 24, 1, 1, 'Silla Moderna - Apoyabrazos'),
('Silla Moderna sin apoyabrazos', 130.00, 0.0, 5, 24, 1, 1, 'Silla Moderna - Sin Apoyabrazos'),

-- Sofa Clásico - Variaciones
('Sofa Clásico de dos plazas', 400.00, 0.0, 2, 36, 1, 2, 'Sofa Clásico - Dos plazas'),
('Sofa Clásico de tres plazas', 500.00, 0.0, 2, 36, 1, 2, 'Sofa Clásico - Tres plazas'),

-- Mesa de Centro - Variaciones
('Mesa de Centro rectangular', 120.00, 0.0, 3, 12, 1, 3, 'Mesa de Centro - Rectangular'),
('Mesa de Centro circular', 140.00, 0.0, 3, 12, 1, 3, 'Mesa de Centro - Circular'),

-- Cama King Size - Variaciones
('Cama King Size con cabecero', 800.00, 0.0, 1, 60, 1, 4, 'Cama King Size - Cabecero'),
('Cama King Size sin cabecero', 750.00, 0.0, 1, 60, 1, 4, 'Cama King Size - Sin Cabecero'),

-- Closet Empotrado - Variaciones
('Closet Empotrado de madera', 600.00, 0.0, 2, 48, 1, 5, 'Closet Empotrado - Madera'),
('Closet Empotrado de metal', 650.00, 0.0, 2, 48, 1, 5, 'Closet Empotrado - Metal'),

-- Lámpara LED - Variaciones
('Lámpara LED de pie', 100.00, 0.0, 10, 12, 1, 6, 'Lámpara LED - Pie'),
('Lámpara LED de mesa', 80.00, 0.0, 10, 12, 1, 6, 'Lámpara LED - Mesa'),

-- Litera Compacta - Variaciones
('Litera Compacta con escritorio', 300.00, 0.0, 2, 36, 1, 7, 'Litera Compacta - Escritorio'),
('Litera Compacta sin escritorio', 280.00, 0.0, 2, 36, 1, 7, 'Litera Compacta - Sin Escritorio'),

-- Sofa Cama Deluxe - Variaciones
('Sofa Cama Deluxe de cuero', 600.00, 0.0, 2, 48, 1, 8, 'Sofa Cama Deluxe - Cuero'),
('Sofa Cama Deluxe de tela', 550.00, 0.0, 2, 48, 1, 8, 'Sofa Cama Deluxe - Tela');


-- Insertar datos en la tabla Stock
INSERT INTO Stock (CantidadInicial, CantidadStock, FechaIngreso, Estado, id_mueble)
VALUES
-- Silla Moderna con apoyabrazos (con stock)
(20, 5, '2024-05-15', 1, 1),
(30, 10, '2024-07-20', 1, 1),

-- Silla Moderna sin apoyabrazos (sin stock)
(15, 0, '2024-03-10', 0, 2),

-- Sofa Clásico de dos plazas (con stock)
(10, 3, '2024-06-18', 1, 3),
(5, 2, '2024-08-10', 1, 3),

-- Sofa Clásico de tres plazas (sin stock)
(8, 0, '2024-04-22', 0, 4),

-- Mesa de Centro rectangular (con stock)
(12, 6, '2024-05-25', 1, 5),
(10, 4, '2024-06-30', 1, 5),

-- Mesa de Centro circular (con stock)
(20, 10, '2024-04-12', 1, 6),

-- Cama King Size con cabecero (con stock)
(5, 1, '2024-02-15', 1, 7),
(8, 5, '2024-07-01', 1, 7),

-- Cama King Size sin cabecero (sin stock)
(6, 0, '2024-03-10', 0, 8),

-- Closet Empotrado de madera (con stock)
(10, 3, '2024-01-25', 1, 9),

-- Closet Empotrado de metal (sin stock)
(7, 0, '2024-06-05', 0, 10),

-- Lámpara LED de pie (con stock)
(25, 15, '2024-03-20', 1, 11),

-- Lámpara LED de mesa (sin stock)
(20, 0, '2024-04-01', 0, 12),

-- Litera Compacta con escritorio (con stock)
(10, 4, '2024-05-11', 1, 13),
(15, 8, '2024-06-15', 1, 13),

-- Litera Compacta sin escritorio (sin stock)
(12, 0, '2024-02-28', 0, 14),

-- Sofa Cama Deluxe de cuero (con stock)
(18, 9, '2024-04-22', 1, 15),

-- Sofa Cama Deluxe de tela (sin stock)
(10, 0, '2024-03-18', 0, 16);

update stock set Estado = REPLACE(Estado, 0, 1) where id_Stock <= 21



insert into SerieFactura (id_Serie, fechaInicio, Estado) values
('A-23', '2024-10-05', 1), ('A-30', '2024-08-01', 1)


insert into EstadoPedido_Entrega (Nombre_EstadoPedido)
values ('Facturado'), ('Entregado'), ('Cancelado'), ('Enviado')

insert into TipoPago (Nombre_TipoPago, Estado)
values ('Efectivo', 1), ('Tarjeta de crédito', 1), ('Tarjeta de Débito', 1), ('Apple Pay', 1), 
('Google Pay',1), ('PayPal', 1)

insert into EstadoPedido_Proveedor(Nombre_EstadoPedido,Estado)
values ('En Proceso',1), ('Recibido Completo',1), ('Cancelado',1)

insert into Proveedor (proveedor,Direccion,Telefono,TelefonoExtra,Correo,Estado)
values 
('Muebles fiesta','18 Av 8-78 zona 1 Quetgo','12345678','87654321','mueblesFiesta@gmail.com',1),
('Muebles Occidente','6 Calle 1-23 zona 3 Totonicapan','24681024','42018642','occMubles@gmail.com',1),
('La bendicion Muebleria','7 Av 4-12 zona 7 San Marcos','21252426','26242521','laBendiMuebles@gmail.com',1)


