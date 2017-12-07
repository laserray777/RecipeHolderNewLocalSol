using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeHolderNewLocal.Startup))]
namespace RecipeHolderNewLocal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
