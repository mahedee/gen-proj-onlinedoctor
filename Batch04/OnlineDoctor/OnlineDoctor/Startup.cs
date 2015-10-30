using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineDoctor.Startup))]
namespace OnlineDoctor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
