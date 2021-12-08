CREATE DATABASE Autoservice;
USE Autoservice;

CREATE TABLE Users(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Nickname VARCHAR(25) NOT NULL,
	Pass VARCHAR(25) NOT NULL,
	User_type BIT NOT NULL,
);

CREATE TABLE CarStatus(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Condition VARCHAR(50) NOT NULL,
);

CREATE TABLE Car(
	id INT IDENTITY(1,1) PRIMARY KEY,
	IsTruck BIT NOT NULL,
	Model VARCHAR(50) NOT NULL,
	CarType VARCHAR(50) NOT NULL,
	Manufacturer VARCHAR(25) NOT NULL,
	CarAssembly VARCHAR(50) NOT NULL,
	CarNumber VARCHAR(10),
	StatusId INT,
	FOREIGN KEY (StatusId) REFERENCES CarStatus (id) ON DELETE CASCADE,
);

CREATE TABLE Accounting(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	CarId INT NOT NULL,
	Mileage INT,
	EngineStatus VARCHAR(100) NOT NULL,
	ChassisStatus VARCHAR(100) NOT NULL,
	CarcassStatus VARCHAR(100) NOT NULL,
	FOREIGN KEY (CarId) REFERENCES Car (id) ON DELETE CASCADE,
);

--CREATE TABLE ServiceType(
--	id INT IDENTITY(1,1) PRIMARY KEY,
--	TypeService VARCHAR(50) NOT NULL,
--	TimePeriod VARCHAR(50) NOT NULL,
--);

--CREATE TABLE IntermediateTotals(
--	id INT IDENTITY(1,1) PRIMARY KEY,
--	CarId INT NOT NULL,
--	ServiceTypeId INT NOT NULL,
--	DateOfSerivce VARCHAR(50) NOT NULL,
--	FOREIGN KEY (CarId) REFERENCES Car (id) ON DELETE CASCADE,
--	FOREIGN KEY (ServiceTypeId) REFERENCES ServiceType (id) ON DELETE CASCADE,
--);

--Add data
USE Autoservice;

INSERT INTO CarStatus
VALUES	('Serviceable operated'),
		('Serviceable not exploited'),
		('Faulty being repaired'),
		('Defective cannot be repaired'),
		('Decommissioned')

INSERT INTO Car
VALUES (0, 'Audi', 'Sedan', 'Germany', '123', 'AB-9874-7', 2),
	   (1, 'BMW', 'Tank car', 'Germany', '568', 'AM-1111-7', 5),
	   (0, 'Peugeot', 'Sedan', 'Europe', '56as8', 'AM-1222-2', 3),
	   (0, 'Skoda', 'Sedan', 'Europe', '5dd68', 'PP-6711-4', 1),
	   (0, 'Mazda', 'Hatchback', 'Japan', '52eeee68', 'OB-4771-3', 1),
	   (1, 'Skoda', 'Auto transporter', 'Europe', '1111q568', 'PA-6721-4', 1),
	   (0, 'Mazda', 'Coupe', 'Japan', 'qqAll', 'AA-1771-2', 1),
	   (0, 'Skoda', 'Sedan', 'Europe', 'zxc', 'PP-6721-4', 1),
	   (0, 'Mazda', 'Hatchback', 'Japan', 'aaaaaaa', 'OB-1771-3', 1),
	   (0, 'Lada (ÂÀÇ)', 'Cabriolet', 'Russia', '568', 'AM-3333-3', 5),
	   (1, 'Ford', 'Euro truck', 'USA', '1337', 'OO-9999-1', NULL),
	   (0, 'Opel', 'Sedan', 'Germany', '228', 'AM-1337-3', NULL),
	   (0, 'Toyota', 'Sedan', 'Japan', '322', 'BP-4720-4', NULL);

INSERT INTO Users
VALUES ('admin', 'admin', 1),
	   ('user', 'user', 0)