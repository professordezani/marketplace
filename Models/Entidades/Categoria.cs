using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades
{
    public class Categoria : EntidadeBase {
        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

        public static implicit operator List<object>(Categoria v)
        {
            throw new NotImplementedException();
        }
    }    
}