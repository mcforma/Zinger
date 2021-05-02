//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Zinger.Models
//{
//    public class Followers
//    {
//        [Required]
//        [Display(Name = "User ID")]
//        public string Id { get; set; }
//        public ApplicationUser ApplicationUser { get; set; }

//        [Required]
//        [Display(Name = "Follower UserName")]
//        public string FollowerUserName { get; set; }
//        [ForeignKey("FollowerUserName")]
//        public ApplicationUser UserName { get; set; }

//    }
//}