using cw2_Student.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//pobieramy connection string z pliku appsettings.json
var connString = builder.Configuration.GetConnectionString("sqlite");
builder.Services
    .AddDbContext<StudentDbContext>(
        options => options.UseSqlite(connString)
        );
//tutaj następuje budowa aplikacji
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.Run();