namespace CurrencyConverter.Model
{
    public class ExchangeRateHistory
    {
        public double Amount { get; set; }
        public string Base { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Dictionary<DateTime, Dictionary<string, double>> Rates { get; set; }
    }
}
