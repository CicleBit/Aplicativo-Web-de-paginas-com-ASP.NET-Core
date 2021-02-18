using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService <DbContextOptions<RazorPagesMovieContext>>()))
            {
                //Look for any movies.
                if (context.Movies.Any())
                {
                    return;
                }
                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1988-2-12"),
                        Genre = "Romantic",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "When Met Sally",
                        ReleaseDate = DateTime.Parse("1918-2-12"),
                        Genre = "Horror",
                        Price = 78.1M,
                        Rating = "L"
                    },
                    new Movie
                    {
                        Title = "Wet Sally",
                        ReleaseDate = DateTime.Parse("1998-2-12"),
                        Genre = "Gospel",
                        Price = 15.99M,
                        Rating = "B"
                    },
                    new Movie
                    {
                        Title = "Met Sally",
                        ReleaseDate = DateTime.Parse("1000-2-12"),
                        Genre = "Suspense",
                        Price = 7.99M,
                        Rating = "A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}