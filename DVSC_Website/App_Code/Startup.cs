using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVSC_Website.Startup))]
namespace DVSC_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
