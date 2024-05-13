using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthStation.BookStore.Application.ViewModel.Requests
{
    /// <summary>
    /// Represents a reporting period request with a start date and an end date.
    /// </summary>
    public record ReportingPeriodRequest(DateTime StartDate, DateTime EndDate);


}
