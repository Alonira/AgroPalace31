using AgroPalace31.DbContexts;
using AgroPalace31.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
           
        }

        public void DeleteBook(Book Book)
        {
            _context.Books.Remove(Book);
            
        }

        public Book GetBook(int id)
        {
            _context.Books.Find(id);
            
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList<Book>();
        }

        public void UpdateBook(Book book)
        {
            //throw new NotImplementedException();
        }
    }
}
