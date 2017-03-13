using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCw1Homework.Startup))]
namespace MVCw1Homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
