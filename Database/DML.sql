-- =========================================
-- DATABASE: FinanceBillingDB
-- DML SCRIPT
-- SAMPLE DATA
-- =========================================

-- =========================================
-- USERS
-- =========================================

INSERT INTO Users
(
    FullName,
    Email,
    PasswordHash,
    Role
)
VALUES
(
    'Admin User',
    'admin@finance.com',
    'Admin123',
    'Admin'
);

INSERT INTO Users
(
    FullName,
    Email,
    PasswordHash,
    Role
)
VALUES
(
    'Finance Executive',
    'finance@finance.com',
    'Finance123',
    'FinanceUser'
);

GO

-- =========================================
-- INVOICES
-- =========================================

INSERT INTO Invoices
(
    InvoiceNumber,
    CustomerName,
    InvoiceDate,
    DueDate,
    Amount,
    Status
)
VALUES
(
    'INV001',
    'ABC Corporation',
    GETDATE(),
    DATEADD(DAY,30,GETDATE()),
    5000.00,
    'Pending'
);

INSERT INTO Invoices
(
    InvoiceNumber,
    CustomerName,
    InvoiceDate,
    DueDate,
    Amount,
    Status
)
VALUES
(
    'INV002',
    'XYZ Limited',
    GETDATE(),
    DATEADD(DAY,30,GETDATE()),
    8500.00,
    'Pending'
);

INSERT INTO Invoices
(
    InvoiceNumber,
    CustomerName,
    InvoiceDate,
    DueDate,
    Amount,
    Status
)
VALUES
(
    'INV003',
    'Global Tech Solutions',
    GETDATE(),
    DATEADD(DAY,15,GETDATE()),
    12000.00,
    'Pending'
);

GO

-- =========================================
-- PAYMENTS
-- =========================================

INSERT INTO Payments
(
    InvoiceId,
    AmountPaid,
    PaymentDate,
    PaymentMethod
)
VALUES
(
    1,
    5000.00,
    GETDATE(),
    'UPI'
);

INSERT INTO Payments
(
    InvoiceId,
    AmountPaid,
    PaymentDate,
    PaymentMethod
)
VALUES
(
    2,
    3000.00,
    GETDATE(),
    'Net Banking'
);

GO

-- =========================================
-- AUDIT LOGS
-- =========================================

INSERT INTO AuditLogs
(
    ActionPerformed,
    UserName
)
VALUES
(
    'Created Invoice INV001',
    'Admin User'
);

INSERT INTO AuditLogs
(
    ActionPerformed,
    UserName
)
VALUES
(
    'Recorded Payment for Invoice INV001',
    'Finance Executive'
);

GO