using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IFuncionarioRepository
    {
        void Create(Funcionario funcionario);
        List<Funcionario> Read(Empresa empresa);
        Funcionario Read(Guid id);
        void Update();

    }
}