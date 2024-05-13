using HealthStation.BookStore.Application.Interface;
using Microsoft.EntityFrameworkCore;

namespace HealthStation.BookStore.Infrastructure.Data.Repositories
{
    /// <summary>
    /// A generic repository class for handling CRUD operations on entities of type T.
    /// </summary>
    /// <remarks>
    /// Constructor for initializing the repository with a database context.
    /// </remarks>
    public abstract class GenericRepository<T>(BookStoreDbContext context) : IGenericRepository<T> where T : class
    {
        protected readonly BookStoreDbContext _context = context;

        /// <summary>
        /// Asynchronously retrieves an entity by its unique identifier.
        /// </summary>
        public async Task<T> GetAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// Asynchronously retrieves all entities of type T.
        /// </summary>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        /// <summary>
        /// Asynchronously adds a new entity to the repository.
        /// </summary>
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Updates the state of an entity in the repository.
        /// </summary>
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }

}
