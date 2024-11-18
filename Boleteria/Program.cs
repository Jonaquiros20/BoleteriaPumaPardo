var builder = WebApplication.CreateBuilder(args);

// Agregar servicios necesarios
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseCookiePolicy();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",

    pattern: "{controller=Home}/{action=Index}/{id?}");
builder.Services.AddDistributedMemoryCache();



app.Run();
