using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DYC_FinalYr_.Startup))]
namespace DYC_FinalYr_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
