using FinanceBillingAnalytics.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace FinanceBillingAnalytics.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IConfiguration _configuration;

        public ReportsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult RevenueSummary()
        {
            RevenueSummaryViewModel model =
                new RevenueSummaryViewModel();

            string connectionString =
                _configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException(
                    "DefaultConnection not configured.");

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd =
                    new SqlCommand(
                        "sp_GetRevenueSummary",
                        con);

                cmd.CommandType =
                    System.Data.CommandType.StoredProcedure;

                SqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    model.TotalInvoices =
                        Convert.ToInt32(
                            reader["TotalInvoices"]);

                    model.TotalRevenue =
                        Convert.ToDecimal(
                            reader["TotalRevenue"]);
                }
            }

            return View(model);
        }
    }
}