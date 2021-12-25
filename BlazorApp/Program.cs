using BlazorApp;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorApp.Data;
using BlazorApp.Pages;
using Blazored.Toast;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IClock, ClockUtc>();
builder.Services.AddSingleton<ICatalog, SimpleCatalog>();
builder.Services.AddSingleton<IBasket, SimpleBasket>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddBlazoredToast();

var dbPath = "myapp.db";
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();