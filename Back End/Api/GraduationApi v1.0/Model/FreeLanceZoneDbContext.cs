using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class FreeLanceZoneDbContext:DbContext
    {
        public FreeLanceZoneDbContext(DbContextOptions<FreeLanceZoneDbContext> options) :base(options)
        {

        }
        public  DbSet<User> Users { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Zone> Zones { get; set; }
        public DbSet<Mentor> Mentors { get; set; }

        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<ZoneManager> ZoneManagers { get; set; }
        public DbSet<StatisticNumber> StatisticNumbers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<BannerImages> BannerImages { get; set; }
        public DbSet<FreelancersOpinion> FreelancersOpinions { get; set; }
        public DbSet<FreelancersStories> FreelancersStories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique(); base.OnModelCreating(modelBuilder);
        }
    }
}
