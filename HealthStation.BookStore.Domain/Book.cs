using HealthStation.BookStore.Domain.Interfaces;

namespace HealthStation.BookStore.Domain
{
    public class Book : BaseEntity, IAuditEntity
    {
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the author of the book.
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets book transactions.
        /// </summary>
        public ICollection<Transaction> Transactions { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who created the book.
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who last modified the book.
        /// </summary>
        public Guid ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the book was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the book was last modified.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }


}
