-- =========================================
-- DATABASE: FinanceBillingDB
-- DDL SCRIPT
-- =========================================

-- =========================================
-- USERS TABLE
-- =========================================

CREATE TABLE Users
(
    UserId INT IDENTITY(1,1) PRIMARY KEY,

    FullName NVARCHAR(100) NOT NULL,

    Email NVARCHAR(100) UNIQUE NOT NULL,

    PasswordHash NVARCHAR(255) NOT NULL,

    Role NVARCHAR(50) NOT NULL,

    CreatedDate DATETIME DEFAULT GETDATE()
);

GO

-- =========================================
-- INVOICES TABLE
-- =========================================

CREATE TABLE Invoices
(
    InvoiceId INT IDENTITY(1,1) PRIMARY KEY,

    InvoiceNumber NVARCHAR(50) UNIQUE NOT NULL,

    CustomerName NVARCHAR(100) NOT NULL,

    InvoiceDate DATETIME NOT NULL,

    DueDate DATETIME NOT NULL,

    Amount DECIMAL(18,2) NOT NULL,

    Status NVARCHAR(50) NOT NULL,

    CreatedDate DATETIME DEFAULT GETDATE()
);

GO

-- =========================================
-- PAYMENTS TABLE
-- =========================================

CREATE TABLE Payments
(
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,

    InvoiceId INT NOT NULL,

    AmountPaid DECIMAL(18,2) NOT NULL,

    PaymentDate DATETIME NOT NULL,

    PaymentMethod NVARCHAR(50),

    FOREIGN KEY (InvoiceId)
    REFERENCES Invoices(InvoiceId)
);

GO

-- =========================================
-- AUDIT LOGS TABLE
-- =========================================

CREATE TABLE AuditLogs
(
    AuditId INT IDENTITY(1,1) PRIMARY KEY,

    ActionPerformed NVARCHAR(255),

    UserName NVARCHAR(100),

    ActionDate DATETIME DEFAULT GETDATE()
);

GO