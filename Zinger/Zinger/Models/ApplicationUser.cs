using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string User_Handle { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Display_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_of_Birth { get; set; }

    }
}
