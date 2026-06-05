using Microsoft.Data.SqlClient;

namespace FinanceBillingAnalytics.Repositories
{
    public class RevenueRepositoryADO
    {
        private readonly string _connectionString;

        public RevenueRepositoryADO(IConfiguration configuration)
        {
            _connectionString =
                configuration.GetConnectionString("DefaultConnection")!;
        }

        public decimal GetTotalRevenue()
        {
            decimal revenue = 0;

            using SqlConnection connection =
                new SqlConnection(_connectionString);

            connection.Open();

            SqlCommand command =
                new SqlCommand(
                    "SELECT ISNULL(SUM(Amount),0) FROM Invoices",
                    connection);

            var result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                revenue = Convert.ToDecimal(result);
            }

            return revenue;
        }
    }
}
