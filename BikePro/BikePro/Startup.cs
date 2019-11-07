using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikePro.Startup))]
namespace BikePro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
