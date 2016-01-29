using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovieTraining.Startup))]
namespace MvcMovieTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
