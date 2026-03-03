-- Tabla de Usuarios (Login)
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY,
    Usuario TEXT,
    Contraseña TEXT,
    Estado BOOLEAN
);

-- Tabla de Clientes
CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY,
    NombreCliente TEXT,
    Apellido TEXT,
    Telefono TEXT,
    Email TEXT,
    Direccion TEXT
);

-- Tabla de Vendedores
CREATE TABLE Vendedores (
    IdVendedor INT PRIMARY KEY,
    NombreVendedor TEXT,
    Apellido TEXT,
    Telefono TEXT,
    Email TEXT
);

-- Tabla de Productos
CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY,
    NombreProducto TEXT,
    Precio CURRENCY,
    Stock INT,
    Descripcion TEXT
);

-- Tabla de Ventas (con claves foráneas)
CREATE TABLE Ventas (
    IdVenta INT PRIMARY KEY,
    IdCliente INT,
    IdVendedor INT,
    IdProducto INT,
    Cantidad INT,
    PrecioUnitario CURRENCY,
    SubTotal CURRENCY,
    Impuesto CURRENCY,
    Total CURRENCY,
    FechaVenta DATE,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdVendedor) REFERENCES Vendedores(IdVendedor),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);

-- DATOS DE PRUEBA
-- Usuarios
INSERT INTO Usuarios VALUES (1, 'admin', '1234', TRUE);
INSERT INTO Usuarios VALUES (2, 'usuario', '1234', TRUE);

-- Clientes
INSERT INTO Clientes VALUES (1, 'Juan', 'Perez', '12345678', 'juan@email.com', 'Calle 1');
INSERT INTO Clientes VALUES (2, 'Maria', 'Garcia', '87654321', 'maria@email.com', 'Calle 2');
INSERT INTO Clientes VALUES (3, 'Carlos', 'Lopez', '11223344', 'carlos@email.com', 'Calle 3');

-- Vendedores
INSERT INTO Vendedores VALUES (1, 'Pedro', 'Martinez', '55667788', 'pedro@email.com');
INSERT INTO Vendedores VALUES (2, 'Ana', 'Rodriguez', '99887766', 'ana@email.com');
INSERT INTO Vendedores VALUES (3, 'Luis', 'Sanchez', '44556677', 'luis@email.com');

-- Productos
INSERT INTO Productos VALUES (1, 'Laptop', 500.00, 10, 'Laptop HP');
INSERT INTO Productos VALUES (2, 'Mouse', 25.00, 50, 'Mouse inalámbrico');
INSERT INTO Productos VALUES (3, 'Teclado', 75.00, 30, 'Teclado mecánico');
INSERT INTO Productos VALUES (4, 'Monitor', 250.00, 15, 'Monitor 24"');
INSERT INTO Productos VALUES (5, 'Impresora', 150.00, 8, 'Impresora multifuncional');
