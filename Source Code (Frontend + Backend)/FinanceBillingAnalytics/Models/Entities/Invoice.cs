using System.ComponentModel.DataAnnotations;

namespace FinanceBillingAnalytics.Models.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; } = string.Empty;

        public DateTime InvoiceDate { get; set; }

        public DateTime DueDate { get; set; }

        [Range(1, 1000000)]
        public decimal Amount { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }
    }
}