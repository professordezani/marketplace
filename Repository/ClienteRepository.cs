using System;
using System.Linq;
using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;

namespace Marketplace.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(Cliente cliente)
        {
            _dataContext.Add(cliente);
            _dataContext.SaveChanges();
        }

        public bool Login(string email, string senha)
        {
            Cliente cliente =_dataContext.Cliente.Where(x => x.Email == email && x.Senha == senha).FirstOrDefault();

            if (cliente == null)
                return false;
            else
                return true;
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