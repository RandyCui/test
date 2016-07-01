using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mu.Startup))]
namespace Mu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
