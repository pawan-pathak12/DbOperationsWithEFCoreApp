using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrice { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, CurrencyType = "INR", Description = "Indian INR" },
                new Currency() { Id = 2, CurrencyType = "Dollar", Description = "Dollar" },
                new Currency() { Id = 3, CurrencyType = "Euro", Description = "Euro"  },
                new Currency() { Id = 4, CurrencyType = "Dinar", Description = "Dinar" }

            );

            modelBuilder.Entity<Language>().HasData(
              new Language { Id = 1, Title = "English", Description = "Books written in English" },
              new Language { Id = 2, Title = "Hindi", Description = "Books written in Hindi" },
              new Language { Id = 3, Title = "Nepali", Description = "Books written in Nepali" },
              new Language { Id = 4, Title = "French", Description = "Books written in French" },
              new Language { Id = 5, Title = "Spanish", Description = "Books written in Spanish" }
            );
            modelBuilder.Entity<Book>().HasData(
             new Book { Id = 1, Title = "Learn ASP.NET Core", Description = "A beginner's book for ASP.NET Core and EF Core.", CreatedOn = new DateOnly(2024, 1, 1), IsActive = true, LanguageId = 1, NoOfPages = 350 },
             new Book { Id = 2, Title = "Mastering C#", Description = "Advanced guide to C# programming.", CreatedOn = new DateOnly(2023, 10, 15), IsActive = true, LanguageId = 1, NoOfPages = 500 },
             new Book { Id = 3, Title = "HTML & CSS Design", Description = "Web design with HTML and CSS.", CreatedOn = new DateOnly(2022, 5, 20), IsActive = true, LanguageId = 2, NoOfPages = 280 },
             new Book { Id = 4, Title = "Introduction to SQL", Description = "Learn SQL from scratch.", CreatedOn = new DateOnly(2021, 8, 10), IsActive = true, LanguageId = 3, NoOfPages = 320 },
             new Book { Id = 5, Title = "JavaScript Essentials", Description = "Core concepts of JavaScript.", CreatedOn = new DateOnly(2024, 3, 5), IsActive = true, LanguageId = 1, NoOfPages = 400 }
             );


            modelBuilder.Entity<BookPrice>().HasData(
             new BookPrice { Id = 1, BookId = 1, CurrencyId = 1, Amount = 29.99m },
             new BookPrice { Id = 2, BookId = 2, CurrencyId = 1, Amount = 39.99m },
             new BookPrice { Id = 3, BookId = 3, CurrencyId = 2, Amount = 19.99m },
             new BookPrice { Id = 4, BookId = 4, CurrencyId = 3, Amount = 24.50m },
             new BookPrice { Id = 5, BookId = 5, CurrencyId = 1, Amount = 34.99m }
             );



        }



    }
}
