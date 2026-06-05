using FinanceBillingAnalytics.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBillingAnalytics.Controllers
{
    public class AuditController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuditController(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var logs =
                _context.AuditLogs.ToList();

            return View(logs);
        }
    }
}
