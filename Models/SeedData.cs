using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using BTVBookRental.Models;

namespace BTVBookRental.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BTVBookRentalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BTVBookRentalContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Titlu = "Amintiri din copilarie",
                        Autor = "Ion Creanga",
                        AnAparitie = 1994,
                        Gen = "Povesti",
                        Status = "Inchiriat"

                    }

                );
                context.SaveChanges();
            }
        }
    }
}


