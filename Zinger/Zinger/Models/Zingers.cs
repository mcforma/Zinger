using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public class Zingers
    {
        [Key]
        [Display(Name = "Zinger ID")]
        [Required]
        public int Zinger_ID { get; set; }

        [AllowNull]
        [StringLength(400, ErrorMessage = "Hashtag must be no more than 400 characters")]
        public string? Hashtag { get; set; }

        [Required]
        [Display(Name = "Zinger Content")]
        [StringLength(400, ErrorMessage = "Zinger must be no more than 400 characters")]
        public string Zinger_Content { get; set; }

        [Required]
        [Display(Name = "Time Stamp")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset Date_Time_Stamp { get; set; } = DateTimeOffset.Now;

        public IList<UsersZingers> UsersZingers { get; set; }
        public IList<ZingersZinger_Replies> ZingersZinger_Replies { get; set; }
        public IList<ZingersHashtags> ZingersHashtags { get; set; }

    }
}
