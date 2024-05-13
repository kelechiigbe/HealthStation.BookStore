using HealthStation.BookStore.Application.ViewModel.Requests;
using HealthStation.BookStore.Domain;

namespace HealthStation.BookStore.Application.Interface
{
    /// <summary>
    /// Represents a transaction repository interface.
    /// </summary>
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        /// <summary>
        /// Gets the revenue generated over a specific period.
        /// </summary>
        /// <param name="reportingPeriodRequest">The reporting period request.</param>
        /// <returns>The revenue generated over the specified period.</returns>
        Task<decimal> GetRevenueGeneratedOverPeriodAsync(ReportingPeriodRequest reportingPeriodRequest);
    }
}
