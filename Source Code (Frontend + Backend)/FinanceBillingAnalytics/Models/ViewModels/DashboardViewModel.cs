namespace FinanceBillingAnalytics.Models.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalInvoices { get; set; }

        public int TotalPayments { get; set; }

        public int PaidInvoices { get; set; }

        public decimal TotalRevenue { get; set; }
    }
}