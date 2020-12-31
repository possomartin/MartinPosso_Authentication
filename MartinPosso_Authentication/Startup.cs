using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MartinPosso_Authentication.Startup))]
namespace MartinPosso_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
