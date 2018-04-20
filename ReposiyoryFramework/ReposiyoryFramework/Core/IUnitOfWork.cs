using ReposiyoryFramework.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReposiyoryFramework.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        int Save();
    }
}
