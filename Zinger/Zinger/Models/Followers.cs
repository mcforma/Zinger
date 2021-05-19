using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class Followers
    {

        //[Key]
        //[Display(Name = "Follower Pair ID")]
        //[Required]
        //public int FollowerPairId { get; set; }

        [Required]
        [Display(Name = "Following User ID")]
        [ForeignKey("Id")]
        public string FollowerUserId { get; set; }
        public ApplicationUser Follower { get; set; }

        [Required]
        [Display(Name = "Followed User ID")]
        [ForeignKey("Id")]
        public string FollowedUserId { get; set; }        
        public ApplicationUser Followee { get; set; }



        //public IList<Followers> FollowingUserIdNav { get; set; }

    }
}