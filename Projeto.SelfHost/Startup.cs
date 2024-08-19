using Owin;
using Projeto.API;
using Projeto.API.Service;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Projeto.SelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            UnityConfig.RegisterComponents();
            var config = new HttpConfiguration();

            var container = new UnityContainer();

            container.RegisterType<ICdbService, CdbService>();

            config.DependencyResolver = new UnityDependencyResolver(container);

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
