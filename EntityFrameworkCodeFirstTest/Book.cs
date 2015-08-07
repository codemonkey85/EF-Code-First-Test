using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirstTest
{
    public class Book
    {
        public Book() 
        {
            Id = Guid.NewGuid();
        }

        [Index(IsUnique = true)]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public Person Author { get; set; }

        public Genres Genre { get; set; }

        public override string ToString()
        {
            return string.Format("{0} by {1}", Title, Author);
        }
    }
}