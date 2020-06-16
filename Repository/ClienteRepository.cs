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

        public Cliente Read(Guid id)
        {
            return (Cliente)_dataContext.Usuarios.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Cliente cliente)
        {
            _dataContext.Update(cliente);
            _dataContext.SaveChanges();
        }       
    }
}