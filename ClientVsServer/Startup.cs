using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientVsServer.Startup))]
namespace ClientVsServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
