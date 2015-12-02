using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzurePractice1.Startup))]
namespace AzurePractice1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
