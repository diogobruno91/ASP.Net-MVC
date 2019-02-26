using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula01.Startup))]
namespace Aula01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
