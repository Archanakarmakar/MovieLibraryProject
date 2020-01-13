namespace WebAPISample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPISample.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPISample.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
<<<<<<< HEAD
        context.Movies.AddOrUpdate(
=======
<<<<<<< HEAD
        context.Movies.AddOrUpdate(
        new Models.Movie { Title = "The Departed", Genre = "Drama", Director = "Martin Scorsese" },
        new Models.Movie { Title = "The Dark Knight", Genre = "Drama", Director = "Christopher Nolan" },
        new Models.Movie { Title = "Inception", Genre = "Drama", Director = "Christopher Nolan" },
        new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", Director = "David Gordon Green" },
        new Models.Movie { Title = "Die Hard", Genre = "Action", Director = "John McTiernan" }
=======
        context.Movie.AddOrUpdate(
>>>>>>> f59d560ef6ccdc578652df40cd7e1b6a6d393554
        new Models.Movie { Title = "The Departed", Genre = "Drama", DirectorName = "Martin Scorsese" },
        new Models.Movie { Title = "The Dark Knight", Genre = "Drama", DirectorName = "Christopher Nolan" },
        new Models.Movie { Title = "Inception", Genre = "Drama", DirectorName = "Christopher Nolan" },
        new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", DirectorName = "David Gordon Green" },
        new Models.Movie { Title = "Die Hard", Genre = "Action", DirectorName = "John McTiernan" }
>>>>>>> a39a7a69830c113cd3cea796c93a7b3345292921
        );
        }
    }
}
