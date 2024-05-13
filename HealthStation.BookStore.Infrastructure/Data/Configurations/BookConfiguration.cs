using HealthStation.BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthStation.BookStore.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Configuration for the Book entity.
    /// </summary>
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        /// <summary>
        /// Configures the properties of the Book entity.
        /// </summary>
        /// <param name="builder">Entity type builder for Book.</param>
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(p => p.Title)
                   .HasMaxLength(250)
                   .IsRequired();

            builder.Property(p => p.Price)
                   .IsRequired();
        }
    }
}
