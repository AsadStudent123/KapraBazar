using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KapraBazar.Web.Startup))]
namespace KapraBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
