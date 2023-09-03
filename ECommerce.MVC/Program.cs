using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.BLL.Concrete;
using ECommerce.BLL.Services;
using ECommerce.DAL.Context;
using ECommerce.IOC.Container;

var builder = WebApplication.CreateBuilder(args);

//MVC
builder.Services.AddControllersWithViews();

//Database Service
builder.Services.AddDbContext<ECommerceContext>();


ServiceIOC.ServiceConfigure(builder.Services);
/* ServiceIOC de tan�ml�
//Generic tiplerine bak
builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));


//Category Service
builder.Services.AddScoped<ICategoryService,CategoryService>();

//Product Service
builder.Services.AddScoped<IProductService, ProductService>();

//Supplier Service

//Order Service

//OrderDetail Service
*/

var app = builder.Build();

app.UseRouting();

app.UseStaticFiles();

//Endpoint
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();