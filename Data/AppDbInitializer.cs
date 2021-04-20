using System;
using System.Linq;
using libdotnet.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace libdotnet.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            if (context != null && !context.Books.Any())
            {
                context.Books.AddRange(new Book
                {
                    Author = "Rabindranath Thakur",
                    Description = "Collection of poem",
                    IsRead = true,
                    DateRead = DateTime.Now.AddDays(-10),
                    Genre = "Poem",
                    Rate = 4,
                    Title = "Sonchoyita",
                    CoverUrl = "https://images-na.ssl-images-amazon.com/images/I/91JMrDVwpaL.jpg",
                    DateAdded = DateTime.Now.AddDays(-25)
                }, new Book
                {
                    Author = "Syed Mujtaba Ali",
                    Description = "Collection of travel story",
                    Genre = "Travel",
                    Rate = 5,
                    Title = "Rochonaboli",
                    CoverUrl = "https://allfreebd.com/wp-content/uploads/2019/05/1555298415.jpg",
                    DateAdded = DateTime.Now.AddDays(-20)
                });

                context.SaveChanges();
            }
        }
    }
}