using FinanceBillingAnalytics.Models.Entities;

namespace FinanceBillingAnalytics.Repositories
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetAllAsync();

        Task<Payment?> GetByIdAsync(int id);

        Task AddAsync(Payment payment);

        Task DeleteAsync(int id);
    }
}
