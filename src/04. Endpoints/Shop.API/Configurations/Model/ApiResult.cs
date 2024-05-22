namespace Shop.API.Configurations.Model
{
    public class ApiResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public List<string> Errors { get; set; }

        public static ApiResult<T> SuccessResult(T result, string message = null)
        {
            return new ApiResult<T>
            {
                Success = true,
                Message = message,
                Result = result,
                Errors = null
            };
        }

        public static ApiResult<T> FailureResult(List<string> errors, string message = null)
        {
            return new ApiResult<T>
            {
                Success = false,
                Message = message,
                Result = default,
                Errors = errors
            };
        }

        public static ApiResult<T> FailureResult(string error, string message = null)
        {
            return new ApiResult<T>
            {
                Success = false,
                Message = message,
                Result = default,
                Errors = new List<string> { error }
            };
        }
    }
}
