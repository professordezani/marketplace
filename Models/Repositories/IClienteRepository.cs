using System;
using Marketplace.Models.Entidades;

namespace Marketplace.Models.Repositories
{
    public interface IClienteRepository
    {
        void Create(Cliente cliente);
        Cliente Read(Guid id);
        void Update(Cliente cliente);

        bool Login(string email, string senha);        
    }
}