CREATE TABLE Pacientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Edad INT,
    Diagnostico VARCHAR(200)
);
select * from Pacientes
--Ejercicio 7
CREATE TABLE Ventas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Cliente VARCHAR(100),
    Producto VARCHAR(100),
    Cantidad INT,
    Precio DECIMAL(10,2)

);


CREATE TABLE Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Cliente VARCHAR(100),
    Fecha DATETIME
);

CREATE TABLE DetalleFactura (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FacturaId INT,
    Producto VARCHAR(100),
    Cantidad INT,
    Precio DECIMAL(10,2),
    FOREIGN KEY (FacturaId) REFERENCES Facturas(Id)
);
--Ejercicio 10
CREATE TABLE Carreras (
    Id INT PRIMARY KEY IDENTITY,
    NombreCarrera VARCHAR(100)
);

CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100),
    Edad INT,
    CarreraId INT,
    FOREIGN KEY (CarreraId) REFERENCES Carreras(Id)
);
select * from  Carreras
select * from Estudiantes
select * from Ventas
