using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula07.Startup))]
namespace Aula07
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
