using FluentValidation;
using HealthStation.BookStore.Application.ViewModel.Requests;

namespace HealthStation.BookStore.Application.FluentValidators
{
    /// <summary>
    /// Validator for the Revenue Report Request.
    /// </summary>
    public class RevenueReportRequestValidator : AbstractValidator<ReportingPeriodRequest>
    {
        /// <summary>
        /// Validates the Start Date and End Date  properties.
        /// </summary>
        public RevenueReportRequestValidator()
        {
            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("Start date is required.")
                .Must(date => date != DateTime.MinValue).WithMessage("Invalid start date.")
                .Must(date => date != DateTime.MaxValue).WithMessage("Invalid start date.");

            RuleFor(x => x.EndDate)
                .NotEmpty().WithMessage("End date is required.")
                .Must(date => date != DateTime.MinValue).WithMessage("Invalid end date.")
                .Must(date => date != DateTime.MaxValue).WithMessage("Invalid end date.");
            RuleFor(x => x.EndDate)
           .GreaterThanOrEqualTo(x => x.StartDate)
           .WithMessage("End date must be greater than or equal to start date.");
        }
    }

}
