using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model{
  public class MovieContext : DbContext {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
          optionsBuilder.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=MovieDB;Pooling=true;");
        }
    }

    public class Movie {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Release { get; set; }
        public List<Actor> Actors { get; set; }
    }

    public class Actor {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Gender { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}