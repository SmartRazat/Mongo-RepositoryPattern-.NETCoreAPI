using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.Repository
{
    public class Product
    {
        public Product(string description)
        {
            Description = description;
            Id = Guid.NewGuid();
        }

        public Product(Guid id, string description)
        {
            Id = id;
            Description = description;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
