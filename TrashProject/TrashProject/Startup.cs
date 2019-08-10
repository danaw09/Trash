using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashProject.Startup))]
namespace TrashProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
