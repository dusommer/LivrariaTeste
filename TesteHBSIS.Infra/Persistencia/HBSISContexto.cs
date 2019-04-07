using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TesteHBSIS.Domain.Entidades;

namespace TesteHBSIS.Infra.Persistencia
{
    public class HBSISContexto : DbContext
    {
        public HBSISContexto() : base("HBSISConnectionString")
        {

        }

        public IDbSet<Autor> Autores { get; set; }
        public IDbSet<Genero> Generos { get; set; }
        public IDbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Entity<Autor>()
                .Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Autor>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Autor)
                .HasForeignKey(e => e.IdAutor);

            modelBuilder.Entity<Genero>()
                .Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Genero>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Genero)
                .HasForeignKey(e => e.IdGenero);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Titulo)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Preco)
                .IsRequired();

            modelBuilder.Entity<Livro>()
                .Property(e => e.Estoque)
                .IsRequired();

            modelBuilder.Entity<Livro>()
                .Property(e => e.Edicao)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
