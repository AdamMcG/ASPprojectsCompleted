using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CA_Azure.Startup))]
namespace CA_Azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
