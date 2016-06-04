using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftwareArchitecture.Startup))]
namespace SoftwareArchitecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
