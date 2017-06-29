using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAjaxEs.Startup))]
namespace MvcAjaxEs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
