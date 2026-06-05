-- =========================================
-- TRIGGER:
-- UPDATE INVOICE STATUS AFTER PAYMENT
-- =========================================

CREATE TRIGGER trg_UpdateInvoiceStatus
ON Payments
AFTER INSERT
AS
BEGIN

    UPDATE Invoices
    SET Status = 'Paid'
    WHERE InvoiceId IN
    (
        SELECT InvoiceId
        FROM inserted
    );

END;

GO