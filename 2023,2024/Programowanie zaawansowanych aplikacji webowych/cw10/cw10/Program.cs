var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/data", () => {return DateTime.Now.Day + " " + DateTime.Now.Date.Month + " " + DateTime.Now.Date.Year;});
app.MapGet("/wizytowka", () => {return "Jestem Kacper :D ";});

app.Run();
