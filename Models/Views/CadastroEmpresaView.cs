using Marketplace.Models.Entidades;
using System.Collections.Generic;
using System;

namespace Marketplace.Models.Views {
    public class CadastroEmpresaView {
        public List<Categoria> Categorias { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }

        public Guid Categoria { get; set;}

        public string Email { get; set; }

        public string Senha { get; set; }

        public CadastroEmpresaView(){
           Categorias = new List<Categoria>();
        }
    }    
}