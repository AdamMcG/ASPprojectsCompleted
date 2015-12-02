using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CA_Practice2.Startup))]
namespace CA_Practice2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
