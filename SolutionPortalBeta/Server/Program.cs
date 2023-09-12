using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.AppDbContext;
using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Repository;
using SolutionPortalBeta.Server.Service;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// For DI registration
builder.Services.AddTransient<IRepository<UserComplaint>, USerComplaintRepository>();
builder.Services.AddTransient<IUserComplaintService, UserComplaintService>();
builder.Services.AddTransient<IFaqRepository<FAQ>, FaqRepository>();
builder.Services.AddTransient<IFaqService, FaqService>();
builder.Services.AddTransient<ICompanyRepository<Company>, CompanyRepository>();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddTransient<IDepartmentRepository<Department>,  DepartmentRepository>();
builder.Services.AddTransient<IDepartmentService, DepartmentService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
