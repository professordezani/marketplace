using System;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IVendaRepository
    {
        void Create(Venda venda);
        Venda Read(Guid id);
        void Update(Venda venda);          
    }
}