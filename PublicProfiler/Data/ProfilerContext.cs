using Microsoft.EntityFrameworkCore;
using PublicProfiler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicProfiler.Data
{
    public class ProfilerContext :DbContext
    {

        public ProfilerContext(DbContextOptions<ProfilerContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);

           modelBuilder.Entity<Social>().HasOne<User>(p => p.User).WithMany(p => p.Socials);

           modelBuilder.Entity<User>().HasMany<Social>(p => p.Socials).WithOne(p => p.User);
        }

        //Here we created classes for the Models we added - These are the databases that will get created 
        public DbSet<User> User { get; set; } 
        public DbSet<Social> Social  { get; set; }
    }
}

