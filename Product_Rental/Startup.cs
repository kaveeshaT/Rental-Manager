using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Product_Rental.Startup))]
namespace Product_Rental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
