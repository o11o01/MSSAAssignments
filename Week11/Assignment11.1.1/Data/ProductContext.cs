using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment11._1._1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment11._1._1.Data
{
    public class ProductContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBooks());
            base.OnModelCreating(modelBuilder);
        }
        private Book[] GetBooks()
        {
            Book[] books = new Book[] 
            {
                new Book {isbn = "111-111-1",title = "Of Mice and Men", author = "John Smith", summary = "The quick brown fox jumped over the lazy dog" },
                new Book {isbn = "111-111-2",title = "Wheel of Time", author = "John Smith", summary = "The quick brown fox jumped over the lazy dog" },
                new Book {isbn = "111-111-3",title = "History", author = "John Smith", summary = "The quick brown fox jumped over the lazy dog" }
            };
            return books;
        }
        
    }
}
