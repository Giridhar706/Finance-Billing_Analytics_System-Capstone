using FinanceBillingAnalytics.Models.Entities;
using FinanceBillingAnalytics.Repositories;
using FinanceBillingAnalytics.Services;
using Moq;
using Xunit;

namespace FinanceBillingAnalytics.Tests
{
    public class InvoiceServiceTests
    {
        private readonly Mock<IInvoiceRepository> _mockRepo;
        private readonly InvoiceService _service;

        public InvoiceServiceTests()
        {
            _mockRepo = new Mock<IInvoiceRepository>();
            _service = new InvoiceService(_mockRepo.Object);
        }

        [Fact]
        public async Task CreateInvoice_ValidInvoice_ShouldCallRepository()
        {
            var invoice = new Invoice
            {
                CustomerName = "ABC Ltd",
                Amount = 5000,
                DueDate = DateTime.Today.AddDays(5)
            };

            await _service.CreateInvoiceAsync(invoice);

            _mockRepo.Verify(r => r.AddAsync(invoice), Times.Once);
        }

        [Fact]
        public async Task CreateInvoice_AmountZero_ShouldThrowException()
        {
            var invoice = new Invoice
            {
                CustomerName = "ABC Ltd",
                Amount = 0,
                DueDate = DateTime.Today.AddDays(5)
            };

            await Assert.ThrowsAsync<ArgumentException>(
                () => _service.CreateInvoiceAsync(invoice));
        }

        [Fact]
        public async Task CreateInvoice_NegativeAmount_ShouldThrowException()
        {
            var invoice = new Invoice
            {
                CustomerName = "ABC Ltd",
                Amount = -100,
                DueDate = DateTime.Today.AddDays(5)
            };

            await Assert.ThrowsAsync<ArgumentException>(
                () => _service.CreateInvoiceAsync(invoice));
        }

        [Fact]
        public async Task CreateInvoice_PastDueDate_ShouldThrowException()
        {
            var invoice = new Invoice
            {
                CustomerName = "ABC Ltd",
                Amount = 1000,
                DueDate = DateTime.Today.AddDays(-1)
            };

            await Assert.ThrowsAsync<ArgumentException>(
                () => _service.CreateInvoiceAsync(invoice));
        }

        [Fact]
        public async Task CreateInvoice_EmptyCustomerName_ShouldThrowException()
        {
            var invoice = new Invoice
            {
                CustomerName = "",
                Amount = 1000,
                DueDate = DateTime.Today.AddDays(5)
            };

            await Assert.ThrowsAsync<ArgumentException>(
                () => _service.CreateInvoiceAsync(invoice));
        }

        [Fact]
        public async Task GetInvoiceById_ShouldReturnInvoice()
        {
            var invoice = new Invoice
            {
                InvoiceId = 1,
                CustomerName = "ABC Ltd",
                Amount = 2000,
                DueDate = DateTime.Today.AddDays(5)
            };

            _mockRepo.Setup(r => r.GetByIdAsync(1))
                     .ReturnsAsync(invoice);

            var result = await _service.GetInvoiceByIdAsync(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.InvoiceId);
        }
    }
}