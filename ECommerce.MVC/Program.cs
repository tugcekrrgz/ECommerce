using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.BLL.Concrete;
using ECommerce.BLL.Services;
using ECommerce.DAL.Context;
using ECommerce.IOC.Container;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//MVC
builder.Services.AddControllersWithViews();

//Database Service
//builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("ECommerce.MVC")));

//Identity Service
//AddEntityFrameworkStores kýsmýný tanýmlamazsak tiplerin nereye ait olacaðýný bilemez. 
//Kullanýcýlara ait token oluiturabilmek için eklendi.
builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<ECommerceContext>().AddDefaultTokenProviders();


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

builder.Services.AddSession(x => {
    x.Cookie.Name = "ECommerce_Cart_Session";
    x.IdleTimeout=TimeSpan.FromMinutes(1);
});


builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/Home/Login";
    x.AccessDeniedPath = "/Home/Login";
    x.Cookie = new CookieBuilder
    {
        Name = "ecommerce_cookie"
    };
    x.SlidingExpiration = true;
    x.ExpireTimeSpan = TimeSpan.FromMinutes(10);
});


var app = builder.Build();


app.UseRouting();

//Kimlik Doðrulama 
app.UseAuthentication();

//Yetkilendirme
app.UseAuthorization();

app.UseStaticFiles();

app.UseSession();

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
