namespace WeatherForecastApplication.Modals
{
    public class ApiResponse
    {
        public List<string> Data { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public static ApiResponse Fail(string errorMessage)
        {
            return new ApiResponse { Succeeded = false, Message = errorMessage };
        }

        public static ApiResponse Success(List<string> data)
        {
            return new ApiResponse { Succeeded = true, Data = data };
        }
    }
}
