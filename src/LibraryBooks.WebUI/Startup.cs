using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryBooks.WebUI.Startup))]
namespace LibraryBooks.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
