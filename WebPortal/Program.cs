using AutoMapper;
using BMS.Data;
using BMS.Data.Models;
using BMS.Data.Providers;
using BMS.Data.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
//   .AddNegotiate()
//   .AddCookie();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});
builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BMSDbContext>(options =>  options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IProductsDataProvider, ProductsDataProvider>();
builder.Services.AddScoped<IOrderDataProvider, OrderDataProvider>();
builder.Services.AddScoped<ICustomerDataProvider, CustomerDataProvider>();
builder.Services.AddScoped<ITeamsDataProvider, TeamsDataProvider>();
builder.Services.AddScoped<IProductIngredientsDataProvider, ProductIngredientsDataProvider>();
builder.Services.AddScoped<IRawMaterialsDataProvider, RawMaterialsDataProvider>();
builder.Services.AddScoped<ICategoryDataProvider, CategoryDataProvider>();
builder.Services.AddScoped<ISubCategoryDataProvider, SubCategoryDataProvider>();
builder.Services.AddScoped<IInvoiceDataProvider, InvoiceDataProvider>();

// Add AutoMapper
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());

builder.Services.AddRazorPages(options =>
{        
    options.Conventions.AuthorizeFolder("/");
    options.Conventions.AuthorizeFolder("/Develop");
    options.Conventions.AllowAnonymousToFolder("/Account");
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);

});
builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Apply migrations automatically
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BMSDbContext>();
    dbContext.Database.Migrate(); // Apply any pending migrations
    DbInitializer.Seed(dbContext); // Seed initial data
}

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
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

// Redirect root ("/") to "/Orders"
app.MapGet("/", context =>
{
    context.Response.Redirect("/Orders");
    return Task.CompletedTask;
});

app.Run();
