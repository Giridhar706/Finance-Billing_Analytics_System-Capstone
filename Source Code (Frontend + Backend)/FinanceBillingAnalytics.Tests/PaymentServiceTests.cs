using FinanceBillingAnalytics.Models.Entities;
using FinanceBillingAnalytics.Repositories;
using FinanceBillingAnalytics.Services;
using Moq;
using Xunit;

namespace FinanceBillingAnalytics.Tests
{
    public class PaymentServiceTests
    {
        private readonly Mock<IPaymentRepository> _mockRepo;
        private readonly PaymentService _service;

        public PaymentServiceTests()
        {
            _mockRepo = new Mock<IPaymentRepository>();
            _service = new PaymentService(_mockRepo.Object);
        }

        [Fact]
        public async Task AddPayment_ValidPayment_ShouldCallRepository()
        {
            var payment = new Payment
            {
                InvoiceId = 1,
                AmountPaid = 1000,
                PaymentMethod = "UPI",
                PaymentDate = DateTime.Today
            };

            await _service.AddPaymentAsync(payment);

            _mockRepo.Verify(r => r.AddAsync(payment), Times.Once);
        }

        [Fact]
        public async Task GetPaymentById_ShouldReturnPayment()
        {
            var payment = new Payment
            {
                PaymentId = 1,
                InvoiceId = 1,
                AmountPaid = 1000,
                PaymentMethod = "UPI"
            };

            _mockRepo.Setup(r => r.GetByIdAsync(1))
                     .ReturnsAsync(payment);

            var result = await _service.GetPaymentByIdAsync(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.PaymentId);
        }

        [Fact]
        public async Task DeletePayment_ShouldCallRepository()
        {
            await _service.DeletePaymentAsync(1);

            _mockRepo.Verify(r => r.DeleteAsync(1), Times.Once);
        }
    }
}