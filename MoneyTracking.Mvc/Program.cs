using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Entity;
using ServiceLayer.DAL.Repositories;
using MoneyTracking.Data;
using ServiceLayer.UserService;
using ServiceLayer.UserService.Interfaces;

var builder = WebApplication.CreateBuilder(args);
const string connection = @"Server=127.0.0.1;Port=3306;Database=MoneyTracking.Mvc;Uid=root;Pwd=123;";
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<TrackingContext>(options =>
    options.UseMySql(connection, ServerVersion.AutoDetect(connection)));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<TrackingContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ItemsRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();