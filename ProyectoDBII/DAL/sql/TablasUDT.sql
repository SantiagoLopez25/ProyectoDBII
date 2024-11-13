USE VentaMuebles
GO

CREATE TYPE udt_DetallePedido AS TABLE
(
    cantidad INT NOT NULL,
    id_mueble INT NOT NULL
);
CREATE TYPE udt_DetalleFactura AS TABLE
(
    cantidad int NOT NULL,
    id_Mueble int NOT NULL
);


CREATE TYPE udt_DetalleImprimir AS TABLE
(
    cantidad int NOT NULL,
    id_Mueble int NOT NULL,
	total decimal(10,2) NOT NUll
);

CREATE TYPE udt_Factura AS TABLE
(
	id_Factura int NOT NULL,
	id_Serie varchar(25) NOT NULL,
	fechaFactura datetime NOT NULL,
	montoTotal decimal(18,2) NOT NULL,
	totalSinDescuetno decimal(18,2) NOT NULL,
	descuento decimal(10,2) NOT NULL,
	Cliente varchar(200) NOT NULL,
	Direccion varchar(30) NOT NULL,
	Usuario varchar(75) NOT NULL
)
