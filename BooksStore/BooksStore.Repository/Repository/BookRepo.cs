using BooksStore.Repository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.Repository
{
    public class BookRepo : BaseRepository<Book>, IBookRepository
    {
        public BookRepo(IMongoContext context) : base(context)
        {
        }
    }
}
