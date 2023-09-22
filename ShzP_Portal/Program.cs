using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShzP_Portal.Areas.Identity.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ShzP_PortalContextConnection") ?? throw new InvalidOperationException("Connection string 'ShzP_PortalContextConnection' not found.");

builder.Services.AddDbContext<ShzP_PortalContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ShzP_PortalUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ShzP_PortalContext>();

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[] { new CultureInfo("en-US"), new CultureInfo("zh-Hans") };
    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedUICultures = supportedCultures;
});

var app = builder.Build();

app.UseRequestLocalization();


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

//var localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();


app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Portal}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
