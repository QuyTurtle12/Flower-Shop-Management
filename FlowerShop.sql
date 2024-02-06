USE [master]
GO
CREATE DATABASE [FlowerShop]
GO
USE [FlowerShop]
GO
-- User Table
CREATE TABLE [dbo].[User] (
    id int PRIMARY KEY,
    username VARCHAR(255),
    password VARCHAR(255),
    fullname VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(20),
    gender VARCHAR(20),
    role VARCHAR(20),
	status BIT
);

-- Order Table
CREATE TABLE [dbo].[Order] (
    id int PRIMARY KEY,
    user_id int REFERENCES [dbo].[User]([id]),
    ordered_date DATE,
    shipped_date DATE,
    total_price DECIMAL(10, 2),
    payment_method VARCHAR(50),
    status VARCHAR(20)
);

-- Flower Table
CREATE TABLE [dbo].[Flower] (
    id int PRIMARY KEY,
    name VARCHAR(255),
    season VARCHAR(20),
    unit_price DECIMAL(10, 2),
    description TEXT,
    stock INT
);

-- Order_Item Table
CREATE TABLE [dbo].[Order_Detail] (
    order_detail_id int IDENTITY(1,1), -- Added identity property
    order_id int REFERENCES [dbo].[Order]([id]),
    flower_id int REFERENCES [dbo].[Flower]([id]),
    amount INT,
    price DECIMAL(10, 2),
    PRIMARY KEY (order_detail_id)
);

-- Sample data for User Table
INSERT INTO [dbo].[User] (id, username, password, fullname, email, phone_number, gender, role, status)
VALUES
    (1, 'john_doe', 'password123', 'John Doe', 'john.doe@example.com', '1234567890', 'Male', 'Customer', 1),
    (2, 'jane_smith', 'securepass', 'Jane Smith', 'jane.smith@example.com', '9876543210', 'Female', 'Admin', 1),
	(3, 'staff_user', 'securepass123', 'Staff User', 'staff.user@example.com', '5551234567', 'Male', 'Staff', 1);


-- Sample data for Order Table
INSERT INTO [dbo].[Order] (id, user_id, ordered_date, shipped_date, total_price, payment_method, status)
VALUES
    (101, 1, '2024-02-06', '2024-02-08', 150.00, 'COD', 'Shipped'),
    (102, 2, '2024-02-07', NULL, 200.50, 'COD', 'Processing');

-- Sample data for Flower Table
INSERT INTO [dbo].[Flower] (id, name, season, unit_price, description, stock)
VALUES
    (201, 'Rose', 'Spring', 10.99, 'Beautiful red roses', 100),
    (202, 'Lily', 'Summer', 8.50, 'White lilies with a lovely fragrance', 75);

-- Sample data for Order_Detail Table
INSERT INTO [dbo].[Order_Detail] (order_id, flower_id, amount, price)
VALUES
    (101, 201, 2, 21.98),
    (101, 202, 1, 8.50),
    (102, 201, 3, 32.97);
