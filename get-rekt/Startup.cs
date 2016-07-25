using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(get_rekt.Startup))]
namespace get_rekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
