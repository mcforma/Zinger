using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Zinger.Models;


namespace Zinger.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "User Handle")]
        [Required]
        [Remote(action: "IsUser_HandleInUse", controller: "Account")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "User Handle must be 4 - 15 characters")]
        public string User_Handle { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50, ErrorMessage = "Last Name must be no more than 50 characters")]
        public string Last_Name { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50, ErrorMessage = "First Name must be no more than 50 characters")]
        public string First_Name { get; set; }

        [Display(Name = "Middle Name")]
        [AllowNull]
        [StringLength(50, ErrorMessage = "Middle Name must be no more than 50 characters")]
        public string? Middle_Name { get; set; }

        [Display(Name = "Display Name")]
        [Required]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "Display Name must be between 4 and 40 characters")]
        public string Display_Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date_of_Birth { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(80, ErrorMessage = "Email Address must be no more than 80 characters")]
        public string Email_Address { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 40 characters")]
        public string Pass_word { get; set; }

        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Pass_word",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


    }
}
