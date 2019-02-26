using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula04.Startup))]
namespace Aula04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
