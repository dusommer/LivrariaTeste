using System.Web.Mvc;
using Microsoft.Practices.Unity;
using TesteHBSIS.WebApp.ServicesApi;
using Unity.Mvc3;

namespace TesteHBSIS.WebApp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IServicoApiAutor, ServicoApiAutor>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicoApiGenero, ServicoApiGenero>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicoApiLivro, ServicoApiLivro>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}