using Microsoft.EntityFrameworkCore;
using OzelDersPlatform.Entity;
using System.Collections.Generic;

namespace OzelDersPlatform.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers {  get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons {  get; set; }
        public DbSet<Application> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}