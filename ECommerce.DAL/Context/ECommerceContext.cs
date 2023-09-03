﻿using ECommerce.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Context
{
    public class ECommerceContext:IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-I9V1GOS\\SQLEXPRESS;database=ECommerceDB;uid=sa;pwd=Tugce8417058;TrustServerCertificate=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
