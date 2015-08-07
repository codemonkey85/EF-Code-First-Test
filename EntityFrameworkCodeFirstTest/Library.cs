using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirstTest
{
    public class Library
    {
        public Library() 
        {
            Id = Guid.NewGuid();
        }

        [Index(IsUnique = true)]
        public Guid Id { get; set; }

        public List<Bookshelf> Bookshelves { get; set; }
    }
}