using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReposiyoryFramework.Core.Domain
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        public virtual Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
