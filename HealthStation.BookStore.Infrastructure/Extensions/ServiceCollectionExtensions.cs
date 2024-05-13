using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Infrastructure.Data;
using HealthStation.BookStore.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HealthStation.BookStore.Infrastructure.Extensions
{
    /// <summary>
    /// Extension methods for adding infrastructure services to the service collection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds infrastructure services to the service collection.
        /// </summary>
        /// <typeparam name="TContext">The type of the DbContext.</typeparam>
        /// <param name="services">The current service collection.</param>
        /// <param name="connectionString">The connection string for the database.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddInfrastructureServices<TContext>(this IServiceCollection services, string connectionString) where TContext : DbContext
        {
            // AddDbContextPool and other service registrations

            services.AddDbContextPool<TContext>(options =>
          {
              options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
          });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            return services;

        }
    }
}
