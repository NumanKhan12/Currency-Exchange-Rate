using System.Text.Json.Serialization;

namespace CurrencyConverter.Model
{
    public class CurrencyRateList
    {
        public double Amount { get; set; }
        public string Base { get; set; }
        public string Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}
