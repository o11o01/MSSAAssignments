using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment12._3._2
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData
                 (
                     new Book { Id = 1, Title = "Into the Wild", Author = "Jon Krakauer", PublishDate = 1996 },
                     new Book { Id = 2, Title = "The Wheel of Time", Author = "Robert Jordna", PublishDate = 1990 },
                     new Book { Id = 3, Title = "Harry Potter", Author = "J.K. Rowling", PublishDate = 1997 }
                );
        }

    }
}
