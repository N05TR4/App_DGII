
--CRAER BASE DE DATOS

CREATE DATABASE PRUEBA_DGII;

-- USAR LA BSE DE DATOS PRUEBA_DGII

USE PRUEBA_DGII;

-- CREAR LAS TABLAS O ENTIDADES

CREATE TABLE Contribuyentes(
	Id INT PRIMARY KEY IDENTITY(1,1),
	RncCedula VARCHAR(11) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Tipo VARCHAR(50) NOT NULL,
	Estatus VARCHAR(10) NOT NULL

);


CREATE TABLE Comprobante(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ContribuyenteId INT NOT NULL,
	NCF VARCHAR(13) NOT NULL,
	Monto DECIMAL NOT NULL,
	Itbis18 DECIMAL NOT NULL,
	FOREIGN KEY (ContribuyenteId) REFERENCES Contribuyentes(Id)
);

-- INSERTAR VALORES EN LA TABLA CONTRIBUYENTES Y COMPROBANTE

INSERT INTO Contribuyentes(RncCedula, Nombre, Tipo, Estatus)
VALUES ('98754321012','JUAN PEREZ', 'PERSONA FISICA', 'activo'),
	   ('123456789','FARMACIA TU SALUD', 'PERSONA JURIDICA', 'inactivo'),
	   ('40212353700', 'JOSE VASQUEZ', 'PERSONA FISICA', 'Activo')

INSERT INTO Comprobante (ContribuyenteId, NCF, Monto, Itbis18)
VALUES (1, 'E310000000001', 200.00, 36.00),
	   (1, 'E310000000002', 1000.00, 180.00),
	   (3, 'E310000000003', 1500.00, 270.00),
	   (3, 'E310000000004', 2000.00, 360.00)

SELECT * FROM Contribuyentes
SELECT * FROM Comprobante