using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    //Id, Name, Description, Img, Price, Discount, Status
                    new Product
                    {
                        Name = "Bacardi - Black (Carta Negra)",
                        Description = "The richest spirit produced by Bacardi is a blend of selected rums aged for periods of up to four years.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/bacardi.jpg",
                        Price = 23.35m,
                        Category = "Still",
                        Discount = 37
                    },
                    new Product
                    {
                        Name = "Jack Daniels - Old No 7",
                        Description = "The archetypal JD and the most famous of all the range from this famous American whiskey producer.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/jack_daniels.jpg",
                        Price = 23.86m,
                        Category = "Still",
                        Discount = 40
                    },
                    new Product
                    {
                        Name = "Aftershock - Hot & Cool Cinnamon",
                        Description = "This cinnamon flavoured liqueur has proved immensely popular since its introduction. Normally drunk as a shooter.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/aftershock.jpg",
                        Price = 24.32m,
                        Category = "Still",
                        Discount = 30
                    },
                    new Product
                    {
                        Name = "Spirytus - Duch Puszczy",
                        Description = "Neutral grain spirit.NOT to be drunk neat.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/Spirytus.jpg",
                        Price = 29.99m,
                        Category = "Over",
                        Discount = 75
                    },
                    new Product
                    {
                        Name = "Johnnie Walker - Black Label 12 Year Old",
                        Description = "As many as 40 whiskies, each aged 12 years or more, make up this satisfyingly complex blend.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/johnnie.jpg",
                        Price = 28.52m,
                        Category = "Over",
                        Discount = 40
                    },
                    new Product
                    {
                        Name = "Jagermeister",
                        Description = "Usually served as a chilled shot from their now famous Jager' Tap Machines in pubs around the world.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/jagermeister.jpg",
                        Price = 18.73m,
                        Category = "Still",
                        Discount = 35
                    },
                    new Product
                    {
                        Name = "Old Monk - The Legend",
                        Description = "Old Monk The Legend is an epitome of the distillers relentless efforts for quality and perfection.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/oldmonk.jpg",
                        Price = 72.71m,
                        Category = "Still",
                        Discount = 42
                    },
                    new Product
                    {
                        Name = "Sheridans",
                        Description = "Visually stunning, it is owned by Gilbey's, the same group that produces Baileys.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/sheridans.jpg",
                        Price = 14.56m,
                        Category = "Over",
                        Discount = 15
                    },
                    new Product
                    {
                        Name = "Patron - XO Cafe",
                        Description = "Patron XO Cafe is produced and blended in the state of Jalisco, Mexico. Jalisco is known for producing the finest tequila in the world.",
                        Img = "https://raw.githubusercontent.com/nddat1908/T1908A_Sem3/master/EAP/Image_DrinkStores/patron.jpg",
                        Price = 33.08m,
                        Category = "Still",
                        Discount = 35
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
