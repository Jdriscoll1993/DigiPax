using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DigiPax.Areas.Identity.IdentityHostingStartup))]

namespace DigiPax.Areas.Identity
{
    //Identity is configured here. IHostingStartup implementation adds enhancements to an app at startup from an external assembly. 
    //For example, an external library can use a hosting startup implementation to provide additional configuration providers or services to an app.
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}