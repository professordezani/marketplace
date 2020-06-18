using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IVendaRepository
    {
        void Create(Venda venda);
        Venda Read(Guid id);
        List<Venda> ReadByEmpresa();
        List<Venda> ReadByCliente(Guid id);
        void Update(Venda venda);
    }
}