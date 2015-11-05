using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NeighboursCommunitySystem.API.Startup))]

namespace NeighboursCommunitySystem.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}