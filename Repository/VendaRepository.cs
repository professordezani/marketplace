using System;
using System.Collections.Generic;
using System.Linq;
using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.EntityFrameworkCore;

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

        public List<Venda> ReadByCliente(Guid id)
        {
           return _dataContext.Vendas.Include(x => x.Cliente).Include(x => x.Produto).Where(x => x.Cliente.Id == id).ToList();
        }

        public List<Venda> ReadByEmpresa()
        {
            return _dataContext.Vendas.Include(x => x.Cliente).Include(x => x.Produto).ToList();
        }

        public void Update(Venda venda)
        {
            _dataContext.Vendas.Update(venda);
            _dataContext.SaveChanges();
        }
    }
}