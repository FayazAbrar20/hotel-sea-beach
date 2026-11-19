-- Creates the LoginDB database from scratch, for a computer that does not have it yet.
-- Use this INSTEAD of migrate.sql on a new machine.
-- Table and column names match what the app's code reads and writes.

IF DB_ID('LoginDB') IS NULL
    CREATE DATABASE LoginDB;
GO

USE LoginDB;
GO

-- User accounts. Column order matters: the registration screen inserts values in this order,
-- and the login screen reads role from column 1 and status from column 9.
CREATE TABLE dbo.registrationone (
    id        INT IDENTITY(1,1) PRIMARY KEY,
    role      NVARCHAR(20)  NOT NULL,
    username  NVARCHAR(100) NOT NULL UNIQUE,
    password  NVARCHAR(200) NOT NULL,   -- salted PBKDF2 hash
    email     NVARCHAR(200) NOT NULL,
    mobile    NVARCHAR(30)  NOT NULL,
    dob       NVARCHAR(50)  NOT NULL,
    gender    NVARCHAR(20)  NOT NULL,
    address   NVARCHAR(300) NOT NULL,
    status    INT           NOT NULL DEFAULT 0   -- 1 = active, 0 = waiting for a Manager
);
GO

-- Rooms.
CREATE TABLE dbo.addroom (
    roomid     INT IDENTITY(1,1) PRIMARY KEY,
    roomnumber NVARCHAR(20) NOT NULL UNIQUE,
    bedtype    NVARCHAR(50) NOT NULL,
    roomtype   NVARCHAR(50) NOT NULL,
    price      INT          NOT NULL,
    booked     NVARCHAR(3)  NOT NULL DEFAULT 'NO'
);
GO

-- Bookings.
CREATE TABLE dbo.Customerroombook (
    id           INT IDENTITY(1,1) PRIMARY KEY,
    roomid       INT          NOT NULL,
    roomnumber   NVARCHAR(20) NOT NULL,
    bedtype      NVARCHAR(50) NOT NULL,
    roomtype     NVARCHAR(50) NOT NULL,
    price        INT          NOT NULL,
    numberOfDays INT          NOT NULL,
    PricePerDay  INT          NOT NULL,
    booked       NVARCHAR(3)  NOT NULL
);
GO

-- Login history (username and time only, never the password).
CREATE TABLE dbo.LoginHistory (
    id         INT IDENTITY(1,1) PRIMARY KEY,
    username   NVARCHAR(100) NOT NULL,
    login_time DATETIME      NOT NULL
);
GO

-- First account: open the app, click Register, choose role "Manager".
-- Manager accounts are activated automatically, so you can log in straight away.
