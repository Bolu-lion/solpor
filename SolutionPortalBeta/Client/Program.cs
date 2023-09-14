using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SolutionPortalBeta.Client;
using SolutionPortalBeta.Client.Services.CompanyServices;
using SolutionPortalBeta.Client.Services.DepartmentServices;
using SolutionPortalBeta.Client.Services.FaqServices;
using SolutionPortalBeta.Client.Services.UserComplaintServices;
using static SolutionPortalBeta.Client.Pages.Nav;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IFaqService, FaqService>();
builder.Services.AddScoped<IUserComplaintService, UserComplaintService>();
builder.Services.AddScoped<BrowserService>(); // scoped service


await builder.Build().RunAsync();

