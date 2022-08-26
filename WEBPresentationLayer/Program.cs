using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Implements;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EsporteDB>(
    options => options.UseSqlServer("name=ConnectionStrings:ConnectionHouse"));

builder.Services.AddTransient<IClienteDALService, ClienteDAL>();
builder.Services.AddTransient<IFuncionarioDALService, FuncionarioDAL>();
builder.Services.AddTransient<IClienteService, ClienteBLL>();
builder.Services.AddTransient<IFuncionarioService, FuncionarioBLL>();
builder.Services.AddTransient<ILoginService, LoginBLL>();
builder.Services.AddTransient<ILoginDALService, LoginDAL>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
