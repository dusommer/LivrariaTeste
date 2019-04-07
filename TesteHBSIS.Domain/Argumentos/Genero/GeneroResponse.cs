namespace TesteHBSIS.Domain.Argumentos.Genero
{
    public class GeneroResponse
    {
        public static explicit operator GeneroResponse(Entidades.Genero genero)
        {
            return new GeneroResponse()
            {
                Nome = genero.Nome,
                Id = genero.Id
            };
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
