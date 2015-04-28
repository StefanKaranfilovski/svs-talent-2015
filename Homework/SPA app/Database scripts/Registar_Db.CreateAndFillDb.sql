USE [Registar_Db]

INSERT INTO Bikes(RegisterNumber, Manufacturer, Model, Colour)
VALUES ('001', 'Factory', 'R1', 'Red'),
	   ('002', 'Factory', 'R2', 'Green'),
	   ('003', 'Factory', 'R3', 'Blue'),
	   ('004', 'Factory', 'R1', 'Red'),
	   ('005', 'Factory', 'R2', 'Green'),
	   ('006', 'Factory', 'R3', 'Blue'),
	   ('007', 'Factory', 'R1', 'Red'),
	   ('008', 'Factory', 'R2', 'Green'),
	   ('009', 'Factory', 'R3', 'Blue'),
	   ('010', 'Factory', 'R1', 'Red'),
	   ('011', 'Factory', 'R2', 'Green'),
	   ('012', 'Factory', 'R3', 'Blue'),
	   ('013', 'Factory', 'R1', 'Red');

USE [Registar_Db]

CREATE TABLE Bikes
(
	BikeId int IDENTITY(1,1) primary key,
	RegisterNumber varchar(30) not null,
	Manufacturer varchar(50) not null,
	Model varchar(30),
	Colour varchar(30)
);