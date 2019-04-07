using System;
using System.Collections.Generic;
using System.Linq;
using prmToolkit.NotificationPattern;
using TesteHBSIS.Domain.Argumentos;
using TesteHBSIS.Domain.Argumentos.Livro;
using TesteHBSIS.Domain.Arguments.Base;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Domain.Interfaces.Servicos;

namespace TesteHBSIS.Domain.Servicos
{
    public class ServicoLivro : Notifiable, IServicoLivro
    {
        private readonly IRepositorioLivro _repositorioLivro;
        private readonly IRepositorioGenero _repositorioGenero;
        public ServicoLivro()
        {

        }

        public ServicoLivro(IRepositorioLivro repositorioLivro, IRepositorioGenero repositorioGenero)
        {
            _repositorioLivro = repositorioLivro;
            _repositorioGenero = repositorioGenero;
        }

        public AdicionarLivroResponse AdicionarLivro(AdicionarLivroRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarLivroRequest", "AdicionarLivroRequest é obrigatório.");
            }

            Livro livro = new Livro(request.Titulo, request.Preco, request.Estoque, request.Edicao, request.IdGenero, request.IdAutor);

            AddNotifications(livro);

            VerificaSeExisteLivroComMesmoTituloEdicao(request.Titulo, request.Edicao);

            if (IsInvalid())
            {
                return null;
            }

            livro = _repositorioLivro.Adicionar(livro);

            return (AdicionarLivroResponse)livro;
        }

        public AlterarLivroResponse AlterarLivro(AlterarLivroRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarLivroRequest", "AlterarLivroRequest é obrigatório.");
            }

            VerificaSeExisteLivroComMesmoTituloEdicao(request.Titulo, request.Edicao, request.Id);

            Livro livro = _repositorioLivro.ObterPorId(request.Id);

            if (livro == null)
            {
                AddNotification("Livro", "Livro não encontrado.");
                return null;
            }

            livro.AlterarLivro(request);

            AddNotifications(livro);

            if (IsInvalid())
            {
                return null;
            }

            _repositorioLivro.Editar(livro);

            return (AlterarLivroResponse)livro;
        }

        public BaseResponse ExcluirLivro(int id)
        {
            Livro livro = _repositorioLivro.ObterPorId(id);

            if (livro == null)
            {
                AddNotification("Livro", "Livro não encontrado.");
                return null;
            }

            _repositorioLivro.Remover(livro);

            return new BaseResponse();
        }

        public IEnumerable<LivroResponse> ListarLivro(FiltroConsultaRequest filtro = null)
        {
            var consulta = _repositorioLivro.Listar();

            if (filtro != null)
            {
                consulta = string.IsNullOrEmpty(filtro.Titulo) ? consulta : consulta.Where(x => x.Titulo.Contains(filtro.Titulo));
                consulta = filtro.IdAutor != null ? consulta.Where(x => x.IdAutor == filtro.IdAutor) : consulta;
                consulta = filtro.IdGenero != null ? consulta.Where(x => x.IdGenero == filtro.IdGenero) : consulta;
                consulta = filtro.PrecoDe != null ? consulta.Where(x => x.Preco >= filtro.PrecoDe) : consulta;
                consulta = filtro.PrecoAte != null ? consulta.Where(x => x.Preco <= filtro.PrecoAte) : consulta;
            }

            return consulta.OrderBy(x => x.Titulo).ToList().Select(livro => (LivroResponse)livro);
        }

        public Livro ObterLivroPorId(int id)
        {
            return _repositorioLivro.ObterPorId(id);
        }

        public void VerificaSeExisteLivroComMesmoTituloEdicao(string titulo, int edicao, int id = 0)
        {
            if (_repositorioLivro.Listar().Any(x => x.Titulo.Equals(titulo) && x.Edicao.Equals(edicao) && x.Id != id))
            {
                AddNotification("Livro", "Já existe um livro cadastrado com esse título e edição");
            }
        }
    }
}
