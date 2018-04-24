using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTESTSITE.Startup))]
namespace MVCTESTSITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
