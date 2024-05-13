using HealthStation.BookStore.Domain;
using HealthStation.BookStore.Infrastructure.Data.SeedData.Helpers;

namespace HealthStation.BookStore.Infrastructure.Data.SeedData
{
    public static class DataSeeder
    {
        public static void SeedData(BookStoreDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Books.Any())
            {
                List<Book> books = [];

                for (int i = 0; i < 100; i++)
                {
                    Book newBook = CreateNewBook(i);
                    AddTransactionsToBook(newBook);
                    books.Add(newBook);
                }

                context.Books.AddRange(books);
                context.SaveChanges();
            }
        }

        private static Book CreateNewBook(int index)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = $"Title {index + 1}",
                CreatedDate = DateTime.UtcNow.AddMonths(-6),
                Price = PriceGenerator.GeneratePrice(),
                Author = CreateNewAuthor(index),
                Transactions = []
            };
        }

        private static Author CreateNewAuthor(int index)
        {
            return new Author
            {
                Id = Guid.NewGuid(),
                Name = $"Author {index + 1}",
                CreatedDate = DateTime.UtcNow.AddMonths(-7)
            };
        }

        private static void AddTransactionsToBook(Book book)
        {
            int transactionCount = RandomQuantityGenerator.GenerateRandomQuantity();

            for (int j = 0; j < transactionCount; j++)
            {
                Transaction newTransaction = CreateNewTransaction(book.Price);
                book.Transactions.Add(newTransaction);
            }
        }

        private static Transaction CreateNewTransaction(decimal bookPrice)
        {
            return new Transaction
            {
                Id = Guid.NewGuid(),
                Quantity = RandomQuantityGenerator.GenerateRandomQuantity(),
                UnitPrice = bookPrice,
                CreatedDate = RandomDateGenerator.GenerateRandomDate()
            };
        }
    }
}
