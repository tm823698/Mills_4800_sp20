using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mills_4800.Startup))]
namespace Mills_4800
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
