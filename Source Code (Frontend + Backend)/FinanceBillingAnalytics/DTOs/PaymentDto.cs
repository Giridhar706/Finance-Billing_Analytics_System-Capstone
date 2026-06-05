namespace FinanceBillingAnalytics.DTOs
{
    public class PaymentDto
    {
        public int InvoiceId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
    }
}