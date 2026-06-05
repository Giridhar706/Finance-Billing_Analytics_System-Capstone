using System.ComponentModel.DataAnnotations;

namespace FinanceBillingAnalytics.Models.Entities
{
    public class AuditLog
    {
        [Key]
        public int AuditId { get; set; }

        public string ActionPerformed { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public DateTime ActionDate { get; set; }
    }
}