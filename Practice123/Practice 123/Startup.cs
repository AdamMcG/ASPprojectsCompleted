using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice_123.Startup))]
namespace Practice_123
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
