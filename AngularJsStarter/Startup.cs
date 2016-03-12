using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJsStarter.Startup))]
namespace AngularJsStarter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
