using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectTraoDoiSach.Startup))]
namespace ProjectTraoDoiSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
