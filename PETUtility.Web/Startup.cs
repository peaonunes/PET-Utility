using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PETUtility.Web.Startup))]
namespace PETUtility.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
