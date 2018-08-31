using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrialsSurveys.Startup))]
namespace TrialsSurveys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
