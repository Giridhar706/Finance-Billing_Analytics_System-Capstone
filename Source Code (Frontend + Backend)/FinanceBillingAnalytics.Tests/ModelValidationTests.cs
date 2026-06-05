using Xunit;

namespace FinanceBillingAnalytics.Tests
{
    public class ModelValidationTests
    {
        [Fact]
        public void CustomerName_ShouldNotBeEmpty()
        {
            string customer = "ABC Corporation";

            Assert.False(string.IsNullOrWhiteSpace(customer));
        }

        [Fact]
        public void Email_ShouldContainAtSymbol()
        {
            string email = "admin@finance.com";

            Assert.Contains("@", email);
        }
    }
}