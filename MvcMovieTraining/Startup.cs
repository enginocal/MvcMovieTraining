using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCollegeTraining.Startup))]
namespace MvcCollegeTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
