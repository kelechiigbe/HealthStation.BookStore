using HealthStation.BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Application.Interface
{
    /// <summary>
    /// Represents a repository for managing books.
    /// </summary>
    public interface IBookRepository : IGenericRepository<Book>
    {
        /// <summary>
        /// Deletes books by their IDs.
        /// </summary>
        /// <param name="bookIds">The list of book IDs to delete.</param>
        /// <returns>A boolean indicating the success of the operation.</returns>
        Task<bool> DeleteBooksByIdsAsync(List<Guid> bookIds);
    }

}
