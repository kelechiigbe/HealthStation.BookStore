using HealthStation.BookStore.Application.Exceptions;
using HealthStation.BookStore.Application.Extensions;
using HealthStation.BookStore.Infrastructure.Data;
using HealthStation.BookStore.Infrastructure.Data.SeedData;
using HealthStation.BookStore.Infrastructure.Extensions;

namespace HealthStation.BookStore.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddApplicationServices();
            builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
            builder.Services.AddProblemDetails();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddInfrastructureServices<BookStoreDbContext>(connectionString);

                var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();

                // Initialize seed data
                using var scope = app.Services.CreateScope();
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<BookStoreDbContext>();
                DataSeeder.SeedData(context);
            }
           
            app.UseExceptionHandler();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
