using FinanceBillingAnalytics.Models.Entities;
using FinanceBillingAnalytics.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBillingAnalytics.Controllers
{
    public class PaymentController : Controller
    {
        private readonly PaymentService _paymentService;

        public PaymentController(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public async Task<IActionResult> Index()
        {
            var payments = await _paymentService.GetAllPaymentsAsync();

            return View(payments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Payment payment)
        {
            if (ModelState.IsValid)
            {
                await _paymentService.AddPaymentAsync(payment);

                return RedirectToAction(nameof(Index));
            }

            return View(payment);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _paymentService.DeletePaymentAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAjax(int id)
        {
            await _paymentService.DeletePaymentAsync(id);

            return Ok();
        }
    }
}