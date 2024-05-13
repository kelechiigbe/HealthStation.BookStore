using HealthStation.BookStore.Application.Interface;

namespace HealthStation.BookStore.Infrastructure.Data
{
    /// <summary>
    /// Represents a unit of work for managing transactions across repositories.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreDbContext _context;

        /// <summary>
        /// Gets the transaction repository.
        /// </summary>
        public ITransactionRepository Transactions { get; }

        /// <summary>
        /// Gets the author repository.
        /// </summary>
        public IAuthorRepository Authors { get; }

        /// <summary>
        /// Gets the book repository.
        /// </summary>
        public IBookRepository Books { get; }

        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        public UnitOfWork(BookStoreDbContext bookStoreContext, IBookRepository bookRepository, IAuthorRepository authorRepository, ITransactionRepository transactionRepository)
        {
            _context = bookStoreContext;
            Books = bookRepository;
            Authors = authorRepository;
            Transactions = transactionRepository;
        }

        /// <summary>
        /// Saves changes synchronously to the database.
        /// </summary>
        /// <returns>The number of state entries written to the database.</returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Saves changes asynchronously to the database.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The task result contains the number of state entries written to the database.</returns>
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Disposes the context and suppresses finalization.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the context.
        /// </summary>
        /// <param name="disposing">A boolean value indicating whether the object is being disposed.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }

}
