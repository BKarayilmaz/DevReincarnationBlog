﻿using DevReincarnationBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevReincarnationBlog.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}