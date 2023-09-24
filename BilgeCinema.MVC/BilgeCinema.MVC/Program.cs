using BilgeCinema.MVC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


// appsettings.json kullanýmý için :

var settings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>(); // Json'dan çekilen verilerle AppSettings tipindeki class dolduruldu.

builder.Services.AddSingleton(settings);

var app = builder.Build();


app.MapDefaultControllerRoute();

app.Run();
