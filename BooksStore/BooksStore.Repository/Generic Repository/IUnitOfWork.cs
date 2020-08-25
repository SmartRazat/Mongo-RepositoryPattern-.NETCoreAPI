using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
