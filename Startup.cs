using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kCab.Startup))]
namespace kCab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
