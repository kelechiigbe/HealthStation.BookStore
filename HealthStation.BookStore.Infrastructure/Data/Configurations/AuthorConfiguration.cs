using HealthStation.BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthStation.BookStore.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Configuration class for the Author entity.
    /// </summary>
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        /// <summary>
        /// Configures the properties of the Author entity.
        /// </summary>
        /// <param name="builder">Entity type builder for Author.</param>
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(150)
                   .IsRequired();
        }
    }
}
