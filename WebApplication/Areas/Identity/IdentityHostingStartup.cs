using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(OpenSourceSCORMLMS.Areas.Identity.IdentityHostingStartup))]
namespace OpenSourceSCORMLMS.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}