using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Application.Interface
{
    /// <summary>
    /// Generic repository interface for CRUD operations.
    /// </summary>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Get entity by id.
        /// </summary>
        Task<T> Get(Guid id);

        /// <summary>
        /// Get all entities.
        /// </summary>
        Task<IEnumerable<T>> GetAll();

        /// <summary>
        /// Add a new entity.
        /// </summary>
        Task Add(T entity);

        /// <summary>
        /// Delete an entity.
        /// </summary>
        void Delete(T entity);

        /// <summary>
        /// Update an entity.
        /// </summary>
        void Update(T entity);
    }

}
