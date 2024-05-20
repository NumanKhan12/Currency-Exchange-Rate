using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Data
{
    public class ApiResult : JsonResult
    {
        public string MessageCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseResolution { get; set; }
        public ApiResult() : base(null)
        {

        }
        public ApiResult(object value) : base(value)
        {

        }
        public ApiResult(object value, object serializerSettings) : base(value, serializerSettings)
        {

        }

    }
}
