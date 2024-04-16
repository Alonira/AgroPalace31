using AgroPalace31.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.DbContexts
{
    public class BookContext :DbContext
    {

        public BookContext(DbContextOptions<BookContext> options) 
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .HasData(
                new Book()
                {
                    Id = 1,
                    Title = "Naruto",
                    BookAuthor = "Lee",
                    Description = "A tale of naruto based on his livelihood"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Angry Bird",
                    BookAuthor = "jay",
                    Description = "a book about features of birds"
                },
                new Book()
                {
                    Id = 3,
                    Title = "Historical Arts",
                    BookAuthor = "kay",
                    Description = "a book about artworks in white&black"
                }
                );
            base.OnModelCreating(builder);
        }
    }
}
