using System;
using System.Collections.Generic;
using System.Text;

namespace Everson_Menezes
{
    class Pedido
    {
        public int Id { get; set; }
        public List<Produto> Produtos = new List<Produto>();
        public double Valor { get; set; }
        public Pedido()
        {

        }

        public Pedido(List<Produto> produtos, double valor)
        {
            Produtos = produtos;
            Valor = valor;
        }

        public Pedido(int id, List<Produto> produtos)
        {
            Id = id;
            Produtos = produtos;
        }
        public double CalcularValorPedido(Pedido pedido)
        {
            foreach(var obj in Produtos)
            {
                Valor += obj.Preco;
            }
            return Valor;
        }
        public double FazerPedido(Pedido pedido)
        {
            return CalcularValorPedido(pedido);

        }
        public void AdicionaProduto(Produto item)
        {

            Produtos.Add(item);
        }
    }
}
