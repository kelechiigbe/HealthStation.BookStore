
using HealthStation.BookStore.Application.Exceptions;
using HealthStation.BookStore.Application.Extensions;
using System.Net;

namespace HealthStation.BookStore.Infrastructure.Exceptions
{
    /// <summary>
    /// Represents an exception thrown when books are not found.
    /// </summary>
    public class BookNotFoundException : BaseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookNotFoundException"/> class with the specified book IDs.
        /// </summary>
        /// <param name="bookIds">The list of book IDs that were not found.</param>
        public BookNotFoundException(List<Guid> bookIds)
            : base($"Books with id(s) {bookIds.ToCommaSeparatedString()} not found", HttpStatusCode.NotFound)
        {
        }
    }

}
