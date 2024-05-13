using HealthStation.BookStore.Application.Interface;

namespace HealthStation.BookStore.Api.Helpers
{
    public class ResponseModel<T> : IResponseModel
    {
        public T Data { get; set; }
        public Exception Ex { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }

        public static ResponseModel<T> CreateResponse<T>(T data, string message, bool isSuccess)
        {
            return new ResponseModel<T>
            {
                Data = data,
                Message = message,
                IsSuccess = isSuccess
            };
        }
    }
}
