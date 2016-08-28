using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sightstone.AspNet.Startup))]
namespace Sightstone.AspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
