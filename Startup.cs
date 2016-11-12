using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoCentrum.Startup))]
namespace AutoCentrum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
