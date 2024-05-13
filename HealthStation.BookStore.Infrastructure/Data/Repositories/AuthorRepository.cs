using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Application.ViewModel.Responses;
using HealthStation.BookStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace HealthStation.BookStore.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Repository for handling Author entities.
    /// </summary>
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        /// <summary>
        /// Constructor for AuthorRepository.
        /// </summary>
        /// <param name="context">The database context.</param>
        public AuthorRepository(BookStoreDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Retrieves the top selling authors based on sales data.
        /// </summary>
        /// <param name="topAuthorsCount">The number of top authors to retrieve.</param>
        /// <returns>A list of top selling authors.</returns>
        public async Task<IEnumerable<TopSellingAuthorsResponse>> GetTopSellingAuthorsAsync(int topAuthorsCount)
        {
            var topSellingAuthors = await _context.Transactions
                .Include(t => t.Book)
                .ThenInclude(a => a.Transactions)
                .GroupBy(t => t.Book.Author.Name)
                .Select(g => new TopSellingAuthorsResponse
                {
                    AuthorName = g.Key,
                    TotalSales = g.Sum(t => t.Quantity * t.UnitPrice)
                })
                .OrderByDescending(a => a.TotalSales)
                .Take(topAuthorsCount)
                .ToListAsync();

            return topSellingAuthors?? Enumerable.Empty<TopSellingAuthorsResponse>();
        }
    }
}
