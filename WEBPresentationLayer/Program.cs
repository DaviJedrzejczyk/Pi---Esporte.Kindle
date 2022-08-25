using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Implements;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EsporteDB>(
    options => options.UseSqlServer("name=ConnectionStrings:ConnectionEntra"));

builder.Services.AddTransient<IClienteDALService, ClienteDAL>();
builder.Services.AddTransient<IFuncionarioDALService, FuncionarioDAL>();
builder.Services.AddTransient<IClienteService, ClienteBLL>();
builder.Services.AddTransient<IFuncionarioService, FuncionarioBLL>();
builder.Services.AddTransient<ILoginService, LoginBLL>();
builder.Services.AddTransient<ILoginDALService, LoginDAL>();



builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
