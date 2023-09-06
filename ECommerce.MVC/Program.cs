using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.BLL.Concrete;
using ECommerce.BLL.Services;
using ECommerce.DAL.Context;
using ECommerce.IOC.Container;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

//MVC
builder.Services.AddControllersWithViews();

//Database Service
builder.Services.AddDbContext<ECommerceContext>();

//Identity Service
//AddEntityFrameworkStores kýsmýný tanýmlamazsak tiplerin nereye ait olacaðýný bilemez. 
builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<ECommerceContext>();


ServiceIOC.ServiceConfigure(builder.Services);
/* ServiceIOC de tanýmlý
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

//Kimlik Doðrulama 
app.UseAuthentication();

//Yetkilendirme
app.UseAuthorization();

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
