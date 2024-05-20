namespace CurrencyConverter.IData
{
    public interface IApiClient
    {
        public T GetHttpResult<T>(string apiEndPoint);
    }
}
