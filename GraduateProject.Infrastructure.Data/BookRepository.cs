using GraduateProject.Domain.Core;
using GraduateProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        private ApplicationContext _db;

        public BookRepository(ApplicationContext applicationContext)
        {
            _db = applicationContext;
        }
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _db.Books;
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
