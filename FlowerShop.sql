USE [master]
GO
CREATE DATABASE [FlowerShop]
GO
USE [FlowerShop]
GO
-- User Table
CREATE TABLE [dbo].[User] (
    id VARCHAR(10) PRIMARY KEY,
    username VARCHAR(255),
    password VARCHAR(255),
    fullname VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(20),
    gender VARCHAR(10),
    role VARCHAR(20),
);

-- Order Table
CREATE TABLE [dbo].[Order] (
    id VARCHAR(10) PRIMARY KEY,
    user_id VARCHAR(10) REFERENCES [dbo].[User]([id]),
    ordered_date DATE,
    shipped_date DATE,
    total_price DECIMAL(10, 2),
    payment_method VARCHAR(50),
    status VARCHAR(20)
);

-- Flower Table
CREATE TABLE [dbo].[Flower] (
    id VARCHAR(10) PRIMARY KEY,
    name VARCHAR(255),
    season VARCHAR(20),
    unit_price DECIMAL(10, 2),
    description TEXT,
    stock INT
);

-- Order_Item Table
CREATE TABLE [dbo].[Order_Detail] (
	order_detail_id VARCHAR(10),
    order_id VARCHAR(10) REFERENCES [dbo].[Order]([id]),
    flower_id VARCHAR(10) REFERENCES [dbo].[Flower]([id]),
    amount INT,
    price DECIMAL(10, 2),
    PRIMARY KEY (order_detail_id)
);

-- User Table
INSERT INTO [dbo].[User] (id, username, password, fullname, email, phone_number, gender, role)
VALUES
('CS001', 'customer1', '123', 'John Doe', 'john.doe@example.com', '1234567890', 'Male', 'Customer'),
('ST001', 'staff1', 'staffpass', 'Jane Smith', 'jane.smith@example.com', '9876543210', 'Female', 'Staff'),
('AD001', 'admin1', 'adminpass', 'Admin User', 'admin@example.com', '5555555555', 'Non-Binary', 'Admin'),
('CS002', 'customer2', 'securepass', 'Alice Johnson', 'alice.johnson@example.com', '1112233444', 'Female', 'Customer'),
('ST002', 'staff2', 'pass123', 'Bob Miller', 'bob.miller@example.com', '9998887777', 'Male', 'Staff'),
('CS003', 'customer3', 'passpass', 'Eva Brown', 'eva.brown@example.com', '7776665555', 'Female', 'Customer'),
('ST003', 'staff3', 'staff123', 'Michael Lee', 'michael.lee@example.com', '3332221111', 'Male', 'Staff'),
('CS004', 'customer4', 'customerpass', 'Sophie Wilson', 'sophie.wilson@example.com', '4445556666', 'Non-Binary', 'Customer'),
('CS005', 'customer5', 'passpass', 'Chris Davis', 'chris.davis@example.com', '8889990000', 'Male', 'Customer'),
('ST004', 'staff4', 'securestaff', 'Olivia Johnson', 'olivia.johnson@example.com', '1231231234', 'Female', 'Staff');

-- Flower Table
INSERT INTO [dbo].[Flower] (id, name, season, unit_price, description, stock)
VALUES
('F001', 'Rose', 'Spring', 12.99, 'Beautiful red roses for any occasion.', 100),
('F002', 'Tulip', 'Spring', 8.50, 'Colorful tulips to brighten your day.', 150),
('F003', 'Sunflower', 'Summer', 9.99, 'Cheerful sunflowers to bring sunshine into your life.', 120),
('F004', 'Lily', 'Summer', 14.75, 'Elegant lilies for a touch of sophistication.', 90),
('F005', 'Daisy', 'Spring', 7.25, 'Simple and charming daisies for a sweet gesture.', 200),
('F006', 'Orchid', 'Fall', 18.50, 'Exotic orchids for a unique and stunning arrangement.', 80),
('F007', 'Carnation', 'Fall', 6.99, 'Classic carnations suitable for any occasion.', 180),
('F008', 'Chrysanthemum', 'Fall', 10.25, 'Colorful chrysanthemums for vibrant displays.', 110),
('F009', 'Poinsettia', 'Winter', 15.99, 'Festive poinsettias for the holiday season.', 60),
('F010', 'Hydrangea', 'Summer', 11.50, 'Hydrangeas in various colors to complement any decor.', 130);

-- Order Table
INSERT INTO [dbo].[Order] (id, user_id, ordered_date, shipped_date, total_price, payment_method, status)
VALUES
('O001', 'CS001', '2024-01-15', '2024-01-20', 59.95, 'COD', 'Delivering'),
('O002', 'CS002', '2024-02-02', '2024-02-08', 36.25, 'COD', 'Finished'),
('O003', 'CS003', '2024-03-10', '2024-03-15', 39.46, 'COD', 'Processing');

-- Order_Item Table
INSERT INTO [dbo].[Order_Detail] (order_detail_id,order_id, flower_id, amount, price)
VALUES
('001','O001', 'F001', 3, 38.97),
('002','O001', 'F003', 2, 19.98),
('003','O002', 'F005', 5, 36.25),
('004','O003', 'F007', 4, 27.96),
('005','O003', 'F010', 1, 11.50);
