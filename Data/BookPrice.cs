namespace DbOperationsWithEFCoreApp.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
            
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }

}
    