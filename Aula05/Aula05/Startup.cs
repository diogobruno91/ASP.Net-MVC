using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula05.Startup))]
namespace Aula05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
