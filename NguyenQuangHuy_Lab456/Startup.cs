using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenQuangHuy_Lab456.Startup))]
namespace NguyenQuangHuy_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
