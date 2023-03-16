using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.SeedWorks
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public List<string> Message { get; set; }
        public ApiResult(bool isSuccess, int statusCode, List<string> message)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Message = message;
        }
        public ApiResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public ApiResult() { }
    }
    public class ApiResult<T> : ApiResult
    {

        public T ResultObj { get; set; }
        public ApiResult(bool isSuccess, List<string> message, int statusCode, T resultObj) : base(isSuccess, statusCode, message)
        {
            ResultObj = resultObj;
        }
        public ApiResult(bool isSuccess) : base(isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
