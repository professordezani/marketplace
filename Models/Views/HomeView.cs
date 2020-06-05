using Marketplace.Models.Entidades;
using System.Collections.Generic;

namespace Marketplace.Models.Views {
    public class HomeView {
        public List<Categoria> Categorias { get; set; }

        public List<ProdutoGroup> ProdutosGroup { get; set; }

        public Produto ProdutoDetail { get; set; }
    }

    public class ProdutoGroup {
        public List<Produto> Produtos { get; set;}

        public ProdutoGroup(){
            Produtos = new List<Produto>();
        }
    }
}