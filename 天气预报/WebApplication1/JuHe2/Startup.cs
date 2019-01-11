using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JuHe2.Startup))]
namespace JuHe2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
