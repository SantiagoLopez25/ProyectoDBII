USE VentaMuebles
GO


-- Función para incicio de sesión
Create function [dbo].[f_login]
(
    @usuario varchar(100), @contrasennia varchar(100)
)
	--returns @tabla table (respuesta bit ,  rol varchar(50) )
	returns varchar(100)
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
		select @rol =  nombre_Rol from usuario inner join rol on usuario.id_Rol = rol.id_Rol where usuario.Usuario = @usuario

	-- Comparación de la contraseña

		
		If @contraGuardada =@contraEncriptada
			--insert into @tabla values (1, @rol)
			set @respuesta = @rol
		Else
			set @respuesta = '0'
			--insert into @tabla values (0, ' ')
	RETURN @respuesta
END