using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using HealthStation.BookStore.Application.FluentValidators;
using FluentValidation;

namespace HealthStation.BookStore.Application.Extensions
{
    /// <summary>
    /// Extensions for configuring application services.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds application services to the service collection.
        /// </summary>
        /// <param name="services">The current service collection.</param>
        /// <returns>The updated service collection.</returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services.AddFluentValidationAutoValidation()
                          .AddValidatorsFromAssemblyContaining<BookDeleteRequestValidator>();
        }
    }

}
