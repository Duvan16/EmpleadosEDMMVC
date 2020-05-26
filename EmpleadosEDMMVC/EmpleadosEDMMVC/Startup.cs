using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpleadosEDMMVC.Startup))]
namespace EmpleadosEDMMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
