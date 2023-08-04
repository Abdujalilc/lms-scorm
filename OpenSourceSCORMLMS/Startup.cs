using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;
using OpenSourceSCORMLMS.Data;
using OpenSourceSCORMLMS.Helpers;
using System.IO;

namespace OpenSourceSCORMLMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services
                .AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()); //prevent JsonResult from camelCasing on its own

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseAuthentication();
            // the purpose of the HtmlHandler is to make sure that when people are running SCORM courses (i.e. native html files) that they are authenticated
            app.UseHtmlHandler();

            app.UseStaticFiles(); // For the wwwroot folder

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc();
            var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
            ConfigurationHelper.Initialize(Configuration, httpContextAccessor);
            // we run SCORM courses out of its own folder (NOT wwwroot) so that HtmlHandler can check for authentication before returning any SCORM content
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, ConfigurationHelper.CourseFolder)),
                RequestPath = "/SCORMCourses"
            });

        }
    }
}
