using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThunderPlanner.Startup))]
namespace ThunderPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
