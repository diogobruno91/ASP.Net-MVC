using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula03.Startup))]
namespace Aula03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
