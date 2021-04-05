using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class ZingersHashtags
    {
        [Required]
        [Display(Name = "Zinger ID")]
        public int Zinger_ID { get; set; }
        public Zingers Zingers { get; set; }

        [Required]
        [StringLength(400, ErrorMessage = "Hashtag must be no more than 400 characters")]
        public string Hashtag { get; set; }
        public Hashtags Hashtags { get; set; }
    }
}
