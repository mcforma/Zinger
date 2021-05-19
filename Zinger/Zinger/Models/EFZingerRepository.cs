using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zinger.Models;

namespace Zinger.Models
{
    public class EFZingerRepository : IZingerRepository
    {
        private ApplicationDbContext context;

        public EFZingerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ApplicationUser> ApplicationUser => context.ApplicationUser;
        public IQueryable<Zingers> Zingers => context.Zingers;
        //public IQueryable<UsersZingers> UsersZingers => context.UsersZingers;
        //public IQueryable<Zinger_Replies> Zinger_Replies => context.Zinger_Replies;
        public IQueryable<Hashtags> Hashtags => context.Hashtags;
        public IQueryable<ZingersHashtags> ZingersHashtags => context.ZingersHashtags;
        //public IQueryable<ZingersZinger_Replies> ZingersZinger_Replies => context.ZingersZinger_Replies;
        public IQueryable<Followers> Followers => context.Followers;
    }
}
