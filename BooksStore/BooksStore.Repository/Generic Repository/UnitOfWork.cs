using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;

        public UnitOfWork(IMongoContext context)
        {
            _context = context;
        }

        public async Task<bool>  Commit()
        {
            return await _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
