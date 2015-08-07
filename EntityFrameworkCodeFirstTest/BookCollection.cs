namespace EntityFrameworkCodeFirstTest
{
    using System.Data.Entity;

    public class BookCollection : DbContext
    {
        // Your context has been configured to use a 'BookCollection' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'EntityFrameworkCodeFirstTest.BookCollection' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'BookCollection'
        // connection string in the application configuration file.
        public BookCollection()
            : base("name=BookCollection")
        {
            //Database.SetInitializer<BookCollection>(null);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Library> Libraries { get; set; }

        public virtual DbSet<Bookshelf> Bookshelves { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Person> Authors { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}