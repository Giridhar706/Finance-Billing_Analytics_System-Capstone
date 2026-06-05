using FinanceBillingAnalytics.Data;
using FinanceBillingAnalytics.Models.ViewModels;
using FinanceBillingAnalytics.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBillingAnalytics.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RevenueRepositoryADO _revenueRepository;

        public DashboardController(
            ApplicationDbContext context,
            RevenueRepositoryADO revenueRepository)
        {
            _context = context;
            _revenueRepository = revenueRepository;
        }

        public IActionResult Index()
        {
            DashboardViewModel model =
                new DashboardViewModel();

            model.TotalInvoices =
                _context.Invoices.Count();

            model.TotalPayments =
                _context.Payments.Count();

            model.PaidInvoices =
                _context.Invoices
                    .Count(x => x.Status == "Paid");

            // ADO.NET Implementation
            model.TotalRevenue =
                _revenueRepository.GetTotalRevenue();

            return View(model);
        }
    }
}