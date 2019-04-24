using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula08.UI.Startup))]
namespace Aula08.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
