using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class AppContext:DbContext
    {
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        DbSet<FaqGroup> FaqGroups { get; set; }

        DbSet<FaqQuestion> FaqQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FaqGroup>()
                .HasMany(c => c.FaqQuestions)
                .WithOne(e => e.FaqGroup)
                .IsRequired();
        }
    }
}
