using CurrencyConverter.Model;

namespace CurrencyConverter.BusinessLogicLayer
{
    public interface ICurrencyExchangeCore
    {
        CurrencyRateList GetLatestExchangeRates(string currencyCode);
        CurrencyRateList GetConversionRates(CurrencyConversionRequest model);
        ExchangeRateHistory GetExchangeRatesHistory(PaginationFilter filter);
    }
}
