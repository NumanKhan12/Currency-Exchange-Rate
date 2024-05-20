using System.IO;
using System;
using RestSharp;
using CurrencyConverter.Model;
using CurrencyConverter.IData;
using Newtonsoft.Json;

namespace CurrencyConverter.Data
{
    public class ApiClient: IApiClient
    {
        private readonly FrankFurterHeaderInfo _frankFurterHeaderInfo;
        public ApiClient(FrankFurterHeaderInfo frankFurterHeaderInfo)
        {
            _frankFurterHeaderInfo = frankFurterHeaderInfo;
        }
        public T GetHttpResult<T>(string apiEndPoint)
        {
            try
            {
                var client = new RestClient(_frankFurterHeaderInfo.BaseUrl);
                var request = new RestRequest(apiEndPoint);
                request.AddHeader("Host", _frankFurterHeaderInfo.Host);
                request.AddHeader("Content-Type", _frankFurterHeaderInfo.ContentType);
                request.AddHeader("Content-Length", _frankFurterHeaderInfo.ContentLength);
                var response = client.Get(request);
                var content = response.Content; // Raw content as string

                if (string.IsNullOrEmpty(content))
                    throw new Exception("not fount result");

                var modelResult = JsonConvert.DeserializeObject<T>(content);
                return modelResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
