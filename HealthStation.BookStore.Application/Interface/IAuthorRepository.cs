using HealthStation.BookStore.Application.ViewModel.Responses;
using HealthStation.BookStore.Domain;

namespace HealthStation.BookStore.Application.Interface
{
    /// <summary>
    /// Represents the Author Repository interface.
    /// </summary>
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        /// <summary>
        /// Gets the top selling authors based on the specified count.
        /// </summary>
        /// <param name="topAuthorsCount">The number of top authors to retrieve.</param>
        /// <returns>A collection of top selling authors.</returns>
        Task<IEnumerable<TopSellingAuthorsResponse>> GetTopSellingAuthors(int topAuthorsCount);
    }

}
