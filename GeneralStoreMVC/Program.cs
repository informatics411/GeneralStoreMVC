using Microsoft.EntityFrameworkCore;
//using GeneralStoreMVC.Data;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
//builder.Services.AddDbContext<GeneralStoreDb>
//    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("GSLocal")));

//builder.Services.AddDbContext<GeneralStoreDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings:GSLocal")));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

