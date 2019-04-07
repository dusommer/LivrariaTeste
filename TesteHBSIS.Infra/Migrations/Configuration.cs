namespace TesteHBSIS.Infra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TesteHBSIS.Domain.Entidades;

    internal sealed class Configuration : DbMigrationsConfiguration<TesteHBSIS.Infra.Persistencia.HBSISContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TesteHBSIS.Infra.Persistencia.HBSISContexto context)
        {
            context.Generos.AddOrUpdate(x => x.Id,
                new Genero("Romance"),
                new Genero("Conto"),
                new Genero("Autobiografia"),
                new Genero("Biografia"),
                new Genero("Fantasia"),
                new Genero("Fic��o"),
                new Genero("Horror"),
                new Genero("Vampirismo")
            );

            context.Autores.AddOrUpdate(x => x.Id,
                new Autor("William Shakespeare"),
                new Autor("Monteiro Lobato"),
                new Autor("Jos� de Alencar"),
                new Autor("Cec�lia Meireles"),
                new Autor("Carlos Drummond de Andrade"),
                new Autor("Machado de Assis"),
                new Autor("Clarice Lispector "),
                new Autor("Graciliano Ramos")
            );
            context.Livros.AddOrUpdate(x => x.Id,
                new Livro("S�tio do Picapau Amarelo", 35, 17, 1, 5, 2));
        }
    }
}
