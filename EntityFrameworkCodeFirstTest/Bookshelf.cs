using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirstTest
{
    public class Bookshelf
    {
        public Bookshelf() 
        {
            Id = Guid.NewGuid();
        }

        [Index(IsUnique = true)]
        public Guid Id { get; set; }

        public List<Book> Books { get; set; }
    }
}