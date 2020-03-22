using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiSeguridadMvc.Startup))]
namespace MiSeguridadMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
