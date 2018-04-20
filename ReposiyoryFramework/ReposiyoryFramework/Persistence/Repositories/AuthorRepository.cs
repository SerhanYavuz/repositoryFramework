using Microsoft.EntityFrameworkCore;
using ReposiyoryFramework.Core.Domain;
using ReposiyoryFramework.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ReposiyoryFramework.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {

        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Author GetauthorByBooks(string bookName)
        {
            return ApplicationDbContext.Authors.Include(a => a.Books).SingleOrDefault(a => a.Name == bookName);
        }


        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }


    }

}
