using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EjemploBanco.Startup))]

namespace EjemploBanco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}