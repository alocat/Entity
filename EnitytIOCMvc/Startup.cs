using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnitytIOCMvc.Startup))]
namespace EnitytIOCMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
