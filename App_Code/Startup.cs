using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TallerNube.Startup))]
namespace TallerNube
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
