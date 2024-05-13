using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Application.ViewModel.Responses
{
    /// <summary>
    /// Represents the response for top-selling authors.
    /// </summary>
    public class TopSellingAuthorsResponse
    {
        /// <summary>
        /// Gets or sets the name of the author.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the total sales of the author.
        /// </summary>
        public decimal TotalSales { get; set; }
    }

}
