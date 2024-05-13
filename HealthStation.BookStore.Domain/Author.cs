using HealthStation.BookStore.Domain.Interfaces;

namespace HealthStation.BookStore.Domain
{
    /// <summary>
    /// Represents an author entity with related books.
    /// </summary>
    public class Author : BaseEntity, IAuditEntity
    {
        /// <summary>
        /// Gets or sets the name of the author.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the collection of books written by the author.
        /// </summary>
        public ICollection<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who created the author entity.
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who last modified the author entity.
        /// </summary>
        public Guid ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the author entity was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the author entity was last modified.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
