using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using OpenSourceSCORMLMS.Data;
using OpenSourceSCORMLMS.Helpers;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Configuration
var config = builder.Configuration;

// Services Registration
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddMvc().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNamingPolicy = null;
    o.JsonSerializerOptions.DictionaryKeyPolicy = null;
});

builder.Services.Configure<FormOptions>(o => o.MultipartBodyLengthLimit = long.MaxValue);

builder.Services.AddRazorPages();
builder.Services.AddControllers();

// Build the application
var app = builder.Build();
ConfigurationHelper.Initialize(app.Configuration, app.Services.GetRequiredService<IHttpContextAccessor>());


// Middleware
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, ConfigurationHelper.CourseFolder)),
    RequestPath = "/SCORMCourses"
});

ConfigurationHelper.Initialize(config, app.Services.GetRequiredService<IHttpContextAccessor>());

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
