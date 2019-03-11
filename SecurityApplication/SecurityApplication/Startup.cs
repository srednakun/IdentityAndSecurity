using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityApplication.Startup))]
namespace SecurityApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
