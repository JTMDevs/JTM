using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Matrimony.UI.Startup))]
namespace Matrimony.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
