namespace CurrencyConverter.Model
{
    public class PaginationFilter
    {
        public int pageNumber { get; set; } = 0;
        public int totalRow { get; set; } = 10;
        public DateTime ToDate { get; set; }= new DateTime();
        public DateTime FromDate { get; set; } =new DateTime();
        public string CurrencyCode { get; set; } = "EUR";
    }
}
