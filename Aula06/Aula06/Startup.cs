using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula06.Startup))]
namespace Aula06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
