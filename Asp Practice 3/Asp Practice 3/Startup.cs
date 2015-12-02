using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp_Practice_3.Startup))]
namespace Asp_Practice_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
