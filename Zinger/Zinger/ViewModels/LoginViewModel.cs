using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "User Handle")]
        [Required]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "User Handle must be 4 - 15 characters")]
        public string User_Handle { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Pass_word { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
