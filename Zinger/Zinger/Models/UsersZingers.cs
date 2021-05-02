using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class UsersZingers
    {
        [Required]
        [Display(Name = "User ID")]
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
        [Required]
        [Display(Name = "Zinger ID")]
        public int Zinger_ID { get; set; }
        public Zingers Zingers { get; set; }

    }
}
  //      [ForeignKey("UsersZingers_Users")]