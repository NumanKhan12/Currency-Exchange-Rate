using CurrencyConverter.Data;
using CurrencyConverter.IData;
using CurrencyConverter.Model;

namespace CurrencyConverter.BusinessLogicLayer
{
    public class CurrencyExchangeCore : ICurrencyExchangeCore
    {
        private readonly IApiClient _apiClient;
        public CurrencyExchangeCore(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public CurrencyRateList GetLatestExchangeRates(string currencyCode)
        {
            try
            {
                if (string.IsNullOrEmpty(currencyCode))
                    currencyCode = "EUR";
                string url = string.Concat(ApiClientEndPointURL.latestExchangeRates, "?from=", currencyCode);
                var result = _apiClient.GetHttpResult<CurrencyRateList>(url);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CurrencyRateList GetConversionRates(CurrencyConversionRequest model)
        {
            try
            {
                if (model == null)
                    throw new Exception("model should be valid");

                string url = string.Concat(ApiClientEndPointURL.latestExchangeRates, $"?amount{model.Amount}from={model.FromCurrency}&to{model.ToCurrency}");
                var result = _apiClient.GetHttpResult<CurrencyRateList>(url);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExchangeRateHistory GetExchangeRatesHistory(PaginationFilter filter)
        {
            try
            {
                var todate = filter.ToDate.ToString("yyyy-MM-dd");
                var fromDate = filter.FromDate.ToString("yyyy-MM-dd");
                string url = string.Concat($"{fromDate}.{todate}?to={filter.CurrencyCode}");
                var result = _apiClient.GetHttpResult<ExchangeRateHistory>(url);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
