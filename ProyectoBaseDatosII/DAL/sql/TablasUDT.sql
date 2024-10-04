USE VentaMuebles
GO


CREATE TYPE udt_DetalleFactura AS TABLE
(
    cantidad int NOT NULL,
    id_Mueble int NOT NULL
);