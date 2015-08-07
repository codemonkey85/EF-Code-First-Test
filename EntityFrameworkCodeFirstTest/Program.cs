using System;
using System.Linq;

namespace EntityFrameworkCodeFirstTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (BookCollection context = new BookCollection())
            {
                //if (context.Libraries != null) context.Libraries.First().Bookshelves.Clear();
                if (context.Libraries == null || !context.Libraries.Any())
                {
                    Book book = new Book() { Title = "Garden Parties", Author = new Person() { FirstName = "James", LastName = "Trickington" }, Genre = Genres.Nonfiction };
                    Bookshelf bookshelf = new Bookshelf() { Books = new System.Collections.Generic.List<Book>() { book } };
                    Library library = new Library() { Bookshelves = new System.Collections.Generic.List<Bookshelf>() { bookshelf } };
                    context.Libraries.Add(library);
                    context.SaveChanges();
                }
                context.Books.ToList().ForEach(b => Console.WriteLine(b));
                Console.WriteLine("{0}Complete!", Environment.NewLine);
                Console.ReadKey();
            }
        }
    }
}