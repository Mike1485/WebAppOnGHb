using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTakeOne9pm.Startup))]
namespace WebTakeOne9pm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
