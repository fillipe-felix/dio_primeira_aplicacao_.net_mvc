using System.Collections.Generic;

namespace primeira_aplicacao_.net_mvc.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string Descricao { get; set; }
        
        public List<Produto> Produtos { get; set; }
    }
}