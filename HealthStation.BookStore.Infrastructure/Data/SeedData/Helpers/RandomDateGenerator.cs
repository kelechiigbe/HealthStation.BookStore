namespace HealthStation.BookStore.Infrastructure.Data.SeedData.Helpers
{
    /// <summary>
    /// Represents a class for generating random dates.
    /// </summary>
    public class RandomDateGenerator
    {
        private static readonly Random random = new();

        /// <summary>
        /// Generates a random date between a specified start and end date.
        /// </summary>
        /// <returns>A randomly generated DateTime value.</returns>
        public static DateTime GenerateRandomDate()
        {
            DateTime startDate = new(2024, 1, 1);
            DateTime endDate = new(2024, 5, 13);

            int range = (endDate - startDate).Days;
            int randomDays = random.Next(range);

            return startDate.AddDays(randomDays);
        }
    }

}
