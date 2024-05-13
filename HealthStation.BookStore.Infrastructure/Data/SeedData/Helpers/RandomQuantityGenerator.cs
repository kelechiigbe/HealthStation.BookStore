using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Infrastructure.Data.SeedData.Helpers
{
    /// <summary>
    /// Represents a class for generating random quantities.
    /// </summary>
    public class RandomQuantityGenerator
    {
        private static readonly Random random = new();

        /// <summary>
        /// Generates a random quantity between 1 and 100.
        /// </summary>
        /// <returns>A random integer between 1 and 100.</returns>
        public static int GenerateRandomQuantity()
        {
            return random.Next(1, 101);
        }
    }

}
