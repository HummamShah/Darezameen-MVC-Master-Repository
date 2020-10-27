using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DareZameen_Web.Startup))]
namespace DareZameen_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
