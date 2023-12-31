﻿using Bogus;
using ECommerce.Common;
using ECommerce.Entity.Base;
using ECommerce.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Context
{
    public class ECommerceContext:IdentityDbContext
    {        
        public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
        {

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Fluent API olarak adlandırılıyor.
            //Order Detail Mapping
            builder.Entity<OrderDetail>().Ignore(x => x.Id);
            builder.Entity<OrderDetail>().HasKey(x => new {x.ProductId, x.OrderId});

            //Category and product mapping
            builder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            //Product and order detail mapping
            builder.Entity<Product>()
                .HasMany(x => x.OrderDetails)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            //Order and order detail mapping
            builder.Entity<Order>()
                .HasMany(x => x.OrderDetails)
                .WithOne(x => x.Order)
                .HasForeignKey( x=> x.OrderId);

            //Order and shipper mapping
            builder.Entity<Shipper>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Shipper)
                .HasForeignKey(x => x.ShipperId);

            
            builder.Entity<Order>().Property(x => x.ShipperId).IsRequired(false);

            //Shipper
            List<Shipper> shippers = new List<Shipper>()
            {
                new Shipper { Id=1,CompanyName = "Aras Kargo", Address = "İstanbul/Pendik", PhoneNumber = "12345678", Status=0 },
                new Shipper { Id=2,CompanyName = "Yurtiçi Kargo", Address = "Ankara/Çankaya", PhoneNumber = "12345678", Status=0 },
                new Shipper { Id=3,CompanyName = "MNG Kargo", Address = "Kocaeli/İzmit", PhoneNumber = "12345678", Status=0 },
                new Shipper { Id=4,CompanyName = "Sürat Kargo", Address = "Sakarya/Hendek", PhoneNumber = "12345678", Status=0 },
                new Shipper { Id=5,CompanyName = "PTT Kargo", Address = "Trabzon/Beşikdüzü", PhoneNumber = "12345678", Status=0 }
            };

            builder.Entity<Shipper>().HasData(shippers);      


            //todo: Ayrı bir katmana taşı.
            //Seed Products and Categories

            //Category
            var faker = new Faker();
            var fakerCategories = faker.Commerce.Categories(10);

            var categories=new List<Category>();

            for (int i=0;i<fakerCategories.Length;i++)
            {
                Category category = new Category
                {
                    Id = i + 1,
                    CategoryName = fakerCategories[i],
                    Description = $"{fakerCategories[i]} description.",
                };
                categories.Add(category);
            }

            //Örnek veriler tabloya dahil edildi.
            builder.Entity<Category>().HasData(categories);

            //Product

            int idCounter = 1;
            var products=new List<Product>();

            for (int i=0;i<categories.Count;i++)
            {
                for (int t=0;t<10;t++)
                {
                    Product product = new Product()
                    {
                        Id = idCounter,
                        CategoryId = categories[i].Id,
                        ProductName = faker.Commerce.ProductName(),
                        Description = faker.Commerce.ProductAdjective(),
                        UnitPrice = decimal.Parse(faker.Commerce.Price()),
                        UnitsInStock = faker.Random.Short(0, 10001),
                    };

                    products.Add(product);
                    idCounter++;
                }
            }

            builder.Entity<Product>().HasData(products);



            base.OnModelCreating(builder);
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-I9V1GOS\\SQLEXPRESS;database=ECommerceDB;uid=sa;pwd=;TrustServerCertificate=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
        */

        public override int SaveChanges()
        {
            //Veri yeni eklenirken


            //Veri güncellenirken

            //Kaydedilmek üzere gönderilen veriyi temsil ediyor
            var modifierEntries = ChangeTracker.Entries().Where(x => x.State==EntityState.Modified || x.State==EntityState.Added );
            try
            {
                foreach (var item in modifierEntries)
                {
                    var entityRepository = item.Entity as BaseClass;
                    if (item.State == EntityState.Modified)
                    {
                        entityRepository.UpdatedDate = DateTime.Now;
                        entityRepository.UpdatedIpAddress = IPAddressFinder.GetIPAddress();
                        entityRepository.UpdatedComputerName=Environment.MachineName;
                    }
                    else if (item.State==EntityState.Added)
                    {
                        entityRepository.CreatedDate=DateTime.Now;
                        entityRepository.CreatedIpAddress = IPAddressFinder.GetIPAddress();
                        entityRepository.CreatedComputerName=Environment.MachineName;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return base.SaveChanges();
        }
    }
}
