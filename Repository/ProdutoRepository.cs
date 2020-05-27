using Marketplace.Data;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Marketplace.Repository {
    public class ProdutoRepository : IProdutoRepository {
        private readonly DataContext _dataContext;

        public ProdutoRepository (DataContext dataContext) {
            _dataContext = dataContext;
        }

        public void Create(Produto produto){
          _dataContext.Add(produto);
          _dataContext.SaveChanges();
        }

        public List<Produto> Read(){
            return _dataContext.Produtos.ToList();
        }

        public Produto Read(Guid id){
            return _dataContext.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}