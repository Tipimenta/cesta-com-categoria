using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaLoja
{


    struct Produto
    {
        public int Id;
        public string Nome;
        public decimal Preco;
    }
    class Listas
    {
        public Listas() { }

        public List<Produto> Lista_produtos = new List<Produto>
        {
            new Produto {Id = 1, Nome = "Café", Preco = 2.5m},
            new Produto {Id = 2, Nome = "Pão", Preco = 4.0m},
            new Produto {Id = 3, Nome = "Leite", Preco = 3.0m},
            new Produto {Id = 4, Nome = "Cereal", Preco = 5.5m},
            new Produto {Id = 5, Nome = "Frutas", Preco = 6.8m},
            new Produto {Id = 6, Nome = "Iogurte", Preco = 3.2m},
            new Produto {Id = 7, Nome = "Ovos", Preco = 7.5m},
            new Produto {Id = 8, Nome = "Queijo", Preco = 5.0m},
            new Produto {Id = 9, Nome = "Manteiga", Preco = 2.0m},
            new Produto {Id = 10, Nome = "Geleia", Preco = 4.5m},
            new Produto {Id = 11, Nome = "Croissant", Preco = 3.8m},
            new Produto {Id = 12, Nome = "Suco de Laranja", Preco = 4.9m},
            new Produto {Id = 13, Nome = "Panquecas", Preco = 6.2m},
            new Produto {Id = 14, Nome = "Granola", Preco = 5.7m},
            new Produto {Id = 15, Nome = "Café com Leite", Preco = 3.7m},
            new Produto {Id = 16, Nome = "Waffles", Preco = 4.5m},
            new Produto {Id = 17, Nome = "Torrada", Preco = 2.0m},
            new Produto {Id = 18, Nome = "Presunto", Preco = 5.3m},
            new Produto {Id = 19, Nome = "Cappuccino", Preco = 4.2m},
            new Produto {Id = 20, Nome = "Smoothie", Preco = 6.5m},
            new Produto {Id = 21, Nome = "Bolo de Café", Preco = 8.0m},
            new Produto {Id = 22, Nome = "Cuscuz", Preco = 3.4m},
            new Produto {Id = 23, Nome = "Muffin", Preco = 2.8m},
            new Produto {Id = 24, Nome = "Aveia", Preco = 4.3m},
            new Produto {Id = 25, Nome = "Sanduíche de Bacon e Ovo", Preco = 7.8m},
            new Produto {Id = 26, Nome = "Chá", Preco = 2.3m},
            new Produto {Id = 27, Nome = "Batata Doce Assada", Preco = 5.1m},
            new Produto {Id = 28, Nome = "Mel", Preco = 3.5m},
            new Produto {Id = 29, Nome = "Salada de Frutas", Preco = 6.0m},
            new Produto {Id = 30, Nome = "Pão de Banana", Preco = 4.7m}
        };

        public List<Produto> Lista_cesta = new List<Produto>
        {
            
        };

        public List<Produto> Lista_natal = new List<Produto>
        {
            new Produto {Id = 4, Nome = "Cereal", Preco = 5.5m},
            new Produto {Id = 5, Nome = "Frutas", Preco = 6.8m},
            new Produto {Id = 6, Nome = "Iogurte", Preco = 3.2m},
            new Produto {Id = 7, Nome = "Ovos", Preco = 7.5m},
            new Produto {Id = 8, Nome = "Queijo", Preco = 5.0m},
            new Produto {Id = 9, Nome = "Manteiga", Preco = 2.0m},
            new Produto {Id = 10, Nome = "Geleia", Preco = 4.5m},
            new Produto {Id = 11, Nome = "Croissant", Preco = 3.8m},
        };

        public List<Produto> Lista_pais = new List<Produto>
        {
            new Produto {Id = 19, Nome = "Cappuccino", Preco = 4.2m},
            new Produto {Id = 2, Nome = "Pão", Preco = 4.0m},
            new Produto {Id = 23, Nome = "Muffin", Preco = 2.8m},
            new Produto {Id = 5, Nome = "Frutas", Preco = 6.8m},
        };

        public List<Produto> Lista_maes = new List<Produto>
        {
            new Produto {Id = 21, Nome = "Bolo de Café", Preco = 8.0m},
            new Produto {Id = 22, Nome = "Cuscuz", Preco = 3.4m},
            new Produto {Id = 23, Nome = "Muffin", Preco = 2.8m},
            new Produto {Id = 24, Nome = "Aveia", Preco = 4.3m},
            new Produto {Id = 25, Nome = "Sanduíche de Bacon e Ovo", Preco = 7.8m},
            new Produto {Id = 26, Nome = "Chá", Preco = 2.3m},
            new Produto {Id = 27, Nome = "Batata Doce Assada", Preco = 5.1m},
            new Produto {Id = 28, Nome = "Mel", Preco = 3.5m},
        };

        public List<Produto> Lista_namorados = new List<Produto>
        {
            new Produto {Id = 19, Nome = "Cappuccino", Preco = 4.2m},
            new Produto {Id = 20, Nome = "Smoothie", Preco = 6.5m},
            new Produto {Id = 21, Nome = "Bolo de Café", Preco = 8.0m},
            new Produto {Id = 22, Nome = "Cuscuz", Preco = 3.4m},
            new Produto {Id = 23, Nome = "Muffin", Preco = 2.8m},
            new Produto {Id = 24, Nome = "Aveia", Preco = 4.3m},
        };

        public List<Produto> Lista_aniversario = new List<Produto>
        {
            new Produto {Id = 1, Nome = "Café", Preco = 2.5m},
            new Produto {Id = 2, Nome = "Pão", Preco = 4.0m},
            new Produto {Id = 3, Nome = "Leite", Preco = 3.0m},
            new Produto {Id = 4, Nome = "Cereal", Preco = 5.5m},
            new Produto {Id = 5, Nome = "Frutas", Preco = 6.8m},
            new Produto {Id = 6, Nome = "Iogurte", Preco = 3.2m},
            new Produto {Id = 7, Nome = "Ovos", Preco = 7.5m},
            new Produto {Id = 8, Nome = "Queijo", Preco = 5.0m},
            new Produto {Id = 9, Nome = "Manteiga", Preco = 2.0m}
        };

    }
}
