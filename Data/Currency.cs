namespace DbOperationsWithEFCoreApp.Data
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyType { get; set; }      // Example: "USD"
        public string Description { get; set; }   

        // Navigation
        public ICollection<BookPrice> Prices { get; set; }
    }                
}                    
