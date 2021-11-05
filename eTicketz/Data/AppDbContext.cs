using eTicketz.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketz.Data
{
    public class AppDbContext:DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        // We are going to 'Overide the 'OnModel creating method'
        // .. using (ModelBuilder) as the parameter, and name it 'modelBuilder'
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Define the Actor Movie

                // am = 'Actor_Movie' compound (combination of Primary Keys)
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                //  using the 'ActorID' parameter in the 'am(actor_movie) table'
                am.ActorId,

                //  using the 'MovieID' parameter in the 'am(actor_movie) table' 
                am.MovieId
            });

            // One to Many Relationship for Movie

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);

            // One to Many Relationship for Actor

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


            // passing modelBuilder to the 'base class'
            // .. this is necessary when we 'generate authentication tables'
            // .. so we do not need to manually define the identifiers
            base.OnModelCreating(modelBuilder);
        }

        // ** Define the 'Table Names' for Each Model **

            // Actor = Model
            // 'Table name' for the Actor Model = Actors
        public DbSet<Actor>Actors { get; set; }

            // Movie = Model
            // 'Table name' for the Movie Model = Movies
        public DbSet<Movie> Movies { get; set; }

            // 'Actor_Movie' = Model
            // 'Table name' for the Actor_Movie Model = Actors_Movies
        public DbSet<Actor_Movie> Actor_Movies { get; set; }

            // 'Cinema' = Model
            // 'Table name' for the Cinema Model = Cinemas
        public DbSet<Cinema> Cinemas { get; set; }

            // 'Producer' = Model
            // 'Table name' for the Producer Model = Producers
        public DbSet<Producer> Producers { get; set; }
    }


}
