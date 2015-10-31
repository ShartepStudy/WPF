using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Atorization.Startup))]
namespace Atorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
