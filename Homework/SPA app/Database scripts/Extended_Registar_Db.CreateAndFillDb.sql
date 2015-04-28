-- CREATE SCHEMA [data]


IF NOT EXISTS (SELECT * FROM sys.sysobjects WHERE name = 'BikeOwners' and xtype = 'U')
BEGIN
	CREATE TABLE data.BikeOwners
	(
		BikeOwnerId int IDENTITY(1,1) not null,
		FirstName nvarchar(50) null,
		LastName nvarchar(100) null
	);
END

--
ALTER TABLE data.BikeOwners 
ADD CONSTRAINT PK_BikeOwners 
PRIMARY KEY (BikeOwnerId)

--
CREATE TABLE data.Bikes
(
	BikeId int IDENTITY(1,1) not null,
	BikeOwnerId int not null,
	RegisterNumber nvarchar(50) not null,
	Manufacturer nvarchar(50) null,
	Model nvarchar(20) null,
	Colour nvarchar(20) null,
	City nvarchar(50) null,
	SpeedsCount tinyint null,
	TStamp timestamp not null
);

--
ALTER TABLE data.Bikes
ADD CONSTRAINT PK_Bikes
PRIMARY KEY (BikeId)

--
ALTER TABLE data.Bikes
ADD CONSTRAINT FK_Bikes_BikeOwnerId_X_BikeOwners_BikeOwnerId
FOREIGN KEY (BikeOwnerId)
REFERENCES data.BikeOwners(BikeOwnerId)

--
SELECT * FROM sys.syscolumns

--
INSERT INTO data.BikeOwners (FirstName, LastName)
VALUES ('First Owner', 'LastName'),
	   ('Second Owner', 'LastName'),
	   ('Third Owner', 'LastName');


--
INSERT INTO data.Bikes(BikeOwnerId, RegisterNumber, Manufacturer, Model, Colour, City, SpeedsCount)
VALUES (1, '001', 'Factory', 'R1', 'Red', 'City', '6'),
	   (3, '002', 'Factory', 'R2', 'Green', 'City', '6'),
	   (1, '003', 'Factory', 'R3', 'Blue', 'City', '6'),
	   (1, '004', 'Factory', 'R1', 'Red', 'City', '6'),
	   (2, '005', 'Factory', 'R2', 'Green', 'City', '6'),
	   (2, '006', 'Factory', 'R3', 'Blue', 'City', '6'),
	   (2, '007', 'Factory', 'R1', 'Red', 'City', '6'),
	   (1, '008', 'Factory', 'R2', 'Green', 'City', '6'),
	   (3, '009', 'Factory', 'R3', 'Blue', 'City', '6'),
	   (3, '010', 'Factory', 'R1', 'Red', 'City', '6'),
	   (1, '011', 'Factory', 'R2', 'Green', 'City', '6'),
	   (3, '012', 'Factory', 'R3', 'Blue', 'City', '6'),
	   (1, '013', 'Factory', 'R1', 'Red', 'City', '6');