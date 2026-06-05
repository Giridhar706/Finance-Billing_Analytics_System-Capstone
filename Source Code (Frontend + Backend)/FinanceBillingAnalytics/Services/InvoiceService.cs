using FinanceBillingAnalytics.Models.Entities;
using FinanceBillingAnalytics.Repositories;

namespace FinanceBillingAnalytics.Services
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<List<Invoice>> GetAllInvoicesAsync()
        {
            return await _invoiceRepository.GetAllAsync();
        }

        public async Task<Invoice?> GetInvoiceByIdAsync(int id)
        {
            return await _invoiceRepository.GetByIdAsync(id);
        }

        public async Task CreateInvoiceAsync(Invoice invoice)
        {
            if (invoice.Amount <= 0)
                throw new ArgumentException("Invoice amount must be greater than zero");

            if (invoice.DueDate < DateTime.Today)
                throw new ArgumentException("Due date cannot be in the past");

            if (string.IsNullOrWhiteSpace(invoice.CustomerName))
                throw new ArgumentException("Customer name required");

            await _invoiceRepository.AddAsync(invoice);
        }

        public async Task UpdateInvoiceAsync(Invoice invoice)
        {
            await _invoiceRepository.UpdateAsync(invoice);
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            await _invoiceRepository.DeleteAsync(id);
        }
    }
}