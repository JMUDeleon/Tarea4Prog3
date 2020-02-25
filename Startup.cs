using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tarea4Pr3.Startup))]
namespace tarea4Pr3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
