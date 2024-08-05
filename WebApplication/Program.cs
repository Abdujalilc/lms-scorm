using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using OpenSourceSCORMLMS.Data;
using OpenSourceSCORMLMS.Helpers;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddMvc().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNamingPolicy = null;
    o.JsonSerializerOptions.DictionaryKeyPolicy = null;
}); //prevent JsonResult from camelCasing on its own

// Configure Kestrel
builder.Services.Configure<KestrelServerOptions>(o => { o.Limits.MaxRequestBodySize = long.MaxValue; });
// Configure IIS
builder.Services.Configure<IISServerOptions>(o => { o.MaxRequestBodySize = long.MaxValue; });
// Configure form options
builder.Services.Configure<FormOptions>(o => { o.MultipartBodyLengthLimit = long.MaxValue;});

builder.Services.AddRazorPages();
builder.Services.AddControllers();
var app = builder.Build();


app.UseStaticFiles();

var httpContextAccessor = app.Services.GetRequiredService<IHttpContextAccessor>();
ConfigurationHelper.Initialize(config, httpContextAccessor);

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, ConfigurationHelper.CourseFolder)),
    RequestPath = "/SCORMCourses"
});
app.UseAuthentication();
app.UseRouting();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseAuthorization();

app.Run();