using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    UserName = "@Number5",
                    Last_Name = "Five",
                    First_Name = "Jonny",
                    Middle_Name = "",
                    Display_Name = "Jonny5",
                    Date_of_Birth = new DateTime(1986, 5, 9),
                    PasswordHash = "P@$$W0rd",
                    Email = "jonny5@number5.com",
                }
            );
        }
    }
}
