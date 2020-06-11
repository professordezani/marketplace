using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Models.Entidades
{
    public class Categoria : EntidadeBase {
        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }
    }    
}