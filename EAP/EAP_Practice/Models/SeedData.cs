using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EAP_Practice.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmpDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmpDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        FirstName = "Nancy",
                        LastName = "Davolio",
                        Sex = "Female",
                        Birthday = "12/08/1948"
                    },
                    new Employee
                    {
                        FirstName = "Andrew",
                        LastName = "Fuller",
                        Sex = "Male",
                        Birthday = "19/02/1952"
                    },
                    new Employee
                    {
                        FirstName = "Janet",
                        LastName = "Leverling",
                        Sex = "Female",
                        Birthday = "30/08/1963"
                    },
                    new Employee
                    {
                        FirstName = "Margaret",
                        LastName = "Peacock",
                        Sex = "Female",
                        Birthday = "19/09/1937"
                    },
                    new Employee
                    {
                        FirstName = "Steven",
                        LastName = "Buchanan",
                        Sex = "Male",
                        Birthday = "04/03/1955"
                    },
                    new Employee
                    {
                        FirstName = "Michael",
                        LastName = "Suyama",
                        Sex = "Male",
                        Birthday = "02/07/1963"
                    },
                    new Employee
                    {
                        FirstName = "Robert",
                        LastName = "King",
                        Sex = "Male",
                        Birthday = "29/05/1960"
                    }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}
