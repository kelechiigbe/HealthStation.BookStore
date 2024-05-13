namespace HealthStation.BookStore.Application.Interface
{
    /// <summary>
    /// Represents a unit of work interface for managing repositories and transactions.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets the repository for managing books.
        /// </summary>
        IBookRepository Books { get; }

        /// <summary>
        /// Gets the repository for managing authors.
        /// </summary>
        IAuthorRepository Authors { get; }

        /// <summary>
        /// Gets the repository for managing transactions.
        /// </summary>
        ITransactionRepository Transactions { get; }

        /// <summary>
        /// Saves changes synchronously.
        /// </summary>
        int Complete();

        /// <summary>
        /// Saves changes asynchronously.
        /// </summary>
        Task<int> CompleteAsync();
    }

}
