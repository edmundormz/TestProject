using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProject.Web.Startup))]
namespace TestProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
