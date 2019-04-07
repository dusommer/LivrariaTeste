using System;
using System.Collections.Generic;
using TesteHBSIS.Domain.Argumentos;
using TesteHBSIS.Domain.Argumentos.Livro;
using TesteHBSIS.Domain.Arguments.Base;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Servicos.Base;

namespace TesteHBSIS.Domain.Interfaces.Servicos
{
    public interface IServicoLivro : IServicoBase
    {
        AdicionarLivroResponse AdicionarLivro(AdicionarLivroRequest request);

        AlterarLivroResponse AlterarLivro(AlterarLivroRequest request);

        IEnumerable<LivroResponse> ListarLivro(FiltroConsultaRequest filtro = null);

        Livro ObterLivroPorId(int id);

        BaseResponse ExcluirLivro(int id);
    }
}
