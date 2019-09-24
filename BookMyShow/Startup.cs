using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMyShow.Startup))]
namespace BookMyShow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
