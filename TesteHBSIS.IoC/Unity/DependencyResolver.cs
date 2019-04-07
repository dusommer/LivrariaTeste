using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteHBSIS.Domain.Interfaces.Argumentos;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Domain.Interfaces.Repositorios.Base;
using TesteHBSIS.Domain.Interfaces.Servicos;
using TesteHBSIS.Domain.Servicos;
using TesteHBSIS.Infra.Persistencia;
using TesteHBSIS.Infra.Persistencia.Repositorios;
using TesteHBSIS.Infra.Persistencia.Repositorios.Base;
using TesteHBSIS.Infra.Transacao;
using TesteHBSIS.WebApp.ServicesApi;

namespace TesteHBSIS.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DbContext, HBSISContexto>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());
            container.RegisterType(typeof(IRepositorioBase<,>), typeof(RepositorioBase<,>));
            container.RegisterType<IRepositorioAutor, RepositorioAutor>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositorioGenero, RepositorioGenero>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositorioLivro, RepositorioLivro>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicoLivro, ServicoLivro>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicoGenero, ServicoGenero>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicoAutor, ServicoAutor>(new HierarchicalLifetimeManager());
        }
    }
}
