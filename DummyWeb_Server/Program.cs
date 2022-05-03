using Dummy.Repository;
using Dummy_Data.Model;
using Dummy_Repository.Repository;
using Dummy_Repository.Repository.IRepository;
using Dummy_Repository.Repository.IRepository.Llblgen;
using Dummy_Repository.Repository.Llblgen;
using Dummy_Service;
using DummyWeb_Server.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<DummyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IDummyRepository, DummyRepository>();
builder.Services.AddScoped<IDummyLlblgenRepository, DummyLlblgenRepository>();

var configurationArgs = new ServiceConfigurationArgs();
builder.Configuration.Bind(configurationArgs);
ServiceInitializer.Initialize(configurationArgs);


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
