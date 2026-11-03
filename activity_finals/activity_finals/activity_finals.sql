IF DB_ID('activity_finals') IS NULL
    CREATE DATABASE activity_finals;
GO

USE activity_finals;
GO

IF OBJECT_ID('users', 'U') IS NULL
CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL
);
GO

IF OBJECT_ID('products', 'U') IS NULL
CREATE TABLE products (
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_name NVARCHAR(100) NOT NULL,
    category NVARCHAR(50) NOT NULL,
    date_added DATE NOT NULL,
    stock INT NOT NULL,
    price DECIMAL(10,2) NOT NULL
);
GO

IF NOT EXISTS (SELECT 1 FROM products)
INSERT INTO products (product_name, category, date_added, stock, price) VALUES
('Intel Core i5 Processor', 'Processor', '2026-10-28', 25, 12500),
('DDR4 8GB RAM', 'Memory', '2026-10-29', 100, 1850),
('1TB Hard Drive', 'Storage', '2026-10-30', 40, 3200),
('500GB SSD', 'Storage', '2026-10-31', 55, 2400),
('RTX 3060 Graphics Card', 'Graphics Card', '2026-11-01', 8, 18900);
GO