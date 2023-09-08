using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.BLL.Concrete;
using ECommerce.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IOC.Container
{
    public class ServiceIOC
    {
        public static void ServiceConfigure(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>),typeof(BaseRepository<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            //Supplier Service

            //Order Service
            services.AddScoped<IOrderService, OrderService>();

            //OrderDetail Service
            services.AddScoped<IOrderDetailService, OrderDetailService>();
        }
    }
}
