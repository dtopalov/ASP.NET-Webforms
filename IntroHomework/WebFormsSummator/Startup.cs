using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsSummator.Startup))]
namespace WebFormsSummator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
