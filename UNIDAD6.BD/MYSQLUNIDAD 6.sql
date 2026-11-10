-- Crear 
CREATE DATABASE IF NOT EXISTS Tienda;
USE Tienda;

-- ELIMINAR LA QUE EXISTIA
DROP TABLE IF EXISTS Pedidos;
DROP TABLE IF EXISTS Clientes;

-- Crear la tabla Clientes
CREATE TABLE Clientes (
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL
);

-- Crear la tabla Pedidos
CREATE TABLE Pedidos (
    IdPedido INT AUTO_INCREMENT PRIMARY KEY,
    IdCliente INT NOT NULL,
    FechaPedido DATE NOT NULL,
    TotalPagar DECIMAL(10,2) NOT NULL,
    EstadoEnvio VARCHAR(50) NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);

--  Insertar primero los registros en Clientes 
INSERT INTO Clientes (Nombre, Correo) VALUES ('Juan Pérez', 'juan@mail.com');
INSERT INTO Clientes (Nombre, Correo) VALUES ('Ana López', 'ana@mail.com');

-- registros en Pedidos 
INSERT INTO Pedidos (IdCliente, FechaPedido, TotalPagar, EstadoEnvio) VALUES (1, '2026-11-10', 45000.00, 'Entregado');
INSERT INTO Pedidos (IdCliente, FechaPedido, TotalPagar, EstadoEnvio) VALUES (2, '2026-11-11', 12500.50, 'Pendiente');

--  Desactivar el modo seguro temporalmente 
SET SQL_SAFE_UPDATES = 0;

-- Borrar primero el pedido de Ana 
DELETE FROM Pedidos WHERE IdCliente = 2;

--Borrar a Ana López de la tabla Clientes
DELETE FROM Clientes WHERE Nombre = 'Ana López';
