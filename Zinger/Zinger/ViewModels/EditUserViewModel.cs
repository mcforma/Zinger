using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Display(Name = "User Handle")]
        [Required]
        [Remote(action: "IsUser_HandleInUse", controller: "Account")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "User Handle must be 4 - 15 characters")]
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(80, ErrorMessage = "Email Address must be no more than 80 characters")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50, ErrorMessage = "First Name must be no more than 50 characters")]
        public string First_Name { get; set; }

        [Display(Name = "Middle Name")]
        [AllowNull]
        [StringLength(50, ErrorMessage = "Middle Name must be no more than 50 characters")]
        public string Middle_Name { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50, ErrorMessage = "Last Name must be no more than 50 characters")]
        public string Last_Name { get; set; }

        [Display(Name = "Display Name")]
        [Required]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "Display Name must be between 4 and 40 characters")]
        public string Display_Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date_of_Birth { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
