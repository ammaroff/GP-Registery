using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GP_Registery.Startup))]
namespace GP_Registery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
