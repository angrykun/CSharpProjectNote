using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XEngine.Startup))]
namespace XEngine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
