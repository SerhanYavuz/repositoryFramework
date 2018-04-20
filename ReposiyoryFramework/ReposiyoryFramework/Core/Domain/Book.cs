using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReposiyoryFramework.Core.Domain
{
    public class Book
    {
        //public Book()
        //{
        //    this.Tags = new HashSet<Tag>();
        //    this.Author = new Author();
        //}

        public virtual Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
