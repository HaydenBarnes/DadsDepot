using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TheDadsDepot.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DepotDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DepotDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Lawn Mower w/ Shoes",
                        Description = "Have a better yard than Craig and stain your sweet new white shoes green!",
                        Category = "Lawn Care",
                        Price = 350
                    },
                    new Product
                    {
                        Name = "65 inch TV",
                        Description = "Just get the 70 inch. You know you want to.",
                        Category = "Electronics",
                        Price = 800
                    },
                    new Product
                    {
                        Name = "Cell phone holster",
                        Description = "Never ask where your phone is again with this amazing holster made of premium fake leather straight from China. " +
                        "But you can tell Craig it is from the skin of you last hunting trip.",
                        Category = "Man-cessories",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "Large Knife",
                        Description = "This is for cutting things. Literally anything.",
                        Category = "Outdoors",
                        Price = 35
                    },
                    new Product
                    {
                        Name = "Dad Depot Coozie",
                        Description = "You know who likes warm beer? Not Dads....",
                        Category = "Man-cessories",
                        Price = 9
                    },
                    new Product
                    {
                        Name = "Moisture Wicking Golf Polo",
                        Description = "Feel good, play good. This will turn you into Tiger Woods. Maybe.",
                        Category = "Clothing",
                        Price = 40
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
