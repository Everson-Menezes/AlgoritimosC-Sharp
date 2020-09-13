using System;
using System.Collections.Generic;
using System.Text;

namespace Everson_Menezes
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public static List<Produto> ExibirProdutos()
        {
            return new List<Produto> 
            {
                new Produto
                {
                    Id = 1,
                    Nome = "lanche de carne",
                    Preco = 20.0
                },
                new Produto
                {
                    Id = 2,
                    Nome = "lanche de frango",
                    Preco = 16.0
                },
                new Produto
                {
                    Id = 3,
                    Nome = "batata frita",
                    Preco = 6.0
                },
                new Produto
                {
                    Id = 4,
                    Nome = "refrigerante",
                    Preco = 4.0
                },
                new Produto
                {
                    Id = 5,
                    Nome = "salada",
                    Preco = 2.0
                },
                new Produto
                {
                    Id = 6,
                    Nome = "maionese",
                    Preco = 1.0
                }
             };
        }        
    }
}
