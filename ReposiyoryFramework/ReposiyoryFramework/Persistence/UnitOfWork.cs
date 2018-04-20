using ReposiyoryFramework.Core;
using ReposiyoryFramework.Core.Domain;
using ReposiyoryFramework.Core.IRepositories;
using ReposiyoryFramework.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReposiyoryFramework.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
    
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
        }
        public IAuthorRepository Authors { get; private set; }
        public Repository<Book> Books { get;}
        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
