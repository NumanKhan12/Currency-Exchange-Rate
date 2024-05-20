using CurrencyConverter.BusinessLogicLayer;
using CurrencyConverter.Data;
using CurrencyConverter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CurrencyConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyExchangeController : ControllerBase
    {
        private readonly ICurrencyExchangeCore _currencyExchangeCore;
        public CurrencyExchangeController(ICurrencyExchangeCore currencyExchangeCore)
        {
            _currencyExchangeCore = currencyExchangeCore;
        }
        [Route("/CurrencyExchange/GetLatestRates")]
        [HttpGet]
        public ApiResult GetLatestExchangeRates(string currencyCode = "")
        {
            try
            {
                var result = _currencyExchangeCore.GetLatestExchangeRates(currencyCode);
                return new ApiResult()
                {
                    StatusCode = (int?)HttpStatusCode.OK,
                    MessageCode = ResponseCodeConstants.Web_Info_RequestSuccess.Code,
                    Value = result,
                };
            }
            catch (Exception ex)
            {

                return new ApiResult()
                {
                    StatusCode = (int?)HttpStatusCode.InternalServerError,
                    MessageCode = ResponseCodeConstants.Web_Error_InternalServerError.Code,
                    ResponseMessage = ex.Message,
                    ResponseResolution = ResponseCodeConstants.Web_Error_InternalServerError.Resolution
                };
            }

        }

        [Route("/CurrencyExchange/GetConversionRates")]
        [HttpPost]
        public ApiResult GetConversionRates(CurrencyConversionRequest model)
        {
            try
            {
                if (CurrencyRules.BlockCurrency.Any(e => e == model.FromCurrency || e == model.ToCurrency))
                {
                    return new ApiResult()
                    {
                        StatusCode = (int?)HttpStatusCode.BadRequest,
                        MessageCode = HttpStatusCode.BadRequest.ToString(),
                        ResponseMessage = "Currency blocked",
                        ResponseResolution = ResponseCodeConstants.Web_Error_InternalServerError.Resolution
                    };
                }
                var result = _currencyExchangeCore.GetConversionRates(model);
                return new ApiResult()
                {
                    StatusCode = (int?)HttpStatusCode.OK,
                    MessageCode = ResponseCodeConstants.Web_Info_RequestSuccess.Code,
                    Value = result,
                };
            }
            catch (Exception ex)
            {

                return new ApiResult()
                {
                    StatusCode = (int?)HttpStatusCode.InternalServerError,
                    MessageCode = ResponseCodeConstants.Web_Error_InternalServerError.Code,
                    ResponseMessage = ex.Message,
                    ResponseResolution = ResponseCodeConstants.Web_Error_InternalServerError.Resolution
                };
            }

        }
        [Route("/CurrencyExchange/GetExchangeRatesHistory")]
        [HttpPost]
        public ApiResult GetExchangeRatesHistory(PaginationFilter filter)
        {
            try
            {
                var result = _currencyExchangeCore.GetExchangeRatesHistory(filter);
                return new ApiResult()
                {
                    StatusCode = (int?)HttpStatusCode.OK,
                    MessageCode = ResponseCodeConstants.Web_Info_RequestSuccess.Code,
                    Value = result,
                };
            }
            catch (Exception ex)
            {

                return new ApiResult()
                {
                    StatusCode = (int?)HttpStatusCode.InternalServerError,
                    MessageCode = ResponseCodeConstants.Web_Error_InternalServerError.Code,
                    ResponseMessage = ex.Message,
                    ResponseResolution = ResponseCodeConstants.Web_Error_InternalServerError.Resolution
                };
            }

        }
    }
}
