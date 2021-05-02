using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zinger.Models
{
    public interface IZingerRepository
    {
        IQueryable<ApplicationUser> ApplicationUser { get; }
        IQueryable<Zingers> Zingers { get; }
        IQueryable<UsersZingers> UsersZingers { get; }
        //IQueryable<Zinger_Replies> Zinger_Replies { get; }
        IQueryable<Hashtags> Hashtags { get; }
        IQueryable<ZingersHashtags> ZingersHashtags { get; }
        //IQueryable<ZingersZinger_Replies> ZingersZinger_Replies { get; }
        //IQueryable<Followers> Followers { get; }
    }
}
