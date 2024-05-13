using HealthStation.BookStore.Api.Helpers;
using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Application.ViewModel.Requests;
using Microsoft.AspNetCore.Mvc;

namespace HealthStation.BookStore.Api.Controllers
{
    /// <summary>
    /// Controller for handling transactions.
    /// </summary>
    [Route("api/transactions")]
    public class TransactionsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TransactionsController> _logger;

        /// <summary>
        /// Constructor for TransactionsController.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="logger">The logger.</param>
        public TransactionsController(IUnitOfWork unitOfWork, ILogger<TransactionsController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Retrieves revenue generated over a specific reporting period.
        /// </summary>
        /// <param name="reportingPeriodRequest">The reporting period request.</param>
        /// <returns>An IActionResult containing the revenue generated.</returns>
        [HttpGet("revenue")]
        public async Task<IActionResult> GetRevenueGenerated([FromQuery] ReportingPeriodRequest reportingPeriodRequest)
        {
            _logger.LogInformation("Retrieving revenue for ReportingPeriod: {ReportingPeriod}", reportingPeriodRequest);

            var revenue = await _unitOfWork.Transactions.GetRevenueGeneratedOverPeriodAsync(reportingPeriodRequest);

            _logger.LogInformation("Retrieved revenue successful for period: {StartDate} - {EndDate}", reportingPeriodRequest.StartDate, reportingPeriodRequest.EndDate);

            var response = ResponseModel<decimal>.CreateResponse(revenue, "Revenue retrieval successful", true);

            return Ok(response);
        }
    }

}
