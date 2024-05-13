using HealthStation.BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HealthStation.BookStore.Infrastructure.Data
{
    /// <summary>
    /// Represents the database context for the BookStore application.
    /// </summary>
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the DbSet for Books entity.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Authors entity.
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Transactions entity.
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; }

        /// <summary>
        /// Customizes the model using the provided modelBuilder.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
