using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lasg.UI.Web.Startup))]
namespace Lasg.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
