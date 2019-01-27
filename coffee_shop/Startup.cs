using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(coffee_shop.Startup))]
namespace coffee_shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
