using Marketplace.Models.Entidades;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Views {
    public class CadastroEmpresaView {
        public List<Categoria> Categorias { get; set; }
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(100)]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(100)]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(18)]
        public string Cnpj { get; set; }
        [Required]
        public Guid Categoria { get; set;}
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MinLength(6,ErrorMessage="Senha deve ter no mínimo 6 caracteres")]
        [MaxLength(25)]
        public string Senha { get; set; }

        public CadastroEmpresaView(){
           Categorias = new List<Categoria>();
        }
    }    
}