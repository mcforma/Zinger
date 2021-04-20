using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zinger.Models;

namespace Zinger.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Zingers> Zingers { get; set; }
        public DbSet<UsersZingers> UsersZingers { get; set; }
        public DbSet<Zinger_Replies> Zinger_Replies { get; set; }
        public DbSet<ZingersZinger_Replies> ZingersZinger_Replies { get; set; }
        public DbSet<Hashtags> Hashtags { get; set; }
        public DbSet<ZingersHashtags> ZingersHashtags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersZingers>()
                .HasKey(uz => new { uz.U_ID, uz.Zinger_ID });
            modelBuilder.Entity<ZingersZinger_Replies>()
                .HasKey(zzr => new { zzr.Zinger_ID, zzr.Replying_Zinger_ID });
            modelBuilder.Entity<ZingersHashtags>()
                .HasKey(zh => new { zh.Zinger_ID, zh.Hashtag });
        }
    }
}
