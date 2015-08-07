using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirstTest
{
    public class Person
    {
        public Person() 
        {
            Id = Guid.NewGuid();
        }

        [Index(IsUnique = true)]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}