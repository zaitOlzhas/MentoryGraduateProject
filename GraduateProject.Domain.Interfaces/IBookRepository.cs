﻿using GraduateProject.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Domain.Interfaces
{
    public interface IBookRepository
    {
        Book GetBook(Guid id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Guid id);
        IEnumerable<Book> GetBooks();
    }
}
