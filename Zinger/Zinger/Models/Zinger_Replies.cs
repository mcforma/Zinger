using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class Zinger_Replies
    {
        [Key]
        [Display(Name = "Replying Zinger ID")]
        public int Replying_Zinger_ID { get; set; }

        //[Display(Name = "Original Zinger ID")]
        //[Required]
        //public int Zinger_ID { get; set; }
        //public Zingers Zingers { get; set; }

        [Required]
        [Display(Name = "Replying User ID")]
        public int Replying_U_ID { get; set; }
        public ApplicationUser Id { get; set; }

        [Required]
        [Display(Name = "Zinger Reply Content")]
        [StringLength(400, ErrorMessage = "Zinger Reply must be no more than 400 characters")]
        public string Zinger_Reply_Content { get; set; }

        [Required]
        [Display(Name = "Time Stamp")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset Date_Time_Stamp { get; set; } = DateTimeOffset.Now;

        public IList<ZingersZinger_Replies> ZingersZinger_Replies { get; set; }

    }
}
