using Mondy.BusinessLogic.Database;

namespace Mondy.BusinessLogic.Service
{
    public delegate bool ModelPredicate<T>(T product);

    public class Service
    {
        internal UserContext DbContext = new UserContext();

        public static ServiceResponse<T> Success<T>(T entry = default)
        {
            return new ServiceResponse<T>
            {
                Success = true,
                Entry = entry
            };
        }

        public static ServiceResponse<T> Failure<T>(string message)
        {
            return new ServiceResponse<T>
            {
                Success = false,
                Message = message,
            };
        }
    }

    public class ServiceResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Entry { get; set; }
    }
}