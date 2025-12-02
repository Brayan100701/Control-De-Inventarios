-----------------------------------  TProveedores

INSERT INTO TProveedores VALUES('DEFAULT', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('CHANCHITOS', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('PROVEEDOR RANDOM', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('FALOPA', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('177013', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('FOR THOSE WHO COME AFTER', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('PROVEEDOR 123', NULL, NULL)
GO

INSERT INTO TProveedores VALUES('LUMIERE', GETDATE(), NULL)
GO

INSERT INTO TProveedores VALUES('TESTPROVIDER', GETDATE(), NULL)
GO



-----------------------------------  TAcciones

INSERT INTO TAcciones VALUES (' ')
GO

INSERT INTO TAcciones VALUES ('login')
GO

INSERT INTO TAcciones VALUES ('logout')
GO

INSERT INTO TAcciones VALUES ('creacion usuario')
GO

INSERT INTO TAcciones VALUES ('modificacion usuario')
GO

INSERT INTO TAcciones VALUES ('habilitado usuario')
GO

INSERT INTO TAcciones VALUES ('inhabilitado usuario')
GO

INSERT INTO TAcciones VALUES ('creacion perfil')
GO

INSERT INTO TAcciones VALUES ('borrado perfil')
GO

INSERT INTO TAcciones VALUES ('modificacion perfil')
GO

INSERT INTO TAcciones VALUES ('modificacion usuario')
GO

INSERT INTO TAcciones VALUES ('creacion producto')
GO

INSERT INTO TAcciones VALUES ('borrado producto')
GO

INSERT INTO TAcciones VALUES ('deshacer borrado')
GO

INSERT INTO TAcciones VALUES ('registro entrada')
GO

INSERT INTO TAcciones VALUES ('registro salida')
GO

INSERT INTO TAcciones VALUES ('consulta')
GO



-----------------------------------  TPerfiles

INSERT INTO TPerfiles VALUES(
	'DEFAULT',
	' ')
GO

INSERT INTO TPerfiles VALUES(
	'Admin',
	'4 5 6 7 8 9 10 11 12 13 14 15 16 17')
GO

INSERT INTO TPerfiles VALUES(
	'AdminPersonal',
	'4 5 6')
GO

INSERT INTO TPerfiles VALUES(
	'AdminInventario',
	'12 13 14 15 17')
GO

INSERT INTO TPerfiles VALUES(
	'Movimientos',
	'12 13 14 15 16 17')
GO

INSERT INTO TPerfiles VALUES(
	'ConsultaInventario',
	'17')
GO




-----------------------------------  USUARIO

INSERT INTO TUsuario VALUES(
	CAST(' ' AS VARBINARY(MAX)),
	1,
	GETDATE(),
	GETDATE(),
	0
)
GO


-----------------------------------  TArticulo

INSERT INTO TArticulos VALUES(
	'PAPAS',
	'SALADAS',
	15,
	1,
	14,
	6
)
GO

INSERT INTO TArticulos VALUES(
	'PAPAS',
	'ADOBADAS',
	10,
	1,
	12,
	1
)
GO

INSERT INTO TArticulos VALUES(
	'PAPAS',
	'SOLAS',
	100,
	1,
	10,
	2
)
GO

INSERT INTO TArticulos VALUES(
	'PAPAS',
	'HABANERO',
	150,
	1,
	20,
	3
)
GO

INSERT INTO TArticulos VALUES(
	'PAPAS',
	'CON LIMON',
	40,
	1,
	14,
	4
)
GO

INSERT INTO TArticulos VALUES(
	'CHURRUMAIS',
	'CLASICOS',
	1500,
	1,
	13,
	5
)
GO

INSERT INTO TArticulos VALUES(
	'PAPAS',
	'A LA FRANCESA',
	12,
	1,
	35,
	6
)
GO

INSERT INTO TArticulos VALUES(
	'AGUA DE LIMON',
	'AGUA NATURAL FRESCA',
	5,
	1,
	15,
	7
)
GO

INSERT INTO TArticulos VALUES(
	'AGUA DE JAMAICA',
	'AGUA NATURAL',
	8,
	1,
	15,
	8
)
GO

INSERT INTO TArticulos VALUES(
	'LAMPARA',
	'LAMPARA CON BATERIA RECARGABLE',
	100,
	1,
	60,
	9
)
GO

SELECT * FROM TArticulos