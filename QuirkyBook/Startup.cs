using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuirkyBook.Startup))]
namespace QuirkyBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
