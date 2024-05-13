using FluentValidation;
using HealthStation.BookStore.Application.ViewModel.Requests;

namespace HealthStation.BookStore.Application.FluentValidators
{
    /// <summary>
    /// Validator for the BookDeleteRequest class.
    /// </summary>
    public class BookDeleteRequestValidator : AbstractValidator<BookDeleteRequest>
    {
        /// <summary>
        /// Validates the BookIds property.
        /// </summary>
        public BookDeleteRequestValidator()
        {
            RuleFor(book => book.BookIds).NotEmpty().WithMessage("At least one book id is required.");
        }
    }

}
