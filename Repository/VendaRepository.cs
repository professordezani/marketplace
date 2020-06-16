using System;
using System.Linq;
using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;

namespace Marketplace.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly DataContext _dataContext;

        public VendaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Venda venda)
        {
            _dataContext.Add(venda);
            _dataContext.SaveChanges();
        }

        public Venda Read(Guid id)
        {
            return _dataContext.Vendas.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Venda venda)
        {
            _dataContext.Vendas.Update(venda);
            _dataContext.SaveChanges();
        }
    }
}