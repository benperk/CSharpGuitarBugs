using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpGuitarBugs.Startup))]
namespace CSharpGuitarBugs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
