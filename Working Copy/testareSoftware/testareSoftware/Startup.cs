using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testareSoftware.Startup))]
namespace testareSoftware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
