using LibraryAPI.Models;

namespace LibraryAPI.Services;

public class BookService
{
    private List<Book> showcase = new List<Book>
    {
        new Book { Id = 1, Title = "Clean Code", Author = "Uncle Bob", Genre = "Programming", Price = 89.99m, StockQuantity = 12 },
        new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andy Hunt", Genre = "Programming", Price = 79.90m, StockQuantity = 8 },
        new Book { Id = 3, Title = "C# in Depth", Author = "Jon Skeet", Genre = "Programming", Price = 99.50m, StockQuantity = 5 },
        new Book { Id = 4, Title = "Design Patterns Explained", Author = "Alan Shalloway", Genre = "Software Design", Price = 74.20m, StockQuantity = 7 },
        new Book { Id = 5, Title = "Refactoring", Author = "Martin Fowler", Genre = "Code Quality", Price = 92.00m, StockQuantity = 6 },
        new Book { Id = 6, Title = "Head First Design Patterns", Author = "Eric Freeman", Genre = "Programming", Price = 84.10m, StockQuantity = 4 },
        new Book { Id = 7, Title = "Code Complete", Author = "Steve McConnell", Genre = "Software Engineering", Price = 109.95m, StockQuantity = 10 },
        new Book { Id = 8, Title = "You Don't Know JS", Author = "Kyle Simpson", Genre = "JavaScript", Price = 64.80m, StockQuantity = 9 },
        new Book { Id = 9, Title = "Domain-Driven Design", Author = "Eric Evans", Genre = "Architecture", Price = 105.00m, StockQuantity = 3 },
        new Book { Id = 10, Title = "The Art of Unit Testing", Author = "Roy Osherove", Genre = "Testing", Price = 69.99m, StockQuantity = 2 }
    };

    public List<Book> GetBooks() 
    {
        return showcase;
    }

    public Book? GetBookById(int id) 
    {
        return showcase.Find(identificador => id == identificador.Id);
    }
}
