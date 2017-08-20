using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitApp.Startup))]
namespace UnitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
