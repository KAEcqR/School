using System;
using Microsoft.EntityFrameworkCore;

namespace cw2_Student.Models;

public class StudentDbContext : DbContext
{
    //konstruktor wywołujący konstruktor klasy bazowej
    public StudentDbContext(DbContextOptions<StudentDbContext> options)
    : base(options)
    {
    }

    //reprezentuje kolekcję encji Books w bazie danych
    public DbSet<Student> Students { get; set; }

    //metoda dodajaca dane startowe do bazy danych
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, Name = "Uczen1", DataUrodzenia = new DateOnly(2004, 6, 15), Index = "00001" },
            new Student { Id = 2, Name = "Uczen2", DataUrodzenia = new DateOnly(2005, 7, 16), Index = "00002" },
            new Student { Id = 3, Name = "Uczen3", DataUrodzenia = new DateOnly(2006, 8, 17), Index = "00003" }
        );
    }
}