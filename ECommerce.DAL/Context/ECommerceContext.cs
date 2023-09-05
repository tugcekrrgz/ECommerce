using ECommerce.Common;
using ECommerce.Entity.Base;
using ECommerce.Entity.Entity;
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

        public override int SaveChanges()
        {
            //Veri yeni eklenirken


            //Veri güncellenirken

            //Kaydedilmek üzere gönderilen veriyi temsil ediyor
            var modifierEntries = ChangeTracker.Entries().Where(x => x.State==EntityState.Modified || x.State==EntityState.Added);
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
