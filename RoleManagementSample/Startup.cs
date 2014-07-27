using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleManagementSample.Startup))]
namespace RoleManagementSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
