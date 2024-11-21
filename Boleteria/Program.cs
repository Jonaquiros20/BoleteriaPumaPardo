var builder = WebApplication.CreateBuilder(args);

// Agregar servicios necesarios
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache(); // Asegúrate de que está antes de Build()

var app = builder.Build();

// Configurar middleware
app.UseStaticFiles(); // Esto es esencial para cargar CSS, JS y otros archivos estáticos
app.UseRouting();
app.UseAuthorization();

// Configurar las rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
