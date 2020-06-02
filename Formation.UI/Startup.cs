using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Formation.UI.Startup))]
namespace Formation.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
