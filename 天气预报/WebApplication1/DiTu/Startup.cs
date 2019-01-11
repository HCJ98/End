using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiTu.Startup))]
namespace DiTu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
