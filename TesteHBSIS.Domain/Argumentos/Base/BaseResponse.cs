namespace TesteHBSIS.Domain.Arguments.Base
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Message = "Sucesso.";
        }
        public string Message { get; set; }

        public static explicit operator BaseResponse(Entidades.Livro entidade)
        {
            return new BaseResponse()
            {
                Message = "Sucesso."
            };
        }
    }
}
