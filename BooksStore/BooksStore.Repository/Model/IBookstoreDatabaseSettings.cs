using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.Repository.Model
{
    public interface IBookstoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
