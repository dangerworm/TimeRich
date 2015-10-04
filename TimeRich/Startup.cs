using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeRich.Startup))]
namespace TimeRich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
