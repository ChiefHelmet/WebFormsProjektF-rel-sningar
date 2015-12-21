using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsProjektFöreläsningar.Startup))]
namespace WebFormsProjektFöreläsningar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
