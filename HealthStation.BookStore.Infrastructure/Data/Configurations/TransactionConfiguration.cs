using HealthStation.BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthStation.BookStore.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Configuration for the Transaction entity.
    /// </summary>
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        /// <summary>
        /// Configures the properties of the Transaction entity.
        /// </summary>
        /// <param name="builder">Entity type builder for Transaction.</param>
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(p => p.Quantity)
             .IsRequired();

            builder.Property(p => p.UnitPrice)
            .IsRequired();
        }
    }
}
