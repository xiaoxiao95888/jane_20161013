using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20161013.Startup))]
namespace _20161013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
