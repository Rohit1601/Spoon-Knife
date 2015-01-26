using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(spoon_knife_project.Startup))]
namespace spoon_knife_project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
