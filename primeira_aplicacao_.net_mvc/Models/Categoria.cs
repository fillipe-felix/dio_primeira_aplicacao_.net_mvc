using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace primeira_aplicacao_.net_mvc.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }
        
        public List<Produto> Produtos { get; set; }
    }
}