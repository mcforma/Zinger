using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zinger.Models;

namespace Zinger.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Zingers> Zingers { get; set; }
        public DbSet<UsersZingers> UsersZingers { get; set; }
        //public DbSet<Zinger_Replies> Zinger_Replies { get; set; }
        //public DbSet<ZingersZinger_Replies> ZingersZinger_Replies { get; set; }
        public DbSet<Hashtags> Hashtags { get; set; }
        public DbSet<ZingersHashtags> ZingersHashtags { get; set; }
        //public DbSet<Followers> Followers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Composite PKs
            modelBuilder.Entity<UsersZingers>()
                .HasKey(uz => new { uz.Id, uz.Zinger_ID });
            //modelBuilder.Entity<ZingersZinger_Replies>()
            //    .HasKey(zzr => new { zzr.Zinger_ID, zzr.Replying_Zinger_ID });
            modelBuilder.Entity<ZingersHashtags>()
                .HasKey(zh => new { zh.Zinger_ID, zh.Hashtag });
            //modelBuilder.Entity<Followers>()
            //    .HasKey(f => new { f.Id, f.FollowerUserName });

            //FKs
            //UserZingers
            modelBuilder.Entity<UsersZingers>()
                .HasOne<ApplicationUser>(uz => uz.ApplicationUser)
                .WithMany(au => au.UsersZingers)
                .HasForeignKey(uz => uz.Id);
            modelBuilder.Entity<UsersZingers>()
                .HasOne<Zingers>(uz => uz.Zingers)
                .WithMany(au => au.UsersZingers)
                .HasForeignKey(uz => uz.Zinger_ID);

            //ZingerHashtags
            modelBuilder.Entity<ZingersHashtags>()
                .HasOne<Zingers>(zht => zht.Zingers)
                .WithMany(z => z.ZingersHashtags)
                .HasForeignKey(zht => zht.Zinger_ID);
            modelBuilder.Entity<ZingersHashtags>()
                .HasOne<Hashtags>(zht => zht.Hashtags)
                .WithMany(z => z.ZingersHashtags)
                .HasForeignKey(zht => zht.Hashtag);

            //ZingersZinger_Replies
            //modelBuilder.Entity<ZingersZinger_Replies>()
            //    .HasOne<Zingers>(zzr => zzr.Zingers)
            //    .WithMany(z => z.ZingersZinger_Replies)
            //    .HasForeignKey(zzr => zzr.Zinger_ID);
            //modelBuilder.Entity<ZingersZinger_Replies>()
            //    .HasOne<Zinger_Replies>(zzr => zzr.Zinger_Replies)
            //    .WithMany(z => z.ZingersZinger_Replies)
            //    .HasForeignKey(zzr => zzr.Replying_Zinger_ID);

            //Self-referencing Zinger_ID from Replying_Zinger_ID in Zingers.cs
            modelBuilder.Entity<Zingers>()
                .HasOne(zsr => zsr.Zinger)
                .WithMany(zsr => zsr.Replying_Zinger_IDs)
                .HasForeignKey(zsr => zsr.Replying_Zinger_ID);

            //Follower FKs
            //modelBuilder.Entity<Followers>()
            //    .HasOne<ApplicationUser>(f => f.ApplicationUser)
            //    .WithMany(au => au.Followers)
            //    .HasForeignKey(f => f.Id);
            //modelBuilder.Entity<Followers>()
            //    .HasOne<ApplicationUser>(f => f.ApplicationUser)
            //    .WithMany(au => au.Followers)
            //    .HasForeignKey(f => f.FollowerUserName);


            modelBuilder.Seed(); //Seed more data in Extension class if desired

        }
    }
}
