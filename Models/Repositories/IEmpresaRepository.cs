using System;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories{
    public interface IEmpresaRepository
    {
        void Create(Empresa empresa, Funcionario funcionario);        
    }
}