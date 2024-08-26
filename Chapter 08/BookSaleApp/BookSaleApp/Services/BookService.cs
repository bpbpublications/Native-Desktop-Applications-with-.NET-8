using BookSaleApp.Models;

namespace BookSaleApp.Services
{
    public class BookService
    {
        public List<Book> GetBooks()
        {
            return new List<Book>() {
            
                new Book() { Id=111, Title = "Great Expectations", Author = "Charles Dickens", Price = 200},
                new Book() { Id=222, Title = "War and Peace", Author = "Leo Tolstoy", Price = 150},
                new Book() { Id=333, Title = "The Sun Also Rises", Author = "Ernest Hemingway", Price = 180},
                new Book() { Id=444, Title = "Invisible Man", Author = "Ralph Ellison", Price = 100}
            };
        }
    }
}
