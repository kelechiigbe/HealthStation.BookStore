using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Application.Extensions
{
    /// <summary>
    /// Provides extension methods for working with lists.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Converts a list of Guids to a comma-separated string.
        /// </summary>
        /// <param name="list">The list of Guids to convert.</param>
        /// <returns>A comma-separated string of Guids.</returns>
        public static string ToCommaSeparatedString(this List<Guid> list)
        {
            return string.Join(", ", list.Select(id => id.ToString()));
        }
    }

}
