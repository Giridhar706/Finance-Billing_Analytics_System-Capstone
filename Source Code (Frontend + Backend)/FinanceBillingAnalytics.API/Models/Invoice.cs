namespace FinanceBillingAnalytics.API.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public string InvoiceNumber { get; set; } = string.Empty;

        public string CustomerName { get; set; } = string.Empty;

        public DateTime InvoiceDate { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Amount { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}