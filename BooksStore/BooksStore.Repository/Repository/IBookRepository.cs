using BooksStore.Repository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
    }
}
