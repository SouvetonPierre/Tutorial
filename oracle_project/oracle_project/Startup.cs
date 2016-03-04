using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oracle_project.Startup))]
namespace oracle_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
