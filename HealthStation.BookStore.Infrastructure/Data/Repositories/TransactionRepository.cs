using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Application.ViewModel.Requests;
using HealthStation.BookStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace HealthStation.BookStore.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Represents a repository for transactions.
    /// </summary>
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public TransactionRepository(BookStoreDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets the total revenue generated over a specified period.
        /// </summary>
        /// <param name="reportingPeriodRequest">The reporting period request.</param>
        /// <returns>The total revenue generated.</returns>
        public async Task<decimal> GetRevenueGeneratedOverPeriod(ReportingPeriodRequest reportingPeriodRequest)
        {
            decimal totalRevenue = await _context.Transactions
                                    .Where(t => t.CreatedDate >= reportingPeriodRequest.StartDate && t.CreatedDate <= reportingPeriodRequest.EndDate)
                                    .SumAsync(t => t.UnitPrice * t.Quantity);

            return totalRevenue;
        }
    }

}
