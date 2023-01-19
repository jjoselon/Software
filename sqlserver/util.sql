USE SqlServerYA;

IF OBJECT_ID('usuarios', 'TABLE') IS NOT NULL 
	DROP TABLE usuarios;

CREATE TABLE usuarios (
	nombre varchar(30),
	clave varchar(10) 
)

ALTER TABLE usuarios ADD correo varchar(100) NOT NULL;
ALTER TABLE usuarios ADD primary key(correo) /*NOT NULL : SQL Server lo establece de forma automatica*/;
-- no es posible establecer un Indice o constraint de Primary Key a un campo que acepte null

/* IDENTITY - AUTO INCREMENT AS MYSQL*/
-- IDENTITY no es un INDICE 
ALTER TABLE usuarios ADD id int /*NOT NULL*/ IDENTITY(2, 3);

-- Nos muestra todas las tablas que nos pertenecen y no las que sql server crea.
exec sp_tables @table_owner='dbo';

exec sp_columns usuarios;
INSERT INTO dbo.usuarios (clave, nombre, correo) VALUES ('123456789', 'jjoselon', 'jjoselon3167@hotmail.com');

SELECT * FROM usuarios;

-- punto 14 - IDENTITY

-- retorna el valor de inicio del campo IDENTITY de la tabla
select IDENT_SEED('usuarios') AS 'BEGIN VALUE';

-- retorna el valor de intervalo cuando se incrementa el campo IDENTITY
select IDENT_INCR('usuarios') AS 'INTERVAL INCREMENT VALUE';

-- para permitir ingresar un valor de forma explicita a un campo IDENTITY (off para desactivar)
SET IDENTITY_INSERT usuarios ON;

INSERT INTO usuarios (id, nombre, clave, correo) VALUES (8, 'Carlos', '123ya', 'carlos3167@hotmail.com');

SELECT * FROM usuarios;

-- el atributo IDENTITY no representa unicidad
