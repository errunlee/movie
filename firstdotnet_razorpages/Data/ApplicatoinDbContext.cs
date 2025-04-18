﻿using firstdotnet_razorpages.Model;
using Microsoft.EntityFrameworkCore;

namespace firstdotnet_razorpages.Data {
    public class ApplicatoinDbContext : DbContext {
        public ApplicatoinDbContext(DbContextOptions<ApplicatoinDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().HasData(
                new Category { Cateogry_Id = 1, DisplayOrder = 1, Name = "Action" },
                new Category { Cateogry_Id = 2, DisplayOrder = 1, Name = "SciFi" },
                new Category { Cateogry_Id = 3, DisplayOrder = 1, Name = "Comedy" }
                );
        }
    }
}
