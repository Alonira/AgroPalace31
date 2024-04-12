using AgroPalace31.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.DbContexts
{
    public class CourseLibraryContext: DbContext
    {
        public CourseLibraryContext(DbContextOptions<CourseLibraryContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = Guid.Parse("d2888908-2ba9-473a-a40f-e38cb54f9b35"),
                    FirstName = "Ola",
                    LastName = "Joke",
                    DateOfBirth = new DateTime(1999, 8, 9),
                    MainCategory = "tools"
                },
                new Author()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    FirstName = "Olu",
                    LastName = "Jola",
                    DateOfBirth = new DateTime(1993, 7, 4),
                    MainCategory = "ships"
                },
                new Author()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    FirstName = "Ade",
                    LastName = "Jota",
                    DateOfBirth = new DateTime(1989, 1, 2),
                    MainCategory = "Rums"
                },
                new Author()
                {
                    Id = Guid.Parse("102b566b-ba1f-b2df-e2cde39ade09"),
                    FirstName = "Rinola",
                    LastName = "Toke",
                    DateOfBirth = new DateTime(1979, 6, 9),
                    MainCategory = "yachts"
                },
                new Author()
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    FirstName = "Akinola",
                    LastName = "Ike",
                    DateOfBirth = new DateTime(1972, 10, 11),
                    MainCategory = "Maps"
                },
                new Author()
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9565-7f6332985a87"),
                    FirstName = "Nola",
                    LastName = "Oke",
                    DateOfBirth = new DateTime(1979, 1, 9),
                    MainCategory = "leathers"
                }, new Author()
                {
                    Id = Guid.Parse("2ee4ife3-edk2-4991-8309-3eb24ce6ca51"),
                    FirstName = "Jola",
                    LastName = "Lase",
                    DateOfBirth = new DateTime(1938, 3, 6),
                    MainCategory = "Containers"
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    AuthorId = Guid.Parse("2te49fe3-eyf2-4fr1-8409-3eb25ce6ca51"),
                    Title = "overthrowing mutiny",
                    Description = "over",
                },
                 new Course
                  {
                      Id = Guid.Parse("1ee49fe3-ed72-4791-8509-9eb25ce6ca51"),
                      AuthorId = Guid.Parse("2ee44fe3-ekf2-4fm1-8429-3eb25ce6ca51"),
                      Title = "reading novels",
                      Description = "novel",
                  },
                 new Course
                    {
                        Id = Guid.Parse("2hh49fe3-edf2-4791-8401-3eb25ce6ca51"),
                        AuthorId = Guid.Parse("6ee49fe3-edf2-4f91-8409-3eb25ce6ca5p"),
                        Title = "watching anime",
                        Description = "animes",
                    },
                 new Course
                      {
                          Id = Guid.Parse("2le49fe3-edf2-2f91-8709-3eb25ke6ca51"),
                          AuthorId = Guid.Parse("2eed9fe3-esf2-4fw1-8459-3eb25ce6ca51"),
                          Title = "music",
                          Description = "recording music",
                      }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
