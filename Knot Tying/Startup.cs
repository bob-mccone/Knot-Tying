using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Knot_Tying.Startup))]
namespace Knot_Tying
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
