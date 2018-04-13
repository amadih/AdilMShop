using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdilMShop.WebUI.Startup))]
namespace AdilMShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
