using SensoStatWeb.Business;
using SensoStatWeb.Business.Interfaces;
using SensoStatWeb.WebApplication.Services;
using SensoStatWeb.WebApplication.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args); // create web app
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); // Add controler with views to app

builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IAdministratorService, AdministratorService>();
builder.Services.AddScoped<ISurveyService, SurveyService>();


var app = builder.Build();
app.UseRouting(); // Start
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
app.UseStaticFiles();

app.Run();

