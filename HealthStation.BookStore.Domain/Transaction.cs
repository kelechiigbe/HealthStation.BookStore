using HealthStation.BookStore.Domain.Interfaces;

namespace HealthStation.BookStore.Domain
{
    public class Transaction : BaseEntity, IAuditEntity
    {
        /// <summary>
        /// Gets or sets the unit price of the transaction.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the quantity of items in the transaction.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the associated book.
        /// </summary>
        public Guid BookId { get; set; }

        /// <summary>
        /// Gets or sets the reference to the associated Book entity.
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who created the transaction.
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user who last modified the transaction.
        /// </summary>
        public Guid ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transaction was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transaction was last modified.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
