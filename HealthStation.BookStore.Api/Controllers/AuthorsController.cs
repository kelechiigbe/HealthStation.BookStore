using HealthStation.BookStore.Api.Helpers;
using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Application.ViewModel.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HealthStation.BookStore.Api.Controllers
{
    /// <summary>
    /// Controller for managing authors.
    /// </summary>
    [Route("api/authors")]
    public class AuthorsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AuthorsController> _logger;

        /// <summary>
        /// Constructor for AuthorsController.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="logger">The logger.</param>
        public AuthorsController(IUnitOfWork unitOfWork, ILogger<AuthorsController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get the top selling authors.
        /// </summary>
        /// <param name="topAuthorsCount">Number of top authors to retrieve.</param>
        [HttpGet]
        [Route("top-sellers")]
        public async Task<IActionResult> GetTopSellingAuthors(int topAuthorsCount = 10)
        {
            _logger.LogInformation("Getting top selling authors...");

            var topSellingAuthors = await _unitOfWork.Authors.GetTopSellingAuthors(topAuthorsCount);

            _logger.LogInformation("Retrieved top selling authors successfully.");

            var response = ResponseModel<TopSellingAuthorsResponse>.CreateResponse(topSellingAuthors, "Retrieval successful", true);

            return Ok(response);
        }
    }

}
