using HealthStation.BookStore.Api.Helpers;
using HealthStation.BookStore.Application.Interface;
using HealthStation.BookStore.Application.ViewModel.Requests;
using HealthStation.BookStore.Application.ViewModel.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HealthStation.BookStore.Api.Controllers
{
    /// <summary>
    /// Controller for managing books.
    /// </summary>
    [Route("api/books")]
    public class BooksController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<BooksController> _logger;

        /// <summary>
        /// Constructor for BooksController.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="logger">The logger.</param>
        public BooksController(IUnitOfWork unitOfWork, ILogger<BooksController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Deletes books based on the provided request.
        /// </summary>
        /// <param name="bookDeleteRequest">The request containing book IDs to delete.</param>
        /// <returns>An IActionResult representing the deletion operation result.</returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteBooksByIds(BookDeleteRequest bookDeleteRequest)
        {
            _logger.LogInformation("Deleting books with IDs: {BookIds}", bookDeleteRequest.BookIds);

            var deletionResult = await _unitOfWork.Books.DeleteBooksByIdsAsync(bookDeleteRequest.BookIds);

            _logger.LogInformation("Deletion result: {DeletionResult}", deletionResult);

            var response = ResponseModel<TopSellingAuthorsResponse>.CreateResponse(deletionResult, "Deletion successful", true);

            return Ok(response);
        }
    }

}
