﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.Repository.Model
{
    public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
