using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OLMS.Startup))]
namespace OLMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
