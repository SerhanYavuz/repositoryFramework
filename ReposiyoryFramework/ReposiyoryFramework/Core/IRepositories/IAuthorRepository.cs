using ReposiyoryFramework.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReposiyoryFramework.Core.IRepositories
{
    public interface IAuthorRepository:IRepository<Author>
    {
        Author GetauthorByBooks(string bookName);
    }
}
