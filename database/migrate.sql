-- Run once in SQL Server Management Studio against the LoginDB database,
-- before starting the updated app.

USE LoginDB;
GO

-- 1. Hashed passwords are 83 characters long; make sure the column can hold them.
--    (If your column was NOT NULL, keep NOT NULL here.)
ALTER TABLE registrationone ALTER COLUMN password NVARCHAR(200);
GO

-- 2. New login history table: records who logged in and when, never the password.
IF OBJECT_ID('dbo.LoginHistory', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.LoginHistory (
        id         INT IDENTITY(1,1) PRIMARY KEY,
        username   NVARCHAR(100) NOT NULL,
        login_time DATETIME      NOT NULL
    );
END
GO

-- 3. The old logintab table stored every password in plain text. Remove it.
IF OBJECT_ID('dbo.logintab', 'U') IS NOT NULL
    DROP TABLE dbo.logintab;
GO

-- Existing accounts keep working: the first time each user logs in, the app checks
-- the old plain-text password once and replaces it with a hash automatically.
