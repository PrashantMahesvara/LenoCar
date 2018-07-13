using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LenoCar.Startup))]
namespace LenoCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
