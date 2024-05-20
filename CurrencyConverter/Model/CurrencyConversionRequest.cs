using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Model
{
    public class CurrencyConversionRequest
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public string FromCurrency { get; set; }
        [Required]
        public string ToCurrency { get; set; }
    }
}
