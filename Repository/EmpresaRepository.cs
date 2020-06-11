using Marketplace.Data;
using Marketplace.Models.Repositories;
using Marketplace.Models.Entidades;

namespace Marketplace.Repository {
    public class EmpresaRepository : IEmpresaRepository{
       private readonly DataContext _dataContext;

       public EmpresaRepository (DataContext dataContext){
           _dataContext = dataContext;
       }

       public void Create(Empresa empresa, Funcionario funcionario){
           _dataContext.Add(empresa);
           _dataContext.Add(funcionario);
           _dataContext.SaveChanges();
       }
    }
}