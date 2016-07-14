using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(where_I_workService.Startup))]

namespace where_I_workService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}