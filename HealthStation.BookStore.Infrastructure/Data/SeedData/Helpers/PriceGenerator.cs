
namespace HealthStation.BookStore.Infrastructure.Data.SeedData.Helpers
{
    /// <summary>
    /// Represents a Price Generator class.
    /// </summary>
    public class PriceGenerator
    {
        private static readonly Random random = new();

        /// <summary>
        /// Generates a random price between 1000 and 10000.
        /// </summary>
        /// <returns>A randomly generated price.</returns>
        public static int GeneratePrice()
        {
            return random.Next(1000, 10001);
        }
    }

}
