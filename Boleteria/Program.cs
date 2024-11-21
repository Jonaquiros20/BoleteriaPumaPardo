var builder = WebApplication.CreateBuilder(args);

// Agregar servicios necesarios
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache(); // Aseg�rate de que est� antes de Build()

var app = builder.Build();

// Configurar middleware
app.UseStaticFiles(); // Esto es esencial para cargar CSS, JS y otros archivos est�ticos
app.UseRouting();
app.UseAuthorization();

// Configurar las rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
