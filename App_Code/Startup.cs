using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(linkdownloader.Startup))]
namespace linkdownloader
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
