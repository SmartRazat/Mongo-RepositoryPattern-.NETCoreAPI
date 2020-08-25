using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoContext context) : base(context)
        {
        }
    }
}
