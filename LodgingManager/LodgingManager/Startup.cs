using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LodgingManager.Startup))]
namespace LodgingManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
