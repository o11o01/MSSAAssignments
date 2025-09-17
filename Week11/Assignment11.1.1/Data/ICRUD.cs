using Assignment11._1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._1._1.Data
{
    public interface ICRUD
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);

        List<Book> GetAllBooks();
        Book GetBookByISBN(string ISBN);
    }
    public class CRUD : ICRUD
    {
        private ProductContext _context;
        public CRUD(ProductContext context)
        {
            _context = context;
        }
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }
        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }
        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }
        public Book GetBookByISBN(string ISBN)
        {
            throw new NotImplementedException();
        }

    }
}
