using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Domain;
using HealthStation.BookStore.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Represents a repository for managing books.
    /// </summary>
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public BookRepository(BookStoreDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Deletes books by their IDs.
        /// </summary>
        /// <param name="bookIds">The list of book IDs to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task<bool> DeleteBooksByIds(List<Guid> bookIds)
        {
            var booksToDelete = await _context.Books
                         .Where(b => bookIds.Contains(b.Id))
                         .ToListAsync();

            if (booksToDelete.Count == 0)
            {
                throw new BookNotFoundException(bookIds);
            }

            if (booksToDelete.Count != 0)
            {
                _context.Books.RemoveRange(booksToDelete);
            }

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
