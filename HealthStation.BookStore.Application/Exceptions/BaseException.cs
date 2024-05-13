using System.Net;

namespace HealthStation.BookStore.Application.Exceptions
{
    /// <summary>
    /// Represents a base exception class.
    /// </summary>
    public abstract class BaseException : Exception
    {
        /// <summary>
        /// Gets the HTTP status code associated with the exception.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Initializes a new instance of the BaseException class with a specified message and status code.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="statusCode">The HTTP status code (default is InternalServerError).</param>
        public BaseException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }

}
