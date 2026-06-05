# Finance & Billing Analytics – Business Rules

## Invoice Rules

1. Invoice Number must be unique.
2. Invoice Amount cannot be negative.
3. Due Date must be greater than or equal to Invoice Date.
4. Invoice Status can be Pending, Paid, or Overdue.

## Payment Rules

1. Payment Amount must be greater than zero.
2. Payment must be linked to a valid Invoice.
3. Payment Date cannot be null.
4. When a payment is recorded, the Invoice Status is automatically updated to Paid using a SQL Trigger.

## User Rules

1. Only authenticated users can access secured APIs.
2. Only Admin users can create, update, or delete Invoice records.
3. Only Admin users can create, update, or delete Payment records.

## Audit Rules

1. Important financial activities should be logged in the Audit Log table.
2. Audit records must contain action details, user name, and timestamp.

## Revenue Protection Rules

1. Payments must always reference an existing invoice.
2. Revenue reports are generated using payment data linked to invoices.
3. Unauthorized users cannot modify financial records.
