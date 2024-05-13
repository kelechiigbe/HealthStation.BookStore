
namespace HealthStation.BookStore.Application.ViewModel.Requests
{
    /// <summary>
    /// Represents a request to delete books.
    /// </summary>
    public record BookDeleteRequest
    {
        /// <summary>
        /// Gets or initializes a list of book IDs to delete.
        /// </summary>
        public List<Guid> BookIds { get; init; }
    }

}
