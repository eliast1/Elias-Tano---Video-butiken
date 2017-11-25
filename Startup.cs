using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uppgift6Avancerat.Startup))]
namespace Uppgift6Avancerat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
