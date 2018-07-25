using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTestProject4.Startup))]
namespace MvcTestProject4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
