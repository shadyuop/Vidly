using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyT.Startup))]
namespace VidlyT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
