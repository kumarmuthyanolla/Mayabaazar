using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mayabazaar.Startup))]
namespace Mayabazaar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
