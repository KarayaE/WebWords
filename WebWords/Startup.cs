using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebWords.Startup))]
namespace WebWords
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
