using Microsoft.EntityFrameworkCore;

namespace cw1_ef_sqlite.Models
{
    public class BookContext : DbContext
    {
        //konstruktor wywołujący konstruktor klasy bazowej
        public BookContext(DbContextOptions<BookContext> options)
        : base(options)
        {
        }

        //reprezentuje kolekcję encji Books w bazie danych
        public DbSet<Book> Books { get; set; }

        //metoda dodajaca dane startowe do bazy danych
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Book One", Author = "Author A", Year = 2001 },
                new Book { Id = 2, Title = "Book Two", Author = "Author B", Year = 2002 },
                new Book { Id = 3, Title = "Book Three", Author = "Author C", Year = 2003 }
            );
        }
    }
}
