using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class ZingersZinger_Replies
    {
        [Required]
        [Display(Name = "Zinger ID")]
        public int Zinger_ID { get; set; }
        public Zingers Zingers { get; set; }
        
        [Required]
        [Display(Name = "Replying Zinger ID")]
        public int Replying_Zinger_ID { get; set; }
        public Zinger_Replies Zinger_Replies { get; set; }

    }
}
