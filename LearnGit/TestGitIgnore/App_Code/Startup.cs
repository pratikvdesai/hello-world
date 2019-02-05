using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitIgnore.Startup))]
namespace TestGitIgnore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
