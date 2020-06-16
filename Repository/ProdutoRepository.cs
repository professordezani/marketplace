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

        public List<Produto> ReadByEmpresa(Guid id){
            return _dataContext.Produtos.Where(x => x.Empresa.Id == id).OrderBy(x => x.Titulo).ToList();
        }

        public Produto Read(Guid id){
            return _dataContext.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Produto produto){
            _dataContext.Produtos.Update(produto);
            _dataContext.SaveChanges();
        }

        public List<Produto> ReadDisponivel(Guid? id){
            var produtos = new List<Produto>();
            if (id.HasValue){
               produtos = _dataContext.Produtos.Where(x => x.Indisponivel == false && x.Empresa.Categoria.Id == id).ToList(); 
            } else {
               produtos = _dataContext.Produtos.Where(x => x.Indisponivel == false).ToList(); 
            }            
            Shuffle(produtos);
            return produtos;       
        }

        private void Shuffle(List<Produto> produtos)  
        {  
            var rng = new Random();  
            int n = produtos.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                Produto value = produtos[k];  
                produtos[k] = produtos[n];  
                produtos[n] = value;  
            }  
        }
    }
}