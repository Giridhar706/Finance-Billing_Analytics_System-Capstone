-- =========================================
-- STORED PROCEDURES
-- Finance Billing Analytics
-- =========================================

-- =========================================
-- REVENUE SUMMARY PROCEDURE
-- Uses JOIN between Invoices and Payments
-- =========================================

CREATE PROCEDURE sp_GetRevenueSummary
AS
BEGIN

    SELECT
        COUNT(DISTINCT i.InvoiceId) AS TotalInvoices,
        SUM(p.AmountPaid) AS TotalRevenue,
        COUNT(p.PaymentId) AS TotalPayments
    FROM Invoices i
    INNER JOIN Payments p
        ON i.InvoiceId = p.InvoiceId;

END;
GO


-- =========================================
-- GET ALL PAID INVOICES
-- =========================================

CREATE PROCEDURE sp_GetPaidInvoices
AS
BEGIN

    SELECT
        InvoiceId,
        InvoiceNumber,
        CustomerName,
        Amount,
        Status
    FROM Invoices
    WHERE Status = 'Paid';

END;
GO


-- =========================================
-- GET PAYMENT DETAILS WITH INVOICE INFO
-- Demonstrates JOIN usage
-- =========================================

CREATE PROCEDURE sp_GetPaymentDetails
AS
BEGIN

    SELECT
        p.PaymentId,
        p.AmountPaid,
        p.PaymentDate,
        p.PaymentMethod,
        i.InvoiceNumber,
        i.CustomerName
    FROM Payments p
    INNER JOIN Invoices i
        ON p.InvoiceId = i.InvoiceId;

END;
GO