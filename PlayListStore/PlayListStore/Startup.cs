using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayListStore.Startup))]
namespace PlayListStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
