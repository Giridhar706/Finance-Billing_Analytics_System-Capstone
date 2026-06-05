using FinanceBillingAnalytics.Models.Entities;
using FinanceBillingAnalytics.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBillingAnalytics.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public async Task<IActionResult> Index()
        {
            var invoices = await _invoiceService.GetAllInvoicesAsync();
            return View(invoices);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                await _invoiceService.CreateInvoiceAsync(invoice);
                return RedirectToAction(nameof(Index));
            }

            return View(invoice);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var invoice = await _invoiceService.GetInvoiceByIdAsync(id);

            if (invoice == null)
                return NotFound();

            return View(invoice);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                await _invoiceService.UpdateInvoiceAsync(invoice);
                return RedirectToAction(nameof(Index));
            }

            return View(invoice);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _invoiceService.DeleteInvoiceAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAjax(int id)
        {
            await _invoiceService.DeleteInvoiceAsync(id);

            return Ok();
        }
    }
}