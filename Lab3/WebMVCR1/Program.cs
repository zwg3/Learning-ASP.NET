var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();

//app.MapControllerRoute(
// name: "default",
// pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();
app.MapGet("/home", () => "Hello World!");
app.Run();
