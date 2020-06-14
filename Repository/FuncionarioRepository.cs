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

        public void Create(Funcionario funcionario) {
            _dataContext.Add(funcionario);
            _dataContext.SaveChanges();
        }
        
        public Funcionario Read(Guid id)
        {
            return _dataContext.Funcionarios.Include(x => x.Empresa).Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Funcionario> ReadByEmpresa(Guid id)
        {
            return _dataContext.Funcionarios.Where(x => x.Empresa.Id == id && x.Principal == false).OrderBy(x => x.Nome).ToList();
        }

        public void Update(Funcionario funcionario)
        {
           _dataContext.Funcionarios.Update(funcionario);
           _dataContext.SaveChanges();
        }

        public void Delete(Guid id){
            var funcionario = Read(id);
            _dataContext.Funcionarios.Remove(funcionario);
            _dataContext.SaveChanges();
        }
   }
}