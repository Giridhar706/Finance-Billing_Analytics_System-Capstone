using FinanceBillingAnalytics.Models.Entities;
using FinanceBillingAnalytics.Repositories;

namespace FinanceBillingAnalytics.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<List<Payment>> GetAllPaymentsAsync()
        {
            return await _paymentRepository.GetAllAsync();
        }

        public async Task<Payment?> GetPaymentByIdAsync(int id)
        {
            return await _paymentRepository.GetByIdAsync(id);
        }

        public async Task AddPaymentAsync(Payment payment)
        {
            if (payment.AmountPaid <= 0)
                throw new ArgumentException("Invalid payment amount");

            if (string.IsNullOrWhiteSpace(payment.PaymentMethod))
                throw new ArgumentException("Payment method required");

            await _paymentRepository.AddAsync(payment);
        }

        public async Task DeletePaymentAsync(int id)
        {
            await _paymentRepository.DeleteAsync(id);
        }
    }
}