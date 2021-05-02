using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    [Index(nameof(UserName), IsUnique = true)]
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "User Handle")]
        public override string UserName { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Display_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_of_Birth { get; set; }

        public IList<UsersZingers> UsersZingers { get; set; }
        //public IList<Zinger_Replies> Zinger_Replies { get; set; }
        //public IList<Followers> Followers { get; set; }

    }
}
