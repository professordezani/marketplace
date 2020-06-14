using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IFuncionarioRepository
    {
        void Create(Funcionario funcionario);
        Funcionario Read(Guid id);
        List<Funcionario> ReadByEmpresa(Guid id);
        void Update(Funcionario funcionario);
        void Delete(Guid id);
    }
}