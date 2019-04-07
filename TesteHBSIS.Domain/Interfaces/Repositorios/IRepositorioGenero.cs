using System;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Repositorios.Base;

namespace TesteHBSIS.Domain.Interfaces.Repositorios
{
    public interface IRepositorioGenero : IRepositorioBase<Genero, int>
    {
    }
}
