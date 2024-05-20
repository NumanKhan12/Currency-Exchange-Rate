namespace CurrencyConverter.Data
{
    public class StatusCodeConstants
    {
        /// <summary>
        /// T-C-XXX
        /// T=> (1=Web)  (2-Core) (3=DAL)
        /// C=> (1=Info) (2=Warning) (3=Error) (4=Critical)
        /// </summary>
        public string Code { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public StatusCodeConstants(string code, string description, string resolution)
        {
            Code = code;
            Description = description;
            Resolution = resolution;
        }
    }
}
