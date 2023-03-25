using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


// --- Acc�s � HomeController ---
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
var app = builder.Build();
app.UseMvc(routes => routes.MapRoute("Default", "{controller=Home}/{action=Index}"));
app.UseFileServer();
app.Run();