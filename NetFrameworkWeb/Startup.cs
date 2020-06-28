using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetFrameworkWeb.Startup))]
namespace NetFrameworkWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
