using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Marketplace.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DataContext _dataContext;

        public FuncionarioRepository(DataContext dataContext){
            _dataContext = dataContext;
        }

        public void Create(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> Read(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Funcionario Read(Guid id)
        {
            return _dataContext.Funcionarios.Include(x => x.Empresa).Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
   }
}