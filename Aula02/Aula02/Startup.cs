using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula02.Startup))]
namespace Aula02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
