using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ASP_MVC_Ribbit.Models;

namespace ASP_MVC_Ribbit.Data
{
    public class RibbitDatabase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Ribbit> Ribbits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Followers)
                .WithMany(u => u.Followings)
                .Map(map =>
                {
                    map.MapLeftKey("FollowingId");
                    map.MapRightKey("FollowerId");
                    map.ToTable("Follow");
                });

            modelBuilder.Entity<User>().HasMany(u => u.Ribbits);

            base.OnModelCreating(modelBuilder);
        }
    }
}