using System;
using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;

namespace Marketplace.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public void Create(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}