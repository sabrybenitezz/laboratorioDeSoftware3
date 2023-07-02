
Create table Automovil
(
	Patente NVARCHAR (6) PRIMARY KEY,
	Marca NVARCHAR (10),
	Modelo NVARCHAR(10),
	Precio INT,
	--CONSTRAINT fk_Cliente FOREIGN KEY (Identificador) REFERENCES Cliente (Identificador),
)