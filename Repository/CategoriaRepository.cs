using Marketplace.Models.Repositories;
using Marketplace.Models.Entidades;
using Marketplace.Data;
using System.Linq;
using System.Collections.Generic;

namespace Marketplace.Repository {
    public class CategoriaRepository : ICategoriaRepository {

        private readonly DataContext _dataContext;

        public CategoriaRepository (DataContext dataContext){
            _dataContext = dataContext;
        }

        public List<Categoria> Read(){
            return _dataContext.Categorias.ToList();
        }        
    }
}