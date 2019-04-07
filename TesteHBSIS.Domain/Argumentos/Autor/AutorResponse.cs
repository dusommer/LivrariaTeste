namespace TesteHBSIS.Domain.Argumentos.Autor
{
    public class AutorResponse
    {
        public static explicit operator AutorResponse(Entidades.Autor autor)
        {
            return new AutorResponse()
            {
                Nome = autor.Nome,
                Id = autor.Id
            };
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
