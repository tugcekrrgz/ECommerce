using Bogus;
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


        protected override void OnModelCreating(ModelBuilder builder)
        {
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
                optionsBuilder.UseSqlServer("server=DESKTOP-I9V1GOS\\SQLEXPRESS;database=ECommerceDB;uid=sa;pwd=Tugce8417058;TrustServerCertificate=True");
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
