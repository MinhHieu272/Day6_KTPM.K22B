using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day6.Models;

namespace Day6.Data
{
    public class Day6Context : DbContext
    {
        public Day6Context (DbContextOptions<Day6Context> options)
            : base(options)
        {
        }

        public DbSet<Day6.Models.Product> Product { get; set; } = default!;
        public DbSet<Day6.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Day6.Models.Movie> Movie { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed genres
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" },
                new Genre { Id = 3, Name = "Drama" },
                new Genre { Id = 4, Name = "Horror" },
                new Genre { Id = 5, Name = "Romance" }
            );
        }
    }
}
