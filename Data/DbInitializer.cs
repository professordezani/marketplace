using Marketplace.Models;
using Marketplace.Data;
using System.Linq;
using System.Collections.Generic;

namespace Marketplace.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext dataContext)
        {
            dataContext.Database.EnsureCreated();

            if (dataContext.Categorias.Any())
            {
                return;
            }

            var categorias = new List<Categoria>(){
             new Categoria {
                Descricao = "Automotivo"
             },
             new Categoria {
                Descricao = "Diversos"
             },
             new Categoria {
                Descricao = "Lar"
             },
             new Categoria {
                Descricao = "Tecnologia"
             },
             new Categoria {
                Descricao = "Vestuário"
             }
         };

            foreach (var categoria in categorias)
            {
                dataContext.Categorias.Add(categoria);
            }

            dataContext.SaveChanges();
        }
    }
}